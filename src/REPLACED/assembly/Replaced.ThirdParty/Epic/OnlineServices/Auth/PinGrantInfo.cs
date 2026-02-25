// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.PinGrantInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

public class PinGrantInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__UserCode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__VerificationURI_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ExpiresIn_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__VerificationURIComplete_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserCode_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserCode_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VerificationURI_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PinGrantInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PinGrantInfo()
  {
    Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (PinGrantInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr);
    PinGrantInfo.NativeFieldInfoPtr__UserCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, "<UserCode>k__BackingField");
    PinGrantInfo.NativeFieldInfoPtr__VerificationURI_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, "<VerificationURI>k__BackingField");
    PinGrantInfo.NativeFieldInfoPtr__ExpiresIn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, "<ExpiresIn>k__BackingField");
    PinGrantInfo.NativeFieldInfoPtr__VerificationURIComplete_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, "<VerificationURIComplete>k__BackingField");
    PinGrantInfo.NativeMethodInfoPtr_get_UserCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672279);
    PinGrantInfo.NativeMethodInfoPtr_set_UserCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672280);
    PinGrantInfo.NativeMethodInfoPtr_get_VerificationURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672281);
    PinGrantInfo.NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672282);
    PinGrantInfo.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672283);
    PinGrantInfo.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672284);
    PinGrantInfo.NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672285);
    PinGrantInfo.NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672286);
    PinGrantInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PinGrantInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672287);
    PinGrantInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672288);
    PinGrantInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr, 100672289);
  }

  public unsafe string UserCode
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_get_UserCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_set_UserCode_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string VerificationURI
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_get_VerificationURI_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int ExpiresIn
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string VerificationURIComplete
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398928, XrefRangeEnd = 398950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<PinGrantInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PinGrantInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398950, XrefRangeEnd = 398976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PinGrantInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PinGrantInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PinGrantInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _UserCode_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PinGrantInfo.NativeFieldInfoPtr__UserCode_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PinGrantInfo.NativeFieldInfoPtr__UserCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _VerificationURI_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PinGrantInfo.NativeFieldInfoPtr__VerificationURI_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PinGrantInfo.NativeFieldInfoPtr__VerificationURI_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int _ExpiresIn_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PinGrantInfo.NativeFieldInfoPtr__ExpiresIn_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PinGrantInfo.NativeFieldInfoPtr__ExpiresIn_k__BackingField)) = value;
    }
  }

  public unsafe string _VerificationURIComplete_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PinGrantInfo.NativeFieldInfoPtr__VerificationURIComplete_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PinGrantInfo.NativeFieldInfoPtr__VerificationURIComplete_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
