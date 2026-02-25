// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.VerifyUserAuthOptionsInternal
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
public struct VerifyUserAuthOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AuthToken;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Token_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_VerifyUserAuthOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_AuthToken;

  static VerifyUserAuthOptionsInternal()
  {
    Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (VerifyUserAuthOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr);
    VerifyUserAuthOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    VerifyUserAuthOptionsInternal.NativeFieldInfoPtr_m_AuthToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, nameof (m_AuthToken));
    VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, 100672439);
    VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_VerifyUserAuthOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, 100672440);
    VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, 100672441);
    VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, 100672442);
  }

  public unsafe Token AuthToken
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 399458, RefRangeEnd = 399460, XrefRangeStart = 399452, XrefRangeEnd = 399458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_set_AuthToken_Public_set_Void_Token_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399460, XrefRangeEnd = 399461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(VerifyUserAuthOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_VerifyUserAuthOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399461, XrefRangeEnd = 399464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399464, XrefRangeEnd = 399468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyUserAuthOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerifyUserAuthOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
