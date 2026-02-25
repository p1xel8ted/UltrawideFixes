// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedString
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
public class SharedString(IntPtr pointer) : SharedVariable<string>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedString_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedString()
  {
    Il2CppClassPointerStore<SharedString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedString));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedString>.NativeClassPtr);
    SharedString.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedString>.NativeClassPtr, 100673703);
    SharedString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedString>.NativeClassPtr, 100673704);
  }

  [CallerCount(77)]
  [CachedScanResults(RefRangeStart = 403805, RefRangeEnd = 403882, XrefRangeStart = 403799, XrefRangeEnd = 403805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedString(string value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedString.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedString_String_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedString) null : Il2CppObjectPool.Get<SharedString>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403882, XrefRangeEnd = 403885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedString()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedString>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
