// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAdmin.KickOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAdmin;

[StructLayout(LayoutKind.Explicit)]
public struct KickOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_KickOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_RoomName;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_TargetUserId;

  static KickOptionsInternal()
  {
    Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAdmin", nameof (KickOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr);
    KickOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    KickOptionsInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, nameof (m_RoomName));
    KickOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    KickOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, 100666713);
    KickOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, 100666714);
    KickOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_KickOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, 100666715);
    KickOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, 100666716);
    KickOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, 100666717);
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381514, XrefRangeEnd = 381518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(KickOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381518, XrefRangeEnd = 381522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(KickOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 381530, RefRangeEnd = 381531, XrefRangeStart = 381522, XrefRangeEnd = 381530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(KickOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KickOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_KickOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381531, XrefRangeEnd = 381534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KickOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381534, XrefRangeEnd = 381539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KickOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KickOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
