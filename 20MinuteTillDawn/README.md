# 20 Minutes Till Dawn

![header](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/8ef884fa-a78d-43e5-bf14-ce69fea8f2a8)

Tested against retail Steam version @ 3440x1440.

## Features
- Overrides full screen to the main display resolution and enforces the appropriate aspect ratio.
- Resolution and full screen mode picker are disabled in the settings menu. 
- UI corrections, mostly related to the main menu, weapon selection screen and the fog in-game.

## Screenshots

![menu](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/bb279af8-5112-4df0-be1c-9ca4702febd0) ![char](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/1176576a-486f-45f7-b246-5edd465df243) ![gun](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/0d18d32a-fef7-4ac4-9554-b538eabf47d3) ![game](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/190dcead-2f39-4153-98ed-53c05cb65e75)

## Configuration
- Press F1 in game to open the UI.

![settings](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/7ccb1db5-0566-4aac-82f4-8bedebf308ab)

## Installation
- Grab the latest release from [here](https://github.com/p1xel8ted/UltrawideFixes/releases/tag/20MinuteTillDawn). Windows and MacOS/Unix versions have been made available.
- Extract the contents of the release zip into the game directory. <br /> (e.g. **`steamapps\common\20MinuteTillDawn** for Steam on Windows).

## Steam Deck/Linux Additional Instructions
🚩**You do not need to do this if you are using Windows!**
- Open up the game properties in Steam and add `WINEDLLOVERRIDES="winmm=n,b" %command%` to the launch options.

## Changes

`0.1.3` - 3rd April 2024
- Adding screen-mode configuration.
- Fixed Display change action

`0.1.2` - 2nd April 2024
- Fog scaling is dynamically adjusted based on the resolution instead of being a hard-coded value.
- Character portraits are now positioned dynamically based on the resolution instead of being a hard-coded value.
- The advertisement banner on the main menu is disabled.

`0.1.1` - 6th August 2023
- Fixed the character portrait overlaying weapons on the weapon selection screen.

`0.1.0` - ??
- Initial release.

## 🚩 Support
#### Please consider supporting the project! Your support helps keep the fixes coming (and maintained), improving the experience for all. Thank you for supporting the project!

## Credits
- [Bepis](https://github.com/bbepis) and team for [BepInEx](https://github.com/BepInEx/BepInEx).
- [ManlyMarco](https://github.com/ManlyMarco) for [ConfigurationManager](https://github.com/BepInEx/BepInEx.ConfigurationManager).
- [Sinai]() for [Unity Explorer](https://github.com/sinai-dev/UnityExplorer).
