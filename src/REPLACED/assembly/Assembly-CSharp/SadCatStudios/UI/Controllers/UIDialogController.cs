// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Controllers.UIDialogController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.UI.Elements;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI.Controllers;

public class UIDialogController(System.IntPtr pointer) : LocalSingletonBehaviour<UIDialogController>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_choicesElements;
  private static readonly System.IntPtr NativeFieldInfoPtr_backChoiceElement;
  private static readonly System.IntPtr NativeFieldInfoPtr_panel;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowAnswers_Public_Void_IList_1_Branch_HashSet_1_UInt64_UniTaskCompletionSource_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIDialogController()
  {
    Il2CppClassPointerStore<UIDialogController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Controllers", nameof (UIDialogController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDialogController>.NativeClassPtr);
    UIDialogController.NativeFieldInfoPtr_choicesElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogController>.NativeClassPtr, nameof (choicesElements));
    UIDialogController.NativeFieldInfoPtr_backChoiceElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogController>.NativeClassPtr, nameof (backChoiceElement));
    UIDialogController.NativeFieldInfoPtr_panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogController>.NativeClassPtr, nameof (panel));
    UIDialogController.NativeMethodInfoPtr_ShowAnswers_Public_Void_IList_1_Branch_HashSet_1_UInt64_UniTaskCompletionSource_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogController>.NativeClassPtr, 100672581);
    UIDialogController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogController>.NativeClassPtr, 100672582);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 102195, RefRangeEnd = 102196, XrefRangeStart = 102135, XrefRangeEnd = 102195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowAnswers(
    IList<Branch> branches,
    HashSet<ulong> seenChoices,
    UniTaskCompletionSource<int> chosenBranchPromise)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) branches);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) seenChoices);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) chosenBranchPromise);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDialogController.NativeMethodInfoPtr_ShowAnswers_Public_Void_IList_1_Branch_HashSet_1_UInt64_UniTaskCompletionSource_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102196, XrefRangeEnd = 102199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIDialogController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDialogController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDialogController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<UIDialogAnswerElement> choicesElements
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.NativeFieldInfoPtr_choicesElements));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UIDialogAnswerElement>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UIDialogAnswerElement>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.NativeFieldInfoPtr_choicesElements), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIDialogAnswerElement backChoiceElement
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.NativeFieldInfoPtr_backChoiceElement));
      return num == System.IntPtr.Zero ? (UIDialogAnswerElement) null : Il2CppObjectPool.Get<UIDialogAnswerElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.NativeFieldInfoPtr_backChoiceElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform panel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.NativeFieldInfoPtr_panel));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.NativeFieldInfoPtr_panel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Controllers.UIDialogController+<>c__DisplayClass3_0")]
  public sealed class __c__DisplayClass3_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_chosenBranchPromise;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ShowAnswers_b__0_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ShowAnswers_b__1_Internal_Void_Int32_0;

    static __c__DisplayClass3_0()
    {
      Il2CppClassPointerStore<UIDialogController.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDialogController>.NativeClassPtr, "<>c__DisplayClass3_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDialogController.__c__DisplayClass3_0>.NativeClassPtr);
      UIDialogController.__c__DisplayClass3_0.NativeFieldInfoPtr_chosenBranchPromise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogController.__c__DisplayClass3_0>.NativeClassPtr, nameof (chosenBranchPromise));
      UIDialogController.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDialogController.__c__DisplayClass3_0>.NativeClassPtr, "<>9__1");
      UIDialogController.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogController.__c__DisplayClass3_0>.NativeClassPtr, 100672583);
      UIDialogController.__c__DisplayClass3_0.NativeMethodInfoPtr__ShowAnswers_b__0_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogController.__c__DisplayClass3_0>.NativeClassPtr, 100672584);
      UIDialogController.__c__DisplayClass3_0.NativeMethodInfoPtr__ShowAnswers_b__1_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDialogController.__c__DisplayClass3_0>.NativeClassPtr, 100672585);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass3_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDialogController.__c__DisplayClass3_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDialogController.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102127, XrefRangeEnd = 102131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _ShowAnswers_b__0(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDialogController.__c__DisplayClass3_0.NativeMethodInfoPtr__ShowAnswers_b__0_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102131, XrefRangeEnd = 102135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _ShowAnswers_b__1(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDialogController.__c__DisplayClass3_0.NativeMethodInfoPtr__ShowAnswers_b__1_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe UniTaskCompletionSource<int> chosenBranchPromise
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.__c__DisplayClass3_0.NativeFieldInfoPtr_chosenBranchPromise));
        return num == System.IntPtr.Zero ? (UniTaskCompletionSource<int>) null : Il2CppObjectPool.Get<UniTaskCompletionSource<int>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.__c__DisplayClass3_0.NativeFieldInfoPtr_chosenBranchPromise), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<int> __9__1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<int>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<int>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDialogController.__c__DisplayClass3_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
