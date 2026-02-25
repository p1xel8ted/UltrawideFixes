// Decompiled with JetBrains decompiler
// Type: ReferenceMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
public class ReferenceMarker(IntPtr pointer) : Marker(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerReference;
  private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__flags_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_flags_Public_Virtual_Final_New_get_NotificationFlags_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ReferenceMarker()
  {
    Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ReferenceMarker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr);
    ReferenceMarker.NativeFieldInfoPtr_playerReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr, nameof (playerReference));
    ReferenceMarker.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr, "<id>k__BackingField");
    ReferenceMarker.NativeFieldInfoPtr__flags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr, "<flags>k__BackingField");
    ReferenceMarker.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr, 100663454 /*0x0600009E*/);
    ReferenceMarker.NativeMethodInfoPtr_get_flags_Public_Virtual_Final_New_get_NotificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr, 100663455 /*0x0600009F*/);
    ReferenceMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr, 100663456 /*0x060000A0*/);
  }

  public virtual unsafe PropertyName id
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReferenceMarker.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PropertyName*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe NotificationFlags flags
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ReferenceMarker.NativeMethodInfoPtr_get_flags_Public_Virtual_Final_New_get_NotificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(NotificationFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ReferenceMarker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceMarker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReferenceMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference playerReference
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReferenceMarker.NativeFieldInfoPtr_playerReference));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReferenceMarker.NativeFieldInfoPtr_playerReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PropertyName _id_k__BackingField
  {
    get
    {
      return *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReferenceMarker.NativeFieldInfoPtr__id_k__BackingField));
    }
    [param: In] set
    {
      *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReferenceMarker.NativeFieldInfoPtr__id_k__BackingField)) = value;
    }
  }

  public unsafe NotificationFlags _flags_k__BackingField
  {
    get
    {
      return *(NotificationFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReferenceMarker.NativeFieldInfoPtr__flags_k__BackingField));
    }
    [param: In] set
    {
      *(NotificationFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReferenceMarker.NativeFieldInfoPtr__flags_k__BackingField)) = value;
    }
  }
}
