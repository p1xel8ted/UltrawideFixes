// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PresentToCameraRTPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class PresentToCameraRTPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kFullscreenPassID;
  private static readonly System.IntPtr NativeFieldInfoPtr_kCroppedPassID;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexInputColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__vertexCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__material;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_FrameResultTextures_byref_CoreParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupVertexCBuffer_Private_Void_CommandBuffer_RenderTargetInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PresentToCameraRTPass()
  {
    Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PresentToCameraRTPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr);
    PresentToCameraRTPass.NativeFieldInfoPtr_kFullscreenPassID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, nameof (kFullscreenPassID));
    PresentToCameraRTPass.NativeFieldInfoPtr_kCroppedPassID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, nameof (kCroppedPassID));
    PresentToCameraRTPass.NativeFieldInfoPtr_kSidTexInputColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, nameof (kSidTexInputColor));
    PresentToCameraRTPass.NativeFieldInfoPtr__vertexCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, nameof (_vertexCBuffer));
    PresentToCameraRTPass.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, nameof (_material));
    PresentToCameraRTPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, 100664189);
    PresentToCameraRTPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_FrameResultTextures_byref_CoreParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, 100664190);
    PresentToCameraRTPass.NativeMethodInfoPtr_SetupVertexCBuffer_Private_Void_CommandBuffer_RenderTargetInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, 100664191);
    PresentToCameraRTPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, 100664192 /*0x06000380*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934448, XrefRangeEnd = 934461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresentToCameraRTPass(Shader presetShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) presetShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentToCameraRTPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934500, RefRangeEnd = 934501, XrefRangeStart = 934461, XrefRangeEnd = 934500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    FrameResultTextures frameResultTextures,
    [In] ref CoreParams coreParams)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) frameResultTextures);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref coreParams;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentToCameraRTPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_FrameResultTextures_byref_CoreParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934523, RefRangeEnd = 934524, XrefRangeStart = 934501, XrefRangeEnd = 934523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupVertexCBuffer(CommandBuffer cmd, RenderTargetInfo rti)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rti;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentToCameraRTPass.NativeMethodInfoPtr_SetupVertexCBuffer_Private_Void_CommandBuffer_RenderTargetInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 934524, XrefRangeEnd = 934532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentToCameraRTPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kFullscreenPassID
  {
    get
    {
      int fullscreenPassId;
      IL2CPP.il2cpp_field_static_get_value(PresentToCameraRTPass.NativeFieldInfoPtr_kFullscreenPassID, (void*) &fullscreenPassId);
      return fullscreenPassId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresentToCameraRTPass.NativeFieldInfoPtr_kFullscreenPassID, (void*) &value);
    }
  }

  public static unsafe int kCroppedPassID
  {
    get
    {
      int kCroppedPassId;
      IL2CPP.il2cpp_field_static_get_value(PresentToCameraRTPass.NativeFieldInfoPtr_kCroppedPassID, (void*) &kCroppedPassId);
      return kCroppedPassId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresentToCameraRTPass.NativeFieldInfoPtr_kCroppedPassID, (void*) &value);
    }
  }

  public static unsafe int kSidTexInputColor
  {
    get
    {
      int sidTexInputColor;
      IL2CPP.il2cpp_field_static_get_value(PresentToCameraRTPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &sidTexInputColor);
      return sidTexInputColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresentToCameraRTPass.NativeFieldInfoPtr_kSidTexInputColor, (void*) &value);
    }
  }

  public unsafe CBuffer<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData> _vertexCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTPass.NativeFieldInfoPtr__vertexCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>) null : Il2CppObjectPool.Get<CBuffer<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTPass.NativeFieldInfoPtr__vertexCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _material
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTPass.NativeFieldInfoPtr__material));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PresentToCameraRTPass.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PresentToCameraRTVertexCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_vertex0;
    private static readonly System.IntPtr NativeFieldInfoPtr_vertex1;
    private static readonly System.IntPtr NativeFieldInfoPtr_vertex2;
    private static readonly System.IntPtr NativeFieldInfoPtr_vertex3;
    [FieldOffset(0)]
    public Vector4 vertex0;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 vertex1;
    [FieldOffset(32 /*0x20*/)]
    public Vector4 vertex2;
    [FieldOffset(48 /*0x30*/)]
    public Vector4 vertex3;

    static PresentToCameraRTVertexCBufferData()
    {
      Il2CppClassPointerStore<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PresentToCameraRTPass>.NativeClassPtr, nameof (PresentToCameraRTVertexCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>.NativeClassPtr);
      PresentToCameraRTPass.PresentToCameraRTVertexCBufferData.NativeFieldInfoPtr_vertex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>.NativeClassPtr, nameof (vertex0));
      PresentToCameraRTPass.PresentToCameraRTVertexCBufferData.NativeFieldInfoPtr_vertex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>.NativeClassPtr, nameof (vertex1));
      PresentToCameraRTPass.PresentToCameraRTVertexCBufferData.NativeFieldInfoPtr_vertex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>.NativeClassPtr, nameof (vertex2));
      PresentToCameraRTPass.PresentToCameraRTVertexCBufferData.NativeFieldInfoPtr_vertex3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>.NativeClassPtr, nameof (vertex3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PresentToCameraRTPass.PresentToCameraRTVertexCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
