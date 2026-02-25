// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderPipelineAsset
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

#nullable disable
namespace UnityEngine.Rendering;

public class RenderPipelineAsset(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultSpeedTree9Shader_Public_Virtual_New_get_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_pipelineType_Public_Virtual_New_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_pipelineTypeFullName_Internal_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureGlobalSettings_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderPipelineType_FamOrAssem_Virtual_New_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static RenderPipelineAsset()
  {
    Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderPipelineAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr);
    RenderPipelineAsset.NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670425);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670426);
    RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670427);
    RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670428);
    RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670429);
    RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670430);
    RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670431);
    RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670432);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670433);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670434);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670435);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670436);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670437);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670438);
    RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670439);
    RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670440);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670441);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670442);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670443);
    RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree9Shader_Public_Virtual_New_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670444);
    RenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670445);
    RenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670446);
    RenderPipelineAsset.NativeMethodInfoPtr_get_pipelineType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670447);
    RenderPipelineAsset.NativeMethodInfoPtr_get_pipelineTypeFullName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670448);
    RenderPipelineAsset.NativeMethodInfoPtr_EnsureGlobalSettings_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670449);
    RenderPipelineAsset.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670450);
    RenderPipelineAsset.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670451);
    RenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineType_FamOrAssem_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670452);
    RenderPipelineAsset.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670453);
    RenderPipelineAsset.NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670454);
    RenderPipelineAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr, 100670455);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487787, RefRangeEnd = 487788, XrefRangeStart = 487786, XrefRangeEnd = 487787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderPipeline InternalCreatePipeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr_InternalCreatePipeline_Internal_RenderPipeline_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (RenderPipeline) null : Il2CppObjectPool.Get<RenderPipeline>(num3);
  }

  public virtual unsafe Material defaultMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Shader autodeskInteractiveShader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Shader autodeskInteractiveTransparentShader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveTransparentShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Shader autodeskInteractiveMaskedShader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_autodeskInteractiveMaskedShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Shader terrainDetailLitShader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailLitShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Shader terrainDetailGrassShader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Shader terrainDetailGrassBillboardShader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_terrainDetailGrassBillboardShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Material defaultParticleMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultParticleMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Material defaultLineMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultLineMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Material defaultTerrainMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultTerrainMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Material defaultUIMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Material defaultUIOverdrawMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIOverdrawMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Material defaultUIETC1SupportedMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultUIETC1SupportedMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Material default2DMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Material default2DMaskMaterial
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_default2DMaskMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
  }

  public virtual unsafe Shader defaultShader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultShader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Shader defaultSpeedTree7Shader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree7Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Shader defaultSpeedTree8Shader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree8Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe Shader defaultSpeedTree9Shader
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_defaultSpeedTree9Shader_Public_Virtual_New_get_Shader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
    }
  }

  public virtual unsafe string renderPipelineShaderTag
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487788, XrefRangeEnd = 487795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe RenderPipeline CreatePipeline()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_CreatePipeline_Protected_Abstract_Virtual_New_RenderPipeline_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (RenderPipeline) null : Il2CppObjectPool.Get<RenderPipeline>(num3);
  }

  public virtual unsafe Il2CppSystem.Type pipelineType
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487795, XrefRangeEnd = 487801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_pipelineType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
    }
  }

  public unsafe string pipelineTypeFullName
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 487802, RefRangeEnd = 487804, XrefRangeStart = 487801, XrefRangeEnd = 487802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr_get_pipelineTypeFullName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureGlobalSettings()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_EnsureGlobalSettings_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487804, XrefRangeEnd = 487818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_OnValidate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487818, XrefRangeEnd = 487822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe Il2CppSystem.Type renderPipelineType
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487822, XrefRangeEnd = 487828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_renderPipelineType_FamOrAssem_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
    }
  }

  public virtual unsafe Il2CppStringArray renderingLayerMaskNames
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_renderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
  }

  public virtual unsafe Il2CppStringArray prefixedRenderingLayerMaskNames
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset.NativeMethodInfoPtr_get_prefixedRenderingLayerMaskNames_Public_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderPipelineAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineAsset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
