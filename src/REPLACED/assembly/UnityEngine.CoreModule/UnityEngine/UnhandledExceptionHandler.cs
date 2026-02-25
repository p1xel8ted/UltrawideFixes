// Decompiled with JetBrains decompiler
// Type: UnityEngine.UnhandledExceptionHandler
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class UnhandledExceptionHandler(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0;

  static UnhandledExceptionHandler()
  {
    Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (UnhandledExceptionHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr);
    UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, 100668301);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453532, XrefRangeEnd = 453548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RegisterUECatcher()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [ObfuscatedName("UnityEngine.UnhandledExceptionHandler+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0;

    static __c()
    {
      Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr);
      UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9");
      UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9__0_0");
      UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100668303);
      UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100668304);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453525, XrefRangeEnd = 453532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _RegisterUECatcher_b__0_0(Il2CppSystem.Object sender, Il2CppSystem.UnhandledExceptionEventArgs e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sender);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe UnhandledExceptionHandler.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (UnhandledExceptionHandler.__c) null : Il2CppObjectPool.Get<UnhandledExceptionHandler.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.UnhandledExceptionEventHandler __9__0_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.UnhandledExceptionEventHandler) null : Il2CppObjectPool.Get<Il2CppSystem.UnhandledExceptionEventHandler>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }
}
