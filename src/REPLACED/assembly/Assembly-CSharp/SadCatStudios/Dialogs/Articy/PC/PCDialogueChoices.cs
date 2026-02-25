// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.PC.PCDialogueChoices
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
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.Dialogs.Articy.PC;

public class PCDialogueChoices(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_eventSystem;
  private static readonly System.IntPtr NativeFieldInfoPtr_dialogueButtons;
  private static readonly System.IntPtr NativeFieldInfoPtr_buttonTexts;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowChoices_Public_UniTask_1_Int32_IList_1_Branch_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PCDialogueChoices()
  {
    Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy.PC", nameof (PCDialogueChoices));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr);
    PCDialogueChoices.NativeFieldInfoPtr_eventSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr, nameof (eventSystem));
    PCDialogueChoices.NativeFieldInfoPtr_dialogueButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr, nameof (dialogueButtons));
    PCDialogueChoices.NativeFieldInfoPtr_buttonTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr, nameof (buttonTexts));
    PCDialogueChoices.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr, 100672943);
    PCDialogueChoices.NativeMethodInfoPtr_ShowChoices_Public_UniTask_1_Int32_IList_1_Branch_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr, 100672944);
    PCDialogueChoices.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr, 100672945);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105005, XrefRangeEnd = 105020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCDialogueChoices.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105020, XrefRangeEnd = 105065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask<int> ShowChoices(IList<Branch> branches, int selectedBranchIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) branches);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &selectedBranchIndex;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PCDialogueChoices.NativeMethodInfoPtr_ShowChoices_Public_UniTask_1_Int32_IList_1_Branch_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask<int>(pointer);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PCDialogueChoices()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCDialogueChoices.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventSystem eventSystem
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.NativeFieldInfoPtr_eventSystem));
      return num == System.IntPtr.Zero ? (EventSystem) null : Il2CppObjectPool.Get<EventSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.NativeFieldInfoPtr_eventSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Button> dialogueButtons
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.NativeFieldInfoPtr_dialogueButtons));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Button>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.NativeFieldInfoPtr_dialogueButtons), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<TMP_Text> buttonTexts
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.NativeFieldInfoPtr_buttonTexts));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<TMP_Text>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<TMP_Text>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.NativeFieldInfoPtr_buttonTexts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.PC.PCDialogueChoices+<>c__DisplayClass4_0")]
  public sealed class __c__DisplayClass4_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_result;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static __c__DisplayClass4_0()
    {
      Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr, "<>c__DisplayClass4_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_0>.NativeClassPtr);
      PCDialogueChoices.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
      PCDialogueChoices.__c__DisplayClass4_0.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_0>.NativeClassPtr, nameof (result));
      PCDialogueChoices.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_0>.NativeClassPtr, 100672946);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass4_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PCDialogueChoices.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe PCDialogueChoices __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (PCDialogueChoices) null : Il2CppObjectPool.Get<PCDialogueChoices>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UniTaskCompletionSource<int> result
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.__c__DisplayClass4_0.NativeFieldInfoPtr_result));
        return num == System.IntPtr.Zero ? (UniTaskCompletionSource<int>) null : Il2CppObjectPool.Get<UniTaskCompletionSource<int>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.__c__DisplayClass4_0.NativeFieldInfoPtr_result), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.PC.PCDialogueChoices+<>c__DisplayClass4_1")]
  public sealed class __c__DisplayClass4_1(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_currentI;
    private static readonly System.IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ShowChoices_b__0_Internal_Void_0;

    static __c__DisplayClass4_1()
    {
      Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PCDialogueChoices>.NativeClassPtr, "<>c__DisplayClass4_1");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_1>.NativeClassPtr);
      PCDialogueChoices.__c__DisplayClass4_1.NativeFieldInfoPtr_currentI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_1>.NativeClassPtr, nameof (currentI));
      PCDialogueChoices.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_1>.NativeClassPtr, "CS$<>8__locals1");
      PCDialogueChoices.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_1>.NativeClassPtr, 100672947);
      PCDialogueChoices.__c__DisplayClass4_1.NativeMethodInfoPtr__ShowChoices_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_1>.NativeClassPtr, 100672948);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass4_1()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCDialogueChoices.__c__DisplayClass4_1>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PCDialogueChoices.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104997, XrefRangeEnd = 105005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _ShowChoices_b__0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PCDialogueChoices.__c__DisplayClass4_1.NativeMethodInfoPtr__ShowChoices_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int currentI
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.__c__DisplayClass4_1.NativeFieldInfoPtr_currentI));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.__c__DisplayClass4_1.NativeFieldInfoPtr_currentI)) = value;
      }
    }

    public unsafe PCDialogueChoices.__c__DisplayClass4_0 field_Public___c__DisplayClass4_0_0
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0));
        return num == System.IntPtr.Zero ? (PCDialogueChoices.__c__DisplayClass4_0) null : Il2CppObjectPool.Get<PCDialogueChoices.__c__DisplayClass4_0>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCDialogueChoices.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
