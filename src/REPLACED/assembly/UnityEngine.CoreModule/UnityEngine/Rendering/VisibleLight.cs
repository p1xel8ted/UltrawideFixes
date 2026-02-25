// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.VisibleLight
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct VisibleLight
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LightType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FinalColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ScreenRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalToWorldMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Range;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SpotAngle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_light_Public_get_Light_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_range_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public LightType m_LightType;
  [FieldOffset(4)]
  public Color m_FinalColor;
  [FieldOffset(20)]
  public Rect m_ScreenRect;
  [FieldOffset(36)]
  public Matrix4x4 m_LocalToWorldMatrix;
  [FieldOffset(100)]
  public float m_Range;
  [FieldOffset(104)]
  public float m_SpotAngle;
  [FieldOffset(108)]
  public int m_InstanceId;
  [FieldOffset(112 /*0x70*/)]
  public VisibleLightFlags m_Flags;

  static VisibleLight()
  {
    Il2CppClassPointerStore<VisibleLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (VisibleLight));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr);
    VisibleLight.NativeFieldInfoPtr_m_LightType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, nameof (m_LightType));
    VisibleLight.NativeFieldInfoPtr_m_FinalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, nameof (m_FinalColor));
    VisibleLight.NativeFieldInfoPtr_m_ScreenRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, nameof (m_ScreenRect));
    VisibleLight.NativeFieldInfoPtr_m_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, nameof (m_LocalToWorldMatrix));
    VisibleLight.NativeFieldInfoPtr_m_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, nameof (m_Range));
    VisibleLight.NativeFieldInfoPtr_m_SpotAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, nameof (m_SpotAngle));
    VisibleLight.NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, nameof (m_InstanceId));
    VisibleLight.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, nameof (m_Flags));
    VisibleLight.NativeMethodInfoPtr_get_light_Public_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100670628);
    VisibleLight.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100670629);
    VisibleLight.NativeMethodInfoPtr_get_range_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100670630);
    VisibleLight.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100670631);
    VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100670632);
    VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100670633);
    VisibleLight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, 100670634);
  }

  public unsafe Light light
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 488898, RefRangeEnd = 488906, XrefRangeStart = 488892, XrefRangeEnd = 488898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_light_Public_get_Light_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Light) null : Il2CppObjectPool.Get<Light>(num3);
    }
  }

  public unsafe Matrix4x4 localToWorldMatrix
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 488906, RefRangeEnd = 488915, XrefRangeStart = 488906, XrefRangeEnd = 488906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_localToWorldMatrix_Public_get_Matrix4x4_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_LocalToWorldMatrix = value;
  }

  public unsafe float range
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 488915, RefRangeEnd = 488917, XrefRangeStart = 488915, XrefRangeEnd = 488915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_range_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Range = value;
  }

  public unsafe float spotAngle
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 488917, RefRangeEnd = 488919, XrefRangeStart = 488917, XrefRangeEnd = 488917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_get_spotAngle_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_SpotAngle = value;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488928, RefRangeEnd = 488929, XrefRangeStart = 488919, XrefRangeEnd = 488928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(VisibleLight other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleLight_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488929, XrefRangeEnd = 488933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488933, XrefRangeEnd = 488938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleLight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisibleLight>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public LightType lightType
  {
    get => this.m_LightType;
    set => this.m_LightType = value;
  }

  public Color finalColor
  {
    get => this.m_FinalColor;
    set => this.m_FinalColor = value;
  }

  public Rect screenRect
  {
    get => this.m_ScreenRect;
    set => this.m_ScreenRect = value;
  }

  public bool intersectsNearPlane
  {
    get => (this.m_Flags & VisibleLightFlags.IntersectsNearPlane) > (VisibleLightFlags) 0;
    set
    {
      if (value)
        this.m_Flags |= VisibleLightFlags.IntersectsNearPlane;
      else
        this.m_Flags &= ~VisibleLightFlags.IntersectsNearPlane;
    }
  }

  public bool intersectsFarPlane
  {
    get => (this.m_Flags & VisibleLightFlags.IntersectsFarPlane) > (VisibleLightFlags) 0;
    set
    {
      if (value)
        this.m_Flags |= VisibleLightFlags.IntersectsFarPlane;
      else
        this.m_Flags &= ~VisibleLightFlags.IntersectsFarPlane;
    }
  }

  public bool forcedVisible
  {
    get => (this.m_Flags & VisibleLightFlags.ForcedVisible) > (VisibleLightFlags) 0;
  }

  public static bool operator ==(VisibleLight left, VisibleLight right) => left.Equals(right);

  public static bool operator !=(VisibleLight left, VisibleLight right) => !left.Equals(right);
}
