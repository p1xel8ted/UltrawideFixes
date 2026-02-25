// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Auth.VerifyIdTokenOptionsInternal
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
public struct VerifyIdTokenOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IdToken;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IdToken_Public_set_Void_IdToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_VerifyIdTokenOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_IdToken;

  static VerifyIdTokenOptionsInternal()
  {
    Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Auth", nameof (VerifyIdTokenOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr);
    VerifyIdTokenOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    VerifyIdTokenOptionsInternal.NativeFieldInfoPtr_m_IdToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr, nameof (m_IdToken));
    VerifyIdTokenOptionsInternal.NativeMethodInfoPtr_set_IdToken_Public_set_Void_IdToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr, 100672421);
    VerifyIdTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_VerifyIdTokenOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr, 100672422);
    VerifyIdTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr, 100672423);
    VerifyIdTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr, 100672424);
  }

  public unsafe IdToken IdToken
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 399411, RefRangeEnd = 399413, XrefRangeStart = 399405, XrefRangeEnd = 399411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenOptionsInternal.NativeMethodInfoPtr_set_IdToken_Public_set_Void_IdToken_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399413, XrefRangeEnd = 399414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(VerifyIdTokenOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_VerifyIdTokenOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399414, XrefRangeEnd = 399417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399417, XrefRangeEnd = 399421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VerifyIdTokenOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VerifyIdTokenOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
