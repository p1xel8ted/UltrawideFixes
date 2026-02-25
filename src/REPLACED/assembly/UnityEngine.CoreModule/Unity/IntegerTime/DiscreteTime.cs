// Decompiled with JetBrains decompiler
// Type: Unity.IntegerTime.DiscreteTime
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IntegerTime;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct DiscreteTime
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Value;
  private static readonly System.IntPtr NativeFieldInfoPtr_Zero;
  private static readonly System.IntPtr NativeFieldInfoPtr_MinValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_MaxValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecondBits;
  private static readonly System.IntPtr NativeFieldInfoPtr_NonPow2TpsBits;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int64_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DiscreteTime_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DiscreteTime_0;
  [FieldOffset(0)]
  public long Value;
  public const int Pow2Exp = 9;
  public const uint Pow2Tps = 512 /*0x0200*/;
  public const uint NonPow2Tps = 275625;
  public const uint TicksPerSecond = 141120000;
  public const double Tick = 7.0861678004535145E-09;
  public const long MaxValueSeconds = 65358361939;
  public const long MinValueSeconds = -65358361939;
  public const uint Tick5Fps = 28224000;
  public const uint Tick10Fps = 14112000;
  public const uint Tick12Fps = 11760000;
  public const uint Tick15Fps = 9408000;
  public const uint Tick2397Fps = 5885880;
  public const uint Tick24Fps = 5880000;
  public const uint Tick25Fps = 5644800;
  public const uint Tick2997Fps = 4708704;
  public const uint Tick30Fps = 4704000;
  public const uint Tick48Fps = 2940000;
  public const uint Tick50Fps = 2822400;
  public const uint Tick5995Fps = 2354352;
  public const uint Tick60Fps = 2352000;
  public const uint Tick90Fps = 1568000;
  public const uint Tick11988Fps = 1177176;
  public const uint Tick120Fps = 1176000;
  public const uint Tick240Fps = 588000;
  public const uint Tick1000Fps = 141120;
  public const uint Tick8Khz = 17640;
  public const uint Tick16Khz = 8820;
  public const uint Tick22Khz = 6400;
  public const uint Tick44Khz = 3200;
  public const uint Tick48Khz = 2940;
  public const uint Tick88Khz = 1600;
  public const uint Tick96Khz = 1470;
  public const uint Tick192Khz = 735;

  static DiscreteTime()
  {
    Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IntegerTime", nameof (DiscreteTime));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr);
    DiscreteTime.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, nameof (Value));
    DiscreteTime.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, nameof (Zero));
    DiscreteTime.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, nameof (MinValue));
    DiscreteTime.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, nameof (MaxValue));
    DiscreteTime.NativeFieldInfoPtr_TicksPerSecondBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, nameof (TicksPerSecondBits));
    DiscreteTime.NativeFieldInfoPtr_NonPow2TpsBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, nameof (NonPow2TpsBits));
    DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663347 /*0x06000033*/);
    DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663348 /*0x06000034*/);
    DiscreteTime.NativeMethodInfoPtr__ctor_Private_Void_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663349 /*0x06000035*/);
    DiscreteTime.NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663350 /*0x06000036*/);
    DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663351 /*0x06000037*/);
    DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663352 /*0x06000038*/);
    DiscreteTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663353 /*0x06000039*/);
    DiscreteTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663354 /*0x0600003A*/);
    DiscreteTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663355 /*0x0600003B*/);
    DiscreteTime.NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663356 /*0x0600003C*/);
    DiscreteTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663357 /*0x0600003D*/);
    DiscreteTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663358 /*0x0600003E*/);
    DiscreteTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663359 /*0x0600003F*/);
    DiscreteTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663360 /*0x06000040*/);
    DiscreteTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663361 /*0x06000041*/);
    DiscreteTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663362 /*0x06000042*/);
    DiscreteTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DiscreteTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, 100663363 /*0x06000043*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413607, XrefRangeEnd = 413611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DiscreteTime(float v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413611, XrefRangeEnd = 413615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DiscreteTime(double v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Public_Void_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(65)]
  [CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DiscreteTime(long v, int _)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &v;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr__ctor_Private_Void_Int64_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(283)]
  [CachedScanResults(RefRangeStart = 319669, RefRangeEnd = 319952, XrefRangeStart = 319669, XrefRangeEnd = 319952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DiscreteTime FromTicks(long v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_FromTicks_Public_Static_DiscreteTime_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DiscreteTime*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe explicit operator float(DiscreteTime d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Single_DiscreteTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe explicit operator double(DiscreteTime d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Explicit_Public_Static_Double_DiscreteTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(DiscreteTime lhs, DiscreteTime rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator >(DiscreteTime lhs, DiscreteTime rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator >=(DiscreteTime lhs, DiscreteTime rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_DiscreteTime_DiscreteTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413615, XrefRangeEnd = 413618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DiscreteTime operator +(DiscreteTime lhs, DiscreteTime rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Addition_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DiscreteTime*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413618, XrefRangeEnd = 413621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe DiscreteTime operator -(DiscreteTime lhs, DiscreteTime rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_DiscreteTime_DiscreteTime_DiscreteTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DiscreteTime*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 328469, RefRangeEnd = 328475, XrefRangeStart = 328469, XrefRangeEnd = 328475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(DiscreteTime rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rhs
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DiscreteTime_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413621, XrefRangeEnd = 413626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object o)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) o)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413626, XrefRangeEnd = 413627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413627, XrefRangeEnd = 413631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413631, XrefRangeEnd = 413635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413635, XrefRangeEnd = 413636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int CompareTo(DiscreteTime other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DiscreteTime.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DiscreteTime_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DiscreteTime>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe DiscreteTime Zero
  {
    get
    {
      DiscreteTime zero;
      IL2CPP.il2cpp_field_static_get_value(DiscreteTime.NativeFieldInfoPtr_Zero, (void*) &zero);
      return zero;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DiscreteTime.NativeFieldInfoPtr_Zero, (void*) &value);
    }
  }

  public static unsafe DiscreteTime MinValue
  {
    get
    {
      DiscreteTime minValue;
      IL2CPP.il2cpp_field_static_get_value(DiscreteTime.NativeFieldInfoPtr_MinValue, (void*) &minValue);
      return minValue;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DiscreteTime.NativeFieldInfoPtr_MinValue, (void*) &value);
    }
  }

  public static unsafe DiscreteTime MaxValue
  {
    get
    {
      DiscreteTime maxValue;
      IL2CPP.il2cpp_field_static_get_value(DiscreteTime.NativeFieldInfoPtr_MaxValue, (void*) &maxValue);
      return maxValue;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DiscreteTime.NativeFieldInfoPtr_MaxValue, (void*) &value);
    }
  }

  public static unsafe int TicksPerSecondBits
  {
    get
    {
      int ticksPerSecondBits;
      IL2CPP.il2cpp_field_static_get_value(DiscreteTime.NativeFieldInfoPtr_TicksPerSecondBits, (void*) &ticksPerSecondBits);
      return ticksPerSecondBits;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DiscreteTime.NativeFieldInfoPtr_TicksPerSecondBits, (void*) &value);
    }
  }

  public static unsafe int NonPow2TpsBits
  {
    get
    {
      int nonPow2TpsBits;
      IL2CPP.il2cpp_field_static_get_value(DiscreteTime.NativeFieldInfoPtr_NonPow2TpsBits, (void*) &nonPow2TpsBits);
      return nonPow2TpsBits;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DiscreteTime.NativeFieldInfoPtr_NonPow2TpsBits, (void*) &value);
    }
  }

  public static explicit operator DiscreteTime(float v) => new DiscreteTime(v);

  public static explicit operator DiscreteTime(double v) => new DiscreteTime(v);

  public static implicit operator RationalTime(DiscreteTime t)
  {
    return new RationalTime(t.Value, RationalTime.TicksPerSecond.DiscreteTimeRate);
  }

  public static bool operator ==(DiscreteTime lhs, DiscreteTime rhs) => lhs.Value == rhs.Value;

  public static bool operator <(DiscreteTime lhs, DiscreteTime rhs) => lhs.Value < rhs.Value;

  public static bool operator <=(DiscreteTime lhs, DiscreteTime rhs) => lhs.Value <= rhs.Value;

  public static DiscreteTime operator *(DiscreteTime lhs, long rhs)
  {
    return DiscreteTime.FromTicks(lhs.Value * rhs);
  }

  public static DiscreteTime operator *(DiscreteTime lhs, double s)
  {
    double i;
    double num1 = DiscreteTime.Modf(s, out i);
    long v = lhs.Value * (long) i;
    if (Il2CppSystem.Math.Abs(num1) >= 7.0861678004535145E-09)
    {
      int num2 = DiscreteTime.Lzcnt(Il2CppSystem.Math.Abs(lhs.Value)) - 1;
      long num3 = (long) (1 << num2);
      if (num2 >= DiscreteTime.TicksPerSecondBits)
        num3 = 141120000L;
      else if (num2 >= DiscreteTime.NonPow2TpsBits)
        num3 = (long) (uint) (275625 << num2 - DiscreteTime.NonPow2TpsBits);
      long num4 = (long) Il2CppSystem.Math.Round((double) num3 / num1);
      v += lhs.Value * num3 / num4;
    }
    return DiscreteTime.FromTicks(v);
  }

  public static double Modf(double x, out double i)
  {
    i = Il2CppSystem.Math.Truncate(x);
    return x - i;
  }

  public static int Lzcnt(long x) => throw new System.NotSupportedException("Method unstripping failed");

  public static DiscreteTime operator *(DiscreteTime lhs, float s) => lhs * (double) s;

  public static DiscreteTime operator /(DiscreteTime lhs, double s) => lhs * (1.0 / s);

  public static DiscreteTime operator /(DiscreteTime lhs, long s)
  {
    return DiscreteTime.FromTicks(lhs.Value / s);
  }

  public static DiscreteTime operator %(DiscreteTime lhs, DiscreteTime rhs)
  {
    return DiscreteTime.FromTicks(lhs.Value % rhs.Value);
  }

  public static DiscreteTime operator -(DiscreteTime lhs) => DiscreteTime.FromTicks(-lhs.Value);
}
