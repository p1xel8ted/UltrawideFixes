// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.BirdsFlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class BirdsFlock(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_takeoffEvent;
  private static readonly IntPtr NativeFieldInfoPtr_birds;
  private static readonly IntPtr NativeFieldInfoPtr_hasFlewAway;
  private static readonly IntPtr NativeMethodInfoPtr_RefillBirdsArray_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Fly_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BirdsFlock()
  {
    Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (BirdsFlock));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr);
    BirdsFlock.NativeFieldInfoPtr_takeoffEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr, nameof (takeoffEvent));
    BirdsFlock.NativeFieldInfoPtr_birds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr, nameof (birds));
    BirdsFlock.NativeFieldInfoPtr_hasFlewAway = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr, nameof (hasFlewAway));
    BirdsFlock.NativeMethodInfoPtr_RefillBirdsArray_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr, 100675871);
    BirdsFlock.NativeMethodInfoPtr_Fly_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr, 100675872);
    BirdsFlock.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr, 100675873);
    BirdsFlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr, 100675874);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120104, XrefRangeEnd = 120107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefillBirdsArray()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BirdsFlock.NativeMethodInfoPtr_RefillBirdsArray_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120107, XrefRangeEnd = 120116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Fly()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BirdsFlock.NativeMethodInfoPtr_Fly_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120116, XrefRangeEnd = 120120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BirdsFlock.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BirdsFlock()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsFlock>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BirdsFlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference takeoffEvent
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BirdsFlock.NativeFieldInfoPtr_takeoffEvent));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BirdsFlock.NativeFieldInfoPtr_takeoffEvent)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<Birds> birds
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BirdsFlock.NativeFieldInfoPtr_birds));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Birds>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Birds>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BirdsFlock.NativeFieldInfoPtr_birds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool hasFlewAway
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BirdsFlock.NativeFieldInfoPtr_hasFlewAway));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BirdsFlock.NativeFieldInfoPtr_hasFlewAway)) = value;
    }
  }
}
