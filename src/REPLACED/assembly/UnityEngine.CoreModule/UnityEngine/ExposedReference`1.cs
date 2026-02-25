// Decompiled with JetBrains decompiler
// Type: UnityEngine.ExposedReference`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[Serializable]
public sealed class ExposedReference<T> : Il2CppSystem.ValueType where T : Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_exposedName;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultValue;
  private static readonly System.IntPtr NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0;

  static ExposedReference()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ExposedReference`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr);
    ExposedReference<T>.NativeFieldInfoPtr_exposedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, nameof (exposedName));
    ExposedReference<T>.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, nameof (defaultValue));
    ExposedReference<T>.NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr, 100664409);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 421103, RefRangeEnd = 421117, XrefRangeStart = 421097, XrefRangeEnd = 421103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T Resolve(IExposedPropertyTable resolver)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resolver)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ExposedReference<T>.NativeMethodInfoPtr_Resolve_Public_T_IExposedPropertyTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  public ExposedReference(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ExposedReference()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExposedReference<T>>.NativeClassPtr))
  {
  }

  public unsafe PropertyName exposedName
  {
    get
    {
      return *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_exposedName));
    }
    [param: In] set
    {
      *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_exposedName)) = value;
    }
  }

  public unsafe Object defaultValue
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_defaultValue));
      return num == System.IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ExposedReference<T>.NativeFieldInfoPtr_defaultValue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
