// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.DualShock4SpecialFeaturesExample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Rewired.ControllerExtensions;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos;

public class DualShock4SpecialFeaturesExample(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_maxTouches;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_touchpadTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_lightObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_accelerometerTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_touches;
  private static readonly System.IntPtr NativeFieldInfoPtr_unusedTouches;
  private static readonly System.IntPtr NativeFieldInfoPtr_isFlashing;
  private static readonly System.IntPtr NativeFieldInfoPtr_textStyle;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetOrientation_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRandomLightColor_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartLightFlash_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopLightFlash_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFirstDS4_Private_IDualShock4Extension_Player_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeTouchObjects_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleTouchpad_Private_Void_IDualShock4Extension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DualShock4SpecialFeaturesExample()
  {
    Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (DualShock4SpecialFeaturesExample));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr);
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_maxTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (maxTouches));
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (playerId));
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touchpadTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (touchpadTransform));
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_lightObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (lightObject));
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_accelerometerTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (accelerometerTransform));
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (touches));
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_unusedTouches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (unusedTouches));
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_isFlashing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (isFlashing));
    DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_textStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (textStyle));
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670325);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670326);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670327);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670328);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_ResetOrientation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670329);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_SetRandomLightColor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670330);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_StartLightFlash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670331);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_StopLightFlash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670332);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_GetFirstDS4_Private_IDualShock4Extension_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670333);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_InitializeTouchObjects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670334);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_HandleTouchpad_Private_Void_IDualShock4Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670335);
    DualShock4SpecialFeaturesExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, 100670336);
  }

  public unsafe Player player
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82979, XrefRangeEnd = 82985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82985, XrefRangeEnd = 82986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82986, XrefRangeEnd = 83085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83085, XrefRangeEnd = 83198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnGUI()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83198, XrefRangeEnd = 83207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetOrientation()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_ResetOrientation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 83224, RefRangeEnd = 83225, XrefRangeStart = 83207, XrefRangeEnd = 83224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRandomLightColor()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_SetRandomLightColor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83225, XrefRangeEnd = 83234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartLightFlash()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_StartLightFlash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83234, XrefRangeEnd = 83243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopLightFlash()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_StopLightFlash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 83259, RefRangeEnd = 83268, XrefRangeStart = 83243, XrefRangeEnd = 83259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IDualShock4Extension GetFirstDS4(Player player)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_GetFirstDS4_Private_IDualShock4Extension_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IDualShock4Extension) null : Il2CppObjectPool.Get<IDualShock4Extension>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 83299, RefRangeEnd = 83300, XrefRangeStart = 83268, XrefRangeEnd = 83299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitializeTouchObjects()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_InitializeTouchObjects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 83351, RefRangeEnd = 83352, XrefRangeStart = 83300, XrefRangeEnd = 83351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void HandleTouchpad(IDualShock4Extension ds4)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ds4)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr_HandleTouchpad_Private_Void_IDualShock4Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DualShock4SpecialFeaturesExample()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int maxTouches
  {
    get
    {
      int maxTouches;
      IL2CPP.il2cpp_field_static_get_value(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_maxTouches, (void*) &maxTouches);
      return maxTouches;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_maxTouches, (void*) &value);
    }
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public unsafe Transform touchpadTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touchpadTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touchpadTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject lightObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_lightObject));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_lightObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform accelerometerTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_accelerometerTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_accelerometerTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<DualShock4SpecialFeaturesExample.Touch> touches
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touches));
      return num == System.IntPtr.Zero ? (List<DualShock4SpecialFeaturesExample.Touch>) null : Il2CppObjectPool.Get<List<DualShock4SpecialFeaturesExample.Touch>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_touches), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Queue<DualShock4SpecialFeaturesExample.Touch> unusedTouches
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_unusedTouches));
      return num == System.IntPtr.Zero ? (Queue<DualShock4SpecialFeaturesExample.Touch>) null : Il2CppObjectPool.Get<Queue<DualShock4SpecialFeaturesExample.Touch>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_unusedTouches), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isFlashing
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_isFlashing));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_isFlashing)) = value;
    }
  }

  public unsafe GUIStyle textStyle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_textStyle));
      return num == System.IntPtr.Zero ? (GUIStyle) null : Il2CppObjectPool.Get<GUIStyle>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.NativeFieldInfoPtr_textStyle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class Touch(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_go;
    private static readonly System.IntPtr NativeFieldInfoPtr_touchId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static Touch()
    {
      Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, nameof (Touch));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr);
      DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr, nameof (go));
      DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_touchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr, nameof (touchId));
      DualShock4SpecialFeaturesExample.Touch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr, 100670337);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82978, XrefRangeEnd = 82979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Touch()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.Touch>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.Touch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GameObject go
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_go));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int touchId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_touchId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.Touch.NativeFieldInfoPtr_touchId)) = value;
      }
    }
  }

  [ObfuscatedName("Rewired.Demos.DualShock4SpecialFeaturesExample+<>c__DisplayClass20_0")]
  public sealed class __c__DisplayClass20_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_touchId;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__HandleTouchpad_b__0_Internal_Boolean_Touch_0;

    static __c__DisplayClass20_0()
    {
      Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample>.NativeClassPtr, "<>c__DisplayClass20_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr);
      DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeFieldInfoPtr_touchId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr, nameof (touchId));
      DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr, 100670338);
      DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeMethodInfoPtr__HandleTouchpad_b__0_Internal_Boolean_Touch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr, 100670339);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass20_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DualShock4SpecialFeaturesExample.__c__DisplayClass20_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _HandleTouchpad_b__0(DualShock4SpecialFeaturesExample.Touch x)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeMethodInfoPtr__HandleTouchpad_b__0_Internal_Boolean_Touch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe int touchId
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeFieldInfoPtr_touchId));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DualShock4SpecialFeaturesExample.__c__DisplayClass20_0.NativeFieldInfoPtr_touchId)) = value;
      }
    }
  }
}
