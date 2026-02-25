// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyPackageDefinition
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyPackageDefinition(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_PackageId;
  private static readonly System.IntPtr NativeFieldInfoPtr_PackageName;
  private static readonly System.IntPtr NativeFieldInfoPtr_PackagePath;
  private static readonly System.IntPtr NativeFieldInfoPtr_mIsDefaultPackage;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsDefaultPackage_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsDefaultPackage_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyPackageDefinition()
  {
    Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyPackageDefinition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr);
    ArticyPackageDefinition.NativeFieldInfoPtr_PackageId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr, nameof (PackageId));
    ArticyPackageDefinition.NativeFieldInfoPtr_PackageName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr, nameof (PackageName));
    ArticyPackageDefinition.NativeFieldInfoPtr_PackagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr, nameof (PackagePath));
    ArticyPackageDefinition.NativeFieldInfoPtr_mIsDefaultPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr, nameof (mIsDefaultPackage));
    ArticyPackageDefinition.NativeMethodInfoPtr_get_IsDefaultPackage_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr, 100663735);
    ArticyPackageDefinition.NativeMethodInfoPtr_set_IsDefaultPackage_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr, 100663736);
    ArticyPackageDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr, 100663737);
  }

  public unsafe bool IsDefaultPackage
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyPackageDefinition.NativeMethodInfoPtr_get_IsDefaultPackage_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990317, XrefRangeEnd = 990321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyPackageDefinition.NativeMethodInfoPtr_set_IsDefaultPackage_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyPackageDefinition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyPackageDefinition>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPackageDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong PackageId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackageDefinition.NativeFieldInfoPtr_PackageId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackageDefinition.NativeFieldInfoPtr_PackageId)) = value;
    }
  }

  public unsafe string PackageName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackageDefinition.NativeFieldInfoPtr_PackageName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackageDefinition.NativeFieldInfoPtr_PackageName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string PackagePath
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackageDefinition.NativeFieldInfoPtr_PackagePath)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackageDefinition.NativeFieldInfoPtr_PackagePath), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool mIsDefaultPackage
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackageDefinition.NativeFieldInfoPtr_mIsDefaultPackage));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPackageDefinition.NativeFieldInfoPtr_mIsDefaultPackage)) = value;
    }
  }
}
