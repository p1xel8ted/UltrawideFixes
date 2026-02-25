// Decompiled with JetBrains decompiler
// Type: _PrivateImplementationDetails_
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__0146FAD5655123F5312222BA31AB6F8D0B57E62C1E432A5600A5A24A6ADEC5FB;
  private static readonly System.IntPtr NativeFieldInfoPtr__2F2442B871968848DFAB7ED3D77D70D04B91626C8E8B25F81FD3E1924F0D904A;
  private static readonly System.IntPtr NativeFieldInfoPtr__6C597E971911D11E593BBAB93B01302B01C7572E99E5346C35D23C638F508F25;
  private static readonly System.IntPtr NativeFieldInfoPtr_ADD3DF7723627FC8A5E90FB36347C1D0240295E22F070976C570A84FDEE1478C;
  private static readonly System.IntPtr NativeFieldInfoPtr_B9F81DC5320291C7D3C967CEB5B6AC0F91C63C34D6EEBCCDB74356FC8CE6A9CF;
  private static readonly System.IntPtr NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ThrowSwitchExpressionException_Internal_Static_Void_Object_0;

  static _PrivateImplementationDetails_()
  {
    Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "<PrivateImplementationDetails>");
    _PrivateImplementationDetails_.NativeFieldInfoPtr__0146FAD5655123F5312222BA31AB6F8D0B57E62C1E432A5600A5A24A6ADEC5FB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "0146FAD5655123F5312222BA31AB6F8D0B57E62C1E432A5600A5A24A6ADEC5FB");
    _PrivateImplementationDetails_.NativeFieldInfoPtr__2F2442B871968848DFAB7ED3D77D70D04B91626C8E8B25F81FD3E1924F0D904A = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "2F2442B871968848DFAB7ED3D77D70D04B91626C8E8B25F81FD3E1924F0D904A");
    _PrivateImplementationDetails_.NativeFieldInfoPtr__6C597E971911D11E593BBAB93B01302B01C7572E99E5346C35D23C638F508F25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "6C597E971911D11E593BBAB93B01302B01C7572E99E5346C35D23C638F508F25");
    _PrivateImplementationDetails_.NativeFieldInfoPtr_ADD3DF7723627FC8A5E90FB36347C1D0240295E22F070976C570A84FDEE1478C = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, nameof (ADD3DF7723627FC8A5E90FB36347C1D0240295E22F070976C570A84FDEE1478C));
    _PrivateImplementationDetails_.NativeFieldInfoPtr_B9F81DC5320291C7D3C967CEB5B6AC0F91C63C34D6EEBCCDB74356FC8CE6A9CF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, nameof (B9F81DC5320291C7D3C967CEB5B6AC0F91C63C34D6EEBCCDB74356FC8CE6A9CF));
    _PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, 100679894);
    _PrivateImplementationDetails_.NativeMethodInfoPtr_ThrowSwitchExpressionException_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, 100679895);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 147314, RefRangeEnd = 147339, XrefRangeStart = 147312, XrefRangeEnd = 147314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe uint ComputeStringHash(string s)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(s)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(_PrivateImplementationDetails_.NativeMethodInfoPtr_ComputeStringHash_Internal_Static_UInt32_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 147344, RefRangeEnd = 147348, XrefRangeStart = 147339, XrefRangeEnd = 147344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ThrowSwitchExpressionException(Il2CppSystem.Object unmatchedValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unmatchedValue)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(_PrivateImplementationDetails_.NativeMethodInfoPtr_ThrowSwitchExpressionException_Internal_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe _PrivateImplementationDetails_.ValueTypeNPrivateSealed1 _0146FAD5655123F5312222BA31AB6F8D0B57E62C1E432A5600A5A24A6ADEC5FB
  {
    get
    {
      _PrivateImplementationDetails_.ValueTypeNPrivateSealed1 a5600A5A24A6AdeC5Fb;
      IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__0146FAD5655123F5312222BA31AB6F8D0B57E62C1E432A5600A5A24A6ADEC5FB, (void*) &a5600A5A24A6AdeC5Fb);
      return a5600A5A24A6AdeC5Fb;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__0146FAD5655123F5312222BA31AB6F8D0B57E62C1E432A5600A5A24A6ADEC5FB, (void*) &value);
    }
  }

  public static unsafe _PrivateImplementationDetails_.ValueTypeNPrivateSealed4 _2F2442B871968848DFAB7ED3D77D70D04B91626C8E8B25F81FD3E1924F0D904A
  {
    get
    {
      _PrivateImplementationDetails_.ValueTypeNPrivateSealed4 f81Fd3E1924F0D904A;
      IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__2F2442B871968848DFAB7ED3D77D70D04B91626C8E8B25F81FD3E1924F0D904A, (void*) &f81Fd3E1924F0D904A);
      return f81Fd3E1924F0D904A;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__2F2442B871968848DFAB7ED3D77D70D04B91626C8E8B25F81FD3E1924F0D904A, (void*) &value);
    }
  }

  public static unsafe _PrivateImplementationDetails_.ValueTypeNPrivateSealed0 _6C597E971911D11E593BBAB93B01302B01C7572E99E5346C35D23C638F508F25
  {
    get
    {
      _PrivateImplementationDetails_.ValueTypeNPrivateSealed0 c35D23C638F508F25;
      IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__6C597E971911D11E593BBAB93B01302B01C7572E99E5346C35D23C638F508F25, (void*) &c35D23C638F508F25);
      return c35D23C638F508F25;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr__6C597E971911D11E593BBAB93B01302B01C7572E99E5346C35D23C638F508F25, (void*) &value);
    }
  }

  public static unsafe _PrivateImplementationDetails_.ValueTypeNPrivateSealed3 ADD3DF7723627FC8A5E90FB36347C1D0240295E22F070976C570A84FDEE1478C
  {
    get
    {
      _PrivateImplementationDetails_.ValueTypeNPrivateSealed3 c570A84FdeE1478C;
      IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_ADD3DF7723627FC8A5E90FB36347C1D0240295E22F070976C570A84FDEE1478C, (void*) &c570A84FdeE1478C);
      return c570A84FdeE1478C;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_ADD3DF7723627FC8A5E90FB36347C1D0240295E22F070976C570A84FDEE1478C, (void*) &value);
    }
  }

  public static unsafe _PrivateImplementationDetails_.ValueTypeNPrivateSealed2 B9F81DC5320291C7D3C967CEB5B6AC0F91C63C34D6EEBCCDB74356FC8CE6A9CF
  {
    get
    {
      _PrivateImplementationDetails_.ValueTypeNPrivateSealed2 b74356Fc8Ce6A9Cf;
      IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_B9F81DC5320291C7D3C967CEB5B6AC0F91C63C34D6EEBCCDB74356FC8CE6A9CF, (void*) &b74356Fc8Ce6A9Cf);
      return b74356Fc8Ce6A9Cf;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_B9F81DC5320291C7D3C967CEB5B6AC0F91C63C34D6EEBCCDB74356FC8CE6A9CF, (void*) &value);
    }
  }

  [ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=16")]
  [StructLayout(LayoutKind.Explicit)]
  public struct ValueTypeNPrivateSealed0
  {
    static ValueTypeNPrivateSealed0()
    {
      Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=16");
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed0>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=32")]
  [StructLayout(LayoutKind.Explicit)]
  public struct ValueTypeNPrivateSealed1
  {
    static ValueTypeNPrivateSealed1()
    {
      Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=32");
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed1>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=64")]
  [StructLayout(LayoutKind.Explicit)]
  public struct ValueTypeNPrivateSealed2
  {
    static ValueTypeNPrivateSealed2()
    {
      Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=64");
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed2>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=85002")]
  [StructLayout(LayoutKind.Explicit)]
  public struct ValueTypeNPrivateSealed3
  {
    static ValueTypeNPrivateSealed3()
    {
      Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=85002");
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed3>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=88361")]
  [StructLayout(LayoutKind.Explicit)]
  public struct ValueTypeNPrivateSealed4
  {
    static ValueTypeNPrivateSealed4()
    {
      Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=88361");
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealed4>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
