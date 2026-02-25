// Decompiled with JetBrains decompiler
// Type: UnityEngine.Plane
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
public struct Plane
{
  private static readonly System.IntPtr NativeFieldInfoPtr_size;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Normal;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Distance;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_normal_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_distance_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClosestPointOnPlane_Public_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  [FieldOffset(0)]
  public Vector3 m_Normal;
  [FieldOffset(12)]
  public float m_Distance;

  static Plane()
  {
    Il2CppClassPointerStore<Plane>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Plane));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Plane>.NativeClassPtr);
    Plane.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, nameof (size));
    Plane.NativeFieldInfoPtr_m_Normal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, nameof (m_Normal));
    Plane.NativeFieldInfoPtr_m_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Plane>.NativeClassPtr, nameof (m_Distance));
    Plane.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664491);
    Plane.NativeMethodInfoPtr_get_distance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664492);
    Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664493);
    Plane.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664494);
    Plane.NativeMethodInfoPtr_ClosestPointOnPlane_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664495);
    Plane.NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664496 /*0x060004B0*/);
    Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664497);
    Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664498);
    Plane.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Plane>.NativeClassPtr, 100664499);
  }

  public unsafe Vector3 normal
  {
    [CallerCount(60), CachedScanResults(RefRangeStart = 421732, RefRangeEnd = 421792, XrefRangeStart = 421732, XrefRangeEnd = 421792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_normal_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Normal = value;
  }

  public unsafe float distance
  {
    [CallerCount(36), CachedScanResults(RefRangeStart = 416131, RefRangeEnd = 416167, XrefRangeStart = 416131, XrefRangeEnd = 416167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_get_distance_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Distance = value;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421984, XrefRangeEnd = 421985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Plane(Vector3 inNormal, Vector3 inPoint)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &inNormal;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inPoint;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void Translate(Vector3 translation)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &translation
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe Vector3 ClosestPointOnPlane(Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ClosestPointOnPlane_Public_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe float GetDistanceToPoint(Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_GetDistanceToPoint_Public_Single_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 421987, RefRangeEnd = 421988, XrefRangeStart = 421985, XrefRangeEnd = 421987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Raycast(Ray ray, out float enter)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ray;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref enter;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_Raycast_Public_Boolean_Ray_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421988, XrefRangeEnd = 421989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421989, XrefRangeEnd = 422012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Plane.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Plane>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe int size
  {
    get
    {
      int size;
      IL2CPP.il2cpp_field_static_get_value(Plane.NativeFieldInfoPtr_size, (void*) &size);
      return size;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Plane.NativeFieldInfoPtr_size, (void*) &value);
    }
  }

  public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint)
  {
    this.m_Normal = Vector3.Normalize(inNormal);
    this.m_Distance = -Vector3.Dot(this.m_Normal, inPoint);
  }

  public void Set3Points(Vector3 a, Vector3 b, Vector3 c)
  {
    this.m_Normal = Vector3.Normalize(Vector3.Cross(b - a, c - a));
    this.m_Distance = -Vector3.Dot(this.m_Normal, a);
  }

  public void Flip()
  {
    this.m_Normal = -this.m_Normal;
    this.m_Distance = -this.m_Distance;
  }

  public Plane flipped => new Plane(-this.m_Normal, -this.m_Distance);

  public static Plane Translate(Plane plane, Vector3 translation)
  {
    return new Plane(plane.m_Normal, plane.m_Distance += Vector3.Dot(plane.m_Normal, translation));
  }

  public bool GetSide(Vector3 point)
  {
    return (double) Vector3.Dot(this.m_Normal, point) + (double) this.m_Distance > 0.0;
  }

  public bool SameSide(Vector3 inPt0, Vector3 inPt1)
  {
    float distanceToPoint1 = this.GetDistanceToPoint(inPt0);
    float distanceToPoint2 = this.GetDistanceToPoint(inPt1);
    return (double) distanceToPoint1 > 0.0 && (double) distanceToPoint2 > 0.0 || (double) distanceToPoint1 <= 0.0 && (double) distanceToPoint2 <= 0.0;
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);
}
