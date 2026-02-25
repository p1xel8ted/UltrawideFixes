// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.TutorialDialogueFeatureConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity.Constraints;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.Features;

public class TutorialDialogueFeatureConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mImages;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTitle;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Images_Public_get_ReferenceStripConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Title_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TutorialDialogueFeatureConstraint()
  {
    Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (TutorialDialogueFeatureConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr);
    TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr, nameof (mLoadedConstraints));
    TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr, nameof (mImages));
    TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr, nameof (mTitle));
    TutorialDialogueFeatureConstraint.NativeMethodInfoPtr_get_Images_Public_get_ReferenceStripConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr, 100679010);
    TutorialDialogueFeatureConstraint.NativeMethodInfoPtr_get_Title_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr, 100679011);
    TutorialDialogueFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr, 100679012);
    TutorialDialogueFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr, 100679013);
  }

  public unsafe ReferenceStripConstraint Images
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialDialogueFeatureConstraint.NativeMethodInfoPtr_get_Images_Public_get_ReferenceStripConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ReferenceStripConstraint) null : Il2CppObjectPool.Get<ReferenceStripConstraint>(num3);
    }
  }

  public unsafe TextConstraint Title
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialDialogueFeatureConstraint.NativeMethodInfoPtr_get_Title_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140032, XrefRangeEnd = 140047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureConstraints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TutorialDialogueFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialDialogueFeatureConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialDialogueFeatureConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialDialogueFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool mLoadedConstraints
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints)) = value;
    }
  }

  public unsafe ReferenceStripConstraint mImages
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mImages));
      return num == System.IntPtr.Zero ? (ReferenceStripConstraint) null : Il2CppObjectPool.Get<ReferenceStripConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mImages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mTitle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mTitle));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialDialogueFeatureConstraint.NativeFieldInfoPtr_mTitle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
