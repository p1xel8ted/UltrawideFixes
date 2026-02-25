// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.PlayerSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.FSM;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Foundation;

public class PlayerSpawner(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_abilities;
  private static readonly IntPtr NativeFieldInfoPtr_defaultFSM;
  private static readonly IntPtr NativeFieldInfoPtr_storyProgressSpawner;
  private static readonly IntPtr NativeFieldInfoPtr_upgrades;
  private static readonly IntPtr NativeFieldInfoPtr_pdaEntriesBefore;
  private static readonly IntPtr NativeMethodInfoPtr_get_DefaultFSM_Public_get_FSMGraph_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Abilities_Public_get_Abilities_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_StoryProgressSpawner_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_StorySpawnerCount_Private_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__StorySpawnerCount_b__11_0_Private_Boolean_PlayerSpawner_0;

  static PlayerSpawner()
  {
    Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (PlayerSpawner));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr);
    PlayerSpawner.NativeFieldInfoPtr_abilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, nameof (abilities));
    PlayerSpawner.NativeFieldInfoPtr_defaultFSM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, nameof (defaultFSM));
    PlayerSpawner.NativeFieldInfoPtr_storyProgressSpawner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, nameof (storyProgressSpawner));
    PlayerSpawner.NativeFieldInfoPtr_upgrades = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, nameof (upgrades));
    PlayerSpawner.NativeFieldInfoPtr_pdaEntriesBefore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, nameof (pdaEntriesBefore));
    PlayerSpawner.NativeMethodInfoPtr_get_DefaultFSM_Public_get_FSMGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, 100671268);
    PlayerSpawner.NativeMethodInfoPtr_get_Abilities_Public_get_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, 100671269);
    PlayerSpawner.NativeMethodInfoPtr_get_StoryProgressSpawner_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, 100671270);
    PlayerSpawner.NativeMethodInfoPtr_StorySpawnerCount_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, 100671271);
    PlayerSpawner.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, 100671272);
    PlayerSpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, 100671273);
    PlayerSpawner.NativeMethodInfoPtr__StorySpawnerCount_b__11_0_Private_Boolean_PlayerSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr, 100671274);
  }

  public unsafe FSMGraph DefaultFSM
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSpawner.NativeMethodInfoPtr_get_DefaultFSM_Public_get_FSMGraph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num3);
    }
  }

  public unsafe Abilities Abilities
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSpawner.NativeMethodInfoPtr_get_Abilities_Public_get_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Abilities*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool StoryProgressSpawner
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80472, XrefRangeStart = 80471, XrefRangeEnd = 80472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSpawner.NativeMethodInfoPtr_get_StoryProgressSpawner_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92617, XrefRangeEnd = 92632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool StorySpawnerCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSpawner.NativeMethodInfoPtr_StorySpawnerCount_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92632, XrefRangeEnd = 92661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerSpawner.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerSpawner()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSpawner>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerSpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92661, XrefRangeEnd = 92666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool _StorySpawnerCount_b__11_0(PlayerSpawner s)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) s)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSpawner.NativeMethodInfoPtr__StorySpawnerCount_b__11_0_Private_Boolean_PlayerSpawner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Abilities abilities
  {
    get
    {
      return *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_abilities));
    }
    [param: In] set
    {
      *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_abilities)) = value;
    }
  }

  public unsafe FSMGraph defaultFSM
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_defaultFSM));
      return num == IntPtr.Zero ? (FSMGraph) null : Il2CppObjectPool.Get<FSMGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_defaultFSM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool storyProgressSpawner
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_storyProgressSpawner));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_storyProgressSpawner)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<ArticyRef> upgrades
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_upgrades));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<ArticyRef>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArticyRef>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_upgrades), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef pdaEntriesBefore
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_pdaEntriesBefore));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerSpawner.NativeFieldInfoPtr_pdaEntriesBefore), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
