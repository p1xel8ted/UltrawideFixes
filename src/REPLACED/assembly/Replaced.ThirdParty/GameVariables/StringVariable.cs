// Decompiled with JetBrains decompiler
// Type: GameVariables.StringVariable
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace GameVariables;

public class StringVariable(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_value;
  private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static StringVariable()
  {
    Il2CppClassPointerStore<StringVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameVariables", nameof (StringVariable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringVariable>.NativeClassPtr);
    StringVariable.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringVariable>.NativeClassPtr, nameof (value));
    StringVariable.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringVariable>.NativeClassPtr, 100663380 /*0x06000054*/);
    StringVariable.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringVariable>.NativeClassPtr, 100663381 /*0x06000055*/);
    StringVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringVariable>.NativeClassPtr, 100663382 /*0x06000056*/);
  }

  public unsafe string Value
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringVariable.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StringVariable.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360964, XrefRangeEnd = 360967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StringVariable()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringVariable>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StringVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string value
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringVariable.NativeFieldInfoPtr_value)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringVariable.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
