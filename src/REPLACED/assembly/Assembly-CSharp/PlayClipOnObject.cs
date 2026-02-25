// Decompiled with JetBrains decompiler
// Type: PlayClipOnObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Playables;

#nullable disable
public class PlayClipOnObject(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_myClip;
  private static readonly IntPtr NativeFieldInfoPtr_graph;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayAnimation_Public_Void_GameObject_AnimationClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayClipOnObject()
  {
    Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PlayClipOnObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr);
    PlayClipOnObject.NativeFieldInfoPtr_myClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr, nameof (myClip));
    PlayClipOnObject.NativeFieldInfoPtr_graph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr, nameof (graph));
    PlayClipOnObject.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr, 100663374 /*0x0600004E*/);
    PlayClipOnObject.NativeMethodInfoPtr_PlayAnimation_Public_Void_GameObject_AnimationClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr, 100663375 /*0x0600004F*/);
    PlayClipOnObject.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr, 100663376 /*0x06000050*/);
    PlayClipOnObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr, 100663377 /*0x06000051*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16065, XrefRangeEnd = 16078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayClipOnObject.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16078, XrefRangeEnd = 16090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PlayAnimation(GameObject target, AnimationClip clip)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clip);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayClipOnObject.NativeMethodInfoPtr_PlayAnimation_Public_Void_GameObject_AnimationClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16090, XrefRangeEnd = 16092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayClipOnObject.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayClipOnObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayClipOnObject>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayClipOnObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AnimationClip myClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayClipOnObject.NativeFieldInfoPtr_myClip));
      return num == IntPtr.Zero ? (AnimationClip) null : Il2CppObjectPool.Get<AnimationClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayClipOnObject.NativeFieldInfoPtr_myClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableGraph graph
  {
    get
    {
      return *(PlayableGraph*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayClipOnObject.NativeFieldInfoPtr_graph));
    }
    [param: In] set
    {
      *(PlayableGraph*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayClipOnObject.NativeFieldInfoPtr_graph)) = value;
    }
  }
}
