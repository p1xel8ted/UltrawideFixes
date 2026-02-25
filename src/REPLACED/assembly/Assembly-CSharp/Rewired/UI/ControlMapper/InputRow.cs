// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.InputRow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class InputRow(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_label;
  private static readonly System.IntPtr NativeFieldInfoPtr__buttons_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_rowIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputFieldActivatedCallback;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_buttons_Public_get_Il2CppReferenceArray_1_ButtonInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_buttons_Private_set_Void_Il2CppReferenceArray_1_ButtonInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Int32_String_Action_2_Int32_ButtonInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InputRow()
  {
    Il2CppClassPointerStore<InputRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (InputRow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputRow>.NativeClassPtr);
    InputRow.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRow>.NativeClassPtr, nameof (label));
    InputRow.NativeFieldInfoPtr__buttons_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRow>.NativeClassPtr, "<buttons>k__BackingField");
    InputRow.NativeFieldInfoPtr_rowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRow>.NativeClassPtr, nameof (rowIndex));
    InputRow.NativeFieldInfoPtr_inputFieldActivatedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputRow>.NativeClassPtr, nameof (inputFieldActivatedCallback));
    InputRow.NativeMethodInfoPtr_get_buttons_Public_get_Il2CppReferenceArray_1_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669788);
    InputRow.NativeMethodInfoPtr_set_buttons_Private_set_Void_Il2CppReferenceArray_1_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669789);
    InputRow.NativeMethodInfoPtr_Initialize_Public_Void_Int32_String_Action_2_Int32_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669790);
    InputRow.NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669791);
    InputRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputRow>.NativeClassPtr, 100669792);
  }

  public unsafe Il2CppReferenceArray<ButtonInfo> buttons
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr_get_buttons_Public_get_Il2CppReferenceArray_1_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<ButtonInfo>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ButtonInfo>>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr_set_buttons_Private_set_Void_Il2CppReferenceArray_1_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79063, XrefRangeEnd = 79067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Initialize(
    int rowIndex,
    string label,
    Il2CppSystem.Action<int, ButtonInfo> inputFieldActivatedCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &rowIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inputFieldActivatedCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr_Initialize_Public_Void_Int32_String_Action_2_Int32_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnButtonActivated(ButtonInfo buttonInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buttonInfo)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr_OnButtonActivated_Public_Void_ButtonInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputRow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputRow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TMP_Text label
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_label));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<ButtonInfo> _buttons_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr__buttons_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ButtonInfo>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ButtonInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr__buttons_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int rowIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_rowIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_rowIndex)) = value;
    }
  }

  public unsafe Il2CppSystem.Action<int, ButtonInfo> inputFieldActivatedCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_inputFieldActivatedCallback));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int, ButtonInfo>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int, ButtonInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputRow.NativeFieldInfoPtr_inputFieldActivatedCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
