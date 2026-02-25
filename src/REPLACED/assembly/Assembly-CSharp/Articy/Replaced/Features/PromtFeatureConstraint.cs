// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.PromtFeatureConstraint
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

public class PromtFeatureConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDescriptionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCounterText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSmallText;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DescriptionText_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CounterText_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SmallText_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PromtFeatureConstraint()
  {
    Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (PromtFeatureConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr);
    PromtFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, nameof (mLoadedConstraints));
    PromtFeatureConstraint.NativeFieldInfoPtr_mDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, nameof (mDescriptionText));
    PromtFeatureConstraint.NativeFieldInfoPtr_mCounterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, nameof (mCounterText));
    PromtFeatureConstraint.NativeFieldInfoPtr_mSmallText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, nameof (mSmallText));
    PromtFeatureConstraint.NativeMethodInfoPtr_get_DescriptionText_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, 100678955);
    PromtFeatureConstraint.NativeMethodInfoPtr_get_CounterText_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, 100678956);
    PromtFeatureConstraint.NativeMethodInfoPtr_get_SmallText_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, 100678957);
    PromtFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, 100678958);
    PromtFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr, 100678959);
  }

  public unsafe TextConstraint DescriptionText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeatureConstraint.NativeMethodInfoPtr_get_DescriptionText_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint CounterText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeatureConstraint.NativeMethodInfoPtr_get_CounterText_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe TextConstraint SmallText
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeatureConstraint.NativeMethodInfoPtr_get_SmallText_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139777, XrefRangeEnd = 139793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureConstraints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PromtFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PromtFeatureConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromtFeatureConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PromtFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool mLoadedConstraints
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints)) = value;
    }
  }

  public unsafe TextConstraint mDescriptionText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeatureConstraint.NativeFieldInfoPtr_mDescriptionText));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromtFeatureConstraint.NativeFieldInfoPtr_mDescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mCounterText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeatureConstraint.NativeFieldInfoPtr_mCounterText));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromtFeatureConstraint.NativeFieldInfoPtr_mCounterText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TextConstraint mSmallText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeatureConstraint.NativeFieldInfoPtr_mSmallText));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromtFeatureConstraint.NativeFieldInfoPtr_mSmallText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
