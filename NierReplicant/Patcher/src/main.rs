use dialoguer::console::Term;
use dialoguer::{theme::ColorfulTheme, Select};
use dirs;
use hex_literal::{self, hex};
use spinners;
use spinners::{Spinner, Spinners};
use std::io::Read;
use std::io::Write;
use std::path::Path;
use std::path::PathBuf;

#[derive(Clone)]
struct EngineRatio {
    name: String,
    hex: [u8; 4],
    height: f32,
    width: f32,
}

fn main() {
    println!("Nier Replicant Ultra-Wide + ReShade + SpecialK (High Frame Rate) Patcher 1.0");
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
    println!("This task downloads files from github they can be found here: https://github.com/p1xel8ted/UltrawideFixes/tree/main/NierReplicant/PatchContent");

    let source = "https://github.com/p1xel8ted/UltrawideFixes/tree/main/NierReplicant/PatchContent";
    
    let download_list = vec![
        "Mods/empty.txt",
        "ReplacementTextures/empty.txt",
        "reshade-shaders/Shaders/empty.txt",
        "reshade-shaders/Textures/empty.txt",
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
        "d3d11.dll",
        "d3dcompiler_46.dll",
        "d3dx.ini",
        "dxgi.dll",
        "nvapi64.dll",
        "ReShade.ini",
        "ReShade64.dll",
    ];

    // Create ShaderFixes folder if it doesn't already exist.
    let shader_fixes_path = game_path.clone().join("ShaderFixes");
    if !shader_fixes_path.exists() {
        std::fs::create_dir_all(&shader_fixes_path).expect("Failed to create ShaderFixes folder");
    }

    // Start downloading files needed.
    for file in download_list {
        match ureq::get(&format!("{}{}?raw=true", source, file)).call() {
            Ok(res) => {
                let len = res
                    .header("Content-Length")
                    .and_then(|s| s.parse::<usize>().ok())
                    .unwrap();

                let mut bytes: Vec<u8> = Vec::with_capacity(len);
                match res.into_reader().take(10_000_000).read_to_end(&mut bytes) {
                    Ok(_) => (),
                    Err(err) => {
                        println!("{}", err);
                        return;
                    }
                };

                let mut file_path = game_path.clone();
                file_path.push(file);

                let mut file = match std::fs::File::create(&file_path) {
                    Ok(file) => file,
                    Err(err) => {
                        println!("{}", err);
                        return;
                    }
                };

                match file.write_all(&bytes) {
                    Ok(_) => {
                        println!("Downloaded {}", file_path.to_str().unwrap());
                    }
                    Err(err) => {
                        println!("{}", err);
                        return;
                    }
                }
            }
            Err(err) => {
                println!("{}", err);
                return;
            }
        };
    }

    println!("All files downloaded!");

    println!("Updating configuration files...");

    update_config(game_path.clone().join("ShaderFixes/0a2c2125f4a421a5-vs_replace.txt"), &ratio);
    update_config(game_path.clone().join("ShaderFixes/dc88834b3469cba8-vs_replace.txt"), &ratio);
}

fn update_config(config_path: PathBuf, ratio: &EngineRatio) {
    let mut config =
        match std::fs::File::open(&config_path) {
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

    // Replace the aspect ratios
    let config_text = config_text.replace(
        "float new_aspect_width = 32.0",
        &format!("float new_aspect_width = {}", &ratio.width.to_string()),
    );
    let config_text = config_text.replace(
        "float new_aspect_height = 9.0",
        &format!("float new_aspect_height = {}", &ratio.height.to_string()),
    );

    // Write back to file
    let mut config = match std::fs::File::create(
        &config_path,
    ) {
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

    println!("Successfully updated the configuration of {}", config_path.to_str().unwrap());
}

fn patch_aspect_ratio(game_dir_path: &PathBuf, ratio: &EngineRatio) {
    let sp = Spinner::new(&Spinners::Dots9, "Patching Aspect Ratio".into());

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
    let sp = Spinner::new(&Spinners::Dots9, "Removing Black Bars".into());

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
            name: "5:4".into(),
            hex: hex!("00 00 A0 3F"),
            width: 5.0,
            height: 4.0,
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
            name: "16:10".into(),
            hex: hex!("CD CC CC 3F"),
            width: 16.0,
            height: 10.0,
        },
        EngineRatio {
            name: "15:9".into(),
            hex: hex!("55 55 D5 3F"),
            width: 15.0,
            height: 9.0,
        },
        EngineRatio {
            name: "1.85:1".into(),
            hex: hex!("CD CC EC 3F"),
            width: 1.85,
            height: 1.0,
        },
        EngineRatio {
            name: "21:9 (2560x1080)".into(),
            hex: hex!("26 B4 17 40"),
            width: 21.0,
            height: 9.0,
        },
        EngineRatio {
            name: "21:9 (3440x1440)".into(),
            hex: hex!("8E E3 18 40"),
            width: 21.0,
            height: 9.0,
        },
        EngineRatio {
            name: "2.39:1".into(),
            hex: hex!("C3 F5 18 40"),
            width: 2.39,
            height: 1.0,
        },
        EngineRatio {
            name: "21:9 (3840x1600)".into(),
            hex: hex!("9A 99 19 40"),
            width: 21.0,
            height: 9.0,
        },
        EngineRatio {
            name: "2.76:1".into(),
            hex: hex!("D7 A3 30 40"),
            width: 2.76,
            height: 1.0,
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
            name: "3x5:4".into(),
            hex: hex!("00 00 70 40"),
            width: 15.0, // 3 times 5
            height: 4.0,
        },
        EngineRatio {
            name: "3x4:3".into(),
            hex: hex!("00 00 80 40"),
            width: 12.0, // 3 times 4
            height: 3.0,
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
        std::io::stdin().read_line(&mut buffer).unwrap();

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

                if width_string.trim().parse::<f32>().is_ok() && height_string.trim().parse::<f32>().is_ok() {
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
        })
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
        std::io::stdin().read_line(&mut buffer).unwrap();

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
    // Check if it's in the current directory
    if Path::new("NieR Replicant ver.1.22474487139.exe").exists() {
        return Ok(PathBuf::from("./"));
    }

    // Go through common directories

    // Steam Windows Directory
    if Path::new("C:/Program Files (x86)/Steam/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe").exists() {
        return Ok(PathBuf::from("C:/Program Files (x86)/Steam/steamapps/common/NieR Replicant ver.1.22474487139/"));
    }

    let home_dir = dirs::home_dir().unwrap();

    // Steam Linux Directory
    if Path::new(&format!("{}/.steam/steam/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe", home_dir.to_str().unwrap())).exists() {
        return Ok(PathBuf::from(format!("{}/.steam/steam/steamapps/common/NieR Replicant ver.1.22474487139/", home_dir.to_str().unwrap())));
    }

    // Another possible linux directory
    if Path::new(&format!("{}/.local/share/Steam/steamapps/common/NieR Replicant ver.1.22474487139/NieR Replicant ver.1.22474487139.exe", home_dir.to_str().unwrap())).exists() {
        return Ok(PathBuf::from(format!("{}/.local/share/Steam/steamapps/common/NieR Replicant ver.1.22474487139/", home_dir.to_str().unwrap())));
    }

    // Could not find the game executable automatically. Ask the user.
    println!("Could not find the game executable automatically. Please enter the path manually:");
    let mut path = String::new();
    std::io::stdin()
        .read_line(&mut path)
        .expect("Failed to read line");
    path = path.trim().to_string();

    if Path::new(&path).exists() {
        return Ok(PathBuf::from(path));
    }

    Err("Could not find the game executable".to_string())
}