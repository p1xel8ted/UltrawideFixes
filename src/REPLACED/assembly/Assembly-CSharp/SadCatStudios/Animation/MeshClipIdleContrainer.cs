// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.MeshClipIdleContrainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Animation;

public class MeshClipIdleContrainer(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_minCycles;
  private static readonly IntPtr NativeFieldInfoPtr_maxCycles;
  private static readonly IntPtr NativeFieldInfoPtr_idleLoopClip;
  private static readonly IntPtr NativeFieldInfoPtr_randomGestures;
  private static readonly IntPtr NativeMethodInfoPtr_get_IdleLoopClip_Public_get_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RandomGestures_Public_get_List_1_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRandomCycle_Public_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRandomGesture_Public_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshClipIdleContrainer()
  {
    Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (MeshClipIdleContrainer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr);
    MeshClipIdleContrainer.NativeFieldInfoPtr_minCycles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, nameof (minCycles));
    MeshClipIdleContrainer.NativeFieldInfoPtr_maxCycles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, nameof (maxCycles));
    MeshClipIdleContrainer.NativeFieldInfoPtr_idleLoopClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, nameof (idleLoopClip));
    MeshClipIdleContrainer.NativeFieldInfoPtr_randomGestures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, nameof (randomGestures));
    MeshClipIdleContrainer.NativeMethodInfoPtr_get_IdleLoopClip_Public_get_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, 100676834);
    MeshClipIdleContrainer.NativeMethodInfoPtr_get_RandomGestures_Public_get_List_1_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, 100676835);
    MeshClipIdleContrainer.NativeMethodInfoPtr_GetRandomCycle_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, 100676836);
    MeshClipIdleContrainer.NativeMethodInfoPtr_GetRandomGesture_Public_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, 100676837);
    MeshClipIdleContrainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr, 100676838);
  }

  public unsafe MeshClip IdleLoopClip
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipIdleContrainer.NativeMethodInfoPtr_get_IdleLoopClip_Public_get_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
    }
  }

  public unsafe List<MeshClip> RandomGestures
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipIdleContrainer.NativeMethodInfoPtr_get_RandomGestures_Public_get_List_1_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (List<MeshClip>) null : Il2CppObjectPool.Get<List<MeshClip>>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126430, RefRangeEnd = 126431, XrefRangeStart = 126429, XrefRangeEnd = 126430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetRandomCycle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipIdleContrainer.NativeMethodInfoPtr_GetRandomCycle_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 126437, RefRangeEnd = 126438, XrefRangeStart = 126431, XrefRangeEnd = 126437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClip GetRandomGesture()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MeshClipIdleContrainer.NativeMethodInfoPtr_GetRandomGesture_Public_MeshClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126438, XrefRangeEnd = 126439, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshClipIdleContrainer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshClipIdleContrainer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshClipIdleContrainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int minCycles
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipIdleContrainer.NativeFieldInfoPtr_minCycles));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipIdleContrainer.NativeFieldInfoPtr_minCycles)) = value;
    }
  }

  public unsafe int maxCycles
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipIdleContrainer.NativeFieldInfoPtr_maxCycles));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipIdleContrainer.NativeFieldInfoPtr_maxCycles)) = value;
    }
  }

  public unsafe MeshClip idleLoopClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipIdleContrainer.NativeFieldInfoPtr_idleLoopClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipIdleContrainer.NativeFieldInfoPtr_idleLoopClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<MeshClip> randomGestures
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshClipIdleContrainer.NativeFieldInfoPtr_randomGestures));
      return num == IntPtr.Zero ? (List<MeshClip>) null : Il2CppObjectPool.Get<List<MeshClip>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshClipIdleContrainer.NativeFieldInfoPtr_randomGestures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
