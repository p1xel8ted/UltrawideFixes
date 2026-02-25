// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bounds
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
public struct Bounds
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Center;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Extents;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_extents_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Expand_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_byref_Bounds_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPoint_Injected_Private_Static_Void_byref_Bounds_byref_Vector3_byref_Vector3_0;
  [FieldOffset(0)]
  public Vector3 m_Center;
  [FieldOffset(12)]
  public Vector3 m_Extents;
  private static readonly Bounds.SqrDistance_InjectedDelegate SqrDistance_InjectedDelegateField;
  private static readonly Bounds.IntersectRayAABB_InjectedDelegate IntersectRayAABB_InjectedDelegateField;

  static Bounds()
  {
    Il2CppClassPointerStore<Bounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Bounds));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bounds>.NativeClassPtr);
    Bounds.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, nameof (m_Center));
    Bounds.NativeFieldInfoPtr_m_Extents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bounds>.NativeClassPtr, nameof (m_Extents));
    Bounds.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664441);
    Bounds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664442);
    Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664443);
    Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664444);
    Bounds.NativeMethodInfoPtr_get_center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664445);
    Bounds.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664446);
    Bounds.NativeMethodInfoPtr_get_size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664447);
    Bounds.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664448 /*0x06000480*/);
    Bounds.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664449);
    Bounds.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664450);
    Bounds.NativeMethodInfoPtr_get_min_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664451);
    Bounds.NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664452);
    Bounds.NativeMethodInfoPtr_get_max_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664453);
    Bounds.NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664454);
    Bounds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664455);
    Bounds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664456);
    Bounds.NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664457);
    Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664458);
    Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664459);
    Bounds.NativeMethodInfoPtr_Expand_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664460);
    Bounds.NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664461);
    Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664462);
    Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664463);
    Bounds.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664464 /*0x06000490*/);
    Bounds.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664465);
    Bounds.NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_byref_Bounds_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664466);
    Bounds.NativeMethodInfoPtr_ClosestPoint_Injected_Private_Static_Void_byref_Bounds_byref_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bounds>.NativeClassPtr, 100664467);
    Bounds.SqrDistance_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.SqrDistance_InjectedDelegate>("UnityEngine.Bounds::SqrDistance_Injected");
    Bounds.IntersectRayAABB_InjectedDelegateField = IL2CPP.ResolveICall<Bounds.IntersectRayAABB_InjectedDelegate>("UnityEngine.Bounds::IntersectRayAABB_Injected");
  }

  [CallerCount(0)]
  public unsafe Bounds(Vector3 center, Vector3 size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &center;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421723, XrefRangeEnd = 421729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421729, XrefRangeEnd = 421732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Bounds other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Bounds_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Vector3 center
  {
    [CallerCount(60), CachedScanResults(RefRangeStart = 421732, RefRangeEnd = 421792, XrefRangeStart = 421732, XrefRangeEnd = 421732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_center_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 327327, RefRangeEnd = 327335, XrefRangeStart = 327327, XrefRangeEnd = 327335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_center_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 size
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_size_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 extents
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 421792, RefRangeEnd = 421820, XrefRangeStart = 421792, XrefRangeEnd = 421792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_extents_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 421820, RefRangeEnd = 421826, XrefRangeStart = 421820, XrefRangeEnd = 421820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_extents_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 min
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_min_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_min_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 max
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_get_max_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_set_max_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Bounds lhs, Bounds rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Bounds_Bounds_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(Bounds lhs, Bounds rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Bounds_Bounds_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe void SetMinMax(Vector3 min, Vector3 max)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &min;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_SetMinMax_Public_Void_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 421826, RefRangeEnd = 421828, XrefRangeStart = 421826, XrefRangeEnd = 421826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encapsulate(Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 421830, RefRangeEnd = 421833, XrefRangeStart = 421828, XrefRangeEnd = 421830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encapsulate(Bounds bounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &bounds
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Encapsulate_Public_Void_Bounds_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 421833, RefRangeEnd = 421835, XrefRangeStart = 421833, XrefRangeEnd = 421833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Expand(float amount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &amount
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Expand_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 421835, RefRangeEnd = 421837, XrefRangeStart = 421835, XrefRangeEnd = 421835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Intersects(Bounds bounds)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &bounds
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Intersects_Public_Boolean_Bounds_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421837, XrefRangeEnd = 421838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421838, XrefRangeEnd = 421861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421863, RefRangeEnd = 421864, XrefRangeStart = 421861, XrefRangeEnd = 421863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Contains(Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421866, RefRangeEnd = 421867, XrefRangeStart = 421864, XrefRangeEnd = 421866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 ClosestPoint(Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ClosestPoint_Public_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421867, XrefRangeEnd = 421869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Contains_Injected(ref Bounds _unity_self, [In] ref Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref point;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_Contains_Injected_Private_Static_Boolean_byref_Bounds_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421869, XrefRangeEnd = 421871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ClosestPoint_Injected(
    ref Bounds _unity_self,
    [In] ref Vector3 point,
    out Vector3 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref _unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref point;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Bounds.NativeMethodInfoPtr_ClosestPoint_Injected_Private_Static_Void_byref_Bounds_byref_Vector3_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Bounds>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public void Expand(Vector3 amount) => this.extents += amount * 0.5f;

  public bool IntersectRay(Ray ray) => Bounds.IntersectRayAABB(ray, this, out float _);

  public bool IntersectRay(Ray ray, out float distance)
  {
    return Bounds.IntersectRayAABB(ray, this, out distance);
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public float SqrDistance(Vector3 point) => Bounds.SqrDistance_Injected(ref this, ref point);

  public static bool IntersectRayAABB(Ray ray, Bounds bounds, out float dist)
  {
    return Bounds.IntersectRayAABB_Injected(ref ray, ref bounds, out dist);
  }

  public static float SqrDistance_Injected(ref Bounds _unity_self, [In] ref Vector3 point)
  {
    return Bounds.SqrDistance_InjectedDelegateField((System.IntPtr) ref _unity_self, (System.IntPtr) ref point);
  }

  public static bool IntersectRayAABB_Injected([In] ref Ray ray, [In] ref Bounds bounds, out float dist)
  {
    return Bounds.IntersectRayAABB_InjectedDelegateField((System.IntPtr) ref ray, (System.IntPtr) ref bounds, (System.IntPtr) ref dist);
  }

  private delegate float SqrDistance_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr point);

  private delegate bool IntersectRayAABB_InjectedDelegate([In] System.IntPtr ray, [In] System.IntPtr bounds, [Out] System.IntPtr dist);
}
