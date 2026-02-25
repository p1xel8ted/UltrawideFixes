// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.AddNotifyAudioBeforeRenderOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio;

[StructLayout(LayoutKind.Explicit)]
public struct AddNotifyAudioBeforeRenderOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UnmixedAudio;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnmixedAudio_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AddNotifyAudioBeforeRenderOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RoomName;
  [FieldOffset(24)]
  public int m_UnmixedAudio;

  static AddNotifyAudioBeforeRenderOptionsInternal()
  {
    Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (AddNotifyAudioBeforeRenderOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr);
    AddNotifyAudioBeforeRenderOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    AddNotifyAudioBeforeRenderOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    AddNotifyAudioBeforeRenderOptionsInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, nameof (m_RoomName));
    AddNotifyAudioBeforeRenderOptionsInternal.NativeFieldInfoPtr_m_UnmixedAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, nameof (m_UnmixedAudio));
    AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, 100666224 /*0x06000B70*/);
    AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, 100666225);
    AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_set_UnmixedAudio_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, 100666226);
    AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_AddNotifyAudioBeforeRenderOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, 100666227);
    AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, 100666228);
    AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, 100666229);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380056, XrefRangeEnd = 380060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380060, XrefRangeEnd = 380064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool UnmixedAudio
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380064, XrefRangeEnd = 380068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_set_UnmixedAudio_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 380080, RefRangeEnd = 380081, XrefRangeStart = 380068, XrefRangeEnd = 380080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(AddNotifyAudioBeforeRenderOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_AddNotifyAudioBeforeRenderOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380081, XrefRangeEnd = 380084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380084, XrefRangeEnd = 380089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddNotifyAudioBeforeRenderOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddNotifyAudioBeforeRenderOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
