// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyRefComplexAttribute
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyRefComplexAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyRefComplexAttribute()
  {
    Il2CppClassPointerStore<ArticyRefComplexAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyRefComplexAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyRefComplexAttribute>.NativeClassPtr);
    ArticyRefComplexAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRefComplexAttribute>.NativeClassPtr, 100663816 /*0x06000208*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyRefComplexAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyRefComplexAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRefComplexAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
