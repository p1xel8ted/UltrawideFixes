// Decompiled with JetBrains decompiler
// Type: Cinemachine.CinemachineEmbeddedAssetPropertyAttribute
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public sealed class CinemachineEmbeddedAssetPropertyAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_WarnIfNull;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

  static CinemachineEmbeddedAssetPropertyAttribute()
  {
    Il2CppClassPointerStore<CinemachineEmbeddedAssetPropertyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (CinemachineEmbeddedAssetPropertyAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineEmbeddedAssetPropertyAttribute>.NativeClassPtr);
    CinemachineEmbeddedAssetPropertyAttribute.NativeFieldInfoPtr_WarnIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineEmbeddedAssetPropertyAttribute>.NativeClassPtr, nameof (WarnIfNull));
    CinemachineEmbeddedAssetPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineEmbeddedAssetPropertyAttribute>.NativeClassPtr, 100664047);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 943739, XrefRangeEnd = 943740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineEmbeddedAssetPropertyAttribute(bool warnIfNull = false)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineEmbeddedAssetPropertyAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &warnIfNull
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineEmbeddedAssetPropertyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool WarnIfNull
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineEmbeddedAssetPropertyAttribute.NativeFieldInfoPtr_WarnIfNull));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineEmbeddedAssetPropertyAttribute.NativeFieldInfoPtr_WarnIfNull)) = value;
    }
  }
}
