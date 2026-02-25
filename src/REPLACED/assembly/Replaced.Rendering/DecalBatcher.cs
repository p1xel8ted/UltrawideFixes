// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DecalBatcher
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

public sealed class DecalBatcher(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidDecalVertexShaderBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_kSidDecalFragmentShaderBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__vertexCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__fragmentCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__decalVertexShaderBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__decalFragmentShaderBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__cmd;
  private static readonly System.IntPtr NativeFieldInfoPtr__decalCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__batch;
  private static readonly System.IntPtr NativeFieldInfoPtr__drawCallCounter;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndFrame_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Decal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddDecalToVertexShaderBuffer_Private_Void_Int32_Decal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddDecalToFragmentShaderBuffer_Private_Void_Int32_Decal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeVertexCBufferSettingUp_Private_Void_Decal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeMaterialSetup_Private_Void_Decal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EncodeCurrentBatchRendering_Private_Void_0;

  static DecalBatcher()
  {
    Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DecalBatcher));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr);
    DecalBatcher.NativeFieldInfoPtr_kSidDecalVertexShaderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (kSidDecalVertexShaderBuffer));
    DecalBatcher.NativeFieldInfoPtr_kSidDecalFragmentShaderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (kSidDecalFragmentShaderBuffer));
    DecalBatcher.NativeFieldInfoPtr__vertexCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (_vertexCBuffer));
    DecalBatcher.NativeFieldInfoPtr__fragmentCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (_fragmentCBuffer));
    DecalBatcher.NativeFieldInfoPtr__decalVertexShaderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (_decalVertexShaderBuffer));
    DecalBatcher.NativeFieldInfoPtr__decalFragmentShaderBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (_decalFragmentShaderBuffer));
    DecalBatcher.NativeFieldInfoPtr__cmd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (_cmd));
    DecalBatcher.NativeFieldInfoPtr__decalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (_decalCount));
    DecalBatcher.NativeFieldInfoPtr__batch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (_batch));
    DecalBatcher.NativeFieldInfoPtr__drawCallCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (_drawCallCounter));
    DecalBatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663687);
    DecalBatcher.NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663688);
    DecalBatcher.NativeMethodInfoPtr_EndFrame_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663689);
    DecalBatcher.NativeMethodInfoPtr_Add_Public_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663690);
    DecalBatcher.NativeMethodInfoPtr_AddDecalToVertexShaderBuffer_Private_Void_Int32_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663691);
    DecalBatcher.NativeMethodInfoPtr_AddDecalToFragmentShaderBuffer_Private_Void_Int32_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663692);
    DecalBatcher.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663693);
    DecalBatcher.NativeMethodInfoPtr_EncodeVertexCBufferSettingUp_Private_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663694);
    DecalBatcher.NativeMethodInfoPtr_EncodeMaterialSetup_Private_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663695);
    DecalBatcher.NativeMethodInfoPtr_EncodeCurrentBatchRendering_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, 100663696 /*0x06000190*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927537, XrefRangeEnd = 927570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecalBatcher()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927570, XrefRangeEnd = 927582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BeginFrame(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_BeginFrame_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927582, XrefRangeEnd = 927583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int EndFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_EndFrame_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927599, RefRangeEnd = 927600, XrefRangeStart = 927583, XrefRangeEnd = 927599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_Add_Public_Void_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927600, XrefRangeEnd = 927602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddDecalToVertexShaderBuffer(int decalIndex, Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &decalIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_AddDecalToVertexShaderBuffer_Private_Void_Int32_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927602, XrefRangeEnd = 927604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddDecalToFragmentShaderBuffer(int decalIndex, Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &decalIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_AddDecalToFragmentShaderBuffer_Private_Void_Int32_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927604, XrefRangeEnd = 927626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927626, XrefRangeEnd = 927630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeVertexCBufferSettingUp(Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_EncodeVertexCBufferSettingUp_Private_Void_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927711, RefRangeEnd = 927712, XrefRangeStart = 927630, XrefRangeEnd = 927711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeMaterialSetup(Decal decal)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_EncodeMaterialSetup_Private_Void_Decal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 927725, RefRangeEnd = 927728, XrefRangeStart = 927712, XrefRangeEnd = 927725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EncodeCurrentBatchRendering()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalBatcher.NativeMethodInfoPtr_EncodeCurrentBatchRendering_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kSidDecalVertexShaderBuffer
  {
    get
    {
      int vertexShaderBuffer;
      IL2CPP.il2cpp_field_static_get_value(DecalBatcher.NativeFieldInfoPtr_kSidDecalVertexShaderBuffer, (void*) &vertexShaderBuffer);
      return vertexShaderBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalBatcher.NativeFieldInfoPtr_kSidDecalVertexShaderBuffer, (void*) &value);
    }
  }

  public static unsafe int kSidDecalFragmentShaderBuffer
  {
    get
    {
      int fragmentShaderBuffer;
      IL2CPP.il2cpp_field_static_get_value(DecalBatcher.NativeFieldInfoPtr_kSidDecalFragmentShaderBuffer, (void*) &fragmentShaderBuffer);
      return fragmentShaderBuffer;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DecalBatcher.NativeFieldInfoPtr_kSidDecalFragmentShaderBuffer, (void*) &value);
    }
  }

  public unsafe CBuffer<DecalBatcher.DecalVertexCBufferData> _vertexCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__vertexCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<DecalBatcher.DecalVertexCBufferData>) null : Il2CppObjectPool.Get<CBuffer<DecalBatcher.DecalVertexCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__vertexCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CBuffer<DecalBatcher.DecalFragmentCBufferData> _fragmentCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__fragmentCBuffer));
      return num == System.IntPtr.Zero ? (CBuffer<DecalBatcher.DecalFragmentCBufferData>) null : Il2CppObjectPool.Get<CBuffer<DecalBatcher.DecalFragmentCBufferData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__fragmentCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<DecalBatcher.DecalVertexShaderData> _decalVertexShaderBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__decalVertexShaderBuffer));
      return num == System.IntPtr.Zero ? (Buffer<DecalBatcher.DecalVertexShaderData>) null : Il2CppObjectPool.Get<Buffer<DecalBatcher.DecalVertexShaderData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__decalVertexShaderBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<DecalBatcher.DecalFragmentShaderData> _decalFragmentShaderBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__decalFragmentShaderBuffer));
      return num == System.IntPtr.Zero ? (Buffer<DecalBatcher.DecalFragmentShaderData>) null : Il2CppObjectPool.Get<Buffer<DecalBatcher.DecalFragmentShaderData>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__decalFragmentShaderBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CommandBuffer _cmd
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__cmd));
      return num == System.IntPtr.Zero ? (CommandBuffer) null : Il2CppObjectPool.Get<CommandBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__cmd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _decalCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__decalCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__decalCount)) = value;
    }
  }

  public DecalBatcher.Batch _batch
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__batch);
      return new DecalBatcher.Batch(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalBatcher.Batch>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__batch), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DecalBatcher.Batch>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe int _drawCallCounter
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__drawCallCounter));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.NativeFieldInfoPtr__drawCallCounter)) = value;
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DecalVertexCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_decalBufferBaseIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    [FieldOffset(0)]
    public uint decalBufferBaseIndex;
    [FieldOffset(4)]
    public Vector3 padding;

    static DecalVertexCBufferData()
    {
      Il2CppClassPointerStore<DecalBatcher.DecalVertexCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (DecalVertexCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalBatcher.DecalVertexCBufferData>.NativeClassPtr);
      DecalBatcher.DecalVertexCBufferData.NativeFieldInfoPtr_decalBufferBaseIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalVertexCBufferData>.NativeClassPtr, nameof (decalBufferBaseIndex));
      DecalBatcher.DecalVertexCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalVertexCBufferData>.NativeClassPtr, nameof (padding));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalBatcher.DecalVertexCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DecalVertexShaderData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_worldMatrix;
    [FieldOffset(0)]
    public Matrix4x4 worldMatrix;

    static DecalVertexShaderData()
    {
      Il2CppClassPointerStore<DecalBatcher.DecalVertexShaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (DecalVertexShaderData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalBatcher.DecalVertexShaderData>.NativeClassPtr);
      DecalBatcher.DecalVertexShaderData.NativeFieldInfoPtr_worldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalVertexShaderData>.NativeClassPtr, nameof (worldMatrix));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalBatcher.DecalVertexShaderData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DecalFragmentCBufferData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_baseColorAlpha;
    private static readonly System.IntPtr NativeFieldInfoPtr_specularColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_emissionColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_smoothness;
    private static readonly System.IntPtr NativeFieldInfoPtr_baseColorInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_normalMapInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_specularColorInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_smoothnessInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_emissionColorInfluence;
    private static readonly System.IntPtr NativeFieldInfoPtr_padding;
    private static readonly System.IntPtr NativeFieldInfoPtr_texBaseColorTexelSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_texNormalMapTexelSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_texSpecularColorTexelSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_texEmissionColorTexelSize;
    [FieldOffset(0)]
    public Vector4 baseColorAlpha;
    [FieldOffset(16 /*0x10*/)]
    public Vector4 specularColor;
    [FieldOffset(32 /*0x20*/)]
    public Vector3 emissionColor;
    [FieldOffset(44)]
    public float smoothness;
    [FieldOffset(48 /*0x30*/)]
    public float baseColorInfluence;
    [FieldOffset(52)]
    public float normalMapInfluence;
    [FieldOffset(56)]
    public float specularColorInfluence;
    [FieldOffset(60)]
    public float smoothnessInfluence;
    [FieldOffset(64 /*0x40*/)]
    public float emissionColorInfluence;
    [FieldOffset(68)]
    public Vector3 padding;
    [FieldOffset(80 /*0x50*/)]
    public Vector4 texBaseColorTexelSize;
    [FieldOffset(96 /*0x60*/)]
    public Vector4 texNormalMapTexelSize;
    [FieldOffset(112 /*0x70*/)]
    public Vector4 texSpecularColorTexelSize;
    [FieldOffset(128 /*0x80*/)]
    public Vector4 texEmissionColorTexelSize;

    static DecalFragmentCBufferData()
    {
      Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (DecalFragmentCBufferData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr);
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_baseColorAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (baseColorAlpha));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_specularColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (specularColor));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_emissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (emissionColor));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_smoothness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (smoothness));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_baseColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (baseColorInfluence));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_normalMapInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (normalMapInfluence));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_specularColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (specularColorInfluence));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_smoothnessInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (smoothnessInfluence));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_emissionColorInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (emissionColorInfluence));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (padding));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_texBaseColorTexelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (texBaseColorTexelSize));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_texNormalMapTexelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (texNormalMapTexelSize));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_texSpecularColorTexelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (texSpecularColorTexelSize));
      DecalBatcher.DecalFragmentCBufferData.NativeFieldInfoPtr_texEmissionColorTexelSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, nameof (texEmissionColorTexelSize));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalBatcher.DecalFragmentCBufferData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DecalFragmentShaderData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_worldToObjectMatrix;
    private static readonly System.IntPtr NativeFieldInfoPtr_baseColorUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_specularColorUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_normalMapUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_emissionColorUvScaleOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_overallInfluence;
    [FieldOffset(0)]
    public Matrix4x4 worldToObjectMatrix;
    [FieldOffset(64 /*0x40*/)]
    public Vector4 baseColorUvScaleOffset;
    [FieldOffset(80 /*0x50*/)]
    public Vector4 specularColorUvScaleOffset;
    [FieldOffset(96 /*0x60*/)]
    public Vector4 normalMapUvScaleOffset;
    [FieldOffset(112 /*0x70*/)]
    public Vector4 emissionColorUvScaleOffset;
    [FieldOffset(128 /*0x80*/)]
    public float overallInfluence;

    static DecalFragmentShaderData()
    {
      Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (DecalFragmentShaderData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr);
      DecalBatcher.DecalFragmentShaderData.NativeFieldInfoPtr_worldToObjectMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr, nameof (worldToObjectMatrix));
      DecalBatcher.DecalFragmentShaderData.NativeFieldInfoPtr_baseColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr, nameof (baseColorUvScaleOffset));
      DecalBatcher.DecalFragmentShaderData.NativeFieldInfoPtr_specularColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr, nameof (specularColorUvScaleOffset));
      DecalBatcher.DecalFragmentShaderData.NativeFieldInfoPtr_normalMapUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr, nameof (normalMapUvScaleOffset));
      DecalBatcher.DecalFragmentShaderData.NativeFieldInfoPtr_emissionColorUvScaleOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr, nameof (emissionColorUvScaleOffset));
      DecalBatcher.DecalFragmentShaderData.NativeFieldInfoPtr_overallInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr, nameof (overallInfluence));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DecalBatcher.DecalFragmentShaderData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public sealed class Batch : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_material;
    private static readonly System.IntPtr NativeFieldInfoPtr_decalBufferBaseIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_decalCount;

    static Batch()
    {
      Il2CppClassPointerStore<DecalBatcher.Batch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DecalBatcher>.NativeClassPtr, nameof (Batch));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalBatcher.Batch>.NativeClassPtr);
      DecalBatcher.Batch.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.Batch>.NativeClassPtr, nameof (material));
      DecalBatcher.Batch.NativeFieldInfoPtr_decalBufferBaseIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.Batch>.NativeClassPtr, nameof (decalBufferBaseIndex));
      DecalBatcher.Batch.NativeFieldInfoPtr_decalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalBatcher.Batch>.NativeClassPtr, nameof (decalCount));
    }

    public Batch(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Batch()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalBatcher.Batch>.NativeClassPtr))
    {
    }

    public unsafe Material material
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.Batch.NativeFieldInfoPtr_material));
        return num == System.IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.Batch.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int decalBufferBaseIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.Batch.NativeFieldInfoPtr_decalBufferBaseIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.Batch.NativeFieldInfoPtr_decalBufferBaseIndex)) = value;
      }
    }

    public unsafe int decalCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.Batch.NativeFieldInfoPtr_decalCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalBatcher.Batch.NativeFieldInfoPtr_decalCount)) = value;
      }
    }
  }
}
