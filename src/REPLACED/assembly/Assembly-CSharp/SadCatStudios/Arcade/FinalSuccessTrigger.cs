// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.FinalSuccessTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class FinalSuccessTrigger(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FinalSuccessTrigger()
  {
    Il2CppClassPointerStore<FinalSuccessTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (FinalSuccessTrigger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalSuccessTrigger>.NativeClassPtr);
    FinalSuccessTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalSuccessTrigger>.NativeClassPtr, 100676500);
    FinalSuccessTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalSuccessTrigger>.NativeClassPtr, 100676501);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123783, XrefRangeEnd = 123790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter2D(Collider2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalSuccessTrigger.NativeMethodInfoPtr_OnTriggerEnter2D_Private_Void_Collider2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalSuccessTrigger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalSuccessTrigger>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalSuccessTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
