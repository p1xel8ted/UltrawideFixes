# Nier Replicant Ultrawide (3DMigoto, ReShade, SpecialK)

Follow the steps below to achieve ultra-wide support, high framerate and 16:9 HUD, as well as re-shade support.

## Prerequisites

Ensure you have administrative access to your game's installation directory, typically located in your Steam or game library folder.

## Installation Steps

### Step 1: Apply the Ultrawide Patch

1. Visit the [Nier Replicant Ultrawide Patcher GitHub page](https://github.com/PineappleIOnic/Nier-Replicant-Ultrawide-Patcher/).
2. Download and extract `nier_ultrawide_patcher.exe` into your game directory so that it is alongside the main game exe `NieR Replicant ver.1.22474487139.exe`.
3. Run `nier_ultrawide_patcher.exe`, selecting your monitor's aspect ratio when prompted to adjust the game to your display.

### Step 2: Set Up Special K

1. Download the latest version of Special K from [Special K's website](https://www.special-k.info/). This is an installer version, and gets installed to `%localappdata%\Programs\Special K`.
   Alternativly, get the latest nightly from the [Special K Discord](https://discord.gg/specialk), #nightly-builds, (download `SpecialK.7z`, not `SKIF.exe`)
2. Locate the `SpecialK64.dll` file, and copy just that file into into your game directory so that it is alongside the main game exe `NieR Replicant ver.1.22474487139.exe`.
3. Rename `SpecialK64.dll` to `dxgi.dll`.

### Step 3: Use Replicant's Little Helper

1. Download Replicant's Little Helper from [Nexus Mods](https://www.nexusmods.com/nierreplicant/mods/12?tab=files).
2. Extract all the files directly into your game directory so that they are alongside the main game exe `NieR Replicant ver.1.22474487139.exe`, overwriting files when prompted.
3. Find and open `custom_dxgi.ini`, copy all its contents.
4. Open `dxgi.ini` in the same directory, paste the copied contents into it, then delete `custom_dxgi.ini`.

### Step 4: Final Steps

1. Run the game via Steam like normal.
2. In-game, press `Ctrl` + `Shift` + `Backspace` to open the Special K menu.
3. Enable the `High Dynamic Framerate` from the menu, and untick `Framerate limit`. Adjust any other settings to your preference.

## Verifying the Installation

After completing the above steps, launch Nier Replicant. The game should now run with ultrawide support, framerate uncapped and the main game UI will remain at a 16:9 aspect ratio, but the gameplay will be adapted to your ultrawide screen.

## Credits

- **Nier Replicant Ultrawide Patcher**: Developed by [PineappleIOnic](https://github.com/PineappleIOnic).
- **Special K**: Created by Kaldaien. [Special K's website](https://www.special-k.info/).
- **Replicant's Little Helper**: Put together by [Merle / MerleWasTaken] and available on Nexus Mods.
