// Decompiled with JetBrains decompiler
// Type: UnityEngine.AddComponentMenu
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class AddComponentMenu(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AddComponentMenu;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ordering;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

  static AddComponentMenu()
  {
    Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AddComponentMenu));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr);
    AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, nameof (m_AddComponentMenu));
    AddComponentMenu.NativeFieldInfoPtr_m_Ordering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, nameof (m_Ordering));
    AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100667856);
    AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr, 100667857);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442739, XrefRangeEnd = 442740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddComponentMenu(string menuName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(menuName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 442741, RefRangeEnd = 442746, XrefRangeStart = 442740, XrefRangeEnd = 442741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AddComponentMenu(string menuName, int order)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AddComponentMenu>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(menuName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &order;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddComponentMenu.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string m_AddComponentMenu
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_AddComponentMenu), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int m_Ordering
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AddComponentMenu.NativeFieldInfoPtr_m_Ordering)) = value;
    }
  }

  public string componentMenu => this.m_AddComponentMenu;

  public int componentOrder => this.m_Ordering;
}
