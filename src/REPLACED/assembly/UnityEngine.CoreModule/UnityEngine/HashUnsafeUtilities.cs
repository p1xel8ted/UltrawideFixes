// Decompiled with JetBrains decompiler
// Type: UnityEngine.HashUnsafeUtilities
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine;

public static class HashUnsafeUtilities : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0;

  static HashUnsafeUtilities()
  {
    Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (HashUnsafeUtilities));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr);
    HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr, 100667185);
    HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUnsafeUtilities>.NativeClassPtr, 100667186);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437843, XrefRangeEnd = 437844, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ComputeHash128(void* data, ulong dataSize, ulong* hash1, ulong* hash2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dataSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) hash1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) hash2;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 437845, RefRangeEnd = 437848, XrefRangeStart = 437844, XrefRangeEnd = 437845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ComputeHash128(void* data, ulong dataSize, Hash128* hash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dataSize;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) hash;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HashUnsafeUtilities.NativeMethodInfoPtr_ComputeHash128_Public_Static_Void_ptr_Void_UInt64_ptr_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public HashUnsafeUtilities(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
