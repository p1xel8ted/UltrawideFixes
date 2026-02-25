// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModificationSetJoinInfoOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence;

[StructLayout(LayoutKind.Explicit)]
public struct PresenceModificationSetJoinInfoOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_JoinInfo;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PresenceModificationSetJoinInfoOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_JoinInfo;

  static PresenceModificationSetJoinInfoOptionsInternal()
  {
    Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (PresenceModificationSetJoinInfoOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr);
    PresenceModificationSetJoinInfoOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    PresenceModificationSetJoinInfoOptionsInternal.NativeFieldInfoPtr_m_JoinInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, nameof (m_JoinInfo));
    PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, 100667439);
    PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_PresenceModificationSetJoinInfoOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, 100667440 /*0x06001030*/);
    PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, 100667441);
    PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, 100667442);
  }

  public unsafe string JoinInfo
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383790, XrefRangeEnd = 383794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383794, XrefRangeEnd = 383798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(PresenceModificationSetJoinInfoOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_PresenceModificationSetJoinInfoOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383798, XrefRangeEnd = 383804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383804, XrefRangeEnd = 383808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
