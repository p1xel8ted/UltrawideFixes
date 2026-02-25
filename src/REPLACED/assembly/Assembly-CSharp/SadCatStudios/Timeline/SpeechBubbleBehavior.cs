// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.SpeechBubbleBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

[Serializable]
public class SpeechBubbleBehavior(IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_SpeechLine;
  private static readonly IntPtr NativeFieldInfoPtr_IsSkippable;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SpeechBubbleBehavior()
  {
    Il2CppClassPointerStore<SpeechBubbleBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (SpeechBubbleBehavior));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeechBubbleBehavior>.NativeClassPtr);
    SpeechBubbleBehavior.NativeFieldInfoPtr_SpeechLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleBehavior>.NativeClassPtr, nameof (SpeechLine));
    SpeechBubbleBehavior.NativeFieldInfoPtr_IsSkippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeechBubbleBehavior>.NativeClassPtr, nameof (IsSkippable));
    SpeechBubbleBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeechBubbleBehavior>.NativeClassPtr, 100670792);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88256, XrefRangeEnd = 88257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SpeechBubbleBehavior()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpeechBubbleBehavior>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SpeechBubbleBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef SpeechLine
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleBehavior.NativeFieldInfoPtr_SpeechLine));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleBehavior.NativeFieldInfoPtr_SpeechLine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool IsSkippable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleBehavior.NativeFieldInfoPtr_IsSkippable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpeechBubbleBehavior.NativeFieldInfoPtr_IsSkippable)) = value;
    }
  }
}
