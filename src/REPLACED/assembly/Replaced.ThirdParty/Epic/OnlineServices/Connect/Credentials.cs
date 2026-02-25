// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.Credentials
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

public class Credentials(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Token_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Type_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Token_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Token_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_ExternalCredentialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_ExternalCredentialType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CredentialsInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Credentials()
  {
    Il2CppClassPointerStore<Credentials>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (Credentials));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Credentials>.NativeClassPtr);
    Credentials.NativeFieldInfoPtr__Token_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credentials>.NativeClassPtr, "<Token>k__BackingField");
    Credentials.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Credentials>.NativeClassPtr, "<Type>k__BackingField");
    Credentials.NativeMethodInfoPtr_get_Token_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credentials>.NativeClassPtr, 100671572);
    Credentials.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credentials>.NativeClassPtr, 100671573);
    Credentials.NativeMethodInfoPtr_get_Type_Public_get_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credentials>.NativeClassPtr, 100671574);
    Credentials.NativeMethodInfoPtr_set_Type_Public_set_Void_ExternalCredentialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credentials>.NativeClassPtr, 100671575);
    Credentials.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CredentialsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credentials>.NativeClassPtr, 100671576);
    Credentials.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credentials>.NativeClassPtr, 100671577);
    Credentials.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Credentials>.NativeClassPtr, 100671578);
  }

  public unsafe string Token
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Credentials.NativeMethodInfoPtr_get_Token_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Credentials.NativeMethodInfoPtr_set_Token_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ExternalCredentialType Type
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Credentials.NativeMethodInfoPtr_get_Type_Public_get_ExternalCredentialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ExternalCredentialType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Credentials.NativeMethodInfoPtr_set_Type_Public_set_Void_ExternalCredentialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396970, XrefRangeEnd = 396980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<CredentialsInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Credentials.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_CredentialsInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396980, XrefRangeEnd = 396994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Credentials.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Credentials()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Credentials>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Credentials.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _Token_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Credentials.NativeFieldInfoPtr__Token_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Credentials.NativeFieldInfoPtr__Token_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ExternalCredentialType _Type_k__BackingField
  {
    get
    {
      return *(ExternalCredentialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Credentials.NativeFieldInfoPtr__Type_k__BackingField));
    }
    [param: In] set
    {
      *(ExternalCredentialType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Credentials.NativeFieldInfoPtr__Type_k__BackingField)) = value;
    }
  }
}
