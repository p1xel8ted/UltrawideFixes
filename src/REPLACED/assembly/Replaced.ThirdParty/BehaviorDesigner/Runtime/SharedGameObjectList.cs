// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedGameObjectList
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
public class SharedGameObjectList(IntPtr pointer) : SharedVariable<List<GameObject>>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedGameObjectList_List_1_GameObject_0;

  static SharedGameObjectList()
  {
    Il2CppClassPointerStore<SharedGameObjectList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedGameObjectList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedGameObjectList>.NativeClassPtr);
    SharedGameObjectList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedGameObjectList>.NativeClassPtr, 100673683);
    SharedGameObjectList.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedGameObjectList_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedGameObjectList>.NativeClassPtr, 100673684);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403613, XrefRangeEnd = 403622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedGameObjectList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedGameObjectList>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedGameObjectList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403622, XrefRangeEnd = 403634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedGameObjectList(List<GameObject> value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedGameObjectList.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedGameObjectList_List_1_GameObject_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedGameObjectList) null : Il2CppObjectPool.Get<SharedGameObjectList>(num3);
  }
}
