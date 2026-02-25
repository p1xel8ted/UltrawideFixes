// Decompiled with JetBrains decompiler
// Type: UnityEngine.MinAttribute
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

public sealed class MinAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_min;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;

  static MinAttribute()
  {
    Il2CppClassPointerStore<MinAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (MinAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr);
    MinAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, nameof (min));
    MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, 100667743);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 441876, RefRangeEnd = 441884, XrefRangeStart = 441875, XrefRangeEnd = 441876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MinAttribute(float min)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &min
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float min
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min)) = value;
    }
  }
}
