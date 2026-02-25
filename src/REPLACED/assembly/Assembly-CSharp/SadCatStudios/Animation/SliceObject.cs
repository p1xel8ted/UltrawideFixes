// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Animation.SliceObject
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
public class SliceObject(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_pivot;
  private static readonly System.IntPtr NativeFieldInfoPtr_size;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Title_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_SliceType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Pivot_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SliceType_Vector2_Vector2_0;

  static SliceObject()
  {
    Il2CppClassPointerStore<SliceObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Animation", nameof (SliceObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SliceObject>.NativeClassPtr);
    SliceObject.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, nameof (title));
    SliceObject.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, nameof (type));
    SliceObject.NativeFieldInfoPtr_pivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, nameof (pivot));
    SliceObject.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, nameof (size));
    SliceObject.NativeMethodInfoPtr_get_Title_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, 100676839);
    SliceObject.NativeMethodInfoPtr_get_Type_Public_get_SliceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, 100676840);
    SliceObject.NativeMethodInfoPtr_get_Pivot_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, 100676841);
    SliceObject.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, 100676842);
    SliceObject.NativeMethodInfoPtr__ctor_Public_Void_String_SliceType_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SliceObject>.NativeClassPtr, 100676843);
  }

  public unsafe string Title
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SliceObject.NativeMethodInfoPtr_get_Title_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe SliceObject.SliceType Type
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SliceObject.NativeMethodInfoPtr_get_Type_Public_get_SliceType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SliceObject.SliceType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector2 Pivot
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SliceObject.NativeMethodInfoPtr_get_Pivot_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector2 Size
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SliceObject.NativeMethodInfoPtr_get_Size_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126439, XrefRangeEnd = 126440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SliceObject(string title, SliceObject.SliceType type, Vector2 pivot, Vector2 size)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SliceObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SliceObject.NativeMethodInfoPtr__ctor_Public_Void_String_SliceType_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string title
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliceObject.NativeFieldInfoPtr_title)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SliceObject.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe SliceObject.SliceType type
  {
    get
    {
      return *(SliceObject.SliceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliceObject.NativeFieldInfoPtr_type));
    }
    [param: In] set
    {
      *(SliceObject.SliceType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliceObject.NativeFieldInfoPtr_type)) = value;
    }
  }

  public unsafe Vector2 pivot
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliceObject.NativeFieldInfoPtr_pivot));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliceObject.NativeFieldInfoPtr_pivot)) = value;
    }
  }

  public unsafe Vector2 size
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliceObject.NativeFieldInfoPtr_size));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SliceObject.NativeFieldInfoPtr_size)) = value;
    }
  }

  public enum SliceType
  {
    None,
    Pivot,
    Anchor,
    Direction,
  }
}
