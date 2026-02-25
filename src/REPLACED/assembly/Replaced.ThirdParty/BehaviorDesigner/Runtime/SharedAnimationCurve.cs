// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedAnimationCurve
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using UnityEngine;

#nullable disable
namespace BehaviorDesigner.Runtime;

[Serializable]
public class SharedAnimationCurve(IntPtr pointer) : SharedVariable<AnimationCurve>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedAnimationCurve_AnimationCurve_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedAnimationCurve()
  {
    Il2CppClassPointerStore<SharedAnimationCurve>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedAnimationCurve));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedAnimationCurve>.NativeClassPtr);
    SharedAnimationCurve.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedAnimationCurve_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedAnimationCurve>.NativeClassPtr, 100673669);
    SharedAnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedAnimationCurve>.NativeClassPtr, 100673670);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403280, XrefRangeEnd = 403286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedAnimationCurve(AnimationCurve value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedAnimationCurve.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedAnimationCurve_AnimationCurve_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedAnimationCurve) null : Il2CppObjectPool.Get<SharedAnimationCurve>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403286, XrefRangeEnd = 403289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedAnimationCurve()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedAnimationCurve>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedAnimationCurve.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
