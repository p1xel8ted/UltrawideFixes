// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.VisibleReflectionProbe
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
public struct VisibleReflectionProbe
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Bounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalToWorldMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_HdrData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Center;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Importance;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoxProjection;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TextureId;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public Bounds m_Bounds;
  [FieldOffset(24)]
  public Matrix4x4 m_LocalToWorldMatrix;
  [FieldOffset(88)]
  public Vector4 m_HdrData;
  [FieldOffset(104)]
  public Vector3 m_Center;
  [FieldOffset(116)]
  public float m_BlendDistance;
  [FieldOffset(120)]
  public int m_Importance;
  [FieldOffset(124)]
  public int m_BoxProjection;
  [FieldOffset(128 /*0x80*/)]
  public int m_InstanceId;
  [FieldOffset(132)]
  public int m_TextureId;

  static VisibleReflectionProbe()
  {
    Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (VisibleReflectionProbe));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr);
    VisibleReflectionProbe.NativeFieldInfoPtr_m_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_Bounds));
    VisibleReflectionProbe.NativeFieldInfoPtr_m_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_LocalToWorldMatrix));
    VisibleReflectionProbe.NativeFieldInfoPtr_m_HdrData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_HdrData));
    VisibleReflectionProbe.NativeFieldInfoPtr_m_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_Center));
    VisibleReflectionProbe.NativeFieldInfoPtr_m_BlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_BlendDistance));
    VisibleReflectionProbe.NativeFieldInfoPtr_m_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_Importance));
    VisibleReflectionProbe.NativeFieldInfoPtr_m_BoxProjection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_BoxProjection));
    VisibleReflectionProbe.NativeFieldInfoPtr_m_InstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_InstanceId));
    VisibleReflectionProbe.NativeFieldInfoPtr_m_TextureId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, nameof (m_TextureId));
    VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100670635);
    VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100670636);
    VisibleReflectionProbe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, 100670637);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488941, RefRangeEnd = 488942, XrefRangeStart = 488938, XrefRangeEnd = 488941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(VisibleReflectionProbe other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VisibleReflectionProbe_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488942, XrefRangeEnd = 488946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488946, XrefRangeEnd = 488961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VisibleReflectionProbe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VisibleReflectionProbe>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public Texture texture => UnityEngine.Object.FindObjectFromInstanceID(this.m_TextureId).Cast<Texture>();

  public ReflectionProbe reflectionProbe
  {
    get => UnityEngine.Object.FindObjectFromInstanceID(this.m_InstanceId).Cast<ReflectionProbe>();
  }

  public Bounds bounds
  {
    get => this.m_Bounds;
    set => this.m_Bounds = value;
  }

  public Matrix4x4 localToWorldMatrix
  {
    get => this.m_LocalToWorldMatrix;
    set => this.m_LocalToWorldMatrix = value;
  }

  public Vector4 hdrData
  {
    get => this.m_HdrData;
    set => this.m_HdrData = value;
  }

  public Vector3 center
  {
    get => this.m_Center;
    set => this.m_Center = value;
  }

  public float blendDistance
  {
    get => this.m_BlendDistance;
    set => this.m_BlendDistance = value;
  }

  public int importance
  {
    get => this.m_Importance;
    set => this.m_Importance = value;
  }

  public bool isBoxProjection
  {
    get => Il2CppSystem.Convert.ToBoolean(this.m_BoxProjection);
    set => this.m_BoxProjection = Il2CppSystem.Convert.ToInt32(value);
  }

  public static bool operator ==(VisibleReflectionProbe left, VisibleReflectionProbe right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(VisibleReflectionProbe left, VisibleReflectionProbe right)
  {
    return !left.Equals(right);
  }
}
