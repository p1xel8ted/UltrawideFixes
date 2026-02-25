// Decompiled with JetBrains decompiler
// Type: UnityEngine.DelayedAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine;

public sealed class DelayedAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DelayedAttribute()
  {
    Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (DelayedAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr);
    DelayedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr, 100667749);
  }

  [CallerCount(68)]
  [CachedScanResults(RefRangeStart = 441800, RefRangeEnd = 441868, XrefRangeStart = 441800, XrefRangeEnd = 441868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DelayedAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayedAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DelayedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
