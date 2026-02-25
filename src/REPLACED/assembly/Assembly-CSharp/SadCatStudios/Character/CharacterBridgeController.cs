// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterBridgeController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Environment;
using SadCatStudios.MovementPhysics;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterBridgeController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_personPhysics;
  private static readonly IntPtr NativeFieldInfoPtr_currBridge;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SaveBridge_Public_Void_BridgeObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPlaneDistance_Public_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_HasArrived_Public_Boolean_Boolean_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SnapToPlane_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterBridgeController()
  {
    Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterBridgeController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr);
    CharacterBridgeController.NativeFieldInfoPtr_personPhysics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr, nameof (personPhysics));
    CharacterBridgeController.NativeFieldInfoPtr_currBridge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr, nameof (currBridge));
    CharacterBridgeController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr, 100674895);
    CharacterBridgeController.NativeMethodInfoPtr_SaveBridge_Public_Void_BridgeObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr, 100674896);
    CharacterBridgeController.NativeMethodInfoPtr_GetPlaneDistance_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr, 100674897);
    CharacterBridgeController.NativeMethodInfoPtr_HasArrived_Public_Boolean_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr, 100674898);
    CharacterBridgeController.NativeMethodInfoPtr_SnapToPlane_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr, 100674899);
    CharacterBridgeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr, 100674900);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114066, XrefRangeEnd = 114069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBridgeController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SaveBridge(BridgeObject bridgeObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bridgeObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBridgeController.NativeMethodInfoPtr_SaveBridge_Public_Void_BridgeObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 114071, RefRangeEnd = 114073, XrefRangeStart = 114069, XrefRangeEnd = 114071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetPlaneDistance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBridgeController.NativeMethodInfoPtr_GetPlaneDistance_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 114078, RefRangeEnd = 114081, XrefRangeStart = 114073, XrefRangeEnd = 114078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasArrived(bool atTop, float threshold)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &atTop;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &threshold;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterBridgeController.NativeMethodInfoPtr_HasArrived_Public_Boolean_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114084, RefRangeEnd = 114085, XrefRangeStart = 114081, XrefRangeEnd = 114084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SnapToPlane(bool toTop)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &toTop
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBridgeController.NativeMethodInfoPtr_SnapToPlane_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterBridgeController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBridgeController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterBridgeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PersonPhysics personPhysics
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBridgeController.NativeFieldInfoPtr_personPhysics));
      return num == IntPtr.Zero ? (PersonPhysics) null : Il2CppObjectPool.Get<PersonPhysics>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBridgeController.NativeFieldInfoPtr_personPhysics), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BridgeObject currBridge
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterBridgeController.NativeFieldInfoPtr_currBridge));
      return num == IntPtr.Zero ? (BridgeObject) null : Il2CppObjectPool.Get<BridgeObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterBridgeController.NativeFieldInfoPtr_currBridge), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
