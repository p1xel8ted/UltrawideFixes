// Decompiled with JetBrains decompiler
// Type: Unity.IntegerTime.RationalTime
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IntegerTime;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct RationalTime
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Count;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TicksPerSecond;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_RationalTime_0;
  [FieldOffset(0)]
  public long m_Count;
  [FieldOffset(8)]
  public RationalTime.TicksPerSecond m_TicksPerSecond;
  private static readonly RationalTime.FromDouble_InjectedDelegate FromDouble_InjectedDelegateField;

  static RationalTime()
  {
    Il2CppClassPointerStore<RationalTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IntegerTime", nameof (RationalTime));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RationalTime>.NativeClassPtr);
    RationalTime.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, nameof (m_Count));
    RationalTime.NativeFieldInfoPtr_m_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, nameof (m_TicksPerSecond));
    RationalTime.NativeMethodInfoPtr_get_Count_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, 100663365 /*0x06000045*/);
    RationalTime.NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, 100663366 /*0x06000046*/);
    RationalTime.FromDouble_InjectedDelegateField = IL2CPP.ResolveICall<RationalTime.FromDouble_InjectedDelegate>("Unity.IntegerTime.RationalTime::FromDouble_Injected");
  }

  public unsafe long Count
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RationalTime.NativeMethodInfoPtr_get_Count_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 413665, RefRangeEnd = 413671, XrefRangeStart = 413656, XrefRangeEnd = 413665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe explicit operator DiscreteTime(RationalTime t)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &t
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RationalTime.NativeMethodInfoPtr_op_Explicit_Public_Static_DiscreteTime_RationalTime_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(DiscreteTime*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public RationalTime.TicksPerSecond Ticks => this.m_TicksPerSecond;

  public static RationalTime FromDouble(double t, RationalTime.TicksPerSecond ticksPerSecond)
  {
    RationalTime ret;
    RationalTime.FromDouble_Injected(t, ref ticksPerSecond, out ret);
    return ret;
  }

  public static void FromDouble_Injected(
    double t,
    [In] ref RationalTime.TicksPerSecond ticksPerSecond,
    out RationalTime ret)
  {
    RationalTime.FromDouble_InjectedDelegateField(t, (System.IntPtr) ref ticksPerSecond, (System.IntPtr) ref ret);
  }

  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct TicksPerSecond
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Numerator;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Denominator;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultTicksPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond24;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond25;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond30;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond50;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond60;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond120;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond2397;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond2425;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond2997;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond5994;
    private static readonly System.IntPtr NativeFieldInfoPtr_TicksPerSecond11988;
    private static readonly System.IntPtr NativeFieldInfoPtr_DiscreteTimeRate;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TicksPerSecond_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Simplify_Private_Static_Void_byref_UInt32_byref_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Gcd_Private_Static_UInt32_UInt32_UInt32_0;
    [FieldOffset(0)]
    public uint m_Numerator;
    [FieldOffset(4)]
    public uint m_Denominator;

    static TicksPerSecond()
    {
      Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RationalTime>.NativeClassPtr, nameof (TicksPerSecond));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr);
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_m_Numerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (m_Numerator));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_m_Denominator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (m_Denominator));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_DefaultTicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (DefaultTicksPerSecond));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond24));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond25));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond30));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond50));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond60));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond120 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond120));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2397 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond2397));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2425 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond2425));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2997 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond2997));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond5994 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond5994));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond11988 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (TicksPerSecond11988));
      RationalTime.TicksPerSecond.NativeFieldInfoPtr_DiscreteTimeRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, nameof (DiscreteTimeRate));
      RationalTime.TicksPerSecond.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, 100663367 /*0x06000047*/);
      RationalTime.TicksPerSecond.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TicksPerSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, 100663368 /*0x06000048*/);
      RationalTime.TicksPerSecond.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, 100663369 /*0x06000049*/);
      RationalTime.TicksPerSecond.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, 100663370 /*0x0600004A*/);
      RationalTime.TicksPerSecond.NativeMethodInfoPtr_Simplify_Private_Static_Void_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, 100663371 /*0x0600004B*/);
      RationalTime.TicksPerSecond.NativeMethodInfoPtr_Gcd_Private_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, 100663372 /*0x0600004C*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413636, XrefRangeEnd = 413642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TicksPerSecond(uint num, uint den = 1)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &num;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &den;
      System.IntPtr num1;
      IL2CPP.il2cpp_runtime_invoke(RationalTime.TicksPerSecond.NativeMethodInfoPtr__ctor_Public_Void_UInt32_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
    }

    [CallerCount(0)]
    public virtual unsafe bool Equals(RationalTime.TicksPerSecond rhs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &rhs
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RationalTime.TicksPerSecond.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TicksPerSecond_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413642, XrefRangeEnd = 413647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object rhs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rhs)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RationalTime.TicksPerSecond.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413647, XrefRangeEnd = 413653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RationalTime.TicksPerSecond.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413653, XrefRangeEnd = 413656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Simplify(ref uint num, ref uint den)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref num;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref den;
      System.IntPtr num1;
      IL2CPP.il2cpp_runtime_invoke(RationalTime.TicksPerSecond.NativeMethodInfoPtr_Simplify_Private_Static_Void_byref_UInt32_byref_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
    }

    [CallerCount(0)]
    public static unsafe uint Gcd(uint a, uint b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RationalTime.TicksPerSecond.NativeMethodInfoPtr_Gcd_Private_Static_UInt32_UInt32_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RationalTime.TicksPerSecond>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe RationalTime.TicksPerSecond DefaultTicksPerSecond
    {
      get
      {
        RationalTime.TicksPerSecond defaultTicksPerSecond;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_DefaultTicksPerSecond, (void*) &defaultTicksPerSecond);
        return defaultTicksPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_DefaultTicksPerSecond, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond24
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond24;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond24, (void*) &ticksPerSecond24);
        return ticksPerSecond24;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond24, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond25
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond25;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond25, (void*) &ticksPerSecond25);
        return ticksPerSecond25;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond25, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond30
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond30;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond30, (void*) &ticksPerSecond30);
        return ticksPerSecond30;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond30, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond50
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond50;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond50, (void*) &ticksPerSecond50);
        return ticksPerSecond50;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond50, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond60
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond60;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond60, (void*) &ticksPerSecond60);
        return ticksPerSecond60;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond60, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond120
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond120;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond120, (void*) &ticksPerSecond120);
        return ticksPerSecond120;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond120, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond2397
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond2397;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2397, (void*) &ticksPerSecond2397);
        return ticksPerSecond2397;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2397, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond2425
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond2425;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2425, (void*) &ticksPerSecond2425);
        return ticksPerSecond2425;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2425, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond2997
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond2997;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2997, (void*) &ticksPerSecond2997);
        return ticksPerSecond2997;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond2997, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond5994
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond5994;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond5994, (void*) &ticksPerSecond5994);
        return ticksPerSecond5994;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond5994, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond TicksPerSecond11988
    {
      get
      {
        RationalTime.TicksPerSecond ticksPerSecond11988;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond11988, (void*) &ticksPerSecond11988);
        return ticksPerSecond11988;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_TicksPerSecond11988, (void*) &value);
      }
    }

    public static unsafe RationalTime.TicksPerSecond DiscreteTimeRate
    {
      get
      {
        RationalTime.TicksPerSecond discreteTimeRate;
        IL2CPP.il2cpp_field_static_get_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_DiscreteTimeRate, (void*) &discreteTimeRate);
        return discreteTimeRate;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RationalTime.TicksPerSecond.NativeFieldInfoPtr_DiscreteTimeRate, (void*) &value);
      }
    }
  }

  private delegate void FromDouble_InjectedDelegate(double t, [In] System.IntPtr ticksPerSecond, [Out] System.IntPtr ret);
}
