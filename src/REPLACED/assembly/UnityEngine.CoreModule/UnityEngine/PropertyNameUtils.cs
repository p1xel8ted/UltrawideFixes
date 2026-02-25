// Decompiled with JetBrains decompiler
// Type: UnityEngine.PropertyNameUtils
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class PropertyNameUtils(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PropertyName_0;

  static PropertyNameUtils()
  {
    Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (PropertyNameUtils));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr);
    PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100667750);
    PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100667751);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 441903, RefRangeEnd = 441905, XrefRangeStart = 441889, XrefRangeEnd = 441903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PropertyName PropertyNameFromString(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PropertyName*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441905, XrefRangeEnd = 441907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PropertyNameFromString_Injected(
    ref ManagedSpanWrapper name,
    out PropertyName ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_byref_ManagedSpanWrapper_byref_PropertyName_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
