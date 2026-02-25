// Decompiled with JetBrains decompiler
// Type: UnityEngine.HelpURLAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class HelpURLAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Url;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Dispatcher;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DispatchingFieldName;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_URL_Public_Virtual_New_get_String_0;

  static HelpURLAttribute()
  {
    Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (HelpURLAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr);
    HelpURLAttribute.NativeFieldInfoPtr_m_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, nameof (m_Url));
    HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, nameof (m_Dispatcher));
    HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, nameof (m_DispatchingFieldName));
    HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, 100667868);
    HelpURLAttribute.NativeMethodInfoPtr_get_URL_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr, 100667869);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 442752, RefRangeEnd = 442756, XrefRangeStart = 442749, XrefRangeEnd = 442752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HelpURLAttribute(string url)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HelpURLAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(url)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe string URL
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HelpURLAttribute.NativeMethodInfoPtr_get_URL_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string m_Url
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Url), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool m_Dispatcher
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_Dispatcher)) = value;
    }
  }

  public unsafe string m_DispatchingFieldName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HelpURLAttribute.NativeFieldInfoPtr_m_DispatchingFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
