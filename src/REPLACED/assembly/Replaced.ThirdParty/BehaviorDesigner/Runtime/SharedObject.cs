// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.SharedObject
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
public class SharedObject(IntPtr pointer) : SharedVariable<UnityEngine.Object>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_SharedObject_Object_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SharedObject()
  {
    Il2CppClassPointerStore<SharedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (SharedObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedObject>.NativeClassPtr);
    SharedObject.NativeMethodInfoPtr_op_Explicit_Public_Static_SharedObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedObject>.NativeClassPtr, 100673693);
    SharedObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedObject>.NativeClassPtr, 100673694);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403724, XrefRangeEnd = 403730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe explicit operator SharedObject(UnityEngine.Object value)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SharedObject.NativeMethodInfoPtr_op_Explicit_Public_Static_SharedObject_Object_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (SharedObject) null : Il2CppObjectPool.Get<SharedObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403730, XrefRangeEnd = 403733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SharedObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedObject>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SharedObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
