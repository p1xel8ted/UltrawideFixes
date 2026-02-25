// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.MeshParryWindowEvent
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
public class MeshParryWindowEvent(IntPtr pointer) : MeshClipEvent(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshParryWindowEvent()
  {
    Il2CppClassPointerStore<MeshParryWindowEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (MeshParryWindowEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshParryWindowEvent>.NativeClassPtr);
    MeshParryWindowEvent.NativeMethodInfoPtr_Init_Public_Virtual_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshParryWindowEvent>.NativeClassPtr, 100676811);
    MeshParryWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshParryWindowEvent>.NativeClassPtr, 100676812);
  }

  [CallerCount(0)]
  public override unsafe void Init(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MeshParryWindowEvent.NativeMethodInfoPtr_Init_Public_Virtual_Void_MeshClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshParryWindowEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshParryWindowEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshParryWindowEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
