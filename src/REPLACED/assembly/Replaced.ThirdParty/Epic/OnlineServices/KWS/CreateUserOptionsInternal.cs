// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.KWS.CreateUserOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.KWS;

[StructLayout(LayoutKind.Explicit)]
public struct CreateUserOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DateOfBirth;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParentEmail;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DateOfBirth_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParentEmail_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CreateUserOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_DateOfBirth;
  [FieldOffset(24)]
  public System.IntPtr m_ParentEmail;

  static CreateUserOptionsInternal()
  {
    Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.KWS", nameof (CreateUserOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr);
    CreateUserOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CreateUserOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    CreateUserOptionsInternal.NativeFieldInfoPtr_m_DateOfBirth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, nameof (m_DateOfBirth));
    CreateUserOptionsInternal.NativeFieldInfoPtr_m_ParentEmail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, nameof (m_ParentEmail));
    CreateUserOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100670180);
    CreateUserOptionsInternal.NativeMethodInfoPtr_set_DateOfBirth_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100670181);
    CreateUserOptionsInternal.NativeMethodInfoPtr_set_ParentEmail_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100670182);
    CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreateUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100670183);
    CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100670184);
    CreateUserOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100670185);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392415, XrefRangeEnd = 392419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DateOfBirth
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392419, XrefRangeEnd = 392423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_set_DateOfBirth_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ParentEmail
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392423, XrefRangeEnd = 392427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_set_ParentEmail_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 392439, RefRangeEnd = 392440, XrefRangeStart = 392427, XrefRangeEnd = 392439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CreateUserOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreateUserOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392440, XrefRangeEnd = 392443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392443, XrefRangeEnd = 392449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
