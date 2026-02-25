// Decompiled with JetBrains decompiler
// Type: UnityEngine.Jobs.TransformAccessArray
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Jobs;

[StructLayout(LayoutKind.Explicit)]
public struct TransformAccessArray
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TransformArray;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Transform_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_length_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTransforms_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Injected_Private_Static_Void_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Injected_Private_Static_IntPtr_IntPtr_Int32_0;
  [FieldOffset(0)]
  public System.IntPtr m_TransformArray;
  private static readonly TransformAccessArray.AddInstanceIdDelegate AddInstanceIdDelegateField;
  private static readonly TransformAccessArray.RemoveAtSwapBackDelegate RemoveAtSwapBackDelegateField;
  private static readonly TransformAccessArray.GetCapacityDelegate GetCapacityDelegateField;
  private static readonly TransformAccessArray.SetCapacityDelegate SetCapacityDelegateField;
  private static readonly TransformAccessArray.SetTransform_InjectedDelegate SetTransform_InjectedDelegateField;

  static TransformAccessArray()
  {
    Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", nameof (TransformAccessArray));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr);
    TransformAccessArray.NativeFieldInfoPtr_m_TransformArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, nameof (m_TransformArray));
    TransformAccessArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668939);
    TransformAccessArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668940);
    TransformAccessArray.NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668941);
    TransformAccessArray.NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668942);
    TransformAccessArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668943);
    TransformAccessArray.NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668944);
    TransformAccessArray.NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668945);
    TransformAccessArray.NativeMethodInfoPtr_get_length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668946);
    TransformAccessArray.NativeMethodInfoPtr_Add_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668947);
    TransformAccessArray.NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668948);
    TransformAccessArray.NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668949);
    TransformAccessArray.NativeMethodInfoPtr_SetTransforms_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668950);
    TransformAccessArray.NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668951);
    TransformAccessArray.NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668952);
    TransformAccessArray.NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668953);
    TransformAccessArray.NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668954);
    TransformAccessArray.NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668955);
    TransformAccessArray.NativeMethodInfoPtr_Add_Injected_Private_Static_Void_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668956);
    TransformAccessArray.NativeMethodInfoPtr_GetTransform_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, 100668957);
    TransformAccessArray.AddInstanceIdDelegateField = IL2CPP.ResolveICall<TransformAccessArray.AddInstanceIdDelegate>("UnityEngine.Jobs.TransformAccessArray::AddInstanceId");
    TransformAccessArray.RemoveAtSwapBackDelegateField = IL2CPP.ResolveICall<TransformAccessArray.RemoveAtSwapBackDelegate>("UnityEngine.Jobs.TransformAccessArray::RemoveAtSwapBack");
    TransformAccessArray.GetCapacityDelegateField = IL2CPP.ResolveICall<TransformAccessArray.GetCapacityDelegate>("UnityEngine.Jobs.TransformAccessArray::GetCapacity");
    TransformAccessArray.SetCapacityDelegateField = IL2CPP.ResolveICall<TransformAccessArray.SetCapacityDelegate>("UnityEngine.Jobs.TransformAccessArray::SetCapacity");
    TransformAccessArray.SetTransform_InjectedDelegateField = IL2CPP.ResolveICall<TransformAccessArray.SetTransform_InjectedDelegate>("UnityEngine.Jobs.TransformAccessArray::SetTransform_Injected");
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472496, RefRangeEnd = 472497, XrefRangeStart = 472490, XrefRangeEnd = 472496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TransformAccessArray(
    Il2CppReferenceArray<Transform> transforms,
    int desiredJobCount = -1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transforms);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &desiredJobCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Transform_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472500, RefRangeEnd = 472501, XrefRangeStart = 472497, XrefRangeEnd = 472500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TransformAccessArray(int capacity, int desiredJobCount = -1)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &capacity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &desiredJobCount;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472501, XrefRangeEnd = 472504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Allocate(
    int capacity,
    int desiredJobCount,
    out TransformAccessArray array)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &capacity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &desiredJobCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref array;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Allocate_Public_Static_Void_Int32_Int32_byref_TransformAccessArray_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool isCreated
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 472504, RefRangeEnd = 472505, XrefRangeStart = 472504, XrefRangeEnd = 472504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 472508, RefRangeEnd = 472510, XrefRangeStart = 472505, XrefRangeEnd = 472508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(192 /*0xC0*/)]
  [CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe System.IntPtr GetTransformAccessArrayForSchedule()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetTransformAccessArrayForSchedule_Internal_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Transform this[int index]
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 472515, RefRangeEnd = 472516, XrefRangeStart = 472510, XrefRangeEnd = 472515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_Item_Public_get_Transform_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
    }
    set => TransformAccessArray.SetTransform(this.m_TransformArray, index, value);
  }

  public unsafe int length
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 472518, RefRangeEnd = 472520, XrefRangeStart = 472516, XrefRangeEnd = 472518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_get_length_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472525, RefRangeEnd = 472526, XrefRangeStart = 472520, XrefRangeEnd = 472525, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(Transform transform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Add_Public_Void_Transform_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472526, XrefRangeEnd = 472528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr Create(int capacity, int desiredJobCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &capacity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &desiredJobCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Create_Private_Static_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472528, XrefRangeEnd = 472530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyTransformAccessArray(System.IntPtr transformArray)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &transformArray
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_DestroyTransformAccessArray_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472530, XrefRangeEnd = 472532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTransforms(
    System.IntPtr transformArrayIntPtr,
    Il2CppReferenceArray<Transform> transforms)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &transformArrayIntPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transforms);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_SetTransforms_Private_Static_Void_IntPtr_Il2CppReferenceArray_1_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472532, XrefRangeEnd = 472537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Add(System.IntPtr transformArrayIntPtr, Transform transform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &transformArrayIntPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Add_Private_Static_Void_IntPtr_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472539, RefRangeEnd = 472540, XrefRangeStart = 472537, XrefRangeEnd = 472539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetSortedTransformAccess(System.IntPtr transformArrayIntPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &transformArrayIntPtr
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetSortedTransformAccess_Internal_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472542, RefRangeEnd = 472543, XrefRangeStart = 472540, XrefRangeEnd = 472542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetSortedToUserIndex(System.IntPtr transformArrayIntPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &transformArrayIntPtr
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetSortedToUserIndex_Internal_Static_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472543, XrefRangeEnd = 472545, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetLength(System.IntPtr transformArrayIntPtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &transformArrayIntPtr
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetLength_Internal_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472545, XrefRangeEnd = 472550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Transform GetTransform(System.IntPtr transformArrayIntPtr, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &transformArrayIntPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetTransform_Internal_Static_Transform_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472550, XrefRangeEnd = 472552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Add_Injected(System.IntPtr transformArrayIntPtr, System.IntPtr transform)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &transformArrayIntPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &transform;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_Add_Injected_Private_Static_Void_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472552, XrefRangeEnd = 472554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetTransform_Injected(System.IntPtr transformArrayIntPtr, int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &transformArrayIntPtr;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &index;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccessArray.NativeMethodInfoPtr_GetTransform_Injected_Private_Static_IntPtr_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformAccessArray>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public int capacity
  {
    get => TransformAccessArray.GetCapacity(this.m_TransformArray);
    set => TransformAccessArray.SetCapacity(this.m_TransformArray, value);
  }

  public void Add(int instanceId)
  {
    TransformAccessArray.AddInstanceId(this.m_TransformArray, instanceId);
  }

  public void RemoveAtSwapBack(int index)
  {
    TransformAccessArray.RemoveAtSwapBack(this.m_TransformArray, index);
  }

  public void SetTransforms(Il2CppReferenceArray<Transform> transforms)
  {
    TransformAccessArray.SetTransforms(this.m_TransformArray, transforms);
  }

  public static void AddInstanceId(System.IntPtr transformArrayIntPtr, int instanceId)
  {
    TransformAccessArray.AddInstanceIdDelegateField(transformArrayIntPtr, instanceId);
  }

  public static void RemoveAtSwapBack(System.IntPtr transformArrayIntPtr, int index)
  {
    TransformAccessArray.RemoveAtSwapBackDelegateField(transformArrayIntPtr, index);
  }

  public static int GetCapacity(System.IntPtr transformArrayIntPtr)
  {
    return TransformAccessArray.GetCapacityDelegateField(transformArrayIntPtr);
  }

  public static void SetCapacity(System.IntPtr transformArrayIntPtr, int capacity)
  {
    TransformAccessArray.SetCapacityDelegateField(transformArrayIntPtr, capacity);
  }

  public static void SetTransform(System.IntPtr transformArrayIntPtr, int index, Transform transform)
  {
    TransformAccessArray.SetTransform_Injected(transformArrayIntPtr, index, UnityEngine.Object.MarshalledUnityObject.Marshal<Transform>(transform));
  }

  public static void SetTransform_Injected(
    System.IntPtr transformArrayIntPtr,
    int index,
    System.IntPtr transform)
  {
    TransformAccessArray.SetTransform_InjectedDelegateField(transformArrayIntPtr, index, transform);
  }

  private delegate void AddInstanceIdDelegate(System.IntPtr transformArrayIntPtr, int instanceId);

  private delegate void RemoveAtSwapBackDelegate(System.IntPtr transformArrayIntPtr, int index);

  private delegate int GetCapacityDelegate(System.IntPtr transformArrayIntPtr);

  private delegate void SetCapacityDelegate(System.IntPtr transformArrayIntPtr, int capacity);

  private delegate void SetTransform_InjectedDelegate(
    System.IntPtr transformArrayIntPtr,
    int index,
    System.IntPtr transform);
}
