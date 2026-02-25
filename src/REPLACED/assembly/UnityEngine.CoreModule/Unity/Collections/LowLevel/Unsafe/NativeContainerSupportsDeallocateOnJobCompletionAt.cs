// Decompiled with JetBrains decompiler
// Type: Unity.Collections.LowLevel.Unsafe.NativeContainerSupportsDeallocateOnJobCompletionAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Unity.Collections.LowLevel.Unsafe;

public sealed class NativeContainerSupportsDeallocateOnJobCompletionAttribute(System.IntPtr pointer) : 
  Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static NativeContainerSupportsDeallocateOnJobCompletionAttribute()
  {
    Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Collections.LowLevel.Unsafe", nameof (NativeContainerSupportsDeallocateOnJobCompletionAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr);
    NativeContainerSupportsDeallocateOnJobCompletionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr, 100663570);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NativeContainerSupportsDeallocateOnJobCompletionAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NativeContainerSupportsDeallocateOnJobCompletionAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NativeContainerSupportsDeallocateOnJobCompletionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
