// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.LineFixedSizeList
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

public sealed class LineFixedSizeList(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kMaxLineCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__positionBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__colorBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr__lineCount;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Vector3_Vector3_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BindAndUpdateData_Public_Void_CommandBuffer_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static LineFixedSizeList()
  {
    Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (LineFixedSizeList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr);
    LineFixedSizeList.NativeFieldInfoPtr_kMaxLineCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, nameof (kMaxLineCount));
    LineFixedSizeList.NativeFieldInfoPtr__positionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, nameof (_positionBuffer));
    LineFixedSizeList.NativeFieldInfoPtr__colorBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, nameof (_colorBuffer));
    LineFixedSizeList.NativeFieldInfoPtr__lineCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, nameof (_lineCount));
    LineFixedSizeList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, 100663481 /*0x060000B9*/);
    LineFixedSizeList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, 100663482 /*0x060000BA*/);
    LineFixedSizeList.NativeMethodInfoPtr_Add_Public_Void_Vector3_Vector3_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, 100663483 /*0x060000BB*/);
    LineFixedSizeList.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, 100663484 /*0x060000BC*/);
    LineFixedSizeList.NativeMethodInfoPtr_BindAndUpdateData_Public_Void_CommandBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, 100663485 /*0x060000BD*/);
    LineFixedSizeList.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr, 100663486 /*0x060000BE*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925383, XrefRangeEnd = 925400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LineFixedSizeList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineFixedSizeList>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineFixedSizeList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int Count
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LineFixedSizeList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925400, XrefRangeEnd = 925408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(Vector3 p0, Vector3 p1, Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &p0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineFixedSizeList.NativeMethodInfoPtr_Add_Public_Void_Vector3_Vector3_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105889, RefRangeEnd = 105890, XrefRangeStart = 105889, XrefRangeEnd = 105890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineFixedSizeList.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925408, XrefRangeEnd = 925421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void BindAndUpdateData(
    CommandBuffer cmd,
    int sidPositionBuffer,
    int sidColorBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cmd);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sidPositionBuffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sidColorBuffer;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineFixedSizeList.NativeMethodInfoPtr_BindAndUpdateData_Public_Void_CommandBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 925421, XrefRangeEnd = 925428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LineFixedSizeList.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kMaxLineCount
  {
    get
    {
      int kMaxLineCount;
      IL2CPP.il2cpp_field_static_get_value(LineFixedSizeList.NativeFieldInfoPtr_kMaxLineCount, (void*) &kMaxLineCount);
      return kMaxLineCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(LineFixedSizeList.NativeFieldInfoPtr_kMaxLineCount, (void*) &value);
    }
  }

  public unsafe Buffer<Vector3> _positionBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineFixedSizeList.NativeFieldInfoPtr__positionBuffer));
      return num == System.IntPtr.Zero ? (Buffer<Vector3>) null : Il2CppObjectPool.Get<Buffer<Vector3>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineFixedSizeList.NativeFieldInfoPtr__positionBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Buffer<Color32> _colorBuffer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineFixedSizeList.NativeFieldInfoPtr__colorBuffer));
      return num == System.IntPtr.Zero ? (Buffer<Color32>) null : Il2CppObjectPool.Get<Buffer<Color32>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LineFixedSizeList.NativeFieldInfoPtr__colorBuffer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _lineCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineFixedSizeList.NativeFieldInfoPtr__lineCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineFixedSizeList.NativeFieldInfoPtr__lineCount)) = value;
    }
  }
}
