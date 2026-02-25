// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.DefaultBasicCharacterFeatureFeatureConstraint
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

public class DefaultBasicCharacterFeatureFeatureConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAge;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSpecies;
  private static readonly System.IntPtr NativeFieldInfoPtr_mBornIn;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSex;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOccupation;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAccent;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPersonality;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAppearance;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Age_Public_get_NumberConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Species_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BornIn_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Sex_Public_get_EnumConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Occupation_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Accent_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Personality_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Appearance_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefaultBasicCharacterFeatureFeatureConstraint()
  {
    Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (DefaultBasicCharacterFeatureFeatureConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mLoadedConstraints));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mAge));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSpecies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mSpecies));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mBornIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mBornIn));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mSex));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mOccupation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mOccupation));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAccent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mAccent));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mPersonality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mPersonality));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mAppearance));
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Age_Public_get_NumberConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678787);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Species_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678788);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_BornIn_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678789);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Sex_Public_get_EnumConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678790);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Occupation_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678791);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Accent_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678792);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Personality_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678793);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Appearance_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678794);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678795);
    DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678796);
  }

  public unsafe NumberConstraint Age
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Age_Public_get_NumberConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (NumberConstraint) null : Il2CppObjectPool.Get<NumberConstraint>(num3);
    }
  }

  public unsafe TextConstraint Species
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Species_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint BornIn
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_BornIn_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe EnumConstraint Sex
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Sex_Public_get_EnumConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EnumConstraint) null : Il2CppObjectPool.Get<EnumConstraint>(num3);
    }
  }

  public unsafe TextConstraint Occupation
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Occupation_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint Accent
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Accent_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint Personality
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Personality_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint Appearance
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Appearance_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138879, XrefRangeEnd = 138915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureConstraints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultBasicCharacterFeatureFeatureConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeatureConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool mLoadedConstraints
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints)) = value;
    }
  }

  public unsafe NumberConstraint mAge
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAge));
      return num == System.IntPtr.Zero ? (NumberConstraint) null : Il2CppObjectPool.Get<NumberConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAge), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mSpecies
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSpecies));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSpecies), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mBornIn
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mBornIn));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mBornIn), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EnumConstraint mSex
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSex));
      return num == System.IntPtr.Zero ? (EnumConstraint) null : Il2CppObjectPool.Get<EnumConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mOccupation
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mOccupation));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mOccupation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mAccent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAccent));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAccent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mPersonality
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mPersonality));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mPersonality), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mAppearance
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAppearance));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mAppearance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
