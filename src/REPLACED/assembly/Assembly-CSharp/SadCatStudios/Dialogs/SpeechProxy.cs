// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.SpeechProxy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Dialogs;

public class SpeechProxy(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_CallBubble_Public_Void_BubbleLineObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_CallSubtitles_Public_Void_StringVariable_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SpeechProxy()
  {
    Il2CppClassPointerStore<SpeechProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs", nameof (SpeechProxy));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechProxy>.NativeClassPtr);
    SpeechProxy.NativeMethodInfoPtr_CallBubble_Public_Void_BubbleLineObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechProxy>.NativeClassPtr, 100672655);
    SpeechProxy.NativeMethodInfoPtr_CallSubtitles_Public_Void_StringVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechProxy>.NativeClassPtr, 100672656);
    SpeechProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechProxy>.NativeClassPtr, 100672657);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CallBubble(BubbleLineObject bubbleLine)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bubbleLine)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechProxy.NativeMethodInfoPtr_CallBubble_Public_Void_BubbleLineObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CallSubtitles(StringVariable subtitle)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) subtitle)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechProxy.NativeMethodInfoPtr_CallSubtitles_Public_Void_StringVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechProxy()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechProxy>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
