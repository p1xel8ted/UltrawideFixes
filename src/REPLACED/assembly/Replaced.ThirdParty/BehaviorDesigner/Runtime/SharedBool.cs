// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedBool
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
public class SharedBool(IntPtr pointer) : SharedVariable<bool>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedBool_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedBool()
  {
    Il2CppClassPointerStore<SharedBool>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedBool));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedBool>.NativeClassPtr);
    SharedBool.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedBool_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedBool>.NativeClassPtr, 100673673);
    SharedBool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedBool>.NativeClassPtr, 100673674);
  }

  [CallerCount(60)]
  [CachedScanResults(RefRangeStart = 403304, RefRangeEnd = 403364, XrefRangeStart = 403298, XrefRangeEnd = 403304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedBool(bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedBool.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedBool_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedBool) null : Il2CppObjectPool.Get<SharedBool>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403364, XrefRangeEnd = 403367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedBool()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedBool>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedBool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
