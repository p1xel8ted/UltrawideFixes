// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Templates.TutorialDialogueTemplateConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced.Features;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.Templates;

public class TutorialDialogueTemplateConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mTutorialDialogue;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TutorialDialogue_Public_get_TutorialDialogueFeatureConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TutorialDialogueTemplateConstraint()
  {
    Il2CppClassPointerStore<TutorialDialogueTemplateConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Templates", nameof (TutorialDialogueTemplateConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialDialogueTemplateConstraint>.NativeClassPtr);
    TutorialDialogueTemplateConstraint.NativeFieldInfoPtr_mTutorialDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialDialogueTemplateConstraint>.NativeClassPtr, nameof (mTutorialDialogue));
    TutorialDialogueTemplateConstraint.NativeMethodInfoPtr_get_TutorialDialogue_Public_get_TutorialDialogueFeatureConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialDialogueTemplateConstraint>.NativeClassPtr, 100678713);
    TutorialDialogueTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialDialogueTemplateConstraint>.NativeClassPtr, 100678714);
  }

  public unsafe TutorialDialogueFeatureConstraint TutorialDialogue
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialDialogueTemplateConstraint.NativeMethodInfoPtr_get_TutorialDialogue_Public_get_TutorialDialogueFeatureConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TutorialDialogueFeatureConstraint) null : Il2CppObjectPool.Get<TutorialDialogueFeatureConstraint>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 138458, RefRangeEnd = 138459, XrefRangeStart = 138453, XrefRangeEnd = 138458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialDialogueTemplateConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialDialogueTemplateConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialDialogueTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TutorialDialogueFeatureConstraint mTutorialDialogue
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialDialogueTemplateConstraint.NativeFieldInfoPtr_mTutorialDialogue));
      return num == System.IntPtr.Zero ? (TutorialDialogueFeatureConstraint) null : Il2CppObjectPool.Get<TutorialDialogueFeatureConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialDialogueTemplateConstraint.NativeFieldInfoPtr_mTutorialDialogue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
