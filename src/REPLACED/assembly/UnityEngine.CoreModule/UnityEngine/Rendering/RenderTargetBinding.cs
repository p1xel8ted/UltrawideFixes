// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderTargetBinding
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class RenderTargetBinding : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorRenderTargets;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthRenderTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorLoadActions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorStoreActions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthLoadAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthStoreAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_colorRenderTargets_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_colorRenderTargets_Public_set_Void_Il2CppStructArray_1_RenderTargetIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_depthRenderTarget_Public_get_RenderTargetIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_depthRenderTarget_Public_set_Void_RenderTargetIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_colorLoadActions_Public_get_Il2CppStructArray_1_RenderBufferLoadAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_colorLoadActions_Public_set_Void_Il2CppStructArray_1_RenderBufferLoadAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_colorStoreActions_Public_set_Void_Il2CppStructArray_1_RenderBufferStoreAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_depthLoadAction_Public_get_RenderBufferLoadAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_depthLoadAction_Public_set_Void_RenderBufferLoadAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_depthStoreAction_Public_set_Void_RenderBufferStoreAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_flags_Public_get_RenderTargetFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_flags_Public_set_Void_RenderTargetFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0;

  static RenderTargetBinding()
  {
    Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderTargetBinding));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr);
    RenderTargetBinding.NativeFieldInfoPtr_m_ColorRenderTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, nameof (m_ColorRenderTargets));
    RenderTargetBinding.NativeFieldInfoPtr_m_DepthRenderTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, nameof (m_DepthRenderTarget));
    RenderTargetBinding.NativeFieldInfoPtr_m_ColorLoadActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, nameof (m_ColorLoadActions));
    RenderTargetBinding.NativeFieldInfoPtr_m_ColorStoreActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, nameof (m_ColorStoreActions));
    RenderTargetBinding.NativeFieldInfoPtr_m_DepthLoadAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, nameof (m_DepthLoadAction));
    RenderTargetBinding.NativeFieldInfoPtr_m_DepthStoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, nameof (m_DepthStoreAction));
    RenderTargetBinding.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, nameof (m_Flags));
    RenderTargetBinding.NativeMethodInfoPtr_get_colorRenderTargets_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669663);
    RenderTargetBinding.NativeMethodInfoPtr_set_colorRenderTargets_Public_set_Void_Il2CppStructArray_1_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669664);
    RenderTargetBinding.NativeMethodInfoPtr_get_depthRenderTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669665);
    RenderTargetBinding.NativeMethodInfoPtr_set_depthRenderTarget_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669666);
    RenderTargetBinding.NativeMethodInfoPtr_get_colorLoadActions_Public_get_Il2CppStructArray_1_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669667);
    RenderTargetBinding.NativeMethodInfoPtr_set_colorLoadActions_Public_set_Void_Il2CppStructArray_1_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669668);
    RenderTargetBinding.NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669669);
    RenderTargetBinding.NativeMethodInfoPtr_set_colorStoreActions_Public_set_Void_Il2CppStructArray_1_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669670);
    RenderTargetBinding.NativeMethodInfoPtr_get_depthLoadAction_Public_get_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669671);
    RenderTargetBinding.NativeMethodInfoPtr_set_depthLoadAction_Public_set_Void_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669672);
    RenderTargetBinding.NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669673);
    RenderTargetBinding.NativeMethodInfoPtr_set_depthStoreAction_Public_set_Void_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669674);
    RenderTargetBinding.NativeMethodInfoPtr_get_flags_Public_get_RenderTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669675);
    RenderTargetBinding.NativeMethodInfoPtr_set_flags_Public_set_Void_RenderTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669676);
    RenderTargetBinding.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669677);
    RenderTargetBinding.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr, 100669678);
  }

  public unsafe Il2CppStructArray<RenderTargetIdentifier> colorRenderTargets
  {
    [CallerCount(192 /*0xC0*/), CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_get_colorRenderTargets_Public_get_Il2CppStructArray_1_RenderTargetIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<RenderTargetIdentifier>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(num3);
    }
    [CallerCount(65), CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_set_colorRenderTargets_Public_set_Void_Il2CppStructArray_1_RenderTargetIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe RenderTargetIdentifier depthRenderTarget
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 482297, RefRangeEnd = 482298, XrefRangeStart = 482297, XrefRangeEnd = 482297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_get_depthRenderTarget_Public_get_RenderTargetIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTargetIdentifier*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 482298, RefRangeEnd = 482299, XrefRangeStart = 482298, XrefRangeEnd = 482298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_set_depthRenderTarget_Public_set_Void_RenderTargetIdentifier_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<RenderBufferLoadAction> colorLoadActions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 473252, RefRangeEnd = 473253, XrefRangeStart = 473252, XrefRangeEnd = 473253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_get_colorLoadActions_Public_get_Il2CppStructArray_1_RenderBufferLoadAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<RenderBufferLoadAction>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferLoadAction>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_set_colorLoadActions_Public_set_Void_Il2CppStructArray_1_RenderBufferLoadAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<RenderBufferStoreAction> colorStoreActions
  {
    [CallerCount(45), CachedScanResults(RefRangeStart = 266310, RefRangeEnd = 266355, XrefRangeStart = 266310, XrefRangeEnd = 266355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_get_colorStoreActions_Public_get_Il2CppStructArray_1_RenderBufferStoreAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<RenderBufferStoreAction>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_set_colorStoreActions_Public_set_Void_Il2CppStructArray_1_RenderBufferStoreAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe RenderBufferLoadAction depthLoadAction
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_get_depthLoadAction_Public_get_RenderBufferLoadAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderBufferLoadAction*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 139338, RefRangeEnd = 139339, XrefRangeStart = 139338, XrefRangeEnd = 139339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_set_depthLoadAction_Public_set_Void_RenderBufferLoadAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe RenderBufferStoreAction depthStoreAction
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_get_depthStoreAction_Public_get_RenderBufferStoreAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderBufferStoreAction*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 394042, RefRangeEnd = 394043, XrefRangeStart = 394042, XrefRangeEnd = 394043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_set_depthStoreAction_Public_set_Void_RenderBufferStoreAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe RenderTargetFlags flags
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 259963, RefRangeEnd = 259964, XrefRangeStart = 259963, XrefRangeEnd = 259964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_get_flags_Public_get_RenderTargetFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderTargetFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 138917, RefRangeEnd = 138918, XrefRangeStart = 138917, XrefRangeEnd = 138918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr_set_flags_Public_set_Void_RenderTargetFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 482299, RefRangeEnd = 482300, XrefRangeStart = 482299, XrefRangeEnd = 482299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTargetBinding(
    Il2CppStructArray<RenderTargetIdentifier> colorRenderTargets,
    Il2CppStructArray<RenderBufferLoadAction> colorLoadActions,
    Il2CppStructArray<RenderBufferStoreAction> colorStoreActions,
    RenderTargetIdentifier depthRenderTarget,
    RenderBufferLoadAction depthLoadAction,
    RenderBufferStoreAction depthStoreAction)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colorRenderTargets);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colorLoadActions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) colorStoreActions);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthRenderTarget;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthLoadAction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthStoreAction;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_RenderTargetIdentifier_Il2CppStructArray_1_RenderBufferLoadAction_Il2CppStructArray_1_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 482309, RefRangeEnd = 482310, XrefRangeStart = 482300, XrefRangeEnd = 482309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTargetBinding(
    RenderTargetIdentifier colorRenderTarget,
    RenderBufferLoadAction colorLoadAction,
    RenderBufferStoreAction colorStoreAction,
    RenderTargetIdentifier depthRenderTarget,
    RenderBufferLoadAction depthLoadAction,
    RenderBufferStoreAction depthStoreAction)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &colorRenderTarget;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &colorLoadAction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &colorStoreAction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthRenderTarget;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &depthLoadAction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &depthStoreAction;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTargetBinding.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_RenderTargetIdentifier_RenderBufferLoadAction_RenderBufferStoreAction_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public RenderTargetBinding(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public RenderTargetBinding()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderTargetBinding>.NativeClassPtr))
  {
  }

  public unsafe Il2CppStructArray<RenderTargetIdentifier> m_ColorRenderTargets
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_ColorRenderTargets));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<RenderTargetIdentifier>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_ColorRenderTargets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderTargetIdentifier m_DepthRenderTarget
  {
    get
    {
      return *(RenderTargetIdentifier*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_DepthRenderTarget));
    }
    [param: In] set
    {
      *(RenderTargetIdentifier*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_DepthRenderTarget)) = value;
    }
  }

  public unsafe Il2CppStructArray<RenderBufferLoadAction> m_ColorLoadActions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_ColorLoadActions));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<RenderBufferLoadAction>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferLoadAction>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_ColorLoadActions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<RenderBufferStoreAction> m_ColorStoreActions
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_ColorStoreActions));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<RenderBufferStoreAction>) null : Il2CppObjectPool.Get<Il2CppStructArray<RenderBufferStoreAction>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_ColorStoreActions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderBufferLoadAction m_DepthLoadAction
  {
    get
    {
      return *(RenderBufferLoadAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_DepthLoadAction));
    }
    [param: In] set
    {
      *(RenderBufferLoadAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_DepthLoadAction)) = value;
    }
  }

  public unsafe RenderBufferStoreAction m_DepthStoreAction
  {
    get
    {
      return *(RenderBufferStoreAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_DepthStoreAction));
    }
    [param: In] set
    {
      *(RenderBufferStoreAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_DepthStoreAction)) = value;
    }
  }

  public unsafe RenderTargetFlags m_Flags
  {
    get
    {
      return *(RenderTargetFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_Flags));
    }
    [param: In] set
    {
      *(RenderTargetFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderTargetBinding.NativeFieldInfoPtr_m_Flags)) = value;
    }
  }
}
