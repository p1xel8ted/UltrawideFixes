// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.Hitbox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class Hitbox(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_pixelPerUnit;
  private static readonly System.IntPtr NativeFieldInfoPtr_parentTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_parentRenderer;
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Position_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalPosition_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_SpriteRenderer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Public_Void_Vector3_Vector2_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PositionForSlice_Public_Static_Vector3_Vector3_Vector2_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Reshape_Private_Void_Vector3_Vector2_Vector3_0;

  static Hitbox()
  {
    Il2CppClassPointerStore<Hitbox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (Hitbox));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hitbox>.NativeClassPtr);
    Hitbox.NativeFieldInfoPtr_pixelPerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, nameof (pixelPerUnit));
    Hitbox.NativeFieldInfoPtr_parentTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, nameof (parentTransform));
    Hitbox.NativeFieldInfoPtr_parentRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, nameof (parentRenderer));
    Hitbox.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, nameof (position));
    Hitbox.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, 100677612);
    Hitbox.NativeMethodInfoPtr_get_LocalPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, 100677613);
    Hitbox.NativeMethodInfoPtr__ctor_Public_Void_Transform_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, 100677614);
    Hitbox.NativeMethodInfoPtr_Reset_Public_Void_Vector3_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, 100677615);
    Hitbox.NativeMethodInfoPtr_PositionForSlice_Public_Static_Vector3_Vector3_Vector2_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, 100677616);
    Hitbox.NativeMethodInfoPtr_Reshape_Private_Void_Vector3_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hitbox>.NativeClassPtr, 100677617);
  }

  public unsafe Vector3 Position
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 130885, RefRangeEnd = 130891, XrefRangeStart = 130884, XrefRangeEnd = 130885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hitbox.NativeMethodInfoPtr_get_Position_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Vector3 LocalPosition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hitbox.NativeMethodInfoPtr_get_LocalPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130892, RefRangeEnd = 130893, XrefRangeStart = 130891, XrefRangeEnd = 130892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Hitbox(Transform transform, SpriteRenderer renderer)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hitbox>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hitbox.NativeMethodInfoPtr__ctor_Public_Void_Transform_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 130894, RefRangeEnd = 130897, XrefRangeStart = 130893, XrefRangeEnd = 130894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reset(Vector3 pivot, Vector2 sourcePosition, Vector3 overridePivot = default (Vector3))
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourcePosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &overridePivot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hitbox.NativeMethodInfoPtr_Reset_Public_Void_Vector3_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130899, RefRangeEnd = 130900, XrefRangeStart = 130897, XrefRangeEnd = 130899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 PositionForSlice(
    Vector3 slice,
    Vector2 sourcePosition,
    Sprite parentSprite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &slice;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourcePosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentSprite);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hitbox.NativeMethodInfoPtr_PositionForSlice_Public_Static_Vector3_Vector3_Vector2_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 130905, RefRangeEnd = 130906, XrefRangeStart = 130900, XrefRangeEnd = 130905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Reshape(Vector3 slice, Vector2 sourcePosition, Vector3 overridePivot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &slice;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourcePosition;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &overridePivot;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hitbox.NativeMethodInfoPtr_Reshape_Private_Void_Vector3_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float pixelPerUnit
  {
    get
    {
      float pixelPerUnit;
      IL2CPP.il2cpp_field_static_get_value(Hitbox.NativeFieldInfoPtr_pixelPerUnit, (void*) &pixelPerUnit);
      return pixelPerUnit;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Hitbox.NativeFieldInfoPtr_pixelPerUnit, (void*) &value);
    }
  }

  public unsafe Transform parentTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hitbox.NativeFieldInfoPtr_parentTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hitbox.NativeFieldInfoPtr_parentTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SpriteRenderer parentRenderer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hitbox.NativeFieldInfoPtr_parentRenderer));
      return num == System.IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hitbox.NativeFieldInfoPtr_parentRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 position
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hitbox.NativeFieldInfoPtr_position));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hitbox.NativeFieldInfoPtr_position)) = value;
    }
  }
}
