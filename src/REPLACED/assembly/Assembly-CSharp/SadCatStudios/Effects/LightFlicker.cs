// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.LightFlicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Rendering;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Effects;

public class LightFlicker(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_moveRadius;
  private static readonly IntPtr NativeFieldInfoPtr_moveSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_movementAxis;
  private static readonly IntPtr NativeFieldInfoPtr_minIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_maxIntensity;
  private static readonly IntPtr NativeFieldInfoPtr_flickerSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_lightData;
  private static readonly IntPtr NativeFieldInfoPtr_startPosition;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Flicker_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LightFlicker()
  {
    Il2CppClassPointerStore<LightFlicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (LightFlicker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr);
    LightFlicker.NativeFieldInfoPtr_moveRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, nameof (moveRadius));
    LightFlicker.NativeFieldInfoPtr_moveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, nameof (moveSpeed));
    LightFlicker.NativeFieldInfoPtr_movementAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, nameof (movementAxis));
    LightFlicker.NativeFieldInfoPtr_minIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, nameof (minIntensity));
    LightFlicker.NativeFieldInfoPtr_maxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, nameof (maxIntensity));
    LightFlicker.NativeFieldInfoPtr_flickerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, nameof (flickerSpeed));
    LightFlicker.NativeFieldInfoPtr_lightData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, nameof (lightData));
    LightFlicker.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, nameof (startPosition));
    LightFlicker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, 100675764);
    LightFlicker.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, 100675765);
    LightFlicker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, 100675766);
    LightFlicker.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, 100675767);
    LightFlicker.NativeMethodInfoPtr_Flicker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, 100675768);
    LightFlicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr, 100675769);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119357, XrefRangeEnd = 119360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightFlicker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119360, XrefRangeEnd = 119363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightFlicker.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119363, XrefRangeEnd = 119367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightFlicker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 119376, RefRangeEnd = 119377, XrefRangeStart = 119367, XrefRangeEnd = 119376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Move()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightFlicker.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119377, XrefRangeEnd = 119380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Flicker()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightFlicker.NativeMethodInfoPtr_Flicker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119380, XrefRangeEnd = 119381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightFlicker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightFlicker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightFlicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float moveRadius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_moveRadius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_moveRadius)) = value;
    }
  }

  public unsafe float moveSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_moveSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_moveSpeed)) = value;
    }
  }

  public unsafe Vector3 movementAxis
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_movementAxis));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_movementAxis)) = value;
    }
  }

  public unsafe float minIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_minIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_minIntensity)) = value;
    }
  }

  public unsafe float maxIntensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_maxIntensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_maxIntensity)) = value;
    }
  }

  public unsafe float flickerSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_flickerSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_flickerSpeed)) = value;
    }
  }

  public unsafe LightExtraData lightData
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_lightData));
      return num == IntPtr.Zero ? (LightExtraData) null : Il2CppObjectPool.Get<LightExtraData>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_lightData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 startPosition
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_startPosition));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightFlicker.NativeFieldInfoPtr_startPosition)) = value;
    }
  }
}
