// Decompiled with JetBrains decompiler
// Type: UnityEngine.LowerResBlitTexture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine;

public class LowerResBlitTexture(IntPtr pointer) : Object(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0;

  static LowerResBlitTexture()
  {
    Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LowerResBlitTexture));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr);
    LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowerResBlitTexture>.NativeClassPtr, 100668513);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LowerResBlitTextureDontStripMe()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LowerResBlitTexture.NativeMethodInfoPtr_LowerResBlitTextureDontStripMe_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
