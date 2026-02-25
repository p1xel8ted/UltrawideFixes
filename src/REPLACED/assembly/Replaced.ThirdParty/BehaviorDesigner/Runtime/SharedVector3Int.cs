// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedVector3Int
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
public class SharedVector3Int(IntPtr pointer) : SharedVariable<Vector3Int>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector3Int_Vector3Int_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedVector3Int()
  {
    Il2CppClassPointerStore<SharedVector3Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedVector3Int));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedVector3Int>.NativeClassPtr);
    SharedVector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedVector3Int>.NativeClassPtr, 100673717);
    SharedVector3Int.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedVector3Int>.NativeClassPtr, 100673718);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404074, XrefRangeEnd = 404080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedVector3Int(Vector3Int value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedVector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector3Int_Vector3Int_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedVector3Int) null : Il2CppObjectPool.Get<SharedVector3Int>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404080, XrefRangeEnd = 404083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedVector3Int()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedVector3Int>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedVector3Int.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
