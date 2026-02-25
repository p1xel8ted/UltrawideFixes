// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedVector2
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
public class SharedVector2(IntPtr pointer) : SharedVariable<Vector2>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector2_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedVector2()
  {
    Il2CppClassPointerStore<SharedVector2>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedVector2));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedVector2>.NativeClassPtr);
    SharedVector2.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedVector2>.NativeClassPtr, 100673711);
    SharedVector2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedVector2>.NativeClassPtr, 100673712);
  }

  [CallerCount(47)]
  [CachedScanResults(RefRangeStart = 403930, RefRangeEnd = 403977, XrefRangeStart = 403924, XrefRangeEnd = 403930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedVector2(Vector2 value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedVector2.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedVector2_Vector2_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedVector2) null : Il2CppObjectPool.Get<SharedVector2>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403977, XrefRangeEnd = 403980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedVector2()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedVector2>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedVector2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
