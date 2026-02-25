// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.RegisterPlayersCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct RegisterPlayersCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RegisteredPlayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RegisteredPlayersCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SanctionedPlayers;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SanctionedPlayersCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RegisteredPlayers_Public_get_Il2CppReferenceArray_1_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SanctionedPlayers_Public_get_Il2CppReferenceArray_1_ProductUserId_0;
  [FieldOffset(0)]
  public Result m_ResultCode;
  [FieldOffset(8)]
  public System.IntPtr m_ClientData;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RegisteredPlayers;
  [FieldOffset(24)]
  public uint m_RegisteredPlayersCount;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_SanctionedPlayers;
  [FieldOffset(40)]
  public uint m_SanctionedPlayersCount;

  static RegisterPlayersCallbackInfoInternal()
  {
    Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (RegisterPlayersCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr);
    RegisterPlayersCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
    RegisterPlayersCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    RegisterPlayersCallbackInfoInternal.NativeFieldInfoPtr_m_RegisteredPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, nameof (m_RegisteredPlayers));
    RegisterPlayersCallbackInfoInternal.NativeFieldInfoPtr_m_RegisteredPlayersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, nameof (m_RegisteredPlayersCount));
    RegisterPlayersCallbackInfoInternal.NativeFieldInfoPtr_m_SanctionedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, nameof (m_SanctionedPlayers));
    RegisterPlayersCallbackInfoInternal.NativeFieldInfoPtr_m_SanctionedPlayersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, nameof (m_SanctionedPlayersCount));
    RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, 100665670);
    RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, 100665671);
    RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, 100665672);
    RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_RegisteredPlayers_Public_get_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, 100665673);
    RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_SanctionedPlayers_Public_get_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, 100665674);
  }

  public unsafe Result ResultCode
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378096, XrefRangeEnd = 378100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppReferenceArray<ProductUserId> RegisteredPlayers
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378100, XrefRangeEnd = 378106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_RegisteredPlayers_Public_get_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<ProductUserId>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ProductUserId>>(num3);
    }
  }

  public unsafe Il2CppReferenceArray<ProductUserId> SanctionedPlayers
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378106, XrefRangeEnd = 378112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterPlayersCallbackInfoInternal.NativeMethodInfoPtr_get_SanctionedPlayers_Public_get_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<ProductUserId>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ProductUserId>>(num3);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterPlayersCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
