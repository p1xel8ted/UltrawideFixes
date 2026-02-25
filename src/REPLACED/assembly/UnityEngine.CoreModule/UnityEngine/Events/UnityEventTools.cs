// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.UnityEventTools
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Events;

public class UnityEventTools(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0;

  static UnityEventTools()
  {
    Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", nameof (UnityEventTools));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr);
    UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEventTools>.NativeClassPtr, 100669049);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 472987, RefRangeEnd = 472992, XrefRangeStart = 472956, XrefRangeEnd = 472987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string TidyAssemblyTypeName(string assemblyTypeName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(assemblyTypeName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEventTools.NativeMethodInfoPtr_TidyAssemblyTypeName_Internal_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }
}
