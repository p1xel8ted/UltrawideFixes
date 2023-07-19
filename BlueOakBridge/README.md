### Blue Oak Bridge Display Tweaks

![Game Logo](header.jpg)<br>

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F2F2DI3WA)<br>
[![Github All Releases](https://img.shields.io/github/downloads/p1xel8ted/BlueOakBridge/total.svg)](https://github.com/p1xel8ted/BlueOakBridge/releases)

## Note

- Includes ConfigManager for easy in-game config. HideGameManagerObject in `BepInEx.cfg` must be set to `TRUE` for it to function.

## Features
- Set whatever resolution and refresh rate (will also set the target framerate to this refresh rate) you want.
- Set whatever window mode you want.
- Open to override VSync options in-game (when set to off, Unity was reporting vsync was still on)
- Change the scale of the UI.

## Installation
- Grab the latest Blue Oak Bridge Display Tweaks release from [here.](https://github.com/p1xel8ted/BlueOakBridge/releases)
- Extract the contents of the release zip into the game directory.<br />(e.g. `**steamapps\common\SteamBuild**` for Steam).

## Configuration
- File located at `**steamapps\common\SteamBuild\BepInEx\config\p1xel8ted.blueoakbridge.displaytweaks.cfg**`
```## Settings file was created by the plugin Blue Oak Bridge Display Tweaks v0.1.0
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
Scale Factor = 1

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

## Full Screen Mode
# Setting type: String
# Default value: ExclusiveFullScreen
# Acceptable values: ExclusiveFullScreen, FullScreenWindow, MaximizedWindow, Windowed
Full Screen Mode = ExclusiveFullScreen

## Vsync
# Setting type: Boolean
# Default value: false
Vsync = false`
