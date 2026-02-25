// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.MeshClipEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Animation;

[Serializable]
public class MeshClipEvent(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_FrameRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_FrameCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_MeshClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static MeshClipEvent()
  {
    Il2CppClassPointerStore<MeshClipEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (MeshClipEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClipEvent>.NativeClassPtr);
    MeshClipEvent.NativeFieldInfoPtr_FrameRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipEvent>.NativeClassPtr, nameof (FrameRange));
    MeshClipEvent.NativeFieldInfoPtr_FrameCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipEvent>.NativeClassPtr, nameof (FrameCount));
    MeshClipEvent.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipEvent>.NativeClassPtr, 100676808);
    MeshClipEvent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipEvent>.NativeClassPtr, 100676809);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Init(MeshClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MeshClipEvent.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_MeshClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClipEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClipEvent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshClipEvent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector2Int FrameRange
  {
    get
    {
      return *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipEvent.NativeFieldInfoPtr_FrameRange));
    }
    [param: In] set
    {
      *(Vector2Int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipEvent.NativeFieldInfoPtr_FrameRange)) = value;
    }
  }

  public unsafe int FrameCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipEvent.NativeFieldInfoPtr_FrameCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipEvent.NativeFieldInfoPtr_FrameCount)) = value;
    }
  }
}
