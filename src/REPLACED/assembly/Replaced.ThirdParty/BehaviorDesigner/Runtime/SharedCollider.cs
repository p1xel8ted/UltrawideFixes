// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedCollider
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
public class SharedCollider(IntPtr pointer) : SharedVariable<Collider>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedCollider_Collider_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedCollider()
  {
    Il2CppClassPointerStore<SharedCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedCollider));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedCollider>.NativeClassPtr);
    SharedCollider.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedCollider_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedCollider>.NativeClassPtr, 100673675);
    SharedCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedCollider>.NativeClassPtr, 100673676);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403367, XrefRangeEnd = 403373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedCollider(Collider value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedCollider.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedCollider_Collider_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedCollider) null : Il2CppObjectPool.Get<SharedCollider>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403373, XrefRangeEnd = 403376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedCollider()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedCollider>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
