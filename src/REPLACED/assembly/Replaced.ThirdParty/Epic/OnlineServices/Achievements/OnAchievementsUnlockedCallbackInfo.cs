// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.OnAchievementsUnlockedCallbackInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

public class OnAchievementsUnlockedCallbackInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__UserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AchievementIds_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Private_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementIds_Public_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementIds_Private_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnAchievementsUnlockedCallbackInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OnAchievementsUnlockedCallbackInfo()
  {
    Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (OnAchievementsUnlockedCallbackInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr);
    OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, "<ClientData>k__BackingField");
    OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__UserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, "<UserId>k__BackingField");
    OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__AchievementIds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, "<AchievementIds>k__BackingField");
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673416);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673417);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673418);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_set_UserId_Private_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673419);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_get_AchievementIds_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673420);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_set_AchievementIds_Private_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673421);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673422);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnAchievementsUnlockedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673423);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673424);
    OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr, 100673425);
  }

  public virtual unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId UserId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_set_UserId_Private_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStringArray AchievementIds
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_get_AchievementIds_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_set_AchievementIds_Private_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<Result>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402367, XrefRangeEnd = 402391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<OnAchievementsUnlockedCallbackInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnAchievementsUnlockedCallbackInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402391, XrefRangeEnd = 402419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnAchievementsUnlockedCallbackInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Object _ClientData_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProductUserId _UserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__UserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__UserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray _AchievementIds_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__AchievementIds_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnAchievementsUnlockedCallbackInfo.NativeFieldInfoPtr__AchievementIds_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
