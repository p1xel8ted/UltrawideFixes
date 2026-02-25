// Decompiled with JetBrains decompiler
// Type: UnityEngine.PreloadData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine;

public class PreloadData(IntPtr pointer) : Object(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0;

  static PreloadData()
  {
    Il2CppClassPointerStore<PreloadData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (PreloadData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreloadData>.NativeClassPtr);
    PreloadData.NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreloadData>.NativeClassPtr, 100668514);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PreloadDataDontStripMe()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreloadData.NativeMethodInfoPtr_PreloadDataDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
