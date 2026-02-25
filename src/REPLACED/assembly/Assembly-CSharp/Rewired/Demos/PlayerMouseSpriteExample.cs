// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.PlayerMouseSpriteExample
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos;

public class PlayerMouseSpriteExample(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerId;
  private static readonly IntPtr NativeFieldInfoPtr_horizontalAction;
  private static readonly IntPtr NativeFieldInfoPtr_verticalAction;
  private static readonly IntPtr NativeFieldInfoPtr_wheelAction;
  private static readonly IntPtr NativeFieldInfoPtr_leftButtonAction;
  private static readonly IntPtr NativeFieldInfoPtr_rightButtonAction;
  private static readonly IntPtr NativeFieldInfoPtr_middleButtonAction;
  private static readonly IntPtr NativeFieldInfoPtr_distanceFromCamera;
  private static readonly IntPtr NativeFieldInfoPtr_spriteScale;
  private static readonly IntPtr NativeFieldInfoPtr_pointerPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_clickEffectPrefab;
  private static readonly IntPtr NativeFieldInfoPtr_hideHardwarePointer;
  private static readonly IntPtr NativeFieldInfoPtr_pointer;
  private static readonly IntPtr NativeFieldInfoPtr_mouse;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateClickEffect_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnScreenPositionChanged_Private_Void_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerMouseSpriteExample()
  {
    Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (PlayerMouseSpriteExample));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr);
    PlayerMouseSpriteExample.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (playerId));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_horizontalAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (horizontalAction));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_verticalAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (verticalAction));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_wheelAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (wheelAction));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_leftButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (leftButtonAction));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_rightButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (rightButtonAction));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_middleButtonAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (middleButtonAction));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_distanceFromCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (distanceFromCamera));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_spriteScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (spriteScale));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_pointerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (pointerPrefab));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_clickEffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (clickEffectPrefab));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_hideHardwarePointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (hideHardwarePointer));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (pointer));
    PlayerMouseSpriteExample.NativeFieldInfoPtr_mouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, nameof (mouse));
    PlayerMouseSpriteExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100670355);
    PlayerMouseSpriteExample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100670356);
    PlayerMouseSpriteExample.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100670357);
    PlayerMouseSpriteExample.NativeMethodInfoPtr_CreateClickEffect_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100670358);
    PlayerMouseSpriteExample.NativeMethodInfoPtr_OnScreenPositionChanged_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100670359);
    PlayerMouseSpriteExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr, 100670360);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83524, XrefRangeEnd = 83567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83567, XrefRangeEnd = 83589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83589, XrefRangeEnd = 83603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 83623, RefRangeEnd = 83626, XrefRangeStart = 83603, XrefRangeEnd = 83623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CreateClickEffect(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_CreateClickEffect_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83626, XrefRangeEnd = 83630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnScreenPositionChanged(Vector2 position)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &position
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr_OnScreenPositionChanged_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83630, XrefRangeEnd = 83643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerMouseSpriteExample()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerMouseSpriteExample>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerMouseSpriteExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public unsafe string horizontalAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_horizontalAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_horizontalAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string verticalAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_verticalAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_verticalAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string wheelAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_wheelAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_wheelAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string leftButtonAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_leftButtonAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_leftButtonAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string rightButtonAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_rightButtonAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_rightButtonAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string middleButtonAction
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_middleButtonAction)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_middleButtonAction), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float distanceFromCamera
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_distanceFromCamera));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_distanceFromCamera)) = value;
    }
  }

  public unsafe float spriteScale
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_spriteScale));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_spriteScale)) = value;
    }
  }

  public unsafe GameObject pointerPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_pointerPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_pointerPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject clickEffectPrefab
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_clickEffectPrefab));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_clickEffectPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hideHardwarePointer
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_hideHardwarePointer));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_hideHardwarePointer)) = value;
    }
  }

  public unsafe GameObject pointer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_pointer));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_pointer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayerMouse mouse
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_mouse));
      return num == IntPtr.Zero ? (PlayerMouse) null : Il2CppObjectPool.Get<PlayerMouse>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerMouseSpriteExample.NativeFieldInfoPtr_mouse), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
