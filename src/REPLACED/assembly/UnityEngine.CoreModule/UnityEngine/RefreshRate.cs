// Decompiled with JetBrains decompiler
// Type: UnityEngine.RefreshRate
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RefreshRate
{
  private static readonly System.IntPtr NativeFieldInfoPtr_numerator;
  private static readonly System.IntPtr NativeFieldInfoPtr_denominator;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  [FieldOffset(0)]
  public uint numerator;
  [FieldOffset(4)]
  public uint denominator;

  static RefreshRate()
  {
    Il2CppClassPointerStore<RefreshRate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RefreshRate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr);
    RefreshRate.NativeFieldInfoPtr_numerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, nameof (numerator));
    RefreshRate.NativeFieldInfoPtr_denominator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, nameof (denominator));
    RefreshRate.NativeMethodInfoPtr_get_value_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664671);
    RefreshRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664672 /*0x06000560*/);
    RefreshRate.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664673);
    RefreshRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664674);
  }

  public unsafe double value
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_get_value_Public_get_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(RefreshRate other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422979, XrefRangeEnd = 422980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int CompareTo(RefreshRate other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422980, XrefRangeEnd = 422985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
