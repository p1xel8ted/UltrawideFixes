// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Audio.G_AudioMonitor
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

#nullable disable
namespace Tayx.Graphy.Audio;

public class G_AudioMonitor(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_refValue;
  private static readonly IntPtr NativeFieldInfoPtr_m_graphyManager;
  private static readonly IntPtr NativeFieldInfoPtr_m_audioListener;
  private static readonly IntPtr NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull;
  private static readonly IntPtr NativeFieldInfoPtr_m_FFTWindow;
  private static readonly IntPtr NativeFieldInfoPtr_m_spectrumSize;
  private static readonly IntPtr NativeFieldInfoPtr_m_spectrum;
  private static readonly IntPtr NativeFieldInfoPtr_m_spectrumHighestValues;
  private static readonly IntPtr NativeFieldInfoPtr_m_maxDB;
  private static readonly IntPtr NativeMethodInfoPtr_get_Spectrum_Public_get_Il2CppStructArray_1_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpectrumHighestValues_Public_get_Il2CppStructArray_1_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SpectrumDataAvailable_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateParameters_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_lin2dB_Public_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_dBNormalized_Public_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_FindAudioListener_Private_AudioListener_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_AudioMonitor()
  {
    Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Audio", nameof (G_AudioMonitor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr);
    G_AudioMonitor.NativeFieldInfoPtr_m_refValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_refValue));
    G_AudioMonitor.NativeFieldInfoPtr_m_graphyManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_graphyManager));
    G_AudioMonitor.NativeFieldInfoPtr_m_audioListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_audioListener));
    G_AudioMonitor.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_findAudioListenerInCameraIfNull));
    G_AudioMonitor.NativeFieldInfoPtr_m_FFTWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_FFTWindow));
    G_AudioMonitor.NativeFieldInfoPtr_m_spectrumSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_spectrumSize));
    G_AudioMonitor.NativeFieldInfoPtr_m_spectrum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_spectrum));
    G_AudioMonitor.NativeFieldInfoPtr_m_spectrumHighestValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_spectrumHighestValues));
    G_AudioMonitor.NativeFieldInfoPtr_m_maxDB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, nameof (m_maxDB));
    G_AudioMonitor.NativeMethodInfoPtr_get_Spectrum_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663632 /*0x06000150*/);
    G_AudioMonitor.NativeMethodInfoPtr_get_SpectrumHighestValues_Public_get_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663633);
    G_AudioMonitor.NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663634);
    G_AudioMonitor.NativeMethodInfoPtr_get_SpectrumDataAvailable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663635);
    G_AudioMonitor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663636);
    G_AudioMonitor.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663637);
    G_AudioMonitor.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663638);
    G_AudioMonitor.NativeMethodInfoPtr_UpdateParameters_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663639);
    G_AudioMonitor.NativeMethodInfoPtr_lin2dB_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663640);
    G_AudioMonitor.NativeMethodInfoPtr_dBNormalized_Public_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663641);
    G_AudioMonitor.NativeMethodInfoPtr_FindAudioListener_Private_AudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663642);
    G_AudioMonitor.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663643);
    G_AudioMonitor.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663644);
    G_AudioMonitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr, 100663645);
  }

  public unsafe Il2CppStructArray<float> Spectrum
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_get_Spectrum_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num3);
    }
  }

  public unsafe Il2CppStructArray<float> SpectrumHighestValues
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_get_SpectrumHighestValues_Public_get_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num3);
    }
  }

  public unsafe float MaxDB
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_get_MaxDB_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool SpectrumDataAvailable
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362866, XrefRangeEnd = 362870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_get_SpectrumDataAvailable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362870, XrefRangeEnd = 362887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362887, XrefRangeEnd = 362895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362895, XrefRangeEnd = 362905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 362915, RefRangeEnd = 362919, XrefRangeStart = 362905, XrefRangeEnd = 362915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateParameters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_UpdateParameters_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 362920, RefRangeEnd = 362924, XrefRangeStart = 362919, XrefRangeEnd = 362920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float lin2dB(float linear)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &linear
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_lin2dB_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe float dBNormalized(float db)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &db
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_dBNormalized_Public_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 362930, RefRangeEnd = 362933, XrefRangeStart = 362924, XrefRangeEnd = 362930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioListener FindAudioListener()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_FindAudioListener_Private_AudioListener_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (AudioListener) null : Il2CppObjectPool.Get<AudioListener>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362933, XrefRangeEnd = 362934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &scene;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &loadSceneMode;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 362934, XrefRangeEnd = 362935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_AudioMonitor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_AudioMonitor>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_AudioMonitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float m_refValue
  {
    get
    {
      float mRefValue;
      IL2CPP.il2cpp_field_static_get_value(G_AudioMonitor.NativeFieldInfoPtr_m_refValue, (void*) &mRefValue);
      return mRefValue;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_AudioMonitor.NativeFieldInfoPtr_m_refValue, (void*) &value);
    }
  }

  public unsafe GraphyManager m_graphyManager
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_graphyManager));
      return num == IntPtr.Zero ? (GraphyManager) null : Il2CppObjectPool.Get<GraphyManager>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_graphyManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AudioListener m_audioListener
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_audioListener));
      return num == IntPtr.Zero ? (AudioListener) null : Il2CppObjectPool.Get<AudioListener>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_audioListener), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphyManager.LookForAudioListener m_findAudioListenerInCameraIfNull
  {
    get
    {
      return *(GraphyManager.LookForAudioListener*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull));
    }
    [param: In] set
    {
      *(GraphyManager.LookForAudioListener*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_findAudioListenerInCameraIfNull)) = value;
    }
  }

  public unsafe FFTWindow m_FFTWindow
  {
    get
    {
      return *(FFTWindow*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_FFTWindow));
    }
    [param: In] set
    {
      *(FFTWindow*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_FFTWindow)) = value;
    }
  }

  public unsafe int m_spectrumSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrumSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrumSize)) = value;
    }
  }

  public unsafe Il2CppStructArray<float> m_spectrum
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrum));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrum), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<float> m_spectrumHighestValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrumHighestValues));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_spectrumHighestValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float m_maxDB
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_maxDB));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_AudioMonitor.NativeFieldInfoPtr_m_maxDB)) = value;
    }
  }
}
