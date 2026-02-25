// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.VerifyIdTokenCallbackInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

public class VerifyIdTokenCallbackInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ResultCode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ApplicationId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ProductId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SandboxId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DeploymentId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DisplayName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsExternalAccountInfoPresent_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ExternalAccountIdType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ExternalAccountId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ExternalAccountDisplayName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Platform_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ResultCode_Private_set_Void_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ApplicationId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ApplicationId_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientId_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductId_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SandboxId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SandboxId_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DeploymentId_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExternalAccountInfoPresent_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsExternalAccountInfoPresent_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalAccountIdType_Public_get_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalAccountIdType_Private_set_Void_ExternalAccountType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalAccountId_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalAccountDisplayName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalAccountDisplayName_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Platform_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Platform_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_VerifyIdTokenCallbackInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VerifyIdTokenCallbackInfo()
  {
    Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (VerifyIdTokenCallbackInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr);
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ResultCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<ResultCode>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<ClientData>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ApplicationId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<ApplicationId>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ClientId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<ClientId>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ProductId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<ProductId>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__SandboxId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<SandboxId>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__DeploymentId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<DeploymentId>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__DisplayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<DisplayName>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__IsExternalAccountInfoPresent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<IsExternalAccountInfoPresent>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountIdType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<ExternalAccountIdType>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<ExternalAccountId>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountDisplayName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<ExternalAccountDisplayName>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__Platform_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, "<Platform>k__BackingField");
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672374);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ResultCode_Private_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672375);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672376);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672377);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ApplicationId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672378);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ApplicationId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672379);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ClientId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672380);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ClientId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672381);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ProductId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672382);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ProductId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672383);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_SandboxId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672384);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_SandboxId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672385);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672386);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_DeploymentId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672387);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672388);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_DisplayName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672389);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_IsExternalAccountInfoPresent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672390);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_IsExternalAccountInfoPresent_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672391);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ExternalAccountIdType_Public_get_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672392);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ExternalAccountIdType_Private_set_Void_ExternalAccountType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672393);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672394);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ExternalAccountId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672395);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ExternalAccountDisplayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672396);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ExternalAccountDisplayName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672397);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_Platform_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672398);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_Platform_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672399);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672400);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_VerifyIdTokenCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672401);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672402);
    VerifyIdTokenCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr, 100672403);
  }

  public unsafe Result ResultCode
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ResultCode_Private_set_Void_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ApplicationId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ApplicationId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ApplicationId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ClientId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ClientId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ClientId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductId
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ProductId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ProductId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string SandboxId
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_SandboxId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_SandboxId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DeploymentId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_DeploymentId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_DeploymentId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DisplayName
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_DisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_DisplayName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsExternalAccountInfoPresent
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_IsExternalAccountInfoPresent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_IsExternalAccountInfoPresent_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalAccountType ExternalAccountIdType
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 74758, RefRangeEnd = 74763, XrefRangeStart = 74758, XrefRangeEnd = 74763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ExternalAccountIdType_Public_get_ExternalAccountType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalAccountType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ExternalAccountIdType_Private_set_Void_ExternalAccountType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ExternalAccountId
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ExternalAccountId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(7), CachedScanResults(RefRangeStart = 80450, RefRangeEnd = 80457, XrefRangeStart = 80450, XrefRangeEnd = 80457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ExternalAccountId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ExternalAccountDisplayName
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_ExternalAccountDisplayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_ExternalAccountDisplayName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Platform
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_get_Platform_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_set_Platform_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399280, XrefRangeEnd = 399283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Nullable<Result> GetResultCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<Result>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 399355, RefRangeEnd = 399356, XrefRangeStart = 399283, XrefRangeEnd = 399355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<VerifyIdTokenCallbackInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_VerifyIdTokenCallbackInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399356, XrefRangeEnd = 399361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VerifyIdTokenCallbackInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerifyIdTokenCallbackInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Result _ResultCode_k__BackingField
  {
    get
    {
      return *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ResultCode_k__BackingField));
    }
    [param: In] set
    {
      *(Result*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ResultCode_k__BackingField)) = value;
    }
  }

  public unsafe Il2CppSystem.Object _ClientData_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _ApplicationId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ApplicationId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ApplicationId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _ClientId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ClientId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ClientId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _ProductId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ProductId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ProductId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _SandboxId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__SandboxId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__SandboxId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _DeploymentId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__DeploymentId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__DeploymentId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _DisplayName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__DisplayName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__DisplayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool _IsExternalAccountInfoPresent_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__IsExternalAccountInfoPresent_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__IsExternalAccountInfoPresent_k__BackingField)) = value;
    }
  }

  public unsafe ExternalAccountType _ExternalAccountIdType_k__BackingField
  {
    get
    {
      return *(ExternalAccountType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountIdType_k__BackingField));
    }
    [param: In] set
    {
      *(ExternalAccountType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountIdType_k__BackingField)) = value;
    }
  }

  public unsafe string _ExternalAccountId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _ExternalAccountDisplayName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountDisplayName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__ExternalAccountDisplayName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _Platform_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__Platform_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VerifyIdTokenCallbackInfo.NativeFieldInfoPtr__Platform_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
