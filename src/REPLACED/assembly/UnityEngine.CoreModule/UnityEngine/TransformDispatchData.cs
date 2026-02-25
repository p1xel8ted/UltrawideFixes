// Decompiled with JetBrains decompiler
// Type: UnityEngine.TransformDispatchData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine;

public sealed class TransformDispatchData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_transformedID;
  private static readonly System.IntPtr NativeFieldInfoPtr_parentID;
  private static readonly System.IntPtr NativeFieldInfoPtr_localToWorldMatrices;
  private static readonly System.IntPtr NativeFieldInfoPtr_positions;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotations;
  private static readonly System.IntPtr NativeFieldInfoPtr_scales;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

  static TransformDispatchData()
  {
    Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TransformDispatchData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr);
    TransformDispatchData.NativeFieldInfoPtr_transformedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, nameof (transformedID));
    TransformDispatchData.NativeFieldInfoPtr_parentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, nameof (parentID));
    TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, nameof (localToWorldMatrices));
    TransformDispatchData.NativeFieldInfoPtr_positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, nameof (positions));
    TransformDispatchData.NativeFieldInfoPtr_rotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, nameof (rotations));
    TransformDispatchData.NativeFieldInfoPtr_scales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, nameof (scales));
    TransformDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr, 100667668);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441366, XrefRangeEnd = 441382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public TransformDispatchData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public TransformDispatchData()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformDispatchData>.NativeClassPtr))
  {
  }

  public NativeArray<int> transformedID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_transformedID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_transformedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> parentID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_parentID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_parentID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Matrix4x4> localToWorldMatrices
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices);
      return new NativeArray<Matrix4x4>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_localToWorldMatrices), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Matrix4x4>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Vector3> positions
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_positions);
      return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_positions), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Quaternion> rotations
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_rotations);
      return new NativeArray<Quaternion>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Quaternion>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_rotations), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Quaternion>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Vector3> scales
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_scales);
      return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TransformDispatchData.NativeFieldInfoPtr_scales), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
