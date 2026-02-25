// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedTransformList
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using UnityEngine;

#nullable disable
namespace BehaviorDesigner.Runtime;

[Serializable]
public class SharedTransformList(IntPtr pointer) : SharedVariable<List<Transform>>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedTransformList_List_1_Transform_0;

  static SharedTransformList()
  {
    Il2CppClassPointerStore<SharedTransformList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedTransformList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedTransformList>.NativeClassPtr);
    SharedTransformList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTransformList>.NativeClassPtr, 100673707);
    SharedTransformList.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedTransformList_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedTransformList>.NativeClassPtr, 100673708);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403894, XrefRangeEnd = 403903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedTransformList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedTransformList>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedTransformList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403903, XrefRangeEnd = 403915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedTransformList(List<Transform> value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedTransformList.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedTransformList_List_1_Transform_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedTransformList) null : Il2CppObjectPool.Get<SharedTransformList>(num3);
  }
}
