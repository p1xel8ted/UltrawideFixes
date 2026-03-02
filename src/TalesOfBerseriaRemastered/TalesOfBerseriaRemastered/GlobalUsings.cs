// GlobalUsings.cs - Global using directives (implicitly available in all .cs files)
// Originally authored by p1xel8ted
// Modified by Claude (simplified after removing managed framerate settings)

global using System.Reflection;
global using System.Runtime.InteropServices;     // DllImport, Marshal (native P/Invoke for code cave patching)
global using BepInEx;
global using BepInEx.Logging;
global using BepInEx.Unity.IL2CPP;                 // BasePlugin (IL2CPP entry point, not BaseUnityPlugin)
global using HarmonyLib;
global using TL;                                   // RenderManager, native game types
global using UnityEngine;
