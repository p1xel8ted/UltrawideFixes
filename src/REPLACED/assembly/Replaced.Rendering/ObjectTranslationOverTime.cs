// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.ObjectTranslationOverTime
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public class ObjectTranslationOverTime(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_speed;
  private static readonly IntPtr NativeFieldInfoPtr_maxDistance;
  private static readonly IntPtr NativeFieldInfoPtr__origin;
  private static readonly IntPtr NativeFieldInfoPtr__sign;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ObjectTranslationOverTime()
  {
    Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (ObjectTranslationOverTime));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr);
    ObjectTranslationOverTime.NativeFieldInfoPtr_speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr, nameof (speed));
    ObjectTranslationOverTime.NativeFieldInfoPtr_maxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr, nameof (maxDistance));
    ObjectTranslationOverTime.NativeFieldInfoPtr__origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr, nameof (_origin));
    ObjectTranslationOverTime.NativeFieldInfoPtr__sign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr, nameof (_sign));
    ObjectTranslationOverTime.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr, 100663571);
    ObjectTranslationOverTime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr, 100663572);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926291, XrefRangeEnd = 926303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectTranslationOverTime.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926303, XrefRangeEnd = 926304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ObjectTranslationOverTime()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectTranslationOverTime>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectTranslationOverTime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float speed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTranslationOverTime.NativeFieldInfoPtr_speed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTranslationOverTime.NativeFieldInfoPtr_speed)) = value;
    }
  }

  public unsafe float maxDistance
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTranslationOverTime.NativeFieldInfoPtr_maxDistance));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTranslationOverTime.NativeFieldInfoPtr_maxDistance)) = value;
    }
  }

  public unsafe Vector3 _origin
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTranslationOverTime.NativeFieldInfoPtr__origin));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTranslationOverTime.NativeFieldInfoPtr__origin)) = value;
    }
  }

  public unsafe float _sign
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTranslationOverTime.NativeFieldInfoPtr__sign));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectTranslationOverTime.NativeFieldInfoPtr__sign)) = value;
    }
  }
}
