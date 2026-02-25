// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SortingSettings
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
public struct SortingSettings
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WorldToCameraMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomAxis;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Criteria;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DistanceMetric;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Camera_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public Matrix4x4 m_WorldToCameraMatrix;
  [FieldOffset(64 /*0x40*/)]
  public Vector3 m_CameraPosition;
  [FieldOffset(76)]
  public Vector3 m_CustomAxis;
  [FieldOffset(88)]
  public SortingCriteria m_Criteria;
  [FieldOffset(92)]
  public DistanceMetric m_DistanceMetric;

  static SortingSettings()
  {
    Il2CppClassPointerStore<SortingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (SortingSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr);
    SortingSettings.NativeFieldInfoPtr_m_WorldToCameraMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, nameof (m_WorldToCameraMatrix));
    SortingSettings.NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, nameof (m_CameraPosition));
    SortingSettings.NativeFieldInfoPtr_m_CustomAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, nameof (m_CustomAxis));
    SortingSettings.NativeFieldInfoPtr_m_Criteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, nameof (m_Criteria));
    SortingSettings.NativeFieldInfoPtr_m_DistanceMetric = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, nameof (m_DistanceMetric));
    SortingSettings.NativeMethodInfoPtr__ctor_Public_Void_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100670583);
    SortingSettings.NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100670584);
    SortingSettings.NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100670585);
    SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100670586);
    SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100670587);
    SortingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, 100670588);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488699, RefRangeEnd = 488701, XrefRangeStart = 488688, XrefRangeEnd = 488699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SortingSettings(Camera camera)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) camera)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr__ctor_Public_Void_Camera_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SortingCriteria criteria
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_get_criteria_Public_get_SortingCriteria_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SortingCriteria*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_set_criteria_Public_set_Void_SortingCriteria_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488703, RefRangeEnd = 488705, XrefRangeStart = 488701, XrefRangeEnd = 488703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(SortingSettings other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488705, XrefRangeEnd = 488709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488716, RefRangeEnd = 488718, XrefRangeStart = 488709, XrefRangeEnd = 488716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingSettings>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public Matrix4x4 worldToCameraMatrix
  {
    get => this.m_WorldToCameraMatrix;
    set => this.m_WorldToCameraMatrix = value;
  }

  public Vector3 cameraPosition
  {
    get => this.m_CameraPosition;
    set => this.m_CameraPosition = value;
  }

  public Vector3 customAxis
  {
    get => this.m_CustomAxis;
    set => this.m_CustomAxis = value;
  }

  public DistanceMetric distanceMetric
  {
    get => this.m_DistanceMetric;
    set => this.m_DistanceMetric = value;
  }

  public static bool operator ==(SortingSettings left, SortingSettings right) => left.Equals(right);

  public static bool operator !=(SortingSettings left, SortingSettings right)
  {
    return !left.Equals(right);
  }
}
