// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedTransform
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
public class SharedTransform(IntPtr pointer) : SharedVariable<Transform>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedTransform_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedTransform()
  {
    Il2CppClassPointerStore<SharedTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedTransform));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedTransform>.NativeClassPtr);
    SharedTransform.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTransform>.NativeClassPtr, 100673705);
    SharedTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTransform>.NativeClassPtr, 100673706);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403885, XrefRangeEnd = 403891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedTransform(Transform value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedTransform.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedTransform_Transform_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedTransform) null : Il2CppObjectPool.Get<SharedTransform>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403891, XrefRangeEnd = 403894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedTransform()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedTransform>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
