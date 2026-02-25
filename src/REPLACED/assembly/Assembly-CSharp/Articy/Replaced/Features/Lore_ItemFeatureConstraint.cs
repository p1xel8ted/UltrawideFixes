// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.Lore_ItemFeatureConstraint
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

public class Lore_ItemFeatureConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLore_item_body;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLore_item_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSmallTextValue;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lore_item_body_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lore_item_type_Public_get_EnumConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SmallTextValue_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Lore_ItemFeatureConstraint()
  {
    Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (Lore_ItemFeatureConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr);
    Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, nameof (mLoadedConstraints));
    Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLore_item_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, nameof (mLore_item_body));
    Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLore_item_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, nameof (mLore_item_type));
    Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mSmallTextValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, nameof (mSmallTextValue));
    Lore_ItemFeatureConstraint.NativeMethodInfoPtr_get_lore_item_body_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, 100678869);
    Lore_ItemFeatureConstraint.NativeMethodInfoPtr_get_lore_item_type_Public_get_EnumConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, 100678870);
    Lore_ItemFeatureConstraint.NativeMethodInfoPtr_get_SmallTextValue_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, 100678871);
    Lore_ItemFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, 100678872);
    Lore_ItemFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr, 100678873);
  }

  public unsafe TextConstraint lore_item_body
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Lore_ItemFeatureConstraint.NativeMethodInfoPtr_get_lore_item_body_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe EnumConstraint lore_item_type
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Lore_ItemFeatureConstraint.NativeMethodInfoPtr_get_lore_item_type_Public_get_EnumConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EnumConstraint) null : Il2CppObjectPool.Get<EnumConstraint>(num3);
    }
  }

  public unsafe TextConstraint SmallTextValue
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Lore_ItemFeatureConstraint.NativeMethodInfoPtr_get_SmallTextValue_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139278, XrefRangeEnd = 139295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureConstraints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Lore_ItemFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Lore_ItemFeatureConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lore_ItemFeatureConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Lore_ItemFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool mLoadedConstraints
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints)) = value;
    }
  }

  public unsafe TextConstraint mLore_item_body
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLore_item_body));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLore_item_body), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EnumConstraint mLore_item_type
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLore_item_type));
      return num == System.IntPtr.Zero ? (EnumConstraint) null : Il2CppObjectPool.Get<EnumConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mLore_item_type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mSmallTextValue
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mSmallTextValue));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Lore_ItemFeatureConstraint.NativeFieldInfoPtr_mSmallTextValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
