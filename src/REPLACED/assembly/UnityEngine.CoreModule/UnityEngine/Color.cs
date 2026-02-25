// Decompiled with JetBrains decompiler
// Type: UnityEngine.Color
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Color
{
  private static readonly System.IntPtr NativeFieldInfoPtr_r;
  private static readonly System.IntPtr NativeFieldInfoPtr_g;
  private static readonly System.IntPtr NativeFieldInfoPtr_b;
  private static readonly System.IntPtr NativeFieldInfoPtr_a;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Color_Color_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Single_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LerpUnclamped_Public_Static_Color_Color_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_red_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_green_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_white_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_black_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_magenta_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gray_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_grey_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_linear_Public_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_gamma_Public_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0;
  [FieldOffset(0)]
  public float r;
  [FieldOffset(4)]
  public float g;
  [FieldOffset(8)]
  public float b;
  [FieldOffset(12)]
  public float a;

  static Color()
  {
    Il2CppClassPointerStore<Color>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Color));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color>.NativeClassPtr);
    Color.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, nameof (r));
    Color.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, nameof (g));
    Color.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, nameof (b));
    Color.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color>.NativeClassPtr, nameof (a));
    Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667241);
    Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667242);
    Color.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667243);
    Color.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667244);
    Color.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667245);
    Color.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667246);
    Color.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667247);
    Color.NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667248 /*0x06000F70*/);
    Color.NativeMethodInfoPtr_op_Subtraction_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667249);
    Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667250);
    Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667251);
    Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667252);
    Color.NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667253);
    Color.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667254);
    Color.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667255);
    Color.NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667256);
    Color.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Color_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667257);
    Color.NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667258);
    Color.NativeMethodInfoPtr_get_red_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667259);
    Color.NativeMethodInfoPtr_get_green_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667260);
    Color.NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667261);
    Color.NativeMethodInfoPtr_get_white_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667262);
    Color.NativeMethodInfoPtr_get_black_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667263);
    Color.NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667264 /*0x06000F80*/);
    Color.NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667265);
    Color.NativeMethodInfoPtr_get_magenta_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667266);
    Color.NativeMethodInfoPtr_get_gray_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667267);
    Color.NativeMethodInfoPtr_get_grey_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667268);
    Color.NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667269);
    Color.NativeMethodInfoPtr_get_linear_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667270);
    Color.NativeMethodInfoPtr_get_gamma_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667271);
    Color.NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667272);
    Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667273);
    Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color>.NativeClassPtr, 100667274);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 245806, RefRangeEnd = 245814, XrefRangeStart = 245806, XrefRangeEnd = 245814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Color(float r, float g, float b, float a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &r;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &g;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe Color(float r, float g, float b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &r;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &g;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438041, XrefRangeEnd = 438042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438042, XrefRangeEnd = 438073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 438077, RefRangeEnd = 438091, XrefRangeStart = 438073, XrefRangeEnd = 438077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438091, XrefRangeEnd = 438098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438098, XrefRangeEnd = 438102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Color other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Color operator +(Color a, Color b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Addition_Public_Static_Color_Color_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Color operator -(Color a, Color b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Subtraction_Public_Static_Color_Color_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Color operator *(Color a, Color b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Color operator *(Color a, float b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Color operator *(float b, Color a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Multiply_Public_Static_Color_Single_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Color operator /(Color a, float b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Division_Public_Static_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Color lhs, Color rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Color_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(Color lhs, Color rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Color_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438102, XrefRangeEnd = 438103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Color Lerp(Color a, Color b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_Lerp_Public_Static_Color_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Color LerpUnclamped(Color a, Color b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_LerpUnclamped_Public_Static_Color_Color_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe Color RGBMultiplied(float multiplier)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &multiplier
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_RGBMultiplied_Internal_Color_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Color red
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_red_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color green
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_green_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color blue
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_blue_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color white
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 70627, RefRangeEnd = 70628, XrefRangeStart = 70627, XrefRangeEnd = 70628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_white_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color black
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_black_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color yellow
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_yellow_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color cyan
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_cyan_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color magenta
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_magenta_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color gray
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_gray_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color grey
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_grey_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Color clear
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_clear_Public_Static_get_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Color linear
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438103, XrefRangeEnd = 438109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_linear_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Color gamma
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438109, XrefRangeEnd = 438115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_gamma_Public_get_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float maxColorComponent
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_get_maxColorComponent_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe implicit operator Vector4(Color c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe implicit operator Color(Vector4 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public Color AlphaMultiplied(float multiplier)
  {
    return new Color(this.r, this.g, this.b, this.a * multiplier);
  }

  public Color RGBMultiplied(Color multiplier)
  {
    return new Color(this.r * multiplier.r, this.g * multiplier.g, this.b * multiplier.b, this.a);
  }

  public float grayscale
  {
    get
    {
      return (float) (0.29899999499320984 * (double) this.r + 0.58700001239776611 * (double) this.g + 57.0 / 500.0 * (double) this.b);
    }
  }

  public float this[int index]
  {
    get
    {
      switch (index)
      {
        case 0:
          return this.r;
        case 1:
          return this.g;
        case 2:
          return this.b;
        case 3:
          return this.a;
        default:
          throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Concat("Invalid Color index(", index.ToString(), ")!"));
      }
    }
    set
    {
      switch (index)
      {
        case 0:
          this.r = value;
          break;
        case 1:
          this.g = value;
          break;
        case 2:
          this.b = value;
          break;
        case 3:
          this.a = value;
          break;
        default:
          throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Concat("Invalid Color index(", index.ToString(), ")!"));
      }
    }
  }

  public static void RGBToHSV(Color rgbColor, out float H, out float S, out float V)
  {
    if ((double) rgbColor.b > (double) rgbColor.g && (double) rgbColor.b > (double) rgbColor.r)
      Color.RGBToHSVHelper(4f, rgbColor.b, rgbColor.r, rgbColor.g, out H, out S, out V);
    else if ((double) rgbColor.g > (double) rgbColor.r)
      Color.RGBToHSVHelper(2f, rgbColor.g, rgbColor.b, rgbColor.r, out H, out S, out V);
    else
      Color.RGBToHSVHelper(0.0f, rgbColor.r, rgbColor.g, rgbColor.b, out H, out S, out V);
  }

  public static void RGBToHSVHelper(
    float offset,
    float dominantcolor,
    float colorone,
    float colortwo,
    out float H,
    out float S,
    out float V)
  {
    V = dominantcolor;
    if ((double) V != 0.0)
    {
      float num1 = (double) colorone <= (double) colortwo ? colorone : colortwo;
      float num2 = V - num1;
      if ((double) num2 != 0.0)
      {
        S = num2 / V;
        H = offset + (colorone - colortwo) / num2;
      }
      else
      {
        S = 0.0f;
        H = offset + (colorone - colortwo);
      }
      H /= 6f;
      if ((double) H >= 0.0)
        return;
      ++H;
    }
    else
    {
      S = 0.0f;
      H = 0.0f;
    }
  }

  public static Color HSVToRGB(float H, float S, float V) => Color.HSVToRGB(H, S, V, true);

  public static Color HSVToRGB(float H, float S, float V, bool hdr)
  {
    Color white = Color.white;
    if ((double) S == 0.0)
    {
      white.r = V;
      white.g = V;
      white.b = V;
    }
    else if ((double) V == 0.0)
    {
      white.r = 0.0f;
      white.g = 0.0f;
      white.b = 0.0f;
    }
    else
    {
      white.r = 0.0f;
      white.g = 0.0f;
      white.b = 0.0f;
      float num1 = S;
      float num2 = V;
      float f = H * 6f;
      int num3 = (int) Mathf.Floor(f);
      float num4 = f - (float) num3;
      float num5 = num2 * (1f - num1);
      float num6 = num2 * (float) (1.0 - (double) num1 * (double) num4);
      float num7 = num2 * (float) (1.0 - (double) num1 * (1.0 - (double) num4));
      switch (num3)
      {
        case -1:
          white.r = num2;
          white.g = num5;
          white.b = num6;
          break;
        case 0:
          white.r = num2;
          white.g = num7;
          white.b = num5;
          break;
        case 1:
          white.r = num6;
          white.g = num2;
          white.b = num5;
          break;
        case 2:
          white.r = num5;
          white.g = num2;
          white.b = num7;
          break;
        case 3:
          white.r = num5;
          white.g = num6;
          white.b = num2;
          break;
        case 4:
          white.r = num7;
          white.g = num5;
          white.b = num2;
          break;
        case 5:
          white.r = num2;
          white.g = num5;
          white.b = num6;
          break;
        case 6:
          white.r = num2;
          white.g = num7;
          white.b = num5;
          break;
      }
      if (!hdr)
      {
        white.r = Mathf.Clamp(white.r, 0.0f, 1f);
        white.g = Mathf.Clamp(white.g, 0.0f, 1f);
        white.b = Mathf.Clamp(white.b, 0.0f, 1f);
      }
    }
    return white;
  }
}
