// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyObject
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyObject(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeFieldInfoPtr_technicalName;
  private static readonly System.IntPtr NativeFieldInfoPtr_parentId;
  private static readonly System.IntPtr NativeFieldInfoPtr_childrenIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_children;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParentId_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_Virtual_New_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InstanceId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InstanceId_Internal_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TechnicalName_Public_Virtual_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TechnicalName_Public_Virtual_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Children_Public_Virtual_New_get_List_1_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSortedChildren_Public_List_1_TObjectType_Comparison_1_TObjectType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetArticyType_Public_ArticyType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateBareObjectClone_Public_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObjectProperties_Public_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_New_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_New_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyObject()
  {
    Il2CppClassPointerStore<ArticyObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr);
    ArticyObject.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, nameof (id));
    ArticyObject.NativeFieldInfoPtr_technicalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, nameof (technicalName));
    ArticyObject.NativeFieldInfoPtr_parentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, nameof (parentId));
    ArticyObject.NativeFieldInfoPtr_childrenIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, nameof (childrenIds));
    ArticyObject.NativeFieldInfoPtr_instanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, nameof (instanceId));
    ArticyObject.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, nameof (children));
    ArticyObject.NativeMethodInfoPtr_get_ParentId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663695);
    ArticyObject.NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663696 /*0x06000190*/);
    ArticyObject.NativeMethodInfoPtr_set_Id_Public_Virtual_New_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663697);
    ArticyObject.NativeMethodInfoPtr_get_InstanceId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663698);
    ArticyObject.NativeMethodInfoPtr_set_InstanceId_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663699);
    ArticyObject.NativeMethodInfoPtr_get_TechnicalName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663700);
    ArticyObject.NativeMethodInfoPtr_set_TechnicalName_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663701);
    ArticyObject.NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663702);
    ArticyObject.NativeMethodInfoPtr_get_Children_Public_Virtual_New_get_List_1_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663703);
    ArticyObject.NativeMethodInfoPtr_GetSortedChildren_Public_List_1_TObjectType_Comparison_1_TObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663704);
    ArticyObject.NativeMethodInfoPtr_GetArticyType_Public_ArticyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663705);
    ArticyObject.NativeMethodInfoPtr_CreateBareObjectClone_Public_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663706);
    ArticyObject.NativeMethodInfoPtr_CloneObjectProperties_Public_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663707);
    ArticyObject.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663708);
    ArticyObject.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_New_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663709);
    ArticyObject.NativeMethodInfoPtr_setProp_Public_Virtual_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663710);
    ArticyObject.NativeMethodInfoPtr_getProp_Public_Virtual_New_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663711);
    ArticyObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr, 100663712 /*0x060001A0*/);
  }

  public unsafe ulong ParentId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObject.NativeMethodInfoPtr_get_ParentId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe ulong Id
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_set_Id_Public_Virtual_New_set_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint InstanceId
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObject.NativeMethodInfoPtr_get_InstanceId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyObject.NativeMethodInfoPtr_set_InstanceId_Internal_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe string TechnicalName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_get_TechnicalName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_set_TechnicalName_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyObject Parent
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989800, XrefRangeEnd = 989809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_get_Parent_Public_Virtual_New_get_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
    }
  }

  public virtual unsafe List<ArticyObject> Children
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989809, XrefRangeEnd = 989842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_get_Children_Public_Virtual_New_get_List_1_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989842, XrefRangeEnd = 989868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<TObjectType> GetSortedChildren<TObjectType>(
    Il2CppSystem.Comparison<TObjectType> aComparisonMethod)
    where TObjectType : class
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aComparisonMethod)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObject.MethodInfoStoreGeneric_GetSortedChildren_Public_List_1_TObjectType_Comparison_1_TObjectType_0<TObjectType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<TObjectType>) null : Il2CppObjectPool.Get<List<TObjectType>>(num3);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 989873, RefRangeEnd = 989879, XrefRangeStart = 989868, XrefRangeEnd = 989873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyType GetArticyType()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObject.NativeMethodInfoPtr_GetArticyType_Public_ArticyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyType) null : Il2CppObjectPool.Get<ArticyType>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 989886, RefRangeEnd = 989888, XrefRangeStart = 989879, XrefRangeEnd = 989886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject CreateBareObjectClone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObject.NativeMethodInfoPtr_CreateBareObjectClone_Public_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 989888, RefRangeEnd = 989889, XrefRangeStart = 989888, XrefRangeEnd = 989888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneObjectProperties(ArticyObject aClone)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObject.NativeMethodInfoPtr_CloneObjectProperties_Public_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989889, XrefRangeEnd = 989898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyObject.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_New_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 989916, RefRangeEnd = 989928, XrefRangeStart = 989898, XrefRangeEnd = 989916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_setProp_Public_Virtual_New_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 989962, RefRangeEnd = 989974, XrefRangeStart = 989928, XrefRangeEnd = 989962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyObject.NativeMethodInfoPtr_getProp_Public_Virtual_New_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 989987, RefRangeEnd = 989999, XrefRangeStart = 989974, XrefRangeEnd = 989987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong id
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_id)) = value;
    }
  }

  public unsafe string technicalName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_technicalName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_technicalName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ulong parentId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_parentId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_parentId)) = value;
    }
  }

  public unsafe List<ulong> childrenIds
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_childrenIds));
      return num == System.IntPtr.Zero ? (List<ulong>) null : Il2CppObjectPool.Get<List<ulong>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_childrenIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe uint instanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_instanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_instanceId)) = value;
    }
  }

  public unsafe List<ArticyObject> children
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_children));
      return num == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyObject.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_GetSortedChildren_Public_List_1_TObjectType_Comparison_1_TObjectType_0<TObjectType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyObject.NativeMethodInfoPtr_GetSortedChildren_Public_List_1_TObjectType_Comparison_1_TObjectType_0, Il2CppClassPointerStore<ArticyObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObjectType>.NativeClassPtr))
    }))));
  }
}
