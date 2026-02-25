// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyphBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs;

public class ControllerElementGlyphBase(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__glyphOrTextPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr__allowedTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr__entries;
  private static readonly System.IntPtr NativeFieldInfoPtr__tempGlyphs;
  private static readonly System.IntPtr NativeFieldInfoPtr__lastGlyphOrTextPrefab;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphOrTextPrefab_Public_Virtual_New_get_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphOrTextPrefab_Public_Virtual_New_set_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_allowedTypes_Public_Virtual_New_get_AllowedTypes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_allowedTypes_Public_Virtual_New_set_Void_AllowedTypes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_entries_Protected_get_List_1_GlyphOrTextObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RequireRebuild_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearObjects_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_Transform_List_1_GlyphOrTextObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ActionElementMap_Transform_List_1_GlyphOrTextObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ControllerElementIdentifier_AxisRange_Transform_List_1_GlyphOrTextObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ControllerElementIdentifier_AxisRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Protected_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphOrTextPrefabOrDefault_Protected_Virtual_New_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultGlyphOrTextPrefab_Protected_Abstract_Virtual_New_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateObjectsAsNeeded_Protected_Virtual_New_Boolean_Transform_List_1_GlyphOrTextObject_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAllowed_Protected_Virtual_New_Boolean_AllowedTypes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGlyphs_Protected_Static_Int32_ActionElementMap_List_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static ControllerElementGlyphBase()
  {
    Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (ControllerElementGlyphBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr);
    ControllerElementGlyphBase.NativeFieldInfoPtr__glyphOrTextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, nameof (_glyphOrTextPrefab));
    ControllerElementGlyphBase.NativeFieldInfoPtr__allowedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, nameof (_allowedTypes));
    ControllerElementGlyphBase.NativeFieldInfoPtr__entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, nameof (_entries));
    ControllerElementGlyphBase.NativeFieldInfoPtr__tempGlyphs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, nameof (_tempGlyphs));
    ControllerElementGlyphBase.NativeFieldInfoPtr__lastGlyphOrTextPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, nameof (_lastGlyphOrTextPrefab));
    ControllerElementGlyphBase.NativeMethodInfoPtr_get_glyphOrTextPrefab_Public_Virtual_New_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668501);
    ControllerElementGlyphBase.NativeMethodInfoPtr_set_glyphOrTextPrefab_Public_Virtual_New_set_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668502);
    ControllerElementGlyphBase.NativeMethodInfoPtr_get_allowedTypes_Public_Virtual_New_get_AllowedTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668503);
    ControllerElementGlyphBase.NativeMethodInfoPtr_set_allowedTypes_Public_Virtual_New_set_Void_AllowedTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668504);
    ControllerElementGlyphBase.NativeMethodInfoPtr_get_entries_Protected_get_List_1_GlyphOrTextObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668505);
    ControllerElementGlyphBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668506);
    ControllerElementGlyphBase.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668507);
    ControllerElementGlyphBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668508);
    ControllerElementGlyphBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668509);
    ControllerElementGlyphBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668510);
    ControllerElementGlyphBase.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668511);
    ControllerElementGlyphBase.NativeMethodInfoPtr_RequireRebuild_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668512);
    ControllerElementGlyphBase.NativeMethodInfoPtr_ClearObjects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668513);
    ControllerElementGlyphBase.NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668514);
    ControllerElementGlyphBase.NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668515);
    ControllerElementGlyphBase.NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_Transform_List_1_GlyphOrTextObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668516);
    ControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ActionElementMap_Transform_List_1_GlyphOrTextObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668517);
    ControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668518);
    ControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ControllerElementIdentifier_AxisRange_Transform_List_1_GlyphOrTextObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668519);
    ControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ControllerElementIdentifier_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668520);
    ControllerElementGlyphBase.NativeMethodInfoPtr_Hide_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668521);
    ControllerElementGlyphBase.NativeMethodInfoPtr_GetGlyphOrTextPrefabOrDefault_Protected_Virtual_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668522);
    ControllerElementGlyphBase.NativeMethodInfoPtr_GetDefaultGlyphOrTextPrefab_Protected_Abstract_Virtual_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668523);
    ControllerElementGlyphBase.NativeMethodInfoPtr_CreateObjectsAsNeeded_Protected_Virtual_New_Boolean_Transform_List_1_GlyphOrTextObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668524);
    ControllerElementGlyphBase.NativeMethodInfoPtr_IsAllowed_Protected_Virtual_New_Boolean_AllowedTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668525);
    ControllerElementGlyphBase.NativeMethodInfoPtr_GetGlyphs_Protected_Static_Int32_ActionElementMap_List_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668526);
    ControllerElementGlyphBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, 100668527);
  }

  public virtual unsafe GameObject glyphOrTextPrefab
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_get_glyphOrTextPrefab_Public_Virtual_New_get_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_set_glyphOrTextPrefab_Public_Virtual_New_set_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ControllerElementGlyphBase.AllowedTypes allowedTypes
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_get_allowedTypes_Public_Virtual_New_get_AllowedTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ControllerElementGlyphBase.AllowedTypes*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_set_allowedTypes_Public_Virtual_New_set_Void_AllowedTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<ControllerElementGlyphBase.GlyphOrTextObject> entries
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphBase.NativeMethodInfoPtr_get_entries_Protected_get_List_1_GlyphOrTextObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ControllerElementGlyphBase.GlyphOrTextObject>) null : Il2CppObjectPool.Get<List<ControllerElementGlyphBase.GlyphOrTextObject>>(num3);
    }
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 68979, RefRangeEnd = 68981, XrefRangeStart = 68968, XrefRangeEnd = 68979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 68981, RefRangeEnd = 68982, XrefRangeStart = 68981, XrefRangeEnd = 68981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void RequireRebuild()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_RequireRebuild_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68982, XrefRangeEnd = 68992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ClearObjects()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_ClearObjects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68992, XrefRangeEnd = 68999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EvaluateObjectVisibility()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void EvaluateObjectVisibility(Transform transform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68999, XrefRangeEnd = 69013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EvaluateObjectVisibility(
    Transform transform,
    List<ControllerElementGlyphBase.GlyphOrTextObject> entries)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_New_Void_Transform_List_1_GlyphOrTextObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69013, XrefRangeEnd = 69026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int ShowGlyphsOrText(
    ActionElementMap actionElementMap,
    Transform parent,
    List<ControllerElementGlyphBase.GlyphOrTextObject> entries)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ActionElementMap_Transform_List_1_GlyphOrTextObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69026, XrefRangeEnd = 69027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int ShowGlyphsOrText(ActionElementMap actionElementMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMap)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69027, XrefRangeEnd = 69036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int ShowGlyphsOrText(
    ControllerElementIdentifier elementIdentifier,
    AxisRange axisRange,
    Transform parent,
    List<ControllerElementGlyphBase.GlyphOrTextObject> entries)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elementIdentifier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axisRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ControllerElementIdentifier_AxisRange_Transform_List_1_GlyphOrTextObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69036, XrefRangeEnd = 69037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int ShowGlyphsOrText(
    ControllerElementIdentifier elementIdentifier,
    AxisRange axisRange)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elementIdentifier);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &axisRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_ControllerElementIdentifier_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69037, XrefRangeEnd = 69044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_Hide_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69044, XrefRangeEnd = 69048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe GameObject GetGlyphOrTextPrefabOrDefault()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_GetGlyphOrTextPrefabOrDefault_Protected_Virtual_New_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe GameObject GetDefaultGlyphOrTextPrefab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_GetDefaultGlyphOrTextPrefab_Protected_Abstract_Virtual_New_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69048, XrefRangeEnd = 69097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool CreateObjectsAsNeeded(
    Transform parent,
    List<ControllerElementGlyphBase.GlyphOrTextObject> entries,
    int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_CreateObjectsAsNeeded_Protected_Virtual_New_Boolean_Transform_List_1_GlyphOrTextObject_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool IsAllowed(
    ControllerElementGlyphBase.AllowedTypes allowedType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &allowedType
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.NativeMethodInfoPtr_IsAllowed_Protected_Virtual_New_Boolean_AllowedTypes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69097, XrefRangeEnd = 69100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetGlyphs(ActionElementMap actionElementMap, List<Il2CppSystem.Object> results)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMap);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) results);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphBase.NativeMethodInfoPtr_GetGlyphs_Protected_Static_Int32_ActionElementMap_List_1_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 69113, RefRangeEnd = 69118, XrefRangeStart = 69100, XrefRangeEnd = 69113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerElementGlyphBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject _glyphOrTextPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__glyphOrTextPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__glyphOrTextPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ControllerElementGlyphBase.AllowedTypes _allowedTypes
  {
    get
    {
      return *(ControllerElementGlyphBase.AllowedTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__allowedTypes));
    }
    [param: In] set
    {
      *(ControllerElementGlyphBase.AllowedTypes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__allowedTypes)) = value;
    }
  }

  public unsafe List<ControllerElementGlyphBase.GlyphOrTextObject> _entries
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__entries));
      return num == System.IntPtr.Zero ? (List<ControllerElementGlyphBase.GlyphOrTextObject>) null : Il2CppObjectPool.Get<List<ControllerElementGlyphBase.GlyphOrTextObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__entries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Il2CppSystem.Object> _tempGlyphs
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__tempGlyphs));
      return num == System.IntPtr.Zero ? (List<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<List<Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__tempGlyphs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject _lastGlyphOrTextPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__lastGlyphOrTextPrefab));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.NativeFieldInfoPtr__lastGlyphOrTextPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class GlyphOrTextObject(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__glyphOrText;
    private static readonly System.IntPtr NativeFieldInfoPtr__frame;
    private static readonly System.IntPtr NativeFieldInfoPtr__isVisible;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_isVisible_Public_Virtual_New_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_isVisible_Protected_Virtual_New_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_glyphOrText_Public_get_GlyphOrTextBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_glyphOrText_Public_set_Void_GlyphOrTextBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GlyphOrTextBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowGlyph_Public_Virtual_New_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShowText_Public_Virtual_New_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HideIfIdle_Public_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

    static GlyphOrTextObject()
    {
      Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ControllerElementGlyphBase>.NativeClassPtr, nameof (GlyphOrTextObject));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__glyphOrText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, nameof (_glyphOrText));
      ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, nameof (_frame));
      ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, nameof (_isVisible));
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_get_isVisible_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668528);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_set_isVisible_Protected_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668529);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_get_glyphOrText_Public_get_GlyphOrTextBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668530);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_set_glyphOrText_Public_set_Void_GlyphOrTextBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668531);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr__ctor_Public_Void_GlyphOrTextBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668532);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_ShowGlyph_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668533);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_ShowText_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668534);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668535);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_HideIfIdle_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668536);
      ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr, 100668537);
    }

    public virtual unsafe bool isVisible
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_get_isVisible_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_set_isVisible_Protected_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe GlyphOrTextBase glyphOrText
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_get_glyphOrText_Public_get_GlyphOrTextBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (GlyphOrTextBase) null : Il2CppObjectPool.Get<GlyphOrTextBase>(num3);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_set_glyphOrText_Public_set_Void_GlyphOrTextBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68811, XrefRangeEnd = 68812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GlyphOrTextObject(GlyphOrTextBase glyphOrText)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementGlyphBase.GlyphOrTextObject>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) glyphOrText)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr__ctor_Public_Void_GlyphOrTextBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68937, XrefRangeEnd = 68942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ShowGlyph(Il2CppSystem.Object glyph)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) glyph)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_ShowGlyph_Public_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68942, XrefRangeEnd = 68947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void ShowText(string text)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(text)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_ShowText_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68947, XrefRangeEnd = 68951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Hide()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_Hide_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68951, XrefRangeEnd = 68952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void HideIfIdle()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_HideIfIdle_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68952, XrefRangeEnd = 68960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Destroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphBase.GlyphOrTextObject.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GlyphOrTextBase _glyphOrText
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__glyphOrText));
        return num == System.IntPtr.Zero ? (GlyphOrTextBase) null : Il2CppObjectPool.Get<GlyphOrTextBase>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__glyphOrText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _frame
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__frame));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__frame)) = value;
      }
    }

    public unsafe bool _isVisible
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__isVisible));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphBase.GlyphOrTextObject.NativeFieldInfoPtr__isVisible)) = value;
      }
    }
  }

  public enum AllowedTypes
  {
    All,
    Glyphs,
    Text,
  }
}
