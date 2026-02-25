// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.Input
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Windows;

public static class Input : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ForwardRawInputImpl_Private_Static_Void_ptr_UInt32_ptr_UInt32_UInt32_ptr_Byte_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForwardRawInput_Public_Static_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ForwardRawInput_Public_Static_Void_ptr_UInt32_ptr_UInt32_UInt32_ptr_Byte_UInt32_0;

  static Input()
  {
    Il2CppClassPointerStore<Input>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows", nameof (Input));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Input>.NativeClassPtr);
    Input.NativeMethodInfoPtr_ForwardRawInputImpl_Private_Static_Void_ptr_UInt32_ptr_UInt32_UInt32_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100668958);
    Input.NativeMethodInfoPtr_ForwardRawInput_Public_Static_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100668959);
    Input.NativeMethodInfoPtr_ForwardRawInput_Public_Static_Void_ptr_UInt32_ptr_UInt32_UInt32_ptr_Byte_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Input>.NativeClassPtr, 100668960);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472554, XrefRangeEnd = 472556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ForwardRawInputImpl(
    uint* rawInputHeaderIndices,
    uint* rawInputDataIndices,
    uint indicesCount,
    byte* rawInputData,
    uint rawInputDataSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) rawInputHeaderIndices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) rawInputDataIndices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &indicesCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) rawInputData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputDataSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_ForwardRawInputImpl_Private_Static_Void_ptr_UInt32_ptr_UInt32_UInt32_ptr_Byte_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472579, RefRangeEnd = 472580, XrefRangeStart = 472556, XrefRangeEnd = 472579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ForwardRawInput(
    System.IntPtr rawInputHeaderIndices,
    System.IntPtr rawInputDataIndices,
    uint indicesCount,
    System.IntPtr rawInputData,
    uint rawInputDataSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &rawInputHeaderIndices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputDataIndices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &indicesCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputDataSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_ForwardRawInput_Public_Static_Void_IntPtr_IntPtr_UInt32_IntPtr_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 472600, RefRangeEnd = 472601, XrefRangeStart = 472580, XrefRangeEnd = 472600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ForwardRawInput(
    uint* rawInputHeaderIndices,
    uint* rawInputDataIndices,
    uint indicesCount,
    byte* rawInputData,
    uint rawInputDataSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) rawInputHeaderIndices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) rawInputDataIndices;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &indicesCount;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) rawInputData;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &rawInputDataSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Input.NativeMethodInfoPtr_ForwardRawInput_Public_Static_Void_ptr_UInt32_ptr_UInt32_UInt32_ptr_Byte_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Input(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
