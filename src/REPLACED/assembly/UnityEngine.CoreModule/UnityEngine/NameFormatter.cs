// Decompiled with JetBrains decompiler
// Type: UnityEngine.NameFormatter
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public sealed class NameFormatter(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_FormatVariableName_Public_Static_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FormatVariableName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0;

  static NameFormatter()
  {
    Il2CppClassPointerStore<NameFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (NameFormatter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NameFormatter>.NativeClassPtr);
    NameFormatter.NativeMethodInfoPtr_FormatVariableName_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameFormatter>.NativeClassPtr, 100668649);
    NameFormatter.NativeMethodInfoPtr_FormatVariableName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NameFormatter>.NativeClassPtr, 100668650);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466345, XrefRangeEnd = 466361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string FormatVariableName(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NameFormatter.NativeMethodInfoPtr_FormatVariableName_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 466361, XrefRangeEnd = 466363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void FormatVariableName_Injected(
    ref ManagedSpanWrapper name,
    out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NameFormatter.NativeMethodInfoPtr_FormatVariableName_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
