// Decompiled with JetBrains decompiler
// Type: UnityEngine.SpriteRenderer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Events;

#nullable disable
namespace UnityEngine;

public sealed class SpriteRenderer(IntPtr pointer) : Renderer(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_SpriteChangeEvent;
  private static readonly IntPtr NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0;
  private static readonly IntPtr NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_shouldSupportTiling_Internal_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_hasSpriteChangeEvents_Internal_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_drawMode_Public_get_SpriteDrawMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_drawMode_Public_set_Void_SpriteDrawMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_adaptiveModeThreshold_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_adaptiveModeThreshold_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_tileMode_Public_get_SpriteTileMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_tileMode_Public_set_Void_SpriteTileMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_flipY_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_flipY_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_spriteSortPoint_Public_get_SpriteSortPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_spriteSortPoint_Public_set_Void_SpriteSortPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCurrentMeshDataPtr_Private_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCurrentMeshData_Internal_MeshDataArray_0;
  private static readonly IntPtr NativeMethodInfoPtr_Internal_GetSpriteBounds_Internal_Bounds_SpriteDrawMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTextureProperties_Internal_Void_MaterialPropertyBlock_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSpriteBounds_Internal_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_shouldSupportTiling_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_hasSpriteChangeEvents_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_hasSpriteChangeEvents_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sprite_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sprite_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_drawMode_Injected_Private_Static_SpriteDrawMode_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_drawMode_Injected_Private_Static_Void_IntPtr_SpriteDrawMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_size_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_size_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_adaptiveModeThreshold_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_adaptiveModeThreshold_Injected_Private_Static_Void_IntPtr_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_tileMode_Injected_Private_Static_SpriteTileMode_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_tileMode_Injected_Private_Static_Void_IntPtr_SpriteTileMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_IntPtr_byref_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_maskInteraction_Injected_Private_Static_SpriteMaskInteraction_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_maskInteraction_Injected_Private_Static_Void_IntPtr_SpriteMaskInteraction_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_flipX_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_flipX_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_flipY_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_flipY_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_spriteSortPoint_Injected_Private_Static_SpriteSortPoint_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_spriteSortPoint_Injected_Private_Static_Void_IntPtr_SpriteSortPoint_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCurrentMeshDataPtr_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_Internal_GetSpriteBounds_Injected_Private_Static_Void_IntPtr_SpriteDrawMode_byref_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTextureProperties_Injected_Private_Static_Void_IntPtr_IntPtr_0;

  static SpriteRenderer()
  {
    Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (SpriteRenderer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr);
    SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, nameof (m_SpriteChangeEvent));
    SpriteRenderer.NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663631);
    SpriteRenderer.NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663632 /*0x06000150*/);
    SpriteRenderer.NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663633);
    SpriteRenderer.NativeMethodInfoPtr_get_shouldSupportTiling_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663634);
    SpriteRenderer.NativeMethodInfoPtr_get_hasSpriteChangeEvents_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663635);
    SpriteRenderer.NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663636);
    SpriteRenderer.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663637);
    SpriteRenderer.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663638);
    SpriteRenderer.NativeMethodInfoPtr_get_drawMode_Public_get_SpriteDrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663639);
    SpriteRenderer.NativeMethodInfoPtr_set_drawMode_Public_set_Void_SpriteDrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663640);
    SpriteRenderer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663641);
    SpriteRenderer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663642);
    SpriteRenderer.NativeMethodInfoPtr_get_adaptiveModeThreshold_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663643);
    SpriteRenderer.NativeMethodInfoPtr_set_adaptiveModeThreshold_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663644);
    SpriteRenderer.NativeMethodInfoPtr_get_tileMode_Public_get_SpriteTileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663645);
    SpriteRenderer.NativeMethodInfoPtr_set_tileMode_Public_set_Void_SpriteTileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663646);
    SpriteRenderer.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663647);
    SpriteRenderer.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663648 /*0x06000160*/);
    SpriteRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663649);
    SpriteRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663650);
    SpriteRenderer.NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663651);
    SpriteRenderer.NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663652);
    SpriteRenderer.NativeMethodInfoPtr_get_flipY_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663653);
    SpriteRenderer.NativeMethodInfoPtr_set_flipY_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663654);
    SpriteRenderer.NativeMethodInfoPtr_get_spriteSortPoint_Public_get_SpriteSortPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663655);
    SpriteRenderer.NativeMethodInfoPtr_set_spriteSortPoint_Public_set_Void_SpriteSortPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663656);
    SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshDataPtr_Private_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663657);
    SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshData_Internal_MeshDataArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663658);
    SpriteRenderer.NativeMethodInfoPtr_Internal_GetSpriteBounds_Internal_Bounds_SpriteDrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663659);
    SpriteRenderer.NativeMethodInfoPtr_GetSecondaryTextureProperties_Internal_Void_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663660);
    SpriteRenderer.NativeMethodInfoPtr_GetSpriteBounds_Internal_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663661);
    SpriteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663662);
    SpriteRenderer.NativeMethodInfoPtr_get_shouldSupportTiling_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663663);
    SpriteRenderer.NativeMethodInfoPtr_get_hasSpriteChangeEvents_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663664 /*0x06000170*/);
    SpriteRenderer.NativeMethodInfoPtr_set_hasSpriteChangeEvents_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663665);
    SpriteRenderer.NativeMethodInfoPtr_get_sprite_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663666);
    SpriteRenderer.NativeMethodInfoPtr_set_sprite_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663667);
    SpriteRenderer.NativeMethodInfoPtr_get_drawMode_Injected_Private_Static_SpriteDrawMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663668);
    SpriteRenderer.NativeMethodInfoPtr_set_drawMode_Injected_Private_Static_Void_IntPtr_SpriteDrawMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663669);
    SpriteRenderer.NativeMethodInfoPtr_get_size_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663670);
    SpriteRenderer.NativeMethodInfoPtr_set_size_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663671);
    SpriteRenderer.NativeMethodInfoPtr_get_adaptiveModeThreshold_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663672);
    SpriteRenderer.NativeMethodInfoPtr_set_adaptiveModeThreshold_Injected_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663673);
    SpriteRenderer.NativeMethodInfoPtr_get_tileMode_Injected_Private_Static_SpriteTileMode_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663674);
    SpriteRenderer.NativeMethodInfoPtr_set_tileMode_Injected_Private_Static_Void_IntPtr_SpriteTileMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663675);
    SpriteRenderer.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663676);
    SpriteRenderer.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_IntPtr_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663677);
    SpriteRenderer.NativeMethodInfoPtr_get_maskInteraction_Injected_Private_Static_SpriteMaskInteraction_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663678);
    SpriteRenderer.NativeMethodInfoPtr_set_maskInteraction_Injected_Private_Static_Void_IntPtr_SpriteMaskInteraction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663679);
    SpriteRenderer.NativeMethodInfoPtr_get_flipX_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663680 /*0x06000180*/);
    SpriteRenderer.NativeMethodInfoPtr_set_flipX_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663681);
    SpriteRenderer.NativeMethodInfoPtr_get_flipY_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663682);
    SpriteRenderer.NativeMethodInfoPtr_set_flipY_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663683);
    SpriteRenderer.NativeMethodInfoPtr_get_spriteSortPoint_Injected_Private_Static_SpriteSortPoint_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663684);
    SpriteRenderer.NativeMethodInfoPtr_set_spriteSortPoint_Injected_Private_Static_Void_IntPtr_SpriteSortPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663685);
    SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshDataPtr_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663686);
    SpriteRenderer.NativeMethodInfoPtr_Internal_GetSpriteBounds_Injected_Private_Static_Void_IntPtr_SpriteDrawMode_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663687);
    SpriteRenderer.NativeMethodInfoPtr_GetSecondaryTextureProperties_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr, 100663688);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414972, XrefRangeEnd = 414986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RegisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_RegisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414986, XrefRangeEnd = 414994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnregisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_UnregisterSpriteChangeCallback_Public_Void_UnityAction_1_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414994, XrefRangeEnd = 415001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InvokeSpriteChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_InvokeSpriteChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool shouldSupportTiling
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415001, XrefRangeEnd = 415006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_shouldSupportTiling_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool hasSpriteChangeEvents
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415006, XrefRangeEnd = 415011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_hasSpriteChangeEvents_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415011, XrefRangeEnd = 415016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_hasSpriteChangeEvents_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Sprite sprite
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 415024, RefRangeEnd = 415029, XrefRangeStart = 415016, XrefRangeEnd = 415024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
    }
    [CallerCount(23), CachedScanResults(RefRangeStart = 415037, RefRangeEnd = 415060, XrefRangeStart = 415029, XrefRangeEnd = 415037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SpriteDrawMode drawMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415060, XrefRangeEnd = 415065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_drawMode_Public_get_SpriteDrawMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SpriteDrawMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415065, XrefRangeEnd = 415070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_drawMode_Public_set_Void_SpriteDrawMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 size
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415070, XrefRangeEnd = 415074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415074, XrefRangeEnd = 415078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float adaptiveModeThreshold
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415078, XrefRangeEnd = 415083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_adaptiveModeThreshold_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415083, XrefRangeEnd = 415088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_adaptiveModeThreshold_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SpriteTileMode tileMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415088, XrefRangeEnd = 415093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_tileMode_Public_get_SpriteTileMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SpriteTileMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415093, XrefRangeEnd = 415098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_tileMode_Public_set_Void_SpriteTileMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color color
  {
    [CallerCount(14), CachedScanResults(RefRangeStart = 415102, RefRangeEnd = 415116, XrefRangeStart = 415098, XrefRangeEnd = 415102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_color_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(24), CachedScanResults(RefRangeStart = 415120, RefRangeEnd = 415144, XrefRangeStart = 415116, XrefRangeEnd = 415120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SpriteMaskInteraction maskInteraction
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415144, XrefRangeEnd = 415149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_maskInteraction_Public_get_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SpriteMaskInteraction*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415149, XrefRangeEnd = 415154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_maskInteraction_Public_set_Void_SpriteMaskInteraction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool flipX
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415154, XrefRangeEnd = 415159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_flipX_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415159, XrefRangeEnd = 415164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_flipX_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool flipY
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415164, XrefRangeEnd = 415169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_flipY_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415169, XrefRangeEnd = 415174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_flipY_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SpriteSortPoint spriteSortPoint
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415174, XrefRangeEnd = 415179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_spriteSortPoint_Public_get_SpriteSortPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SpriteSortPoint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415179, XrefRangeEnd = 415184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_spriteSortPoint_Public_set_Void_SpriteSortPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415184, XrefRangeEnd = 415189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IntPtr GetCurrentMeshDataPtr()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshDataPtr_Private_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415189, XrefRangeEnd = 415194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Mesh.MeshDataArray GetCurrentMeshData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshData_Internal_MeshDataArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Mesh.MeshDataArray*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415194, XrefRangeEnd = 415198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Bounds Internal_GetSpriteBounds(SpriteDrawMode mode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &mode
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_Internal_GetSpriteBounds_Internal_Bounds_SpriteDrawMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415198, XrefRangeEnd = 415208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetSecondaryTextureProperties(MaterialPropertyBlock mbp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mbp)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetSecondaryTextureProperties_Internal_Void_MaterialPropertyBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415208, XrefRangeEnd = 415216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Bounds GetSpriteBounds()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetSpriteBounds_Internal_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16301, XrefRangeEnd = 16305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpriteRenderer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteRenderer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415216, XrefRangeEnd = 415218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_shouldSupportTiling_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_shouldSupportTiling_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415218, XrefRangeEnd = 415220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_hasSpriteChangeEvents_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_hasSpriteChangeEvents_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415220, XrefRangeEnd = 415222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_hasSpriteChangeEvents_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_hasSpriteChangeEvents_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415222, XrefRangeEnd = 415224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_sprite_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_sprite_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415224, XrefRangeEnd = 415226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_sprite_Injected(IntPtr _unity_self, IntPtr value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_sprite_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415226, XrefRangeEnd = 415228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SpriteDrawMode get_drawMode_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_drawMode_Injected_Private_Static_SpriteDrawMode_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SpriteDrawMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415228, XrefRangeEnd = 415230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_drawMode_Injected(IntPtr _unity_self, SpriteDrawMode value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_drawMode_Injected_Private_Static_Void_IntPtr_SpriteDrawMode_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415230, XrefRangeEnd = 415232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_size_Injected(IntPtr _unity_self, out Vector2 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_size_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415232, XrefRangeEnd = 415234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_size_Injected(IntPtr _unity_self, [In] ref Vector2 value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_size_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415234, XrefRangeEnd = 415236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_adaptiveModeThreshold_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_adaptiveModeThreshold_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415236, XrefRangeEnd = 415238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_adaptiveModeThreshold_Injected(IntPtr _unity_self, float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_adaptiveModeThreshold_Injected_Private_Static_Void_IntPtr_Single_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415238, XrefRangeEnd = 415240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SpriteTileMode get_tileMode_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_tileMode_Injected_Private_Static_SpriteTileMode_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SpriteTileMode*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415240, XrefRangeEnd = 415242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_tileMode_Injected(IntPtr _unity_self, SpriteTileMode value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_tileMode_Injected_Private_Static_Void_IntPtr_SpriteTileMode_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415242, XrefRangeEnd = 415244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_color_Injected(IntPtr _unity_self, out Color ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_color_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415244, XrefRangeEnd = 415246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_color_Injected(IntPtr _unity_self, [In] ref Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_color_Injected_Private_Static_Void_IntPtr_byref_Color_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415246, XrefRangeEnd = 415248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_maskInteraction_Injected_Private_Static_SpriteMaskInteraction_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SpriteMaskInteraction*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415248, XrefRangeEnd = 415250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_maskInteraction_Injected(
    IntPtr _unity_self,
    SpriteMaskInteraction value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_maskInteraction_Injected_Private_Static_Void_IntPtr_SpriteMaskInteraction_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415250, XrefRangeEnd = 415252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_flipX_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_flipX_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415252, XrefRangeEnd = 415254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_flipX_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_flipX_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415254, XrefRangeEnd = 415256, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_flipY_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_flipY_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415256, XrefRangeEnd = 415258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_flipY_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_flipY_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415258, XrefRangeEnd = 415260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe SpriteSortPoint get_spriteSortPoint_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_get_spriteSortPoint_Injected_Private_Static_SpriteSortPoint_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(SpriteSortPoint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415260, XrefRangeEnd = 415262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_spriteSortPoint_Injected(IntPtr _unity_self, SpriteSortPoint value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_set_spriteSortPoint_Injected_Private_Static_Void_IntPtr_SpriteSortPoint_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415262, XrefRangeEnd = 415264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetCurrentMeshDataPtr_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetCurrentMeshDataPtr_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415264, XrefRangeEnd = 415266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_GetSpriteBounds_Injected(
    IntPtr _unity_self,
    SpriteDrawMode mode,
    out Bounds ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &mode;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_Internal_GetSpriteBounds_Injected_Private_Static_Void_IntPtr_SpriteDrawMode_byref_Bounds_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415266, XrefRangeEnd = 415268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetSecondaryTextureProperties_Injected(IntPtr _unity_self, IntPtr mbp)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &mbp;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpriteRenderer.NativeMethodInfoPtr_GetSecondaryTextureProperties_Injected_Private_Static_Void_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UnityEvent<SpriteRenderer> m_SpriteChangeEvent
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent));
      return num == IntPtr.Zero ? (UnityEvent<SpriteRenderer>) null : Il2CppObjectPool.Get<UnityEvent<SpriteRenderer>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteRenderer.NativeFieldInfoPtr_m_SpriteChangeEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
