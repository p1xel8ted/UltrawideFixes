// Decompiled with JetBrains decompiler
// Type: UnityEngine.MultilineAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class MultilineAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_lines;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

  static MultilineAttribute()
  {
    Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (MultilineAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr);
    MultilineAttribute.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, nameof (lines));
    MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, 100667744);
    MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr, 100667745);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441884, XrefRangeEnd = 441885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MultilineAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441885, XrefRangeEnd = 441886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MultilineAttribute(int lines)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultilineAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &lines
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MultilineAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int lines
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MultilineAttribute.NativeFieldInfoPtr_lines)) = value;
    }
  }
}
