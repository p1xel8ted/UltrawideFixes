// Decompiled with JetBrains decompiler
// Type: Articy.Unity.LocalizedTextAssignMethod
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class LocalizedTextAssignMethod(IntPtr pointer) : UnityEvent<Component, string>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LocalizedTextAssignMethod()
  {
    Il2CppClassPointerStore<LocalizedTextAssignMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (LocalizedTextAssignMethod));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedTextAssignMethod>.NativeClassPtr);
    LocalizedTextAssignMethod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedTextAssignMethod>.NativeClassPtr, 100663492 /*0x060000C4*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 987562, XrefRangeEnd = 987565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalizedTextAssignMethod()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedTextAssignMethod>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizedTextAssignMethod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
