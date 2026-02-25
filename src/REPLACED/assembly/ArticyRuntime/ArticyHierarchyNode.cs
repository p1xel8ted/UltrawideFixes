// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyHierarchyNode
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyHierarchyNode(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mParent;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTechnicalName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mArticyType;
  private static readonly System.IntPtr NativeFieldInfoPtr_mChildren;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt64_UInt64_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UInt64_UInt64_String_String_List_1_ArticyHierarchyNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateNode_Private_Static_ArticyHierarchyNode_UInt64_UInt64_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_ArticyObject_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_TObject_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Private_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Parent_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TechnicalName_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ArticyType_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ArticyType_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Children_Public_get_ReadOnlyCollection_1_ArticyHierarchyNode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ChildrenInternal_Internal_get_List_1_ArticyHierarchyNode_0;

  static ArticyHierarchyNode()
  {
    Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyHierarchyNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr);
    ArticyHierarchyNode.NativeFieldInfoPtr_mId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, nameof (mId));
    ArticyHierarchyNode.NativeFieldInfoPtr_mParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, nameof (mParent));
    ArticyHierarchyNode.NativeFieldInfoPtr_mTechnicalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, nameof (mTechnicalName));
    ArticyHierarchyNode.NativeFieldInfoPtr_mArticyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, nameof (mArticyType));
    ArticyHierarchyNode.NativeFieldInfoPtr_mChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, nameof (mChildren));
    ArticyHierarchyNode.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_UInt64_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663665);
    ArticyHierarchyNode.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_UInt64_String_String_List_1_ArticyHierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663666);
    ArticyHierarchyNode.NativeMethodInfoPtr_CreateNode_Private_Static_ArticyHierarchyNode_UInt64_UInt64_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663667);
    ArticyHierarchyNode.NativeMethodInfoPtr_GetObject_Public_ArticyObject_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663668);
    ArticyHierarchyNode.NativeMethodInfoPtr_GetObject_Public_TObject_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663669);
    ArticyHierarchyNode.NativeMethodInfoPtr_get_Id_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663670);
    ArticyHierarchyNode.NativeMethodInfoPtr_set_Id_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663671);
    ArticyHierarchyNode.NativeMethodInfoPtr_get_Parent_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663672);
    ArticyHierarchyNode.NativeMethodInfoPtr_set_Parent_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663673);
    ArticyHierarchyNode.NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663674);
    ArticyHierarchyNode.NativeMethodInfoPtr_set_TechnicalName_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663675);
    ArticyHierarchyNode.NativeMethodInfoPtr_get_ArticyType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663676);
    ArticyHierarchyNode.NativeMethodInfoPtr_set_ArticyType_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663677);
    ArticyHierarchyNode.NativeMethodInfoPtr_get_Children_Public_get_ReadOnlyCollection_1_ArticyHierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663678);
    ArticyHierarchyNode.NativeMethodInfoPtr_get_ChildrenInternal_Internal_get_List_1_ArticyHierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr, 100663679);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989532, XrefRangeEnd = 989539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyHierarchyNode(ulong aId, ulong aParent, string aTechnicalName, string aType)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aParent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aType);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_UInt64_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989539, XrefRangeEnd = 989546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyHierarchyNode(
    ulong aId,
    ulong aParent,
    string aTechnicalName,
    string aType,
    List<ArticyHierarchyNode> aChildren)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aParent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aChildren);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr__ctor_Internal_Void_UInt64_UInt64_String_String_List_1_ArticyHierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989546, XrefRangeEnd = 989556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyHierarchyNode CreateNode(
    ulong aId,
    ulong aParent,
    string aTechnicalName,
    string aType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &aId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aParent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aTechnicalName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aType);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_CreateNode_Private_Static_ArticyHierarchyNode_UInt64_UInt64_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyHierarchyNode) null : Il2CppObjectPool.Get<ArticyHierarchyNode>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989556, XrefRangeEnd = 989565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject GetObject(uint aInstanceId = 0)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aInstanceId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_GetObject_Public_ArticyObject_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989565, XrefRangeEnd = 989606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TObject GetObject<TObject>(uint aInstanceId = 0) where TObject : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aInstanceId
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.MethodInfoStoreGeneric_GetObject_Public_TObject_UInt32_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  public unsafe ulong Id
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_get_Id_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_set_Id_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong Parent
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_get_Parent_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_set_Parent_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string TechnicalName
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_get_TechnicalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_set_TechnicalName_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ArticyType
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_get_ArticyType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_set_ArticyType_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ReadOnlyCollection<ArticyHierarchyNode> Children
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989606, XrefRangeEnd = 989610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_get_Children_Public_get_ReadOnlyCollection_1_ArticyHierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ReadOnlyCollection<ArticyHierarchyNode>) null : Il2CppObjectPool.Get<ReadOnlyCollection<ArticyHierarchyNode>>(num3);
    }
  }

  public unsafe List<ArticyHierarchyNode> ChildrenInternal
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyNode.NativeMethodInfoPtr_get_ChildrenInternal_Internal_get_List_1_ArticyHierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ArticyHierarchyNode>) null : Il2CppObjectPool.Get<List<ArticyHierarchyNode>>(num3);
    }
  }

  public unsafe ulong mId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mId)) = value;
    }
  }

  public unsafe ulong mParent
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mParent));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mParent)) = value;
    }
  }

  public unsafe string mTechnicalName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mTechnicalName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mTechnicalName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string mArticyType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mArticyType)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mArticyType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe List<ArticyHierarchyNode> mChildren
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mChildren));
      return num == System.IntPtr.Zero ? (List<ArticyHierarchyNode>) null : Il2CppObjectPool.Get<List<ArticyHierarchyNode>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyNode.NativeFieldInfoPtr_mChildren), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_GetObject_Public_TObject_UInt32_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyHierarchyNode.NativeMethodInfoPtr_GetObject_Public_TObject_UInt32_0, Il2CppClassPointerStore<ArticyHierarchyNode>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }
}
