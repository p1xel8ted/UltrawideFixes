// Decompiled with JetBrains decompiler
// Type: UnityEngine.Sprite
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class Sprite(IntPtr pointer) : Object(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPacked_Internal_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTextureRectOffset_Internal_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Internal_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteWithoutTextureScripting_Internal_Static_Sprite_Rect_Vector2_Single_Texture2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_rect_Public_get_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_border_Public_get_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_extrude_Internal_get_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTexture_Internal_Texture2D_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTextureCount_Public_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTextures_Public_Int32_Il2CppReferenceArray_1_SecondarySpriteTexture_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_spriteAtlasTextureScale_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_packed_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_textureRectOffset_Public_get_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPhysicsShapeCount_Public_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetScriptableObjectsCount_Public_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetScriptableObjects_Public_UInt32_Il2CppReferenceArray_1_ScriptableObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddScriptableObject_Public_Boolean_ScriptableObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_RemoveScriptableObjectAt_Public_Boolean_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetScriptableObjectAt_Public_Boolean_ScriptableObject_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPhysicsShapePointCount_Public_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Internal_GetPhysicsShapePointCount_Private_Int32_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPhysicsShape_Public_Int32_Int32_List_1_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPhysicsShapeImpl_Private_Static_Void_Sprite_Int32_List_1_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverridePhysicsShape_Public_Void_IList_1_Il2CppStructArray_1_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverridePhysicsShapeCount_Private_Static_Void_Sprite_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverridePhysicsShape_Private_Static_Void_Sprite_Il2CppStructArray_1_Vector2_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverrideGeometry_Public_Void_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_UInt16_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_Sprite_Rect_Vector2_Single_Texture2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_Sprite_Rect_Vector2_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPackingMode_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPackingRotation_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPacked_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTextureRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetTextureRectOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPadding_Injected_Private_Static_Void_IntPtr_byref_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateSpriteWithoutTextureScripting_Injected_Private_Static_IntPtr_byref_Rect_byref_Vector2_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_IntPtr_IntPtr_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_border_Injected_Private_Static_Void_IntPtr_byref_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_texture_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_extrude_Injected_Private_Static_UInt32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTexture_Injected_Private_Static_IntPtr_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTextureCount_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSecondaryTextures_Injected_Private_Static_Int32_IntPtr_Il2CppReferenceArray_1_SecondarySpriteTexture_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_pixelsPerUnit_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_spriteAtlasTextureScale_Injected_Private_Static_Single_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Injected_Private_Static_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_vertices_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_triangles_Injected_Private_Static_Il2CppStructArray_1_UInt16_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_uv_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPhysicsShapeCount_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetScriptableObjectsCount_Injected_Private_Static_UInt32_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetScriptableObjects_Injected_Private_Static_UInt32_IntPtr_Il2CppReferenceArray_1_ScriptableObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddScriptableObject_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_RemoveScriptableObjectAt_Injected_Private_Static_Boolean_IntPtr_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetScriptableObjectAt_Injected_Private_Static_Boolean_IntPtr_IntPtr_UInt32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Internal_GetPhysicsShapePointCount_Injected_Private_Static_Int32_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetPhysicsShapeImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableListWrapper_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverridePhysicsShapeCount_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverridePhysicsShape_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_OverrideGeometry_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

  static Sprite()
  {
    Il2CppClassPointerStore<Sprite>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Sprite));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprite>.NativeClassPtr);
    Sprite.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663689);
    Sprite.NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663690);
    Sprite.NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663691);
    Sprite.NativeMethodInfoPtr_GetPacked_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663692);
    Sprite.NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663693);
    Sprite.NativeMethodInfoPtr_GetTextureRectOffset_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663694);
    Sprite.NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663695);
    Sprite.NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663696 /*0x06000190*/);
    Sprite.NativeMethodInfoPtr_GetPadding_Internal_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663697);
    Sprite.NativeMethodInfoPtr_CreateSpriteWithoutTextureScripting_Internal_Static_Sprite_Rect_Vector2_Single_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663698);
    Sprite.NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663699);
    Sprite.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663700);
    Sprite.NativeMethodInfoPtr_get_rect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663701);
    Sprite.NativeMethodInfoPtr_get_border_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663702);
    Sprite.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663703);
    Sprite.NativeMethodInfoPtr_get_extrude_Internal_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663704);
    Sprite.NativeMethodInfoPtr_GetSecondaryTexture_Internal_Texture2D_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663705);
    Sprite.NativeMethodInfoPtr_GetSecondaryTextureCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663706);
    Sprite.NativeMethodInfoPtr_GetSecondaryTextures_Public_Int32_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663707);
    Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663708);
    Sprite.NativeMethodInfoPtr_get_spriteAtlasTextureScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663709);
    Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663710);
    Sprite.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663711);
    Sprite.NativeMethodInfoPtr_get_packed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663712 /*0x060001A0*/);
    Sprite.NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663713);
    Sprite.NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663714);
    Sprite.NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663715);
    Sprite.NativeMethodInfoPtr_get_textureRectOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663716);
    Sprite.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663717);
    Sprite.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663718);
    Sprite.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663719);
    Sprite.NativeMethodInfoPtr_GetPhysicsShapeCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663720);
    Sprite.NativeMethodInfoPtr_GetScriptableObjectsCount_Public_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663721);
    Sprite.NativeMethodInfoPtr_GetScriptableObjects_Public_UInt32_Il2CppReferenceArray_1_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663722);
    Sprite.NativeMethodInfoPtr_AddScriptableObject_Public_Boolean_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663723);
    Sprite.NativeMethodInfoPtr_RemoveScriptableObjectAt_Public_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663724);
    Sprite.NativeMethodInfoPtr_SetScriptableObjectAt_Public_Boolean_ScriptableObject_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663725);
    Sprite.NativeMethodInfoPtr_GetPhysicsShapePointCount_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663726);
    Sprite.NativeMethodInfoPtr_Internal_GetPhysicsShapePointCount_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663727);
    Sprite.NativeMethodInfoPtr_GetPhysicsShape_Public_Int32_Int32_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663728 /*0x060001B0*/);
    Sprite.NativeMethodInfoPtr_GetPhysicsShapeImpl_Private_Static_Void_Sprite_Int32_List_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663729);
    Sprite.NativeMethodInfoPtr_OverridePhysicsShape_Public_Void_IList_1_Il2CppStructArray_1_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663730);
    Sprite.NativeMethodInfoPtr_OverridePhysicsShapeCount_Private_Static_Void_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663731);
    Sprite.NativeMethodInfoPtr_OverridePhysicsShape_Private_Static_Void_Sprite_Il2CppStructArray_1_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663732);
    Sprite.NativeMethodInfoPtr_OverrideGeometry_Public_Void_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663733);
    Sprite.NativeMethodInfoPtr_Create_Internal_Static_Sprite_Rect_Vector2_Single_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663734);
    Sprite.NativeMethodInfoPtr_Create_Internal_Static_Sprite_Rect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663735);
    Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663736);
    Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663737);
    Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663738);
    Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663739);
    Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663740);
    Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663741);
    Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663742);
    Sprite.NativeMethodInfoPtr_GetPackingMode_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663743);
    Sprite.NativeMethodInfoPtr_GetPackingRotation_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663744 /*0x060001C0*/);
    Sprite.NativeMethodInfoPtr_GetPacked_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663745);
    Sprite.NativeMethodInfoPtr_GetTextureRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663746);
    Sprite.NativeMethodInfoPtr_GetTextureRectOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663747);
    Sprite.NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663748);
    Sprite.NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663749);
    Sprite.NativeMethodInfoPtr_GetPadding_Injected_Private_Static_Void_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663750);
    Sprite.NativeMethodInfoPtr_CreateSpriteWithoutTextureScripting_Injected_Private_Static_IntPtr_byref_Rect_byref_Vector2_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663751);
    Sprite.NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_IntPtr_IntPtr_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663752);
    Sprite.NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663753);
    Sprite.NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663754);
    Sprite.NativeMethodInfoPtr_get_border_Injected_Private_Static_Void_IntPtr_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663755);
    Sprite.NativeMethodInfoPtr_get_texture_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663756);
    Sprite.NativeMethodInfoPtr_get_extrude_Injected_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663757);
    Sprite.NativeMethodInfoPtr_GetSecondaryTexture_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663758);
    Sprite.NativeMethodInfoPtr_GetSecondaryTextureCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663759);
    Sprite.NativeMethodInfoPtr_GetSecondaryTextures_Injected_Private_Static_Int32_IntPtr_Il2CppReferenceArray_1_SecondarySpriteTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663760 /*0x060001D0*/);
    Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663761);
    Sprite.NativeMethodInfoPtr_get_spriteAtlasTextureScale_Injected_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663762);
    Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Injected_Private_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663763);
    Sprite.NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663764);
    Sprite.NativeMethodInfoPtr_get_vertices_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663765);
    Sprite.NativeMethodInfoPtr_get_triangles_Injected_Private_Static_Il2CppStructArray_1_UInt16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663766);
    Sprite.NativeMethodInfoPtr_get_uv_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663767);
    Sprite.NativeMethodInfoPtr_GetPhysicsShapeCount_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663768);
    Sprite.NativeMethodInfoPtr_GetScriptableObjectsCount_Injected_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663769);
    Sprite.NativeMethodInfoPtr_GetScriptableObjects_Injected_Private_Static_UInt32_IntPtr_Il2CppReferenceArray_1_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663770);
    Sprite.NativeMethodInfoPtr_AddScriptableObject_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663771);
    Sprite.NativeMethodInfoPtr_RemoveScriptableObjectAt_Injected_Private_Static_Boolean_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663772);
    Sprite.NativeMethodInfoPtr_SetScriptableObjectAt_Injected_Private_Static_Boolean_IntPtr_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663773);
    Sprite.NativeMethodInfoPtr_Internal_GetPhysicsShapePointCount_Injected_Private_Static_Int32_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663774);
    Sprite.NativeMethodInfoPtr_GetPhysicsShapeImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableListWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663775);
    Sprite.NativeMethodInfoPtr_OverridePhysicsShapeCount_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663776 /*0x060001E0*/);
    Sprite.NativeMethodInfoPtr_OverridePhysicsShape_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663777);
    Sprite.NativeMethodInfoPtr_OverrideGeometry_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprite>.NativeClassPtr, 100663778);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415268, XrefRangeEnd = 415272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Sprite()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprite>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415272, XrefRangeEnd = 415277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPackingMode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPackingMode_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 415282, RefRangeEnd = 415284, XrefRangeStart = 415277, XrefRangeEnd = 415282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPackingRotation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPackingRotation_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415284, XrefRangeEnd = 415289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPacked()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPacked_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415289, XrefRangeEnd = 415293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Rect GetTextureRect()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetTextureRect_Internal_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415293, XrefRangeEnd = 415297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2 GetTextureRectOffset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetTextureRectOffset_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 415301, RefRangeEnd = 415302, XrefRangeStart = 415297, XrefRangeEnd = 415301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector4 GetInnerUVs()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetInnerUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 415306, RefRangeEnd = 415307, XrefRangeStart = 415302, XrefRangeEnd = 415306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector4 GetOuterUVs()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetOuterUVs_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 415311, RefRangeEnd = 415312, XrefRangeStart = 415307, XrefRangeEnd = 415311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector4 GetPadding()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPadding_Internal_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415312, XrefRangeEnd = 415320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite CreateSpriteWithoutTextureScripting(
    Rect rect,
    Vector2 pivot,
    float pixelsToUnits,
    Texture2D texture)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pixelsToUnits;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_CreateSpriteWithoutTextureScripting_Internal_Static_Sprite_Rect_Vector2_Single_Texture2D_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415320, XrefRangeEnd = 415328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite CreateSprite(
    Texture2D texture,
    Rect rect,
    Vector2 pivot,
    float pixelsPerUnit,
    uint extrude,
    SpriteMeshType meshType,
    Vector4 border,
    bool generateFallbackPhysicsShape,
    Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
  {
    IntPtr* numPtr = stackalloc IntPtr[9];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &pixelsPerUnit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &extrude;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &meshType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &border;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &generateFallbackPhysicsShape;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(8) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) secondaryTexture);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_CreateSprite_Internal_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  public unsafe Bounds bounds
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 415332, RefRangeEnd = 415345, XrefRangeStart = 415328, XrefRangeEnd = 415332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_bounds_Public_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Rect rect
  {
    [CallerCount(18), CachedScanResults(RefRangeStart = 415349, RefRangeEnd = 415367, XrefRangeStart = 415345, XrefRangeEnd = 415349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_rect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector4 border
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 415371, RefRangeEnd = 415379, XrefRangeStart = 415367, XrefRangeEnd = 415371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_border_Public_get_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Texture2D texture
  {
    [CallerCount(32 /*0x20*/), CachedScanResults(RefRangeStart = 415387, RefRangeEnd = 415419, XrefRangeStart = 415379, XrefRangeEnd = 415387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_texture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num3);
    }
  }

  public unsafe uint extrude
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415419, XrefRangeEnd = 415424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_extrude_Internal_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415424, XrefRangeEnd = 415432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture2D GetSecondaryTexture(int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetSecondaryTexture_Internal_Texture2D_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415432, XrefRangeEnd = 415437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetSecondaryTextureCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetSecondaryTextureCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415437, XrefRangeEnd = 415445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetSecondaryTextures(
    Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) secondaryTexture)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetSecondaryTextures_Public_Int32_Il2CppReferenceArray_1_SecondarySpriteTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float pixelsPerUnit
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 415450, RefRangeEnd = 415454, XrefRangeStart = 415445, XrefRangeEnd = 415450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float spriteAtlasTextureScale
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415454, XrefRangeEnd = 415459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_spriteAtlasTextureScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Texture2D associatedAlphaSplitTexture
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 415467, RefRangeEnd = 415469, XrefRangeStart = 415459, XrefRangeEnd = 415467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Public_get_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num3);
    }
  }

  public unsafe Vector2 pivot
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 415473, RefRangeEnd = 415476, XrefRangeStart = 415469, XrefRangeEnd = 415473, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool packed
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 415480, RefRangeEnd = 415483, XrefRangeStart = 415476, XrefRangeEnd = 415480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe SpritePackingMode packingMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packingMode_Public_get_SpritePackingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SpritePackingMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe SpritePackingRotation packingRotation
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 415282, RefRangeEnd = 415284, XrefRangeStart = 415282, XrefRangeEnd = 415284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_packingRotation_Public_get_SpritePackingRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SpritePackingRotation*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Rect textureRect
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 415487, RefRangeEnd = 415491, XrefRangeStart = 415483, XrefRangeEnd = 415487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_textureRect_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector2 textureRectOffset
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_textureRectOffset_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Il2CppStructArray<Vector2> vertices
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 415496, RefRangeEnd = 415501, XrefRangeStart = 415491, XrefRangeEnd = 415496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_vertices_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppStructArray<Vector2>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(num3);
    }
  }

  public unsafe Il2CppStructArray<ushort> triangles
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 415506, RefRangeEnd = 415509, XrefRangeStart = 415501, XrefRangeEnd = 415506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_triangles_Public_get_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppStructArray<ushort>) null : Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(num3);
    }
  }

  public unsafe Il2CppStructArray<Vector2> uv
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 415514, RefRangeEnd = 415519, XrefRangeStart = 415509, XrefRangeEnd = 415514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_uv_Public_get_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Il2CppStructArray<Vector2>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415519, XrefRangeEnd = 415524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPhysicsShapeCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPhysicsShapeCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415524, XrefRangeEnd = 415529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetScriptableObjectsCount()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetScriptableObjectsCount_Public_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415529, XrefRangeEnd = 415537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetScriptableObjects(
    Il2CppReferenceArray<ScriptableObject> scriptableObjects)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) scriptableObjects)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetScriptableObjects_Public_UInt32_Il2CppReferenceArray_1_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415537, XrefRangeEnd = 415548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AddScriptableObject(ScriptableObject obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_AddScriptableObject_Public_Boolean_ScriptableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415548, XrefRangeEnd = 415553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool RemoveScriptableObjectAt(uint i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &i
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_RemoveScriptableObjectAt_Public_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415553, XrefRangeEnd = 415564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool SetScriptableObjectAt(ScriptableObject obj, uint i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &i;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_SetScriptableObjectAt_Public_Boolean_ScriptableObject_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415564, XrefRangeEnd = 415585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPhysicsShapePointCount(int shapeIdx)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &shapeIdx
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPhysicsShapePointCount_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415585, XrefRangeEnd = 415590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int Internal_GetPhysicsShapePointCount(int shapeIdx)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &shapeIdx
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Internal_GetPhysicsShapePointCount_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415590, XrefRangeEnd = 415596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetPhysicsShape(int shapeIdx, List<Vector2> physicsShape)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &shapeIdx;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicsShape);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPhysicsShape_Public_Int32_Int32_List_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 415615, RefRangeEnd = 415616, XrefRangeStart = 415596, XrefRangeEnd = 415615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetPhysicsShapeImpl(
    Sprite sprite,
    int shapeIdx,
    List<Vector2> physicsShape)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &shapeIdx;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicsShape);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPhysicsShapeImpl_Private_Static_Void_Sprite_Int32_List_1_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415616, XrefRangeEnd = 415654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OverridePhysicsShape(IList<Il2CppStructArray<Vector2>> physicsShapes)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicsShapes)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_OverridePhysicsShape_Public_Void_IList_1_Il2CppStructArray_1_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415654, XrefRangeEnd = 415659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OverridePhysicsShapeCount(Sprite sprite, int physicsShapeCount)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &physicsShapeCount;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_OverridePhysicsShapeCount_Private_Static_Void_Sprite_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415659, XrefRangeEnd = 415674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OverridePhysicsShape(
    Sprite sprite,
    Il2CppStructArray<Vector2> physicsShape,
    int idx)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicsShape);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &idx;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_OverridePhysicsShape_Private_Static_Void_Sprite_Il2CppStructArray_1_Vector2_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415674, XrefRangeEnd = 415698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OverrideGeometry(
    Il2CppStructArray<Vector2> vertices,
    Il2CppStructArray<ushort> triangles)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vertices);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) triangles);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_OverrideGeometry_Public_Void_Il2CppStructArray_1_Vector2_Il2CppStructArray_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415698, XrefRangeEnd = 415706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(
    Rect rect,
    Vector2 pivot,
    float pixelsToUnits,
    Texture2D texture)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pixelsToUnits;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Internal_Static_Sprite_Rect_Vector2_Single_Texture2D_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415706, XrefRangeEnd = 415714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(Rect rect, Vector2 pivot, float pixelsToUnits)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pixelsToUnits;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Internal_Static_Sprite_Rect_Vector2_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415714, XrefRangeEnd = 415715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(
    Texture2D texture,
    Rect rect,
    Vector2 pivot,
    float pixelsPerUnit,
    uint extrude,
    SpriteMeshType meshType,
    Vector4 border,
    bool generateFallbackPhysicsShape)
  {
    IntPtr* numPtr = stackalloc IntPtr[8];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &pixelsPerUnit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &extrude;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &meshType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &border;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &generateFallbackPhysicsShape;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 415732, RefRangeEnd = 415738, XrefRangeStart = 415715, XrefRangeEnd = 415732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(
    Texture2D texture,
    Rect rect,
    Vector2 pivot,
    float pixelsPerUnit,
    uint extrude,
    SpriteMeshType meshType,
    Vector4 border,
    bool generateFallbackPhysicsShape,
    Il2CppReferenceArray<SecondarySpriteTexture> secondaryTextures)
  {
    IntPtr* numPtr = stackalloc IntPtr[9];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &pixelsPerUnit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &extrude;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &meshType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &border;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &generateFallbackPhysicsShape;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(8) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) secondaryTextures);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415738, XrefRangeEnd = 415739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(
    Texture2D texture,
    Rect rect,
    Vector2 pivot,
    float pixelsPerUnit,
    uint extrude,
    SpriteMeshType meshType,
    Vector4 border)
  {
    IntPtr* numPtr = stackalloc IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &pixelsPerUnit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &extrude;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &meshType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) &border;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_Vector4_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415739, XrefRangeEnd = 415742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(
    Texture2D texture,
    Rect rect,
    Vector2 pivot,
    float pixelsPerUnit,
    uint extrude,
    SpriteMeshType meshType)
  {
    IntPtr* numPtr = stackalloc IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &pixelsPerUnit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &extrude;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &meshType;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_SpriteMeshType_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415742, XrefRangeEnd = 415745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(
    Texture2D texture,
    Rect rect,
    Vector2 pivot,
    float pixelsPerUnit,
    uint extrude)
  {
    IntPtr* numPtr = stackalloc IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &pixelsPerUnit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &extrude;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_UInt32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415745, XrefRangeEnd = 415748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(
    Texture2D texture,
    Rect rect,
    Vector2 pivot,
    float pixelsPerUnit)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &pixelsPerUnit;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 415751, RefRangeEnd = 415755, XrefRangeStart = 415748, XrefRangeEnd = 415751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Sprite Create(Texture2D texture, Rect rect, Vector2 pivot)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pivot;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Create_Public_Static_Sprite_Texture2D_Rect_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415755, XrefRangeEnd = 415757, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetPackingMode_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPackingMode_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415757, XrefRangeEnd = 415759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetPackingRotation_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPackingRotation_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415759, XrefRangeEnd = 415761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetPacked_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPacked_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415761, XrefRangeEnd = 415763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetTextureRect_Injected(IntPtr _unity_self, out Rect ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetTextureRect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415763, XrefRangeEnd = 415765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetTextureRectOffset_Injected(IntPtr _unity_self, out Vector2 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetTextureRectOffset_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415765, XrefRangeEnd = 415767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetInnerUVs_Injected(IntPtr _unity_self, out Vector4 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetInnerUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415767, XrefRangeEnd = 415769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetOuterUVs_Injected(IntPtr _unity_self, out Vector4 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetOuterUVs_Injected_Private_Static_Void_IntPtr_byref_Vector4_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415769, XrefRangeEnd = 415771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetPadding_Injected(IntPtr _unity_self, out Vector4 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPadding_Injected_Private_Static_Void_IntPtr_byref_Vector4_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415771, XrefRangeEnd = 415773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr CreateSpriteWithoutTextureScripting_Injected(
    [In] ref Rect rect,
    [In] ref Vector2 pivot,
    float pixelsToUnits,
    IntPtr texture)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = (IntPtr) ref rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &pixelsToUnits;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &texture;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_CreateSpriteWithoutTextureScripting_Injected_Private_Static_IntPtr_byref_Rect_byref_Vector2_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415773, XrefRangeEnd = 415775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr CreateSprite_Injected(
    IntPtr texture,
    [In] ref Rect rect,
    [In] ref Vector2 pivot,
    float pixelsPerUnit,
    uint extrude,
    SpriteMeshType meshType,
    [In] ref Vector4 border,
    bool generateFallbackPhysicsShape,
    Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
  {
    IntPtr* numPtr = stackalloc IntPtr[9];
    numPtr[0] = (IntPtr) &texture;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref rect;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref pivot;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &pixelsPerUnit;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &extrude;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(5) * sizeof (IntPtr))) = (IntPtr) &meshType;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(6) * sizeof (IntPtr))) = (IntPtr) ref border;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(7) * sizeof (IntPtr))) = (IntPtr) &generateFallbackPhysicsShape;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(8) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) secondaryTexture);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_CreateSprite_Injected_Private_Static_IntPtr_IntPtr_byref_Rect_byref_Vector2_Single_UInt32_SpriteMeshType_byref_Vector4_Boolean_Il2CppReferenceArray_1_SecondarySpriteTexture_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415775, XrefRangeEnd = 415777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_bounds_Injected(IntPtr _unity_self, out Bounds ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_bounds_Injected_Private_Static_Void_IntPtr_byref_Bounds_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415777, XrefRangeEnd = 415779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_rect_Injected(IntPtr _unity_self, out Rect ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_rect_Injected_Private_Static_Void_IntPtr_byref_Rect_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415779, XrefRangeEnd = 415781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_border_Injected(IntPtr _unity_self, out Vector4 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_border_Injected_Private_Static_Void_IntPtr_byref_Vector4_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415781, XrefRangeEnd = 415783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_texture_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_texture_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415783, XrefRangeEnd = 415785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint get_extrude_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_extrude_Injected_Private_Static_UInt32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415785, XrefRangeEnd = 415787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr GetSecondaryTexture_Injected(IntPtr _unity_self, int index)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &index;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetSecondaryTexture_Injected_Private_Static_IntPtr_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415787, XrefRangeEnd = 415789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetSecondaryTextureCount_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetSecondaryTextureCount_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415789, XrefRangeEnd = 415791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetSecondaryTextures_Injected(
    IntPtr _unity_self,
    Il2CppReferenceArray<SecondarySpriteTexture> secondaryTexture)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) secondaryTexture);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetSecondaryTextures_Injected_Private_Static_Int32_IntPtr_Il2CppReferenceArray_1_SecondarySpriteTexture_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415791, XrefRangeEnd = 415793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_pixelsPerUnit_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pixelsPerUnit_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415793, XrefRangeEnd = 415795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float get_spriteAtlasTextureScale_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_spriteAtlasTextureScale_Injected_Private_Static_Single_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415795, XrefRangeEnd = 415797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_associatedAlphaSplitTexture_Injected_Private_Static_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415797, XrefRangeEnd = 415799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref ret;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_pivot_Injected_Private_Static_Void_IntPtr_byref_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415799, XrefRangeEnd = 415801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<Vector2> get_vertices_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_vertices_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Il2CppStructArray<Vector2>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415801, XrefRangeEnd = 415803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<ushort> get_triangles_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_triangles_Injected_Private_Static_Il2CppStructArray_1_UInt16_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Il2CppStructArray<ushort>) null : Il2CppObjectPool.Get<Il2CppStructArray<ushort>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415803, XrefRangeEnd = 415805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppStructArray<Vector2> get_uv_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_get_uv_Injected_Private_Static_Il2CppStructArray_1_Vector2_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Il2CppStructArray<Vector2>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415805, XrefRangeEnd = 415807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetPhysicsShapeCount_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPhysicsShapeCount_Injected_Private_Static_Int32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415807, XrefRangeEnd = 415809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetScriptableObjectsCount_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetScriptableObjectsCount_Injected_Private_Static_UInt32_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415809, XrefRangeEnd = 415811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint GetScriptableObjects_Injected(
    IntPtr _unity_self,
    Il2CppReferenceArray<ScriptableObject> scriptableObjects)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) scriptableObjects);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetScriptableObjects_Injected_Private_Static_UInt32_IntPtr_Il2CppReferenceArray_1_ScriptableObject_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415811, XrefRangeEnd = 415813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool AddScriptableObject_Injected(IntPtr _unity_self, IntPtr obj)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &obj;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_AddScriptableObject_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415813, XrefRangeEnd = 415815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool RemoveScriptableObjectAt_Injected(IntPtr _unity_self, uint i)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &i;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_RemoveScriptableObjectAt_Injected_Private_Static_Boolean_IntPtr_UInt32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415815, XrefRangeEnd = 415817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SetScriptableObjectAt_Injected(IntPtr _unity_self, IntPtr obj, uint i)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &obj;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &i;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_SetScriptableObjectAt_Injected_Private_Static_Boolean_IntPtr_IntPtr_UInt32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415817, XrefRangeEnd = 415819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int Internal_GetPhysicsShapePointCount_Injected(
    IntPtr _unity_self,
    int shapeIdx)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &shapeIdx;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_Internal_GetPhysicsShapePointCount_Injected_Private_Static_Int32_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415819, XrefRangeEnd = 415821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetPhysicsShapeImpl_Injected(
    IntPtr sprite,
    int shapeIdx,
    ref BlittableListWrapper physicsShape)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &sprite;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &shapeIdx;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref physicsShape;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_GetPhysicsShapeImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_BlittableListWrapper_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415821, XrefRangeEnd = 415823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OverridePhysicsShapeCount_Injected(IntPtr sprite, int physicsShapeCount)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &sprite;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &physicsShapeCount;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_OverridePhysicsShapeCount_Injected_Private_Static_Void_IntPtr_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415823, XrefRangeEnd = 415825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OverridePhysicsShape_Injected(
    IntPtr sprite,
    ref ManagedSpanWrapper physicsShape,
    int idx)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &sprite;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref physicsShape;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &idx;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_OverridePhysicsShape_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_Int32_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 415825, XrefRangeEnd = 415827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OverrideGeometry_Injected(
    IntPtr _unity_self,
    ref ManagedSpanWrapper vertices,
    ref ManagedSpanWrapper triangles)
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref vertices;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) ref triangles;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Sprite.NativeMethodInfoPtr_OverrideGeometry_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
