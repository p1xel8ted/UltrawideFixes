// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Templates.Upgrade_ItemTemplateConstraint
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

public class Upgrade_ItemTemplateConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mStatUpgrade;
  private static readonly System.IntPtr NativeFieldInfoPtr_mItem;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatUpgrade_Public_get_StatUpgradeFeatureConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_ItemFeatureConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Upgrade_ItemTemplateConstraint()
  {
    Il2CppClassPointerStore<Upgrade_ItemTemplateConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Templates", nameof (Upgrade_ItemTemplateConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Upgrade_ItemTemplateConstraint>.NativeClassPtr);
    Upgrade_ItemTemplateConstraint.NativeFieldInfoPtr_mStatUpgrade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Upgrade_ItemTemplateConstraint>.NativeClassPtr, nameof (mStatUpgrade));
    Upgrade_ItemTemplateConstraint.NativeFieldInfoPtr_mItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Upgrade_ItemTemplateConstraint>.NativeClassPtr, nameof (mItem));
    Upgrade_ItemTemplateConstraint.NativeMethodInfoPtr_get_StatUpgrade_Public_get_StatUpgradeFeatureConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Upgrade_ItemTemplateConstraint>.NativeClassPtr, 100678728);
    Upgrade_ItemTemplateConstraint.NativeMethodInfoPtr_get_Item_Public_get_ItemFeatureConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Upgrade_ItemTemplateConstraint>.NativeClassPtr, 100678729);
    Upgrade_ItemTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Upgrade_ItemTemplateConstraint>.NativeClassPtr, 100678730);
  }

  public unsafe StatUpgradeFeatureConstraint StatUpgrade
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Upgrade_ItemTemplateConstraint.NativeMethodInfoPtr_get_StatUpgrade_Public_get_StatUpgradeFeatureConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (StatUpgradeFeatureConstraint) null : Il2CppObjectPool.Get<StatUpgradeFeatureConstraint>(num3);
    }
  }

  public unsafe ItemFeatureConstraint Item
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Upgrade_ItemTemplateConstraint.NativeMethodInfoPtr_get_Item_Public_get_ItemFeatureConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ItemFeatureConstraint) null : Il2CppObjectPool.Get<ItemFeatureConstraint>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 138537, RefRangeEnd = 138538, XrefRangeStart = 138528, XrefRangeEnd = 138537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Upgrade_ItemTemplateConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Upgrade_ItemTemplateConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Upgrade_ItemTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StatUpgradeFeatureConstraint mStatUpgrade
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Upgrade_ItemTemplateConstraint.NativeFieldInfoPtr_mStatUpgrade));
      return num == System.IntPtr.Zero ? (StatUpgradeFeatureConstraint) null : Il2CppObjectPool.Get<StatUpgradeFeatureConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Upgrade_ItemTemplateConstraint.NativeFieldInfoPtr_mStatUpgrade), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ItemFeatureConstraint mItem
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Upgrade_ItemTemplateConstraint.NativeFieldInfoPtr_mItem));
      return num == System.IntPtr.Zero ? (ItemFeatureConstraint) null : Il2CppObjectPool.Get<ItemFeatureConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Upgrade_ItemTemplateConstraint.NativeFieldInfoPtr_mItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
