// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.MeshDisableHurtboxEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Animation;

[Serializable]
public class MeshDisableHurtboxEvent(IntPtr pointer) : MeshClipEvent(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshDisableHurtboxEvent()
  {
    Il2CppClassPointerStore<MeshDisableHurtboxEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (MeshDisableHurtboxEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshDisableHurtboxEvent>.NativeClassPtr);
    MeshDisableHurtboxEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshDisableHurtboxEvent>.NativeClassPtr, 100676810);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshDisableHurtboxEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshDisableHurtboxEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshDisableHurtboxEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
