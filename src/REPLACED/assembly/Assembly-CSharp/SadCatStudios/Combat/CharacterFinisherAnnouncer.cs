// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterFinisherAnnouncer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterFinisherAnnouncer(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_finisherChanceVariable;
  private static readonly IntPtr NativeFieldInfoPtr_finisherChanceStep;
  private static readonly IntPtr NativeFieldInfoPtr_stateController;
  private static readonly IntPtr NativeFieldInfoPtr_defaultChance;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessFinisherChance_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ProcessFinisherConnection_Public_Void_Transform_FinisherVariant_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterFinisherAnnouncer()
  {
    Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterFinisherAnnouncer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr);
    CharacterFinisherAnnouncer.NativeFieldInfoPtr_finisherChanceVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, nameof (finisherChanceVariable));
    CharacterFinisherAnnouncer.NativeFieldInfoPtr_finisherChanceStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, nameof (finisherChanceStep));
    CharacterFinisherAnnouncer.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, nameof (stateController));
    CharacterFinisherAnnouncer.NativeFieldInfoPtr_defaultChance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, nameof (defaultChance));
    CharacterFinisherAnnouncer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, 100677107);
    CharacterFinisherAnnouncer.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, 100677108);
    CharacterFinisherAnnouncer.NativeMethodInfoPtr_ProcessFinisherChance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, 100677109);
    CharacterFinisherAnnouncer.NativeMethodInfoPtr_ProcessFinisherConnection_Public_Void_Transform_FinisherVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, 100677110);
    CharacterFinisherAnnouncer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr, 100677111);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128283, XrefRangeEnd = 128286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterFinisherAnnouncer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterFinisherAnnouncer.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128289, RefRangeEnd = 128290, XrefRangeStart = 128286, XrefRangeEnd = 128289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessFinisherChance()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterFinisherAnnouncer.NativeMethodInfoPtr_ProcessFinisherChance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128296, RefRangeEnd = 128297, XrefRangeStart = 128290, XrefRangeEnd = 128296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ProcessFinisherConnection(
    Transform receiverTransform,
    FinisherVariant finisherVariant)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) receiverTransform);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) finisherVariant);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterFinisherAnnouncer.NativeMethodInfoPtr_ProcessFinisherConnection_Public_Void_Transform_FinisherVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterFinisherAnnouncer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterFinisherAnnouncer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterFinisherAnnouncer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatVariable finisherChanceVariable
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterFinisherAnnouncer.NativeFieldInfoPtr_finisherChanceVariable));
      return num == IntPtr.Zero ? (FloatVariable) null : Il2CppObjectPool.Get<FloatVariable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterFinisherAnnouncer.NativeFieldInfoPtr_finisherChanceVariable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatReference finisherChanceStep
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterFinisherAnnouncer.NativeFieldInfoPtr_finisherChanceStep));
      return num == IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterFinisherAnnouncer.NativeFieldInfoPtr_finisherChanceStep), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StateController stateController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterFinisherAnnouncer.NativeFieldInfoPtr_stateController));
      return num == IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterFinisherAnnouncer.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float defaultChance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterFinisherAnnouncer.NativeFieldInfoPtr_defaultChance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterFinisherAnnouncer.NativeFieldInfoPtr_defaultChance)) = value;
    }
  }
}
