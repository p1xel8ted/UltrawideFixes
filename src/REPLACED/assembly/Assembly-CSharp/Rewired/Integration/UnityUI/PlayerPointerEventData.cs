// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.PlayerPointerEventData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Rewired.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Integration.UnityUI;

public class PlayerPointerEventData(IntPtr pointer) : PointerEventData(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__playerId_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__inputSourceIndex_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__mouseSource_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__touchSource_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__sourceType_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__buttonIndex_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_playerId_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  static PlayerPointerEventData()
  {
    Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", nameof (PlayerPointerEventData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr);
    PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<playerId>k__BackingField");
    PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<inputSourceIndex>k__BackingField");
    PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<mouseSource>k__BackingField");
    PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<touchSource>k__BackingField");
    PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<sourceType>k__BackingField");
    PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, "<buttonIndex>k__BackingField");
    PlayerPointerEventData.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668300);
    PlayerPointerEventData.NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668301);
    PlayerPointerEventData.NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668302);
    PlayerPointerEventData.NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668303);
    PlayerPointerEventData.NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668304);
    PlayerPointerEventData.NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668305);
    PlayerPointerEventData.NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668306);
    PlayerPointerEventData.NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668307);
    PlayerPointerEventData.NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668308);
    PlayerPointerEventData.NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668309);
    PlayerPointerEventData.NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668310);
    PlayerPointerEventData.NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668311);
    PlayerPointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668312);
    PlayerPointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr, 100668313);
  }

  public unsafe int playerId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_playerId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_playerId_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int inputSourceIndex
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_inputSourceIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_inputSourceIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IMouseInputSource mouseSource
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_mouseSource_Public_get_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (IMouseInputSource) null : Il2CppObjectPool.Get<IMouseInputSource>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_mouseSource_Public_set_Void_IMouseInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ITouchInputSource touchSource
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_touchSource_Public_get_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ITouchInputSource) null : Il2CppObjectPool.Get<ITouchInputSource>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_touchSource_Public_set_Void_ITouchInputSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PointerEventType sourceType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_sourceType_Public_get_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PointerEventType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_sourceType_Public_set_Void_PointerEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int buttonIndex
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_get_buttonIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr_set_buttonIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66848, XrefRangeEnd = 66849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerPointerEventData(EventSystem eventSystem)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPointerEventData>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventSystem)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPointerEventData.NativeMethodInfoPtr__ctor_Public_Void_EventSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66849, XrefRangeEnd = 66886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayerPointerEventData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public unsafe int _playerId_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__playerId_k__BackingField)) = value;
    }
  }

  public unsafe int _inputSourceIndex_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__inputSourceIndex_k__BackingField)) = value;
    }
  }

  public unsafe IMouseInputSource _mouseSource_k__BackingField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField));
      return num == IntPtr.Zero ? (IMouseInputSource) null : Il2CppObjectPool.Get<IMouseInputSource>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__mouseSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ITouchInputSource _touchSource_k__BackingField
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField));
      return num == IntPtr.Zero ? (ITouchInputSource) null : Il2CppObjectPool.Get<ITouchInputSource>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__touchSource_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PointerEventType _sourceType_k__BackingField
  {
    get
    {
      return *(PointerEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField));
    }
    [param: In] set
    {
      *(PointerEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__sourceType_k__BackingField)) = value;
    }
  }

  public unsafe int _buttonIndex_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerPointerEventData.NativeFieldInfoPtr__buttonIndex_k__BackingField)) = value;
    }
  }
}
