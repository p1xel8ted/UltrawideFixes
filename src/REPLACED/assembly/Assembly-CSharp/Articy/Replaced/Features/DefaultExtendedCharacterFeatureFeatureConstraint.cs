// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.DefaultExtendedCharacterFeatureFeatureConstraint
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

public class DefaultExtendedCharacterFeatureFeatureConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mMotivation;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInnerConflict;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSkills;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFears;
  private static readonly System.IntPtr NativeFieldInfoPtr_mHabits;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFurtherDetails;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Motivation_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InnerConflict_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Skills_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Fears_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Habits_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FurtherDetails_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefaultExtendedCharacterFeatureFeatureConstraint()
  {
    Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (DefaultExtendedCharacterFeatureFeatureConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr);
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mLoadedConstraints));
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mMotivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mMotivation));
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mInnerConflict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mInnerConflict));
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSkills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mSkills));
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mFears = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mFears));
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mHabits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mHabits));
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mFurtherDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, nameof (mFurtherDetails));
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Motivation_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678818);
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_InnerConflict_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678819);
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Skills_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678820);
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Fears_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678821);
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Habits_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678822);
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_FurtherDetails_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678823);
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678824);
    DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr, 100678825);
  }

  public unsafe TextConstraint Motivation
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Motivation_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint InnerConflict
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_InnerConflict_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint Skills
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Skills_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint Fears
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Fears_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint Habits
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_Habits_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint FurtherDetails
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_get_FurtherDetails_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139045, XrefRangeEnd = 139071, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureConstraints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultExtendedCharacterFeatureFeatureConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeatureConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool mLoadedConstraints
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints)) = value;
    }
  }

  public unsafe TextConstraint mMotivation
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mMotivation));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mMotivation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mInnerConflict
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mInnerConflict));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mInnerConflict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mSkills
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSkills));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mSkills), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mFears
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mFears));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mFears), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mHabits
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mHabits));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mHabits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mFurtherDetails
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mFurtherDetails));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeatureConstraint.NativeFieldInfoPtr_mFurtherDetails), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
