// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.SubtitleBehavior
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
public class SubtitleBehavior(IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_SpeechLine;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SubtitleBehavior()
  {
    Il2CppClassPointerStore<SubtitleBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (SubtitleBehavior));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubtitleBehavior>.NativeClassPtr);
    SubtitleBehavior.NativeFieldInfoPtr_SpeechLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubtitleBehavior>.NativeClassPtr, nameof (SpeechLine));
    SubtitleBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubtitleBehavior>.NativeClassPtr, 100670804);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SubtitleBehavior()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubtitleBehavior>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubtitleBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef SpeechLine
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SubtitleBehavior.NativeFieldInfoPtr_SpeechLine));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SubtitleBehavior.NativeFieldInfoPtr_SpeechLine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
