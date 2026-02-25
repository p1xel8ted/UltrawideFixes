// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedRect
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
public class SharedRect(IntPtr pointer) : SharedVariable<Rect>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedRect_Rect_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedRect()
  {
    Il2CppClassPointerStore<SharedRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedRect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedRect>.NativeClassPtr);
    SharedRect.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedRect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedRect>.NativeClassPtr, 100673699);
    SharedRect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedRect>.NativeClassPtr, 100673700);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 403782, RefRangeEnd = 403786, XrefRangeStart = 403776, XrefRangeEnd = 403782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedRect(Rect value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedRect.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedRect_Rect_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedRect) null : Il2CppObjectPool.Get<SharedRect>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403786, XrefRangeEnd = 403789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedRect()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedRect>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedRect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
