// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.FrameRate
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct FrameRate
{
  private static readonly System.IntPtr NativeFieldInfoPtr_k_24Fps;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_23_976Fps;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_25Fps;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_30Fps;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_29_97Fps;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_50Fps;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_60Fps;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_59_94Fps;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Rate;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rate_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0;
  [FieldOffset(0)]
  public int m_Rate;

  static FrameRate()
  {
    Il2CppClassPointerStore<FrameRate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (FrameRate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameRate>.NativeClassPtr);
    FrameRate.NativeFieldInfoPtr_k_24Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (k_24Fps));
    FrameRate.NativeFieldInfoPtr_k_23_976Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (k_23_976Fps));
    FrameRate.NativeFieldInfoPtr_k_25Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (k_25Fps));
    FrameRate.NativeFieldInfoPtr_k_30Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (k_30Fps));
    FrameRate.NativeFieldInfoPtr_k_29_97Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (k_29_97Fps));
    FrameRate.NativeFieldInfoPtr_k_50Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (k_50Fps));
    FrameRate.NativeFieldInfoPtr_k_60Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (k_60Fps));
    FrameRate.NativeFieldInfoPtr_k_59_94Fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (k_59_94Fps));
    FrameRate.NativeFieldInfoPtr_m_Rate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, nameof (m_Rate));
    FrameRate.NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669362);
    FrameRate.NativeMethodInfoPtr_get_rate_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669363);
    FrameRate.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669364);
    FrameRate.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669365);
    FrameRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669366);
    FrameRate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669367);
    FrameRate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669368);
    FrameRate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669369);
    FrameRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669370);
    FrameRate.NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669371);
    FrameRate.NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, 100669372);
  }

  public unsafe bool dropFrame
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 479896, RefRangeEnd = 479897, XrefRangeStart = 479896, XrefRangeEnd = 479896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_get_dropFrame_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe double rate
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 479900, RefRangeEnd = 479902, XrefRangeStart = 479897, XrefRangeEnd = 479900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_get_rate_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public unsafe FrameRate(uint frameRate = 0, bool drop = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &frameRate;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &drop;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr__ctor_Public_Void_UInt32_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479902, RefRangeEnd = 479903, XrefRangeStart = 479902, XrefRangeEnd = 479902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(FrameRate other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FrameRate_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479903, XrefRangeEnd = 479908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 479911, RefRangeEnd = 479919, XrefRangeStart = 479908, XrefRangeEnd = 479911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(FrameRate a, FrameRate b)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &a;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FrameRate_FrameRate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(239)]
  [CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479919, XrefRangeEnd = 479932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479958, RefRangeEnd = 479959, XrefRangeStart = 479932, XrefRangeEnd = 479958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_ToString_Public_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479973, RefRangeEnd = 479974, XrefRangeStart = 479959, XrefRangeEnd = 479973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe FrameRate DoubleToFrameRate(double framerate)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &framerate
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameRate.NativeMethodInfoPtr_DoubleToFrameRate_Internal_Static_FrameRate_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(FrameRate*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameRate>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe FrameRate k_24Fps
  {
    get
    {
      FrameRate k24Fps;
      IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_24Fps, (void*) &k24Fps);
      return k24Fps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_24Fps, (void*) &value);
    }
  }

  public static unsafe FrameRate k_23_976Fps
  {
    get
    {
      FrameRate k23976Fps;
      IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_23_976Fps, (void*) &k23976Fps);
      return k23976Fps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_23_976Fps, (void*) &value);
    }
  }

  public static unsafe FrameRate k_25Fps
  {
    get
    {
      FrameRate k25Fps;
      IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_25Fps, (void*) &k25Fps);
      return k25Fps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_25Fps, (void*) &value);
    }
  }

  public static unsafe FrameRate k_30Fps
  {
    get
    {
      FrameRate k30Fps;
      IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_30Fps, (void*) &k30Fps);
      return k30Fps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_30Fps, (void*) &value);
    }
  }

  public static unsafe FrameRate k_29_97Fps
  {
    get
    {
      FrameRate k2997Fps;
      IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_29_97Fps, (void*) &k2997Fps);
      return k2997Fps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_29_97Fps, (void*) &value);
    }
  }

  public static unsafe FrameRate k_50Fps
  {
    get
    {
      FrameRate k50Fps;
      IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_50Fps, (void*) &k50Fps);
      return k50Fps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_50Fps, (void*) &value);
    }
  }

  public static unsafe FrameRate k_60Fps
  {
    get
    {
      FrameRate k60Fps;
      IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_60Fps, (void*) &k60Fps);
      return k60Fps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_60Fps, (void*) &value);
    }
  }

  public static unsafe FrameRate k_59_94Fps
  {
    get
    {
      FrameRate k5994Fps;
      IL2CPP.il2cpp_field_static_get_value(FrameRate.NativeFieldInfoPtr_k_59_94Fps, (void*) &k5994Fps);
      return k5994Fps;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FrameRate.NativeFieldInfoPtr_k_59_94Fps, (void*) &value);
    }
  }

  public static bool operator !=(FrameRate a, FrameRate b) => !a.Equals(b);

  public static bool operator <(FrameRate a, FrameRate b) => a.rate < b.rate;

  public static bool operator <=(FrameRate a, FrameRate b) => a.rate <= b.rate;

  public static bool operator >(FrameRate a, FrameRate b) => a.rate > b.rate;

  public static bool operator >=(FrameRate a, FrameRate b) => a.rate <= b.rate;

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static int FrameRateToInt(FrameRate framerate) => framerate.m_Rate;
}
