// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.CollectedItemsAchievementFeatureConstraint
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

public class CollectedItemsAchievementFeatureConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mItems;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDescription;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Items_Public_get_ReferenceStripConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CollectedItemsAchievementFeatureConstraint()
  {
    Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (CollectedItemsAchievementFeatureConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr);
    CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr, nameof (mLoadedConstraints));
    CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr, nameof (mItems));
    CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr, nameof (mDescription));
    CollectedItemsAchievementFeatureConstraint.NativeMethodInfoPtr_get_Items_Public_get_ReferenceStripConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr, 100678758);
    CollectedItemsAchievementFeatureConstraint.NativeMethodInfoPtr_get_Description_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr, 100678759);
    CollectedItemsAchievementFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr, 100678760);
    CollectedItemsAchievementFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr, 100678761);
  }

  public unsafe ReferenceStripConstraint Items
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectedItemsAchievementFeatureConstraint.NativeMethodInfoPtr_get_Items_Public_get_ReferenceStripConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ReferenceStripConstraint) null : Il2CppObjectPool.Get<ReferenceStripConstraint>(num3);
    }
  }

  public unsafe TextConstraint Description
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CollectedItemsAchievementFeatureConstraint.NativeMethodInfoPtr_get_Description_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138666, XrefRangeEnd = 138683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureConstraints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CollectedItemsAchievementFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CollectedItemsAchievementFeatureConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectedItemsAchievementFeatureConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CollectedItemsAchievementFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool mLoadedConstraints
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints)) = value;
    }
  }

  public unsafe ReferenceStripConstraint mItems
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mItems));
      return num == System.IntPtr.Zero ? (ReferenceStripConstraint) null : Il2CppObjectPool.Get<ReferenceStripConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mDescription
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mDescription));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CollectedItemsAchievementFeatureConstraint.NativeFieldInfoPtr_mDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
