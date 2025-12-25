// Global using directives
// These are automatically available in all C# files in the project without explicit using statements

// System namespaces
global using System;
global using System.Collections.Generic;
global using System.Diagnostics.CodeAnalysis;
global using System.Linq;

// Game-specific namespaces
global using Duckov.MiniMaps;        // Map marker system
global using Duckov.Modding.UI;      // Mod manager UI
global using Duckov.UI;              // Game UI components (MainMenu, PauseMenu, etc.)

// Third-party libraries
global using HarmonyLib;                              // Runtime patching framework
global using JetBrains.Annotations;                   // Code annotations (UsedImplicitly, etc.)
global using LeTai.Asset.TranslucentImage;            // Translucent image blur effects

// Unity namespaces
global using Unity.VisualScripting;   // Provides GetOrAddComponent extension method
global using UnityEngine;             // Core Unity engine
global using UnityEngine.UI;          // Unity UI components (Image, LayoutElement, etc.)

// Alias to disambiguate UnityEngine.Object from System.Object
global using Object = UnityEngine.Object;