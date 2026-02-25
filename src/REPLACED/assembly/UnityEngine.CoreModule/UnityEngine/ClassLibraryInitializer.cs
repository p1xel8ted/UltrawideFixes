// Decompiled with JetBrains decompiler
// Type: UnityEngine.ClassLibraryInitializer
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;

#nullable disable
namespace UnityEngine;

public static class ClassLibraryInitializer : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

  static ClassLibraryInitializer()
  {
    Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ClassLibraryInitializer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr);
    ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClassLibraryInitializer>.NativeClassPtr, 100667957);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444579, XrefRangeEnd = 444580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Init()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClassLibraryInitializer.NativeMethodInfoPtr_Init_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ClassLibraryInitializer(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static void InitAssemblyRedirections()
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }
}
