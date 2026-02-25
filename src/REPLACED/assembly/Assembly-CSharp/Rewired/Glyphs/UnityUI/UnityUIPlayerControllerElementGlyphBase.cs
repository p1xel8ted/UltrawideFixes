// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.UnityUI.UnityUIPlayerControllerElementGlyphBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Glyphs.UnityUI;

public class UnityUIPlayerControllerElementGlyphBase(IntPtr pointer) : 
  UnityUIControllerElementGlyphBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__options;
  private static readonly IntPtr NativeFieldInfoPtr__actionRange;
  private static readonly IntPtr NativeFieldInfoPtr__group1;
  private static readonly IntPtr NativeFieldInfoPtr__group2;
  private static readonly IntPtr NativeFieldInfoPtr__tempAems;
  private static readonly IntPtr NativeFieldInfoPtr__tempCombinedElementAems;
  private static readonly IntPtr NativeFieldInfoPtr__group1Objects;
  private static readonly IntPtr NativeFieldInfoPtr__group2Objects;
  private static readonly IntPtr NativeMethodInfoPtr_get_options_Public_Virtual_New_get_ControllerElementGlyphSelectorOptionsSOBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_options_Public_Virtual_New_set_Void_ControllerElementGlyphSelectorOptionsSOBase_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_Abstract_Virtual_New_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionId_Public_Abstract_Virtual_New_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_actionId_Public_Abstract_Virtual_New_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_actionRange_Public_Virtual_New_get_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_actionRange_Public_Virtual_New_set_Void_AxisRange_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_group1_Public_Virtual_New_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_group1_Public_Virtual_New_set_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_group2_Public_Virtual_New_get_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_group2_Public_Virtual_New_set_Void_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_isMousePrioritizedOverKeyboard_Protected_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryGetControllerTypeOrder_Protected_Virtual_New_Boolean_Int32_byref_ControllerType_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearObjects_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowBinding_Protected_Virtual_New_Boolean_ActionElementMap_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowSplitAxisBindings_Protected_Virtual_New_Boolean_ActionElementMap_ActionElementMap_0;
  private static readonly IntPtr NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_IList_1_ActionElementMap_Transform_List_1_GlyphOrTextObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_Hide_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetObjectGroupTransform_Protected_Virtual_New_Transform_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetOptionsOrDefault_Protected_Virtual_New_ControllerElementGlyphSelectorOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static UnityUIPlayerControllerElementGlyphBase()
  {
    Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs.UnityUI", nameof (UnityUIPlayerControllerElementGlyphBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr);
    UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, nameof (_options));
    UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__actionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, nameof (_actionRange));
    UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, nameof (_group1));
    UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, nameof (_group2));
    UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__tempAems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, nameof (_tempAems));
    UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__tempCombinedElementAems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, nameof (_tempCombinedElementAems));
    UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group1Objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, nameof (_group1Objects));
    UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group2Objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, nameof (_group2Objects));
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_options_Public_Virtual_New_get_ControllerElementGlyphSelectorOptionsSOBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668665);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_options_Public_Virtual_New_set_Void_ControllerElementGlyphSelectorOptionsSOBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668666);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668667);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_playerId_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668668);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_actionId_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668669);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_actionId_Public_Abstract_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668670);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_actionRange_Public_Virtual_New_get_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668671);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_actionRange_Public_Virtual_New_set_Void_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668672 /*0x06001500*/);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_group1_Public_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668673);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_group1_Public_Virtual_New_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668674);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_group2_Public_Virtual_New_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668675);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_group2_Public_Virtual_New_set_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668676);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_isMousePrioritizedOverKeyboard_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668677);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_TryGetControllerTypeOrder_Protected_Virtual_New_Boolean_Int32_byref_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668678);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668679);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_ClearObjects_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668680);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_ShowBinding_Protected_Virtual_New_Boolean_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668681);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_ShowSplitAxisBindings_Protected_Virtual_New_Boolean_ActionElementMap_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668682);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668683);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_IList_1_ActionElementMap_Transform_List_1_GlyphOrTextObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668684);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_Hide_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668685);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_GetObjectGroupTransform_Protected_Virtual_New_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668686);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_GetOptionsOrDefault_Protected_Virtual_New_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668687);
    UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr, 100668688);
  }

  public virtual unsafe ControllerElementGlyphSelectorOptionsSOBase options
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_options_Public_Virtual_New_get_ControllerElementGlyphSelectorOptionsSOBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ControllerElementGlyphSelectorOptionsSOBase) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptionsSOBase>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_options_Public_Virtual_New_set_Void_ControllerElementGlyphSelectorOptionsSOBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe int playerId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_playerId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_playerId_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe int actionId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_actionId_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_actionId_Public_Abstract_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe AxisRange actionRange
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 69970, RefRangeEnd = 69973, XrefRangeStart = 69970, XrefRangeEnd = 69970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_actionRange_Public_Virtual_New_get_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AxisRange*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_actionRange_Public_Virtual_New_set_Void_AxisRange_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Transform group1
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_group1_Public_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_group1_Public_Virtual_New_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Transform group2
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_group2_Public_Virtual_New_get_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_set_group2_Public_Virtual_New_set_Void_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool isMousePrioritizedOverKeyboard
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_get_isMousePrioritizedOverKeyboard_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69973, XrefRangeEnd = 69974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool TryGetControllerTypeOrder(int index, out ControllerType controllerType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref controllerType;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_TryGetControllerTypeOrder_Protected_Virtual_New_Boolean_Int32_byref_ControllerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69974, XrefRangeEnd = 69983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69983, XrefRangeEnd = 69996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ClearObjects()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_ClearObjects_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool ShowBinding(ActionElementMap actionElementMap)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMap)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_ShowBinding_Protected_Virtual_New_Boolean_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69996, XrefRangeEnd = 69998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool ShowSplitAxisBindings(
    ActionElementMap negativeAem,
    ActionElementMap positiveAem)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) negativeAem);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positiveAem);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_ShowSplitAxisBindings_Protected_Virtual_New_Boolean_ActionElementMap_ActionElementMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69998, XrefRangeEnd = 70010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void EvaluateObjectVisibility()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_EvaluateObjectVisibility_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70010, XrefRangeEnd = 70019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int ShowGlyphsOrText(
    IList<ActionElementMap> bindings,
    Transform parent,
    List<ControllerElementGlyphBase.GlyphOrTextObject> objects)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bindings);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objects);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_ShowGlyphsOrText_Protected_Virtual_New_Int32_IList_1_ActionElementMap_Transform_List_1_GlyphOrTextObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70019, XrefRangeEnd = 70045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Hide()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_Hide_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70045, XrefRangeEnd = 70049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Transform GetObjectGroupTransform(int groupIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &groupIndex
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_GetObjectGroupTransform_Protected_Virtual_New_Transform_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70049, XrefRangeEnd = 70072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ControllerElementGlyphSelectorOptions GetOptionsOrDefault()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr_GetOptionsOrDefault_Protected_Virtual_New_ControllerElementGlyphSelectorOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70072, XrefRangeEnd = 70093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityUIPlayerControllerElementGlyphBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityUIPlayerControllerElementGlyphBase>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityUIPlayerControllerElementGlyphBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ControllerElementGlyphSelectorOptionsSOBase _options
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__options));
      return num == IntPtr.Zero ? (ControllerElementGlyphSelectorOptionsSOBase) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptionsSOBase>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__options), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AxisRange _actionRange
  {
    get
    {
      return *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__actionRange));
    }
    [param: In] set
    {
      *(AxisRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__actionRange)) = value;
    }
  }

  public unsafe Transform _group1
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group1));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform _group2
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group2));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ActionElementMap> _tempAems
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__tempAems));
      return num == IntPtr.Zero ? (List<ActionElementMap>) null : Il2CppObjectPool.Get<List<ActionElementMap>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__tempAems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ActionElementMap> _tempCombinedElementAems
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__tempCombinedElementAems));
      return num == IntPtr.Zero ? (List<ActionElementMap>) null : Il2CppObjectPool.Get<List<ActionElementMap>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__tempCombinedElementAems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ControllerElementGlyphBase.GlyphOrTextObject> _group1Objects
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group1Objects));
      return num == IntPtr.Zero ? (List<ControllerElementGlyphBase.GlyphOrTextObject>) null : Il2CppObjectPool.Get<List<ControllerElementGlyphBase.GlyphOrTextObject>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group1Objects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ControllerElementGlyphBase.GlyphOrTextObject> _group2Objects
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group2Objects));
      return num == IntPtr.Zero ? (List<ControllerElementGlyphBase.GlyphOrTextObject>) null : Il2CppObjectPool.Get<List<ControllerElementGlyphBase.GlyphOrTextObject>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityUIPlayerControllerElementGlyphBase.NativeFieldInfoPtr__group2Objects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
