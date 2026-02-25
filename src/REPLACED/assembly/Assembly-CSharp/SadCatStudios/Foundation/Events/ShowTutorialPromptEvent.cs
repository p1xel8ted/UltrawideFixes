// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.ShowTutorialPromptEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.UI.Elements;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Foundation.Events;

public sealed class ShowTutorialPromptEvent : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_PromptText;
  private static readonly System.IntPtr NativeFieldInfoPtr_ShowAt;
  private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
  private static readonly System.IntPtr NativeFieldInfoPtr_Bounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_NeedMarker;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Transform_IBounds_Vector3_Boolean_0;

  static ShowTutorialPromptEvent()
  {
    Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (ShowTutorialPromptEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr);
    ShowTutorialPromptEvent.NativeFieldInfoPtr_PromptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr, nameof (PromptText));
    ShowTutorialPromptEvent.NativeFieldInfoPtr_ShowAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr, nameof (ShowAt));
    ShowTutorialPromptEvent.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr, nameof (Offset));
    ShowTutorialPromptEvent.NativeFieldInfoPtr_Bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr, nameof (Bounds));
    ShowTutorialPromptEvent.NativeFieldInfoPtr_NeedMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr, nameof (NeedMarker));
    ShowTutorialPromptEvent.NativeMethodInfoPtr__ctor_Public_Void_String_Transform_IBounds_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr, 100671462);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 94247, RefRangeEnd = 94250, XrefRangeStart = 94247, XrefRangeEnd = 94247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShowTutorialPromptEvent(
    string text,
    Transform showAt,
    UIPromtFollow.IBounds bounds,
    Vector3 offset,
    bool needMarker)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) showAt);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bounds);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &needMarker;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShowTutorialPromptEvent.NativeMethodInfoPtr__ctor_Public_Void_String_Transform_IBounds_Vector3_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ShowTutorialPromptEvent(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ShowTutorialPromptEvent()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTutorialPromptEvent>.NativeClassPtr))
  {
  }

  public unsafe string PromptText
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_PromptText)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_PromptText), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Transform ShowAt
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_ShowAt));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_ShowAt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 Offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_Offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_Offset)) = value;
    }
  }

  public unsafe UIPromtFollow.IBounds Bounds
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_Bounds));
      return num == System.IntPtr.Zero ? (UIPromtFollow.IBounds) null : Il2CppObjectPool.Get<UIPromtFollow.IBounds>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_Bounds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool NeedMarker
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_NeedMarker));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTutorialPromptEvent.NativeFieldInfoPtr_NeedMarker)) = value;
    }
  }
}
