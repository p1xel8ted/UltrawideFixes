// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.OutStringMarshaller
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct OutStringMarshaller
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetStringAndDispose_Public_Static_String_ManagedSpanWrapper_0;

  static OutStringMarshaller()
  {
    Il2CppClassPointerStore<OutStringMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (OutStringMarshaller));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutStringMarshaller>.NativeClassPtr);
    OutStringMarshaller.NativeMethodInfoPtr_GetStringAndDispose_Public_Static_String_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutStringMarshaller>.NativeClassPtr, 100669199);
  }

  [CallerCount(108)]
  [CachedScanResults(RefRangeStart = 478539, RefRangeEnd = 478647, XrefRangeStart = 478536, XrefRangeEnd = 478539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetStringAndDispose(ManagedSpanWrapper managedSpan)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &managedSpan
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutStringMarshaller.NativeMethodInfoPtr_GetStringAndDispose_Public_Static_String_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OutStringMarshaller>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static void UpdateStringAndDispose(
    ManagedSpanWrapper inSpanWrapper,
    ManagedSpanWrapper outSpanWrapper,
    ref string outString)
  {
    if (inSpanWrapper.begin == outSpanWrapper.begin)
      return;
    outString = OutStringMarshaller.GetStringAndDispose(outSpanWrapper);
  }
}
