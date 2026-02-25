// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.UninstallModCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Mods;

[StructLayout(LayoutKind.Explicit)]
public struct UninstallModCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Mod;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Mod_Public_get_ModIdentifier_0;
  [FieldOffset(0)]
  public Result m_ResultCode;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ClientData;
  [FieldOffset(24)]
  public System.IntPtr m_Mod;

  static UninstallModCallbackInfoInternal()
  {
    Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Mods", nameof (UninstallModCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr);
    UninstallModCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
    UninstallModCallbackInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    UninstallModCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    UninstallModCallbackInfoInternal.NativeFieldInfoPtr_m_Mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, nameof (m_Mod));
    UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, 100668707);
    UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, 100668708);
    UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, 100668709);
    UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, 100668710);
    UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_Mod_Public_get_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, 100668711);
  }

  public unsafe Result ResultCode
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387794, XrefRangeEnd = 387800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387800, XrefRangeEnd = 387804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ModIdentifier Mod
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387804, XrefRangeEnd = 387810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UninstallModCallbackInfoInternal.NativeMethodInfoPtr_get_Mod_Public_get_ModIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ModIdentifier) null : Il2CppObjectPool.Get<ModIdentifier>(num3);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UninstallModCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
