// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedFloat
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
public class SharedFloat(IntPtr pointer) : SharedVariable<float>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SharedFloat_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedFloat()
  {
    Il2CppClassPointerStore<SharedFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedFloat));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedFloat>.NativeClassPtr);
    SharedFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedFloat_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedFloat>.NativeClassPtr, 100673679);
    SharedFloat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedFloat>.NativeClassPtr, 100673680);
  }

  [CallerCount(195)]
  [CachedScanResults(RefRangeStart = 403406, RefRangeEnd = 403601, XrefRangeStart = 403397, XrefRangeEnd = 403406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator SharedFloat(float value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedFloat.NativeMethodInfoPtr_op_Implicit_Public_Static_SharedFloat_Single_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedFloat) null : Il2CppObjectPool.Get<SharedFloat>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403601, XrefRangeEnd = 403604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedFloat()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedFloat>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedFloat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
