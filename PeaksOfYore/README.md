### Peaks of Yore

![Game Logo](header.jpg)<br>

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F2F2DI3WA)<br>

## Note

- Includes ConfigManager for easy in-game config. HideGameManagerObject in `BepInEx.cfg` must be set to `TRUE` to function.

## Features
- Set whatever resolution and refresh rate (will also set the target framerate to this refresh rate) you want.
- Set whatever window mode you want.
- Open to override VSync options in-game (when set to off, Unity was reporting vsync was still on)
- Override the FixedUpdateRate to a multiple of your refresh rate to fix the awful camera judder (it's hardcoded to 50Hz by default). Be careful going too high if you play the game on a potato.
- Change the scale of the UI.

## Installation
- Grab the latest release from [here](https://github.com/p1xel8ted/UltrawideFixes/releases/tag/BlueOakBridge).
- Extract the contents of the release zip into the game directory.<br />(e.g. `**steamapps\common\SteamBuild**` for Steam).

## Configuration
- File located at `**steamapps\common\SteamBuild\BepInEx\config\p1xel8ted.blueoakbridge.displaytweaks.cfg**`
- Note your default values may look different to mine as their based off your own setup.
```## Settings file was created by plugin Blue Oak Bridge Display Tweaks v0.1.0
## Plugin GUID: p1xel8ted.blueoakbridge.displaytweaks

[1. UI]

## Change the scale of the UI
# Setting type: Boolean
# Default value: true
Change Scale = true

## Scale factor for the UI
# Setting type: Single
# Default value: 1
# Acceptable value range: From 0.5 to 2
Scale Factor = 0.8521128

[2. Display]

## Screen width
# Setting type: Int32
# Default value: 3440
Screen Width = 3440

## Screen height
# Setting type: Int32
# Default value: 1440
Screen Height = 1440

## Refresh rate for the game
# Setting type: Int32
# Default value: 120
Refresh Rate = 120

## Fixed Update Interval
# Setting type: Single
# Default value: 60
# Acceptable values: 60, 100, 120, 60.317, 60.004, 49.987, 59.973, 84.964
Fixed Update Interval = 120

## Full Screen Mode
# Setting type: String
# Default value: ExclusiveFullScreen
# Acceptable values: ExclusiveFullScreen, FullScreenWindow, MaximizedWindow, Windowed
Full Screen Mode = FullScreenWindow

## Toggle VSync (game setting doesn't always appear to work)
# Setting type: Boolean
# Default value: false
Vsync = false

## Apply Display Settings
# Setting type: Boolean
# Default value: true
Apply = true

[3. Camera]

## Current zoom level
# Setting type: Single
# Default value: 12
Current Zoom = 17.39994

## Minimum zoom level
# Setting type: Int32
# Default value: 16
# Acceptable value range: From 10 to 32
Max Zoom = 32

## Zoom speed
# Setting type: Int32
# Default value: 5
# Acceptable value range: From 1 to 10
Zoom Speed = 10

Min Zoom = 10
```