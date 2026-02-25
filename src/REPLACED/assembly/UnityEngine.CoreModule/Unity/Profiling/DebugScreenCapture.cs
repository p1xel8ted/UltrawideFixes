// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.DebugScreenCapture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;

#nullable disable
namespace Unity.Profiling;

public sealed class DebugScreenCapture : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr__RawImageDataReference_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ImageFormat_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Width_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Height_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0;

  static DebugScreenCapture()
  {
    Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling", nameof (DebugScreenCapture));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr);
    DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<RawImageDataReference>k__BackingField");
    DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<ImageFormat>k__BackingField");
    DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<Width>k__BackingField");
    DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, "<Height>k__BackingField");
    DebugScreenCapture.NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663414 /*0x06000076*/);
    DebugScreenCapture.NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663415 /*0x06000077*/);
    DebugScreenCapture.NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663416 /*0x06000078*/);
    DebugScreenCapture.NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr, 100663417 /*0x06000079*/);
  }

  public unsafe NativeArray<byte> RawImageDataReference
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 70612, RefRangeEnd = 70627, XrefRangeStart = 70612, XrefRangeEnd = 70627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_RawImageDataReference_Public_set_Void_NativeArray_1_Byte_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._RawImageDataReference_k__BackingField;
  }

  public unsafe TextureFormat ImageFormat
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_ImageFormat_Public_set_Void_TextureFormat_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._ImageFormat_k__BackingField;
  }

  public unsafe int Width
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_Width_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._Width_k__BackingField;
  }

  public unsafe int Height
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DebugScreenCapture.NativeMethodInfoPtr_set_Height_Public_set_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._Height_k__BackingField;
  }

  public DebugScreenCapture(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public DebugScreenCapture()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugScreenCapture>.NativeClassPtr))
  {
  }

  public NativeArray<byte> _RawImageDataReference_k__BackingField
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField);
      return new NativeArray<byte>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__RawImageDataReference_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<byte>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe TextureFormat _ImageFormat_k__BackingField
  {
    get
    {
      return *(TextureFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField));
    }
    [param: In] set
    {
      *(TextureFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__ImageFormat_k__BackingField)) = value;
    }
  }

  public unsafe int _Width_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Width_k__BackingField)) = value;
    }
  }

  public unsafe int _Height_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugScreenCapture.NativeFieldInfoPtr__Height_k__BackingField)) = value;
    }
  }
}
