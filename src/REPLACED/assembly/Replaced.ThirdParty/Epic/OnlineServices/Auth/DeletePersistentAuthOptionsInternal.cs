// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.DeletePersistentAuthOptionsInternal
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
public struct DeletePersistentAuthOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RefreshToken;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_DeletePersistentAuthOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_RefreshToken;

  static DeletePersistentAuthOptionsInternal()
  {
    Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (DeletePersistentAuthOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr);
    DeletePersistentAuthOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    DeletePersistentAuthOptionsInternal.NativeFieldInfoPtr_m_RefreshToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, nameof (m_RefreshToken));
    DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, 100672090);
    DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_DeletePersistentAuthOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, 100672091);
    DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, 100672092);
    DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, 100672093);
  }

  public unsafe string RefreshToken
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398483, XrefRangeEnd = 398487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_set_RefreshToken_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398487, XrefRangeEnd = 398491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(DeletePersistentAuthOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_DeletePersistentAuthOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398491, XrefRangeEnd = 398497, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 398497, XrefRangeEnd = 398501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DeletePersistentAuthOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeletePersistentAuthOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
