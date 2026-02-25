// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.CreatePresenceModificationOptionsInternal
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
public struct CreatePresenceModificationOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CreatePresenceModificationOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;

  static CreatePresenceModificationOptionsInternal()
  {
    Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (CreatePresenceModificationOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr);
    CreatePresenceModificationOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CreatePresenceModificationOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    CreatePresenceModificationOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr, 100667254);
    CreatePresenceModificationOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreatePresenceModificationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr, 100667255);
    CreatePresenceModificationOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr, 100667256);
    CreatePresenceModificationOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr, 100667257);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383073, XrefRangeEnd = 383077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreatePresenceModificationOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383077, XrefRangeEnd = 383081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CreatePresenceModificationOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreatePresenceModificationOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreatePresenceModificationOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383081, XrefRangeEnd = 383087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreatePresenceModificationOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383087, XrefRangeEnd = 383091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreatePresenceModificationOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreatePresenceModificationOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
