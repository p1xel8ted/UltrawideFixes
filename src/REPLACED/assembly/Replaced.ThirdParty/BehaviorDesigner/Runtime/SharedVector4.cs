// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedVector4
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
public class SharedVector4(IntPtr pointer) : SharedVariable<Vector4>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector4_Vector4_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedVector4()
  {
    Il2CppClassPointerStore<SharedVector4>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedVector4));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedVector4>.NativeClassPtr);
    SharedVector4.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedVector4>.NativeClassPtr, 100673719);
    SharedVector4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedVector4>.NativeClassPtr, 100673720);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 404089, RefRangeEnd = 404093, XrefRangeStart = 404083, XrefRangeEnd = 404089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedVector4(Vector4 value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedVector4.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector4_Vector4_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedVector4) null : Il2CppObjectPool.Get<SharedVector4>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404093, XrefRangeEnd = 404096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedVector4()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedVector4>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedVector4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
