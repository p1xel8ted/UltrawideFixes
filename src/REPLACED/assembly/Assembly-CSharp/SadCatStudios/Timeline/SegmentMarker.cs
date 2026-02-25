// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.SegmentMarker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Timeline;

#nullable disable
namespace SadCatStudios.Timeline;

public class SegmentMarker(IntPtr pointer) : Marker(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SegmentMarker()
  {
    Il2CppClassPointerStore<SegmentMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (SegmentMarker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SegmentMarker>.NativeClassPtr);
    SegmentMarker.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SegmentMarker>.NativeClassPtr, "<id>k__BackingField");
    SegmentMarker.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentMarker>.NativeClassPtr, 100670771);
    SegmentMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SegmentMarker>.NativeClassPtr, 100670772);
  }

  public virtual unsafe PropertyName id
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SegmentMarker.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_PropertyName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PropertyName*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SegmentMarker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SegmentMarker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SegmentMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PropertyName _id_k__BackingField
  {
    get
    {
      return *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SegmentMarker.NativeFieldInfoPtr__id_k__BackingField));
    }
    [param: In] set
    {
      *(PropertyName*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SegmentMarker.NativeFieldInfoPtr__id_k__BackingField)) = value;
    }
  }
}
