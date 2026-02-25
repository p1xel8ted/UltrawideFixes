// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedColor
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
public class SharedColor(IntPtr pointer) : SharedVariable<Color>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedColor_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedColor()
  {
    Il2CppClassPointerStore<SharedColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedColor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedColor>.NativeClassPtr);
    SharedColor.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedColor_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedColor>.NativeClassPtr, 100673677);
    SharedColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedColor>.NativeClassPtr, 100673678);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 403382, RefRangeEnd = 403394, XrefRangeStart = 403376, XrefRangeEnd = 403382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedColor(Color value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedColor.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedColor_Color_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedColor) null : Il2CppObjectPool.Get<SharedColor>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403394, XrefRangeEnd = 403397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedColor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedColor>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
