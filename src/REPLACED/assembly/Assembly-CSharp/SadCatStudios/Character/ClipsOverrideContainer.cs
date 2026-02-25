// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.ClipsOverrideContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Character;

public class ClipsOverrideContainer(IntPtr pointer) : SerializedScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_overrideClipsDictionary;
  private static readonly IntPtr NativeMethodInfoPtr_GetClip_Public_MeshClip_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ClipsOverrideContainer()
  {
    Il2CppClassPointerStore<ClipsOverrideContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (ClipsOverrideContainer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipsOverrideContainer>.NativeClassPtr);
    ClipsOverrideContainer.NativeFieldInfoPtr_overrideClipsDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipsOverrideContainer>.NativeClassPtr, nameof (overrideClipsDictionary));
    ClipsOverrideContainer.NativeMethodInfoPtr_GetClip_Public_MeshClip_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipsOverrideContainer>.NativeClassPtr, 100675600 /*0x06003010*/);
    ClipsOverrideContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipsOverrideContainer>.NativeClassPtr, 100675601);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118344, XrefRangeEnd = 118347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClip GetClip(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipsOverrideContainer.NativeMethodInfoPtr_GetClip_Public_MeshClip_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ClipsOverrideContainer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipsOverrideContainer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ClipsOverrideContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InjectionClipsDictionary overrideClipsDictionary
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipsOverrideContainer.NativeFieldInfoPtr_overrideClipsDictionary));
      return num == IntPtr.Zero ? (InjectionClipsDictionary) null : Il2CppObjectPool.Get<InjectionClipsDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipsOverrideContainer.NativeFieldInfoPtr_overrideClipsDictionary), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
