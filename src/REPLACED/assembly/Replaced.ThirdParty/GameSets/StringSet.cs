// Decompiled with JetBrains decompiler
// Type: GameSets.StringSet
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace GameSets;

public class StringSet(IntPtr pointer) : RuntimeSet<string>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_transformDict;
  private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTransform_Public_Transform_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static StringSet()
  {
    Il2CppClassPointerStore<StringSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameSets", nameof (StringSet));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringSet>.NativeClassPtr);
    StringSet.NativeFieldInfoPtr_transformDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSet>.NativeClassPtr, nameof (transformDict));
    StringSet.NativeMethodInfoPtr_Add_Public_Void_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSet>.NativeClassPtr, 100663738);
    StringSet.NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSet>.NativeClassPtr, 100663739);
    StringSet.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSet>.NativeClassPtr, 100663740);
    StringSet.NativeMethodInfoPtr_GetTransform_Public_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSet>.NativeClassPtr, 100663741);
    StringSet.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSet>.NativeClassPtr, 100663742);
    StringSet.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSet>.NativeClassPtr, 100663743);
    StringSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSet>.NativeClassPtr, 100663744 /*0x060001C0*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364008, XrefRangeEnd = 364014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(string thing, Transform transform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(thing);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StringSet.NativeMethodInfoPtr_Add_Public_Void_String_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364014, XrefRangeEnd = 364023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Remove(string thing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(thing)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StringSet.NativeMethodInfoPtr_Remove_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364023, XrefRangeEnd = 364030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StringSet.NativeMethodInfoPtr_Clear_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 364034, RefRangeEnd = 364035, XrefRangeStart = 364030, XrefRangeEnd = 364034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Transform GetTransform(string id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(id)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringSet.NativeMethodInfoPtr_GetTransform_Public_Transform_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364035, XrefRangeEnd = 364037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StringSet.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364037, XrefRangeEnd = 364041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Contains(string item)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(item)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringSet.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364041, XrefRangeEnd = 364050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StringSet()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringSet>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StringSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Dictionary<string, Transform> transformDict
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StringSet.NativeFieldInfoPtr_transformDict));
      return num == IntPtr.Zero ? (Dictionary<string, Transform>) null : Il2CppObjectPool.Get<Dictionary<string, Transform>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StringSet.NativeFieldInfoPtr_transformDict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
