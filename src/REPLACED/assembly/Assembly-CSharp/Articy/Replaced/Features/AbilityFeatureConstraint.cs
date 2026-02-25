// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.AbilityFeatureConstraint
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

public class AbilityFeatureConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAbilityType;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AbilityType_Public_get_EnumConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AbilityFeatureConstraint()
  {
    Il2CppClassPointerStore<AbilityFeatureConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (AbilityFeatureConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityFeatureConstraint>.NativeClassPtr);
    AbilityFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityFeatureConstraint>.NativeClassPtr, nameof (mLoadedConstraints));
    AbilityFeatureConstraint.NativeFieldInfoPtr_mAbilityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityFeatureConstraint>.NativeClassPtr, nameof (mAbilityType));
    AbilityFeatureConstraint.NativeMethodInfoPtr_get_AbilityType_Public_get_EnumConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityFeatureConstraint>.NativeClassPtr, 100678742);
    AbilityFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityFeatureConstraint>.NativeClassPtr, 100678743);
    AbilityFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityFeatureConstraint>.NativeClassPtr, 100678744);
  }

  public unsafe EnumConstraint AbilityType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AbilityFeatureConstraint.NativeMethodInfoPtr_get_AbilityType_Public_get_EnumConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EnumConstraint) null : Il2CppObjectPool.Get<EnumConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138577, XrefRangeEnd = 138583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureConstraints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AbilityFeatureConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityFeatureConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AbilityFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool mLoadedConstraints
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints)) = value;
    }
  }

  public unsafe EnumConstraint mAbilityType
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityFeatureConstraint.NativeFieldInfoPtr_mAbilityType));
      return num == System.IntPtr.Zero ? (EnumConstraint) null : Il2CppObjectPool.Get<EnumConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityFeatureConstraint.NativeFieldInfoPtr_mAbilityType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
