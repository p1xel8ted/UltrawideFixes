// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.MyPlatformUnifiedMouseSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Rewired.Platforms.Custom;
using System;
using UnityEngine;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

public class MyPlatformUnifiedMouseSource(IntPtr pointer) : CustomPlatformUnifiedMouseSource(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_mousePosition_Public_Virtual_get_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MyPlatformUnifiedMouseSource()
  {
    Il2CppClassPointerStore<MyPlatformUnifiedMouseSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (MyPlatformUnifiedMouseSource));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformUnifiedMouseSource>.NativeClassPtr);
    MyPlatformUnifiedMouseSource.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformUnifiedMouseSource>.NativeClassPtr, 100670556);
    MyPlatformUnifiedMouseSource.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformUnifiedMouseSource>.NativeClassPtr, 100670557);
    MyPlatformUnifiedMouseSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformUnifiedMouseSource>.NativeClassPtr, 100670558);
  }

  public override unsafe Vector2 mousePosition
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85962, XrefRangeEnd = 85963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MyPlatformUnifiedMouseSource.NativeMethodInfoPtr_get_mousePosition_Public_Virtual_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85963, XrefRangeEnd = 86003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MyPlatformUnifiedMouseSource.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86003, XrefRangeEnd = 86004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MyPlatformUnifiedMouseSource()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformUnifiedMouseSource>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformUnifiedMouseSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
