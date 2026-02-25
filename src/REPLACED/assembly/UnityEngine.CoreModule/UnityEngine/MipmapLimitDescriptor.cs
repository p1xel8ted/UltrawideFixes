// Decompiled with JetBrains decompiler
// Type: UnityEngine.MipmapLimitDescriptor
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class MipmapLimitDescriptor : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr__useMipmapLimit_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__groupName_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_useMipmapLimit_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_groupName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0;

  static MipmapLimitDescriptor()
  {
    Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (MipmapLimitDescriptor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr);
    MipmapLimitDescriptor.NativeFieldInfoPtr__useMipmapLimit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, "<useMipmapLimit>k__BackingField");
    MipmapLimitDescriptor.NativeFieldInfoPtr__groupName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, "<groupName>k__BackingField");
    MipmapLimitDescriptor.NativeMethodInfoPtr_get_useMipmapLimit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, 100667158);
    MipmapLimitDescriptor.NativeMethodInfoPtr_get_groupName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, 100667159);
    MipmapLimitDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr, 100667160);
  }

  public unsafe bool useMipmapLimit
  {
    [CallerCount(93), CachedScanResults(RefRangeStart = 147614, RefRangeEnd = 147707, XrefRangeStart = 147614, XrefRangeEnd = 147707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MipmapLimitDescriptor.NativeMethodInfoPtr_get_useMipmapLimit_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string groupName
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MipmapLimitDescriptor.NativeMethodInfoPtr_get_groupName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 437759, RefRangeEnd = 437766, XrefRangeStart = 437759, XrefRangeEnd = 437759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MipmapLimitDescriptor(bool useMipmapLimit, string groupName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &useMipmapLimit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(groupName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MipmapLimitDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public MipmapLimitDescriptor(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public MipmapLimitDescriptor()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MipmapLimitDescriptor>.NativeClassPtr))
  {
  }

  public unsafe bool _useMipmapLimit_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MipmapLimitDescriptor.NativeFieldInfoPtr__useMipmapLimit_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MipmapLimitDescriptor.NativeFieldInfoPtr__useMipmapLimit_k__BackingField)) = value;
    }
  }

  public unsafe string _groupName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MipmapLimitDescriptor.NativeFieldInfoPtr__groupName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MipmapLimitDescriptor.NativeFieldInfoPtr__groupName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
