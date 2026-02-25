// Decompiled with JetBrains decompiler
// Type: UnityEngine.SpookyHash
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public static class SpookyHash : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0;
  public const int k_NumVars = 12;
  public const int k_BlockSize = 96 /*0x60*/;
  public const int k_BufferSize = 192 /*0xC0*/;
  public const ulong k_DeadBeefConst = 16045690984833335023 /*0xDEADBEEFDEADBEEF*/;

  static SpookyHash()
  {
    Il2CppClassPointerStore<SpookyHash>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (SpookyHash));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr);
    SpookyHash.NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100667187);
    SpookyHash.NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100667188);
    SpookyHash.NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100667189);
    SpookyHash.NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100667190);
    SpookyHash.NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100667191);
    SpookyHash.NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100667192);
    SpookyHash.NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100667193);
    SpookyHash.NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, 100667194);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 437857, RefRangeEnd = 437860, XrefRangeStart = 437848, XrefRangeEnd = 437857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Hash(void* message, ulong length, ulong* hash1, ulong* hash2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) message;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) hash1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) hash2;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Hash_Public_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437860, XrefRangeEnd = 437863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void End(
    ulong* data,
    ref ulong h0,
    ref ulong h1,
    ref ulong h2,
    ref ulong h3,
    ref ulong h4,
    ref ulong h5,
    ref ulong h6,
    ref ulong h7,
    ref ulong h8,
    ref ulong h9,
    ref ulong h10,
    ref ulong h11)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[13];
    numPtr[0] = (System.IntPtr) data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref h0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref h1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref h2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref h3;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref h4;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref h5;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref h6;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref h7;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref h8;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref h9;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref h10;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) ref h11;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_End_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 437863, RefRangeEnd = 437869, XrefRangeStart = 437863, XrefRangeEnd = 437863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EndPartial(
    ref ulong h0,
    ref ulong h1,
    ref ulong h2,
    ref ulong h3,
    ref ulong h4,
    ref ulong h5,
    ref ulong h6,
    ref ulong h7,
    ref ulong h8,
    ref ulong h9,
    ref ulong h10,
    ref ulong h11)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[12];
    numPtr[0] = (System.IntPtr) ref h0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref h1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref h2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref h3;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref h4;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref h5;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref h6;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref h7;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref h8;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref h9;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref h10;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref h11;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_EndPartial_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe void Rot64(ref ulong x, int k)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &k;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Rot64_Private_Static_Void_byref_UInt64_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 437877, RefRangeEnd = 437878, XrefRangeStart = 437869, XrefRangeEnd = 437877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Short(void* message, ulong length, ulong* hash1, ulong* hash2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) message;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &length;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) hash1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) hash2;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Short_Private_Static_Void_ptr_Void_UInt64_ptr_UInt64_ptr_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref h0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref h1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref h2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref h3;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_ShortMix_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) ref h0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref h1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref h2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref h3;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_ShortEnd_Private_Static_Void_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe void Mix(
    ulong* data,
    ref ulong s0,
    ref ulong s1,
    ref ulong s2,
    ref ulong s3,
    ref ulong s4,
    ref ulong s5,
    ref ulong s6,
    ref ulong s7,
    ref ulong s8,
    ref ulong s9,
    ref ulong s10,
    ref ulong s11)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[13];
    numPtr[0] = (System.IntPtr) data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref s0;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref s1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref s2;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref s3;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref s4;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref s5;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref s6;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref s7;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref s8;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) ref s9;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) ref s10;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) ref s11;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpookyHash.NativeMethodInfoPtr_Mix_Private_Static_Void_ptr_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_byref_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public SpookyHash(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct U
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_p8;
    private static readonly System.IntPtr NativeFieldInfoPtr_p32;
    private static readonly System.IntPtr NativeFieldInfoPtr_p64;
    private static readonly System.IntPtr NativeFieldInfoPtr_i;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0;
    [FieldOffset(0)]
    public System.IntPtr p8;
    [FieldOffset(0)]
    public System.IntPtr p32;
    [FieldOffset(0)]
    public System.IntPtr p64;
    [FieldOffset(0)]
    public ulong i;

    static U()
    {
      Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpookyHash>.NativeClassPtr, nameof (U));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr);
      SpookyHash.U.NativeFieldInfoPtr_p8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, nameof (p8));
      SpookyHash.U.NativeFieldInfoPtr_p32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, nameof (p32));
      SpookyHash.U.NativeFieldInfoPtr_p64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, nameof (p64));
      SpookyHash.U.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, nameof (i));
      SpookyHash.U.NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, 100667195);
    }

    [CallerCount(65)]
    [CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe U(ushort* p8)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) p8
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SpookyHash.U.NativeMethodInfoPtr__ctor_Public_Void_ptr_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpookyHash.U>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
