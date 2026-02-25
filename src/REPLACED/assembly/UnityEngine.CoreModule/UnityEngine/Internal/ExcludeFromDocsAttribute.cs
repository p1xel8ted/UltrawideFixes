// Decompiled with JetBrains decompiler
// Type: UnityEngine.Internal.ExcludeFromDocsAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine.Internal;

[Serializable]
public class ExcludeFromDocsAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ExcludeFromDocsAttribute()
  {
    Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Internal", nameof (ExcludeFromDocsAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr);
    ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr, 100669352);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ExcludeFromDocsAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromDocsAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExcludeFromDocsAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
