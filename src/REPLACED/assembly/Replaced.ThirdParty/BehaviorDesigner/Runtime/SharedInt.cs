// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedInt
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace BehaviorDesigner.Runtime;

[Serializable]
public class SharedInt(IntPtr pointer) : SharedVariable<int>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedInt_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedInt()
  {
    Il2CppClassPointerStore<SharedInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedInt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedInt>.NativeClassPtr);
    SharedInt.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedInt>.NativeClassPtr, 100673687);
    SharedInt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedInt>.NativeClassPtr, 100673688);
  }

  [CallerCount(48 /*0x30*/)]
  [CachedScanResults(RefRangeStart = 403652, RefRangeEnd = 403700, XrefRangeStart = 403646, XrefRangeEnd = 403652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedInt(int value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedInt.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedInt_Int32_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedInt) null : Il2CppObjectPool.Get<SharedInt>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403700, XrefRangeEnd = 403703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedInt()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedInt>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedInt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
