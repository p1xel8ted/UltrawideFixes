// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Friends.GetFriendsCountOptionsInternal
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
public struct GetFriendsCountOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_GetFriendsCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;

  static GetFriendsCountOptionsInternal()
  {
    Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Friends", nameof (GetFriendsCountOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr);
    GetFriendsCountOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    GetFriendsCountOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    GetFriendsCountOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr, 100670453);
    GetFriendsCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_GetFriendsCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr, 100670454);
    GetFriendsCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr, 100670455);
    GetFriendsCountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr, 100670456);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393347, XrefRangeEnd = 393351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GetFriendsCountOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393351, XrefRangeEnd = 393355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(GetFriendsCountOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetFriendsCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_GetFriendsCountOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393355, XrefRangeEnd = 393361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetFriendsCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 393361, XrefRangeEnd = 393365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GetFriendsCountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GetFriendsCountOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
