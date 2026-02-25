// Decompiled with JetBrains decompiler
// Type: UnityEngine.InspectorNameAttribute
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

public class InspectorNameAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_displayName;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

  static InspectorNameAttribute()
  {
    Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (InspectorNameAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr);
    InspectorNameAttribute.NativeFieldInfoPtr_displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr, nameof (displayName));
    InspectorNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr, 100667737);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441870, XrefRangeEnd = 441871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InspectorNameAttribute(string displayName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InspectorNameAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(displayName)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InspectorNameAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string displayName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectorNameAttribute.NativeFieldInfoPtr_displayName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InspectorNameAttribute.NativeFieldInfoPtr_displayName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
