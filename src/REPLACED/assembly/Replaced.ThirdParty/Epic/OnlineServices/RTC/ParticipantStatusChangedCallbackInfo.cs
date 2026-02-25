// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTC.ParticipantStatusChangedCallbackInfo
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
namespace Epic.OnlineServices.RTC;

public class ParticipantStatusChangedCallbackInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RoomName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ParticipantId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ParticipantStatus_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ParticipantMetadata_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RoomName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantId_Private_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantStatus_Private_set_Void_RTCParticipantStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParticipantMetadata_Private_set_Void_Il2CppReferenceArray_1_ParticipantMetadata_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_ParticipantStatusChangedCallbackInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ParticipantStatusChangedCallbackInfo()
  {
    Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTC", nameof (ParticipantStatusChangedCallbackInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr);
    ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, "<ClientData>k__BackingField");
    ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, "<LocalUserId>k__BackingField");
    ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__RoomName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, "<RoomName>k__BackingField");
    ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, "<ParticipantId>k__BackingField");
    ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantStatus_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, "<ParticipantStatus>k__BackingField");
    ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantMetadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, "<ParticipantMetadata>k__BackingField");
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667031);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667032);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667033);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667034);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_RoomName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667035);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_RoomName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667036);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667037);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_ParticipantId_Private_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667038);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667039);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_ParticipantStatus_Private_set_Void_RTCParticipantStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667040 /*0x06000EA0*/);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667041);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_ParticipantMetadata_Private_set_Void_Il2CppReferenceArray_1_ParticipantMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667042);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667043);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_ParticipantStatusChangedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667044);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667045);
    ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr, 100667046);
  }

  public virtual unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_RoomName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_RoomName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId ParticipantId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_ParticipantId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_ParticipantId_Private_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe RTCParticipantStatus ParticipantStatus
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_ParticipantStatus_Public_get_RTCParticipantStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RTCParticipantStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_ParticipantStatus_Private_set_Void_RTCParticipantStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata> ParticipantMetadata
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_get_ParticipantMetadata_Public_get_Il2CppReferenceArray_1_ParticipantMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_set_ParticipantMetadata_Private_set_Void_Il2CppReferenceArray_1_ParticipantMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<Result>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 382455, RefRangeEnd = 382456, XrefRangeStart = 382415, XrefRangeEnd = 382455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<ParticipantStatusChangedCallbackInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_ParticipantStatusChangedCallbackInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382456, XrefRangeEnd = 382461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ParticipantStatusChangedCallbackInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticipantStatusChangedCallbackInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ParticipantStatusChangedCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Object _ClientData_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProductUserId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _RoomName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__RoomName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__RoomName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ProductUserId _ParticipantId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RTCParticipantStatus _ParticipantStatus_k__BackingField
  {
    get
    {
      return *(RTCParticipantStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantStatus_k__BackingField));
    }
    [param: In] set
    {
      *(RTCParticipantStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantStatus_k__BackingField)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata> _ParticipantMetadata_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantMetadata_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Epic.OnlineServices.RTC.ParticipantMetadata>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticipantStatusChangedCallbackInfo.NativeFieldInfoPtr__ParticipantMetadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
