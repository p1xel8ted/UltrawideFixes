// Decompiled with JetBrains decompiler
// Type: UnityEngine.NumericFieldDraggerUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class NumericFieldDraggerUtility(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_UseYSign;
  private static readonly System.IntPtr NativeMethodInfoPtr_Acceleration_Public_Static_Single_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NiceDelta_Public_Static_Single_Vector2_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_Double_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_UInt64_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Double_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_Int64_Int64_0;
  public const float kDragSensitivity = 0.03f;

  static NumericFieldDraggerUtility()
  {
    Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (NumericFieldDraggerUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr);
    NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, nameof (s_UseYSign));
    NumericFieldDraggerUtility.NativeMethodInfoPtr_Acceleration_Public_Static_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100667674);
    NumericFieldDraggerUtility.NativeMethodInfoPtr_NiceDelta_Public_Static_Single_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100667675);
    NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100667676);
    NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100667677);
    NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100667678);
    NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100667679);
    NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100667680);
    NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumericFieldDraggerUtility>.NativeClassPtr, 100667681);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 441403, RefRangeEnd = 441411, XrefRangeStart = 441403, XrefRangeEnd = 441403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Acceleration(bool shiftPressed, bool altPressed)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &shiftPressed;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &altPressed;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_Acceleration_Public_Static_Single_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 441418, RefRangeEnd = 441426, XrefRangeStart = 441411, XrefRangeEnd = 441418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float NiceDelta(Vector2 deviceDelta, float acceleration)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &deviceDelta;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &acceleration;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_NiceDelta_Public_Static_Single_Vector2_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 441431, RefRangeEnd = 441433, XrefRangeStart = 441426, XrefRangeEnd = 441431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double CalculateFloatDragSensitivity(double value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441437, RefRangeEnd = 441438, XrefRangeStart = 441433, XrefRangeEnd = 441437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double CalculateFloatDragSensitivity(
    double value,
    double minValue,
    double maxValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateFloatDragSensitivity_Public_Static_Double_Double_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 441439, RefRangeEnd = 441442, XrefRangeStart = 441438, XrefRangeEnd = 441439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long CalculateIntDragSensitivity(long value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441444, RefRangeEnd = 441445, XrefRangeStart = 441442, XrefRangeEnd = 441444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ulong CalculateIntDragSensitivity(ulong value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_UInt64_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 441450, RefRangeEnd = 441452, XrefRangeStart = 441445, XrefRangeEnd = 441450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe double CalculateIntDragSensitivity(double value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Double_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441456, RefRangeEnd = 441457, XrefRangeStart = 441452, XrefRangeEnd = 441456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe long CalculateIntDragSensitivity(long value, long minValue, long maxValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &minValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxValue;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumericFieldDraggerUtility.NativeMethodInfoPtr_CalculateIntDragSensitivity_Public_Static_Int64_Int64_Int64_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe bool s_UseYSign
  {
    get
    {
      bool sUseYsign;
      IL2CPP.il2cpp_field_static_get_value(NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign, (void*) &sUseYsign);
      return sUseYsign;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(NumericFieldDraggerUtility.NativeFieldInfoPtr_s_UseYSign, (void*) &value);
    }
  }
}
