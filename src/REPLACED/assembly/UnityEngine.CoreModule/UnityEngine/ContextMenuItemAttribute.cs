// Decompiled with JetBrains decompiler
// Type: UnityEngine.ContextMenuItemAttribute
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

public class ContextMenuItemAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_name;
  private static readonly IntPtr NativeFieldInfoPtr_function;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

  static ContextMenuItemAttribute()
  {
    Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ContextMenuItemAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr);
    ContextMenuItemAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr, nameof (name));
    ContextMenuItemAttribute.NativeFieldInfoPtr_function = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr, nameof (function));
    ContextMenuItemAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr, 100667736);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441869, XrefRangeEnd = 441870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ContextMenuItemAttribute(string name, string function)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenuItemAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(function);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ContextMenuItemAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContextMenuItemAttribute.NativeFieldInfoPtr_name)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContextMenuItemAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string function
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContextMenuItemAttribute.NativeFieldInfoPtr_function)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContextMenuItemAttribute.NativeFieldInfoPtr_function), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
