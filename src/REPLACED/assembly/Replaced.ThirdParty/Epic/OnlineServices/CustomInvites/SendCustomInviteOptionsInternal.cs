// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.CustomInvites.SendCustomInviteOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.CustomInvites;

[StructLayout(LayoutKind.Explicit)]
public struct SendCustomInviteOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserIdsCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SendCustomInviteOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_TargetUserIds;
  [FieldOffset(24)]
  public uint m_TargetUserIdsCount;

  static SendCustomInviteOptionsInternal()
  {
    Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.CustomInvites", nameof (SendCustomInviteOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr);
    SendCustomInviteOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SendCustomInviteOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    SendCustomInviteOptionsInternal.NativeFieldInfoPtr_m_TargetUserIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, nameof (m_TargetUserIds));
    SendCustomInviteOptionsInternal.NativeFieldInfoPtr_m_TargetUserIdsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, nameof (m_TargetUserIdsCount));
    SendCustomInviteOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, 100671416);
    SendCustomInviteOptionsInternal.NativeMethodInfoPtr_set_TargetUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, 100671417);
    SendCustomInviteOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SendCustomInviteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, 100671418);
    SendCustomInviteOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, 100671419);
    SendCustomInviteOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, 100671420);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396246, XrefRangeEnd = 396250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendCustomInviteOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<ProductUserId> TargetUserIds
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 396256, RefRangeEnd = 396258, XrefRangeStart = 396250, XrefRangeEnd = 396256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendCustomInviteOptionsInternal.NativeMethodInfoPtr_set_TargetUserIds_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396258, XrefRangeEnd = 396263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SendCustomInviteOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendCustomInviteOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SendCustomInviteOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396263, XrefRangeEnd = 396270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendCustomInviteOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396270, XrefRangeEnd = 396275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendCustomInviteOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendCustomInviteOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
