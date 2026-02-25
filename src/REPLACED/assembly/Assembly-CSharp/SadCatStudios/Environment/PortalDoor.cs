// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.PortalDoor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using SadCatStudios.Triggers;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class PortalDoor(IntPtr pointer) : PortalObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_zone;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoEnterSequence_Protected_Virtual_Void_CharacterInteractionController_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoAfterEnterSequence_Protected_Virtual_Void_CharacterInteractionController_0;
  private static readonly IntPtr NativeMethodInfoPtr_DoExitSequence_Protected_Virtual_Void_CharacterInteractionController_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PortalDoor()
  {
    Il2CppClassPointerStore<PortalDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (PortalDoor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr);
    PortalDoor.NativeFieldInfoPtr_zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr, nameof (zone));
    PortalDoor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr, 100676052);
    PortalDoor.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr, 100676053);
    PortalDoor.NativeMethodInfoPtr_DoEnterSequence_Protected_Virtual_Void_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr, 100676054);
    PortalDoor.NativeMethodInfoPtr_DoAfterEnterSequence_Protected_Virtual_Void_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr, 100676055);
    PortalDoor.NativeMethodInfoPtr_DoExitSequence_Protected_Virtual_Void_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr, 100676056);
    PortalDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr, 100676057);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120995, XrefRangeEnd = 120998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PortalDoor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120998, XrefRangeEnd = 121004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Vector3 PlayerPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PortalDoor.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121004, XrefRangeEnd = 121006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoEnterSequence(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PortalDoor.NativeMethodInfoPtr_DoEnterSequence_Protected_Virtual_Void_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121006, XrefRangeEnd = 121008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAfterEnterSequence(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PortalDoor.NativeMethodInfoPtr_DoAfterEnterSequence_Protected_Virtual_Void_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121008, XrefRangeEnd = 121013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoExitSequence(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PortalDoor.NativeMethodInfoPtr_DoExitSequence_Protected_Virtual_Void_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121013, XrefRangeEnd = 121017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PortalDoor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PortalDoor>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PortalDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InteractionPortalZone zone
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PortalDoor.NativeFieldInfoPtr_zone));
      return num == IntPtr.Zero ? (InteractionPortalZone) null : Il2CppObjectPool.Get<InteractionPortalZone>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PortalDoor.NativeFieldInfoPtr_zone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
