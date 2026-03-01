// GlobalUsings.cs — Global using directives (implicitly available in all .cs files)
// Originally authored by p1xel8ted
// Modified by Claude (inline comments)

global using System.Reflection;
global using System.Runtime.InteropServices;     // DllImport, Marshal (native P/Invoke for code cave patching)
global using BepInEx;
global using BepInEx.Configuration;
global using BepInEx.Logging; // ConfigEntry, ConfigDescription, AcceptableValueList
global using BepInEx.Unity.IL2CPP;                 // BasePlugin (IL2CPP entry point, not BaseUnityPlugin)
global using HarmonyLib;
global using Il2CppInterop.Runtime.Injection;
global using TalesOfBerseriaRemastered.MonoBehaviours;
global using TalesOfBerseriaRemastered.Utils;
global using TL; // Harmony patching framework
global using UnityEngine;
global using UnityEngine.Events;                   // UnityAction<Scene, LoadSceneMode> for scene callback
global using UnityEngine.SceneManagement;           // SceneManager.sceneLoaded (fires once — single-scene game)
