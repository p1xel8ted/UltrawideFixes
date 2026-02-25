// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.LODParameters
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
public struct LODParameters
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsOrthographic;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FieldOfView;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OrthoSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CameraPixelHeight;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public int m_IsOrthographic;
  [FieldOffset(4)]
  public Vector3 m_CameraPosition;
  [FieldOffset(16 /*0x10*/)]
  public float m_FieldOfView;
  [FieldOffset(20)]
  public float m_OrthoSize;
  [FieldOffset(24)]
  public int m_CameraPixelHeight;

  static LODParameters()
  {
    Il2CppClassPointerStore<LODParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (LODParameters));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LODParameters>.NativeClassPtr);
    LODParameters.NativeFieldInfoPtr_m_IsOrthographic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, nameof (m_IsOrthographic));
    LODParameters.NativeFieldInfoPtr_m_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, nameof (m_CameraPosition));
    LODParameters.NativeFieldInfoPtr_m_FieldOfView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, nameof (m_FieldOfView));
    LODParameters.NativeFieldInfoPtr_m_OrthoSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, nameof (m_OrthoSize));
    LODParameters.NativeFieldInfoPtr_m_CameraPixelHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, nameof (m_CameraPixelHeight));
    LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100670393);
    LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100670394);
    LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, 100670395);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487640, RefRangeEnd = 487641, XrefRangeStart = 487638, XrefRangeEnd = 487640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(LODParameters other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LODParameters_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487641, XrefRangeEnd = 487645, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487650, RefRangeEnd = 487651, XrefRangeStart = 487645, XrefRangeEnd = 487650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LODParameters.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LODParameters>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public bool isOrthographic
  {
    get => Il2CppSystem.Convert.ToBoolean(this.m_IsOrthographic);
    set => this.m_IsOrthographic = Il2CppSystem.Convert.ToInt32(value);
  }

  public Vector3 cameraPosition
  {
    get => this.m_CameraPosition;
    set => this.m_CameraPosition = value;
  }

  public float fieldOfView
  {
    get => this.m_FieldOfView;
    set => this.m_FieldOfView = value;
  }

  public float orthoSize
  {
    get => this.m_OrthoSize;
    set => this.m_OrthoSize = value;
  }

  public int cameraPixelHeight
  {
    get => this.m_CameraPixelHeight;
    set => this.m_CameraPixelHeight = value;
  }

  public static bool operator ==(LODParameters left, LODParameters right) => left.Equals(right);

  public static bool operator !=(LODParameters left, LODParameters right) => !left.Equals(right);
}
