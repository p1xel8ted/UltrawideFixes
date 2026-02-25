// Decompiled with JetBrains decompiler
// Type: UnityEngine.Vector2Int
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
public struct Vector2Int
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_X;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Y;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Zero;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_One;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Up;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Down;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Left;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Right;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_magnitude_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CeilToInt_Public_Static_Vector2Int_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RoundToInt_Public_Static_Vector2Int_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector2Int_Vector2Int_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2Int_Vector2Int_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector2Int_Vector2Int_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_up_Public_Static_get_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_right_Public_Static_get_Vector2Int_0;
  [FieldOffset(0)]
  public int m_X;
  [FieldOffset(4)]
  public int m_Y;

  static Vector2Int()
  {
    Il2CppClassPointerStore<Vector2Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Vector2Int));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr);
    Vector2Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, nameof (m_X));
    Vector2Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, nameof (m_Y));
    Vector2Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, nameof (s_Zero));
    Vector2Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, nameof (s_One));
    Vector2Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, nameof (s_Up));
    Vector2Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, nameof (s_Down));
    Vector2Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, nameof (s_Left));
    Vector2Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, nameof (s_Right));
    Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667580);
    Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667581);
    Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667582);
    Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667583);
    Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667584 /*0x060010C0*/);
    Vector2Int.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667585);
    Vector2Int.NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667586);
    Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667587);
    Vector2Int.NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667588);
    Vector2Int.NativeMethodInfoPtr_CeilToInt_Public_Static_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667589);
    Vector2Int.NativeMethodInfoPtr_RoundToInt_Public_Static_Vector2Int_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667590);
    Vector2Int.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2Int_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667591);
    Vector2Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2Int_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667592);
    Vector2Int.NativeMethodInfoPtr_op_Division_Public_Static_Vector2Int_Vector2Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667593);
    Vector2Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667594);
    Vector2Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667595);
    Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667596);
    Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667597);
    Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667598);
    Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667599);
    Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667600 /*0x060010D0*/);
    Vector2Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667601);
    Vector2Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667602);
    Vector2Int.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667603);
    Vector2Int.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100667604);
  }

  public unsafe int x
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int y
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 328510, RefRangeEnd = 328569, XrefRangeStart = 328510, XrefRangeEnd = 328569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(54)]
  [CachedScanResults(RefRangeStart = 94193, RefRangeEnd = 94247, XrefRangeStart = 94193, XrefRangeEnd = 94247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector2Int(int x, int y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float magnitude
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_magnitude_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe Vector2Int Max(Vector2Int lhs, Vector2Int rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Max_Public_Static_Vector2Int_Vector2Int_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe implicit operator Vector2(Vector2Int v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 305627, RefRangeEnd = 305629, XrefRangeStart = 305627, XrefRangeEnd = 305629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2Int FloorToInt(Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_FloorToInt_Public_Static_Vector2Int_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441184, XrefRangeEnd = 441192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2Int CeilToInt(Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_CeilToInt_Public_Static_Vector2Int_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441192, XrefRangeEnd = 441200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2Int RoundToInt(Vector2 v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_RoundToInt_Public_Static_Vector2Int_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2Int operator +(Vector2Int a, Vector2Int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Addition_Public_Static_Vector2Int_Vector2Int_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2Int operator -(Vector2Int a, Vector2Int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector2Int_Vector2Int_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector2Int operator /(Vector2Int a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Division_Public_Static_Vector2Int_Vector2Int_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Vector2Int lhs, Vector2Int rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(Vector2Int lhs, Vector2Int rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441200, XrefRangeEnd = 441203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Vector2Int other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441203, XrefRangeEnd = 441211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441211, XrefRangeEnd = 441225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public static unsafe Vector2Int zero
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441225, XrefRangeEnd = 441227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2Int one
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441227, XrefRangeEnd = 441229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2Int up
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441229, XrefRangeEnd = 441231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_up_Public_Static_get_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector2Int right
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441231, XrefRangeEnd = 441233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_right_Public_Static_get_Vector2Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe Vector2Int s_Zero
  {
    get
    {
      Vector2Int sZero;
      IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*) &sZero);
      return sZero;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*) &value);
    }
  }

  public static unsafe Vector2Int s_One
  {
    get
    {
      Vector2Int sOne;
      IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*) &sOne);
      return sOne;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*) &value);
    }
  }

  public static unsafe Vector2Int s_Up
  {
    get
    {
      Vector2Int sUp;
      IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*) &sUp);
      return sUp;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*) &value);
    }
  }

  public static unsafe Vector2Int s_Down
  {
    get
    {
      Vector2Int sDown;
      IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*) &sDown);
      return sDown;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*) &value);
    }
  }

  public static unsafe Vector2Int s_Left
  {
    get
    {
      Vector2Int sLeft;
      IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*) &sLeft);
      return sLeft;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*) &value);
    }
  }

  public static unsafe Vector2Int s_Right
  {
    get
    {
      Vector2Int sRight;
      IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*) &sRight);
      return sRight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*) &value);
    }
  }

  public void Set(int x, int y)
  {
    this.m_X = x;
    this.m_Y = y;
  }

  public int this[int index]
  {
    get
    {
      switch (index)
      {
        case 0:
          return this.x;
        case 1:
          return this.y;
        default:
          throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Format("Invalid Vector2Int index addressed: {0}!", (Il2CppSystem.Object) (System.ValueType) index));
      }
    }
    set
    {
      switch (index)
      {
        case 0:
          this.x = value;
          break;
        case 1:
          this.y = value;
          break;
        default:
          throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Format("Invalid Vector2Int index addressed: {0}!", (Il2CppSystem.Object) (System.ValueType) index));
      }
    }
  }

  public int sqrMagnitude => this.x * this.x + this.y * this.y;

  public static float Distance(Vector2Int a, Vector2Int b)
  {
    float num1 = (float) (a.x - b.x);
    float num2 = (float) (a.y - b.y);
    return (float) Il2CppSystem.Math.Sqrt((double) num1 * (double) num1 + (double) num2 * (double) num2);
  }

  public static Vector2Int Min(Vector2Int lhs, Vector2Int rhs)
  {
    return new Vector2Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
  }

  public static Vector2Int Scale(Vector2Int a, Vector2Int b)
  {
    return new Vector2Int(a.x * b.x, a.y * b.y);
  }

  public void Scale(Vector2Int scale)
  {
    this.x *= scale.x;
    this.y *= scale.y;
  }

  public void Clamp(Vector2Int min, Vector2Int max)
  {
    this.x = Il2CppSystem.Math.Max(min.x, this.x);
    this.x = Il2CppSystem.Math.Min(max.x, this.x);
    this.y = Il2CppSystem.Math.Max(min.y, this.y);
    this.y = Il2CppSystem.Math.Min(max.y, this.y);
  }

  public static explicit operator Vector3Int(Vector2Int v) => new Vector3Int(v.x, v.y, 0);

  public static Vector2Int operator -(Vector2Int v) => new Vector2Int(-v.x, -v.y);

  public static Vector2Int operator *(Vector2Int a, Vector2Int b)
  {
    return new Vector2Int(a.x * b.x, a.y * b.y);
  }

  public static Vector2Int operator *(int a, Vector2Int b) => new Vector2Int(a * b.x, a * b.y);

  public static Vector2Int operator *(Vector2Int a, int b) => new Vector2Int(a.x * b, a.y * b);

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static Vector2Int down => Vector2Int.s_Down;

  public static Vector2Int left => Vector2Int.s_Left;
}
