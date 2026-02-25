// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RasterState
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
public struct RasterState
{
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CullingMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OffsetUnits;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OffsetFactor;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthClip;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Conservative;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding1;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding2;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public CullMode m_CullingMode;
  [FieldOffset(4)]
  public int m_OffsetUnits;
  [FieldOffset(8)]
  public float m_OffsetFactor;
  [FieldOffset(12)]
  public byte m_DepthClip;
  [FieldOffset(13)]
  public byte m_Conservative;
  [FieldOffset(14)]
  public byte m_Padding1;
  [FieldOffset(15)]
  public byte m_Padding2;

  static RasterState()
  {
    Il2CppClassPointerStore<RasterState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RasterState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RasterState>.NativeClassPtr);
    RasterState.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, nameof (defaultValue));
    RasterState.NativeFieldInfoPtr_m_CullingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, nameof (m_CullingMode));
    RasterState.NativeFieldInfoPtr_m_OffsetUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, nameof (m_OffsetUnits));
    RasterState.NativeFieldInfoPtr_m_OffsetFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, nameof (m_OffsetFactor));
    RasterState.NativeFieldInfoPtr_m_DepthClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, nameof (m_DepthClip));
    RasterState.NativeFieldInfoPtr_m_Conservative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, nameof (m_Conservative));
    RasterState.NativeFieldInfoPtr_m_Padding1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, nameof (m_Padding1));
    RasterState.NativeFieldInfoPtr_m_Padding2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RasterState>.NativeClassPtr, nameof (m_Padding2));
    RasterState.NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100670397);
    RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100670398);
    RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100670399);
    RasterState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RasterState>.NativeClassPtr, 100670400);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487651, XrefRangeEnd = 487656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RasterState(
    CullMode cullingMode = CullMode.Back,
    int offsetUnits = 0,
    float offsetFactor = 0.0f,
    bool depthClip = true)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &cullingMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetUnits;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offsetFactor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthClip;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr__ctor_Public_Void_CullMode_Int32_Single_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487656, XrefRangeEnd = 487657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(RasterState other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RasterState_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487657, XrefRangeEnd = 487663, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487663, XrefRangeEnd = 487666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RasterState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RasterState>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe RasterState defaultValue
  {
    get
    {
      RasterState defaultValue;
      IL2CPP.il2cpp_field_static_get_value(RasterState.NativeFieldInfoPtr_defaultValue, (void*) &defaultValue);
      return defaultValue;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RasterState.NativeFieldInfoPtr_defaultValue, (void*) &value);
    }
  }

  public CullMode cullingMode
  {
    get => this.m_CullingMode;
    set => this.m_CullingMode = value;
  }

  public bool depthClip
  {
    get => Il2CppSystem.Convert.ToBoolean(this.m_DepthClip);
    set => this.m_DepthClip = Il2CppSystem.Convert.ToByte(value);
  }

  public bool conservative
  {
    get => Il2CppSystem.Convert.ToBoolean(this.m_Conservative);
    set => this.m_Conservative = Il2CppSystem.Convert.ToByte(value);
  }

  public int offsetUnits
  {
    get => this.m_OffsetUnits;
    set => this.m_OffsetUnits = value;
  }

  public float offsetFactor
  {
    get => this.m_OffsetFactor;
    set => this.m_OffsetFactor = value;
  }

  public static bool operator ==(RasterState left, RasterState right) => left.Equals(right);

  public static bool operator !=(RasterState left, RasterState right) => !left.Equals(right);
}
