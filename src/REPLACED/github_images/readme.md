<img width="460" height="215" alt="misc_header" src="https://github.com/user-attachments/assets/fa7c0f2b-c43d-4932-b2a9-29c7081b62ea" />

#### An super-ultra-wide solution for REPLACED
![GitHub release (by tag)](https://img.shields.io/github/downloads/p1xel8ted/UltrawideFixes/Replaced/total?label=downloads)

## Support
#### Please consider supporting this project! Your contributions help keep the fixes updated and maintained, improving the overall experience for everyone.

Thank you for your support!

[![ko-fi](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/bf2d4fb0-2249-4193-92df-5de01bf40cbf)](https://ko-fi.com/F2F2DI3WA)

## ❗Notes

- First run will take 20 to 30 seconds depending on your hardware.
- Startup may sit on `Chainloader Initialized` for a while — this appears to be random.
- Do not enable any Unity logging features in BepInEx or Doorstop.
- Do not update BepInEx beyond build 738 (not fully verified, but recommended).
- Alt-tabbing during a loading screen can crash the game, even in windowed mode.
- At aspect ratios wider than 21:9, culling issues occur; unlikely to be fixable via BepInEx.

## Features
Tested against Steam version @ 32:9, 48:9

- Resolution overridden to main display resolution
- UI centered where relevant
- Aspect ratio cap removed
- FOV controlled with PageDown/PageUp; Home to reset.
- Intro skipped

## Screenshots

Coming

## Configuration
No in-game configuration UI — edit the config file directly.

- Main HUD centering (toggle)

## Installation
- Grab the latest release from below.
- Extract the contents of the release zip into the game directory. (e.g. **`steamapps\common\REPLACED`** for Steam on Windows).

### Steam Deck/Linux/MacOS Additional Instructions
**You do not need to do this if you are using Windows!**
- Open up the game properties in Steam and add `WINEDLLOVERRIDES="winhttp=n,b" %command%` to the launch options.

## Changes

`0.1.0` - 2nd May 2026
- Initial release