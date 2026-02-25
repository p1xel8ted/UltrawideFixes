// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.UIRenderingPass
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class UIRenderingPass(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kKeywordNoHdrPacking;
  private static readonly System.IntPtr NativeFieldInfoPtr_kShaderPassArray;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_UIRenderingParams_SortingCriteria_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_UIRenderingParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_byref_CoreParams_byref_UIRenderingParams_RenderTextureResource_RenderTextureResource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIRenderingPass()
  {
    Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (UIRenderingPass));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr);
    UIRenderingPass.NativeFieldInfoPtr_kKeywordNoHdrPacking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr, nameof (kKeywordNoHdrPacking));
    UIRenderingPass.NativeFieldInfoPtr_kShaderPassArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr, nameof (kShaderPassArray));
    UIRenderingPass.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_UIRenderingParams_SortingCriteria_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr, 100664219);
    UIRenderingPass.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_UIRenderingParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr, 100664220);
    UIRenderingPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_byref_CoreParams_byref_UIRenderingParams_RenderTextureResource_RenderTextureResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr, 100664221);
    UIRenderingPass.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr, 100664222);
    UIRenderingPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr, 100664223);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 935033, XrefRangeEnd = 935038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RendererList MakeRendererList(
    [In] ref ScriptableRenderContext ctx,
    [In] ref UIRenderingParams uirp,
    SortingCriteria sortingCriteria,
    RenderQueueRange renderQueueRange)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) uirp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingCriteria;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &renderQueueRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIRenderingPass.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_UIRenderingParams_SortingCriteria_RenderQueueRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 935051, RefRangeEnd = 935054, XrefRangeStart = 935038, XrefRangeEnd = 935051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe RendererList MakeRendererList(
    [In] ref ScriptableRenderContext ctx,
    [In] ref UIRenderingParams uirp,
    Il2CppStructArray<ShaderTagId> shaderPassArray,
    SortingCriteria sortingCriteria,
    RenderQueueRange renderQueueRange)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) uirp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) shaderPassArray);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingCriteria;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &renderQueueRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIRenderingPass.NativeMethodInfoPtr_MakeRendererList_Private_Static_RendererList_byref_ScriptableRenderContext_byref_UIRenderingParams_Il2CppStructArray_1_ShaderTagId_SortingCriteria_RenderQueueRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RendererList*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 935105, RefRangeEnd = 935108, XrefRangeStart = 935054, XrefRangeEnd = 935105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Encode(
    [In] ref ScriptableRenderContext ctx,
    [In] ref CoreParams coreParams,
    [In] ref UIRenderingParams uirp,
    RenderTextureResource texUIColor,
    RenderTextureResource texUIDepth)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) ref ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref coreParams;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) uirp);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texUIColor));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) texUIDepth));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderingPass.NativeMethodInfoPtr_Encode_Public_Void_byref_ScriptableRenderContext_byref_CoreParams_byref_UIRenderingParams_RenderTextureResource_RenderTextureResource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderingPass.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIRenderingPass()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRenderingPass>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIRenderingPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe string kKeywordNoHdrPacking
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(UIRenderingPass.NativeFieldInfoPtr_kKeywordNoHdrPacking, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIRenderingPass.NativeFieldInfoPtr_kKeywordNoHdrPacking, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public static unsafe Il2CppStructArray<ShaderTagId> kShaderPassArray
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UIRenderingPass.NativeFieldInfoPtr_kShaderPassArray, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStructArray<ShaderTagId>) null : Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIRenderingPass.NativeFieldInfoPtr_kShaderPassArray, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
