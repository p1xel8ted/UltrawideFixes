// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUITextMeshProGlyphHelper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore;

#nullable disable
namespace Rewired.Glyphs.UnityUI;

public class UnityUITextMeshProGlyphHelper(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__text;
  private static readonly System.IntPtr NativeFieldInfoPtr__options;
  private static readonly System.IntPtr NativeFieldInfoPtr__spriteOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr__baseSpriteMaterial;
  private static readonly System.IntPtr NativeFieldInfoPtr__overrideSpriteMaterialProperties;
  private static readonly System.IntPtr NativeFieldInfoPtr__spriteMaterialProperties;
  private static readonly System.IntPtr NativeFieldInfoPtr__tmProText;
  private static readonly System.IntPtr NativeFieldInfoPtr__textPrev;
  private static readonly System.IntPtr NativeFieldInfoPtr__processTagSb;
  private static readonly System.IntPtr NativeFieldInfoPtr__tempSb;
  private static readonly System.IntPtr NativeFieldInfoPtr__tempSb2;
  private static readonly System.IntPtr NativeFieldInfoPtr__primaryAsset;
  private static readonly System.IntPtr NativeFieldInfoPtr__assignedAssets;
  private static readonly System.IntPtr NativeFieldInfoPtr__assetsPool;
  private static readonly System.IntPtr NativeFieldInfoPtr__tempAems;
  private static readonly System.IntPtr NativeFieldInfoPtr__tempGlyphs;
  private static readonly System.IntPtr NativeFieldInfoPtr__dirtyAssets;
  private static readonly System.IntPtr NativeFieldInfoPtr__tempKeys;
  private static readonly System.IntPtr NativeFieldInfoPtr__glyphsOrTextTemp;
  private static readonly System.IntPtr NativeFieldInfoPtr__currentlyUsedAssets;
  private static readonly System.IntPtr NativeFieldInfoPtr__currentTags;
  private static readonly System.IntPtr NativeFieldInfoPtr__tempStringDictionary;
  private static readonly System.IntPtr NativeFieldInfoPtr__initialized;
  private static readonly System.IntPtr NativeFieldInfoPtr__rebuildRequired;
  private static readonly System.IntPtr NativeFieldInfoPtr__stubTexture;
  private static readonly System.IntPtr NativeFieldInfoPtr___controllerElementTagPool;
  private static readonly System.IntPtr NativeFieldInfoPtr___actionTagPool;
  private static readonly System.IntPtr NativeFieldInfoPtr___playerTagPool;
  private static readonly System.IntPtr NativeFieldInfoPtr___tagHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr___s_displayTypeNames;
  private static readonly System.IntPtr NativeFieldInfoPtr___s_displayTypeValues;
  private static readonly System.IntPtr NativeFieldInfoPtr___s_axisRangeNames;
  private static readonly System.IntPtr NativeFieldInfoPtr___s_axisRangeValues;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerElementTagPool_Private_get_Pool_1_ControllerElementTag_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_actionTagPool_Private_get_Pool_1_ActionTag_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_playerTagPool_Private_get_Pool_1_PlayerTag_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_tagHandlers_Private_get_Dictionary_2_String_ParseTagAttributesHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_options_Public_Virtual_New_get_ControllerElementGlyphSelectorOptionsSOBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_options_Public_Virtual_New_set_Void_ControllerElementGlyphSelectorOptionsSOBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteOptions_Public_Virtual_New_get_TMProSpriteOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_spriteOptions_Public_Virtual_New_set_Void_TMProSpriteOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_baseSpriteMaterial_Public_Virtual_New_get_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_baseSpriteMaterial_Public_Virtual_New_set_Void_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_overrideSpriteMaterialProperties_Public_Virtual_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideSpriteMaterialProperties_Public_Virtual_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteMaterialProperties_Public_Virtual_New_get_SpriteMaterialProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_spriteMaterialProperties_Public_Virtual_New_set_Void_SpriteMaterialProperties_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForceUpdate_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOptionsOrDefault_Protected_Virtual_New_ControllerElementGlyphSelectorOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MainUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ParseText_Private_Boolean_String_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessNextTag_Private_Boolean_byref_String_StringBuilder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTag_ControllerElement_Private_Boolean_String_Int32_Int32_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTag_Action_Private_Boolean_String_Int32_Int32_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessTag_Player_Private_Boolean_String_Int32_Int32_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryCreateTMProString_Private_Boolean_List_1_GlyphOrText_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetControllerElementGlyphsOrText_Private_Boolean_ControllerElementTag_List_1_GlyphOrText_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetActionDisplayName_Private_Boolean_ActionTag_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetPlayerDisplayName_Private_Boolean_PlayerTag_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryAssignSprite_Private_Boolean_Sprite_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequireRebuild_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreatePrimaryAsset_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOrCreateAsset_Private_Asset_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateAsset_Private_Asset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveUnusedAssets_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetDirty_Private_Void_Asset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForEachAsset_Private_Void_Action_1_Asset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_shaderPropertyId_color_Private_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_s_displayTypeNames_Private_Static_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_s_displayTypeValues_Private_Static_get_Il2CppStructArray_1_DisplayType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_s_axisRangeNames_Private_Static_get_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_s_axisRangeValues_Private_Static_get_Il2CppStructArray_1_AxisRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ParseAttributes_Private_Static_Void_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidKeyChar_Private_Static_Boolean_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidTagNameChar_Private_Static_Boolean_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidNonQuotedValueChar_Private_Static_Boolean_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsEqual_Private_Static_Boolean_List_1_GlyphOrText_List_1_GlyphOrText_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WriteSpriteKey_Private_Static_Void_StringBuilder_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetGlyphsOrText_Private_Static_Boolean_ActionElementMap_DisplayType_List_1_Sprite_List_1_String_List_1_GlyphOrText_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsGlyphAllowed_Private_Static_Boolean_DisplayType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsTextAllowed_Private_Static_Boolean_DisplayType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyMaterialProperties_Private_Static_Void_Material_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopySpriteMaterialPropertiesToMaterial_Private_Static_Void_SpriteMaterialProperties_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__set_overrideSpriteMaterialProperties_b__51_0_Private_Void_Asset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__set_spriteMaterialProperties_b__54_0_Private_Void_Asset_0;

  static UnityUITextMeshProGlyphHelper()
  {
    Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs.UnityUI", nameof (UnityUITextMeshProGlyphHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr);
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_text));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_options));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__spriteOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_spriteOptions));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__baseSpriteMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_baseSpriteMaterial));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__overrideSpriteMaterialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_overrideSpriteMaterialProperties));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__spriteMaterialProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_spriteMaterialProperties));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tmProText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_tmProText));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__textPrev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_textPrev));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__processTagSb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_processTagSb));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempSb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_tempSb));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempSb2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_tempSb2));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__primaryAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_primaryAsset));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__assignedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_assignedAssets));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__assetsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_assetsPool));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempAems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_tempAems));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempGlyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_tempGlyphs));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__dirtyAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_dirtyAssets));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_tempKeys));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__glyphsOrTextTemp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_glyphsOrTextTemp));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__currentlyUsedAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_currentlyUsedAssets));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__currentTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_currentTags));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempStringDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_tempStringDictionary));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_initialized));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__rebuildRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_rebuildRequired));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__stubTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (_stubTexture));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___controllerElementTagPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (__controllerElementTagPool));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___actionTagPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (__actionTagPool));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___playerTagPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (__playerTagPool));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___tagHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (__tagHandlers));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_displayTypeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (__s_displayTypeNames));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_displayTypeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (__s_displayTypeValues));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_axisRangeNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (__s_axisRangeNames));
    UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_axisRangeValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (__s_axisRangeValues));
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_controllerElementTagPool_Private_get_Pool_1_ControllerElementTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668689);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_actionTagPool_Private_get_Pool_1_ActionTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668690);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_playerTagPool_Private_get_Pool_1_PlayerTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668691);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_tagHandlers_Private_get_Dictionary_2_String_ParseTagAttributesHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668692);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668693);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668694);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_options_Public_Virtual_New_get_ControllerElementGlyphSelectorOptionsSOBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668695);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_options_Public_Virtual_New_set_Void_ControllerElementGlyphSelectorOptionsSOBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668696);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_spriteOptions_Public_Virtual_New_get_TMProSpriteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668697);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_spriteOptions_Public_Virtual_New_set_Void_TMProSpriteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668698);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_baseSpriteMaterial_Public_Virtual_New_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668699);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_baseSpriteMaterial_Public_Virtual_New_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668700);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_overrideSpriteMaterialProperties_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668701);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_overrideSpriteMaterialProperties_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668702);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_spriteMaterialProperties_Public_Virtual_New_get_SpriteMaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668703);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_spriteMaterialProperties_Public_Virtual_New_set_Void_SpriteMaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668704);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668705);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668706);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668707);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668708);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ForceUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668709);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_GetOptionsOrDefault_Protected_Virtual_New_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668710);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_Initialize_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668711);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_MainUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668712);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ParseText_Private_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668713);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ProcessNextTag_Private_Boolean_byref_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668714);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ProcessTag_ControllerElement_Private_Boolean_String_Int32_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668715);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ProcessTag_Action_Private_Boolean_String_Int32_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668716);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ProcessTag_Player_Private_Boolean_String_Int32_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668717);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryCreateTMProString_Private_Boolean_List_1_GlyphOrText_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668718);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryGetControllerElementGlyphsOrText_Private_Boolean_ControllerElementTag_List_1_GlyphOrText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668719);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryGetActionDisplayName_Private_Boolean_ActionTag_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668720);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryGetPlayerDisplayName_Private_Boolean_PlayerTag_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668721);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryAssignSprite_Private_Boolean_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668722);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_RequireRebuild_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668723);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_CreatePrimaryAsset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668724);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_GetOrCreateAsset_Private_Asset_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668725);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_CreateAsset_Private_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668726);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_RemoveUnusedAssets_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668727);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_SetDirty_Private_Void_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668728);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ForEachAsset_Private_Void_Action_1_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668729);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_shaderPropertyId_color_Private_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668730);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_s_displayTypeNames_Private_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668731);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_s_displayTypeValues_Private_Static_get_Il2CppStructArray_1_DisplayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668732);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_s_axisRangeNames_Private_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668733);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_s_axisRangeValues_Private_Static_get_Il2CppStructArray_1_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668734);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ParseAttributes_Private_Static_Void_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668735);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsValidKeyChar_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668736);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsValidTagNameChar_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668737);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsValidNonQuotedValueChar_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668738);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsEqual_Private_Static_Boolean_List_1_GlyphOrText_List_1_GlyphOrText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668739);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_WriteSpriteKey_Private_Static_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668740);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryGetGlyphsOrText_Private_Static_Boolean_ActionElementMap_DisplayType_List_1_Sprite_List_1_String_List_1_GlyphOrText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668741);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsGlyphAllowed_Private_Static_Boolean_DisplayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668742);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsTextAllowed_Private_Static_Boolean_DisplayType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668743);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_CopyMaterialProperties_Private_Static_Void_Material_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668744);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_CopySpriteMaterialPropertiesToMaterial_Private_Static_Void_SpriteMaterialProperties_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668745);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668746);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr__set_overrideSpriteMaterialProperties_b__51_0_Private_Void_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668747);
    UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr__set_spriteMaterialProperties_b__54_0_Private_Void_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, 100668748);
  }

  public unsafe UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> controllerElementTagPool
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70947, XrefRangeEnd = 70949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_controllerElementTagPool_Private_get_Pool_1_ControllerElementTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag>) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag>>(num3);
    }
  }

  public unsafe UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> actionTagPool
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70949, XrefRangeEnd = 70951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_actionTagPool_Private_get_Pool_1_ActionTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag>) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag>>(num3);
    }
  }

  public unsafe UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> playerTagPool
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70951, XrefRangeEnd = 70953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_playerTagPool_Private_get_Pool_1_PlayerTag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag>) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag>>(num3);
    }
  }

  public unsafe Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> tagHandlers
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70953, XrefRangeEnd = 70963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_tagHandlers_Private_get_Dictionary_2_String_ParseTagAttributesHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>) null : Il2CppObjectPool.Get<Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>>(num3);
    }
  }

  public virtual unsafe string text
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_text_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_text_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ControllerElementGlyphSelectorOptionsSOBase options
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_options_Public_Virtual_New_get_ControllerElementGlyphSelectorOptionsSOBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ControllerElementGlyphSelectorOptionsSOBase) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptionsSOBase>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_options_Public_Virtual_New_set_Void_ControllerElementGlyphSelectorOptionsSOBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe UnityUITextMeshProGlyphHelper.TMProSpriteOptions spriteOptions
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_spriteOptions_Public_Virtual_New_get_TMProSpriteOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(UnityUITextMeshProGlyphHelper.TMProSpriteOptions*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70963, XrefRangeEnd = 71000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_spriteOptions_Public_Virtual_New_set_Void_TMProSpriteOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Material baseSpriteMaterial
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_baseSpriteMaterial_Public_Virtual_New_get_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71000, XrefRangeEnd = 71017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_baseSpriteMaterial_Public_Virtual_New_set_Void_Material_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool overrideSpriteMaterialProperties
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_overrideSpriteMaterialProperties_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71017, XrefRangeEnd = 71040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_overrideSpriteMaterialProperties_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe UnityUITextMeshProGlyphHelper.SpriteMaterialProperties spriteMaterialProperties
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_spriteMaterialProperties_Public_Virtual_New_get_SpriteMaterialProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71040, XrefRangeEnd = 71047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_set_spriteMaterialProperties_Public_Virtual_New_set_Void_SpriteMaterialProperties_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71047, XrefRangeEnd = 71062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71062, XrefRangeEnd = 71063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71063, XrefRangeEnd = 71071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71071, XrefRangeEnd = 71112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71112, XrefRangeEnd = 71119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ForceUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ForceUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71119, XrefRangeEnd = 71142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ControllerElementGlyphSelectorOptions GetOptionsOrDefault()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_GetOptionsOrDefault_Protected_Virtual_New_ControllerElementGlyphSelectorOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71142, XrefRangeEnd = 71157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_Initialize_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71205, RefRangeEnd = 71207, XrefRangeStart = 71157, XrefRangeEnd = 71205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MainUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_MainUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71207, XrefRangeEnd = 71213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ParseText(string text, out string newText)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ParseText_Private_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    newText = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 71220, RefRangeEnd = 71224, XrefRangeStart = 71213, XrefRangeEnd = 71220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessNextTag(ref string text, StringBuilder sb)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(text);
    System.IntPtr* numPtr3 = &il2Cpp;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ProcessNextTag_Private_Boolean_byref_String_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    text = IL2CPP.Il2CppStringToManaged(il2Cpp);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71224, XrefRangeEnd = 71242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessTag_ControllerElement(
    string text,
    int startIndex,
    int count,
    out string replacement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ProcessTag_ControllerElement_Private_Boolean_String_Int32_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    replacement = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71242, XrefRangeEnd = 71262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessTag_Action(
    string text,
    int startIndex,
    int count,
    out string replacement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ProcessTag_Action_Private_Boolean_String_Int32_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    replacement = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71262, XrefRangeEnd = 71282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool ProcessTag_Player(
    string text,
    int startIndex,
    int count,
    out string replacement)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ProcessTag_Player_Private_Boolean_String_Int32_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    replacement = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71306, RefRangeEnd = 71307, XrefRangeStart = 71282, XrefRangeEnd = 71306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryCreateTMProString(
    List<UnityUITextMeshProGlyphHelper.GlyphOrText> glyphs,
    out string result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) glyphs);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryCreateTMProString_Private_Boolean_List_1_GlyphOrText_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    result = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71390, RefRangeEnd = 71392, XrefRangeStart = 71307, XrefRangeEnd = 71390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetControllerElementGlyphsOrText(
    UnityUITextMeshProGlyphHelper.ControllerElementTag tag,
    List<UnityUITextMeshProGlyphHelper.GlyphOrText> results)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tag);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryGetControllerElementGlyphsOrText_Private_Boolean_ControllerElementTag_List_1_GlyphOrText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71392, XrefRangeEnd = 71398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetActionDisplayName(
    UnityUITextMeshProGlyphHelper.ActionTag tag,
    out string result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tag);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryGetActionDisplayName_Private_Boolean_ActionTag_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    result = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71398, XrefRangeEnd = 71404, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetPlayerDisplayName(
    UnityUITextMeshProGlyphHelper.PlayerTag tag,
    out string result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tag);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryGetPlayerDisplayName_Private_Boolean_PlayerTag_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    result = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71457, RefRangeEnd = 71458, XrefRangeStart = 71404, XrefRangeEnd = 71457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryAssignSprite(Sprite sprite, string key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryAssignSprite_Private_Boolean_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void RequireRebuild()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_RequireRebuild_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71458, XrefRangeEnd = 71466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreatePrimaryAsset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_CreatePrimaryAsset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71541, RefRangeEnd = 71542, XrefRangeStart = 71466, XrefRangeEnd = 71541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUITextMeshProGlyphHelper.Asset GetOrCreateAsset(Sprite sprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_GetOrCreateAsset_Private_Asset_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Asset) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Asset>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71542, XrefRangeEnd = 71555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUITextMeshProGlyphHelper.Asset CreateAsset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_CreateAsset_Private_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Asset) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Asset>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71586, RefRangeEnd = 71588, XrefRangeStart = 71555, XrefRangeEnd = 71586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveUnusedAssets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_RemoveUnusedAssets_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71588, XrefRangeEnd = 71594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetDirty(UnityUITextMeshProGlyphHelper.Asset asset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_SetDirty_Private_Void_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 71604, RefRangeEnd = 71608, XrefRangeStart = 71594, XrefRangeEnd = 71604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ForEachAsset(
    Il2CppSystem.Action<UnityUITextMeshProGlyphHelper.Asset> callback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ForEachAsset_Private_Void_Action_1_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int shaderPropertyId_color
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71608, XrefRangeEnd = 71611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_shaderPropertyId_color_Private_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Il2CppStringArray s_displayTypeNames
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 71614, RefRangeEnd = 71616, XrefRangeStart = 71611, XrefRangeEnd = 71614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_s_displayTypeNames_Private_Static_get_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
  }

  public static unsafe Il2CppStructArray<UnityUITextMeshProGlyphHelper.DisplayType> s_displayTypeValues
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 71620, RefRangeEnd = 71621, XrefRangeStart = 71616, XrefRangeEnd = 71620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_s_displayTypeValues_Private_Static_get_Il2CppStructArray_1_DisplayType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<UnityUITextMeshProGlyphHelper.DisplayType>) null : Il2CppObjectPool.Get<Il2CppStructArray<UnityUITextMeshProGlyphHelper.DisplayType>>(num3);
    }
  }

  public static unsafe Il2CppStringArray s_axisRangeNames
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 71624, RefRangeEnd = 71628, XrefRangeStart = 71621, XrefRangeEnd = 71624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_s_axisRangeNames_Private_Static_get_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
  }

  public static unsafe Il2CppStructArray<AxisRange> s_axisRangeValues
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 71632, RefRangeEnd = 71634, XrefRangeStart = 71628, XrefRangeEnd = 71632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_get_s_axisRangeValues_Private_Static_get_Il2CppStructArray_1_AxisRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<AxisRange>) null : Il2CppObjectPool.Get<Il2CppStructArray<AxisRange>>(num3);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 71682, RefRangeEnd = 71685, XrefRangeStart = 71634, XrefRangeEnd = 71682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ParseAttributes(
    string text,
    int startIndex,
    int count,
    StringBuilder sbKey,
    StringBuilder sbValue,
    Dictionary<string, string> results)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sbKey);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sbValue);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_ParseAttributes_Private_Static_Void_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71688, RefRangeEnd = 71690, XrefRangeStart = 71685, XrefRangeEnd = 71688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidKeyChar(char c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsValidKeyChar_Private_Static_Boolean_Char_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71688, RefRangeEnd = 71690, XrefRangeStart = 71688, XrefRangeEnd = 71690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidTagNameChar(char c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsValidTagNameChar_Private_Static_Boolean_Char_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71690, XrefRangeEnd = 71693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidNonQuotedValueChar(char c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsValidNonQuotedValueChar_Private_Static_Boolean_Char_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71701, RefRangeEnd = 71702, XrefRangeStart = 71693, XrefRangeEnd = 71701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsEqual(
    List<UnityUITextMeshProGlyphHelper.GlyphOrText> a,
    List<UnityUITextMeshProGlyphHelper.GlyphOrText> b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsEqual_Private_Static_Boolean_List_1_GlyphOrText_List_1_GlyphOrText_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71710, RefRangeEnd = 71711, XrefRangeStart = 71702, XrefRangeEnd = 71710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void WriteSpriteKey(StringBuilder sb, string key)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_WriteSpriteKey_Private_Static_Void_StringBuilder_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71711, XrefRangeEnd = 71734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetGlyphsOrText(
    ActionElementMap aem,
    UnityUITextMeshProGlyphHelper.DisplayType displayType,
    List<Sprite> glyphs,
    List<string> keys,
    List<UnityUITextMeshProGlyphHelper.GlyphOrText> results)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aem);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &displayType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) glyphs);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keys);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_TryGetGlyphsOrText_Private_Static_Boolean_ActionElementMap_DisplayType_List_1_Sprite_List_1_String_List_1_GlyphOrText_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsGlyphAllowed(
    UnityUITextMeshProGlyphHelper.DisplayType displayType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsGlyphAllowed_Private_Static_Boolean_DisplayType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool IsTextAllowed(
    UnityUITextMeshProGlyphHelper.DisplayType displayType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &displayType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_IsTextAllowed_Private_Static_Boolean_DisplayType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 71767, RefRangeEnd = 71769, XrefRangeStart = 71734, XrefRangeEnd = 71767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopyMaterialProperties(Material source, Material destination)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destination);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_CopyMaterialProperties_Private_Static_Void_Material_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 71778, RefRangeEnd = 71779, XrefRangeStart = 71769, XrefRangeEnd = 71778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CopySpriteMaterialPropertiesToMaterial(
    UnityUITextMeshProGlyphHelper.SpriteMaterialProperties properties,
    Material material)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &properties;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr_CopySpriteMaterialPropertiesToMaterial_Private_Static_Void_SpriteMaterialProperties_Material_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71779, XrefRangeEnd = 71846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUITextMeshProGlyphHelper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71846, XrefRangeEnd = 71860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _set_overrideSpriteMaterialProperties_b__51_0(
    UnityUITextMeshProGlyphHelper.Asset asset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr__set_overrideSpriteMaterialProperties_b__51_0_Private_Void_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 71860, XrefRangeEnd = 71874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _set_spriteMaterialProperties_b__54_0(UnityUITextMeshProGlyphHelper.Asset asset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.NativeMethodInfoPtr__set_spriteMaterialProperties_b__54_0_Private_Void_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _text
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__text)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__text), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ControllerElementGlyphSelectorOptionsSOBase _options
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__options));
      return num == System.IntPtr.Zero ? (ControllerElementGlyphSelectorOptionsSOBase) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptionsSOBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__options), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityUITextMeshProGlyphHelper.TMProSpriteOptions _spriteOptions
  {
    get
    {
      return *(UnityUITextMeshProGlyphHelper.TMProSpriteOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__spriteOptions));
    }
    [param: In] set
    {
      *(UnityUITextMeshProGlyphHelper.TMProSpriteOptions*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__spriteOptions)) = value;
    }
  }

  public unsafe Material _baseSpriteMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__baseSpriteMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__baseSpriteMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _overrideSpriteMaterialProperties
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__overrideSpriteMaterialProperties));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__overrideSpriteMaterialProperties)) = value;
    }
  }

  public unsafe UnityUITextMeshProGlyphHelper.SpriteMaterialProperties _spriteMaterialProperties
  {
    get
    {
      return *(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__spriteMaterialProperties));
    }
    [param: In] set
    {
      *(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__spriteMaterialProperties)) = value;
    }
  }

  public unsafe TextMeshProUGUI _tmProText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tmProText));
      return num == System.IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tmProText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string _textPrev
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__textPrev)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__textPrev), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe StringBuilder _processTagSb
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__processTagSb));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__processTagSb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder _tempSb
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempSb));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempSb), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder _tempSb2
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempSb2));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempSb2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityUITextMeshProGlyphHelper.Asset _primaryAsset
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__primaryAsset));
      return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Asset) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Asset>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__primaryAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UnityUITextMeshProGlyphHelper.Asset> _assignedAssets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__assignedAssets));
      return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.Asset>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.Asset>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__assignedAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UnityUITextMeshProGlyphHelper.Asset> _assetsPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__assetsPool));
      return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.Asset>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.Asset>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__assetsPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ActionElementMap> _tempAems
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempAems));
      return num == System.IntPtr.Zero ? (List<ActionElementMap>) null : Il2CppObjectPool.Get<List<ActionElementMap>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempAems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Sprite> _tempGlyphs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempGlyphs));
      return num == System.IntPtr.Zero ? (List<Sprite>) null : Il2CppObjectPool.Get<List<Sprite>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempGlyphs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UnityUITextMeshProGlyphHelper.Asset> _dirtyAssets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__dirtyAssets));
      return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.Asset>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.Asset>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__dirtyAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<string> _tempKeys
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempKeys));
      return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UnityUITextMeshProGlyphHelper.GlyphOrText> _glyphsOrTextTemp
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__glyphsOrTextTemp));
      return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.GlyphOrText>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.GlyphOrText>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__glyphsOrTextTemp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UnityUITextMeshProGlyphHelper.Asset> _currentlyUsedAssets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__currentlyUsedAssets));
      return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.Asset>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.Asset>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__currentlyUsedAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<UnityUITextMeshProGlyphHelper.Tag> _currentTags
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__currentTags));
      return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.Tag>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.Tag>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__currentTags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, string> _tempStringDictionary
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempStringDictionary));
      return num == System.IntPtr.Zero ? (Dictionary<string, string>) null : Il2CppObjectPool.Get<Dictionary<string, string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__tempStringDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__initialized)) = value;
    }
  }

  public unsafe bool _rebuildRequired
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__rebuildRequired));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__rebuildRequired)) = value;
    }
  }

  public unsafe Texture2D _stubTexture
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__stubTexture));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr__stubTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> __controllerElementTagPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___controllerElementTagPool));
      return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag>) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___controllerElementTagPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> __actionTagPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___actionTagPool));
      return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag>) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___actionTagPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> __playerTagPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___playerTagPool));
      return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag>) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___playerTagPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler> __tagHandlers
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___tagHandlers));
      return num == System.IntPtr.Zero ? (Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>) null : Il2CppObjectPool.Get<Dictionary<string, UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___tagHandlers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStringArray __s_displayTypeNames
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_displayTypeNames, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_displayTypeNames, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<UnityUITextMeshProGlyphHelper.DisplayType> __s_displayTypeValues
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_displayTypeValues, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<UnityUITextMeshProGlyphHelper.DisplayType>) null : Il2CppObjectPool.Get<Il2CppStructArray<UnityUITextMeshProGlyphHelper.DisplayType>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_displayTypeValues, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStringArray __s_axisRangeNames
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_axisRangeNames, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_axisRangeNames, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStructArray<AxisRange> __s_axisRangeValues
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_axisRangeValues, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<AxisRange>) null : Il2CppObjectPool.Get<Il2CppStructArray<AxisRange>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityUITextMeshProGlyphHelper.NativeFieldInfoPtr___s_axisRangeValues, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class ParseTagAttributesHandler(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_Int32_Int32_byref_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Int32_byref_String_AsyncCallback_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;

    static ParseTagAttributesHandler()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (ParseTagAttributesHandler));
      UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>.NativeClassPtr, 100668749);
      UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_Int32_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>.NativeClassPtr, 100668750);
      UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Int32_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>.NativeClassPtr, 100668751);
      UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>.NativeClassPtr, 100668752);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70093, XrefRangeEnd = 70096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParseTagAttributesHandler(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Invoke(
      string text,
      int startIndex,
      int count,
      out string replacement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_String_Int32_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      replacement = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70096, XrefRangeEnd = 70101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
      string text,
      int startIndex,
      int count,
      out string replacement,
      Il2CppSystem.AsyncCallback callback,
      Il2CppSystem.Object @object)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[6];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_Int32_Int32_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      replacement = IL2CPP.Il2CppStringToManaged(zero);
      System.IntPtr num4 = num3;
      return num4 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(num4);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70101, XrefRangeEnd = 70103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool EndInvoke(out string replacement, Il2CppSystem.IAsyncResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ParseTagAttributesHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      replacement = IL2CPP.Il2CppStringToManaged(zero);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public class Tag(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_tagType;
    private static readonly System.IntPtr NativeFieldInfoPtr__pool;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_TagType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_pool_Protected_get_Pool_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_pool_Protected_set_Void_Pool_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPool_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Protected_Abstract_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_List_1_Tag_0;

    static Tag()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (Tag));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.Tag.NativeFieldInfoPtr_tagType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, nameof (tagType));
      UnityUITextMeshProGlyphHelper.Tag.NativeFieldInfoPtr__pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, nameof (_pool));
      UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr__ctor_Protected_Void_TagType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, 100668753);
      UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_get_pool_Protected_get_Pool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, 100668754);
      UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_set_pool_Protected_set_Void_Pool_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, 100668755);
      UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_ReturnToPool_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, 100668756);
      UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_Clear_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, 100668757);
      UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_Clear_Public_Static_Void_List_1_Tag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, 100668758);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Tag(UnityUITextMeshProGlyphHelper.Tag.TagType tagType)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &tagType
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr__ctor_Protected_Void_TagType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe UnityUITextMeshProGlyphHelper.Tag.Pool pool
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_get_pool_Protected_get_Pool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Tag.Pool) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Tag.Pool>(num3);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_set_pool_Protected_set_Void_Pool_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 70119, RefRangeEnd = 70120, XrefRangeStart = 70119, XrefRangeEnd = 70119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReturnToPool()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_ReturnToPool_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_Clear_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 70128, RefRangeEnd = 70130, XrefRangeStart = 70120, XrefRangeEnd = 70128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Clear(List<UnityUITextMeshProGlyphHelper.Tag> list)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.NativeMethodInfoPtr_Clear_Public_Static_Void_List_1_Tag_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe UnityUITextMeshProGlyphHelper.Tag.TagType tagType
    {
      get
      {
        return *(UnityUITextMeshProGlyphHelper.Tag.TagType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Tag.NativeFieldInfoPtr_tagType));
      }
      [param: In] set
      {
        *(UnityUITextMeshProGlyphHelper.Tag.TagType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Tag.NativeFieldInfoPtr_tagType)) = value;
      }
    }

    public unsafe UnityUITextMeshProGlyphHelper.Tag.Pool _pool
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Tag.NativeFieldInfoPtr__pool));
        return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.Tag.Pool) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.Tag.Pool>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Tag.NativeFieldInfoPtr__pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum TagType
    {
      ControllerElement,
      Action,
      Player,
    }

    public class Pool(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Boolean_Tag_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

      static Pool()
      {
        Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, nameof (Pool));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool>.NativeClassPtr);
        UnityUITextMeshProGlyphHelper.Tag.Pool.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Boolean_Tag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool>.NativeClassPtr, 100668759);
        UnityUITextMeshProGlyphHelper.Tag.Pool.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool>.NativeClassPtr, 100668760);
      }

      [CallerCount(0)]
      public virtual unsafe bool Return(UnityUITextMeshProGlyphHelper.Tag obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.Tag.Pool.NativeMethodInfoPtr_Return_Public_Abstract_Virtual_New_Boolean_Tag_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(3004)]
      [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Pool()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.Pool.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public sealed class Pool<T>(System.IntPtr pointer) : UnityUITextMeshProGlyphHelper.Tag.Pool(pointer)
      where T : UnityUITextMeshProGlyphHelper.Tag, new()
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__list;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_T_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Return_Public_Virtual_Boolean_Tag_0;

      static Pool()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag>.NativeClassPtr, "Pool`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool<T>>.NativeClassPtr);
        UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool<T>>.NativeClassPtr, nameof (_list));
        UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool<T>>.NativeClassPtr, 100668761);
        UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeMethodInfoPtr_Get_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool<T>>.NativeClassPtr, 100668762);
        UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeMethodInfoPtr_Return_Public_Virtual_Boolean_Tag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool<T>>.NativeClassPtr, 100668763);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 70107, RefRangeEnd = 70110, XrefRangeStart = 70103, XrefRangeEnd = 70107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Pool()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Tag.Pool<T>>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 70112, RefRangeEnd = 70115, XrefRangeStart = 70110, XrefRangeEnd = 70112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe T Get()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeMethodInfoPtr_Get_Public_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70115, XrefRangeEnd = 70119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe bool Return(UnityUITextMeshProGlyphHelper.Tag obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeMethodInfoPtr_Return_Public_Virtual_Boolean_Tag_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      public unsafe List<T> _list
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeFieldInfoPtr__list));
          return num == System.IntPtr.Zero ? (List<T>) null : Il2CppObjectPool.Get<List<T>>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Tag.Pool<T>.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public sealed class ControllerElementTag(System.IntPtr pointer) : UnityUITextMeshProGlyphHelper.Tag(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_type;
    private static readonly System.IntPtr NativeFieldInfoPtr_playerId;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__glyphsOrText;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphsOrText_Public_get_List_1_GlyphOrText_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_ControllerElementTag_byref_ControllerElementTag_0;

    static ControllerElementTag()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (ControllerElementTag));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, nameof (type));
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, nameof (playerId));
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_actionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, nameof (actionId));
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_actionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, nameof (actionRange));
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr__glyphsOrText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, nameof (_glyphsOrText));
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr_get_glyphsOrText_Public_get_List_1_GlyphOrText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, 100668764);
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, 100668765);
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, 100668766);
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, 100668767);
      UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_ControllerElementTag_byref_ControllerElementTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr, 100668768);
    }

    public unsafe List<UnityUITextMeshProGlyphHelper.GlyphOrText> glyphsOrText
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr_get_glyphsOrText_Public_get_List_1_GlyphOrText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.GlyphOrText>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.GlyphOrText>>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70130, XrefRangeEnd = 70165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70165, XrefRangeEnd = 70172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ControllerElementTag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ControllerElementTag>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70172, XrefRangeEnd = 70174, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 70245, RefRangeEnd = 70246, XrefRangeStart = 70174, XrefRangeEnd = 70245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryParseString(
      string text,
      int startIndex,
      int count,
      StringBuilder sb1,
      StringBuilder sb2,
      Dictionary<string, string> workDictionary,
      UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ControllerElementTag> pool,
      out UnityUITextMeshProGlyphHelper.ControllerElementTag result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb1);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb2);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) workDictionary);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_ControllerElementTag_byref_ControllerElementTag_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      ref UnityUITextMeshProGlyphHelper.ControllerElementTag local = ref result;
      System.IntPtr pointer = zero;
      UnityUITextMeshProGlyphHelper.ControllerElementTag controllerElementTag = pointer == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ControllerElementTag) null : new UnityUITextMeshProGlyphHelper.ControllerElementTag(pointer);
      local = controllerElementTag;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    public unsafe UnityUITextMeshProGlyphHelper.DisplayType type
    {
      get
      {
        return *(UnityUITextMeshProGlyphHelper.DisplayType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_type));
      }
      [param: In] set
      {
        *(UnityUITextMeshProGlyphHelper.DisplayType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_type)) = value;
      }
    }

    public unsafe int playerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_playerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_playerId)) = value;
      }
    }

    public unsafe int actionId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_actionId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_actionId)) = value;
      }
    }

    public unsafe AxisRange actionRange
    {
      get
      {
        return *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_actionRange));
      }
      [param: In] set
      {
        *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr_actionRange)) = value;
      }
    }

    public unsafe List<UnityUITextMeshProGlyphHelper.GlyphOrText> _glyphsOrText
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr__glyphsOrText));
        return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.GlyphOrText>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.GlyphOrText>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ControllerElementTag.NativeFieldInfoPtr__glyphsOrText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public sealed class ActionTag(System.IntPtr pointer) : UnityUITextMeshProGlyphHelper.Tag(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_actionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_actionRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__displayName;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_ActionTag_byref_ActionTag_0;

    static ActionTag()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (ActionTag));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr_actionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, nameof (actionId));
      UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr_actionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, nameof (actionRange));
      UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr__displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, nameof (_displayName));
      UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, 100668769);
      UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, 100668770);
      UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, 100668771);
      UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, 100668772);
      UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, 100668773);
      UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_ActionTag_byref_ActionTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr, 100668774);
    }

    public unsafe string displayName
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70246, XrefRangeEnd = 70270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70270, XrefRangeEnd = 70271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActionTag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ActionTag>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 70325, RefRangeEnd = 70326, XrefRangeStart = 70271, XrefRangeEnd = 70325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryParseString(
      string text,
      int startIndex,
      int count,
      StringBuilder sb1,
      StringBuilder sb2,
      Dictionary<string, string> workDictionary,
      UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.ActionTag> pool,
      out UnityUITextMeshProGlyphHelper.ActionTag result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb1);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb2);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) workDictionary);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.ActionTag.NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_ActionTag_byref_ActionTag_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      ref UnityUITextMeshProGlyphHelper.ActionTag local = ref result;
      System.IntPtr pointer = zero;
      UnityUITextMeshProGlyphHelper.ActionTag actionTag = pointer == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ActionTag) null : new UnityUITextMeshProGlyphHelper.ActionTag(pointer);
      local = actionTag;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    public unsafe int actionId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr_actionId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr_actionId)) = value;
      }
    }

    public unsafe AxisRange actionRange
    {
      get
      {
        return *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr_actionRange));
      }
      [param: In] set
      {
        *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr_actionRange)) = value;
      }
    }

    public unsafe string _displayName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr__displayName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.ActionTag.NativeFieldInfoPtr__displayName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  public sealed class PlayerTag(System.IntPtr pointer) : UnityUITextMeshProGlyphHelper.Tag(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_playerId;
    private static readonly System.IntPtr NativeFieldInfoPtr__displayName;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_displayName_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_PlayerTag_byref_PlayerTag_0;

    static PlayerTag()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (PlayerTag));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.PlayerTag.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr, nameof (playerId));
      UnityUITextMeshProGlyphHelper.PlayerTag.NativeFieldInfoPtr__displayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr, nameof (_displayName));
      UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_get_displayName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr, 100668775);
      UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr, 100668776);
      UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr, 100668777);
      UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr, 100668778);
      UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr, 100668779);
      UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_PlayerTag_byref_PlayerTag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr, 100668780);
    }

    public unsafe string displayName
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_get_displayName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_set_displayName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70326, XrefRangeEnd = 70344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70344, XrefRangeEnd = 70345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlayerTag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.PlayerTag>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public override unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_Clear_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 70386, RefRangeEnd = 70387, XrefRangeStart = 70345, XrefRangeEnd = 70386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryParseString(
      string text,
      int startIndex,
      int count,
      StringBuilder sb1,
      StringBuilder sb2,
      Dictionary<string, string> workDictionary,
      UnityUITextMeshProGlyphHelper.Tag.Pool<UnityUITextMeshProGlyphHelper.PlayerTag> pool,
      out UnityUITextMeshProGlyphHelper.PlayerTag result)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[8];
      numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb1);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb2);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) workDictionary);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(7) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.PlayerTag.NativeMethodInfoPtr_TryParseString_Public_Static_Boolean_String_Int32_Int32_StringBuilder_StringBuilder_Dictionary_2_String_String_Pool_1_PlayerTag_byref_PlayerTag_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      ref UnityUITextMeshProGlyphHelper.PlayerTag local = ref result;
      System.IntPtr pointer = zero;
      UnityUITextMeshProGlyphHelper.PlayerTag playerTag = pointer == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.PlayerTag) null : new UnityUITextMeshProGlyphHelper.PlayerTag(pointer);
      local = playerTag;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    public unsafe int playerId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.PlayerTag.NativeFieldInfoPtr_playerId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.PlayerTag.NativeFieldInfoPtr_playerId)) = value;
      }
    }

    public unsafe string _displayName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.PlayerTag.NativeFieldInfoPtr__displayName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.PlayerTag.NativeFieldInfoPtr__displayName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  public sealed class GlyphOrText : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_glyphKey;
    private static readonly System.IntPtr NativeFieldInfoPtr_sprite;
    private static readonly System.IntPtr NativeFieldInfoPtr_name;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphOrText_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GlyphOrText_GlyphOrText_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_GlyphOrText_GlyphOrText_0;

    static GlyphOrText()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (GlyphOrText));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_glyphKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr, nameof (glyphKey));
      UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr, nameof (sprite));
      UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr, nameof (name));
      UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr, 100668781);
      UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr, 100668782);
      UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphOrText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr, 100668783);
      UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GlyphOrText_GlyphOrText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr, 100668784);
      UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_GlyphOrText_GlyphOrText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr, 100668785);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70387, XrefRangeEnd = 70396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70396, XrefRangeEnd = 70402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(UnityUITextMeshProGlyphHelper.GlyphOrText other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphOrText_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70402, XrefRangeEnd = 70408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(
      UnityUITextMeshProGlyphHelper.GlyphOrText a,
      UnityUITextMeshProGlyphHelper.GlyphOrText b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_GlyphOrText_GlyphOrText_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 70414, RefRangeEnd = 70415, XrefRangeStart = 70408, XrefRangeEnd = 70414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(
      UnityUITextMeshProGlyphHelper.GlyphOrText a,
      UnityUITextMeshProGlyphHelper.GlyphOrText b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) a));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) b));
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_GlyphOrText_GlyphOrText_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public GlyphOrText(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public GlyphOrText()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.GlyphOrText>.NativeClassPtr))
    {
    }

    public unsafe string glyphKey
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_glyphKey)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_glyphKey), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Sprite sprite
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_sprite));
        return num == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.GlyphOrText.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  public class Asset(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_id;
    private static readonly System.IntPtr NativeFieldInfoPtr__spriteAsset;
    private static readonly System.IntPtr NativeFieldInfoPtr__material;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_idCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr___tmProShader;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteAsset_Public_get_ITMProSpriteAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_material_Public_get_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Material_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_Material_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_tmProShader_Private_Static_get_Shader_0;

    static Asset()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (Asset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, nameof (id));
      UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr__spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, nameof (_spriteAsset));
      UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, nameof (_material));
      UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr_s_idCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, nameof (s_idCounter));
      UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr___tmProShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, nameof (__tmProShader));
      UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_get_spriteAsset_Public_get_ITMProSpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, 100668786);
      UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_get_material_Public_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, 100668787);
      UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr__ctor_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, 100668788);
      UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_Material_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, 100668789);
      UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, 100668790);
      UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_get_tmProShader_Private_Static_get_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr, 100668791);
    }

    public unsafe UnityUITextMeshProGlyphHelper.ITMProSpriteAsset spriteAsset
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_get_spriteAsset_Public_get_ITMProSpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ITMProSpriteAsset) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>(num3);
      }
    }

    public unsafe Material material
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_get_material_Public_get_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
      }
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 70469, RefRangeEnd = 70474, XrefRangeStart = 70415, XrefRangeEnd = 70469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Asset(Material baseMaterial)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.Asset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) baseMaterial)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr__ctor_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 70512, RefRangeEnd = 70513, XrefRangeStart = 70474, XrefRangeEnd = 70512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Material CreateMaterial(Material baseMaterial, uint id)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) baseMaterial);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &id;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_CreateMaterial_Public_Static_Material_Material_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num3);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 70523, RefRangeEnd = 70526, XrefRangeStart = 70513, XrefRangeEnd = 70523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Destroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe Shader tmProShader
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70526, XrefRangeEnd = 70541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.Asset.NativeMethodInfoPtr_get_tmProShader_Private_Static_get_Shader_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num3);
      }
    }

    public unsafe uint id
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr_id));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr_id)) = value;
      }
    }

    public unsafe UnityUITextMeshProGlyphHelper.ITMProSpriteAsset _spriteAsset
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr__spriteAsset));
        return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ITMProSpriteAsset) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr__spriteAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material _material
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr__material));
        return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe uint s_idCounter
    {
      get
      {
        uint sIdCounter;
        IL2CPP.il2cpp_field_static_get_value(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr_s_idCounter, (void*) &sIdCounter);
        return sIdCounter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr_s_idCounter, (void*) &value);
      }
    }

    public static unsafe Shader __tmProShader
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr___tmProShader, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Shader) null : Il2CppObjectPool.Get<Shader>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnityUITextMeshProGlyphHelper.Asset.NativeFieldInfoPtr___tmProShader, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TMProSpriteOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__scale;
    private static readonly System.IntPtr NativeFieldInfoPtr__offsetSizeMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr__extraOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr__xAdvanceWidthMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr__extraXAdvance;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_offsetSizeMultiplier_Public_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_offsetSizeMultiplier_Public_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_extraOffset_Public_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_extraOffset_Public_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_xAdvanceWidthMultiplier_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_xAdvanceWidthMultiplier_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_extraXAdvance_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_extraXAdvance_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_TMProSpriteOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TMProSpriteOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TMProSpriteOptions_TMProSpriteOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TMProSpriteOptions_TMProSpriteOptions_0;
    [FieldOffset(0)]
    public float _scale;
    [FieldOffset(4)]
    public Vector2 _offsetSizeMultiplier;
    [FieldOffset(12)]
    public Vector2 _extraOffset;
    [FieldOffset(20)]
    public float _xAdvanceWidthMultiplier;
    [FieldOffset(24)]
    public float _extraXAdvance;

    static TMProSpriteOptions()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (TMProSpriteOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeFieldInfoPtr__scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, nameof (_scale));
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeFieldInfoPtr__offsetSizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, nameof (_offsetSizeMultiplier));
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeFieldInfoPtr__extraOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, nameof (_extraOffset));
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeFieldInfoPtr__xAdvanceWidthMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, nameof (_xAdvanceWidthMultiplier));
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeFieldInfoPtr__extraXAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, nameof (_extraXAdvance));
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668792);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668793);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_offsetSizeMultiplier_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668794);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_offsetSizeMultiplier_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668795);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_extraOffset_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668796);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_extraOffset_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668797);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_xAdvanceWidthMultiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668798);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_xAdvanceWidthMultiplier_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668799);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_extraXAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668800);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_extraXAdvance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668801);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_Default_Public_Static_get_TMProSpriteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668802);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668803);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668804);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TMProSpriteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668805);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TMProSpriteOptions_TMProSpriteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668806);
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TMProSpriteOptions_TMProSpriteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, 100668807);
    }

    public unsafe float scale
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_scale_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(43), CachedScanResults(RefRangeStart = 70541, RefRangeEnd = 70584, XrefRangeStart = 70541, XrefRangeEnd = 70541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Vector2 offsetSizeMultiplier
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_offsetSizeMultiplier_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 70584, RefRangeEnd = 70588, XrefRangeStart = 70584, XrefRangeEnd = 70584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_offsetSizeMultiplier_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe Vector2 extraOffset
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_extraOffset_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 70588, RefRangeEnd = 70589, XrefRangeStart = 70588, XrefRangeEnd = 70588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_extraOffset_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe float xAdvanceWidthMultiplier
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_xAdvanceWidthMultiplier_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 70589, RefRangeEnd = 70590, XrefRangeStart = 70589, XrefRangeEnd = 70589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_xAdvanceWidthMultiplier_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe float extraXAdvance
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_extraXAdvance_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 70590, RefRangeEnd = 70591, XrefRangeStart = 70590, XrefRangeEnd = 70590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_set_extraXAdvance_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public static unsafe UnityUITextMeshProGlyphHelper.TMProSpriteOptions Default
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 70591, RefRangeEnd = 70592, XrefRangeStart = 70591, XrefRangeEnd = 70591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_get_Default_Public_Static_get_TMProSpriteOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(UnityUITextMeshProGlyphHelper.TMProSpriteOptions*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70592, XrefRangeEnd = 70595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70595, XrefRangeEnd = 70602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &other
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TMProSpriteOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe bool operator ==(
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions a,
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TMProSpriteOptions_TMProSpriteOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe bool operator !=(
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions a,
      UnityUITextMeshProGlyphHelper.TMProSpriteOptions b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSpriteOptions.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TMProSpriteOptions_TMProSpriteOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSpriteOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct SpriteMaterialProperties
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__color;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_color_Public_get_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_color_Public_set_Void_Color_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_SpriteMaterialProperties_0;
    [FieldOffset(0)]
    public Color _color;

    static SpriteMaterialProperties()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.SpriteMaterialProperties>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (SpriteMaterialProperties));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.SpriteMaterialProperties>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.SpriteMaterialProperties.NativeFieldInfoPtr__color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.SpriteMaterialProperties>.NativeClassPtr, nameof (_color));
      UnityUITextMeshProGlyphHelper.SpriteMaterialProperties.NativeMethodInfoPtr_get_color_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.SpriteMaterialProperties>.NativeClassPtr, 100668808);
      UnityUITextMeshProGlyphHelper.SpriteMaterialProperties.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.SpriteMaterialProperties>.NativeClassPtr, 100668809);
      UnityUITextMeshProGlyphHelper.SpriteMaterialProperties.NativeMethodInfoPtr_get_Default_Public_Static_get_SpriteMaterialProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.SpriteMaterialProperties>.NativeClassPtr, 100668810);
    }

    public unsafe Color color
    {
      [CallerCount(10), CachedScanResults(RefRangeStart = 70602, RefRangeEnd = 70612, XrefRangeStart = 70602, XrefRangeEnd = 70602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties.NativeMethodInfoPtr_get_color_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(15), CachedScanResults(RefRangeStart = 70612, RefRangeEnd = 70627, XrefRangeStart = 70612, XrefRangeEnd = 70612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties.NativeMethodInfoPtr_set_color_Public_set_Void_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public static unsafe UnityUITextMeshProGlyphHelper.SpriteMaterialProperties Default
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 70627, RefRangeEnd = 70628, XrefRangeStart = 70627, XrefRangeEnd = 70627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties.NativeMethodInfoPtr_get_Default_Public_Static_get_SpriteMaterialProperties_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(UnityUITextMeshProGlyphHelper.SpriteMaterialProperties*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.SpriteMaterialProperties>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public class ITMProSprite(System.IntPtr pointer) : Il2CppObjectBase(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Public_Abstract_Virtual_New_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_Abstract_Virtual_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_Abstract_Virtual_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_Abstract_Virtual_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_Abstract_Virtual_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_xOffset_Public_Abstract_Virtual_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_xOffset_Public_Abstract_Virtual_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_yOffset_Public_Abstract_Virtual_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_yOffset_Public_Abstract_Virtual_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_xAdvance_Public_Abstract_Virtual_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_xAdvance_Public_Abstract_Virtual_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_Abstract_Virtual_New_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Public_Abstract_Virtual_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_pivot_Public_Abstract_Virtual_New_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_scale_Public_Abstract_Virtual_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_scale_Public_Abstract_Virtual_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_Abstract_Virtual_New_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_unicode_Public_Abstract_Virtual_New_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_unicode_Public_Abstract_Virtual_New_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_hashCode_Public_Abstract_Virtual_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_hashCode_Public_Abstract_Virtual_New_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_sprite_Public_Abstract_Virtual_New_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_sprite_Public_Abstract_Virtual_New_set_Void_Sprite_0;

    static ITMProSprite()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (ITMProSprite));
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668811);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_id_Public_Abstract_Virtual_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668812);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_width_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668813);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_width_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668814);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_height_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668815);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_height_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668816);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_xOffset_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668817);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_xOffset_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668818);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_yOffset_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668819);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_yOffset_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668820);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_xAdvance_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668821);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_xAdvance_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668822);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668823);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_position_Public_Abstract_Virtual_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668824);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_pivot_Public_Abstract_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668825);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_pivot_Public_Abstract_Virtual_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668826);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_scale_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668827);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_scale_Public_Abstract_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668828);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668829);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_name_Public_Abstract_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668830);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_unicode_Public_Abstract_Virtual_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668831);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_unicode_Public_Abstract_Virtual_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668832);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_hashCode_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668833);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_hashCode_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668834);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_sprite_Public_Abstract_Virtual_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668835);
      UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_sprite_Public_Abstract_Virtual_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSprite>.NativeClassPtr, 100668836);
    }

    public virtual unsafe uint id
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_id_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_id_Public_Abstract_Virtual_New_set_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float width
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_width_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_width_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float height
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_height_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_height_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float xOffset
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_xOffset_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_xOffset_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float yOffset
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_yOffset_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_yOffset_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float xAdvance
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_xAdvance_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_xAdvance_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Vector2 position
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_position_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_position_Public_Abstract_Virtual_New_set_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Vector2 pivot
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_pivot_Public_Abstract_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_pivot_Public_Abstract_Virtual_New_set_Void_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float scale
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_scale_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_scale_Public_Abstract_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe string name
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_name_Public_Abstract_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe uint unicode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_unicode_Public_Abstract_Virtual_New_get_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_unicode_Public_Abstract_Virtual_New_set_Void_UInt32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe int hashCode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_hashCode_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_hashCode_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Sprite sprite
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_get_sprite_Public_Abstract_Virtual_New_get_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSprite.NativeMethodInfoPtr_set_sprite_Public_Abstract_Virtual_New_set_Void_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }
  }

  public class ITMProSpriteAsset(System.IntPtr pointer) : Il2CppObjectBase(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteCount_Public_Abstract_Virtual_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteSheet_Public_Abstract_Virtual_New_get_Texture_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_spriteSheet_Public_Abstract_Virtual_New_set_Void_Texture_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteAsset_Public_Abstract_Virtual_New_TMP_SpriteAsset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Public_Abstract_Virtual_New_ITMProSprite_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddSprite_Public_Abstract_Virtual_New_Void_ITMProSprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLookupTables_Public_Abstract_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0;

    static ITMProSpriteAsset()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (ITMProSpriteAsset));
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_get_spriteCount_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668837);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_get_spriteSheet_Public_Abstract_Virtual_New_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668838);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_set_spriteSheet_Public_Abstract_Virtual_New_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668839);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_GetSpriteAsset_Public_Abstract_Virtual_New_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668840);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_GetSprite_Public_Abstract_Virtual_New_ITMProSprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668841);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_AddSprite_Public_Abstract_Virtual_New_Void_ITMProSprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668842);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668843);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668844);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668845);
      UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>.NativeClassPtr, 100668846);
    }

    public virtual unsafe int spriteCount
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_get_spriteCount_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public virtual unsafe Texture spriteSheet
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_get_spriteSheet_Public_Abstract_Virtual_New_get_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_set_spriteSheet_Public_Abstract_Virtual_New_set_Void_Texture_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    public virtual unsafe TMP_SpriteAsset GetSpriteAsset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_GetSpriteAsset_Public_Abstract_Virtual_New_TMP_SpriteAsset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TMP_SpriteAsset) null : Il2CppObjectPool.Get<TMP_SpriteAsset>(num3);
    }

    [CallerCount(0)]
    public virtual unsafe UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_GetSprite_Public_Abstract_Virtual_New_ITMProSprite_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ITMProSprite) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.ITMProSprite>(num3);
    }

    [CallerCount(0)]
    public virtual unsafe void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_AddSprite_Public_Abstract_Virtual_New_Void_ITMProSprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool Contains(string spriteName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(spriteName)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void UpdateLookupTables()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Destroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUITextMeshProGlyphHelper.ITMProSpriteAsset.NativeMethodInfoPtr_Destroy_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static class TMProAssetVersionHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__isVersionSupportedChecked;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckVersionSupported_Private_Static_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSprite_Public_Static_ITMProSprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSpriteAsset_Public_Static_ITMProSpriteAsset_0;

    static TMProAssetVersionHelper()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (TMProAssetVersionHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeFieldInfoPtr__isVersionSupportedChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper>.NativeClassPtr, nameof (_isVersionSupportedChecked));
      UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeMethodInfoPtr_CheckVersionSupported_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper>.NativeClassPtr, 100668847);
      UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeMethodInfoPtr_CreateSprite_Public_Static_ITMProSprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper>.NativeClassPtr, 100668848);
      UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeMethodInfoPtr_CreateSpriteAsset_Public_Static_ITMProSpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper>.NativeClassPtr, 100668849);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70628, XrefRangeEnd = 70631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckVersionSupported()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeMethodInfoPtr_CheckVersionSupported_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 70657, RefRangeEnd = 70658, XrefRangeStart = 70631, XrefRangeEnd = 70657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe UnityUITextMeshProGlyphHelper.ITMProSprite CreateSprite()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeMethodInfoPtr_CreateSprite_Public_Static_ITMProSprite_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ITMProSprite) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.ITMProSprite>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70658, XrefRangeEnd = 70666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe UnityUITextMeshProGlyphHelper.ITMProSpriteAsset CreateSpriteAsset()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeMethodInfoPtr_CreateSpriteAsset_Public_Static_ITMProSpriteAsset_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ITMProSpriteAsset) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.ITMProSpriteAsset>(num3);
    }

    public TMProAssetVersionHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool _isVersionSupportedChecked
    {
      get
      {
        bool supportedChecked;
        IL2CPP.il2cpp_field_static_get_value(UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeFieldInfoPtr__isVersionSupportedChecked, (void*) &supportedChecked);
        return supportedChecked;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnityUITextMeshProGlyphHelper.TMProAssetVersionHelper.NativeFieldInfoPtr__isVersionSupportedChecked, (void*) &value);
      }
    }
  }

  public class TMProSprite_AssetV1_0_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_spriteInfo;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_xOffset_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_xOffset_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_yOffset_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_yOffset_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_xAdvance_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_xAdvance_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_Virtual_Final_New_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Public_Virtual_Final_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_pivot_Public_Virtual_Final_New_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_scale_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_scale_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_unicode_Public_Virtual_Final_New_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_unicode_Public_Virtual_Final_New_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_hashCode_Public_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_hashCode_Public_Virtual_Final_New_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_sprite_Public_Virtual_Final_New_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_sprite_Public_Virtual_Final_New_set_Void_Sprite_0;

    static TMProSprite_AssetV1_0_0()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (TMProSprite_AssetV1_0_0));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeFieldInfoPtr_spriteInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, nameof (spriteInfo));
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668850);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668851);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668852);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668853);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_width_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668854);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668855);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_height_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668856);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_xOffset_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668857);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_xOffset_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668858);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_yOffset_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668859);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_yOffset_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668860);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_xAdvance_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668861);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_xAdvance_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668862);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668863);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_position_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668864);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_pivot_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668865);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_pivot_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668866);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_scale_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668867);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_scale_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668868);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668869);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668870);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_unicode_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668871);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_unicode_Public_Virtual_Final_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668872);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_hashCode_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668873);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_hashCode_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668874);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_sprite_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668875);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_sprite_Public_Virtual_Final_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, 100668876);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70716, XrefRangeEnd = 70721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TMProSprite_AssetV1_0_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe uint id
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float width
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_width_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float height
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_height_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float xOffset
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_xOffset_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_xOffset_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float yOffset
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_yOffset_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_yOffset_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float xAdvance
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_xAdvance_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_xAdvance_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Vector2 position
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_position_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Vector2 pivot
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_pivot_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_pivot_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float scale
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_scale_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_scale_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe string name
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe uint unicode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_unicode_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_unicode_Public_Virtual_Final_New_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe int hashCode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_hashCode_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_hashCode_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Sprite sprite
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_get_sprite_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeMethodInfoPtr_set_sprite_Public_Virtual_Final_New_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe TMP_Sprite spriteInfo
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeFieldInfoPtr_spriteInfo));
        return num == System.IntPtr.Zero ? (TMP_Sprite) null : Il2CppObjectPool.Get<TMP_Sprite>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.NativeFieldInfoPtr_spriteInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class TMPro_SpriteAsset(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__spriteAsset;
      private static readonly System.IntPtr NativeFieldInfoPtr__sprites;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteCount_Public_Virtual_Final_New_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteSheet_Public_Virtual_Final_New_get_Texture_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_spriteSheet_Public_Virtual_Final_New_set_Void_Texture_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteAsset_Public_Virtual_Final_New_TMP_SpriteAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Public_Virtual_Final_New_ITMProSprite_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddSprite_Public_Virtual_Final_New_Void_ITMProSprite_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLookupTables_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0;

      static TMPro_SpriteAsset()
      {
        Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>.NativeClassPtr, nameof (TMPro_SpriteAsset));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, nameof (_spriteAsset));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeFieldInfoPtr__sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, nameof (_sprites));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_get_spriteCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668877);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_get_spriteSheet_Public_Virtual_Final_New_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668878);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_set_spriteSheet_Public_Virtual_Final_New_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668879);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668880);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_GetSpriteAsset_Public_Virtual_Final_New_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668881);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_GetSprite_Public_Virtual_Final_New_ITMProSprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668882);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_AddSprite_Public_Virtual_Final_New_Void_ITMProSprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668883);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668884);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668885);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668886);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr, 100668887);
      }

      public virtual unsafe int spriteCount
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70666, XrefRangeEnd = 70667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_get_spriteCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          return *(int*) IL2CPP.il2cpp_object_unbox(num2);
        }
      }

      public virtual unsafe Texture spriteSheet
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_get_spriteSheet_Public_Virtual_Final_New_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
        }
        [CallerCount(0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
          };
          System.IntPtr num;
          IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_set_spriteSheet_Public_Virtual_Final_New_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
          Il2CppException.RaiseExceptionIfNecessary(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70667, XrefRangeEnd = 70684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TMPro_SpriteAsset()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(13)]
      [CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe TMP_SpriteAsset GetSpriteAsset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_GetSpriteAsset_Public_Virtual_Final_New_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (TMP_SpriteAsset) null : Il2CppObjectPool.Get<TMP_SpriteAsset>(num3);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70684, XrefRangeEnd = 70688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &index
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_GetSprite_Public_Virtual_Final_New_ITMProSprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ITMProSprite) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.ITMProSprite>(num3);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70688, XrefRangeEnd = 70698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_AddSprite_Public_Virtual_Final_New_Void_ITMProSprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70698, XrefRangeEnd = 70702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Clear()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70702, XrefRangeEnd = 70707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Contains(string spriteName)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(spriteName)
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70707, XrefRangeEnd = 70709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void UpdateLookupTables()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70709, XrefRangeEnd = 70716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Destroy()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public unsafe TMP_SpriteAsset _spriteAsset
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteAsset));
          return num == System.IntPtr.Zero ? (TMP_SpriteAsset) null : Il2CppObjectPool.Get<TMP_SpriteAsset>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0> _sprites
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeFieldInfoPtr__sprites));
          return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0>>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_0_0.TMPro_SpriteAsset.NativeFieldInfoPtr__sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public class TMProSprite_AssetV1_1_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__spriteGlyph;
    private static readonly System.IntPtr NativeFieldInfoPtr__spriteCharacter;
    private static readonly System.IntPtr NativeFieldInfoPtr_s_isVersionSupported;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteGlyph_Public_get_TMPro_SpriteGlyph_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteCharacter_Public_get_TMPro_SpriteCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_xOffset_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_xOffset_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_yOffset_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_yOffset_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_xAdvance_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_xAdvance_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_Virtual_Final_New_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_pivot_Public_Virtual_Final_New_get_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_pivot_Public_Virtual_Final_New_set_Void_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_scale_Public_Virtual_Final_New_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_scale_Public_Virtual_Final_New_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_unicode_Public_Virtual_Final_New_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_unicode_Public_Virtual_Final_New_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_hashCode_Public_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_hashCode_Public_Virtual_Final_New_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_sprite_Public_Virtual_Final_New_get_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_sprite_Public_Virtual_Final_New_set_Void_Sprite_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CheckVersionSupported_Public_Static_Boolean_0;

    static TMProSprite_AssetV1_1_0()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, nameof (TMProSprite_AssetV1_1_0));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr__spriteGlyph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, nameof (_spriteGlyph));
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr__spriteCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, nameof (_spriteCharacter));
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr_s_isVersionSupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, nameof (s_isVersionSupported));
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668888);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_spriteGlyph_Public_get_TMPro_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668889);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_spriteCharacter_Public_get_TMPro_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668890);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668891);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668892);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668893);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_width_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668894);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668895);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_height_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668896);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_xOffset_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668897);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_xOffset_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668898);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_yOffset_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668899);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_yOffset_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668900);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_xAdvance_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668901);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_xAdvance_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668902);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668903);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_position_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668904);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_pivot_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668905);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_pivot_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668906);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_scale_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668907);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_scale_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668908);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668909);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668910);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_unicode_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668911);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_unicode_Public_Virtual_Final_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668912);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_hashCode_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668913);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_hashCode_Public_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668914);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_sprite_Public_Virtual_Final_New_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668915);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_sprite_Public_Virtual_Final_New_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668916);
      UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_CheckVersionSupported_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, 100668917);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70831, XrefRangeEnd = 70850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TMProSprite_AssetV1_1_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph spriteGlyph
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_spriteGlyph_Public_get_TMPro_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>(num3);
      }
    }

    public unsafe UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter spriteCharacter
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_spriteCharacter_Public_get_TMPro_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>(num3);
      }
    }

    public virtual unsafe uint id
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70850, XrefRangeEnd = 70852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70852, XrefRangeEnd = 70853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_id_Public_Virtual_Final_New_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float width
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70853, XrefRangeEnd = 70855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70855, XrefRangeEnd = 70864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_width_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float height
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70864, XrefRangeEnd = 70866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70866, XrefRangeEnd = 70875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_height_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float xOffset
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70875, XrefRangeEnd = 70877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_xOffset_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70877, XrefRangeEnd = 70880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_xOffset_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float yOffset
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70880, XrefRangeEnd = 70882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_yOffset_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70882, XrefRangeEnd = 70885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_yOffset_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float xAdvance
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70885, XrefRangeEnd = 70887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_xAdvance_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70887, XrefRangeEnd = 70890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_xAdvance_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Vector2 position
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70890, XrefRangeEnd = 70896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_position_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70896, XrefRangeEnd = 70903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_position_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Vector2 pivot
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 70903, RefRangeEnd = 70906, XrefRangeStart = 70903, XrefRangeEnd = 70903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_pivot_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(15159), CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_pivot_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe float scale
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_scale_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(float*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_scale_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe string name
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return IL2CPP.Il2CppStringToManaged(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe uint unicode
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_unicode_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_unicode_Public_Virtual_Final_New_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe int hashCode
    {
      [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_hashCode_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(15159), CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_hashCode_Public_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public virtual unsafe Sprite sprite
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_get_sprite_Public_Virtual_Final_New_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_set_sprite_Public_Virtual_Final_New_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 70927, RefRangeEnd = 70931, XrefRangeStart = 70906, XrefRangeEnd = 70927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool CheckVersionSupported()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeMethodInfoPtr_CheckVersionSupported_Public_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph _spriteGlyph
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr__spriteGlyph));
        return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr__spriteGlyph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter _spriteCharacter
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr__spriteCharacter));
        return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr__spriteCharacter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Nullable<bool> s_isVersionSupported
    {
      get
      {
        System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        IL2CPP.il2cpp_field_static_get_value(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr_s_isVersionSupported, (void*) num);
        return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.NativeFieldInfoPtr_s_isVersionSupported, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
      }
    }

    public class TMPro_SpriteCharacter(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__source;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_source_Public_get_TMP_SpriteCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      static TMPro_SpriteCharacter()
      {
        Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, nameof (TMPro_SpriteCharacter));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, nameof (_source));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_source_Public_get_TMP_SpriteCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668918);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668919);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668920);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668921);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668922);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668923);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668924);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668925);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668926);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668927);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668928 /*0x06001600*/);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr, 100668929);
      }

      public unsafe TMP_SpriteCharacter source
      {
        [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_source_Public_get_TMP_SpriteCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (TMP_SpriteCharacter) null : Il2CppObjectPool.Get<TMP_SpriteCharacter>(num3);
        }
      }

      public unsafe Glyph glyph
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_glyph_Public_get_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Glyph) null : Il2CppObjectPool.Get<Glyph>(num3);
        }
        [CallerCount(0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
          };
          System.IntPtr num;
          IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_glyph_Public_set_Void_Glyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
          Il2CppException.RaiseExceptionIfNecessary(num);
        }
      }

      public unsafe uint unicode
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_unicode_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
        }
        [CallerCount(0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr num;
          IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_unicode_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
          Il2CppException.RaiseExceptionIfNecessary(num);
        }
      }

      public unsafe string name
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          return IL2CPP.Il2CppStringToManaged(num2);
        }
        [CallerCount(6), CachedScanResults(RefRangeStart = 70721, RefRangeEnd = 70727, XrefRangeStart = 70721, XrefRangeEnd = 70721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            IL2CPP.ManagedStringToIl2Cpp(value)
          };
          System.IntPtr num;
          IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
          Il2CppException.RaiseExceptionIfNecessary(num);
        }
      }

      public unsafe float scale
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          return *(float*) IL2CPP.il2cpp_object_unbox(num2);
        }
        [CallerCount(0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr num;
          IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
          Il2CppException.RaiseExceptionIfNecessary(num);
        }
      }

      public unsafe uint glyphIndex
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_get_glyphIndex_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
        }
        [CallerCount(0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            (System.IntPtr) &value
          };
          System.IntPtr num;
          IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr_set_glyphIndex_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
          Il2CppException.RaiseExceptionIfNecessary(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70727, XrefRangeEnd = 70732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TMPro_SpriteCharacter()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public unsafe TMP_SpriteCharacter _source
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeFieldInfoPtr__source));
          return num == System.IntPtr.Zero ? (TMP_SpriteCharacter) null : Il2CppObjectPool.Get<TMP_SpriteCharacter>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteCharacter.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class TMPro_SpriteGlyph(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__source;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_source_Public_get_TMP_SpriteGlyph_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_Glyph_0;

      static TMPro_SpriteGlyph()
      {
        Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, nameof (TMPro_SpriteGlyph));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeFieldInfoPtr__source = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr, nameof (_source));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr_get_source_Public_get_TMP_SpriteGlyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr, 100668930);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr, 100668931);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr, 100668932);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr, 100668933);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr_Initialize_Private_Static_Void_Glyph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr, 100668934);
      }

      public unsafe TMP_SpriteGlyph source
      {
        [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr_get_source_Public_get_TMP_SpriteGlyph_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (TMP_SpriteGlyph) null : Il2CppObjectPool.Get<TMP_SpriteGlyph>(num3);
        }
      }

      public unsafe Sprite sprite
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr_get_sprite_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
        }
        [CallerCount(0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
          };
          System.IntPtr num;
          IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr_set_sprite_Public_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
          Il2CppException.RaiseExceptionIfNecessary(num);
        }
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70732, XrefRangeEnd = 70740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TMPro_SpriteGlyph()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70740, XrefRangeEnd = 70743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Initialize(Glyph glyph)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) glyph)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeMethodInfoPtr_Initialize_Private_Static_Void_Glyph_0, System.IntPtr.Zero, (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public unsafe TMP_SpriteGlyph _source
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeFieldInfoPtr__source));
          return num == System.IntPtr.Zero ? (TMP_SpriteGlyph) null : Il2CppObjectPool.Get<TMP_SpriteGlyph>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteGlyph.NativeFieldInfoPtr__source), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    public class TMPro_SpriteAsset(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__spriteCharacterTable;
      private static readonly System.IntPtr NativeFieldInfoPtr__spriteGlyphTable;
      private static readonly System.IntPtr NativeFieldInfoPtr__spriteCharacterTableList;
      private static readonly System.IntPtr NativeFieldInfoPtr__spriteGlyphTableList;
      private static readonly System.IntPtr NativeFieldInfoPtr__sprites;
      private static readonly System.IntPtr NativeFieldInfoPtr__spriteAsset;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteCount_Public_Virtual_Final_New_get_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_spriteSheet_Public_Virtual_Final_New_get_Texture_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_set_spriteSheet_Public_Virtual_Final_New_set_Void_Texture_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetSpriteAsset_Public_Virtual_Final_New_TMP_SpriteAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Public_Virtual_Final_New_ITMProSprite_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_AddSprite_Public_Virtual_Final_New_Void_ITMProSprite_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLookupTables_Public_Virtual_Final_New_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0;

      static TMPro_SpriteAsset()
      {
        Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>.NativeClassPtr, nameof (TMPro_SpriteAsset));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteCharacterTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, nameof (_spriteCharacterTable));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteGlyphTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, nameof (_spriteGlyphTable));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteCharacterTableList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, nameof (_spriteCharacterTableList));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteGlyphTableList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, nameof (_spriteGlyphTableList));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__sprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, nameof (_sprites));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, nameof (_spriteAsset));
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_get_spriteCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668935);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_get_spriteSheet_Public_Virtual_Final_New_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668936);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_set_spriteSheet_Public_Virtual_Final_New_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668937);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668938);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_GetSpriteAsset_Public_Virtual_Final_New_TMP_SpriteAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668939);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_GetSprite_Public_Virtual_Final_New_ITMProSprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668940);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_AddSprite_Public_Virtual_Final_New_Void_ITMProSprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668941);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668942);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668943);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668944);
        UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr, 100668945);
      }

      public virtual unsafe int spriteCount
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70743, XrefRangeEnd = 70744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_get_spriteCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          return *(int*) IL2CPP.il2cpp_object_unbox(num2);
        }
      }

      public virtual unsafe Texture spriteSheet
      {
        [CallerCount(0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_get_spriteSheet_Public_Virtual_Final_New_get_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          System.IntPtr num3 = num2;
          return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
        }
        [CallerCount(0)] set
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          System.IntPtr* numPtr = stackalloc System.IntPtr[1]
          {
            IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
          };
          System.IntPtr num;
          IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_set_spriteSheet_Public_Virtual_Final_New_set_Void_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
          Il2CppException.RaiseExceptionIfNecessary(num);
        }
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 70789, RefRangeEnd = 70792, XrefRangeStart = 70744, XrefRangeEnd = 70789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TMPro_SpriteAsset()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(15)]
      [CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe TMP_SpriteAsset GetSpriteAsset()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_GetSpriteAsset_Public_Virtual_Final_New_TMP_SpriteAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (TMP_SpriteAsset) null : Il2CppObjectPool.Get<TMP_SpriteAsset>(num3);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70792, XrefRangeEnd = 70796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe UnityUITextMeshProGlyphHelper.ITMProSprite GetSprite(int index)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &index
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_GetSprite_Public_Virtual_Final_New_ITMProSprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper.ITMProSprite) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper.ITMProSprite>(num3);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70796, XrefRangeEnd = 70810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void AddSprite(UnityUITextMeshProGlyphHelper.ITMProSprite sprite)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_AddSprite_Public_Virtual_Final_New_Void_ITMProSprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70810, XrefRangeEnd = 70817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Clear()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Clear_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70817, XrefRangeEnd = 70822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Contains(string spriteName)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.ManagedStringToIl2Cpp(spriteName)
        };
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Contains_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70822, XrefRangeEnd = 70824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void UpdateLookupTables()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_UpdateLookupTables_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70824, XrefRangeEnd = 70831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Destroy()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeMethodInfoPtr_Destroy_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public unsafe PropertyInfo _spriteCharacterTable
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteCharacterTable));
          return num == System.IntPtr.Zero ? (PropertyInfo) null : Il2CppObjectPool.Get<PropertyInfo>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteCharacterTable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe PropertyInfo _spriteGlyphTable
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteGlyphTable));
          return num == System.IntPtr.Zero ? (PropertyInfo) null : Il2CppObjectPool.Get<PropertyInfo>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteGlyphTable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe IList _spriteCharacterTableList
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteCharacterTableList));
          return num == System.IntPtr.Zero ? (IList) null : Il2CppObjectPool.Get<IList>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteCharacterTableList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe IList _spriteGlyphTableList
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteGlyphTableList));
          return num == System.IntPtr.Zero ? (IList) null : Il2CppObjectPool.Get<IList>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteGlyphTableList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0> _sprites
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__sprites));
          return num == System.IntPtr.Zero ? (List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>) null : Il2CppObjectPool.Get<List<UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0>>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__sprites), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TMP_SpriteAsset _spriteAsset
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteAsset));
          return num == System.IntPtr.Zero ? (TMP_SpriteAsset) null : Il2CppObjectPool.Get<TMP_SpriteAsset>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.TMProSprite_AssetV1_1_0.TMPro_SpriteAsset.NativeFieldInfoPtr__spriteAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }

  public enum DisplayType
  {
    Glyph,
    Text,
    GlyphOrText,
  }

  [ObfuscatedName("Rewired.Glyphs.UnityUI.UnityUITextMeshProGlyphHelper+<>c__DisplayClass48_0")]
  public sealed class __c__DisplayClass48_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sourceMaterial;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__set_baseSpriteMaterial_b__0_Internal_Void_Asset_0;

    static __c__DisplayClass48_0()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, "<>c__DisplayClass48_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeFieldInfoPtr_sourceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0>.NativeClassPtr, nameof (sourceMaterial));
      UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0>.NativeClassPtr, "<>4__this");
      UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0>.NativeClassPtr, 100668946);
      UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeMethodInfoPtr__set_baseSpriteMaterial_b__0_Internal_Void_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0>.NativeClassPtr, 100668947);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass48_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70931, XrefRangeEnd = 70938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _set_baseSpriteMaterial_b__0(UnityUITextMeshProGlyphHelper.Asset asset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeMethodInfoPtr__set_baseSpriteMaterial_b__0_Internal_Void_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Material sourceMaterial
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeFieldInfoPtr_sourceMaterial));
        return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeFieldInfoPtr_sourceMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UnityUITextMeshProGlyphHelper __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UnityUITextMeshProGlyphHelper) null : Il2CppObjectPool.Get<UnityUITextMeshProGlyphHelper>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.__c__DisplayClass48_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("Rewired.Glyphs.UnityUI.UnityUITextMeshProGlyphHelper+<>c__DisplayClass51_0")]
  public sealed class __c__DisplayClass51_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sourceMaterial;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__set_overrideSpriteMaterialProperties_b__1_Internal_Void_Asset_0;

    static __c__DisplayClass51_0()
    {
      Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper>.NativeClassPtr, "<>c__DisplayClass51_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0>.NativeClassPtr);
      UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0.NativeFieldInfoPtr_sourceMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0>.NativeClassPtr, nameof (sourceMaterial));
      UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0>.NativeClassPtr, 100668948);
      UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0.NativeMethodInfoPtr__set_overrideSpriteMaterialProperties_b__1_Internal_Void_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0>.NativeClassPtr, 100668949);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass51_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70938, XrefRangeEnd = 70947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _set_overrideSpriteMaterialProperties_b__1(
      UnityUITextMeshProGlyphHelper.Asset asset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0.NativeMethodInfoPtr__set_overrideSpriteMaterialProperties_b__1_Internal_Void_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Material sourceMaterial
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0.NativeFieldInfoPtr_sourceMaterial));
        return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUITextMeshProGlyphHelper.__c__DisplayClass51_0.NativeFieldInfoPtr_sourceMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
