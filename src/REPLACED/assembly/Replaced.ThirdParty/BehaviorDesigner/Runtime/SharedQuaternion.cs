// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedQuaternion
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
public class SharedQuaternion(IntPtr pointer) : SharedVariable<Quaternion>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedQuaternion_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedQuaternion()
  {
    Il2CppClassPointerStore<SharedQuaternion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedQuaternion));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedQuaternion>.NativeClassPtr);
    SharedQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedQuaternion_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedQuaternion>.NativeClassPtr, 100673697);
    SharedQuaternion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedQuaternion>.NativeClassPtr, 100673698);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 403748, RefRangeEnd = 403773, XrefRangeStart = 403742, XrefRangeEnd = 403748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedQuaternion(Quaternion value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedQuaternion.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedQuaternion_Quaternion_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedQuaternion) null : Il2CppObjectPool.Get<SharedQuaternion>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403773, XrefRangeEnd = 403776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedQuaternion()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedQuaternion>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedQuaternion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
