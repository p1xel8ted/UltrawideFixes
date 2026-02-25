// Decompiled with JetBrains decompiler
// Type: Il2CppSystem.Runtime.CompilerServices.IsUnmanagedAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Il2CppSystem.Runtime.CompilerServices;

public sealed class IsUnmanagedAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static IsUnmanagedAttribute()
  {
    Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "System.Runtime.CompilerServices", nameof (IsUnmanagedAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr);
    IsUnmanagedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr, 100663298 /*0x06000002*/);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IsUnmanagedAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsUnmanagedAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IsUnmanagedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
