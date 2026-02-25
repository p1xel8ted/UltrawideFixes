// Decompiled with JetBrains decompiler
// Type: Unity.IntegerTime.RationalTimeExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IntegerTime;

public static class RationalTimeExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Static_RationalTime_RationalTime_TicksPerSecond_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Injected_Private_Static_Void_byref_RationalTime_byref_TicksPerSecond_byref_RationalTime_0;
  private static readonly RationalTimeExtensions.ToDouble_InjectedDelegate ToDouble_InjectedDelegateField;
  private static readonly RationalTimeExtensions.IsValid_InjectedDelegate IsValid_InjectedDelegateField;
  private static readonly RationalTimeExtensions.Add_InjectedDelegate Add_InjectedDelegateField;
  private static readonly RationalTimeExtensions.Subtract_InjectedDelegate Subtract_InjectedDelegateField;
  private static readonly RationalTimeExtensions.Multiply_InjectedDelegate Multiply_InjectedDelegateField;
  private static readonly RationalTimeExtensions.Divide_InjectedDelegate Divide_InjectedDelegateField;

  static RationalTimeExtensions()
  {
    Il2CppClassPointerStore<RationalTimeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IntegerTime", nameof (RationalTimeExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RationalTimeExtensions>.NativeClassPtr);
    RationalTimeExtensions.NativeMethodInfoPtr_Convert_Public_Static_RationalTime_RationalTime_TicksPerSecond_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTimeExtensions>.NativeClassPtr, 100663374 /*0x0600004E*/);
    RationalTimeExtensions.NativeMethodInfoPtr_Convert_Injected_Private_Static_Void_byref_RationalTime_byref_TicksPerSecond_byref_RationalTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RationalTimeExtensions>.NativeClassPtr, 100663375 /*0x0600004F*/);
    RationalTimeExtensions.ToDouble_InjectedDelegateField = IL2CPP.ResolveICall<RationalTimeExtensions.ToDouble_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::ToDouble_Injected");
    RationalTimeExtensions.IsValid_InjectedDelegateField = IL2CPP.ResolveICall<RationalTimeExtensions.IsValid_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::IsValid_Injected");
    RationalTimeExtensions.Add_InjectedDelegateField = IL2CPP.ResolveICall<RationalTimeExtensions.Add_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::Add_Injected");
    RationalTimeExtensions.Subtract_InjectedDelegateField = IL2CPP.ResolveICall<RationalTimeExtensions.Subtract_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::Subtract_Injected");
    RationalTimeExtensions.Multiply_InjectedDelegateField = IL2CPP.ResolveICall<RationalTimeExtensions.Multiply_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::Multiply_Injected");
    RationalTimeExtensions.Divide_InjectedDelegateField = IL2CPP.ResolveICall<RationalTimeExtensions.Divide_InjectedDelegate>("Unity.IntegerTime.RationalTimeExtensions::Divide_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413671, XrefRangeEnd = 413673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RationalTime Convert(
    this RationalTime time,
    RationalTime.TicksPerSecond rate)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rate;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RationalTimeExtensions.NativeMethodInfoPtr_Convert_Public_Static_RationalTime_RationalTime_TicksPerSecond_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RationalTime*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413673, XrefRangeEnd = 413675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Convert_Injected(
    [In] ref RationalTime time,
    [In] ref RationalTime.TicksPerSecond rate,
    out RationalTime ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rate;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RationalTimeExtensions.NativeMethodInfoPtr_Convert_Injected_Private_Static_Void_byref_RationalTime_byref_TicksPerSecond_byref_RationalTime_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public RationalTimeExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static double ToDouble(RationalTime value)
  {
    return RationalTimeExtensions.ToDouble_Injected(ref value);
  }

  public static bool IsValid(RationalTime value)
  {
    return RationalTimeExtensions.IsValid_Injected(ref value);
  }

  public static RationalTime Add(RationalTime lhs, RationalTime rhs)
  {
    RationalTime ret;
    RationalTimeExtensions.Add_Injected(ref lhs, ref rhs, out ret);
    return ret;
  }

  public static RationalTime Subtract(RationalTime lhs, RationalTime rhs)
  {
    RationalTime ret;
    RationalTimeExtensions.Subtract_Injected(ref lhs, ref rhs, out ret);
    return ret;
  }

  public static RationalTime Multiply(RationalTime lhs, RationalTime rhs)
  {
    RationalTime ret;
    RationalTimeExtensions.Multiply_Injected(ref lhs, ref rhs, out ret);
    return ret;
  }

  public static RationalTime Divide(RationalTime lhs, RationalTime rhs)
  {
    RationalTime ret;
    RationalTimeExtensions.Divide_Injected(ref lhs, ref rhs, out ret);
    return ret;
  }

  public static double ToDouble_Injected([In] ref RationalTime value)
  {
    return RationalTimeExtensions.ToDouble_InjectedDelegateField((System.IntPtr) ref value);
  }

  public static bool IsValid_Injected([In] ref RationalTime value)
  {
    return RationalTimeExtensions.IsValid_InjectedDelegateField((System.IntPtr) ref value);
  }

  public static void Add_Injected([In] ref RationalTime lhs, [In] ref RationalTime rhs, out RationalTime ret)
  {
    RationalTimeExtensions.Add_InjectedDelegateField((System.IntPtr) ref lhs, (System.IntPtr) ref rhs, (System.IntPtr) ref ret);
  }

  public static void Subtract_Injected(
    [In] ref RationalTime lhs,
    [In] ref RationalTime rhs,
    out RationalTime ret)
  {
    RationalTimeExtensions.Subtract_InjectedDelegateField((System.IntPtr) ref lhs, (System.IntPtr) ref rhs, (System.IntPtr) ref ret);
  }

  public static void Multiply_Injected(
    [In] ref RationalTime lhs,
    [In] ref RationalTime rhs,
    out RationalTime ret)
  {
    RationalTimeExtensions.Multiply_InjectedDelegateField((System.IntPtr) ref lhs, (System.IntPtr) ref rhs, (System.IntPtr) ref ret);
  }

  public static void Divide_Injected(
    [In] ref RationalTime lhs,
    [In] ref RationalTime rhs,
    out RationalTime ret)
  {
    RationalTimeExtensions.Divide_InjectedDelegateField((System.IntPtr) ref lhs, (System.IntPtr) ref rhs, (System.IntPtr) ref ret);
  }

  private delegate double ToDouble_InjectedDelegate([In] System.IntPtr value);

  private delegate bool IsValid_InjectedDelegate([In] System.IntPtr value);

  private delegate void Add_InjectedDelegate([In] System.IntPtr lhs, [In] System.IntPtr rhs, [Out] System.IntPtr ret);

  private delegate void Subtract_InjectedDelegate([In] System.IntPtr lhs, [In] System.IntPtr rhs, [Out] System.IntPtr ret);

  private delegate void Multiply_InjectedDelegate([In] System.IntPtr lhs, [In] System.IntPtr rhs, [Out] System.IntPtr ret);

  private delegate void Divide_InjectedDelegate([In] System.IntPtr lhs, [In] System.IntPtr rhs, [Out] System.IntPtr ret);
}
