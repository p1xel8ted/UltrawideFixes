// Decompiled with JetBrains decompiler
// Type: VibrationMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Configs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
public class VibrationMarker(IntPtr pointer) : Marker(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_VibrationConfig;
  private static readonly IntPtr NativeFieldInfoPtr_Flags;
  private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_flags_Public_Virtual_Final_New_get_NotificationFlags_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VibrationMarker()
  {
    Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (VibrationMarker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr);
    VibrationMarker.NativeFieldInfoPtr_VibrationConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr, nameof (VibrationConfig));
    VibrationMarker.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr, nameof (Flags));
    VibrationMarker.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr, "<id>k__BackingField");
    VibrationMarker.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr, 100663457 /*0x060000A1*/);
    VibrationMarker.NativeMethodInfoPtr_get_flags_Public_Virtual_Final_New_get_NotificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr, 100663458 /*0x060000A2*/);
    VibrationMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr, 100663459 /*0x060000A3*/);
  }

  public virtual unsafe PropertyName id
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16660, RefRangeEnd = 16661, XrefRangeStart = 16660, XrefRangeEnd = 16661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VibrationMarker.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VibrationMarker.NativeMethodInfoPtr_get_flags_Public_Virtual_Final_New_get_NotificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(NotificationFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VibrationMarker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VibrationMarker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VibrationMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe JoystickVibrationConfig VibrationConfig
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationMarker.NativeFieldInfoPtr_VibrationConfig));
      return num == IntPtr.Zero ? (JoystickVibrationConfig) null : Il2CppObjectPool.Get<JoystickVibrationConfig>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VibrationMarker.NativeFieldInfoPtr_VibrationConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe NotificationFlags Flags
  {
    get
    {
      return *(NotificationFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationMarker.NativeFieldInfoPtr_Flags));
    }
    [param: In] set
    {
      *(NotificationFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationMarker.NativeFieldInfoPtr_Flags)) = value;
    }
  }

  public unsafe PropertyName _id_k__BackingField
  {
    get
    {
      return *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationMarker.NativeFieldInfoPtr__id_k__BackingField));
    }
    [param: In] set
    {
      *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationMarker.NativeFieldInfoPtr__id_k__BackingField)) = value;
    }
  }
}
