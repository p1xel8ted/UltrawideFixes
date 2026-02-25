// Decompiled with JetBrains decompiler
// Type: _PrivateImplementationDetails_
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
[ObfuscatedName("<PrivateImplementationDetails>")]
public sealed class _PrivateImplementationDetails_(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32;

  static _PrivateImplementationDetails_()
  {
    Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "", "<PrivateImplementationDetails>");
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr);
    _PrivateImplementationDetails_.NativeFieldInfoPtr_AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, nameof (AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32));
  }

  public static unsafe _PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32
  {
    get
    {
      _PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique e864A950696D743Cc32;
      IL2CPP.il2cpp_field_static_get_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32, (void*) &e864A950696D743Cc32);
      return e864A950696D743Cc32;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(_PrivateImplementationDetails_.NativeFieldInfoPtr_AA5072B96927F710758B3E5237A84AC68E397BC4E1BF7E864A950696D743CC32, (void*) &value);
    }
  }

  [ObfuscatedName("<PrivateImplementationDetails>+__StaticArrayInitTypeSize=12")]
  [StructLayout(LayoutKind.Explicit)]
  public struct ValueTypeNPrivateSealedUnique
  {
    static ValueTypeNPrivateSealedUnique()
    {
      Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<_PrivateImplementationDetails_>.NativeClassPtr, "__StaticArrayInitTypeSize=12");
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<_PrivateImplementationDetails_.ValueTypeNPrivateSealedUnique>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
