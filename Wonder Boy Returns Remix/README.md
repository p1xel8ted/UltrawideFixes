## Wonder Boy Returns Remix 

![image](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/37e77b5e-ae9e-4e81-bdd6-bcc669cbf140)

Tested against retail Steam version @ 3440x1440.

## 🚩 Notes
- This game has really janky resolution control. I've forced it at an engine level and a game level, but it still renders at 1920x1080 (you can verify in SpecialK); but the aspect is still correct...
- If you force the resolution to your native resolution using SpecialK, the game black screens.

## Features
- Overrides full screen to the main display resolution and enforces the appropriate aspect ratio.
- UI corrections, mostly related to the main menu, and character/level select screens.
- Control camera zoom.
- Enabled ability to go backwards.

## Screenshots

![release_menu](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/bc0175db-c3c8-4130-84ea-e117c51b8870)  ![release_char](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/0584c3c2-0b61-4986-8631-276aa6fd3864) ![release_game](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/ca605a9f-6fa5-4cf2-a9f5-05310160624d)


## Configuration
- Press F1 in game to open the UI.

![image](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/d01e018a-3c74-488c-8bc5-e33eb0833eeb)

## Installation
- Grab the latest release from [here](https://github.com/p1xel8ted/UltrawideFixes/releases/tag/WonderBoyReturnsRemix). Windows and MacOS/Unix versions have been made available.
- Extract the contents of the release zip into the game directory. <br /> (e.g. **`steamapps\common\Wonder Boy Returns Remix** for Steam on Windows).

## Steam Deck/Linux Additional Instructions
🚩**You do not need to do this if you are using Windows!**
- Open up the game properties in Steam and add `WINEDLLOVERRIDES="winmm=n,b" %command%` to the launch options.

## Changes

`0.1.1` - 6th April 2024
- Corrected some UI backgrounds.
- General code cleanup.

`0.1.0` - 6th August 2023
- Initial release.

- ## Support

[![ko-fi](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/bf2d4fb0-2249-4193-92df-5de01bf40cbf)](https://ko-fi.com/F2F2DI3WA) [![patreon](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/d66993ee-153f-483f-aec8-6cde5f84d497)](https://www.patreon.com/p1xel8ted) [![bitcoin](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/e7c3afc3-43f6-42af-9acc-5a2d7f4a8d50)](https://github.com/p1xel8ted/UltrawideFixes/blob/main/donations/README.md) [![ethereum](https://github.com/p1xel8ted/UltrawideFixes/assets/10510767/00a10334-602e-4d5d-b186-96e716f02dc8)](https://github.com/p1xel8ted/UltrawideFixes/blob/main/donations/README.md)

## Credits
- [Bepis](https://github.com/bbepis) and team for [BepInEx](https://github.com/BepInEx/BepInEx).
- [ManlyMarco](https://github.com/ManlyMarco) for [ConfigurationManager](https://github.com/BepInEx/BepInEx.ConfigurationManager).
- [Sinai]() for [Unity Explorer](https://github.com/sinai-dev/UnityExplorer).
