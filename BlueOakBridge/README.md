# Blue Oak Bridge

![header](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/310f14f1-3a68-425e-ac22-d30fbaf7707b)

Tested against retail Steam version @ 3440x1440.

## Features
- Overrides resolution and refresh rate to that of whichever display you have set in the configuration.
- Control fullscreen modes; defaults to Fullscreen Window.
- Override the physics update rate to a multiple of your refresh rate to fix the awful camera judder (it's hardcoded to 50Hz by default). Be careful going too high if you play the game on a potato.
- Change the scale of the UI.
- Menu background image is corrected based on 21:9 or 32:9. No action taken if less than 21:9.
- Control zoom levels, as the default is clearly designed for TV use.

## Screenshots

![release_menu](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/e41277f4-eec5-4dc9-8fb0-6d50d8056a6f) ![release_game](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/c36c37c9-0005-4610-a8c8-c1abfd9854ad)

## Configuration
- Press F1 in game to open the UI.

![settings](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/c5bee9f3-7f81-4c73-a05e-166479aee29e)

## Installation
- Grab the latest release from [here](https://github.com/p1xel8ted/UltrawideFixes/releases/tag/BlueOakBridge). Windows and MacOS/Unix versions have been made available.
- Extract the contents of the release zip into the game directory.<br />(e.g. **`steamapps\common\SteamBuild`** for Steam on Windows).

### Steam Deck/Linux Additional Instructions
🚩**You do not need to do this if you are using Windows!**
- Open up the game properties in Steam and add `WINEDLLOVERRIDES="winmm=n,b" %command%` to the launch options.

## Changes

`0.1.1` - 7th April 2024
- Implemented main menu background image overrides.
- General clean up and code improvements.
- Fixed UI scaling and zooming not working as intended.

`0.1.0` - 7th August 2023
- Initial release.

 ## 🚩 Support
#### Please consider supporting the project! Your support helps keep the fixes coming (and maintained), improving the experience for all. Thank you for supporting the project!

[![ko-fi](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/bf2d4fb0-2249-4193-92df-5de01bf40cbf)](https://ko-fi.com/F2F2DI3WA) [![patreon](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/d66993ee-153f-483f-aec8-6cde5f84d497)](https://www.patreon.com/p1xel8ted) [![bitcoin](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/e7c3afc3-43f6-42af-9acc-5a2d7f4a8d50)](https://github.com/p1xel8ted/UltrawideFixes/blob/main/donations/README.md) [![ethereum](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/00a10334-602e-4d5d-b186-96e716f02dc8)](https://github.com/p1xel8ted/UltrawideFixes/blob/main/donations/README.md)

## Credits
- [Bepis](https://github.com/bbepis) and team for [BepInEx](https://github.com/BepInEx/BepInEx).
- [ManlyMarco](https://github.com/ManlyMarco) for [ConfigurationManager](https://github.com/BepInEx/BepInEx.ConfigurationManager).
- [Sinai]() for [Unity Explorer](https://github.com/sinai-dev/UnityExplorer).
