// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Friends.OnFriendsUpdateInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Friends;

[StructLayout(LayoutKind.Explicit)]
public struct OnFriendsUpdateInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviousStatus;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentStatus;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PreviousStatus_Public_get_FriendsStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentStatus_Public_get_FriendsStatus_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_TargetUserId;
  [FieldOffset(24)]
  public FriendsStatus m_PreviousStatus;
  [FieldOffset(28)]
  public FriendsStatus m_CurrentStatus;

  static OnFriendsUpdateInfoInternal()
  {
    Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Friends", nameof (OnFriendsUpdateInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr);
    OnFriendsUpdateInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    OnFriendsUpdateInfoInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, nameof (m_LocalUserId));
    OnFriendsUpdateInfoInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, nameof (m_TargetUserId));
    OnFriendsUpdateInfoInternal.NativeFieldInfoPtr_m_PreviousStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, nameof (m_PreviousStatus));
    OnFriendsUpdateInfoInternal.NativeFieldInfoPtr_m_CurrentStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, nameof (m_CurrentStatus));
    OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, 100670497);
    OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, 100670498);
    OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, 100670499);
    OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, 100670500);
    OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_PreviousStatus_Public_get_FriendsStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, 100670501);
    OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_CurrentStatus_Public_get_FriendsStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, 100670502);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393450, XrefRangeEnd = 393454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393454, XrefRangeEnd = 393460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
  }

  public unsafe EpicAccountId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393460, XrefRangeEnd = 393466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_TargetUserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
  }

  public unsafe FriendsStatus PreviousStatus
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_PreviousStatus_Public_get_FriendsStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FriendsStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe FriendsStatus CurrentStatus
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnFriendsUpdateInfoInternal.NativeMethodInfoPtr_get_CurrentStatus_Public_get_FriendsStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FriendsStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnFriendsUpdateInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
