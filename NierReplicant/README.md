# Nier Replicant Ultrawide (3DMigoto, ReShade, SpecialK)

Follow the steps below to achieve ultra-wide support, high framerate and 16:9 HUD, as well as re-shade support.

## Prerequisites

Ensure you have administrative access to your game's installation directory, typically located in your Steam or game library folder.

## Installation Steps

### Step 1: Apply the Ultrawide Patch

1. Visit the [Nier Replicant Ultrawide Patcher GitHub page](https://github.com/PineappleIOnic/Nier-Replicant-Ultrawide-Patcher/).
2. Download and run the patcher, selecting your monitor's aspect ratio when prompted to adjust the game to your display.

### Step 2: Set Up Special K

1. Download the latest version of Special K from [Special K's website](https://www.special-k.info/).
2. Locate the `SpecialK64.dll` file in your download, rename it to `dxgi.dll`, and move it to your game's main installation folder.

### Step 3: Use Replicant's Little Helper

1. Download Replicant's Little Helper from [Nexus Mods](https://www.nexusmods.com/nierreplicant/mods/12?tab=files).
2. Extract all the files directly into the game's installation folder, overwriting files when prompted.
3. Find and open `custom_dxgi.ini`, copy all its contents.
4. Open `dxgi.ini` in the same directory, paste the copied contents into it, then delete `custom_dxgi.ini`.

### Step 4: Access Special K Menu

- In-game, press `Ctrl` + `Shift` + `Backspace` to open the Special K menu.
- Enable the "High FPS Fix" from the menu and adjust any other settings to your preference.

## Verifying the Installation

After completing the above steps, launch Nier Replicant. The game should now run with ultrawide support, framerate uncapped and the main game UI will remain at a 16:9 aspect ratio, but the gameplay will be adapted to your ultrawide screen.

## Credits

- **Nier Replicant Ultrawide Patcher**: Developed by [PineappleIOnic](https://github.com/PineappleIOnic).
- **Special K**: Created by Kaldaien. [Special K's website](https://www.special-k.info/).
- **Replicant's Little Helper**: Put together by [Merle / MerleWasTaken] and available on Nexus Mods.
