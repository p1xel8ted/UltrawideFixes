// Decompiled with JetBrains decompiler
// Type: Unity.Collections.NativeDisableParallelForRestrictionAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Unity.Collections;

public sealed class NativeDisableParallelForRestrictionAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static NativeDisableParallelForRestrictionAttribute()
  {
    Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections", nameof (NativeDisableParallelForRestrictionAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr);
    NativeDisableParallelForRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr, 100663483 /*0x060000BB*/);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeDisableParallelForRestrictionAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeDisableParallelForRestrictionAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeDisableParallelForRestrictionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
