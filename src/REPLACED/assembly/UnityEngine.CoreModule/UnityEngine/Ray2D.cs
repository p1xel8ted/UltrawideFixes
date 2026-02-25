// Decompiled with JetBrains decompiler
// Type: UnityEngine.Ray2D
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
public struct Ray2D
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Origin;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Direction;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_origin_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_origin_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_direction_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_direction_Public_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  [FieldOffset(0)]
  public Vector2 m_Origin;
  [FieldOffset(8)]
  public Vector2 m_Direction;

  static Ray2D()
  {
    Il2CppClassPointerStore<Ray2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Ray2D));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ray2D>.NativeClassPtr);
    Ray2D.NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, nameof (m_Origin));
    Ray2D.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, nameof (m_Direction));
    Ray2D.NativeMethodInfoPtr_get_origin_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664508);
    Ray2D.NativeMethodInfoPtr_set_origin_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664509);
    Ray2D.NativeMethodInfoPtr_get_direction_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664510);
    Ray2D.NativeMethodInfoPtr_set_direction_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664511);
    Ray2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664512 /*0x060004C0*/);
    Ray2D.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, 100664513);
  }

  public unsafe Vector2 origin
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 422045, RefRangeEnd = 422049, XrefRangeStart = 422045, XrefRangeEnd = 422045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_get_origin_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(65), CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_set_origin_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector2 direction
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 422049, RefRangeEnd = 422050, XrefRangeStart = 422049, XrefRangeEnd = 422049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_get_direction_Public_get_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422050, XrefRangeEnd = 422051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_set_direction_Public_set_Void_Vector2_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422051, XrefRangeEnd = 422052, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422052, XrefRangeEnd = 422075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray2D.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Ray2D>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public Vector2 GetPoint(float distance) => this.m_Origin + this.m_Direction * distance;

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);
}
