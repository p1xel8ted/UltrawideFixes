// Decompiled with JetBrains decompiler
// Type: Unity.IL2CPP.CompilerServices.Il2CppEagerStaticClassConstructionAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Unity.IL2CPP.CompilerServices;

public class Il2CppEagerStaticClassConstructionAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Il2CppEagerStaticClassConstructionAttribute()
  {
    Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr = Il2CppInterop.Runtime.IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IL2CPP.CompilerServices", nameof (Il2CppEagerStaticClassConstructionAttribute));
    Il2CppInterop.Runtime.IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr);
    Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = Il2CppInterop.Runtime.IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr, 100663376 /*0x06000050*/);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppEagerStaticClassConstructionAttribute()
    : this(Il2CppInterop.Runtime.IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppEagerStaticClassConstructionAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    Il2CppInterop.Runtime.IL2CPP.il2cpp_runtime_invoke(Il2CppEagerStaticClassConstructionAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, Il2CppInterop.Runtime.IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
