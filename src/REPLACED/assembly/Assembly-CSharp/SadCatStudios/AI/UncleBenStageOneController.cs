// Decompiled with JetBrains decompiler
// Type: SadCatStudios.AI.UncleBenStageOneController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.AI;

public class UncleBenStageOneController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_aiController;
  private static readonly System.IntPtr NativeFieldInfoPtr_healthController;
  private static readonly System.IntPtr NativeFieldInfoPtr_conditionProviders;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ContextClosed_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsInContext_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UncleBenStageOneController()
  {
    Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.AI", nameof (UncleBenStageOneController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr);
    UncleBenStageOneController.NativeFieldInfoPtr_aiController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, nameof (aiController));
    UncleBenStageOneController.NativeFieldInfoPtr_healthController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, nameof (healthController));
    UncleBenStageOneController.NativeFieldInfoPtr_conditionProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, nameof (conditionProviders));
    UncleBenStageOneController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, 100677914);
    UncleBenStageOneController.NativeMethodInfoPtr_ContextClosed_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, 100677915);
    UncleBenStageOneController.NativeMethodInfoPtr_IsInContext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, 100677916);
    UncleBenStageOneController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, 100677917);
    UncleBenStageOneController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, 100677918);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132542, XrefRangeEnd = 132548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UncleBenStageOneController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132548, XrefRangeEnd = 132550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ContextClosed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UncleBenStageOneController.NativeMethodInfoPtr_ContextClosed_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132550, XrefRangeEnd = 132552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsInContext()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UncleBenStageOneController.NativeMethodInfoPtr_IsInContext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132552, XrefRangeEnd = 132553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UncleBenStageOneController.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132553, XrefRangeEnd = 132566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UncleBenStageOneController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UncleBenStageOneController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CharacterAIController aiController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.NativeFieldInfoPtr_aiController));
      return num == System.IntPtr.Zero ? (CharacterAIController) null : Il2CppObjectPool.Get<CharacterAIController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.NativeFieldInfoPtr_aiController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterHealthController healthController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.NativeFieldInfoPtr_healthController));
      return num == System.IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.NativeFieldInfoPtr_healthController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<UncleBenStageOneController.BacklineShotConditionProvider> conditionProviders
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.NativeFieldInfoPtr_conditionProviders));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UncleBenStageOneController.BacklineShotConditionProvider>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UncleBenStageOneController.BacklineShotConditionProvider>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.NativeFieldInfoPtr_conditionProviders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class BacklineShotConditionProvider(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HealthPoint;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsClosed;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Check_Public_Boolean_Single_0;

    static BacklineShotConditionProvider()
    {
      Il2CppClassPointerStore<UncleBenStageOneController.BacklineShotConditionProvider>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UncleBenStageOneController>.NativeClassPtr, nameof (BacklineShotConditionProvider));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UncleBenStageOneController.BacklineShotConditionProvider>.NativeClassPtr);
      UncleBenStageOneController.BacklineShotConditionProvider.NativeFieldInfoPtr_HealthPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleBenStageOneController.BacklineShotConditionProvider>.NativeClassPtr, nameof (HealthPoint));
      UncleBenStageOneController.BacklineShotConditionProvider.NativeFieldInfoPtr_IsClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UncleBenStageOneController.BacklineShotConditionProvider>.NativeClassPtr, nameof (IsClosed));
      UncleBenStageOneController.BacklineShotConditionProvider.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleBenStageOneController.BacklineShotConditionProvider>.NativeClassPtr, 100677919);
      UncleBenStageOneController.BacklineShotConditionProvider.NativeMethodInfoPtr_Check_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UncleBenStageOneController.BacklineShotConditionProvider>.NativeClassPtr, 100677920);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132541, XrefRangeEnd = 132542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BacklineShotConditionProvider(float healthPoint)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UncleBenStageOneController.BacklineShotConditionProvider>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &healthPoint
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UncleBenStageOneController.BacklineShotConditionProvider.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool Check(float currHealthPercent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &currHealthPercent
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UncleBenStageOneController.BacklineShotConditionProvider.NativeMethodInfoPtr_Check_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe float HealthPoint
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.BacklineShotConditionProvider.NativeFieldInfoPtr_HealthPoint));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.BacklineShotConditionProvider.NativeFieldInfoPtr_HealthPoint)) = value;
      }
    }

    public unsafe bool IsClosed
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.BacklineShotConditionProvider.NativeFieldInfoPtr_IsClosed));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UncleBenStageOneController.BacklineShotConditionProvider.NativeFieldInfoPtr_IsClosed)) = value;
      }
    }
  }
}
