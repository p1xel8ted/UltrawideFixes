use std::io::Read;
use std::io::Write;
use std::path::PathBuf;
use dialoguer::{Select, theme::ColorfulTheme};
use dialoguer::console::Term;
use hex_literal::hex;
use indicatif::{ProgressBar, ProgressStyle};
use spinners::Spinner;
use spinners::Spinners::Dots9;

#[derive(Clone)]
struct EngineRatio {
    name: String,
    hex: [u8; 4],
    height: f32,
    width: f32,
}

fn main() {
    println!("Nier Replicant Ultra-Wide + ReShade + SpecialK (High Frame Rate) AIO 1.2");
    println!("It is recommended to use this tool on a clean installation of Nier Replicant.");

    let game_path = match detect_game_location() {
        Ok(path) => path,
        Err(err) => {
            println!("{}", err);
            return;
        }
    };

    println!("Found game at {:?}!", &game_path);

    backup(&game_path);

    let ratio = match ratio_select() {
        Ok(ratio) => ratio,
        Err(err) => {
            println!("{}", err);
            return;
        }
    };

    println!("Selected ratio: {}", ratio.name);

    patch_aspect_ratio(&game_path, &ratio);

    correct_position(&game_path, &ratio);

    fix_ui_scaling(&game_path, &ratio);

    println!("Successfully patched and installed! Have Fun!");

    println!("All credits go to u/helifax19 for finding this method, and PineappleIOnic for the original version of this tool!");

    println!("Press enter to exit...");

    std::io::stdin().read_line(&mut String::new()).unwrap();
}

fn fix_ui_scaling(game_path: &PathBuf, ratio: &EngineRatio) {
    println!("This task downloads files from github they can be found here: https://github.com/p1xel8ted/UltrawideFixes/tree/main/src/NierReplicant/PatchContent");

    let source =
        "https://github.com/p1xel8ted/UltrawideFixes/blob/main/src/NierReplicant/PatchContent/";

    let download_list = vec![
        "ShaderFixes/0a2c2125f4a421a5-vs_replace.txt",
        "ShaderFixes/3dvision2sbs_sli_downscale_pass1.hlsl",
        "ShaderFixes/3dvision2sbs_sli_downscale_pass2.hlsl",
        "ShaderFixes/3dvision2sbs.hlsl",
        "ShaderFixes/3dvision2sbs.ini",
        "ShaderFixes/dc88834b3469cba8-vs_replace.txt",
        "ShaderFixes/mouse.hlsl",
        "ShaderFixes/mouse.ini",
        "ShaderFixes/upscale.hlsl",
        "ShaderFixes/upscale.ini",
        "3Dmigoto64.dll",
        "d3dcompiler_46.dll",
        "d3dx.ini",
        "dxgi.dll",
        "dxgi.ini",
        "ReShade.ini",
        "ReShade64.dll",
    ];

    // Ensure necessary directories exist
    let dirs_to_create = vec![
        "Mods",
        "ReplacementTextures",
        "reshade-shaders/Shaders",
        "reshade-shaders/Textures",
        "ShaderFixes",
    ];

    for dir in dirs_to_create {
        let full_path = game_path.join(dir);
        if !full_path.exists() {
            if let Err(e) = std::fs::create_dir_all(&full_path) {
                eprintln!("Failed to create directory {}: {}", full_path.display(), e);
                return;
            }
        }
    }

    let style = ProgressStyle::default_bar()
        .template(
            "{msg} {spinner:.green} [{elapsed}] [{bar:40.cyan/blue}] {bytes}/{total_bytes} ({eta})",
        )
        .unwrap()
        .progress_chars("#>-");

    let mut skipped = false;

    for file in download_list {
        let url = format!("{}{}?raw=true", source, file);
        let response = match ureq::get(&url).call() {
            Ok(res) => res,
            Err(e) => {
                eprintln!("Failed to download {}: {}", file, e);
                skipped = true;
                continue;
            }
        };

        let content_length = response
            .header("Content-Length")
            .and_then(|s| s.parse::<u64>().ok())
            .unwrap_or_default();

        let pb = ProgressBar::new(content_length);
        pb.set_style(style.clone()); 
        pb.set_message(format!("Downloading {}", file));
        let mut bytes: Vec<u8> = Vec::with_capacity(content_length as usize);
        let mut reader = response.into_reader();
        let mut buffer = [0; 128 * 1024]; 
        while let Ok(len) = reader.read(&mut buffer) {
            if len == 0 {
                break;
            }
            bytes.extend_from_slice(&buffer[..len]);
            pb.inc(len as u64);
        }
        pb.finish_with_message(format!("Downloaded {}", file));

        let file_path = game_path.join(file);
        let mut file = match std::fs::File::create(&file_path) {
            Ok(f) => f,
            Err(err) => {
                eprintln!("Failed to create file {}: {}", file_path.display(), err);
                skipped = true;
                continue; 
            }
        };

        if let Err(err) = file.write_all(&bytes) {
            eprintln!("Failed to write to {}: {}", file_path.display(), err);
            skipped = true;
            continue;
        }
    }

    if skipped {
        println!("Some files failed to download/save. Please download them manually from the link above and place them in the game directory.");
    } else {
        println!("All files downloaded!");
    }

    println!("Updating configuration files...");

    update_config(
        game_path
            .clone()
            .join("ShaderFixes/0a2c2125f4a421a5-vs_replace.txt"),
        &ratio,
    );
    update_config(
        game_path
            .clone()
            .join("ShaderFixes/dc88834b3469cba8-vs_replace.txt"),
        &ratio,
    );
}

fn update_config(config_path: PathBuf, ratio: &EngineRatio) {
    let mut config = match std::fs::File::open(&config_path) {
        Ok(file) => file,
        Err(err) => {
            println!("{}", err);
            return;
        }
    };

    // Read as text
    let mut config_text = String::new();
    match config.read_to_string(&mut config_text) {
        Ok(_) => (),
        Err(err) => {
            println!("{}", err);
            return;
        }
    };
    
    let config_text = config_text.replace(
        "float new_aspect_width = 32.0",
        &format!("float new_aspect_width = {}", &ratio.width.to_string()),
    );
    let config_text = config_text.replace(
        "float new_aspect_height = 9.0",
        &format!("float new_aspect_height = {}", &ratio.height.to_string()),
    );
    
    let mut config = match std::fs::File::create(&config_path) {
        Ok(file) => file,
        Err(err) => {
            println!("{}", err);
            return;
        }
    };

    match config.write_all(config_text.as_bytes()) {
        Ok(_) => (),
        Err(err) => {
            println!("{}", err);
            return;
        }
    };

    println!(
        "Successfully updated the configuration of {}",
        config_path.to_str().unwrap()
    );
}

fn patch_aspect_ratio(game_dir_path: &PathBuf, ratio: &EngineRatio) {

    let mut sp = Spinner::new(Dots9, "Patching Aspect Ratio".into());

    let mut game_path = game_dir_path.clone();
    game_path.push("NieR Replicant ver.1.22474487139.exe");

    // Load game executable into a buffer
    let mut game_exe_file = std::fs::File::open(&game_path).unwrap();

    // Update all instances of old game's ratio
    let original_ratio = hex!("39 8E E3 3F");

    let new_ratio = ratio.hex;

    let mut buffer: Vec<u8> = Vec::new();
    let length = game_exe_file.read_to_end(&mut buffer).unwrap();

    for i in 0..length {
        if (i + 4) > length {
            break;
        }
        if buffer[i..i + 4] == original_ratio {
            buffer[i..i + 4].clone_from_slice(&new_ratio);
        }
    }

    // Write patched executable to disk
    let mut patched_exec_file = std::fs::File::create(&game_path).unwrap();

    patched_exec_file.write_all(&buffer).unwrap();

    sp.stop();

    println!(" Done!");
}

fn correct_position(game_dir_path: &PathBuf, ratio: &EngineRatio) {
 
    let mut sp = Spinner::new(Dots9, "Removing Black Bars".into());

    let mut game_path = game_dir_path.clone();
    game_path.push("NieR Replicant ver.1.22474487139.exe");

    // Load game executable into a buffer
    let mut game_exe_file = std::fs::File::open(&game_path).unwrap();

    // Update all instances of old game's ratio
    let original_ratio = hex!("00 00 10 41 00 00 50 41 00 00 80 41 00 00 00 00");

    let mut new_ratio = original_ratio.clone();
    new_ratio[0..4].clone_from_slice(&ratio.height.to_le_bytes());
    new_ratio[8..12].clone_from_slice(&ratio.width.to_le_bytes());

    let mut buffer: Vec<u8> = Vec::new();
    let length = game_exe_file.read_to_end(&mut buffer).unwrap();

    for i in 0..length {
        if (i + 16) > length {
            break;
        }
        if buffer[i..i + 16] == original_ratio {
            buffer[i..i + 16].clone_from_slice(&new_ratio);
        }
    }

    // Write patched executable to disk
    let mut patched_exec_file = std::fs::File::create(&game_path).unwrap();

    patched_exec_file.write_all(&buffer).unwrap();

    sp.stop();
    println!(" Done!");
}

fn ratio_select() -> Result<EngineRatio, std::io::Error> {
    println!("Select your display ratio:");

    let common_ratios = vec![
        EngineRatio {
            name: "1.85:1".into(),
            hex: hex!("CD CC EC 3F"),
            width: 1.85,
            height: 1.0,
        },
        EngineRatio {
            name: "2.39:1".into(),
            hex: hex!("C3 F5 18 40"),
            width: 2.39,
            height: 1.0,
        },
        EngineRatio {
            name: "2.76:1".into(),
            hex: hex!("D7 A3 30 40"),
            width: 2.76,
            height: 1.0,
        },
        EngineRatio {
            name: "4:3".into(),
            hex: hex!("AB AA AA 3F"),
            width: 4.0,
            height: 3.0,
        },
        EngineRatio {
            name: "3:2".into(),
            hex: hex!("00 00 C0 3F"),
            width: 3.0,
            height: 2.0,
        },
        EngineRatio {
            name: "5:4".into(),
            hex: hex!("00 00 A0 3F"),
            width: 5.0,
            height: 4.0,
        },
        EngineRatio {
            name: "12:3".into(),
            hex: hex!("00 00 80 40"),
            width: 12.0,
            height: 3.0,
        },
        EngineRatio {
            name: "15:4".into(),
            hex: hex!("00 00 70 40"),
            width: 15.0,
            height: 4.0,
        },
        EngineRatio {
            name: "15:9".into(),
            hex: hex!("55 55 D5 3F"),
            width: 15.0,
            height: 9.0,
        },
        EngineRatio {
            name: "16:10".into(),
            hex: hex!("CD CC CC 3F"),
            width: 16.0,
            height: 10.0,
        },
        EngineRatio {
            name: "21:9 (2560x1080)".into(),
            hex: hex!("26 B4 17 40"),
            width: 21.5, //this is intentional
            height: 9.0,
        },
        
        EngineRatio {
            name: "21:9 (3440x1440)".into(),
            hex: hex!("8E E3 18 40"),
            width: 21.5, //this is intentional
            height: 9.0,
        },
        EngineRatio {
            name: "21:9 (3840x1600)".into(),
            hex: hex!("9A 99 19 40"),
            width: 21.5, //this is intentional
            height: 9.0,
        },
        EngineRatio {
            name: "32:10".into(),
            hex: hex!("CD CC 4C 40"),
            width: 32.0,
            height: 10.0,
        },
        EngineRatio {
            name: "32:9".into(),
            hex: hex!("39 8E 63 40"),
            width: 32.0,
            height: 9.0,
        },
        EngineRatio {
            name: "48:10".into(),
            hex: hex!("9A 99 99 40"),
            width: 48.0, // 3 times 16
            height: 10.0,
        },
        EngineRatio {
            name: "45:9".into(),
            hex: hex!("00 00 A0 40"),
            width: 45.0, // 3 times 15
            height: 9.0,
        },
        EngineRatio {
            name: "48:9".into(),
            hex: hex!("AB AA AA 40"),
            width: 48.0, // 3 times 16
            height: 9.0,
        },
    ];

    // Create array with only the names
    let mut names = Vec::new();
    for ratio in common_ratios.clone() {
        names.push(ratio.name);
    }

    names.push("Custom".into());

    let selection;

    loop {
        let buffer = Select::with_theme(&ColorfulTheme::default())
            .items(&names)
            .default(0)
            .interact_on_opt(&Term::stderr())?;

        if buffer.is_some() {
            selection = buffer.unwrap();
            break;
        }

        println!("Please select a ratio.");
    }

    if selection == common_ratios.len() {
        // Start creating a custom ratio.
        println!("Please enter the width and height of your display in pixels.");

        let mut width = String::new();
        let mut height = String::new();

        loop {
            print!("Width: ");
            std::io::stdout().flush().unwrap();
            std::io::stdin().read_line(&mut width).unwrap();

            print!("Height: ");
            std::io::stdout().flush().unwrap();
            std::io::stdin().read_line(&mut height).unwrap();

            if width.trim().parse::<f32>().is_ok() && height.trim().parse::<f32>().is_ok() {
                break;
            }

            println!("Please enter a valid number.");
        }

        let mut width = width.trim().parse::<f32>().unwrap();
        let mut height = height.trim().parse::<f32>().unwrap();

        // Calculate GCD
        let gcd = gcd(width, height);
        width = width / gcd;
        height = height / gcd;

        println!("Estimated ratio: {}:{}", width, height);
        println!("Please confirm this is the correct ratio. [y/n]");

        let mut buffer = String::new();
        if std::io::stdin().read_line(&mut buffer).is_err() {
            eprintln!("Error reading input.");
            return Err(std::io::Error::new(
                std::io::ErrorKind::InvalidInput,
                "Error reading input.",
            ));
        }

        if buffer.trim() != "y" {
            println!("Please manually type your ratio.");

            let mut width_string: String = String::new();
            let mut height_string: String = String::new();

            loop {
                print!("Ratio Width: ");
                std::io::stdout().flush().unwrap();
                std::io::stdin().read_line(&mut width_string).unwrap();

                print!("Ratio Height: ");
                std::io::stdout().flush().unwrap();
                std::io::stdin().read_line(&mut height_string).unwrap();

                if width_string.trim().parse::<f32>().is_ok()
                    && height_string.trim().parse::<f32>().is_ok()
                {
                    break;
                }

                println!("Please enter a valid number.");
            }

            width = width_string.trim().parse::<f32>().unwrap();
            height = height_string.trim().parse::<f32>().unwrap();
        }

        let hex: f32 = (width / height).log2();

        // Create ratio
        return Ok(EngineRatio {
            name: format!("Custom ({}:{})", width, height).into(),
            hex: hex.to_le_bytes(),
            height,
            width,
        });
    }

    Ok(common_ratios[selection].clone())
}

fn gcd(first: f32, second: f32) -> f32 {
    let mut max = first;
    let mut min = second;
    if min > max {
        let val = max;
        max = min;
        min = val;
    }

    loop {
        let res = max % min;
        if res == 0.0 {
            return min;
        }

        max = min;
        min = res;
    }
}

fn backup(game_path: &PathBuf) {
    let mut backup_path = game_path.clone();
    backup_path.push("NieR Replicant ver.1.22474487139.exe.bak");

    let mut game_path = game_path.clone();
    game_path.push("NieR Replicant ver.1.22474487139.exe");

    if backup_path.exists() {
        println!("Restore original game backup for patching? (highly recommended) [y/n]");

        let mut buffer = String::new();
        if std::io::stdin().read_line(&mut buffer).is_err() {
            eprintln!("Error reading input.");
            return;
        }

        if buffer.trim() == "y" {
            std::fs::copy(&backup_path, &game_path).unwrap();
            println!("Successfully restored backup.");
        }

        return;
    }

    println!("Create a backup of the game? (y/n)");
    let mut backup = String::new();
    std::io::stdin().read_line(&mut backup).unwrap();
    if backup.trim() == "y" {
        println!("Creating backup...");

        std::fs::copy(game_path, &backup_path).unwrap();
        println!("Backup created at {:?}!", &backup_path);
    }
}

fn detect_game_location() -> Result<PathBuf, String> {
    let mut possible_paths = vec![
        PathBuf::from("./NieR Replicant ver.1.22474487139.exe"), // Current directory
        PathBuf::from("C:/Program Files (x86)/Steam/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("D:/Games/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("E:/Games/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("F:/Games/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("G:/Games/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("H:/Games/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("D:/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("E:/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("F:/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("G:/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
        PathBuf::from("H:/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"),
    ];

    // Attempt to include dynamic paths based on the user's home directory
    if let Some(home_dir) = dirs::home_dir() {
        possible_paths.push(home_dir.join(".steam/steam/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe")); // Steam Linux Directory
        possible_paths.push(home_dir.join(".local/share/Steam/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe"));
        // Another possible Linux directory
    }

    // Iterate over the possible paths and check if the game executable exists
    for path in possible_paths {
        if path.exists() {
            return Ok(path.parent().unwrap().to_path_buf());
        }
    }

    // If none of the predefined paths exist, ask the user to manually enter the path
    println!("Could not find the game executable automatically. Please enter the path manually:");
    let mut user_input = String::new();
    if std::io::stdin().read_line(&mut user_input).is_err() {
        return Err("Failed to read line".to_string());
    }
    let user_path = PathBuf::from(user_input.trim());
    if user_path.exists() {
        return Ok(user_path);
    }

    Err("Could not find the game executable".to_string())
}