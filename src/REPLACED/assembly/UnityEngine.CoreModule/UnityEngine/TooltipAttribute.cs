// Decompiled with JetBrains decompiler
// Type: UnityEngine.TooltipAttribute
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

public class TooltipAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_tooltip;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

  static TooltipAttribute()
  {
    Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TooltipAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr);
    TooltipAttribute.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr, nameof (tooltip));
    TooltipAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr, 100667738);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441871, XrefRangeEnd = 441872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TooltipAttribute(string tooltip)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TooltipAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(tooltip)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TooltipAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string tooltip
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TooltipAttribute.NativeFieldInfoPtr_tooltip)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TooltipAttribute.NativeFieldInfoPtr_tooltip), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
