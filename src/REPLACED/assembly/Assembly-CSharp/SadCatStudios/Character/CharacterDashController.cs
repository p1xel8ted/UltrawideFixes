// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterDashController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.FSM;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterDashController(IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_dashNum;
  private static readonly IntPtr NativeFieldInfoPtr_dashZoneCheckRadius;
  private static readonly IntPtr NativeFieldInfoPtr_dashZoneLayer;
  private static readonly IntPtr NativeFieldInfoPtr_dashZoneTag;
  private static readonly IntPtr NativeFieldInfoPtr_keepCounterStates;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_dashCounter;
  private static readonly IntPtr NativeFieldInfoPtr_dashOverlap;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetCounter_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Dash_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanDash_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterDashController()
  {
    Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterDashController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr);
    CharacterDashController.NativeFieldInfoPtr_dashNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, nameof (dashNum));
    CharacterDashController.NativeFieldInfoPtr_dashZoneCheckRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, nameof (dashZoneCheckRadius));
    CharacterDashController.NativeFieldInfoPtr_dashZoneLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, nameof (dashZoneLayer));
    CharacterDashController.NativeFieldInfoPtr_dashZoneTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, nameof (dashZoneTag));
    CharacterDashController.NativeFieldInfoPtr_keepCounterStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, nameof (keepCounterStates));
    CharacterDashController.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, nameof (stateController));
    CharacterDashController.NativeFieldInfoPtr_dashCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, nameof (dashCounter));
    CharacterDashController.NativeFieldInfoPtr_dashOverlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, nameof (dashOverlap));
    CharacterDashController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, 100674970);
    CharacterDashController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, 100674971);
    CharacterDashController.NativeMethodInfoPtr_ResetCounter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, 100674972);
    CharacterDashController.NativeMethodInfoPtr_Dash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, 100674973);
    CharacterDashController.NativeMethodInfoPtr_CanDash_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, 100674974);
    CharacterDashController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr, 100674975);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114424, XrefRangeEnd = 114427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDashController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114427, XrefRangeEnd = 114436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDashController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ResetCounter()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDashController.NativeMethodInfoPtr_ResetCounter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114436, RefRangeEnd = 114437, XrefRangeStart = 114436, XrefRangeEnd = 114436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dash()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDashController.NativeMethodInfoPtr_Dash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114446, RefRangeEnd = 114447, XrefRangeStart = 114437, XrefRangeEnd = 114446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanDash()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterDashController.NativeMethodInfoPtr_CanDash_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114447, XrefRangeEnd = 114451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterDashController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterDashController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterDashController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int dashNum
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashNum));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashNum)) = value;
    }
  }

  public unsafe float dashZoneCheckRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashZoneCheckRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashZoneCheckRadius)) = value;
    }
  }

  public unsafe LayerMask dashZoneLayer
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashZoneLayer));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashZoneLayer)) = value;
    }
  }

  public unsafe string dashZoneTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashZoneTag)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashZoneTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe HashSet<SadCatStudios.FSM.State> keepCounterStates
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_keepCounterStates));
      return num == IntPtr.Zero ? (HashSet<SadCatStudios.FSM.State>) null : Il2CppObjectPool.Get<HashSet<SadCatStudios.FSM.State>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_keepCounterStates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int dashCounter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashCounter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashCounter)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Collider> dashOverlap
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashOverlap));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Collider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Collider>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterDashController.NativeFieldInfoPtr_dashOverlap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
