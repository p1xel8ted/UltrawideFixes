// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedRigidbodyType2D
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
public class SharedRigidbodyType2D(IntPtr pointer) : SharedVariable<RigidbodyType2D>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedRigidbodyType2D_RigidbodyType2D_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedRigidbodyType2D()
  {
    Il2CppClassPointerStore<SharedRigidbodyType2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedRigidbodyType2D));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedRigidbodyType2D>.NativeClassPtr);
    SharedRigidbodyType2D.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedRigidbodyType2D_RigidbodyType2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedRigidbodyType2D>.NativeClassPtr, 100673701);
    SharedRigidbodyType2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedRigidbodyType2D>.NativeClassPtr, 100673702);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 403795, RefRangeEnd = 403796, XrefRangeStart = 403789, XrefRangeEnd = 403795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedRigidbodyType2D(RigidbodyType2D value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedRigidbodyType2D.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedRigidbodyType2D_RigidbodyType2D_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedRigidbodyType2D) null : Il2CppObjectPool.Get<SharedRigidbodyType2D>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403796, XrefRangeEnd = 403799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedRigidbodyType2D()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedRigidbodyType2D>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedRigidbodyType2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
