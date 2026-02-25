// Decompiled with JetBrains decompiler
// Type: UnityEngine.Vector4
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
public struct Vector4
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kEpsilon;
  private static readonly System.IntPtr NativeFieldInfoPtr_x;
  private static readonly System.IntPtr NativeFieldInfoPtr_y;
  private static readonly System.IntPtr NativeFieldInfoPtr_z;
  private static readonly System.IntPtr NativeFieldInfoPtr_w;
  private static readonly System.IntPtr NativeFieldInfoPtr_zeroVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_oneVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_positiveInfinityVector;
  private static readonly System.IntPtr NativeFieldInfoPtr_negativeInfinityVector;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Vector4_Vector4_Vector4_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveTowards_Public_Static_Vector4_Vector4_Vector4_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Scale_Public_Void_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Distance_Public_Static_Single_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector4_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector4_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  [FieldOffset(0)]
  public float x;
  [FieldOffset(4)]
  public float y;
  [FieldOffset(8)]
  public float z;
  [FieldOffset(12)]
  public float w;

  static Vector4()
  {
    Il2CppClassPointerStore<Vector4>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Vector4));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector4>.NativeClassPtr);
    Vector4.NativeFieldInfoPtr_kEpsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (kEpsilon));
    Vector4.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (x));
    Vector4.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (y));
    Vector4.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (z));
    Vector4.NativeFieldInfoPtr_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (w));
    Vector4.NativeFieldInfoPtr_zeroVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (zeroVector));
    Vector4.NativeFieldInfoPtr_oneVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (oneVector));
    Vector4.NativeFieldInfoPtr_positiveInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (positiveInfinityVector));
    Vector4.NativeFieldInfoPtr_negativeInfinityVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector4>.NativeClassPtr, nameof (negativeInfinityVector));
    Vector4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667630);
    Vector4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667631);
    Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667632 /*0x060010F0*/);
    Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667633);
    Vector4.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667634);
    Vector4.NativeMethodInfoPtr_Lerp_Public_Static_Vector4_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667635);
    Vector4.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector4_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667636);
    Vector4.NativeMethodInfoPtr_Scale_Public_Void_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667637);
    Vector4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667638);
    Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667639);
    Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667640);
    Vector4.NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667641);
    Vector4.NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667642);
    Vector4.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667643);
    Vector4.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667644);
    Vector4.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667645);
    Vector4.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667646);
    Vector4.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667647);
    Vector4.NativeMethodInfoPtr_Min_Public_Static_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667648 /*0x06001100*/);
    Vector4.NativeMethodInfoPtr_Max_Public_Static_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667649);
    Vector4.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667650);
    Vector4.NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667651);
    Vector4.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667652);
    Vector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667653);
    Vector4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667654);
    Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667655);
    Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667656);
    Vector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667657);
    Vector4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667658);
    Vector4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667659);
    Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667660);
    Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667661);
    Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667662);
    Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667663);
    Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667664);
    Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector4>.NativeClassPtr, 100667665);
  }

  public unsafe float this[int index]
  {
    [CallerCount(26), CachedScanResults(RefRangeStart = 441264, RefRangeEnd = 441290, XrefRangeStart = 441264, XrefRangeEnd = 441264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 441290, RefRangeEnd = 441298, XrefRangeStart = 441290, XrefRangeEnd = 441290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 245806, RefRangeEnd = 245814, XrefRangeStart = 245806, XrefRangeEnd = 245814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector4(float x, float y, float z, float w)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &w;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe Vector4(float x, float y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 245806, RefRangeEnd = 245814, XrefRangeStart = 245806, XrefRangeEnd = 245814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(float newX, float newY, float newZ, float newW)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &newX;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newY;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newZ;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &newW;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Set_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 Lerp(Vector4 a, Vector4 b, float t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Lerp_Public_Static_Vector4_Vector4_Vector4_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441298, XrefRangeEnd = 441304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 MoveTowards(Vector4 current, Vector4 target, float maxDistanceDelta)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &current;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxDistanceDelta;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_MoveTowards_Public_Static_Vector4_Vector4_Vector4_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void Scale(Vector4 scale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &scale
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Scale_Public_Void_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 440572, RefRangeEnd = 440583, XrefRangeStart = 440572, XrefRangeEnd = 440583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441304, XrefRangeEnd = 441307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Vector4 other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441307, XrefRangeEnd = 441310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 Normalize(Vector4 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Normalize_Public_Static_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Vector4 normalized
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441310, XrefRangeEnd = 441313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_normalized_Public_get_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe float Dot(Vector4 a, Vector4 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Dot_Public_Static_Single_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441313, XrefRangeEnd = 441314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Distance(Vector4 a, Vector4 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Distance_Public_Static_Single_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441314, XrefRangeEnd = 441317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Magnitude(Vector4 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Magnitude_Public_Static_Single_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float magnitude
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441317, XrefRangeEnd = 441320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float sqrMagnitude
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_sqrMagnitude_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe Vector4 Min(Vector4 lhs, Vector4 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Min_Public_Static_Vector4_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector4 Max(Vector4 lhs, Vector4 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_Max_Public_Static_Vector4_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe Vector4 zero
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441320, XrefRangeEnd = 441322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector4 one
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441322, XrefRangeEnd = 441324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_get_one_Public_Static_get_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe Vector4 operator +(Vector4 a, Vector4 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Addition_Public_Static_Vector4_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector4 operator -(Vector4 a, Vector4 b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector4_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector4 operator -(Vector4 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &a
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector4 operator *(Vector4 a, float d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Vector4_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector4 operator *(float d, Vector4 a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &d;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector4_Single_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector4 operator /(Vector4 a, float d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &d;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Division_Public_Static_Vector4_Vector4_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Vector4 lhs, Vector4 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(Vector4 lhs, Vector4 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector4_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe implicit operator Vector4(Vector3 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe implicit operator Vector3(Vector4 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe implicit operator Vector4(Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector4_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 422045, RefRangeEnd = 422049, XrefRangeStart = 422045, XrefRangeEnd = 422049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator Vector2(Vector4 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441324, XrefRangeEnd = 441330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441330, XrefRangeEnd = 441361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector4.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector4>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe float kEpsilon
  {
    get
    {
      float kEpsilon;
      IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_kEpsilon, (void*) &kEpsilon);
      return kEpsilon;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_kEpsilon, (void*) &value);
    }
  }

  public static unsafe Vector4 zeroVector
  {
    get
    {
      Vector4 zeroVector;
      IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_zeroVector, (void*) &zeroVector);
      return zeroVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_zeroVector, (void*) &value);
    }
  }

  public static unsafe Vector4 oneVector
  {
    get
    {
      Vector4 oneVector;
      IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_oneVector, (void*) &oneVector);
      return oneVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_oneVector, (void*) &value);
    }
  }

  public static unsafe Vector4 positiveInfinityVector
  {
    get
    {
      Vector4 positiveInfinityVector;
      IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_positiveInfinityVector, (void*) &positiveInfinityVector);
      return positiveInfinityVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_positiveInfinityVector, (void*) &value);
    }
  }

  public static unsafe Vector4 negativeInfinityVector
  {
    get
    {
      Vector4 negativeInfinityVector;
      IL2CPP.il2cpp_field_static_get_value(Vector4.NativeFieldInfoPtr_negativeInfinityVector, (void*) &negativeInfinityVector);
      return negativeInfinityVector;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector4.NativeFieldInfoPtr_negativeInfinityVector, (void*) &value);
    }
  }

  public static Vector4 LerpUnclamped(Vector4 a, Vector4 b, float t)
  {
    return new Vector4(a.x + (b.x - a.x) * t, a.y + (b.y - a.y) * t, a.z + (b.z - a.z) * t, a.w + (b.w - a.w) * t);
  }

  public static Vector4 Scale(Vector4 a, Vector4 b)
  {
    return new Vector4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
  }

  public void Normalize()
  {
    float num = Vector4.Magnitude(this);
    if ((double) num > 9.9999997473787516E-06)
      this = this / num;
    else
      this = Vector4.zero;
  }

  public static Vector4 Project(Vector4 a, Vector4 b)
  {
    return b * (Vector4.Dot(a, b) / Vector4.Dot(b, b));
  }

  public static Vector4 positiveInfinity => Vector4.positiveInfinityVector;

  public static Vector4 negativeInfinity => Vector4.negativeInfinityVector;

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static float SqrMagnitude(Vector4 a) => Vector4.Dot(a, a);

  public float SqrMagnitude() => Vector4.Dot(this, this);
}
