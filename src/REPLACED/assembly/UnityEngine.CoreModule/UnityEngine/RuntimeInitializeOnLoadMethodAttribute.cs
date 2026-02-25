// Decompiled with JetBrains decompiler
// Type: UnityEngine.RuntimeInitializeOnLoadMethodAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

#nullable disable
namespace UnityEngine;

public class RuntimeInitializeOnLoadMethodAttribute(IntPtr pointer) : PreserveAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_LoadType;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0;

  static RuntimeInitializeOnLoadMethodAttribute()
  {
    Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RuntimeInitializeOnLoadMethodAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr);
    RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, nameof (m_LoadType));
    RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100668246);
    RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100668247);
    RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr, 100668248);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452974, XrefRangeEnd = 452975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RuntimeInitializeOnLoadMethodAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452975, XrefRangeEnd = 452976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RuntimeInitializeOnLoadMethodAttribute(RuntimeInitializeLoadType loadType)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeInitializeOnLoadMethodAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &loadType
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe RuntimeInitializeLoadType loadType
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RuntimeInitializeOnLoadMethodAttribute.NativeMethodInfoPtr_set_loadType_Private_set_Void_RuntimeInitializeLoadType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_LoadType;
  }

  public unsafe RuntimeInitializeLoadType m_LoadType
  {
    get
    {
      return *(RuntimeInitializeLoadType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType));
    }
    [param: In] set
    {
      *(RuntimeInitializeLoadType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RuntimeInitializeOnLoadMethodAttribute.NativeFieldInfoPtr_m_LoadType)) = value;
    }
  }
}
