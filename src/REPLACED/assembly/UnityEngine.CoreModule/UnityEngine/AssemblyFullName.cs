// Decompiled with JetBrains decompiler
// Type: UnityEngine.AssemblyFullName
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class AssemblyFullName : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_Version;
  private static readonly System.IntPtr NativeFieldInfoPtr_PublicKeyToken;
  private static readonly System.IntPtr NativeFieldInfoPtr_Culture;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  static AssemblyFullName()
  {
    Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AssemblyFullName));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr);
    AssemblyFullName.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, nameof (Name));
    AssemblyFullName.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, nameof (Version));
    AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, nameof (PublicKeyToken));
    AssemblyFullName.NativeFieldInfoPtr_Culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, nameof (Culture));
    AssemblyFullName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100667962);
    AssemblyFullName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100667963);
    AssemblyFullName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr, 100667964);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444608, XrefRangeEnd = 444614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444614, XrefRangeEnd = 444620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444620, XrefRangeEnd = 444636, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssemblyFullName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public AssemblyFullName(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public AssemblyFullName()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyFullName>.NativeClassPtr))
  {
  }

  public unsafe string Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe AssemblyVersion Version
  {
    get
    {
      return *(AssemblyVersion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Version));
    }
    [param: In] set
    {
      *(AssemblyVersion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Version)) = value;
    }
  }

  public unsafe string PublicKeyToken
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_PublicKeyToken), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string Culture
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Culture)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssemblyFullName.NativeFieldInfoPtr_Culture), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
