// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderPipelineAsset`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

#nullable disable
namespace UnityEngine.Rendering;

public class RenderPipelineAsset<TRenderPipeline>(System.IntPtr pointer) : RenderPipelineAsset(pointer)
  where TRenderPipeline : RenderPipeline
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_pipelineType_Public_Virtual_Final_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_renderPipelineType_FamOrAssem_Virtual_Final_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static RenderPipelineAsset()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<RenderPipelineAsset<TRenderPipeline>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineAsset`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TRenderPipeline>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineAsset<TRenderPipeline>>.NativeClassPtr);
    RenderPipelineAsset<TRenderPipeline>.NativeMethodInfoPtr_get_pipelineType_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset<TRenderPipeline>>.NativeClassPtr, 100670456);
    RenderPipelineAsset<TRenderPipeline>.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset<TRenderPipeline>>.NativeClassPtr, 100670457);
    RenderPipelineAsset<TRenderPipeline>.NativeMethodInfoPtr_get_renderPipelineType_FamOrAssem_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset<TRenderPipeline>>.NativeClassPtr, 100670458);
    RenderPipelineAsset<TRenderPipeline>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineAsset<TRenderPipeline>>.NativeClassPtr, 100670459);
  }

  public override unsafe Il2CppSystem.Type pipelineType
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487828, XrefRangeEnd = 487846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset<TRenderPipeline>.NativeMethodInfoPtr_get_pipelineType_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
    }
  }

  public override unsafe string renderPipelineShaderTag
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487846, XrefRangeEnd = 487870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineAsset<TRenderPipeline>.NativeMethodInfoPtr_get_renderPipelineShaderTag_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public override unsafe Il2CppSystem.Type renderPipelineType
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset<TRenderPipeline>.NativeMethodInfoPtr_get_renderPipelineType_FamOrAssem_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderPipelineAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineAsset<TRenderPipeline>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineAsset<TRenderPipeline>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
