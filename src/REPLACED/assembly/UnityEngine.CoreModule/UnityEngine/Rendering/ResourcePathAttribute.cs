// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ResourcePathAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class ResourcePathAttribute(IntPtr pointer) : ResourcePathsBaseAttribute(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SearchType_0;

  static ResourcePathAttribute()
  {
    Il2CppClassPointerStore<ResourcePathAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ResourcePathAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcePathAttribute>.NativeClassPtr);
    ResourcePathAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_SearchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcePathAttribute>.NativeClassPtr, 100669707);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ResourcePathAttribute(string path, SearchType location = SearchType.ProjectPath)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcePathAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &location;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResourcePathAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_SearchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
