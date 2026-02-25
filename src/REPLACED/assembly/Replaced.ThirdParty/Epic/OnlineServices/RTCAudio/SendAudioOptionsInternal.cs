// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.SendAudioOptionsInternal
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
public struct SendAudioOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Buffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Buffer_Public_set_Void_AudioBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SendAudioOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_RoomName;
  [FieldOffset(24)]
  public System.IntPtr m_Buffer;

  static SendAudioOptionsInternal()
  {
    Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (SendAudioOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr);
    SendAudioOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SendAudioOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    SendAudioOptionsInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, nameof (m_RoomName));
    SendAudioOptionsInternal.NativeFieldInfoPtr_m_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, nameof (m_Buffer));
    SendAudioOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, 100666563);
    SendAudioOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, 100666564);
    SendAudioOptionsInternal.NativeMethodInfoPtr_set_Buffer_Public_set_Void_AudioBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, 100666565);
    SendAudioOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SendAudioOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, 100666566);
    SendAudioOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, 100666567);
    SendAudioOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, 100666568);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381142, XrefRangeEnd = 381146, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendAudioOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string RoomName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381146, XrefRangeEnd = 381150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendAudioOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AudioBuffer Buffer
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 381156, RefRangeEnd = 381157, XrefRangeStart = 381150, XrefRangeEnd = 381156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SendAudioOptionsInternal.NativeMethodInfoPtr_set_Buffer_Public_set_Void_AudioBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 381166, RefRangeEnd = 381167, XrefRangeStart = 381157, XrefRangeEnd = 381166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SendAudioOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendAudioOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SendAudioOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381167, XrefRangeEnd = 381170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendAudioOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 381170, XrefRangeEnd = 381176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SendAudioOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SendAudioOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
