// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public static class ScriptableRuntimeReflectionSystemSettings : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Instance;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0;

  static ScriptableRuntimeReflectionSystemSettings()
  {
    Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", nameof (ScriptableRuntimeReflectionSystemSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr);
    ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, nameof (s_Instance));
    ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100670742);
    ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100670743);
    ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemSettings>.NativeClassPtr, 100670744);
  }

  public static unsafe IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489666, XrefRangeEnd = 489680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_set_Internal_ScriptableRuntimeReflectionSystemSettings_system_Private_Static_set_Void_IScriptableRuntimeReflectionSystem_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => ScriptableRuntimeReflectionSystemSettings.s_Instance.implementation;
  }

  public static unsafe ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489680, XrefRangeEnd = 489684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_get_Internal_ScriptableRuntimeReflectionSystemSettings_instance_Private_Static_get_ScriptableRuntimeReflectionSystemWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ScriptableRuntimeReflectionSystemWrapper) null : Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489684, XrefRangeEnd = 489692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ScriptingDirtyReflectionSystemInstance()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemSettings.NativeMethodInfoPtr_ScriptingDirtyReflectionSystemInstance_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ScriptableRuntimeReflectionSystemSettings(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe ScriptableRuntimeReflectionSystemWrapper s_Instance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ScriptableRuntimeReflectionSystemWrapper) null : Il2CppObjectPool.Get<ScriptableRuntimeReflectionSystemWrapper>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScriptableRuntimeReflectionSystemSettings.NativeFieldInfoPtr_s_Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static IScriptableRuntimeReflectionSystem system
  {
    get
    {
      return ScriptableRuntimeReflectionSystemSettings.Internal_ScriptableRuntimeReflectionSystemSettings_system;
    }
    set => throw new System.NotSupportedException("Method unstripping failed");
  }
}
