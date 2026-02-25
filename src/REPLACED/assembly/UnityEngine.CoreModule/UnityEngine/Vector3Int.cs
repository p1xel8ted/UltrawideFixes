// Decompiled with JetBrains decompiler
// Type: UnityEngine.Vector3Int
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
public struct Vector3Int
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_X;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Y;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Z;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Zero;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_One;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Up;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Down;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Left;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Right;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Forward;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_Back;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_z_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0;
  [FieldOffset(0)]
  public int m_X;
  [FieldOffset(4)]
  public int m_Y;
  [FieldOffset(8)]
  public int m_Z;

  static Vector3Int()
  {
    Il2CppClassPointerStore<Vector3Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Vector3Int));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr);
    Vector3Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (m_X));
    Vector3Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (m_Y));
    Vector3Int.NativeFieldInfoPtr_m_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (m_Z));
    Vector3Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (s_Zero));
    Vector3Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (s_One));
    Vector3Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (s_Up));
    Vector3Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (s_Down));
    Vector3Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (s_Left));
    Vector3Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (s_Right));
    Vector3Int.NativeFieldInfoPtr_s_Forward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (s_Forward));
    Vector3Int.NativeFieldInfoPtr_s_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, nameof (s_Back));
    Vector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667606);
    Vector3Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667607);
    Vector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667608);
    Vector3Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667609);
    Vector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667610);
    Vector3Int.NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667611);
    Vector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667612);
    Vector3Int.NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667613);
    Vector3Int.NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667614);
    Vector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667615);
    Vector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667616 /*0x060010E0*/);
    Vector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667617);
    Vector3Int.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667618);
    Vector3Int.NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667619);
    Vector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667620);
    Vector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667621);
    Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667622);
    Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667623);
    Vector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667624);
    Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667625);
    Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667626);
    Vector3Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667627);
    Vector3Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, 100667628);
  }

  public unsafe int x
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int y
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 328510, RefRangeEnd = 328569, XrefRangeStart = 328510, XrefRangeEnd = 328569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int z
  {
    [CallerCount(34), CachedScanResults(RefRangeStart = 327541, RefRangeEnd = 327575, XrefRangeStart = 327541, XrefRangeEnd = 327575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_z_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 147413, RefRangeEnd = 147418, XrefRangeStart = 147413, XrefRangeEnd = 147418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_set_z_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 148719, RefRangeEnd = 148721, XrefRangeStart = 148719, XrefRangeEnd = 148721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3Int(int x, int y, int z)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe Vector3Int Min(Vector3Int lhs, Vector3Int rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Min_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3Int Max(Vector3Int lhs, Vector3Int rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Max_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe implicit operator Vector3(Vector3Int v)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &v
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector3_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3Int operator +(Vector3Int a, Vector3Int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Addition_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3Int operator -(Vector3Int a, Vector3Int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Subtraction_Public_Static_Vector3Int_Vector3Int_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3Int operator *(Vector3Int a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Multiply_Public_Static_Vector3Int_Vector3Int_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Vector3Int operator /(Vector3Int a, int b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Division_Public_Static_Vector3Int_Vector3Int_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Vector3Int lhs, Vector3Int rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector3Int_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(Vector3Int lhs, Vector3Int rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector3Int_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441233, XrefRangeEnd = 441236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Vector3Int other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector3Int_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 441239, RefRangeEnd = 441243, XrefRangeStart = 441236, XrefRangeEnd = 441239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441243, XrefRangeEnd = 441244, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441244, XrefRangeEnd = 441260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public static unsafe Vector3Int zero
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441260, XrefRangeEnd = 441262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe Vector3Int one
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441262, XrefRangeEnd = 441264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vector3Int.NativeMethodInfoPtr_get_one_Public_Static_get_Vector3Int_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector3Int>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe Vector3Int s_Zero
  {
    get
    {
      Vector3Int sZero;
      IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Zero, (void*) &sZero);
      return sZero;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Zero, (void*) &value);
    }
  }

  public static unsafe Vector3Int s_One
  {
    get
    {
      Vector3Int sOne;
      IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_One, (void*) &sOne);
      return sOne;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_One, (void*) &value);
    }
  }

  public static unsafe Vector3Int s_Up
  {
    get
    {
      Vector3Int sUp;
      IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Up, (void*) &sUp);
      return sUp;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Up, (void*) &value);
    }
  }

  public static unsafe Vector3Int s_Down
  {
    get
    {
      Vector3Int sDown;
      IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Down, (void*) &sDown);
      return sDown;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Down, (void*) &value);
    }
  }

  public static unsafe Vector3Int s_Left
  {
    get
    {
      Vector3Int sLeft;
      IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Left, (void*) &sLeft);
      return sLeft;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Left, (void*) &value);
    }
  }

  public static unsafe Vector3Int s_Right
  {
    get
    {
      Vector3Int sRight;
      IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Right, (void*) &sRight);
      return sRight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Right, (void*) &value);
    }
  }

  public static unsafe Vector3Int s_Forward
  {
    get
    {
      Vector3Int sForward;
      IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Forward, (void*) &sForward);
      return sForward;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Forward, (void*) &value);
    }
  }

  public static unsafe Vector3Int s_Back
  {
    get
    {
      Vector3Int sBack;
      IL2CPP.il2cpp_field_static_get_value(Vector3Int.NativeFieldInfoPtr_s_Back, (void*) &sBack);
      return sBack;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Vector3Int.NativeFieldInfoPtr_s_Back, (void*) &value);
    }
  }

  public void Set(int x, int y, int z)
  {
    this.m_X = x;
    this.m_Y = y;
    this.m_Z = z;
  }

  public int this[int index]
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public float magnitude
  {
    get => Mathf.Sqrt((float) (this.x * this.x + this.y * this.y + this.z * this.z));
  }

  public int sqrMagnitude => this.x * this.x + this.y * this.y + this.z * this.z;

  public static float Distance(Vector3Int a, Vector3Int b) => (a - b).magnitude;

  public static Vector3Int Scale(Vector3Int a, Vector3Int b)
  {
    return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);
  }

  public void Scale(Vector3Int scale)
  {
    this.x *= scale.x;
    this.y *= scale.y;
    this.z *= scale.z;
  }

  public void Clamp(Vector3Int min, Vector3Int max)
  {
    this.x = Il2CppSystem.Math.Max(min.x, this.x);
    this.x = Il2CppSystem.Math.Min(max.x, this.x);
    this.y = Il2CppSystem.Math.Max(min.y, this.y);
    this.y = Il2CppSystem.Math.Min(max.y, this.y);
    this.z = Il2CppSystem.Math.Max(min.z, this.z);
    this.z = Il2CppSystem.Math.Min(max.z, this.z);
  }

  public static explicit operator Vector2Int(Vector3Int v) => new Vector2Int(v.x, v.y);

  public static Vector3Int FloorToInt(Vector3 v)
  {
    return new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
  }

  public static Vector3Int CeilToInt(Vector3 v)
  {
    return new Vector3Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z));
  }

  public static Vector3Int RoundToInt(Vector3 v)
  {
    return new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));
  }

  public static Vector3Int operator *(Vector3Int a, Vector3Int b)
  {
    return new Vector3Int(a.x * b.x, a.y * b.y, a.z * b.z);
  }

  public static Vector3Int operator -(Vector3Int a) => new Vector3Int(-a.x, -a.y, -a.z);

  public static Vector3Int operator *(int a, Vector3Int b)
  {
    return new Vector3Int(a * b.x, a * b.y, a * b.z);
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static Vector3Int up => Vector3Int.s_Up;

  public static Vector3Int down => Vector3Int.s_Down;

  public static Vector3Int left => Vector3Int.s_Left;

  public static Vector3Int right => Vector3Int.s_Right;

  public static Vector3Int forward => Vector3Int.s_Forward;

  public static Vector3Int back => Vector3Int.s_Back;
}
