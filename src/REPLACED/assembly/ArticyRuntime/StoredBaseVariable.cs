// Decompiled with JetBrains decompiler
// Type: Articy.Unity.StoredBaseVariable
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public class StoredBaseVariable(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mFullQualifiedName;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FullQualifiedName_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VariableName_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

  static StoredBaseVariable()
  {
    Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (StoredBaseVariable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr);
    StoredBaseVariable.NativeFieldInfoPtr_mFullQualifiedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr, nameof (mFullQualifiedName));
    StoredBaseVariable.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr, 100664071 /*0x06000307*/);
    StoredBaseVariable.NativeMethodInfoPtr_get_FullQualifiedName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr, 100664072 /*0x06000308*/);
    StoredBaseVariable.NativeMethodInfoPtr_get_VariableName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr, 100664073 /*0x06000309*/);
    StoredBaseVariable.NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr, 100664074 /*0x0600030A*/);
    StoredBaseVariable.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr, 100664075 /*0x0600030B*/);
    StoredBaseVariable.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr, 100664076 /*0x0600030C*/);
  }

  [CallerCount(125)]
  [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StoredBaseVariable(string aFullQualifiedName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredBaseVariable>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aFullQualifiedName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StoredBaseVariable.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe string FullQualifiedName
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredBaseVariable.NativeMethodInfoPtr_get_FullQualifiedName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string VariableName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994679, XrefRangeEnd = 994682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredBaseVariable.NativeMethodInfoPtr_get_VariableName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public virtual unsafe string Namespace
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994682, XrefRangeEnd = 994685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredBaseVariable.NativeMethodInfoPtr_get_Namespace_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe Il2CppSystem.Object Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StoredBaseVariable.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994685, XrefRangeEnd = 994692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int CompareTo(Il2CppSystem.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredBaseVariable.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe string mFullQualifiedName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoredBaseVariable.NativeFieldInfoPtr_mFullQualifiedName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StoredBaseVariable.NativeFieldInfoPtr_mFullQualifiedName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
