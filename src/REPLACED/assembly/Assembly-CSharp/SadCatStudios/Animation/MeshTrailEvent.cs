// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.MeshTrailEvent
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

#nullable disable
namespace SadCatStudios.Animation;

[Serializable]
public class MeshTrailEvent(IntPtr pointer) : MeshClipEvent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_TrailN;
  private static readonly IntPtr NativeFieldInfoPtr_Points;
  private static readonly IntPtr NativeFieldInfoPtr_ControlPoints;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MeshTrailEvent()
  {
    Il2CppClassPointerStore<MeshTrailEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (MeshTrailEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshTrailEvent>.NativeClassPtr);
    MeshTrailEvent.NativeFieldInfoPtr_TrailN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTrailEvent>.NativeClassPtr, nameof (TrailN));
    MeshTrailEvent.NativeFieldInfoPtr_Points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTrailEvent>.NativeClassPtr, nameof (Points));
    MeshTrailEvent.NativeFieldInfoPtr_ControlPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MeshTrailEvent>.NativeClassPtr, nameof (ControlPoints));
    MeshTrailEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTrailEvent>.NativeClassPtr, 100676818);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MeshTrailEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshTrailEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MeshTrailEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int TrailN
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshTrailEvent.NativeFieldInfoPtr_TrailN));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshTrailEvent.NativeFieldInfoPtr_TrailN)) = value;
    }
  }

  public unsafe MeshTrailEvent.PointDictionary Points
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshTrailEvent.NativeFieldInfoPtr_Points));
      return num == IntPtr.Zero ? (MeshTrailEvent.PointDictionary) null : Il2CppObjectPool.Get<MeshTrailEvent.PointDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshTrailEvent.NativeFieldInfoPtr_Points), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshTrailEvent.PointDictionary ControlPoints
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MeshTrailEvent.NativeFieldInfoPtr_ControlPoints));
      return num == IntPtr.Zero ? (MeshTrailEvent.PointDictionary) null : Il2CppObjectPool.Get<MeshTrailEvent.PointDictionary>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MeshTrailEvent.NativeFieldInfoPtr_ControlPoints), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class PointDictionary(IntPtr pointer) : UnitySerializedDictionary<int, Vector3>(pointer)
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static PointDictionary()
    {
      Il2CppClassPointerStore<MeshTrailEvent.PointDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MeshTrailEvent>.NativeClassPtr, nameof (PointDictionary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MeshTrailEvent.PointDictionary>.NativeClassPtr);
      MeshTrailEvent.PointDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MeshTrailEvent.PointDictionary>.NativeClassPtr, 100676819);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126407, XrefRangeEnd = 126410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PointDictionary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MeshTrailEvent.PointDictionary>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MeshTrailEvent.PointDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
