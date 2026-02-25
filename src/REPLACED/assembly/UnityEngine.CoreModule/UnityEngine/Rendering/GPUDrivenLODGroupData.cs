// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.GPUDrivenLODGroupData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class GPUDrivenLODGroupData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_lodGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceReferencePoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_worldSpaceSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_renderersCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastLODIsBillboard;
  private static readonly System.IntPtr NativeFieldInfoPtr_forceLODMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_invalidLODGroupID;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodRenderersCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodScreenRelativeTransitionHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_lodFadeTransitionWidth;

  static GPUDrivenLODGroupData()
  {
    Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (GPUDrivenLODGroupData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr);
    GPUDrivenLODGroupData.NativeFieldInfoPtr_lodGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (lodGroupID));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_lodOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (lodOffset));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_lodCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (lodCount));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_fadeMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (fadeMode));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_worldSpaceReferencePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (worldSpaceReferencePoint));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_worldSpaceSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (worldSpaceSize));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_renderersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (renderersCount));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_lastLODIsBillboard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (lastLODIsBillboard));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_forceLODMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (forceLODMask));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_invalidLODGroupID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (invalidLODGroupID));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_lodRenderersCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (lodRenderersCount));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_lodScreenRelativeTransitionHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (lodScreenRelativeTransitionHeight));
    GPUDrivenLODGroupData.NativeFieldInfoPtr_lodFadeTransitionWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr, nameof (lodFadeTransitionWidth));
  }

  public GPUDrivenLODGroupData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public GPUDrivenLODGroupData()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GPUDrivenLODGroupData>.NativeClassPtr))
  {
  }

  public NativeArray<int> lodGroupID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodGroupID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> lodOffset
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodOffset);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodOffset), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> lodCount
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodCount);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<LODFadeMode> fadeMode
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_fadeMode);
      return new NativeArray<LODFadeMode>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<LODFadeMode>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_fadeMode), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<LODFadeMode>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<Vector3> worldSpaceReferencePoint
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_worldSpaceReferencePoint);
      return new NativeArray<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_worldSpaceReferencePoint), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Vector3>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<float> worldSpaceSize
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_worldSpaceSize);
      return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_worldSpaceSize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<short> renderersCount
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_renderersCount);
      return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_renderersCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<bool> lastLODIsBillboard
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lastLODIsBillboard);
      return new NativeArray<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lastLODIsBillboard), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<byte> forceLODMask
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_forceLODMask);
      return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_forceLODMask), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> invalidLODGroupID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_invalidLODGroupID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_invalidLODGroupID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<short> lodRenderersCount
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodRenderersCount);
      return new NativeArray<short>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodRenderersCount), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<short>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<float> lodScreenRelativeTransitionHeight
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodScreenRelativeTransitionHeight);
      return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodScreenRelativeTransitionHeight), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<float> lodFadeTransitionWidth
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodFadeTransitionWidth);
      return new NativeArray<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GPUDrivenLODGroupData.NativeFieldInfoPtr_lodFadeTransitionWidth), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
