// Decompiled with JetBrains decompiler
// Type: UnityEngine.Ray
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
public struct Ray
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Origin;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Direction;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_origin_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_origin_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_direction_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_direction_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  [FieldOffset(0)]
  public Vector3 m_Origin;
  [FieldOffset(12)]
  public Vector3 m_Direction;

  static Ray()
  {
    Il2CppClassPointerStore<Ray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Ray));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ray>.NativeClassPtr);
    Ray.NativeFieldInfoPtr_m_Origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, nameof (m_Origin));
    Ray.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, nameof (m_Direction));
    Ray.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664500);
    Ray.NativeMethodInfoPtr_get_origin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664501);
    Ray.NativeMethodInfoPtr_set_origin_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664502);
    Ray.NativeMethodInfoPtr_get_direction_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664503);
    Ray.NativeMethodInfoPtr_set_direction_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664504);
    Ray.NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664505);
    Ray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664506);
    Ray.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100664507);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422012, XrefRangeEnd = 422013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Ray(Vector3 origin, Vector3 direction)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &direction;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 origin
  {
    [CallerCount(60), CachedScanResults(RefRangeStart = 421732, RefRangeEnd = 421792, XrefRangeStart = 421732, XrefRangeEnd = 421792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_get_origin_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_set_origin_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 direction
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 421792, RefRangeEnd = 421820, XrefRangeStart = 421792, XrefRangeEnd = 421820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_get_direction_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422013, XrefRangeEnd = 422014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_set_direction_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 422014, RefRangeEnd = 422021, XrefRangeStart = 422014, XrefRangeEnd = 422014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetPoint(float distance)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &distance
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_GetPoint_Public_Vector3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422021, XrefRangeEnd = 422022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422022, XrefRangeEnd = 422045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Ray>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);
}
