// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UpscaleSkyAndCloudsPass
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

public sealed class UpscaleSkyAndCloudsPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexSkyAndCloudsResult;
  private static readonly System.IntPtr NativeFieldInfoPtr__cbuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__upscaleMaterial;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static UpscaleSkyAndCloudsPass()
  {
    Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UpscaleSkyAndCloudsPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr);
    UpscaleSkyAndCloudsPass.NativeFieldInfoPtr_kSidTexSkyAndCloudsResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr, nameof (kSidTexSkyAndCloudsResult));
    UpscaleSkyAndCloudsPass.NativeFieldInfoPtr__cbuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr, nameof (_cbuffer));
    UpscaleSkyAndCloudsPass.NativeFieldInfoPtr__upscaleMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr, nameof (_upscaleMaterial));
    UpscaleSkyAndCloudsPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr, 100663765);
    UpscaleSkyAndCloudsPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr, 100663766);
    UpscaleSkyAndCloudsPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr, 100663767);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928727, XrefRangeEnd = 928740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UpscaleSkyAndCloudsPass(Shader upscaleShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) upscaleShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpscaleSkyAndCloudsPass.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928771, RefRangeEnd = 928772, XrefRangeStart = 928740, XrefRangeEnd = 928771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    CommandBuffer cmd,
    RenderTextureResource texSkyAndCoudsResult,
    RenderTextureResource texSceneColor,
    RenderTextureResource texSceneDepth)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSkyAndCoudsResult));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texSceneDepth));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpscaleSkyAndCloudsPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_CommandBuffer_RenderTextureResource_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928772, XrefRangeEnd = 928781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpscaleSkyAndCloudsPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidTexSkyAndCloudsResult
  {
    get
    {
      int skyAndCloudsResult;
      IL2CPP.il2cpp_field_static_get_value(UpscaleSkyAndCloudsPass.NativeFieldInfoPtr_kSidTexSkyAndCloudsResult, (void*) &skyAndCloudsResult);
      return skyAndCloudsResult;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UpscaleSkyAndCloudsPass.NativeFieldInfoPtr_kSidTexSkyAndCloudsResult, (void*) &value);
    }
  }

  public unsafe CBuffer<UpscaleSkyAndCloudsPass.UpsaleSkyAndCloudsCBufferData> _cbuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpscaleSkyAndCloudsPass.NativeFieldInfoPtr__cbuffer));
      return num == System.IntPtr.Zero ? (CBuffer<UpscaleSkyAndCloudsPass.UpsaleSkyAndCloudsCBufferData>) null : Il2CppObjectPool.Get<CBuffer<UpscaleSkyAndCloudsPass.UpsaleSkyAndCloudsCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpscaleSkyAndCloudsPass.NativeFieldInfoPtr__cbuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Material _upscaleMaterial
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpscaleSkyAndCloudsPass.NativeFieldInfoPtr__upscaleMaterial));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpscaleSkyAndCloudsPass.NativeFieldInfoPtr__upscaleMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct UpsaleSkyAndCloudsCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texSize;
    [FieldOffset(0)]
    public Vector4 texSize;

    static UpsaleSkyAndCloudsCBufferData()
    {
      Il2CppClassPointerStore<UpscaleSkyAndCloudsPass.UpsaleSkyAndCloudsCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass>.NativeClassPtr, nameof (UpsaleSkyAndCloudsCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass.UpsaleSkyAndCloudsCBufferData>.NativeClassPtr);
      UpscaleSkyAndCloudsPass.UpsaleSkyAndCloudsCBufferData.NativeFieldInfoPtr_texSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass.UpsaleSkyAndCloudsCBufferData>.NativeClassPtr, nameof (texSize));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpscaleSkyAndCloudsPass.UpsaleSkyAndCloudsCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
