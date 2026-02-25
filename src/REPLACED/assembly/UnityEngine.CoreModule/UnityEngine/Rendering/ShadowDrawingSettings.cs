// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ShadowDrawingSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct ShadowDrawingSettings
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingResults;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LightIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UseRenderingLayerMaskTest;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SplitData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectsFilter;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProjectionType;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_objectsFilter_Public_set_Void_ShadowObjectsFilter_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public CullingResults m_CullingResults;
  [FieldOffset(16 /*0x10*/)]
  public int m_LightIndex;
  [FieldOffset(20)]
  public int m_SplitIndex;
  [FieldOffset(24)]
  public int m_UseRenderingLayerMaskTest;
  [FieldOffset(28)]
  public uint m_BatchLayerMask;
  [FieldOffset(32 /*0x20*/)]
  public ShadowSplitData m_SplitData;
  [FieldOffset(284)]
  public ShadowObjectsFilter m_ObjectsFilter;
  [FieldOffset(288)]
  public BatchCullingProjectionType m_ProjectionType;

  static ShadowDrawingSettings()
  {
    Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ShadowDrawingSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr);
    ShadowDrawingSettings.NativeFieldInfoPtr_m_CullingResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, nameof (m_CullingResults));
    ShadowDrawingSettings.NativeFieldInfoPtr_m_LightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, nameof (m_LightIndex));
    ShadowDrawingSettings.NativeFieldInfoPtr_m_SplitIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, nameof (m_SplitIndex));
    ShadowDrawingSettings.NativeFieldInfoPtr_m_UseRenderingLayerMaskTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, nameof (m_UseRenderingLayerMaskTest));
    ShadowDrawingSettings.NativeFieldInfoPtr_m_BatchLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, nameof (m_BatchLayerMask));
    ShadowDrawingSettings.NativeFieldInfoPtr_m_SplitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, nameof (m_SplitData));
    ShadowDrawingSettings.NativeFieldInfoPtr_m_ObjectsFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, nameof (m_ObjectsFilter));
    ShadowDrawingSettings.NativeFieldInfoPtr_m_ProjectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, nameof (m_ProjectionType));
    ShadowDrawingSettings.NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100670565);
    ShadowDrawingSettings.NativeMethodInfoPtr_set_objectsFilter_Public_set_Void_ShadowObjectsFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100670566);
    ShadowDrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100670567);
    ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100670568);
    ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100670569);
    ShadowDrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, 100670570);
  }

  public unsafe bool useRenderingLayerMaskTest
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 488614, RefRangeEnd = 488617, XrefRangeStart = 488614, XrefRangeEnd = 488614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_set_useRenderingLayerMaskTest_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_UseRenderingLayerMaskTest != 0;
  }

  public unsafe ShadowObjectsFilter objectsFilter
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488617, RefRangeEnd = 488618, XrefRangeStart = 488617, XrefRangeEnd = 488617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_set_objectsFilter_Public_set_Void_ShadowObjectsFilter_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ObjectsFilter;
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488623, RefRangeEnd = 488625, XrefRangeStart = 488618, XrefRangeEnd = 488623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShadowDrawingSettings(CullingResults cullingResults, int lightIndex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &cullingResults;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lightIndex;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_CullingResults_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488639, RefRangeEnd = 488640, XrefRangeStart = 488625, XrefRangeEnd = 488639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(ShadowDrawingSettings other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowDrawingSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488640, XrefRangeEnd = 488644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488644, XrefRangeEnd = 488649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowDrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowDrawingSettings>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public CullingResults cullingResults
  {
    get => this.m_CullingResults;
    set => this.m_CullingResults = value;
  }

  public int lightIndex
  {
    get => this.m_LightIndex;
    set => this.m_LightIndex = value;
  }

  public int splitIndex
  {
    get => this.m_SplitIndex;
    set => this.m_SplitIndex = value;
  }

  public uint batchLayerMask
  {
    get => this.m_BatchLayerMask;
    set => this.m_BatchLayerMask = value;
  }

  public ShadowSplitData splitData
  {
    get => this.m_SplitData;
    set => this.m_SplitData = value;
  }

  public BatchCullingProjectionType projectionType
  {
    get => this.m_ProjectionType;
    set => this.m_ProjectionType = value;
  }

  public static bool operator ==(ShadowDrawingSettings left, ShadowDrawingSettings right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(ShadowDrawingSettings left, ShadowDrawingSettings right)
  {
    return !left.Equals(right);
  }
}
