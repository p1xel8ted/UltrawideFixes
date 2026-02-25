// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.BloomParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct BloomParams
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kBlank;
  private static readonly System.IntPtr NativeFieldInfoPtr_threshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_scatter;
  private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BloomParams_BloomParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BloomParams_BloomParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_BloomParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public readonly float threshold;
  [FieldOffset(4)]
  public readonly float scatter;
  [FieldOffset(8)]
  public readonly float intensity;

  static BloomParams()
  {
    Il2CppClassPointerStore<BloomParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (BloomParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomParams>.NativeClassPtr);
    BloomParams.NativeFieldInfoPtr_kBlank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, nameof (kBlank));
    BloomParams.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, nameof (threshold));
    BloomParams.NativeFieldInfoPtr_scatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, nameof (scatter));
    BloomParams.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, nameof (intensity));
    BloomParams.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, 100663628);
    BloomParams.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BloomParams_BloomParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, 100663629);
    BloomParams.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BloomParams_BloomParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, 100663630);
    BloomParams.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, 100663631);
    BloomParams.NativeMethodInfoPtr_Equals_Public_Boolean_BloomParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, 100663632 /*0x06000150*/);
    BloomParams.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, 100663633);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 245823, RefRangeEnd = 245824, XrefRangeStart = 245823, XrefRangeEnd = 245824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BloomParams(float threshold, float scatter, float intensity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &threshold;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &scatter;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &intensity;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BloomParams.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927027, RefRangeEnd = 927028, XrefRangeStart = 927017, XrefRangeEnd = 927027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(BloomParams lhs, BloomParams rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BloomParams.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BloomParams_BloomParams_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927028, XrefRangeEnd = 927041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(BloomParams lhs, BloomParams rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BloomParams.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BloomParams_BloomParams_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927041, XrefRangeEnd = 927046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BloomParams.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe bool Equals(BloomParams other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BloomParams.NativeMethodInfoPtr_Equals_Public_Boolean_BloomParams_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927046, XrefRangeEnd = 927050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BloomParams.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BloomParams>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe BloomParams kBlank
  {
    get
    {
      BloomParams kBlank;
      IL2CPP.il2cpp_field_static_get_value(BloomParams.NativeFieldInfoPtr_kBlank, (void*) &kBlank);
      return kBlank;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BloomParams.NativeFieldInfoPtr_kBlank, (void*) &value);
    }
  }
}
