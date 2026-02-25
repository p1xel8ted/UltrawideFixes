// Decompiled with JetBrains decompiler
// Type: ArticyDebugFlowPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class ArticyDebugFlowPlayer(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_branchPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_displayNameLabel;
  private static readonly IntPtr NativeFieldInfoPtr_textLabel;
  private static readonly IntPtr NativeFieldInfoPtr_typeLabel;
  private static readonly IntPtr NativeFieldInfoPtr_technicalNameLabel;
  private static readonly IntPtr NativeFieldInfoPtr_idLabel;
  private static readonly IntPtr NativeFieldInfoPtr_branchLayoutPanel;
  private static readonly IntPtr NativeFieldInfoPtr_previewImagePanel;
  private static readonly IntPtr NativeFieldInfoPtr_showFalseBranches;
  private static readonly IntPtr NativeFieldInfoPtr_flowPlayer;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearAllBranches_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ExtractCurrentPausePreviewImage_Private_Void_IFlowObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyTargetLabel_Public_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyDebugFlowPlayer()
  {
    Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ArticyDebugFlowPlayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr);
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_branchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (branchPrefab));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_displayNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (displayNameLabel));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_textLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (textLabel));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_typeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (typeLabel));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_technicalNameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (technicalNameLabel));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_idLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (idLabel));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_branchLayoutPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (branchLayoutPanel));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_previewImagePanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (previewImagePanel));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_showFalseBranches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (showFalseBranches));
    ArticyDebugFlowPlayer.NativeFieldInfoPtr_flowPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, nameof (flowPlayer));
    ArticyDebugFlowPlayer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, 100663302 /*0x06000006*/);
    ArticyDebugFlowPlayer.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, 100663303 /*0x06000007*/);
    ArticyDebugFlowPlayer.NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, 100663304 /*0x06000008*/);
    ArticyDebugFlowPlayer.NativeMethodInfoPtr_ClearAllBranches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, 100663305 /*0x06000009*/);
    ArticyDebugFlowPlayer.NativeMethodInfoPtr_ExtractCurrentPausePreviewImage_Private_Void_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, 100663306 /*0x0600000A*/);
    ArticyDebugFlowPlayer.NativeMethodInfoPtr_CopyTargetLabel_Public_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, 100663307 /*0x0600000B*/);
    ArticyDebugFlowPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr, 100663308 /*0x0600000C*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 580, XrefRangeEnd = 591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugFlowPlayer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 591, XrefRangeEnd = 637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnFlowPlayerPaused(IFlowObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugFlowPlayer.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 637, XrefRangeEnd = 673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBranchesUpdated(IList<Branch> aBranches)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranches)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugFlowPlayer.NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 696, RefRangeEnd = 698, XrefRangeStart = 673, XrefRangeEnd = 696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearAllBranches()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugFlowPlayer.NativeMethodInfoPtr_ClearAllBranches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 719, RefRangeEnd = 720, XrefRangeStart = 698, XrefRangeEnd = 719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExtractCurrentPausePreviewImage(IFlowObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugFlowPlayer.NativeMethodInfoPtr_ExtractCurrentPausePreviewImage_Private_Void_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720, XrefRangeEnd = 746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CopyTargetLabel(BaseEventData aData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugFlowPlayer.NativeMethodInfoPtr_CopyTargetLabel_Public_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyDebugFlowPlayer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDebugFlowPlayer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugFlowPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GameObject branchPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_branchPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_branchPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text displayNameLabel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_displayNameLabel));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_displayNameLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text textLabel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_textLabel));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_textLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text typeLabel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_typeLabel));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_typeLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text technicalNameLabel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_technicalNameLabel));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_technicalNameLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Text idLabel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_idLabel));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_idLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform branchLayoutPanel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_branchLayoutPanel));
      return num == IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_branchLayoutPanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image previewImagePanel
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_previewImagePanel));
      return num == IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_previewImagePanel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool showFalseBranches
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_showFalseBranches));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_showFalseBranches)) = value;
    }
  }

  public unsafe ArticyFlowPlayer flowPlayer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_flowPlayer));
      return num == IntPtr.Zero ? (ArticyFlowPlayer) null : Il2CppObjectPool.Get<ArticyFlowPlayer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugFlowPlayer.NativeFieldInfoPtr_flowPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
