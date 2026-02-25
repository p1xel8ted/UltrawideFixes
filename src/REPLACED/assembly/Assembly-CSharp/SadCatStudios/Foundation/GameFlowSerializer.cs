// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.GameFlowSerializer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation;

public class GameFlowSerializer(System.IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_guidComponent;
  private static readonly System.IntPtr NativeFieldInfoPtr_guid;
  private static readonly System.IntPtr NativeFieldInfoPtr_saveDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameFlowSerializables;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameFlowInitialize;
  private static readonly System.IntPtr NativeFieldInfoPtr_isPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_Awoken;
  private static readonly System.IntPtr NativeFieldInfoPtr_GlobalInitializePriority;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SaveOne_Private_Void_GameFlowState_ICheckpointSender_IGameFlowSerializable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Save_Public_Void_GameFlowState_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_GameFlowState_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GameFlowSerializer()
  {
    Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (GameFlowSerializer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr);
    GameFlowSerializer.NativeFieldInfoPtr_guidComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, nameof (guidComponent));
    GameFlowSerializer.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, nameof (guid));
    GameFlowSerializer.NativeFieldInfoPtr_saveDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, nameof (saveDictionary));
    GameFlowSerializer.NativeFieldInfoPtr_gameFlowSerializables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, nameof (gameFlowSerializables));
    GameFlowSerializer.NativeFieldInfoPtr_gameFlowInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, nameof (gameFlowInitialize));
    GameFlowSerializer.NativeFieldInfoPtr_isPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, nameof (isPlayer));
    GameFlowSerializer.NativeFieldInfoPtr_Awoken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, nameof (Awoken));
    GameFlowSerializer.NativeFieldInfoPtr_GlobalInitializePriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, nameof (GlobalInitializePriority));
    GameFlowSerializer.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, 100671303);
    GameFlowSerializer.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, 100671304);
    GameFlowSerializer.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, 100671305);
    GameFlowSerializer.NativeMethodInfoPtr_SaveOne_Private_Void_GameFlowState_ICheckpointSender_IGameFlowSerializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, 100671306);
    GameFlowSerializer.NativeMethodInfoPtr_Save_Public_Void_GameFlowState_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, 100671307);
    GameFlowSerializer.NativeMethodInfoPtr_Load_Public_Void_GameFlowState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, 100671308);
    GameFlowSerializer.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, 100671309);
    GameFlowSerializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, 100671310);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92966, XrefRangeEnd = 93010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameFlowSerializer.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93010, XrefRangeEnd = 93014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93021, RefRangeEnd = 93022, XrefRangeStart = 93014, XrefRangeEnd = 93021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 93040, RefRangeEnd = 93041, XrefRangeStart = 93022, XrefRangeEnd = 93040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SaveOne(
    GameFlowState flowState,
    ICheckpointSender checkpointSender,
    IGameFlowSerializable serializable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) flowState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) serializable);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.NativeMethodInfoPtr_SaveOne_Private_Void_GameFlowState_ICheckpointSender_IGameFlowSerializable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 93067, RefRangeEnd = 93070, XrefRangeStart = 93041, XrefRangeEnd = 93067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Save(GameFlowState flowState, ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) flowState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.NativeMethodInfoPtr_Save_Public_Void_GameFlowState_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 93116, RefRangeEnd = 93118, XrefRangeStart = 93070, XrefRangeEnd = 93116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Load(GameFlowState flowState, bool dontLoadPlayer = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) flowState);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dontLoadPlayer;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.NativeMethodInfoPtr_Load_Public_Void_GameFlowState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93118, XrefRangeEnd = 93128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize(bool dontLoadPlayer = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &dontLoadPlayer
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameFlowSerializer.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93128, XrefRangeEnd = 93135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameFlowSerializer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidComponent guidComponent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_guidComponent));
      return num == System.IntPtr.Zero ? (GuidComponent) null : Il2CppObjectPool.Get<GuidComponent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_guidComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Guid guid
  {
    get
    {
      return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_guid));
    }
    [param: In] set
    {
      *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_guid)) = value;
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, Il2CppSystem.Object> saveDictionary
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_saveDictionary));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_saveDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IGameFlowSerializable> gameFlowSerializables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_gameFlowSerializables));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<IGameFlowSerializable>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IGameFlowSerializable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_gameFlowSerializables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<IGameFlowInitialize> gameFlowInitialize
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_gameFlowInitialize));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<IGameFlowInitialize>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<IGameFlowInitialize>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_gameFlowInitialize), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isPlayer
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_isPlayer));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_isPlayer)) = value;
    }
  }

  public unsafe bool Awoken
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_Awoken));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_Awoken)) = value;
    }
  }

  public unsafe int GlobalInitializePriority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_GlobalInitializePriority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameFlowSerializer.NativeFieldInfoPtr_GlobalInitializePriority)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.GameFlowSerializer+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__8_0_Internal_Int32_IGameFlowSerializable_IGameFlowSerializable_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Awake_b__8_1_Internal_Int32_IGameFlowInitialize_IGameFlowInitialize_0;

    static __c()
    {
      Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameFlowSerializer>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr);
      GameFlowSerializer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr, "<>9");
      GameFlowSerializer.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr, "<>9__8_0");
      GameFlowSerializer.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr, "<>9__8_1");
      GameFlowSerializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr, 100671312);
      GameFlowSerializer.__c.NativeMethodInfoPtr__Awake_b__8_0_Internal_Int32_IGameFlowSerializable_IGameFlowSerializable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr, 100671313);
      GameFlowSerializer.__c.NativeMethodInfoPtr__Awake_b__8_1_Internal_Int32_IGameFlowInitialize_IGameFlowInitialize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr, 100671314);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameFlowSerializer.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92954, XrefRangeEnd = 92960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _Awake_b__8_0(IGameFlowSerializable a, IGameFlowSerializable b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.__c.NativeMethodInfoPtr__Awake_b__8_0_Internal_Int32_IGameFlowSerializable_IGameFlowSerializable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92960, XrefRangeEnd = 92966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _Awake_b__8_1(IGameFlowInitialize a, IGameFlowInitialize b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GameFlowSerializer.__c.NativeMethodInfoPtr__Awake_b__8_1_Internal_Int32_IGameFlowInitialize_IGameFlowInitialize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe GameFlowSerializer.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GameFlowSerializer.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (GameFlowSerializer.__c) null : Il2CppObjectPool.Get<GameFlowSerializer.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameFlowSerializer.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<IGameFlowSerializable> __9__8_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GameFlowSerializer.__c.NativeFieldInfoPtr___9__8_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<IGameFlowSerializable>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<IGameFlowSerializable>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameFlowSerializer.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<IGameFlowInitialize> __9__8_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(GameFlowSerializer.__c.NativeFieldInfoPtr___9__8_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<IGameFlowInitialize>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<IGameFlowInitialize>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GameFlowSerializer.__c.NativeFieldInfoPtr___9__8_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
