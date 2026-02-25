// Decompiled with JetBrains decompiler
// Type: UnityEngine.HashUtilities
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine;

public static class HashUtilities : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0;

  static HashUtilities()
  {
    Il2CppClassPointerStore<HashUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (HashUtilities));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashUtilities>.NativeClassPtr);
    HashUtilities.NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashUtilities>.NativeClassPtr, 100667184 /*0x06000F30*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 437842, RefRangeEnd = 437843, XrefRangeStart = 437841, XrefRangeEnd = 437842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void AppendHash(ref Hash128 inHash, ref Hash128 outHash)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref inHash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outHash;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HashUtilities.NativeMethodInfoPtr_AppendHash_Public_Static_Void_byref_Hash128_byref_Hash128_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public HashUtilities(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe void QuantisedMatrixHash(ref Matrix4x4 value, ref Hash128 hash)
  {
    fixed (Hash128* hash1 = &hash)
    {
      int* data = stackalloc int[16 /*0x10*/];
      for (int index = 0; index < 16 /*0x10*/; ++index)
        data[index] = (int) ((double) value[index] * 1000.0 + 0.5);
      HashUnsafeUtilities.ComputeHash128((void*) data, 64UL /*0x40*/, hash1);
    }
  }

  public static unsafe void QuantisedVectorHash(ref Vector3 value, ref Hash128 hash)
  {
    fixed (Hash128* hash1 = &hash)
    {
      int* data = stackalloc int[3];
      for (int index = 0; index < 3; ++index)
        data[index] = (int) ((double) value[index] * 1000.0 + 0.5);
      HashUnsafeUtilities.ComputeHash128((void*) data, 12UL, hash1);
    }
  }

  public static unsafe void ComputeHash128<T>(ref T value, ref Hash128 hash) where T : struct
  {
    HashUnsafeUtilities.ComputeHash128(UnsafeUtility.AddressOf<T>(ref value), (ulong) UnsafeUtility.SizeOf<T>(), (Hash128*) UnsafeUtility.AddressOf<Hash128>(ref hash));
  }

  public static void ComputeHash128(Il2CppStructArray<byte> value, ref Hash128 hash)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }
}
