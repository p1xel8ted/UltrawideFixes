// Decompiled with JetBrains decompiler
// Type: UnityEngine.SpaceAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class SpaceAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_height;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

  static SpaceAttribute()
  {
    Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (SpaceAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr);
    SpaceAttribute.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, nameof (height));
    SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, 100667739);
    SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, 100667740);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441872, XrefRangeEnd = 441873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpaceAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441873, XrefRangeEnd = 441874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpaceAttribute(float height)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &height
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float height
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpaceAttribute.NativeFieldInfoPtr_height));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpaceAttribute.NativeFieldInfoPtr_height)) = value;
    }
  }
}
