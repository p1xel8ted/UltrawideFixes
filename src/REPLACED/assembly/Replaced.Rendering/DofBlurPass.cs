// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DofBlurPass
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

public sealed class DofBlurPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTexColorCoveragePrototypeDesc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kHorzGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kVertGroupSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexCoc;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurForegroundColorPing;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurForegroundCoveragePing;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColorPing;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurForegroundColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurForegroundCoverage;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColor;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__compute;
  private static readonly System.IntPtr NativeFieldInfoPtr__horizontalBlurKernel;
  private static readonly System.IntPtr NativeFieldInfoPtr__verticalBlurInFocusBackgroundKernel;
  private static readonly System.IntPtr NativeFieldInfoPtr__verticalBlurForegroundKernel;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeAndAllocateTexture_Private_RenderTextureResource_String_byref_RenderTextureDescriptor_Vector2Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_DepthOfFieldParams_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_Single_0;

  static DofBlurPass()
  {
    Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DofBlurPass));
    DofBlurPass.NativeFieldInfoPtr_kTexColorCoveragePrototypeDesc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kTexColorCoveragePrototypeDesc));
    DofBlurPass.NativeFieldInfoPtr_kHorzGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kHorzGroupSize));
    DofBlurPass.NativeFieldInfoPtr_kVertGroupSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kVertGroupSize));
    DofBlurPass.NativeFieldInfoPtr_kSidTexColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kSidTexColor));
    DofBlurPass.NativeFieldInfoPtr_kSidTexCoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kSidTexCoc));
    DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundColorPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kSidTexBlurForegroundColorPing));
    DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundCoveragePing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kSidTexBlurForegroundCoveragePing));
    DofBlurPass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColorPing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kSidTexBlurInFocusBackgroundColorPing));
    DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kSidTexBlurForegroundColor));
    DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kSidTexBlurForegroundCoverage));
    DofBlurPass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (kSidTexBlurInFocusBackgroundColor));
    DofBlurPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (_cbuffer));
    DofBlurPass.NativeFieldInfoPtr__compute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (_compute));
    DofBlurPass.NativeFieldInfoPtr__horizontalBlurKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (_horizontalBlurKernel));
    DofBlurPass.NativeFieldInfoPtr__verticalBlurInFocusBackgroundKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (_verticalBlurInFocusBackgroundKernel));
    DofBlurPass.NativeFieldInfoPtr__verticalBlurForegroundKernel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (_verticalBlurForegroundKernel));
    DofBlurPass.NativeMethodInfoPtr_MakeAndAllocateTexture_Private_RenderTextureResource_String_byref_RenderTextureDescriptor_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, 100664140);
    DofBlurPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, 100664141);
    DofBlurPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_DepthOfFieldParams_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, 100664142);
    DofBlurPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, 100664143);
    DofBlurPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, 100664144 /*0x06000350*/);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 933452, RefRangeEnd = 933454, XrefRangeStart = 933447, XrefRangeEnd = 933452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTextureResource MakeAndAllocateTexture(
    string label,
    [In] ref RenderTextureDescriptor descPrototype,
    Vector2Int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(label);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref descPrototype;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DofBlurPass.NativeMethodInfoPtr_MakeAndAllocateTexture_Private_RenderTextureResource_String_byref_RenderTextureDescriptor_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new RenderTextureResource(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933454, XrefRangeEnd = 933472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DofBlurPass(ComputeShader compute)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DofBlurPass.NativeMethodInfoPtr__ctor_Public_Void_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 933597, RefRangeEnd = 933598, XrefRangeStart = 933472, XrefRangeEnd = 933597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    CommandBuffer cmd,
    DepthOfFieldParams dof,
    [In] ref RenderTextureResource texColor,
    [In] ref RenderTextureResource texCoc,
    out RenderTextureResource texBlurForegroundColor,
    out RenderTextureResource texBlurForegroundCoverage,
    out RenderTextureResource texBlurInFocusBackgroundColor)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof));
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texCoc);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
    System.IntPtr zero3 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero3;
    *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
    System.IntPtr num4;
    IL2CPP.il2cpp_runtime_invoke(DofBlurPass.NativeMethodInfoPtr_Encode_Public_Void_CommandBuffer_DepthOfFieldParams_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_byref_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    ref RenderTextureResource local1 = ref texBlurForegroundColor;
    System.IntPtr pointer1 = zero1;
    RenderTextureResource renderTextureResource1 = pointer1 == System.IntPtr.Zero ? (RenderTextureResource) null : new RenderTextureResource(pointer1);
    local1 = renderTextureResource1;
    ref RenderTextureResource local2 = ref texBlurForegroundCoverage;
    System.IntPtr pointer2 = zero2;
    RenderTextureResource renderTextureResource2 = pointer2 == System.IntPtr.Zero ? (RenderTextureResource) null : new RenderTextureResource(pointer2);
    local2 = renderTextureResource2;
    ref RenderTextureResource local3 = ref texBlurInFocusBackgroundColor;
    System.IntPtr pointer3 = zero3;
    RenderTextureResource renderTextureResource3 = pointer3 == System.IntPtr.Zero ? (RenderTextureResource) null : new RenderTextureResource(pointer3);
    local3 = renderTextureResource3;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933598, XrefRangeEnd = 933602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DofBlurPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 933667, RefRangeEnd = 933669, XrefRangeStart = 933602, XrefRangeEnd = 933667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetupCBuffer(
    CommandBuffer cmd,
    [In] ref DepthOfFieldParams dof,
    Vector2Int textureSize,
    float radiusScale = 1f)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) dof);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textureSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &radiusScale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DofBlurPass.NativeMethodInfoPtr_SetupCBuffer_Private_Void_CommandBuffer_byref_DepthOfFieldParams_Vector2Int_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe RenderTextureDescriptor kTexColorCoveragePrototypeDesc
  {
    get
    {
      RenderTextureDescriptor coveragePrototypeDesc;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kTexColorCoveragePrototypeDesc, (void*) &coveragePrototypeDesc);
      return coveragePrototypeDesc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kTexColorCoveragePrototypeDesc, (void*) &value);
    }
  }

  public static unsafe Vector2Int kHorzGroupSize
  {
    get
    {
      Vector2Int kHorzGroupSize;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kHorzGroupSize, (void*) &kHorzGroupSize);
      return kHorzGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kHorzGroupSize, (void*) &value);
    }
  }

  public static unsafe Vector2Int kVertGroupSize
  {
    get
    {
      Vector2Int kVertGroupSize;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kVertGroupSize, (void*) &kVertGroupSize);
      return kVertGroupSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kVertGroupSize, (void*) &value);
    }
  }

  public static unsafe int kSidTexColor
  {
    get
    {
      int kSidTexColor;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kSidTexColor, (void*) &kSidTexColor);
      return kSidTexColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kSidTexColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexCoc
  {
    get
    {
      int kSidTexCoc;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kSidTexCoc, (void*) &kSidTexCoc);
      return kSidTexCoc;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kSidTexCoc, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurForegroundColorPing
  {
    get
    {
      int foregroundColorPing;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundColorPing, (void*) &foregroundColorPing);
      return foregroundColorPing;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundColorPing, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurForegroundCoveragePing
  {
    get
    {
      int foregroundCoveragePing;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundCoveragePing, (void*) &foregroundCoveragePing);
      return foregroundCoveragePing;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundCoveragePing, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurInFocusBackgroundColorPing
  {
    get
    {
      int backgroundColorPing;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColorPing, (void*) &backgroundColorPing);
      return backgroundColorPing;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColorPing, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurForegroundColor
  {
    get
    {
      int blurForegroundColor;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundColor, (void*) &blurForegroundColor);
      return blurForegroundColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundColor, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurForegroundCoverage
  {
    get
    {
      int foregroundCoverage;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundCoverage, (void*) &foregroundCoverage);
      return foregroundCoverage;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurForegroundCoverage, (void*) &value);
    }
  }

  public static unsafe int kSidTexBlurInFocusBackgroundColor
  {
    get
    {
      int focusBackgroundColor;
      IL2CPP.il2cpp_field_static_get_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColor, (void*) &focusBackgroundColor);
      return focusBackgroundColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DofBlurPass.NativeFieldInfoPtr_kSidTexBlurInFocusBackgroundColor, (void*) &value);
    }
  }

  public unsafe CBuffer<DofBlurPass.DofBlurCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<DofBlurPass.DofBlurCBufferData>) null : Il2CppObjectPool.Get<CBuffer<DofBlurPass.DofBlurCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeShader _compute
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__compute));
      return num == System.IntPtr.Zero ? (ComputeShader) null : Il2CppObjectPool.Get<ComputeShader>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__compute), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _horizontalBlurKernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__horizontalBlurKernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__horizontalBlurKernel)) = value;
    }
  }

  public unsafe int _verticalBlurInFocusBackgroundKernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__verticalBlurInFocusBackgroundKernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__verticalBlurInFocusBackgroundKernel)) = value;
    }
  }

  public unsafe int _verticalBlurForegroundKernel
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__verticalBlurForegroundKernel));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DofBlurPass.NativeFieldInfoPtr__verticalBlurForegroundKernel)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DofBlurCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_tc2Uv;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxCocRadiusPixels;
    private static readonly System.IntPtr NativeFieldInfoPtr_backgroundBlurBellFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_foregroundBlurBellFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public Vector4 tc2Uv;
    [FieldOffset(16 /*0x10*/)]
    public float maxCocRadiusPixels;
    [FieldOffset(20)]
    public float backgroundBlurBellFactor;
    [FieldOffset(24)]
    public float foregroundBlurBellFactor;
    [FieldOffset(28)]
    public float padding;

    static DofBlurCBufferData()
    {
      Il2CppClassPointerStore<DofBlurPass.DofBlurCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DofBlurPass>.NativeClassPtr, nameof (DofBlurCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DofBlurPass.DofBlurCBufferData>.NativeClassPtr);
      DofBlurPass.DofBlurCBufferData.NativeFieldInfoPtr_tc2Uv = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass.DofBlurCBufferData>.NativeClassPtr, nameof (tc2Uv));
      DofBlurPass.DofBlurCBufferData.NativeFieldInfoPtr_maxCocRadiusPixels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass.DofBlurCBufferData>.NativeClassPtr, nameof (maxCocRadiusPixels));
      DofBlurPass.DofBlurCBufferData.NativeFieldInfoPtr_backgroundBlurBellFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass.DofBlurCBufferData>.NativeClassPtr, nameof (backgroundBlurBellFactor));
      DofBlurPass.DofBlurCBufferData.NativeFieldInfoPtr_foregroundBlurBellFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass.DofBlurCBufferData>.NativeClassPtr, nameof (foregroundBlurBellFactor));
      DofBlurPass.DofBlurCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DofBlurPass.DofBlurCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DofBlurPass.DofBlurCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
