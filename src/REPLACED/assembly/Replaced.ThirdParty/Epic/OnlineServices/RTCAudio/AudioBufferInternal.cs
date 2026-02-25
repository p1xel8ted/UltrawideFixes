// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.AudioBufferInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio;

[StructLayout(LayoutKind.Explicit)]
public struct AudioBufferInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Frames;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FramesCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SampleRate;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Channels;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AudioBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Frames;
  [FieldOffset(16 /*0x10*/)]
  public uint m_FramesCount;
  [FieldOffset(20)]
  public uint m_SampleRate;
  [FieldOffset(24)]
  public uint m_Channels;

  static AudioBufferInternal()
  {
    Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (AudioBufferInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr);
    AudioBufferInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_ApiVersion));
    AudioBufferInternal.NativeFieldInfoPtr_m_Frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_Frames));
    AudioBufferInternal.NativeFieldInfoPtr_m_FramesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_FramesCount));
    AudioBufferInternal.NativeFieldInfoPtr_m_SampleRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_SampleRate));
    AudioBufferInternal.NativeFieldInfoPtr_m_Channels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, nameof (m_Channels));
    AudioBufferInternal.NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666320 /*0x06000BD0*/);
    AudioBufferInternal.NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666321);
    AudioBufferInternal.NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666322);
    AudioBufferInternal.NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666323);
    AudioBufferInternal.NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666324);
    AudioBufferInternal.NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666325);
    AudioBufferInternal.NativeMethodInfoPtr_Set_Public_Void_AudioBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666326);
    AudioBufferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666327);
    AudioBufferInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, 100666328);
  }

  public unsafe Il2CppStructArray<short> Frames
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380377, XrefRangeEnd = 380383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_get_Frames_Public_get_Il2CppStructArray_1_Int16_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<short>) null : Il2CppObjectPool.Get<Il2CppStructArray<short>>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 380389, RefRangeEnd = 380391, XrefRangeStart = 380383, XrefRangeEnd = 380389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_set_Frames_Public_set_Void_Il2CppStructArray_1_Int16_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint SampleRate
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_get_SampleRate_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_set_SampleRate_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint Channels
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_get_Channels_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_set_Channels_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380391, XrefRangeEnd = 380392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(AudioBuffer other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_Set_Public_Void_AudioBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 380395, RefRangeEnd = 380396, XrefRangeStart = 380392, XrefRangeEnd = 380395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380396, XrefRangeEnd = 380400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioBufferInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AudioBufferInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
