// Decompiled with JetBrains decompiler
// Type: UnityEngine.ColorUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class ColorUtility(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoTryParseHtmlColor_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Color32_0;

  static ColorUtility()
  {
    Il2CppClassPointerStore<ColorUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ColorUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr);
    ColorUtility.NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100667283);
    ColorUtility.NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100667284);
    ColorUtility.NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100667285);
    ColorUtility.NativeMethodInfoPtr_DoTryParseHtmlColor_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorUtility>.NativeClassPtr, 100667286);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 438276, RefRangeEnd = 438277, XrefRangeStart = 438262, XrefRangeEnd = 438276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool DoTryParseHtmlColor(string htmlString, out Color32 color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(htmlString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref color;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_DoTryParseHtmlColor_Internal_Static_Boolean_String_byref_Color32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 438278, RefRangeEnd = 438282, XrefRangeStart = 438277, XrefRangeEnd = 438278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryParseHtmlString(string htmlString, out Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(htmlString);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref color;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_TryParseHtmlString_Public_Static_Boolean_String_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 438312, RefRangeEnd = 438315, XrefRangeStart = 438282, XrefRangeEnd = 438312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToHtmlStringRGB(Color color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &color
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_ToHtmlStringRGB_Public_Static_String_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438315, XrefRangeEnd = 438317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool DoTryParseHtmlColor_Injected(
    ref ManagedSpanWrapper htmlString,
    out Color32 color)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref htmlString;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref color;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ColorUtility.NativeMethodInfoPtr_DoTryParseHtmlColor_Injected_Private_Static_Boolean_byref_ManagedSpanWrapper_byref_Color32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static string ToHtmlStringRGBA(Color color)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }
}
