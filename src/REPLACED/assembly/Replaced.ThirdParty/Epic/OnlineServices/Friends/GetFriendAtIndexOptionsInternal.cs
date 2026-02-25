// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Friends.GetFriendAtIndexOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Friends;

[StructLayout(LayoutKind.Explicit)]
public struct GetFriendAtIndexOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_GetFriendAtIndexOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public int m_Index;

  static GetFriendAtIndexOptionsInternal()
  {
    Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Friends", nameof (GetFriendAtIndexOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr);
    GetFriendAtIndexOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    GetFriendAtIndexOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    GetFriendAtIndexOptionsInternal.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, nameof (m_Index));
    GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, 100670445);
    GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, 100670446);
    GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_GetFriendAtIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, 100670447);
    GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, 100670448);
    GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, 100670449);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393329, XrefRangeEnd = 393333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int Index
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_set_Index_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393333, XrefRangeEnd = 393337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(GetFriendAtIndexOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_GetFriendAtIndexOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393337, XrefRangeEnd = 393343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393343, XrefRangeEnd = 393347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetFriendAtIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetFriendAtIndexOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
