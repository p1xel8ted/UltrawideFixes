// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.MaskDecalBatcher
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

public sealed class MaskDecalBatcher(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kCubeVertexCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_kFalloffFuncPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kTextureMaskPass;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidTexMaskDecal;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidMaskDecalVertexShaderBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidMaskDecalFragmentShaderBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__material;
  private static readonly System.IntPtr NativeFieldInfoPtr__maskDecalVertexCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__maskDecalVertexShaderBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__maskDecalFragmentShaderBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__cmd;
  private static readonly System.IntPtr NativeFieldInfoPtr__batch;
  private static readonly System.IntPtr NativeFieldInfoPtr__maskDecalCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__drawCallCounter;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_MaskDecal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddMaskDecalToVertexShaderBuffer_Private_Void_Int32_MaskDecal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddMaskDecalToFragmentShaderBuffer_Private_Void_Int32_MaskDecal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeCurrentBatchRendering_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static MaskDecalBatcher()
  {
    Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (MaskDecalBatcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr);
    MaskDecalBatcher.NativeFieldInfoPtr_kCubeVertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (kCubeVertexCount));
    MaskDecalBatcher.NativeFieldInfoPtr_kFalloffFuncPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (kFalloffFuncPass));
    MaskDecalBatcher.NativeFieldInfoPtr_kTextureMaskPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (kTextureMaskPass));
    MaskDecalBatcher.NativeFieldInfoPtr_kSidTexMaskDecal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (kSidTexMaskDecal));
    MaskDecalBatcher.NativeFieldInfoPtr_kSidMaskDecalVertexShaderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (kSidMaskDecalVertexShaderBuffer));
    MaskDecalBatcher.NativeFieldInfoPtr_kSidMaskDecalFragmentShaderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (kSidMaskDecalFragmentShaderBuffer));
    MaskDecalBatcher.NativeFieldInfoPtr__material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (_material));
    MaskDecalBatcher.NativeFieldInfoPtr__maskDecalVertexCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (_maskDecalVertexCBuffer));
    MaskDecalBatcher.NativeFieldInfoPtr__maskDecalVertexShaderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (_maskDecalVertexShaderBuffer));
    MaskDecalBatcher.NativeFieldInfoPtr__maskDecalFragmentShaderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (_maskDecalFragmentShaderBuffer));
    MaskDecalBatcher.NativeFieldInfoPtr__cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (_cmd));
    MaskDecalBatcher.NativeFieldInfoPtr__batch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (_batch));
    MaskDecalBatcher.NativeFieldInfoPtr__maskDecalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (_maskDecalCount));
    MaskDecalBatcher.NativeFieldInfoPtr__drawCallCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (_drawCallCounter));
    MaskDecalBatcher.NativeMethodInfoPtr__ctor_Public_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, 100663728 /*0x060001B0*/);
    MaskDecalBatcher.NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, 100663729);
    MaskDecalBatcher.NativeMethodInfoPtr_Add_Public_Void_MaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, 100663730);
    MaskDecalBatcher.NativeMethodInfoPtr_AddMaskDecalToVertexShaderBuffer_Private_Void_Int32_MaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, 100663731);
    MaskDecalBatcher.NativeMethodInfoPtr_AddMaskDecalToFragmentShaderBuffer_Private_Void_Int32_MaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, 100663732);
    MaskDecalBatcher.NativeMethodInfoPtr_EncodeCurrentBatchRendering_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, 100663733);
    MaskDecalBatcher.NativeMethodInfoPtr_EndFrame_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, 100663734);
    MaskDecalBatcher.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, 100663735);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928161, XrefRangeEnd = 928190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MaskDecalBatcher(Shader maskDecalShader)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecalShader)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalBatcher.NativeMethodInfoPtr__ctor_Public_Void_Shader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928190, XrefRangeEnd = 928202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BeginFrame(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalBatcher.NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 928211, RefRangeEnd = 928212, XrefRangeStart = 928202, XrefRangeEnd = 928211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(MaskDecal maskDecal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalBatcher.NativeMethodInfoPtr_Add_Public_Void_MaskDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddMaskDecalToVertexShaderBuffer(int decalIndex, MaskDecal maskDecal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &decalIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecal);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalBatcher.NativeMethodInfoPtr_AddMaskDecalToVertexShaderBuffer_Private_Void_Int32_MaskDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928212, XrefRangeEnd = 928214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddMaskDecalToFragmentShaderBuffer(int decalIndex, MaskDecal maskDecal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &decalIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecal);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalBatcher.NativeMethodInfoPtr_AddMaskDecalToFragmentShaderBuffer_Private_Void_Int32_MaskDecal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 928236, RefRangeEnd = 928239, XrefRangeStart = 928214, XrefRangeEnd = 928236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeCurrentBatchRendering()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalBatcher.NativeMethodInfoPtr_EncodeCurrentBatchRendering_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928239, XrefRangeEnd = 928240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int EndFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaskDecalBatcher.NativeMethodInfoPtr_EndFrame_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 928240, XrefRangeEnd = 928263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaskDecalBatcher.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kCubeVertexCount
  {
    get
    {
      int kCubeVertexCount;
      IL2CPP.il2cpp_field_static_get_value(MaskDecalBatcher.NativeFieldInfoPtr_kCubeVertexCount, (void*) &kCubeVertexCount);
      return kCubeVertexCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecalBatcher.NativeFieldInfoPtr_kCubeVertexCount, (void*) &value);
    }
  }

  public static unsafe int kFalloffFuncPass
  {
    get
    {
      int kFalloffFuncPass;
      IL2CPP.il2cpp_field_static_get_value(MaskDecalBatcher.NativeFieldInfoPtr_kFalloffFuncPass, (void*) &kFalloffFuncPass);
      return kFalloffFuncPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecalBatcher.NativeFieldInfoPtr_kFalloffFuncPass, (void*) &value);
    }
  }

  public static unsafe int kTextureMaskPass
  {
    get
    {
      int kTextureMaskPass;
      IL2CPP.il2cpp_field_static_get_value(MaskDecalBatcher.NativeFieldInfoPtr_kTextureMaskPass, (void*) &kTextureMaskPass);
      return kTextureMaskPass;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecalBatcher.NativeFieldInfoPtr_kTextureMaskPass, (void*) &value);
    }
  }

  public static unsafe int kSidTexMaskDecal
  {
    get
    {
      int kSidTexMaskDecal;
      IL2CPP.il2cpp_field_static_get_value(MaskDecalBatcher.NativeFieldInfoPtr_kSidTexMaskDecal, (void*) &kSidTexMaskDecal);
      return kSidTexMaskDecal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecalBatcher.NativeFieldInfoPtr_kSidTexMaskDecal, (void*) &value);
    }
  }

  public static unsafe int kSidMaskDecalVertexShaderBuffer
  {
    get
    {
      int vertexShaderBuffer;
      IL2CPP.il2cpp_field_static_get_value(MaskDecalBatcher.NativeFieldInfoPtr_kSidMaskDecalVertexShaderBuffer, (void*) &vertexShaderBuffer);
      return vertexShaderBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecalBatcher.NativeFieldInfoPtr_kSidMaskDecalVertexShaderBuffer, (void*) &value);
    }
  }

  public static unsafe int kSidMaskDecalFragmentShaderBuffer
  {
    get
    {
      int fragmentShaderBuffer;
      IL2CPP.il2cpp_field_static_get_value(MaskDecalBatcher.NativeFieldInfoPtr_kSidMaskDecalFragmentShaderBuffer, (void*) &fragmentShaderBuffer);
      return fragmentShaderBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MaskDecalBatcher.NativeFieldInfoPtr_kSidMaskDecalFragmentShaderBuffer, (void*) &value);
    }
  }

  public unsafe Material _material
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__material));
      return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<MaskDecalBatcher.MaskDecalVertexCBufferData> _maskDecalVertexCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__maskDecalVertexCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<MaskDecalBatcher.MaskDecalVertexCBufferData>) null : Il2CppObjectPool.Get<CBuffer<MaskDecalBatcher.MaskDecalVertexCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__maskDecalVertexCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<MaskDecalBatcher.MaskDecalVertexShaderData> _maskDecalVertexShaderBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__maskDecalVertexShaderBuffer));
      return num == System.IntPtr.Zero ? (Buffer<MaskDecalBatcher.MaskDecalVertexShaderData>) null : Il2CppObjectPool.Get<Buffer<MaskDecalBatcher.MaskDecalVertexShaderData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__maskDecalVertexShaderBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<MaskDecalBatcher.MaskDecalFragmentShaderData> _maskDecalFragmentShaderBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__maskDecalFragmentShaderBuffer));
      return num == System.IntPtr.Zero ? (Buffer<MaskDecalBatcher.MaskDecalFragmentShaderData>) null : Il2CppObjectPool.Get<Buffer<MaskDecalBatcher.MaskDecalFragmentShaderData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__maskDecalFragmentShaderBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CommandBuffer _cmd
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__cmd));
      return num == System.IntPtr.Zero ? (CommandBuffer) null : Il2CppObjectPool.Get<CommandBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__cmd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public MaskDecalBatcher.Batch _batch
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__batch);
      return new MaskDecalBatcher.Batch(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaskDecalBatcher.Batch>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__batch), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MaskDecalBatcher.Batch>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe int _maskDecalCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__maskDecalCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__maskDecalCount)) = value;
    }
  }

  public unsafe int _drawCallCounter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__drawCallCounter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.NativeFieldInfoPtr__drawCallCounter)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct MaskDecalVertexCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_decalBufferBaseIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public uint decalBufferBaseIndex;
    [FieldOffset(4)]
    public Vector3 padding;

    static MaskDecalVertexCBufferData()
    {
      Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (MaskDecalVertexCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexCBufferData>.NativeClassPtr);
      MaskDecalBatcher.MaskDecalVertexCBufferData.NativeFieldInfoPtr_decalBufferBaseIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexCBufferData>.NativeClassPtr, nameof (decalBufferBaseIndex));
      MaskDecalBatcher.MaskDecalVertexCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct MaskDecalVertexShaderData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_worldMatrix;
    [FieldOffset(0)]
    public Matrix4x4 worldMatrix;

    static MaskDecalVertexShaderData()
    {
      Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexShaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (MaskDecalVertexShaderData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexShaderData>.NativeClassPtr);
      MaskDecalBatcher.MaskDecalVertexShaderData.NativeFieldInfoPtr_worldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexShaderData>.NativeClassPtr, nameof (worldMatrix));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalVertexShaderData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct MaskDecalFragmentShaderData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_worldToObjectMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_mainFalloffStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_mainFalloffEnd;
    private static readonly System.IntPtr NativeFieldInfoPtr_mainFalloffSaturation;
    private static readonly System.IntPtr NativeFieldInfoPtr_sideFalloffLength;
    [FieldOffset(0)]
    public Matrix4x4 worldToObjectMatrix;
    [FieldOffset(64 /*0x40*/)]
    public float mainFalloffStart;
    [FieldOffset(68)]
    public float mainFalloffEnd;
    [FieldOffset(72)]
    public float mainFalloffSaturation;
    [FieldOffset(76)]
    public float sideFalloffLength;

    static MaskDecalFragmentShaderData()
    {
      Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalFragmentShaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (MaskDecalFragmentShaderData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalFragmentShaderData>.NativeClassPtr);
      MaskDecalBatcher.MaskDecalFragmentShaderData.NativeFieldInfoPtr_worldToObjectMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalFragmentShaderData>.NativeClassPtr, nameof (worldToObjectMatrix));
      MaskDecalBatcher.MaskDecalFragmentShaderData.NativeFieldInfoPtr_mainFalloffStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalFragmentShaderData>.NativeClassPtr, nameof (mainFalloffStart));
      MaskDecalBatcher.MaskDecalFragmentShaderData.NativeFieldInfoPtr_mainFalloffEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalFragmentShaderData>.NativeClassPtr, nameof (mainFalloffEnd));
      MaskDecalBatcher.MaskDecalFragmentShaderData.NativeFieldInfoPtr_mainFalloffSaturation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalFragmentShaderData>.NativeClassPtr, nameof (mainFalloffSaturation));
      MaskDecalBatcher.MaskDecalFragmentShaderData.NativeFieldInfoPtr_sideFalloffLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalFragmentShaderData>.NativeClassPtr, nameof (sideFalloffLength));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaskDecalBatcher.MaskDecalFragmentShaderData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public sealed class Batch : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_texMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_decalCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_decalBufferBaseIndex;

    static Batch()
    {
      Il2CppClassPointerStore<MaskDecalBatcher.Batch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaskDecalBatcher>.NativeClassPtr, nameof (Batch));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaskDecalBatcher.Batch>.NativeClassPtr);
      MaskDecalBatcher.Batch.NativeFieldInfoPtr_texMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.Batch>.NativeClassPtr, nameof (texMask));
      MaskDecalBatcher.Batch.NativeFieldInfoPtr_decalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.Batch>.NativeClassPtr, nameof (decalCount));
      MaskDecalBatcher.Batch.NativeFieldInfoPtr_decalBufferBaseIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaskDecalBatcher.Batch>.NativeClassPtr, nameof (decalBufferBaseIndex));
    }

    public Batch(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Batch()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaskDecalBatcher.Batch>.NativeClassPtr))
    {
    }

    public unsafe Texture texMask
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.Batch.NativeFieldInfoPtr_texMask));
        return num == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.Batch.NativeFieldInfoPtr_texMask), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int decalCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.Batch.NativeFieldInfoPtr_decalCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.Batch.NativeFieldInfoPtr_decalCount)) = value;
      }
    }

    public unsafe int decalBufferBaseIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.Batch.NativeFieldInfoPtr_decalBufferBaseIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaskDecalBatcher.Batch.NativeFieldInfoPtr_decalBufferBaseIndex)) = value;
      }
    }
  }
}
