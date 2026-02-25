// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.FilmGrainParams
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

public sealed class FilmGrainParams : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_on;
  private static readonly System.IntPtr NativeFieldInfoPtr_texGrain;
  private static readonly System.IntPtr NativeFieldInfoPtr_intensity;
  private static readonly System.IntPtr NativeFieldInfoPtr_darkAreaRangeStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_darkAreaRangeEnd;
  private static readonly System.IntPtr NativeFieldInfoPtr_brightAreaRangeStart;
  private static readonly System.IntPtr NativeFieldInfoPtr_brightAreaRangeEnd;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Texture_Single_Single_Single_Single_Single_0;

  static FilmGrainParams()
  {
    Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (FilmGrainParams));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr);
    FilmGrainParams.NativeFieldInfoPtr_on = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, nameof (on));
    FilmGrainParams.NativeFieldInfoPtr_texGrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, nameof (texGrain));
    FilmGrainParams.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, nameof (intensity));
    FilmGrainParams.NativeFieldInfoPtr_darkAreaRangeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, nameof (darkAreaRangeStart));
    FilmGrainParams.NativeFieldInfoPtr_darkAreaRangeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, nameof (darkAreaRangeEnd));
    FilmGrainParams.NativeFieldInfoPtr_brightAreaRangeStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, nameof (brightAreaRangeStart));
    FilmGrainParams.NativeFieldInfoPtr_brightAreaRangeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, nameof (brightAreaRangeEnd));
    FilmGrainParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Texture_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr, 100663642);
  }

  [CallerCount(0)]
  public unsafe FilmGrainParams(
    bool on,
    Texture texGrain,
    float intensity,
    float darkAreaRangeStart,
    float darkAreaRangeEnd,
    float brightAreaRangeStart,
    float brightAreaRangeEnd)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &on;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texGrain);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &intensity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &darkAreaRangeStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &darkAreaRangeEnd;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &brightAreaRangeStart;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &brightAreaRangeEnd;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FilmGrainParams.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Texture_Single_Single_Single_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public FilmGrainParams(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public FilmGrainParams()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilmGrainParams>.NativeClassPtr))
  {
  }

  public unsafe bool on
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_on));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_on)) = value;
    }
  }

  public unsafe Texture texGrain
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_texGrain));
      return num == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_texGrain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float intensity
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_intensity));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_intensity)) = value;
    }
  }

  public unsafe float darkAreaRangeStart
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_darkAreaRangeStart));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_darkAreaRangeStart)) = value;
    }
  }

  public unsafe float darkAreaRangeEnd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_darkAreaRangeEnd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_darkAreaRangeEnd)) = value;
    }
  }

  public unsafe float brightAreaRangeStart
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_brightAreaRangeStart));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_brightAreaRangeStart)) = value;
    }
  }

  public unsafe float brightAreaRangeEnd
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_brightAreaRangeEnd));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FilmGrainParams.NativeFieldInfoPtr_brightAreaRangeEnd)) = value;
    }
  }
}
