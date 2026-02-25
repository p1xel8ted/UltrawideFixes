// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Utils.NumString.G_FloatString
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Tayx.Graphy.Utils.NumString;

public static class G_FloatString : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_floatFormat;
  private static readonly System.IntPtr NativeFieldInfoPtr_decimalMultiplier;
  private static readonly System.IntPtr NativeFieldInfoPtr_negativeBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_positiveBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_Single_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToInt_Public_Static_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToFloat_Public_Static_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Pow_Private_Static_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToIndex_Private_Static_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromIndex_Private_Static_Single_Int32_0;

  static G_FloatString()
  {
    Il2CppClassPointerStore<G_FloatString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Utils.NumString", nameof (G_FloatString));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr);
    G_FloatString.NativeFieldInfoPtr_floatFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, nameof (floatFormat));
    G_FloatString.NativeFieldInfoPtr_decimalMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, nameof (decimalMultiplier));
    G_FloatString.NativeFieldInfoPtr_negativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, nameof (negativeBuffer));
    G_FloatString.NativeFieldInfoPtr_positiveBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, nameof (positiveBuffer));
    G_FloatString.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663531 /*0x060000EB*/);
    G_FloatString.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663532 /*0x060000EC*/);
    G_FloatString.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663533 /*0x060000ED*/);
    G_FloatString.NativeMethodInfoPtr_Init_Public_Static_Void_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663534 /*0x060000EE*/);
    G_FloatString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663535 /*0x060000EF*/);
    G_FloatString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663536 /*0x060000F0*/);
    G_FloatString.NativeMethodInfoPtr_ToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663537 /*0x060000F1*/);
    G_FloatString.NativeMethodInfoPtr_ToFloat_Public_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663538 /*0x060000F2*/);
    G_FloatString.NativeMethodInfoPtr_Pow_Private_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663539 /*0x060000F3*/);
    G_FloatString.NativeMethodInfoPtr_ToIndex_Private_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663540 /*0x060000F4*/);
    G_FloatString.NativeMethodInfoPtr_FromIndex_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_FloatString>.NativeClassPtr, 100663541 /*0x060000F5*/);
  }

  public static unsafe bool Inited
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 361858, RefRangeEnd = 361863, XrefRangeStart = 361854, XrefRangeEnd = 361858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float MinValue
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 361871, RefRangeEnd = 361876, XrefRangeStart = 361863, XrefRangeEnd = 361871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float MaxValue
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 361884, RefRangeEnd = 361889, XrefRangeStart = 361876, XrefRangeEnd = 361884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 361932, RefRangeEnd = 361937, XrefRangeStart = 361889, XrefRangeEnd = 361932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Init(float minNegativeValue, float maxPositiveValue, int decimals = 1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &minNegativeValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxPositiveValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &decimals;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_Init_Public_Static_Void_Single_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361946, RefRangeEnd = 361947, XrefRangeStart = 361937, XrefRangeEnd = 361946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToStringNonAlloc(this float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 361956, RefRangeEnd = 361960, XrefRangeStart = 361947, XrefRangeEnd = 361956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToStringNonAlloc(this float value, string format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(format);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Single_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public static unsafe int ToInt(this float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToInt_Public_Static_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 361960, RefRangeEnd = 361961, XrefRangeStart = 361960, XrefRangeEnd = 361960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float ToFloat(this int i)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToFloat_Public_Static_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe int Pow(int f, int p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &f;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_Pow_Private_Static_Int32_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 361968, RefRangeEnd = 361971, XrefRangeStart = 361961, XrefRangeEnd = 361968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int ToIndex(this float f)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &f
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_ToIndex_Private_Static_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361971, XrefRangeEnd = 361975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float FromIndex(this int i)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_FloatString.NativeMethodInfoPtr_FromIndex_Private_Static_Single_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public G_FloatString(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe string floatFormat
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(G_FloatString.NativeFieldInfoPtr_floatFormat, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_FloatString.NativeFieldInfoPtr_floatFormat, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe float decimalMultiplier
  {
    get
    {
      float decimalMultiplier;
      IL2CPP.il2cpp_field_static_get_value(G_FloatString.NativeFieldInfoPtr_decimalMultiplier, (void*) &decimalMultiplier);
      return decimalMultiplier;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_FloatString.NativeFieldInfoPtr_decimalMultiplier, (void*) &value);
    }
  }

  public static unsafe Il2CppStringArray negativeBuffer
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(G_FloatString.NativeFieldInfoPtr_negativeBuffer, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_FloatString.NativeFieldInfoPtr_negativeBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStringArray positiveBuffer
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(G_FloatString.NativeFieldInfoPtr_positiveBuffer, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_FloatString.NativeFieldInfoPtr_positiveBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
