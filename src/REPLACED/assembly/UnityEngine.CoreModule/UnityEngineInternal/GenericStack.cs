// Decompiled with JetBrains decompiler
// Type: UnityEngineInternal.GenericStack
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections;
using System;

#nullable disable
namespace UnityEngineInternal;

public class GenericStack(IntPtr pointer) : Stack(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GenericStack()
  {
    Il2CppClassPointerStore<GenericStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", nameof (GenericStack));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericStack>.NativeClassPtr);
    GenericStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericStack>.NativeClassPtr, 100663304 /*0x06000008*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 413311, RefRangeEnd = 413312, XrefRangeStart = 413310, XrefRangeEnd = 413311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GenericStack()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericStack>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GenericStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
