# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

This repository contains Ultra-Wide Fixes for Unity-based games. The project consists of multiple independent game-specific modifications that provide ultrawide monitor support, field-of-view fixes, HUD adjustments, and various quality-of-life improvements for games that don't natively support ultrawide resolutions.

## Repository Structure

- `src/` - Contains individual game fix projects, each in its own subdirectory
- Each game directory contains:
  - A Visual Studio solution (.sln) file
  - A C# project (.csproj) file configured for BepInEx plugins
  - `Patches/` - Harmony patches for game modification
  - `Helpers/` - Utility classes for common functionality
  - `libs/` - Game-specific Unity assemblies and dependencies

## Build System

### Building Individual Projects

Each game fix is a separate C# project that builds to a BepInEx plugin:

```bash
# Build a specific project from its directory
dotnet build src/[GameName]/[GameName].sln --configuration Release

# Example:
dotnet build src/TheHouseOfTheDead2Remake/TheHouseOfTheDead2Remake.sln --configuration Release
```

### Project Configuration

All projects are configured with:
- Target framework: `netstandard2.1`
- BepInEx as the primary dependency
- Output path typically set to the game's BepInEx plugins folder
- Package references to BepInEx.Core and ConfigurationManager

### Common Build Targets

- **Release**: Optimized builds for distribution
- **Debug**: Development builds with additional logging and test features

## Architecture Patterns

### Core Components

1. **Plugin.cs** - Main plugin entry point that:
   - Inherits from `BaseUnityPlugin`
   - Defines configuration entries using BepInEx's config system
   - Sets up Harmony patches on Awake()
   - Manages scene loading events and display updates

2. **Patches/Patches.cs** - Harmony patches that:
   - Modify game behavior at runtime
   - Override quality settings, camera behavior, UI scaling
   - Implement ultrawide-specific fixes for cameras, HUD, and videos

3. **Helpers/** - Utility classes providing:
   - `Resolutions.cs` - Resolution detection and management
   - `HudLayout.cs` - UI element positioning and scaling
   - `Cameras.cs` - Camera field-of-view and aspect ratio handling
   - `Volumes.cs` - Post-processing volume management
   - `QualSettings.cs` - Graphics quality overrides

### Common Functionality Patterns

#### Resolution Management
- Detect available resolutions from Unity's Screen.resolutions
- Support custom refresh rates when Unity reports incorrectly
- Merge and validate resolution lists with refresh rate data

#### UI Scaling Strategy
- Use AspectRatioFitter components for maintaining proper UI proportions
- Apply different scaling modes based on aspect ratio detection
- Implement LayoutController for game-specific UI adjustments

#### Camera Modifications
- Override camera gateFit modes for proper ultrawide rendering
- Adjust field-of-view calculations for different aspect ratios
- Handle Cinemachine camera state modifications

#### Configuration System
- Extensive use of BepInEx ConfigEntry system
- Organized into logical sections (Display, UI, Camera, Graphics, etc.)
- Real-time configuration updates with immediate application

## Development Workflow

### Adding New Game Support

1. Create new directory under `src/[GameName]/`
2. Copy and adapt a similar game's project structure
3. Update .csproj with game-specific assembly references in `libs/`
4. Implement game-specific patches in `Patches/Patches.cs`
5. Adapt helper classes for game's specific requirements
6. Test with various ultrawide resolutions and aspect ratios

### Key Implementation Areas

- **Harmony Patches**: Focus on CanvasScaler, Camera, QualitySettings, and game-specific UI classes
- **Configuration**: Provide comprehensive options for resolution, aspect ratio, and quality settings
- **UI Handling**: Implement proper scaling for HUD elements, menus, and overlays
- **Video Playback**: Ensure cutscenes and videos maintain proper aspect ratios

### Common Debugging Approaches

- Use `Plugin.Log.LogInfo/LogWarning` for runtime debugging
- Implement debug-only configuration options for testing specific aspect ratios
- Monitor camera and canvas scaler changes through logged state transitions

## Game-Specific Considerations

Each game fix addresses unique challenges:

- **UI Systems**: Different games use various UI frameworks (NGUI, Unity UI, custom systems)
- **Camera Management**: Some games use Cinemachine, others use custom camera controllers  
- **Post-Processing**: HDRP, URP, or built-in render pipeline specific volume handling
- **Video Playback**: Game-specific video player implementations requiring aspect ratio fixes

## Testing

Test each fix across multiple ultrawide resolutions:
- 21:9 (2560x1080, 3440x1440)
- 32:9 (3840x1080, 5120x1440) 
- 32:10 (3840x1200)
- Various custom resolutions

Verify:
- Proper camera field-of-view scaling
- UI element positioning and readability
- Video playback aspect ratios
- Post-processing effect coverage
- Performance impact of modifications

## Distribution

Each project builds directly to the game's BepInEx plugins folder for easy testing and distribution. The BepInEx framework handles plugin loading and Harmony patch application automatically.