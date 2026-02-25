// Decompiled with JetBrains decompiler
// Type: FinalDestructableBunker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Tilemaps;

#nullable disable
public class FinalDestructableBunker(IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_collisionSound;
  private static readonly IntPtr NativeFieldInfoPtr_tilemap;
  private static readonly IntPtr NativeFieldInfoPtr_bounds;
  private static readonly IntPtr NativeFieldInfoPtr_allTiles;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Respawn_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCollisionStay2D_Private_Void_Collision2D_0;
  private static readonly IntPtr NativeMethodInfoPtr_PatternDestruction_Private_Void_Vector2_Il2CppObjectBase_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FinalDestructableBunker()
  {
    Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (FinalDestructableBunker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr);
    FinalDestructableBunker.NativeFieldInfoPtr_collisionSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, nameof (collisionSound));
    FinalDestructableBunker.NativeFieldInfoPtr_tilemap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, nameof (tilemap));
    FinalDestructableBunker.NativeFieldInfoPtr_bounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, nameof (bounds));
    FinalDestructableBunker.NativeFieldInfoPtr_allTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, nameof (allTiles));
    FinalDestructableBunker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, 100663391 /*0x0600005F*/);
    FinalDestructableBunker.NativeMethodInfoPtr_Respawn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, 100663392 /*0x06000060*/);
    FinalDestructableBunker.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, 100663393 /*0x06000061*/);
    FinalDestructableBunker.NativeMethodInfoPtr_OnCollisionStay2D_Private_Void_Collision2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, 100663394 /*0x06000062*/);
    FinalDestructableBunker.NativeMethodInfoPtr_PatternDestruction_Private_Void_Vector2_Il2CppObjectBase_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, 100663395 /*0x06000063*/);
    FinalDestructableBunker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, 100663396 /*0x06000064*/);
    FinalDestructableBunker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr, 100663397 /*0x06000065*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16244, XrefRangeEnd = 16249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalDestructableBunker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16249, XrefRangeEnd = 16260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Respawn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalDestructableBunker.NativeMethodInfoPtr_Respawn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16260, XrefRangeEnd = 16280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionEnter2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalDestructableBunker.NativeMethodInfoPtr_OnCollisionEnter2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16280, XrefRangeEnd = 16285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnCollisionStay2D(Collision2D other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalDestructableBunker.NativeMethodInfoPtr_OnCollisionStay2D_Private_Void_Collision2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 16293, RefRangeEnd = 16295, XrefRangeStart = 16285, XrefRangeEnd = 16293, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PatternDestruction(
    Vector2 point,
    Il2CppObjectBase destructionPattern,
    Vector2 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &point;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr(destructionPattern);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &offset;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalDestructableBunker.NativeMethodInfoPtr_PatternDestruction_Private_Void_Vector2_Il2CppObjectBase_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16295, XrefRangeEnd = 16300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalDestructableBunker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 16301, RefRangeEnd = 16305, XrefRangeStart = 16300, XrefRangeEnd = 16301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FinalDestructableBunker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinalDestructableBunker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalDestructableBunker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference collisionSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalDestructableBunker.NativeFieldInfoPtr_collisionSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalDestructableBunker.NativeFieldInfoPtr_collisionSound)) = value;
    }
  }

  public unsafe Tilemap tilemap
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalDestructableBunker.NativeFieldInfoPtr_tilemap));
      return num == IntPtr.Zero ? (Tilemap) null : Il2CppObjectPool.Get<Tilemap>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalDestructableBunker.NativeFieldInfoPtr_tilemap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BoundsInt bounds
  {
    get
    {
      return *(BoundsInt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalDestructableBunker.NativeFieldInfoPtr_bounds));
    }
    [param: In] set
    {
      *(BoundsInt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalDestructableBunker.NativeFieldInfoPtr_bounds)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<TileBase> allTiles
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FinalDestructableBunker.NativeFieldInfoPtr_allTiles));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<TileBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<TileBase>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FinalDestructableBunker.NativeFieldInfoPtr_allTiles), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
