// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchFilterSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BatchFilterSettings
{
  private static readonly System.IntPtr NativeFieldInfoPtr_renderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_rendererPriority;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_sceneCullingMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_layer;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_batchLayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_motionMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_shadowMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_receiveShadows;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_staticShadowCaster;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_allDepthSorted;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_isSceneCullingMaskSet;
  [FieldOffset(0)]
  public uint renderingLayerMask;
  [FieldOffset(4)]
  public int rendererPriority;
  [FieldOffset(8)]
  public ulong m_sceneCullingMask;
  [FieldOffset(16 /*0x10*/)]
  public byte layer;
  [FieldOffset(17)]
  public byte m_batchLayer;
  [FieldOffset(18)]
  public byte m_motionMode;
  [FieldOffset(19)]
  public byte m_shadowMode;
  [FieldOffset(20)]
  public byte m_receiveShadows;
  [FieldOffset(21)]
  public byte m_staticShadowCaster;
  [FieldOffset(22)]
  public byte m_allDepthSorted;
  [FieldOffset(23)]
  public byte m_isSceneCullingMaskSet;
  private static readonly BatchFilterSettings.DefaultCullingMaskDelegate DefaultCullingMaskDelegateField;

  static BatchFilterSettings()
  {
    Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchFilterSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr);
    BatchFilterSettings.NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (renderingLayerMask));
    BatchFilterSettings.NativeFieldInfoPtr_rendererPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (rendererPriority));
    BatchFilterSettings.NativeFieldInfoPtr_m_sceneCullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (m_sceneCullingMask));
    BatchFilterSettings.NativeFieldInfoPtr_layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (layer));
    BatchFilterSettings.NativeFieldInfoPtr_m_batchLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (m_batchLayer));
    BatchFilterSettings.NativeFieldInfoPtr_m_motionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (m_motionMode));
    BatchFilterSettings.NativeFieldInfoPtr_m_shadowMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (m_shadowMode));
    BatchFilterSettings.NativeFieldInfoPtr_m_receiveShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (m_receiveShadows));
    BatchFilterSettings.NativeFieldInfoPtr_m_staticShadowCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (m_staticShadowCaster));
    BatchFilterSettings.NativeFieldInfoPtr_m_allDepthSorted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (m_allDepthSorted));
    BatchFilterSettings.NativeFieldInfoPtr_m_isSceneCullingMaskSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, nameof (m_isSceneCullingMaskSet));
    BatchFilterSettings.DefaultCullingMaskDelegateField = IL2CPP.ResolveICall<BatchFilterSettings.DefaultCullingMaskDelegate>("UnityEngine.Rendering.BatchFilterSettings::DefaultCullingMask");
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchFilterSettings>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public byte batchLayer
  {
    get => this.m_batchLayer;
    set => this.m_batchLayer = value;
  }

  public MotionVectorGenerationMode motionMode
  {
    get => (MotionVectorGenerationMode) this.m_motionMode;
    set => this.m_motionMode = (byte) value;
  }

  public ShadowCastingMode shadowCastingMode
  {
    get => (ShadowCastingMode) this.m_shadowMode;
    set => this.m_shadowMode = (byte) value;
  }

  public bool receiveShadows
  {
    get => this.m_receiveShadows > (byte) 0;
    set => this.m_receiveShadows = value ? (byte) 1 : (byte) 0;
  }

  public bool staticShadowCaster
  {
    get => this.m_staticShadowCaster > (byte) 0;
    set => this.m_staticShadowCaster = value ? (byte) 1 : (byte) 0;
  }

  public bool allDepthSorted
  {
    get => this.m_allDepthSorted > (byte) 0;
    set => this.m_allDepthSorted = value ? (byte) 1 : (byte) 0;
  }

  public static ulong DefaultCullingMask() => BatchFilterSettings.DefaultCullingMaskDelegateField();

  public ulong sceneCullingMask
  {
    get
    {
      return this.m_isSceneCullingMaskSet == (byte) 0 ? BatchFilterSettings.DefaultCullingMask() : this.m_sceneCullingMask;
    }
    set
    {
      this.m_isSceneCullingMaskSet = (byte) 1;
      this.m_sceneCullingMask = value;
    }
  }

  private delegate ulong DefaultCullingMaskDelegate();
}
