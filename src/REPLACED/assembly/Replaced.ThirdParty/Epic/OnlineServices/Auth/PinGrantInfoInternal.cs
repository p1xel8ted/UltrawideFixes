// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.PinGrantInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Auth;

[StructLayout(LayoutKind.Explicit)]
public struct PinGrantInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_VerificationURI;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExpiresIn;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_VerificationURIComplete;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserCode_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserCode_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VerificationURI_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PinGrantInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_UserCode;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_VerificationURI;
  [FieldOffset(24)]
  public int m_ExpiresIn;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_VerificationURIComplete;

  static PinGrantInfoInternal()
  {
    Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (PinGrantInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr);
    PinGrantInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    PinGrantInfoInternal.NativeFieldInfoPtr_m_UserCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_UserCode));
    PinGrantInfoInternal.NativeFieldInfoPtr_m_VerificationURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_VerificationURI));
    PinGrantInfoInternal.NativeFieldInfoPtr_m_ExpiresIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_ExpiresIn));
    PinGrantInfoInternal.NativeFieldInfoPtr_m_VerificationURIComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, nameof (m_VerificationURIComplete));
    PinGrantInfoInternal.NativeMethodInfoPtr_get_UserCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672290);
    PinGrantInfoInternal.NativeMethodInfoPtr_set_UserCode_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672291);
    PinGrantInfoInternal.NativeMethodInfoPtr_get_VerificationURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672292);
    PinGrantInfoInternal.NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672293);
    PinGrantInfoInternal.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672294);
    PinGrantInfoInternal.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672295);
    PinGrantInfoInternal.NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672296);
    PinGrantInfoInternal.NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672297);
    PinGrantInfoInternal.NativeMethodInfoPtr_Set_Public_Void_PinGrantInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672298);
    PinGrantInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672299);
    PinGrantInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, 100672300);
  }

  public unsafe string UserCode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398976, XrefRangeEnd = 398980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_get_UserCode_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398980, XrefRangeEnd = 398984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_set_UserCode_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string VerificationURI
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398984, XrefRangeEnd = 398988, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_get_VerificationURI_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398988, XrefRangeEnd = 398992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_set_VerificationURI_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int ExpiresIn
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_get_ExpiresIn_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_set_ExpiresIn_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string VerificationURIComplete
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398992, XrefRangeEnd = 398996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_get_VerificationURIComplete_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398996, XrefRangeEnd = 399000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_set_VerificationURIComplete_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 399012, RefRangeEnd = 399013, XrefRangeStart = 399000, XrefRangeEnd = 399012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(PinGrantInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_Set_Public_Void_PinGrantInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399013, XrefRangeEnd = 399016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399016, XrefRangeEnd = 399022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PinGrantInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PinGrantInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
