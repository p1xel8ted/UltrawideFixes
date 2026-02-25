// Decompiled with JetBrains decompiler
// Type: UnityEngine.Scripting.APIUpdating.MovedFromAttributeData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Scripting.APIUpdating;

public sealed class MovedFromAttributeData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_className;
  private static readonly System.IntPtr NativeFieldInfoPtr_nameSpace;
  private static readonly System.IntPtr NativeFieldInfoPtr_assembly;
  private static readonly System.IntPtr NativeFieldInfoPtr_classHasChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_nameSpaceHasChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_assemblyHasChanged;
  private static readonly System.IntPtr NativeFieldInfoPtr_autoUdpateAPI;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0;

  static MovedFromAttributeData()
  {
    Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", nameof (MovedFromAttributeData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr);
    MovedFromAttributeData.NativeFieldInfoPtr_className = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, nameof (className));
    MovedFromAttributeData.NativeFieldInfoPtr_nameSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, nameof (nameSpace));
    MovedFromAttributeData.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, nameof (assembly));
    MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, nameof (classHasChanged));
    MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, nameof (nameSpaceHasChanged));
    MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, nameof (assemblyHasChanged));
    MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, nameof (autoUdpateAPI));
    MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, 100669202);
  }

  [CallerCount(0)]
  public unsafe void Set(
    bool autoUpdateAPI,
    string sourceNamespace = null,
    string sourceAssembly = null,
    string sourceClassName = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &autoUpdateAPI;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovedFromAttributeData.NativeMethodInfoPtr_Set_Public_Void_Boolean_String_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public MovedFromAttributeData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public MovedFromAttributeData()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr))
  {
  }

  public unsafe string className
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_className), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string nameSpace
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpace), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string assembly
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assembly), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool classHasChanged
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_classHasChanged)) = value;
    }
  }

  public unsafe bool nameSpaceHasChanged
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_nameSpaceHasChanged)) = value;
    }
  }

  public unsafe bool assemblyHasChanged
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_assemblyHasChanged)) = value;
    }
  }

  public unsafe bool autoUdpateAPI
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttributeData.NativeFieldInfoPtr_autoUdpateAPI)) = value;
    }
  }
}
