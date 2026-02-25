// Decompiled with JetBrains decompiler
// Type: UnityEngine.CustomRenderTextureManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public static class CustomRenderTextureManager : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_textureLoaded;
  private static readonly System.IntPtr NativeFieldInfoPtr_textureUnloaded;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0;
  private static readonly CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate GetAllCustomRenderTexturesDelegateField;

  static CustomRenderTextureManager()
  {
    Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (CustomRenderTextureManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr);
    CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, nameof (textureLoaded));
    CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, nameof (textureUnloaded));
    CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100664653);
    CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomRenderTextureManager>.NativeClassPtr, 100664654);
    CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField = IL2CPP.ResolveICall<CustomRenderTextureManager.GetAllCustomRenderTexturesDelegate>("UnityEngine.CustomRenderTextureManager::GetAllCustomRenderTextures");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422886, XrefRangeEnd = 422888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnTextureLoaded_Internal(CustomRenderTexture source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureLoaded_Internal_Private_Static_Void_CustomRenderTexture_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422888, XrefRangeEnd = 422890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CustomRenderTextureManager.NativeMethodInfoPtr_InvokeOnTextureUnloaded_Internal_Private_Static_Void_CustomRenderTexture_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public CustomRenderTextureManager(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppSystem.Action<CustomRenderTexture> textureLoaded
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<CustomRenderTexture>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<CustomRenderTexture>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureLoaded, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppSystem.Action<CustomRenderTexture> textureUnloaded
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<CustomRenderTexture>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<CustomRenderTexture>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CustomRenderTextureManager.NativeFieldInfoPtr_textureUnloaded, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [SpecialName]
  public static void add_textureLoaded(Il2CppSystem.Action<CustomRenderTexture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_textureLoaded(Il2CppSystem.Action<CustomRenderTexture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_textureUnloaded(Il2CppSystem.Action<CustomRenderTexture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_textureUnloaded(Il2CppSystem.Action<CustomRenderTexture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void GetAllCustomRenderTextures(
    List<CustomRenderTexture> currentCustomRenderTextures)
  {
    CustomRenderTextureManager.GetAllCustomRenderTexturesDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentCustomRenderTextures));
  }

  [SpecialName]
  public static void add_updateTriggered(Il2CppSystem.Action<CustomRenderTexture, int> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_updateTriggered(Il2CppSystem.Action<CustomRenderTexture, int> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void InvokeTriggerUpdate(CustomRenderTexture crt, int updateCount)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_initializeTriggered(Il2CppSystem.Action<CustomRenderTexture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_initializeTriggered(Il2CppSystem.Action<CustomRenderTexture> value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void InvokeTriggerInitialize(CustomRenderTexture crt)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  private delegate void GetAllCustomRenderTexturesDelegate(System.IntPtr currentCustomRenderTextures);
}
