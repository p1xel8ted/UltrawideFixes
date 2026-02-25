// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CombatZoneEnemyPlacer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CombatZoneEnemyPlacer(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Squad;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartPlacingAtDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_Direction;
  private static readonly System.IntPtr NativeFieldInfoPtr_UsedDirectionWhenPoolIsSwitched;
  private static readonly System.IntPtr NativeFieldInfoPtr_MinDistanceBetweenEnemies;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxDistanceBetweenEnemies;
  private static readonly System.IntPtr NativeFieldInfoPtr_ZDistanceAmplitude;
  private static readonly System.IntPtr NativeFieldInfoPtr_hideOnStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_OutsideEnemiesPlacingSide;
  private static readonly System.IntPtr NativeFieldInfoPtr_SwapOutsideSideEachEnemy;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartPlacingAtDistanceOutside;
  private static readonly System.IntPtr NativeFieldInfoPtr_OutsideFrontlineZ;
  private static readonly System.IntPtr NativeFieldInfoPtr_TeleportOutsideEnemies;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InitializePriority_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowHiddenEnemies_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatZoneEnemyPlacer()
  {
    Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CombatZoneEnemyPlacer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr);
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_Squad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (Squad));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_StartPlacingAtDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (StartPlacingAtDistance));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (Direction));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_UsedDirectionWhenPoolIsSwitched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (UsedDirectionWhenPoolIsSwitched));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_MinDistanceBetweenEnemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (MinDistanceBetweenEnemies));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_MaxDistanceBetweenEnemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (MaxDistanceBetweenEnemies));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_ZDistanceAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (ZDistanceAmplitude));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_hideOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (hideOnStart));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_OutsideEnemiesPlacingSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (OutsideEnemiesPlacingSide));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_SwapOutsideSideEachEnemy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (SwapOutsideSideEachEnemy));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_StartPlacingAtDistanceOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (StartPlacingAtDistanceOutside));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_OutsideFrontlineZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (OutsideFrontlineZ));
    CombatZoneEnemyPlacer.NativeFieldInfoPtr_TeleportOutsideEnemies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, nameof (TeleportOutsideEnemies));
    CombatZoneEnemyPlacer.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, 100677030);
    CombatZoneEnemyPlacer.NativeMethodInfoPtr_get_InitializePriority_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, 100677031);
    CombatZoneEnemyPlacer.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, 100677032);
    CombatZoneEnemyPlacer.NativeMethodInfoPtr_ShowHiddenEnemies_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, 100677033);
    CombatZoneEnemyPlacer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, 100677034);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127825, XrefRangeEnd = 127829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  public virtual unsafe int InitializePriority
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 749, RefRangeEnd = 751, XrefRangeStart = 749, XrefRangeEnd = 751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer.NativeMethodInfoPtr_get_InitializePriority_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127829, XrefRangeEnd = 127850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127850, XrefRangeEnd = 127871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowHiddenEnemies()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer.NativeMethodInfoPtr_ShowHiddenEnemies_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127871, XrefRangeEnd = 127872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatZoneEnemyPlacer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CombatSquad Squad
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_Squad));
      return num == System.IntPtr.Zero ? (CombatSquad) null : Il2CppObjectPool.Get<CombatSquad>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_Squad), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float StartPlacingAtDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_StartPlacingAtDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_StartPlacingAtDistance)) = value;
    }
  }

  public unsafe CombatZoneEnemyPlacer.PlacementDirection Direction
  {
    get
    {
      return *(CombatZoneEnemyPlacer.PlacementDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_Direction));
    }
    [param: In] set
    {
      *(CombatZoneEnemyPlacer.PlacementDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_Direction)) = value;
    }
  }

  public unsafe CombatZoneEnemyPlacer.DirectionForNewPool UsedDirectionWhenPoolIsSwitched
  {
    get
    {
      return *(CombatZoneEnemyPlacer.DirectionForNewPool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_UsedDirectionWhenPoolIsSwitched));
    }
    [param: In] set
    {
      *(CombatZoneEnemyPlacer.DirectionForNewPool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_UsedDirectionWhenPoolIsSwitched)) = value;
    }
  }

  public unsafe float MinDistanceBetweenEnemies
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_MinDistanceBetweenEnemies));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_MinDistanceBetweenEnemies)) = value;
    }
  }

  public unsafe float MaxDistanceBetweenEnemies
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_MaxDistanceBetweenEnemies));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_MaxDistanceBetweenEnemies)) = value;
    }
  }

  public unsafe float ZDistanceAmplitude
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_ZDistanceAmplitude));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_ZDistanceAmplitude)) = value;
    }
  }

  public unsafe bool hideOnStart
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_hideOnStart));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_hideOnStart)) = value;
    }
  }

  public unsafe CombatZoneEnemyPlacer.OutsideSide OutsideEnemiesPlacingSide
  {
    get
    {
      return *(CombatZoneEnemyPlacer.OutsideSide*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_OutsideEnemiesPlacingSide));
    }
    [param: In] set
    {
      *(CombatZoneEnemyPlacer.OutsideSide*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_OutsideEnemiesPlacingSide)) = value;
    }
  }

  public unsafe bool SwapOutsideSideEachEnemy
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_SwapOutsideSideEachEnemy));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_SwapOutsideSideEachEnemy)) = value;
    }
  }

  public unsafe float StartPlacingAtDistanceOutside
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_StartPlacingAtDistanceOutside));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_StartPlacingAtDistanceOutside)) = value;
    }
  }

  public unsafe bool OutsideFrontlineZ
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_OutsideFrontlineZ));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_OutsideFrontlineZ)) = value;
    }
  }

  public unsafe bool TeleportOutsideEnemies
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_TeleportOutsideEnemies));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer.NativeFieldInfoPtr_TeleportOutsideEnemies)) = value;
    }
  }

  public enum PlacementDirection
  {
    LeftToRight,
    RightToLeft,
  }

  public enum DirectionForNewPool
  {
    StartFromOpposite,
    ContinueWithCurrent,
  }

  public enum OutsideSide
  {
    Left,
    Right,
  }

  [ObfuscatedName("SadCatStudios.Combat.CombatZoneEnemyPlacer+<Start>d__16")]
  public sealed class _Start_d__16(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Start_d__16()
    {
      Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CombatZoneEnemyPlacer>.NativeClassPtr, "<Start>d__16");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr);
      CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, "<>1__state");
      CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, "<>2__current");
      CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, "<>4__this");
      CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, 100677035);
      CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, 100677036);
      CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, 100677037);
      CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, 100677038);
      CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, 100677039);
      CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr, 100677040);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Start_d__16(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatZoneEnemyPlacer._Start_d__16>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127817, XrefRangeEnd = 127820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127820, XrefRangeEnd = 127825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatZoneEnemyPlacer._Start_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CombatZoneEnemyPlacer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CombatZoneEnemyPlacer) null : Il2CppObjectPool.Get<CombatZoneEnemyPlacer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CombatZoneEnemyPlacer._Start_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
