// Decompiled with JetBrains decompiler
// Type: UnityEngine.SceneManagement.Scene
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.SceneManagement;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct Scene
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_handle_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_guid_Internal_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scene_Scene_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNameInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGUIDInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0;
  [FieldOffset(0)]
  public int m_Handle;
  private static readonly Scene.IsSubSceneDelegate IsSubSceneDelegateField;
  private static readonly Scene.SetIsSubSceneDelegate SetIsSubSceneDelegateField;
  private static readonly Scene.GetLoadingStateInternalDelegate GetLoadingStateInternalDelegateField;
  private static readonly Scene.GetIsDirtyInternalDelegate GetIsDirtyInternalDelegateField;
  private static readonly Scene.GetDirtyIDDelegate GetDirtyIDDelegateField;
  private static readonly Scene.GetBuildIndexInternalDelegate GetBuildIndexInternalDelegateField;
  private static readonly Scene.GetPathInternal_InjectedDelegate GetPathInternal_InjectedDelegateField;
  private static readonly Scene.SetPathAndGUIDInternal_InjectedDelegate SetPathAndGUIDInternal_InjectedDelegateField;
  private static readonly Scene.SetNameInternal_InjectedDelegate SetNameInternal_InjectedDelegateField;

  static Scene()
  {
    Il2CppClassPointerStore<Scene>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.SceneManagement", nameof (Scene));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Scene>.NativeClassPtr);
    Scene.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Scene>.NativeClassPtr, nameof (m_Handle));
    Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669205);
    Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669206);
    Scene.NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669207);
    Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669208);
    Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669209);
    Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669210);
    Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669211);
    Scene.NativeMethodInfoPtr_get_guid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669212);
    Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669213);
    Scene.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669214);
    Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669215);
    Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669216);
    Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669217);
    Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669218);
    Scene.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669219);
    Scene.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scene_Scene_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669220);
    Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669221);
    Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669222);
    Scene.NativeMethodInfoPtr_GetNameInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669223);
    Scene.NativeMethodInfoPtr_GetGUIDInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Scene>.NativeClassPtr, 100669224);
    Scene.IsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.IsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::IsSubScene");
    Scene.SetIsSubSceneDelegateField = IL2CPP.ResolveICall<Scene.SetIsSubSceneDelegate>("UnityEngine.SceneManagement.Scene::SetIsSubScene");
    Scene.GetLoadingStateInternalDelegateField = IL2CPP.ResolveICall<Scene.GetLoadingStateInternalDelegate>("UnityEngine.SceneManagement.Scene::GetLoadingStateInternal");
    Scene.GetIsDirtyInternalDelegateField = IL2CPP.ResolveICall<Scene.GetIsDirtyInternalDelegate>("UnityEngine.SceneManagement.Scene::GetIsDirtyInternal");
    Scene.GetDirtyIDDelegateField = IL2CPP.ResolveICall<Scene.GetDirtyIDDelegate>("UnityEngine.SceneManagement.Scene::GetDirtyID");
    Scene.GetBuildIndexInternalDelegateField = IL2CPP.ResolveICall<Scene.GetBuildIndexInternalDelegate>("UnityEngine.SceneManagement.Scene::GetBuildIndexInternal");
    Scene.GetPathInternal_InjectedDelegateField = IL2CPP.ResolveICall<Scene.GetPathInternal_InjectedDelegate>("UnityEngine.SceneManagement.Scene::GetPathInternal_Injected");
    Scene.SetPathAndGUIDInternal_InjectedDelegateField = IL2CPP.ResolveICall<Scene.SetPathAndGUIDInternal_InjectedDelegate>("UnityEngine.SceneManagement.Scene::SetPathAndGUIDInternal_Injected");
    Scene.SetNameInternal_InjectedDelegateField = IL2CPP.ResolveICall<Scene.SetNameInternal_InjectedDelegate>("UnityEngine.SceneManagement.Scene::SetNameInternal_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478649, XrefRangeEnd = 478651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsValidInternal(int sceneHandle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sceneHandle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValidInternal_Private_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478656, RefRangeEnd = 478657, XrefRangeStart = 478651, XrefRangeEnd = 478656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetNameInternal(int sceneHandle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sceneHandle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetNameInternal_Private_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478662, RefRangeEnd = 478663, XrefRangeStart = 478657, XrefRangeEnd = 478662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string GetGUIDInternal(int sceneHandle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sceneHandle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetGUIDInternal_Private_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478663, XrefRangeEnd = 478665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetIsLoadedInternal(int sceneHandle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sceneHandle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetIsLoadedInternal_Private_Static_Boolean_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478665, XrefRangeEnd = 478667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetRootCountInternal(int sceneHandle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &sceneHandle
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootCountInternal_Private_Static_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478667, XrefRangeEnd = 478669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetRootGameObjectsInternal(int sceneHandle, Il2CppSystem.Object resultRootList)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sceneHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultRootList);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjectsInternal_Private_Static_Void_Int32_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int handle
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_handle_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string guid
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478669, XrefRangeEnd = 478670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_guid_Internal_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 478672, RefRangeEnd = 478677, XrefRangeStart = 478670, XrefRangeEnd = 478672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_IsValid_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe string name
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 478678, RefRangeEnd = 478686, XrefRangeStart = 478677, XrefRangeEnd = 478678, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_name_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    set => Scene.SetNameInternal(this.handle, value);
  }

  public unsafe bool isLoaded
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 478688, RefRangeEnd = 478692, XrefRangeStart = 478686, XrefRangeEnd = 478688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_isLoaded_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int rootCount
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478692, XrefRangeEnd = 478694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_get_rootCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478707, RefRangeEnd = 478708, XrefRangeStart = 478694, XrefRangeEnd = 478707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppReferenceArray<GameObject> GetRootGameObjects()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Il2CppReferenceArray_1_GameObject_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<GameObject>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478732, RefRangeEnd = 478733, XrefRangeStart = 478708, XrefRangeEnd = 478732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetRootGameObjects(List<GameObject> rootGameObjects)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rootGameObjects)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetRootGameObjects_Public_Void_List_1_GameObject_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 307349, RefRangeEnd = 307358, XrefRangeStart = 307349, XrefRangeEnd = 307358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(Scene lhs, Scene rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Scene_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478733, RefRangeEnd = 478734, XrefRangeStart = 478733, XrefRangeEnd = 478733, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(Scene lhs, Scene rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Scene_Scene_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(239)]
  [CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478737, RefRangeEnd = 478738, XrefRangeStart = 478734, XrefRangeEnd = 478737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478738, XrefRangeEnd = 478740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetNameInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sceneHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetNameInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478740, XrefRangeEnd = 478742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetGUIDInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sceneHandle;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Scene.NativeMethodInfoPtr_GetGUIDInternal_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Scene>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static string GetPathInternal(int sceneHandle)
  {
    ManagedSpanWrapper ret;
    string stringAndDispose;
    try
    {
      Scene.GetPathInternal_Injected(sceneHandle, out ret);
    }
    finally
    {
      stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
    }
    return stringAndDispose;
  }

  public static unsafe void SetPathAndGUIDInternal(int sceneHandle, string path, string guid)
  {
    try
    {
      int sceneHandle1 = sceneHandle;
      ManagedSpanWrapper managedSpanWrapper1;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(path, ref managedSpanWrapper1))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = path.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper1 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local1 = ref managedSpanWrapper1;
      ManagedSpanWrapper managedSpanWrapper2;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(guid, ref managedSpanWrapper2))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = guid.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper2 = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper2;
      Scene.SetPathAndGUIDInternal_Injected(sceneHandle1, ref local1, ref local2);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void SetNameInternal(int sceneHandle, string name)
  {
    try
    {
      int sceneHandle1 = sceneHandle;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      Scene.SetNameInternal_Injected(sceneHandle1, ref local);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static bool IsSubScene(int sceneHandle) => Scene.IsSubSceneDelegateField(sceneHandle);

  public static void SetIsSubScene(int sceneHandle, bool value)
  {
    Scene.SetIsSubSceneDelegateField(sceneHandle, value);
  }

  public static Scene.LoadingState GetLoadingStateInternal(int sceneHandle)
  {
    return Scene.GetLoadingStateInternalDelegateField(sceneHandle);
  }

  public static bool GetIsDirtyInternal(int sceneHandle)
  {
    return Scene.GetIsDirtyInternalDelegateField(sceneHandle);
  }

  public static int GetDirtyID(int sceneHandle) => Scene.GetDirtyIDDelegateField(sceneHandle);

  public static int GetBuildIndexInternal(int sceneHandle)
  {
    return Scene.GetBuildIndexInternalDelegateField(sceneHandle);
  }

  public Scene.LoadingState loadingState => Scene.GetLoadingStateInternal(this.handle);

  public string path => Scene.GetPathInternal(this.handle);

  public int buildIndex => Scene.GetBuildIndexInternal(this.handle);

  public bool isDirty => Scene.GetIsDirtyInternal(this.handle);

  public int dirtyID => Scene.GetDirtyID(this.handle);

  public bool isSubScene
  {
    get => Scene.IsSubScene(this.handle);
    set => Scene.SetIsSubScene(this.handle, value);
  }

  public void SetPathAndGuid(string path, string guid)
  {
    Scene.SetPathAndGUIDInternal(this.m_Handle, path, guid);
  }

  public static void GetPathInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret)
  {
    Scene.GetPathInternal_InjectedDelegateField(sceneHandle, (System.IntPtr) ref ret);
  }

  public static void SetPathAndGUIDInternal_Injected(
    int sceneHandle,
    ref ManagedSpanWrapper path,
    ref ManagedSpanWrapper guid)
  {
    Scene.SetPathAndGUIDInternal_InjectedDelegateField(sceneHandle, (System.IntPtr) ref path, (System.IntPtr) ref guid);
  }

  public static void SetNameInternal_Injected(int sceneHandle, ref ManagedSpanWrapper name)
  {
    Scene.SetNameInternal_InjectedDelegateField(sceneHandle, (System.IntPtr) ref name);
  }

  public enum LoadingState
  {
    NotLoaded,
    Loading,
    Loaded,
    Unloading,
  }

  private delegate bool IsSubSceneDelegate(int sceneHandle);

  private delegate void SetIsSubSceneDelegate(int sceneHandle, bool value);

  private delegate Scene.LoadingState GetLoadingStateInternalDelegate(int sceneHandle);

  private delegate bool GetIsDirtyInternalDelegate(int sceneHandle);

  private delegate int GetDirtyIDDelegate(int sceneHandle);

  private delegate int GetBuildIndexInternalDelegate(int sceneHandle);

  private delegate void GetPathInternal_InjectedDelegate(int sceneHandle, [Out] System.IntPtr ret);

  private delegate void SetPathAndGUIDInternal_InjectedDelegate(
    int sceneHandle,
    System.IntPtr path,
    System.IntPtr guid);

  private delegate void SetNameInternal_InjectedDelegate(int sceneHandle, System.IntPtr name);
}
