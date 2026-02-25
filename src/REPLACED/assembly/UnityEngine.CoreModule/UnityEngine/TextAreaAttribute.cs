// Decompiled with JetBrains decompiler
// Type: UnityEngine.TextAreaAttribute
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

public sealed class TextAreaAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_minLines;
  private static readonly IntPtr NativeFieldInfoPtr_maxLines;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

  static TextAreaAttribute()
  {
    Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TextAreaAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr);
    TextAreaAttribute.NativeFieldInfoPtr_minLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, nameof (minLines));
    TextAreaAttribute.NativeFieldInfoPtr_maxLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, nameof (maxLines));
    TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, 100667746);
    TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr, 100667747);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441886, XrefRangeEnd = 441887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextAreaAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441887, XrefRangeEnd = 441888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TextAreaAttribute(int minLines, int maxLines)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextAreaAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &minLines;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &maxLines;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TextAreaAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int minLines
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_minLines)) = value;
    }
  }

  public unsafe int maxLines
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextAreaAttribute.NativeFieldInfoPtr_maxLines)) = value;
    }
  }
}
