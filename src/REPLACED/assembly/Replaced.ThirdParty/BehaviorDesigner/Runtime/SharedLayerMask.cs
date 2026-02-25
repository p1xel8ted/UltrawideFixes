// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedLayerMask
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
public class SharedLayerMask(IntPtr pointer) : SharedVariable<LayerMask>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedLayerMask_LayerMask_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedLayerMask()
  {
    Il2CppClassPointerStore<SharedLayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedLayerMask));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedLayerMask>.NativeClassPtr);
    SharedLayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedLayerMask_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedLayerMask>.NativeClassPtr, 100673689);
    SharedLayerMask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedLayerMask>.NativeClassPtr, 100673690);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403703, XrefRangeEnd = 403712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedLayerMask(LayerMask value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedLayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedLayerMask_LayerMask_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedLayerMask) null : Il2CppObjectPool.Get<SharedLayerMask>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403712, XrefRangeEnd = 403715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedLayerMask()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedLayerMask>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedLayerMask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
