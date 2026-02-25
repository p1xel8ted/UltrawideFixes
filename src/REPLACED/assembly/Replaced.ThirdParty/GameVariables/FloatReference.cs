// Decompiled with JetBrains decompiler
// Type: GameVariables.FloatReference
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace GameVariables;

[Serializable]
public class FloatReference(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_UseConstant;
  private static readonly System.IntPtr NativeFieldInfoPtr_ConstantValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_Variable;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_FloatReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_FloatReference_0;

  static FloatReference()
  {
    Il2CppClassPointerStore<FloatReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameVariables", nameof (FloatReference));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatReference>.NativeClassPtr);
    FloatReference.NativeFieldInfoPtr_UseConstant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, nameof (UseConstant));
    FloatReference.NativeFieldInfoPtr_ConstantValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, nameof (ConstantValue));
    FloatReference.NativeFieldInfoPtr_Variable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, nameof (Variable));
    FloatReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, 100663358 /*0x0600003E*/);
    FloatReference.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, 100663359 /*0x0600003F*/);
    FloatReference.NativeMethodInfoPtr_get_Value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, 100663360 /*0x06000040*/);
    FloatReference.NativeMethodInfoPtr_SetValue_Public_Void_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, 100663361 /*0x06000041*/);
    FloatReference.NativeMethodInfoPtr_SetValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, 100663362 /*0x06000042*/);
    FloatReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatReference>.NativeClassPtr, 100663363 /*0x06000043*/);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132517, RefRangeEnd = 132519, XrefRangeStart = 132517, XrefRangeEnd = 132519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FloatReference()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatReference>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 360562, RefRangeEnd = 360564, XrefRangeStart = 360561, XrefRangeEnd = 360562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FloatReference(float value)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatReference>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatReference.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float Value
  {
    [CallerCount(72), CachedScanResults(RefRangeStart = 360564, RefRangeEnd = 360636, XrefRangeStart = 360564, XrefRangeEnd = 360564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FloatReference.NativeMethodInfoPtr_get_Value_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 360637, RefRangeEnd = 360643, XrefRangeStart = 360636, XrefRangeEnd = 360637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetValue(FloatReference source)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatReference.NativeMethodInfoPtr_SetValue_Public_Void_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(44)]
  [CachedScanResults(RefRangeStart = 360643, RefRangeEnd = 360687, XrefRangeStart = 360643, XrefRangeEnd = 360643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetValue(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatReference.NativeMethodInfoPtr_SetValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(220)]
  [CachedScanResults(RefRangeStart = 360687, RefRangeEnd = 360907, XrefRangeStart = 360687, XrefRangeEnd = 360687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator float(FloatReference reference)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) reference)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FloatReference.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_FloatReference_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool UseConstant
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatReference.NativeFieldInfoPtr_UseConstant));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatReference.NativeFieldInfoPtr_UseConstant)) = value;
    }
  }

  public unsafe float ConstantValue
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatReference.NativeFieldInfoPtr_ConstantValue));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatReference.NativeFieldInfoPtr_ConstantValue)) = value;
    }
  }

  public unsafe FloatVariable Variable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatReference.NativeFieldInfoPtr_Variable));
      return num == System.IntPtr.Zero ? (FloatVariable) null : Il2CppObjectPool.Get<FloatVariable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FloatReference.NativeFieldInfoPtr_Variable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
