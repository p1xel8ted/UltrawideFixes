// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.MyPlatformControllerIdentifier
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

[StructLayout(LayoutKind.Explicit)]
public struct MyPlatformControllerIdentifier
{
  private static readonly System.IntPtr NativeFieldInfoPtr_vendorId;
  private static readonly System.IntPtr NativeFieldInfoPtr_productId;
  [FieldOffset(0)]
  public ushort vendorId;
  [FieldOffset(2)]
  public ushort productId;

  static MyPlatformControllerIdentifier()
  {
    Il2CppClassPointerStore<MyPlatformControllerIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (MyPlatformControllerIdentifier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformControllerIdentifier>.NativeClassPtr);
    MyPlatformControllerIdentifier.NativeFieldInfoPtr_vendorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformControllerIdentifier>.NativeClassPtr, nameof (vendorId));
    MyPlatformControllerIdentifier.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformControllerIdentifier>.NativeClassPtr, nameof (productId));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MyPlatformControllerIdentifier>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
