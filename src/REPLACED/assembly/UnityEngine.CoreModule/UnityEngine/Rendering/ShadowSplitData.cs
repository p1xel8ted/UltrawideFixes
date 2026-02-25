// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ShadowSplitData
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
public struct ShadowSplitData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumCullingPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_maximumCullingPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingPlaneCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingPlanes;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingSphere;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowCascadeBlendCullingFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingNearPlane;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingMatrix;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public int m_CullingPlaneCount;
  [FieldOffset(4)]
  public ShadowSplitData._m_CullingPlanes_e__FixedBuffer m_CullingPlanes;
  [FieldOffset(164)]
  public Vector4 m_CullingSphere;
  [FieldOffset(180)]
  public float m_ShadowCascadeBlendCullingFactor;
  [FieldOffset(184)]
  public float m_CullingNearPlane;
  [FieldOffset(188)]
  public Matrix4x4 m_CullingMatrix;

  static ShadowSplitData()
  {
    Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ShadowSplitData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr);
    ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, nameof (k_MaximumCullingPlaneCount));
    ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, nameof (maximumCullingPlaneCount));
    ShadowSplitData.NativeFieldInfoPtr_m_CullingPlaneCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, nameof (m_CullingPlaneCount));
    ShadowSplitData.NativeFieldInfoPtr_m_CullingPlanes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, nameof (m_CullingPlanes));
    ShadowSplitData.NativeFieldInfoPtr_m_CullingSphere = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, nameof (m_CullingSphere));
    ShadowSplitData.NativeFieldInfoPtr_m_ShadowCascadeBlendCullingFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, nameof (m_ShadowCascadeBlendCullingFactor));
    ShadowSplitData.NativeFieldInfoPtr_m_CullingNearPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, nameof (m_CullingNearPlane));
    ShadowSplitData.NativeFieldInfoPtr_m_CullingMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, nameof (m_CullingMatrix));
    ShadowSplitData.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100670571);
    ShadowSplitData.NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100670572);
    ShadowSplitData.NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100670573);
    ShadowSplitData.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100670574);
    ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100670575);
    ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100670576);
    ShadowSplitData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, 100670577);
  }

  public unsafe int cullingPlaneCount
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_get_cullingPlaneCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      this.m_CullingPlaneCount = value >= 0 && value <= 10 ? value : throw new Il2CppSystem.ArgumentException(Il2CppSystem.String.Format("Value should range from {0} to ShadowSplitData.maximumCullingPlaneCount ({1}), but was {2}.", (Il2CppSystem.Object) (System.ValueType) 0, (Il2CppSystem.Object) (System.ValueType) 10, (Il2CppSystem.Object) (System.ValueType) value));
    }
  }

  public unsafe Vector4 cullingSphere
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 488649, RefRangeEnd = 488652, XrefRangeStart = 488649, XrefRangeEnd = 488649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_get_cullingSphere_Public_get_Vector4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_CullingSphere = value;
  }

  public unsafe float shadowCascadeBlendCullingFactor
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 488652, RefRangeEnd = 488654, XrefRangeStart = 488652, XrefRangeEnd = 488652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_set_shadowCascadeBlendCullingFactor_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ShadowCascadeBlendCullingFactor;
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488657, RefRangeEnd = 488659, XrefRangeStart = 488654, XrefRangeEnd = 488657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Plane GetCullingPlane(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_GetCullingPlane_Public_Plane_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Plane*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488672, RefRangeEnd = 488674, XrefRangeStart = 488659, XrefRangeEnd = 488672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(ShadowSplitData other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShadowSplitData_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488674, XrefRangeEnd = 488680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488684, RefRangeEnd = 488685, XrefRangeStart = 488680, XrefRangeEnd = 488684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShadowSplitData.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe int k_MaximumCullingPlaneCount
  {
    get
    {
      int cullingPlaneCount;
      IL2CPP.il2cpp_field_static_get_value(ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*) &cullingPlaneCount);
      return cullingPlaneCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowSplitData.NativeFieldInfoPtr_k_MaximumCullingPlaneCount, (void*) &value);
    }
  }

  public static unsafe int maximumCullingPlaneCount
  {
    get
    {
      int cullingPlaneCount;
      IL2CPP.il2cpp_field_static_get_value(ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*) &cullingPlaneCount);
      return cullingPlaneCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShadowSplitData.NativeFieldInfoPtr_maximumCullingPlaneCount, (void*) &value);
    }
  }

  public Matrix4x4 cullingMatrix
  {
    get => this.m_CullingMatrix;
    set => this.m_CullingMatrix = value;
  }

  public float cullingNearPlane
  {
    get => this.m_CullingNearPlane;
    set => this.m_CullingNearPlane = value;
  }

  public void SetCullingPlane(int index, Plane plane)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static bool operator ==(ShadowSplitData left, ShadowSplitData right) => left.Equals(right);

  public static bool operator !=(ShadowSplitData left, ShadowSplitData right)
  {
    return !left.Equals(right);
  }

  [ObfuscatedName("UnityEngine.Rendering.ShadowSplitData+<m_CullingPlanes>e__FixedBuffer")]
  [StructLayout(LayoutKind.Explicit)]
  public struct _m_CullingPlanes_e__FixedBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
    [FieldOffset(0)]
    public byte FixedElementField;

    static _m_CullingPlanes_e__FixedBuffer()
    {
      Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShadowSplitData>.NativeClassPtr, "<m_CullingPlanes>e__FixedBuffer");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr);
      ShadowSplitData._m_CullingPlanes_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShadowSplitData._m_CullingPlanes_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
