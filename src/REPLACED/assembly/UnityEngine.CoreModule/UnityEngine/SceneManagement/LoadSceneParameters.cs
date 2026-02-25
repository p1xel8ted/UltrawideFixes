// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.LoadSceneParameters
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.SceneManagement;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct LoadSceneParameters
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadSceneMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalPhysicsMode;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0;
  [FieldOffset(0)]
  public LoadSceneMode m_LoadSceneMode;
  [FieldOffset(4)]
  public LocalPhysicsMode m_LocalPhysicsMode;

  static LoadSceneParameters()
  {
    Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", nameof (LoadSceneParameters));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr);
    LoadSceneParameters.NativeFieldInfoPtr_m_LoadSceneMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, nameof (m_LoadSceneMode));
    LoadSceneParameters.NativeFieldInfoPtr_m_LocalPhysicsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, nameof (m_LocalPhysicsMode));
    LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, 100669272);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 328500, RefRangeEnd = 328510, XrefRangeStart = 328500, XrefRangeEnd = 328510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LoadSceneParameters(LoadSceneMode mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mode
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoadSceneParameters.NativeMethodInfoPtr__ctor_Public_Void_LoadSceneMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LoadSceneParameters>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public LoadSceneMode loadSceneMode
  {
    get => this.m_LoadSceneMode;
    set => this.m_LoadSceneMode = value;
  }

  public LocalPhysicsMode localPhysicsMode
  {
    get => this.m_LocalPhysicsMode;
    set => this.m_LocalPhysicsMode = value;
  }
}
