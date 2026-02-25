// Decompiled with JetBrains decompiler
// Type: UnityEngine.Serialization.FormerlySerializedAsAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Serialization;

public class FormerlySerializedAsAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_oldName;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_oldName_Public_get_String_0;

  static FormerlySerializedAsAttribute()
  {
    Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Serialization", nameof (FormerlySerializedAsAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr);
    FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, nameof (m_oldName));
    FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, 100669178);
    FormerlySerializedAsAttribute.NativeMethodInfoPtr_get_oldName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr, 100669179);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 255058, RefRangeEnd = 255093, XrefRangeStart = 255058, XrefRangeEnd = 255093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FormerlySerializedAsAttribute(string oldName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormerlySerializedAsAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(oldName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FormerlySerializedAsAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string oldName
  {
    [CallerCount(211), CachedScanResults(RefRangeStart = 296220, RefRangeEnd = 296431, XrefRangeStart = 296220, XrefRangeEnd = 296431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FormerlySerializedAsAttribute.NativeMethodInfoPtr_get_oldName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string m_oldName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FormerlySerializedAsAttribute.NativeFieldInfoPtr_m_oldName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
