// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.CelestialBodyParams
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class CelestialBodyParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_texBaseColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_tint;
  private static readonly System.IntPtr NativeFieldInfoPtr_sizeWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_horizontalOffsetWs;
  private static readonly System.IntPtr NativeFieldInfoPtr_verticalOffsetWs;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Vector3_Single_Single_Single_0;

  static CelestialBodyParams()
  {
    Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (CelestialBodyParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr);
    CelestialBodyParams.NativeFieldInfoPtr_texBaseColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr, nameof (texBaseColor));
    CelestialBodyParams.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr, nameof (tint));
    CelestialBodyParams.NativeFieldInfoPtr_sizeWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr, nameof (sizeWs));
    CelestialBodyParams.NativeFieldInfoPtr_horizontalOffsetWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr, nameof (horizontalOffsetWs));
    CelestialBodyParams.NativeFieldInfoPtr_verticalOffsetWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr, nameof (verticalOffsetWs));
    CelestialBodyParams.NativeMethodInfoPtr__ctor_Public_Void_Texture_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr, 100663604);
  }

  [CallerCount(0)]
  public unsafe CelestialBodyParams(
    Texture texBaseColor,
    Vector3 tint,
    float sizeWs,
    float horizontalOffsetWs,
    float verticalOffsetWs)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texBaseColor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tint;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &sizeWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &horizontalOffsetWs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &verticalOffsetWs;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CelestialBodyParams.NativeMethodInfoPtr__ctor_Public_Void_Texture_Vector3_Single_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public CelestialBodyParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public CelestialBodyParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CelestialBodyParams>.NativeClassPtr))
  {
  }

  public unsafe Texture texBaseColor
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_texBaseColor));
      return num == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_texBaseColor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 tint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_tint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_tint)) = value;
    }
  }

  public unsafe float sizeWs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_sizeWs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_sizeWs)) = value;
    }
  }

  public unsafe float horizontalOffsetWs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_horizontalOffsetWs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_horizontalOffsetWs)) = value;
    }
  }

  public unsafe float verticalOffsetWs
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_verticalOffsetWs));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CelestialBodyParams.NativeFieldInfoPtr_verticalOffsetWs)) = value;
    }
  }
}
