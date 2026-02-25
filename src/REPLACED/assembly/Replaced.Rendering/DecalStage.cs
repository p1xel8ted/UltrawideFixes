// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DecalStage
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class DecalStage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__decalManager;
  private static readonly System.IntPtr NativeFieldInfoPtr__decalBufferPass;
  private static readonly System.IntPtr NativeFieldInfoPtr__maskDecalPass;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DecalManager_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_DecalStageFrameStats_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_DecalStageFrameStats_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static DecalStage()
  {
    Il2CppClassPointerStore<DecalStage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DecalStage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalStage>.NativeClassPtr);
    DecalStage.NativeFieldInfoPtr__decalManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, nameof (_decalManager));
    DecalStage.NativeFieldInfoPtr__decalBufferPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, nameof (_decalBufferPass));
    DecalStage.NativeFieldInfoPtr__maskDecalPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, nameof (_maskDecalPass));
    DecalStage.NativeMethodInfoPtr__ctor_Public_Void_DecalManager_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, 100663721);
    DecalStage.NativeMethodInfoPtr_Encode_Public_DecalStageFrameStats_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, 100663722);
    DecalStage.NativeMethodInfoPtr_Encode_Public_DecalStageFrameStats_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, 100663723);
    DecalStage.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, 100663724);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928074, RefRangeEnd = 928075, XrefRangeStart = 928033, XrefRangeEnd = 928074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecalStage(DecalManager decalManager, Shader maskDecalShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalStage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decalManager);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecalShader);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalStage.NativeMethodInfoPtr__ctor_Public_Void_DecalManager_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928075, XrefRangeEnd = 928084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecalStageFrameStats Encode(
    [In] ref ScriptableRenderContext ctx,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalStage.NativeMethodInfoPtr_Encode_Public_DecalStageFrameStats_byref_ScriptableRenderContext_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DecalStageFrameStats*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 928112, RefRangeEnd = 928115, XrefRangeStart = 928084, XrefRangeEnd = 928112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecalStageFrameStats Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    SceneFrame frame,
    [In] ref FrameRenderingParams frp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frame);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalStage.NativeMethodInfoPtr_Encode_Public_DecalStageFrameStats_byref_ScriptableRenderContext_CommandBuffer_SceneFrame_byref_FrameRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DecalStageFrameStats*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928137, RefRangeEnd = 928138, XrefRangeStart = 928115, XrefRangeEnd = 928137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalStage.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DecalManager _decalManager
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalStage.NativeFieldInfoPtr__decalManager));
      return num == System.IntPtr.Zero ? (DecalManager) null : Il2CppObjectPool.Get<DecalManager>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalStage.NativeFieldInfoPtr__decalManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DecalBufferPass _decalBufferPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalStage.NativeFieldInfoPtr__decalBufferPass));
      return num == System.IntPtr.Zero ? (DecalBufferPass) null : Il2CppObjectPool.Get<DecalBufferPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalStage.NativeFieldInfoPtr__decalBufferPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MaskDecalPass _maskDecalPass
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalStage.NativeFieldInfoPtr__maskDecalPass));
      return num == System.IntPtr.Zero ? (MaskDecalPass) null : Il2CppObjectPool.Get<MaskDecalPass>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalStage.NativeFieldInfoPtr__maskDecalPass), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DecalVertexShaderData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_worldMatrix;
    [FieldOffset(0)]
    public Matrix4x4 worldMatrix;

    static DecalVertexShaderData()
    {
      Il2CppClassPointerStore<DecalStage.DecalVertexShaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, nameof (DecalVertexShaderData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalStage.DecalVertexShaderData>.NativeClassPtr);
      DecalStage.DecalVertexShaderData.NativeFieldInfoPtr_worldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalVertexShaderData>.NativeClassPtr, nameof (worldMatrix));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalStage.DecalVertexShaderData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DecalMaterialCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_baseColorAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_specularColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_smoothness;
    private static readonly System.IntPtr NativeFieldInfoPtr_emissionColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_baseColorInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_normalMapInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_specularColorInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_smoothnessInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_emissionColorInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public Vector4 baseColorAlpha;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 specularColor;
    [FieldOffset(32 /*0x20*/)]
    public float smoothness;
    [FieldOffset(36)]
    public Vector3 emissionColor;
    [FieldOffset(48 /*0x30*/)]
    public float baseColorInfluence;
    [FieldOffset(52)]
    public float normalMapInfluence;
    [FieldOffset(56)]
    public float specularColorInfluence;
    [FieldOffset(60)]
    public float smoothnessInfluence;
    [FieldOffset(64 /*0x40*/)]
    public float emissionColorInfluence;
    [FieldOffset(68)]
    public Vector3 padding;

    static DecalMaterialCBufferData()
    {
      Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, nameof (DecalMaterialCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr);
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_baseColorAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (baseColorAlpha));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_specularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (specularColor));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_smoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (smoothness));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_emissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (emissionColor));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_baseColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (baseColorInfluence));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_normalMapInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (normalMapInfluence));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_specularColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (specularColorInfluence));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_smoothnessInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (smoothnessInfluence));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_emissionColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (emissionColorInfluence));
      DecalStage.DecalMaterialCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalStage.DecalMaterialCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DecalFragmentShaderData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_worldToObjectMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_baseColorUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_specularColorUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_normalMapUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_emissionColorUvScaleOffset;
    [FieldOffset(0)]
    public Matrix4x4 worldToObjectMatrix;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 baseColorUvScaleOffset;
    [FieldOffset(80 /*0x50*/)]
    public Vector4 specularColorUvScaleOffset;
    [FieldOffset(96 /*0x60*/)]
    public Vector4 normalMapUvScaleOffset;
    [FieldOffset(112 /*0x70*/)]
    public Vector4 emissionColorUvScaleOffset;

    static DecalFragmentShaderData()
    {
      Il2CppClassPointerStore<DecalStage.DecalFragmentShaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalStage>.NativeClassPtr, nameof (DecalFragmentShaderData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalStage.DecalFragmentShaderData>.NativeClassPtr);
      DecalStage.DecalFragmentShaderData.NativeFieldInfoPtr_worldToObjectMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalFragmentShaderData>.NativeClassPtr, nameof (worldToObjectMatrix));
      DecalStage.DecalFragmentShaderData.NativeFieldInfoPtr_baseColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalFragmentShaderData>.NativeClassPtr, nameof (baseColorUvScaleOffset));
      DecalStage.DecalFragmentShaderData.NativeFieldInfoPtr_specularColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalFragmentShaderData>.NativeClassPtr, nameof (specularColorUvScaleOffset));
      DecalStage.DecalFragmentShaderData.NativeFieldInfoPtr_normalMapUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalFragmentShaderData>.NativeClassPtr, nameof (normalMapUvScaleOffset));
      DecalStage.DecalFragmentShaderData.NativeFieldInfoPtr_emissionColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalStage.DecalFragmentShaderData>.NativeClassPtr, nameof (emissionColorUvScaleOffset));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalStage.DecalFragmentShaderData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
