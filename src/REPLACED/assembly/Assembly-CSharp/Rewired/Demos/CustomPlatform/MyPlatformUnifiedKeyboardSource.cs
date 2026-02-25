// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.MyPlatformUnifiedKeyboardSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Rewired.Platforms.Custom;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

public class MyPlatformUnifiedKeyboardSource(IntPtr pointer) : CustomPlatformUnifiedKeyboardSource(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_keyCodes;
  private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MyPlatformUnifiedKeyboardSource()
  {
    Il2CppClassPointerStore<MyPlatformUnifiedKeyboardSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (MyPlatformUnifiedKeyboardSource));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformUnifiedKeyboardSource>.NativeClassPtr);
    MyPlatformUnifiedKeyboardSource.NativeFieldInfoPtr_keyCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformUnifiedKeyboardSource>.NativeClassPtr, nameof (keyCodes));
    MyPlatformUnifiedKeyboardSource.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformUnifiedKeyboardSource>.NativeClassPtr, 100670552);
    MyPlatformUnifiedKeyboardSource.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformUnifiedKeyboardSource>.NativeClassPtr, 100670553);
    MyPlatformUnifiedKeyboardSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformUnifiedKeyboardSource>.NativeClassPtr, 100670554);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85931, XrefRangeEnd = 85952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnInitialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MyPlatformUnifiedKeyboardSource.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85952, XrefRangeEnd = 85961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MyPlatformUnifiedKeyboardSource.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85961, XrefRangeEnd = 85962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MyPlatformUnifiedKeyboardSource()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformUnifiedKeyboardSource>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformUnifiedKeyboardSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Il2CppStructArray<KeyboardKeyCode> keyCodes
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(MyPlatformUnifiedKeyboardSource.NativeFieldInfoPtr_keyCodes, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (Il2CppStructArray<KeyboardKeyCode>) null : Il2CppObjectPool.Get<Il2CppStructArray<KeyboardKeyCode>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(MyPlatformUnifiedKeyboardSource.NativeFieldInfoPtr_keyCodes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
