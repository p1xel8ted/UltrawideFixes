// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedBehaviour
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
public class SharedBehaviour(IntPtr pointer) : SharedVariable<Behaviour>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SharedBehaviour_Behaviour_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedBehaviour()
  {
    Il2CppClassPointerStore<SharedBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedBehaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedBehaviour>.NativeClassPtr);
    SharedBehaviour.NativeMethodInfoPtr_op_Explicit_Public_Static_SharedBehaviour_Behaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedBehaviour>.NativeClassPtr, 100673671);
    SharedBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedBehaviour>.NativeClassPtr, 100673672);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403289, XrefRangeEnd = 403295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe explicit operator SharedBehaviour(Behaviour value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedBehaviour.NativeMethodInfoPtr_op_Explicit_Public_Static_SharedBehaviour_Behaviour_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedBehaviour) null : Il2CppObjectPool.Get<SharedBehaviour>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403295, XrefRangeEnd = 403298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedBehaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedBehaviour>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
