// Decompiled with JetBrains decompiler
// Type: UnityEngine.ContextMenu
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class ContextMenu(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_menuItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_validate;
  private static readonly System.IntPtr NativeFieldInfoPtr_priority;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0;

  static ContextMenu()
  {
    Il2CppClassPointerStore<ContextMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ContextMenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr);
    ContextMenu.NativeFieldInfoPtr_menuItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, nameof (menuItem));
    ContextMenu.NativeFieldInfoPtr_validate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, nameof (validate));
    ContextMenu.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, nameof (priority));
    ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100667862);
    ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100667863);
    ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr, 100667864);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442746, XrefRangeEnd = 442747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ContextMenu(string itemName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(itemName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442747, XrefRangeEnd = 442748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ContextMenu(string itemName, bool isValidateFunction)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(itemName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isValidateFunction;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442748, XrefRangeEnd = 442749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ContextMenu(string itemName, bool isValidateFunction, int priority)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextMenu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(itemName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isValidateFunction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &priority;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ContextMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string menuItem
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_menuItem)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_menuItem), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool validate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_validate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_validate)) = value;
    }
  }

  public unsafe int priority
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_priority));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContextMenu.NativeFieldInfoPtr_priority)) = value;
    }
  }
}
