// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.PresentShadowMapCascadesPass
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

public sealed class PresentShadowMapCascadesPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSideSize;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__presentSmcShader;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitOriginOffset_Private_Static_Void_ShadowMapCascadesLayout_Vector2_byref_Vector2_byref_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_Vector2Int_ShadowMappingParams_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PresentShadowMapCascadesPass()
  {
    Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (PresentShadowMapCascadesPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr);
    PresentShadowMapCascadesPass.NativeFieldInfoPtr_kOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, nameof (kOffset));
    PresentShadowMapCascadesPass.NativeFieldInfoPtr_kSideSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, nameof (kSideSize));
    PresentShadowMapCascadesPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, nameof (_cbuffer));
    PresentShadowMapCascadesPass.NativeFieldInfoPtr__presentSmcShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, nameof (_presentSmcShader));
    PresentShadowMapCascadesPass.NativeMethodInfoPtr_InitOriginOffset_Private_Static_Void_ShadowMapCascadesLayout_Vector2_byref_Vector2_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, 100664175);
    PresentShadowMapCascadesPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, 100664176 /*0x06000370*/);
    PresentShadowMapCascadesPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_Vector2Int_ShadowMappingParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, 100664177);
    PresentShadowMapCascadesPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, 100664178);
  }

  [CallerCount(0)]
  public static unsafe void InitOriginOffset(
    ShadowMapCascadesLayout cascadeLayout,
    Vector2 renderTargetSize,
    out Vector2 origin,
    out Vector2 offset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &cascadeLayout;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &renderTargetSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref offset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentShadowMapCascadesPass.NativeMethodInfoPtr_InitOriginOffset_Private_Static_Void_ShadowMapCascadesLayout_Vector2_byref_Vector2_byref_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934263, RefRangeEnd = 934264, XrefRangeStart = 934250, XrefRangeEnd = 934263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresentShadowMapCascadesPass(Shader presentSmcShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) presentSmcShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentShadowMapCascadesPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934295, RefRangeEnd = 934296, XrefRangeStart = 934264, XrefRangeEnd = 934295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    Vector2Int renderTargetSize,
    ShadowMappingParams shadowMapping)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &renderTargetSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &shadowMapping;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentShadowMapCascadesPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_Vector2Int_ShadowMappingParams_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 934300, RefRangeEnd = 934301, XrefRangeStart = 934296, XrefRangeEnd = 934300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresentShadowMapCascadesPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float kOffset
  {
    get
    {
      float kOffset;
      IL2CPP.il2cpp_field_static_get_value(PresentShadowMapCascadesPass.NativeFieldInfoPtr_kOffset, (void*) &kOffset);
      return kOffset;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresentShadowMapCascadesPass.NativeFieldInfoPtr_kOffset, (void*) &value);
    }
  }

  public static unsafe float kSideSize
  {
    get
    {
      float kSideSize;
      IL2CPP.il2cpp_field_static_get_value(PresentShadowMapCascadesPass.NativeFieldInfoPtr_kSideSize, (void*) &kSideSize);
      return kSideSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PresentShadowMapCascadesPass.NativeFieldInfoPtr_kSideSize, (void*) &value);
    }
  }

  public unsafe CBuffer<PresentShadowMapCascadesPass.PresentSmcCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentShadowMapCascadesPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<PresentShadowMapCascadesPass.PresentSmcCBufferData>) null : Il2CppObjectPool.Get<CBuffer<PresentShadowMapCascadesPass.PresentSmcCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PresentShadowMapCascadesPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _presentSmcShader
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresentShadowMapCascadesPass.NativeFieldInfoPtr__presentSmcShader));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PresentShadowMapCascadesPass.NativeFieldInfoPtr__presentSmcShader), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PresentSmcCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_cascadeIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding3;
    [FieldOffset(0)]
    public float cascadeIndex;
    [FieldOffset(4)]
    public Vector3 padding3;

    static PresentSmcCBufferData()
    {
      Il2CppClassPointerStore<PresentShadowMapCascadesPass.PresentSmcCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PresentShadowMapCascadesPass>.NativeClassPtr, nameof (PresentSmcCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresentShadowMapCascadesPass.PresentSmcCBufferData>.NativeClassPtr);
      PresentShadowMapCascadesPass.PresentSmcCBufferData.NativeFieldInfoPtr_cascadeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentShadowMapCascadesPass.PresentSmcCBufferData>.NativeClassPtr, nameof (cascadeIndex));
      PresentShadowMapCascadesPass.PresentSmcCBufferData.NativeFieldInfoPtr_padding3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresentShadowMapCascadesPass.PresentSmcCBufferData>.NativeClassPtr, nameof (padding3));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PresentShadowMapCascadesPass.PresentSmcCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
