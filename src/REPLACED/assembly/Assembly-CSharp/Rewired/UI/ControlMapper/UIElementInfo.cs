// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.UIElementInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class UIElementInfo(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_identifier;
  private static readonly System.IntPtr NativeFieldInfoPtr_intData;
  private static readonly System.IntPtr NativeFieldInfoPtr_text;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnSelectedEvent;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_OnSelectedEvent_Public_add_Void_Action_1_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnSelectedEvent_Public_rem_Void_Action_1_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static UIElementInfo()
  {
    Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (UIElementInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr);
    UIElementInfo.NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, nameof (identifier));
    UIElementInfo.NativeFieldInfoPtr_intData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, nameof (intData));
    UIElementInfo.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, nameof (text));
    UIElementInfo.NativeFieldInfoPtr_OnSelectedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, nameof (OnSelectedEvent));
    UIElementInfo.NativeMethodInfoPtr_add_OnSelectedEvent_Public_add_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, 100670057);
    UIElementInfo.NativeMethodInfoPtr_remove_OnSelectedEvent_Public_rem_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, 100670058);
    UIElementInfo.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, 100670059);
    UIElementInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr, 100670060);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 80026, RefRangeEnd = 80034, XrefRangeStart = 80021, XrefRangeEnd = 80026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_OnSelectedEvent(Il2CppSystem.Action<GameObject> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIElementInfo.NativeMethodInfoPtr_add_OnSelectedEvent_Public_add_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80034, XrefRangeEnd = 80039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_OnSelectedEvent(Il2CppSystem.Action<GameObject> value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIElementInfo.NativeMethodInfoPtr_remove_OnSelectedEvent_Public_rem_Void_Action_1_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80039, XrefRangeEnd = 80040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIElementInfo.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIElementInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIElementInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIElementInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string identifier
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_identifier)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_identifier), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int intData
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_intData));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_intData)) = value;
    }
  }

  public unsafe TMP_Text text
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_text));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<GameObject> OnSelectedEvent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_OnSelectedEvent));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<GameObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIElementInfo.NativeFieldInfoPtr_OnSelectedEvent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
