// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.GlobalCBuffers
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

public sealed class GlobalCBuffers(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__globalCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__globalCharacterCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__shaderGraphCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__litVfxShellCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__unlitVfxShellCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__particleUnlitVfxShellCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__uiVfxCBufferData;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Setup_Public_Void_byref_ScriptableRenderContext_byref_UIRenderingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static GlobalCBuffers()
  {
    Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (GlobalCBuffers));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr);
    GlobalCBuffers.NativeFieldInfoPtr__globalCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (_globalCBuffer));
    GlobalCBuffers.NativeFieldInfoPtr__globalCharacterCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (_globalCharacterCBuffer));
    GlobalCBuffers.NativeFieldInfoPtr__shaderGraphCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (_shaderGraphCBuffer));
    GlobalCBuffers.NativeFieldInfoPtr__litVfxShellCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (_litVfxShellCBuffer));
    GlobalCBuffers.NativeFieldInfoPtr__unlitVfxShellCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (_unlitVfxShellCBuffer));
    GlobalCBuffers.NativeFieldInfoPtr__particleUnlitVfxShellCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (_particleUnlitVfxShellCBuffer));
    GlobalCBuffers.NativeFieldInfoPtr__uiVfxCBufferData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (_uiVfxCBufferData));
    GlobalCBuffers.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, 100663807);
    GlobalCBuffers.NativeMethodInfoPtr_Setup_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, 100663808 /*0x06000200*/);
    GlobalCBuffers.NativeMethodInfoPtr_Setup_Public_Void_byref_ScriptableRenderContext_byref_UIRenderingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, 100663809 /*0x06000201*/);
    GlobalCBuffers.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, 100663810 /*0x06000202*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929472, RefRangeEnd = 929473, XrefRangeStart = 929417, XrefRangeEnd = 929472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GlobalCBuffers()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalCBuffers.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 929513, RefRangeEnd = 929515, XrefRangeStart = 929473, XrefRangeEnd = 929513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Setup(
    [In] ref ScriptableRenderContext ctx,
    [In] ref FrameRenderingParams frp,
    [In] ref Matrix4x4 prevNonJitteredProjectionViewMatrix)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) frp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref prevNonJitteredProjectionViewMatrix;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalCBuffers.NativeMethodInfoPtr_Setup_Public_Void_byref_ScriptableRenderContext_byref_FrameRenderingParams_byref_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 929552, RefRangeEnd = 929555, XrefRangeStart = 929515, XrefRangeEnd = 929552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Setup([In] ref ScriptableRenderContext ctx, [In] ref UIRenderingParams uirp)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) uirp);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalCBuffers.NativeMethodInfoPtr_Setup_Public_Void_byref_ScriptableRenderContext_byref_UIRenderingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 929576, RefRangeEnd = 929577, XrefRangeStart = 929555, XrefRangeEnd = 929576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GlobalCBuffers.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CBuffer<GlobalCBuffers.GlobalCBufferData> _globalCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__globalCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GlobalCBuffers.GlobalCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GlobalCBuffers.GlobalCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__globalCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<GlobalCBuffers.GlobalCharacterCBufferData> _globalCharacterCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__globalCharacterCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GlobalCBuffers.GlobalCharacterCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GlobalCBuffers.GlobalCharacterCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__globalCharacterCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<GlobalCBuffers.ShaderGraphData> _shaderGraphCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__shaderGraphCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GlobalCBuffers.ShaderGraphData>) null : Il2CppObjectPool.Get<CBuffer<GlobalCBuffers.ShaderGraphData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__shaderGraphCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<GlobalCBuffers.UnlitV1VfxShellCBufferData> _litVfxShellCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__litVfxShellCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GlobalCBuffers.UnlitV1VfxShellCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GlobalCBuffers.UnlitV1VfxShellCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__litVfxShellCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<GlobalCBuffers.UnlitV1VfxShellCBufferData> _unlitVfxShellCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__unlitVfxShellCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GlobalCBuffers.UnlitV1VfxShellCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GlobalCBuffers.UnlitV1VfxShellCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__unlitVfxShellCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<GlobalCBuffers.ParticleUnlitV1VfxShellCBufferData> _particleUnlitVfxShellCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__particleUnlitVfxShellCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<GlobalCBuffers.ParticleUnlitV1VfxShellCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GlobalCBuffers.ParticleUnlitV1VfxShellCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__particleUnlitVfxShellCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<GlobalCBuffers.UIV1VfxCBufferData> _uiVfxCBufferData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__uiVfxCBufferData));
      return num == System.IntPtr.Zero ? (CBuffer<GlobalCBuffers.UIV1VfxCBufferData>) null : Il2CppObjectPool.Get<CBuffer<GlobalCBuffers.UIV1VfxCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GlobalCBuffers.NativeFieldInfoPtr__uiVfxCBufferData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GlobalCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_projectionMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_viewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_invViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_invProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_nonJitteredProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_prevNonJitteredProjectionViewMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_depthPojectionParams;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraPosWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraForwardWs;
    private static readonly System.IntPtr NativeFieldInfoPtr_screenTexCoordToUv;
    private static readonly System.IntPtr NativeFieldInfoPtr_timeParameters;
    [FieldOffset(0)]
    public Matrix4x4 projectionViewMatrix;
    [FieldOffset(64 /*0x40*/)]
    public Matrix4x4 projectionMatrix;
    [FieldOffset(128 /*0x80*/)]
    public Matrix4x4 viewMatrix;
    [FieldOffset(192 /*0xC0*/)]
    public Matrix4x4 invViewMatrix;
    [FieldOffset(256 /*0x0100*/)]
    public Matrix4x4 invProjectionMatrix;
    [FieldOffset(320)]
    public Matrix4x4 invProjectionViewMatrix;
    [FieldOffset(384)]
    public Matrix4x4 nonJitteredProjectionViewMatrix;
    [FieldOffset(448)]
    public Matrix4x4 prevNonJitteredProjectionViewMatrix;
    [FieldOffset(512 /*0x0200*/)]
    public Vector4 depthPojectionParams;
    [FieldOffset(528)]
    public Vector4 cameraPosWs;
    [FieldOffset(544)]
    public Vector4 cameraForwardWs;
    [FieldOffset(560)]
    public Vector4 screenTexCoordToUv;
    [FieldOffset(576)]
    public Vector4 timeParameters;

    static GlobalCBufferData()
    {
      Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (GlobalCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr);
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_projectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (projectionViewMatrix));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_projectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (projectionMatrix));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_viewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (viewMatrix));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_invViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (invViewMatrix));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_invProjectionMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (invProjectionMatrix));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_invProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (invProjectionViewMatrix));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_nonJitteredProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (nonJitteredProjectionViewMatrix));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_prevNonJitteredProjectionViewMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (prevNonJitteredProjectionViewMatrix));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_depthPojectionParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (depthPojectionParams));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_cameraPosWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (cameraPosWs));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_cameraForwardWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (cameraForwardWs));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_screenTexCoordToUv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (screenTexCoordToUv));
      GlobalCBuffers.GlobalCBufferData.NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, nameof (timeParameters));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalCBuffers.GlobalCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct GlobalCharacterCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_rimColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding0;
    private static readonly System.IntPtr NativeFieldInfoPtr_highlightColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_highlightIntensity;
    private static readonly System.IntPtr NativeFieldInfoPtr_mainChatacterHeightScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_mainChatacterHeightOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding1;
    [FieldOffset(0)]
    public Vector3 rimColor;
    [FieldOffset(12)]
    public float padding0;
    [FieldOffset(16 /*0x10*/)]
    public Vector3 highlightColor;
    [FieldOffset(28)]
    public float highlightIntensity;
    [FieldOffset(32 /*0x20*/)]
    public float mainChatacterHeightScale;
    [FieldOffset(36)]
    public float mainChatacterHeightOffset;
    [FieldOffset(40)]
    public Vector2 padding1;

    static GlobalCharacterCBufferData()
    {
      Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (GlobalCharacterCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr);
      GlobalCBuffers.GlobalCharacterCBufferData.NativeFieldInfoPtr_rimColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr, nameof (rimColor));
      GlobalCBuffers.GlobalCharacterCBufferData.NativeFieldInfoPtr_padding0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr, nameof (padding0));
      GlobalCBuffers.GlobalCharacterCBufferData.NativeFieldInfoPtr_highlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr, nameof (highlightColor));
      GlobalCBuffers.GlobalCharacterCBufferData.NativeFieldInfoPtr_highlightIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr, nameof (highlightIntensity));
      GlobalCBuffers.GlobalCharacterCBufferData.NativeFieldInfoPtr_mainChatacterHeightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr, nameof (mainChatacterHeightScale));
      GlobalCBuffers.GlobalCharacterCBufferData.NativeFieldInfoPtr_mainChatacterHeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr, nameof (mainChatacterHeightOffset));
      GlobalCBuffers.GlobalCharacterCBufferData.NativeFieldInfoPtr_padding1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr, nameof (padding1));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalCBuffers.GlobalCharacterCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ShaderGraphData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_time;
    [FieldOffset(0)]
    public Vector4 time;

    static ShaderGraphData()
    {
      Il2CppClassPointerStore<GlobalCBuffers.ShaderGraphData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (ShaderGraphData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCBuffers.ShaderGraphData>.NativeClassPtr);
      GlobalCBuffers.ShaderGraphData.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.ShaderGraphData>.NativeClassPtr, nameof (time));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalCBuffers.ShaderGraphData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct LitV1VfxShellCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_timeParameters;
    [FieldOffset(0)]
    public Vector4 timeParameters;

    static LitV1VfxShellCBufferData()
    {
      Il2CppClassPointerStore<GlobalCBuffers.LitV1VfxShellCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (LitV1VfxShellCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCBuffers.LitV1VfxShellCBufferData>.NativeClassPtr);
      GlobalCBuffers.LitV1VfxShellCBufferData.NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.LitV1VfxShellCBufferData>.NativeClassPtr, nameof (timeParameters));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalCBuffers.LitV1VfxShellCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UnlitV1VfxShellCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_timeParameters;
    [FieldOffset(0)]
    public Vector4 timeParameters;

    static UnlitV1VfxShellCBufferData()
    {
      Il2CppClassPointerStore<GlobalCBuffers.UnlitV1VfxShellCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (UnlitV1VfxShellCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCBuffers.UnlitV1VfxShellCBufferData>.NativeClassPtr);
      GlobalCBuffers.UnlitV1VfxShellCBufferData.NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.UnlitV1VfxShellCBufferData>.NativeClassPtr, nameof (timeParameters));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalCBuffers.UnlitV1VfxShellCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct ParticleUnlitV1VfxShellCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_timeParameters;
    [FieldOffset(0)]
    public Vector4 timeParameters;

    static ParticleUnlitV1VfxShellCBufferData()
    {
      Il2CppClassPointerStore<GlobalCBuffers.ParticleUnlitV1VfxShellCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (ParticleUnlitV1VfxShellCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCBuffers.ParticleUnlitV1VfxShellCBufferData>.NativeClassPtr);
      GlobalCBuffers.ParticleUnlitV1VfxShellCBufferData.NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.ParticleUnlitV1VfxShellCBufferData>.NativeClassPtr, nameof (timeParameters));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalCBuffers.ParticleUnlitV1VfxShellCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UIV1VfxCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_timeParameters;
    [FieldOffset(0)]
    public Vector4 timeParameters;

    static UIV1VfxCBufferData()
    {
      Il2CppClassPointerStore<GlobalCBuffers.UIV1VfxCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GlobalCBuffers>.NativeClassPtr, nameof (UIV1VfxCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalCBuffers.UIV1VfxCBufferData>.NativeClassPtr);
      GlobalCBuffers.UIV1VfxCBufferData.NativeFieldInfoPtr_timeParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalCBuffers.UIV1VfxCBufferData>.NativeClassPtr, nameof (timeParameters));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalCBuffers.UIV1VfxCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
