// Decompiled with JetBrains decompiler
// Type: UnityEngine.RangeAttribute
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

public sealed class RangeAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_min;
  private static readonly IntPtr NativeFieldInfoPtr_max;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

  static RangeAttribute()
  {
    Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RangeAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr);
    RangeAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, nameof (min));
    RangeAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, nameof (max));
    RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, 100667742);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441874, XrefRangeEnd = 441875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RangeAttribute(float min, float max)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &min;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &max;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float min
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min)) = value;
    }
  }

  public unsafe float max
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max)) = value;
    }
  }
}
