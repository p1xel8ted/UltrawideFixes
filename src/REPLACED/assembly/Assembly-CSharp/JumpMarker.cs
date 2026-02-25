// Decompiled with JetBrains decompiler
// Type: JumpMarker
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
public class JumpMarker(IntPtr pointer) : Marker(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_destinationMarker;
  private static readonly IntPtr NativeFieldInfoPtr_emitOnce;
  private static readonly IntPtr NativeFieldInfoPtr_emitInEditor;
  private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static JumpMarker()
  {
    Il2CppClassPointerStore<JumpMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (JumpMarker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr);
    JumpMarker.NativeFieldInfoPtr_destinationMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr, nameof (destinationMarker));
    JumpMarker.NativeFieldInfoPtr_emitOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr, nameof (emitOnce));
    JumpMarker.NativeFieldInfoPtr_emitInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr, nameof (emitInEditor));
    JumpMarker.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr, "<id>k__BackingField");
    JumpMarker.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr, 100663451 /*0x0600009B*/);
    JumpMarker.NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr, 100663452 /*0x0600009C*/);
    JumpMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr, 100663453 /*0x0600009D*/);
  }

  public virtual unsafe PropertyName id
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16660, RefRangeEnd = 16661, XrefRangeStart = 16660, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JumpMarker.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PropertyName*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe NotificationFlags UnityEngine\u002ETimeline\u002EINotificationOptionProvider\u002Eflags
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(JumpMarker.NativeMethodInfoPtr_UnityEngine_Timeline_INotificationOptionProvider_get_flags_Private_Virtual_Final_New_get_NotificationFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(NotificationFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JumpMarker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JumpMarker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JumpMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DestinationMarker destinationMarker
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpMarker.NativeFieldInfoPtr_destinationMarker));
      return num == IntPtr.Zero ? (DestinationMarker) null : Il2CppObjectPool.Get<DestinationMarker>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JumpMarker.NativeFieldInfoPtr_destinationMarker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool emitOnce
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpMarker.NativeFieldInfoPtr_emitOnce));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpMarker.NativeFieldInfoPtr_emitOnce)) = value;
    }
  }

  public unsafe bool emitInEditor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpMarker.NativeFieldInfoPtr_emitInEditor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpMarker.NativeFieldInfoPtr_emitInEditor)) = value;
    }
  }

  public unsafe PropertyName _id_k__BackingField
  {
    get
    {
      return *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpMarker.NativeFieldInfoPtr__id_k__BackingField));
    }
    [param: In] set
    {
      *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpMarker.NativeFieldInfoPtr__id_k__BackingField)) = value;
    }
  }
}
