// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Friends.OnFriendsUpdateInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Friends;

public class OnFriendsUpdateInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TargetUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PreviousStatus_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentStatus_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Private_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PreviousStatus_Public_get_FriendsStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PreviousStatus_Private_set_Void_FriendsStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStatus_Public_get_FriendsStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentStatus_Private_set_Void_FriendsStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnFriendsUpdateInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OnFriendsUpdateInfo()
  {
    Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Friends", nameof (OnFriendsUpdateInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr);
    OnFriendsUpdateInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, "<ClientData>k__BackingField");
    OnFriendsUpdateInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, "<LocalUserId>k__BackingField");
    OnFriendsUpdateInfo.NativeFieldInfoPtr__TargetUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, "<TargetUserId>k__BackingField");
    OnFriendsUpdateInfo.NativeFieldInfoPtr__PreviousStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, "<PreviousStatus>k__BackingField");
    OnFriendsUpdateInfo.NativeFieldInfoPtr__CurrentStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, "<CurrentStatus>k__BackingField");
    OnFriendsUpdateInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670483);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670484);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670485);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670486);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670487);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_set_TargetUserId_Private_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670488);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_get_PreviousStatus_Public_get_FriendsStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670489);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_set_PreviousStatus_Private_set_Void_FriendsStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670490);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_get_CurrentStatus_Public_get_FriendsStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670491);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_set_CurrentStatus_Private_set_Void_FriendsStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670492);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670493);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnFriendsUpdateInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670494);
    OnFriendsUpdateInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670495);
    OnFriendsUpdateInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr, 100670496);
  }

  public virtual unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId TargetUserId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_set_TargetUserId_Private_set_Void_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe FriendsStatus PreviousStatus
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_get_PreviousStatus_Public_get_FriendsStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FriendsStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_set_PreviousStatus_Private_set_Void_FriendsStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe FriendsStatus CurrentStatus
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_get_CurrentStatus_Public_get_FriendsStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FriendsStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_set_CurrentStatus_Private_set_Void_FriendsStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Nullable<Result> GetResultCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<Result>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393390, XrefRangeEnd = 393418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<OnFriendsUpdateInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnFriendsUpdateInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393418, XrefRangeEnd = 393450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnFriendsUpdateInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnFriendsUpdateInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Object _ClientData_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EpicAccountId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EpicAccountId _TargetUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__TargetUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__TargetUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FriendsStatus _PreviousStatus_k__BackingField
  {
    get
    {
      return *(FriendsStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__PreviousStatus_k__BackingField));
    }
    [param: In] set
    {
      *(FriendsStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__PreviousStatus_k__BackingField)) = value;
    }
  }

  public unsafe FriendsStatus _CurrentStatus_k__BackingField
  {
    get
    {
      return *(FriendsStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__CurrentStatus_k__BackingField));
    }
    [param: In] set
    {
      *(FriendsStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnFriendsUpdateInfo.NativeFieldInfoPtr__CurrentStatus_k__BackingField)) = value;
    }
  }
}
