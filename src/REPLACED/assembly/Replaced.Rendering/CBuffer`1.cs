// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CBuffer`1
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class CBuffer<Data>(System.IntPtr pointer) : Il2CppSystem.Object(pointer) where Data : new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeFieldInfoPtr__dataArray;
  private static readonly System.IntPtr NativeFieldInfoPtr__gpuCBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__shaderId;
  private static readonly System.IntPtr NativeFieldInfoPtr__boundAsGlobal;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateGpuCBuffer_Private_Void_CommandBuffer_0;

  static CBuffer()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", "CBuffer`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<Data>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr);
    CBuffer<Data>.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, nameof (data));
    CBuffer<Data>.NativeFieldInfoPtr__dataArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, nameof (_dataArray));
    CBuffer<Data>.NativeFieldInfoPtr__gpuCBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, nameof (_gpuCBuffer));
    CBuffer<Data>.NativeFieldInfoPtr__shaderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, nameof (_shaderId));
    CBuffer<Data>.NativeFieldInfoPtr__boundAsGlobal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, nameof (_boundAsGlobal));
    CBuffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, 100663313 /*0x06000011*/);
    CBuffer<Data>.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, 100663314 /*0x06000012*/);
    CBuffer<Data>.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, 100663315 /*0x06000013*/);
    CBuffer<Data>.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, 100663316 /*0x06000014*/);
    CBuffer<Data>.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, 100663317 /*0x06000015*/);
    CBuffer<Data>.NativeMethodInfoPtr_UpdateGpuCBuffer_Private_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr, 100663318 /*0x06000016*/);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 923972, RefRangeEnd = 923975, XrefRangeStart = 923963, XrefRangeEnd = 923972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CBuffer(string cbufferShaderName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CBuffer<Data>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(cbufferShaderName)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CBuffer<Data>.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 923978, RefRangeEnd = 924002, XrefRangeStart = 923975, XrefRangeEnd = 923978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindGlobal(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CBuffer<Data>.NativeMethodInfoPtr_BindGlobal_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 924005, RefRangeEnd = 924010, XrefRangeStart = 924002, XrefRangeEnd = 924005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Bind(CommandBuffer cmd, ComputeShader compute)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) compute);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CBuffer<Data>.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_ComputeShader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 924013, RefRangeEnd = 924016, XrefRangeStart = 924010, XrefRangeEnd = 924013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Bind(CommandBuffer cmd, Material material)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CBuffer<Data>.NativeMethodInfoPtr_Bind_Public_Void_CommandBuffer_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(36)]
  [CachedScanResults(RefRangeStart = 924018, RefRangeEnd = 924054, XrefRangeStart = 924016, XrefRangeEnd = 924018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CBuffer<Data>.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 924054, XrefRangeEnd = 924099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateGpuCBuffer(CommandBuffer cmd)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CBuffer<Data>.NativeMethodInfoPtr_UpdateGpuCBuffer_Private_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Data data
  {
    get
    {
      return IL2CPP.PointerToValueGeneric<Data>(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr_data), true, false);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr num1 = ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr_data);
      System.Type type = typeof (Data);
      if (!type.IsValueType)
      {
        if (!string.Equals(type.FullName, "System.String"))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((object) value as Il2CppObjectBase);
          if (ptr != System.IntPtr.Zero && IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)))
          {
            System.IntPtr num2 = ptr;
            System.IntPtr num3 = IL2CPP.il2cpp_object_unbox(ptr);
            int num4 = IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(num2), (uint&) System.IntPtr.Zero);
            __memcpy(num1, num3, num4);
          }
          else
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, ptr);
        }
        else
        {
          System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp((object) value as string);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, num1, il2Cpp);
        }
      }
      else
      {
        Data data = value;
        *(Data*) num1 = data;
      }
    }
  }

  public unsafe Il2CppArrayBase<Data> _dataArray
  {
    get
    {
      return Il2CppArrayBase<Data>.WrapNativeGenericArrayPointer(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr__dataArray)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr__dataArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ComputeBuffer _gpuCBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr__gpuCBuffer));
      return num == System.IntPtr.Zero ? (ComputeBuffer) null : Il2CppObjectPool.Get<ComputeBuffer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr__gpuCBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _shaderId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr__shaderId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr__shaderId)) = value;
    }
  }

  public unsafe bool _boundAsGlobal
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr__boundAsGlobal));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CBuffer<Data>.NativeFieldInfoPtr__boundAsGlobal)) = value;
    }
  }
}
