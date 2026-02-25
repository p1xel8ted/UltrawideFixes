// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineTriggerAction
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Cinemachine;

public class CinemachineTriggerAction(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WithTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WithoutTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SkipFirst;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Repeating;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OnObjectEnter;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OnObjectExit;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveTriggerObjects;
  private static readonly System.IntPtr NativeMethodInfoPtr_Filter_Private_Boolean_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalDoTriggerEnter_Private_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalDoTriggerExit_Private_Void_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCollisionExit2D_Private_Void_Collision2D_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineTriggerAction()
  {
    Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineTriggerAction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr);
    CinemachineTriggerAction.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (m_LayerMask));
    CinemachineTriggerAction.NativeFieldInfoPtr_m_WithTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (m_WithTag));
    CinemachineTriggerAction.NativeFieldInfoPtr_m_WithoutTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (m_WithoutTag));
    CinemachineTriggerAction.NativeFieldInfoPtr_m_SkipFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (m_SkipFirst));
    CinemachineTriggerAction.NativeFieldInfoPtr_m_Repeating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (m_Repeating));
    CinemachineTriggerAction.NativeFieldInfoPtr_m_OnObjectEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (m_OnObjectEnter));
    CinemachineTriggerAction.NativeFieldInfoPtr_m_OnObjectExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (m_OnObjectExit));
    CinemachineTriggerAction.NativeFieldInfoPtr_m_ActiveTriggerObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (m_ActiveTriggerObjects));
    CinemachineTriggerAction.NativeMethodInfoPtr_Filter_Private_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664214);
    CinemachineTriggerAction.NativeMethodInfoPtr_InternalDoTriggerEnter_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664215);
    CinemachineTriggerAction.NativeMethodInfoPtr_InternalDoTriggerExit_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664216);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664217);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664218);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664219);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664220);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664221);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664222);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664223);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnCollisionExit2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664224 /*0x060003A0*/);
    CinemachineTriggerAction.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664225);
    CinemachineTriggerAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, 100664226);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945195, XrefRangeEnd = 945200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Filter(GameObject other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_Filter_Private_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 945209, RefRangeEnd = 945213, XrefRangeStart = 945200, XrefRangeEnd = 945209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalDoTriggerEnter(GameObject other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_InternalDoTriggerEnter_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 945221, RefRangeEnd = 945225, XrefRangeStart = 945213, XrefRangeEnd = 945221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalDoTriggerExit(GameObject other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_InternalDoTriggerExit_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945225, XrefRangeEnd = 945228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945228, XrefRangeEnd = 945231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerExit(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnTriggerExit_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945231, XrefRangeEnd = 945234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945234, XrefRangeEnd = 945237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionExit(Collision other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnCollisionExit_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter2D(Collider2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerExit2D(Collider2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnTriggerExit2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945237, XrefRangeEnd = 945240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945240, XrefRangeEnd = 945243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionExit2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnCollisionExit2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945243, XrefRangeEnd = 945261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineTriggerAction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerMask m_LayerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_LayerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_LayerMask)) = value;
    }
  }

  public unsafe string m_WithTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_WithTag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_WithTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string m_WithoutTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_WithoutTag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_WithoutTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int m_SkipFirst
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_SkipFirst));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_SkipFirst)) = value;
    }
  }

  public unsafe bool m_Repeating
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_Repeating));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_Repeating)) = value;
    }
  }

  public CinemachineTriggerAction.ActionSettings m_OnObjectEnter
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_OnObjectEnter);
      return new CinemachineTriggerAction.ActionSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_OnObjectEnter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public CinemachineTriggerAction.ActionSettings m_OnObjectExit
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_OnObjectExit);
      return new CinemachineTriggerAction.ActionSettings(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_OnObjectExit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe HashSet<GameObject> m_ActiveTriggerObjects
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_ActiveTriggerObjects));
      return num == System.IntPtr.Zero ? (HashSet<GameObject>) null : Il2CppObjectPool.Get<HashSet<GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.NativeFieldInfoPtr_m_ActiveTriggerObjects), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class ActionSettings : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Action;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Target;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_BoostAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Mode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Event;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Mode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

    static ActionSettings()
    {
      Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineTriggerAction>.NativeClassPtr, nameof (ActionSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr);
      CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, nameof (m_Action));
      CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, nameof (m_Target));
      CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_BoostAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, nameof (m_BoostAmount));
      CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, nameof (m_StartTime));
      CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, nameof (m_Mode));
      CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, nameof (m_Event));
      CinemachineTriggerAction.ActionSettings.NativeMethodInfoPtr__ctor_Public_Void_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, 100664227);
      CinemachineTriggerAction.ActionSettings.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, 100664228);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945106, XrefRangeEnd = 945110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ActionSettings(
      CinemachineTriggerAction.ActionSettings.Mode action)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &action
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.ActionSettings.NativeMethodInfoPtr__ctor_Public_Void_Mode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 945193, RefRangeEnd = 945195, XrefRangeStart = 945110, XrefRangeEnd = 945193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.ActionSettings.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public ActionSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ActionSettings()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr))
    {
    }

    public unsafe CinemachineTriggerAction.ActionSettings.Mode m_Action
    {
      get
      {
        return *(CinemachineTriggerAction.ActionSettings.Mode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Action));
      }
      [param: In] set
      {
        *(CinemachineTriggerAction.ActionSettings.Mode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Action)) = value;
      }
    }

    public unsafe UnityEngine.Object m_Target
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Target));
        return num == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int m_BoostAmount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_BoostAmount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_BoostAmount)) = value;
      }
    }

    public unsafe float m_StartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_StartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_StartTime)) = value;
      }
    }

    public unsafe CinemachineTriggerAction.ActionSettings.TimeMode m_Mode
    {
      get
      {
        return *(CinemachineTriggerAction.ActionSettings.TimeMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Mode));
      }
      [param: In] set
      {
        *(CinemachineTriggerAction.ActionSettings.TimeMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Mode)) = value;
      }
    }

    public unsafe CinemachineTriggerAction.ActionSettings.TriggerEvent m_Event
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Event));
        return num == System.IntPtr.Zero ? (CinemachineTriggerAction.ActionSettings.TriggerEvent) null : Il2CppObjectPool.Get<CinemachineTriggerAction.ActionSettings.TriggerEvent>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineTriggerAction.ActionSettings.NativeFieldInfoPtr_m_Event), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum Mode
    {
      Custom,
      PriorityBoost,
      Activate,
      Deactivate,
      Enable,
      Disable,
      Play,
      Stop,
    }

    [Serializable]
    public class TriggerEvent(System.IntPtr pointer) : UnityEvent(pointer)
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      static TriggerEvent()
      {
        Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings.TriggerEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings>.NativeClassPtr, nameof (TriggerEvent));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings.TriggerEvent>.NativeClassPtr);
        CinemachineTriggerAction.ActionSettings.TriggerEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings.TriggerEvent>.NativeClassPtr, 100664229);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 226779, RefRangeEnd = 226782, XrefRangeStart = 226779, XrefRangeEnd = 226782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe TriggerEvent()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineTriggerAction.ActionSettings.TriggerEvent>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(CinemachineTriggerAction.ActionSettings.TriggerEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public enum TimeMode
    {
      FromStart,
      FromEnd,
      BeforeNow,
      AfterNow,
    }
  }
}
