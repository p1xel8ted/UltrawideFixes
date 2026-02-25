// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rect
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
public struct Rect
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_XMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_YMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Width;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Height;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_xMin_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_yMin_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_xMax_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_yMax_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  [FieldOffset(0)]
  public float m_XMin;
  [FieldOffset(4)]
  public float m_YMin;
  [FieldOffset(8)]
  public float m_Width;
  [FieldOffset(12)]
  public float m_Height;

  static Rect()
  {
    Il2CppClassPointerStore<Rect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Rect));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rect>.NativeClassPtr);
    Rect.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, nameof (m_XMin));
    Rect.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, nameof (m_YMin));
    Rect.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, nameof (m_Width));
    Rect.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, nameof (m_Height));
    Rect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664514);
    Rect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664515);
    Rect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664516);
    Rect.NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664517);
    Rect.NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664518);
    Rect.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664519);
    Rect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664520);
    Rect.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664521);
    Rect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664522);
    Rect.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664523);
    Rect.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664524);
    Rect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664525);
    Rect.NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664526);
    Rect.NativeMethodInfoPtr_get_min_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664527);
    Rect.NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664528 /*0x060004D0*/);
    Rect.NativeMethodInfoPtr_get_max_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664529);
    Rect.NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664530);
    Rect.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664531);
    Rect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664532);
    Rect.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664533);
    Rect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664534);
    Rect.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664535);
    Rect.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664536);
    Rect.NativeMethodInfoPtr_get_xMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664537);
    Rect.NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664538);
    Rect.NativeMethodInfoPtr_get_yMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664539);
    Rect.NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664540);
    Rect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664541);
    Rect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664542);
    Rect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664543);
    Rect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664544 /*0x060004E0*/);
    Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664545);
    Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664546);
    Rect.NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664547);
    Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664548);
    Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664549);
    Rect.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664550);
    Rect.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664551);
    Rect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664552);
    Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664553);
    Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664554);
    Rect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664555);
    Rect.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664556);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 245806, RefRangeEnd = 245814, XrefRangeStart = 245806, XrefRangeEnd = 245814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Rect(float x, float y, float width, float height)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe Rect(Vector2 position, Vector2 size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe Rect(Rect source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &source
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Rect zero
  {
    [CallerCount(37), CachedScanResults(RefRangeStart = 422075, RefRangeEnd = 422112, XrefRangeStart = 422075, XrefRangeEnd = 422075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public static unsafe Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &xmin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &ymin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &xmax;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ymax;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float x
  {
    [CallerCount(113), CachedScanResults(RefRangeStart = 415878, RefRangeEnd = 415991, XrefRangeStart = 415878, XrefRangeEnd = 415991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_x_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(43), CachedScanResults(RefRangeStart = 70541, RefRangeEnd = 70584, XrefRangeStart = 70541, XrefRangeEnd = 70584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float y
  {
    [CallerCount(95), CachedScanResults(RefRangeStart = 415991, RefRangeEnd = 416086, XrefRangeStart = 415991, XrefRangeEnd = 416086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_y_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(22), CachedScanResults(RefRangeStart = 400905, RefRangeEnd = 400927, XrefRangeStart = 400905, XrefRangeEnd = 400927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 position
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 422045, RefRangeEnd = 422049, XrefRangeStart = 422045, XrefRangeEnd = 422049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 center
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 min
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_min_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 max
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_max_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float width
  {
    [CallerCount(45), CachedScanResults(RefRangeStart = 416086, RefRangeEnd = 416131, XrefRangeStart = 416086, XrefRangeEnd = 416131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_width_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(13), CachedScanResults(RefRangeStart = 400927, RefRangeEnd = 400940, XrefRangeStart = 400927, XrefRangeEnd = 400940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float height
  {
    [CallerCount(36), CachedScanResults(RefRangeStart = 416131, RefRangeEnd = 416167, XrefRangeStart = 416131, XrefRangeEnd = 416167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_height_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(11), CachedScanResults(RefRangeStart = 400940, RefRangeEnd = 400951, XrefRangeStart = 400940, XrefRangeEnd = 400951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 size
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 422049, RefRangeEnd = 422050, XrefRangeStart = 422049, XrefRangeEnd = 422050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float xMin
  {
    [CallerCount(113), CachedScanResults(RefRangeStart = 415878, RefRangeEnd = 415991, XrefRangeStart = 415878, XrefRangeEnd = 415991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_xMin_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float yMin
  {
    [CallerCount(95), CachedScanResults(RefRangeStart = 415991, RefRangeEnd = 416086, XrefRangeStart = 415991, XrefRangeEnd = 416086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_yMin_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float xMax
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float yMax
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 422112, RefRangeEnd = 422113, XrefRangeStart = 422112, XrefRangeEnd = 422112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Contains(Vector2 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe bool Contains(Vector3 point)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &point
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Rect OrderMinMax(Rect rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rect
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe bool Overlaps(Rect other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 422114, RefRangeEnd = 422116, XrefRangeStart = 422113, XrefRangeEnd = 422114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Overlaps(Rect other, bool allowInverse)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &other;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &allowInverse;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator !=(Rect lhs, Rect rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(Rect lhs, Rect rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 422120, RefRangeEnd = 422124, XrefRangeStart = 422116, XrefRangeEnd = 422120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422124, XrefRangeEnd = 422131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 422135, RefRangeEnd = 422137, XrefRangeStart = 422131, XrefRangeEnd = 422135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Rect other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422137, XrefRangeEnd = 422138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 422159, RefRangeEnd = 422164, XrefRangeStart = 422138, XrefRangeEnd = 422159, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Rect>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public void Set(float x, float y, float width, float height)
  {
    this.m_XMin = x;
    this.m_YMin = y;
    this.m_Width = width;
    this.m_Height = height;
  }

  public bool Contains(Vector3 point, bool allowInverse)
  {
    return !allowInverse ? this.Contains(point) : ((double) this.width < 0.0 && (double) point.x <= (double) this.xMin && (double) point.x > (double) this.xMax || (double) this.width >= 0.0 && (double) point.x >= (double) this.xMin && (double) point.x < (double) this.xMax) & ((double) this.height < 0.0 && (double) point.y <= (double) this.yMin && (double) point.y > (double) this.yMax || (double) this.height >= 0.0 && (double) point.y >= (double) this.yMin && (double) point.y < (double) this.yMax);
  }

  public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates)
  {
    return new Vector2(Mathf.Lerp(rectangle.x, rectangle.xMax, normalizedRectCoordinates.x), Mathf.Lerp(rectangle.y, rectangle.yMax, normalizedRectCoordinates.y));
  }

  public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
  {
    return new Vector2(Mathf.InverseLerp(rectangle.x, rectangle.xMax, point.x), Mathf.InverseLerp(rectangle.y, rectangle.yMax, point.y));
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public float left => this.m_XMin;

  public float right => this.m_XMin + this.m_Width;

  public float top => this.m_YMin;

  public float bottom => this.m_YMin + this.m_Height;
}
