// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyHierarchyManager
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyHierarchyManager(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_mRoot;
  private static readonly IntPtr NativeFieldInfoPtr_mHierarchyIdMap;
  private static readonly IntPtr NativeFieldInfoPtr_serializedNodes;
  private static readonly IntPtr NativeMethodInfoPtr_get_ProjectNode_Public_get_ArticyHierarchyNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHierarchyInfo_Public_ArticyHierarchyNode_UInt64_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetRootHierarchyNode_Private_Void_ArticyHierarchyNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_BuildHierarchyIdMap_Private_Void_ArticyHierarchyNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddNodeToSerializedNodes_Private_Void_ArticyHierarchyNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReadNodeFromSerializedNodes_Private_ArticyHierarchyNode_byref_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyHierarchyManager()
  {
    Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyHierarchyManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr);
    ArticyHierarchyManager.NativeFieldInfoPtr_mRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, nameof (mRoot));
    ArticyHierarchyManager.NativeFieldInfoPtr_mHierarchyIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, nameof (mHierarchyIdMap));
    ArticyHierarchyManager.NativeFieldInfoPtr_serializedNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, nameof (serializedNodes));
    ArticyHierarchyManager.NativeMethodInfoPtr_get_ProjectNode_Public_get_ArticyHierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663680 /*0x06000180*/);
    ArticyHierarchyManager.NativeMethodInfoPtr_GetHierarchyInfo_Public_ArticyHierarchyNode_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663681);
    ArticyHierarchyManager.NativeMethodInfoPtr_SetRootHierarchyNode_Private_Void_ArticyHierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663682);
    ArticyHierarchyManager.NativeMethodInfoPtr_BuildHierarchyIdMap_Private_Void_ArticyHierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663683);
    ArticyHierarchyManager.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663684);
    ArticyHierarchyManager.NativeMethodInfoPtr_AddNodeToSerializedNodes_Private_Void_ArticyHierarchyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663685);
    ArticyHierarchyManager.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663686);
    ArticyHierarchyManager.NativeMethodInfoPtr_ReadNodeFromSerializedNodes_Private_ArticyHierarchyNode_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663687);
    ArticyHierarchyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr, 100663688);
  }

  public unsafe ArticyHierarchyNode ProjectNode
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr_get_ProjectNode_Public_get_ArticyHierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ArticyHierarchyNode) null : Il2CppObjectPool.Get<ArticyHierarchyNode>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989610, XrefRangeEnd = 989613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyHierarchyNode GetHierarchyInfo(ulong aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &aId
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr_GetHierarchyInfo_Public_ArticyHierarchyNode_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ArticyHierarchyNode) null : Il2CppObjectPool.Get<ArticyHierarchyNode>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989613, XrefRangeEnd = 989618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRootHierarchyNode(ArticyHierarchyNode aRoot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aRoot)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr_SetRootHierarchyNode_Private_Void_ArticyHierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 989642, RefRangeEnd = 989644, XrefRangeStart = 989618, XrefRangeEnd = 989642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BuildHierarchyIdMap(ArticyHierarchyNode aRoot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aRoot)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr_BuildHierarchyIdMap_Private_Void_ArticyHierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989644, XrefRangeEnd = 989653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 989691, RefRangeEnd = 989693, XrefRangeStart = 989653, XrefRangeEnd = 989691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddNodeToSerializedNodes(ArticyHierarchyNode aNode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNode)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr_AddNodeToSerializedNodes_Private_Void_ArticyHierarchyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989693, XrefRangeEnd = 989698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 989725, RefRangeEnd = 989727, XrefRangeStart = 989698, XrefRangeEnd = 989725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyHierarchyNode ReadNodeFromSerializedNodes(ref int index)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref index
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr_ReadNodeFromSerializedNodes_Private_ArticyHierarchyNode_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ArticyHierarchyNode) null : Il2CppObjectPool.Get<ArticyHierarchyNode>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989727, XrefRangeEnd = 989740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyHierarchyManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyHierarchyManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyHierarchyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyHierarchyNode mRoot
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyManager.NativeFieldInfoPtr_mRoot));
      return num == IntPtr.Zero ? (ArticyHierarchyNode) null : Il2CppObjectPool.Get<ArticyHierarchyNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyManager.NativeFieldInfoPtr_mRoot), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ulong, ArticyHierarchyNode> mHierarchyIdMap
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyManager.NativeFieldInfoPtr_mHierarchyIdMap));
      return num == IntPtr.Zero ? (Dictionary<ulong, ArticyHierarchyNode>) null : Il2CppObjectPool.Get<Dictionary<ulong, ArticyHierarchyNode>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyManager.NativeFieldInfoPtr_mHierarchyIdMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<SerializableArticyHierarchyNode> serializedNodes
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyManager.NativeFieldInfoPtr_serializedNodes));
      return num == IntPtr.Zero ? (List<SerializableArticyHierarchyNode>) null : Il2CppObjectPool.Get<List<SerializableArticyHierarchyNode>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyHierarchyManager.NativeFieldInfoPtr_serializedNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
