// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VisibleMaskDecal
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class VisibleMaskDecal : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sortingKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_maskDecal;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_MaskDecal_0;

  static VisibleMaskDecal()
  {
    Il2CppClassPointerStore<VisibleMaskDecal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VisibleMaskDecal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleMaskDecal>.NativeClassPtr);
    VisibleMaskDecal.NativeFieldInfoPtr_sortingKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleMaskDecal>.NativeClassPtr, nameof (sortingKey));
    VisibleMaskDecal.NativeFieldInfoPtr_maskDecal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleMaskDecal>.NativeClassPtr, nameof (maskDecal));
    VisibleMaskDecal.NativeMethodInfoPtr__ctor_Public_Void_MaskDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleMaskDecal>.NativeClassPtr, 100663705);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 927873, XrefRangeEnd = 927878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VisibleMaskDecal(MaskDecal maskDecal)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleMaskDecal>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) maskDecal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VisibleMaskDecal.NativeMethodInfoPtr__ctor_Public_Void_MaskDecal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public VisibleMaskDecal(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public VisibleMaskDecal()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleMaskDecal>.NativeClassPtr))
  {
  }

  public unsafe ulong sortingKey
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisibleMaskDecal.NativeFieldInfoPtr_sortingKey));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisibleMaskDecal.NativeFieldInfoPtr_sortingKey)) = value;
    }
  }

  public unsafe MaskDecal maskDecal
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisibleMaskDecal.NativeFieldInfoPtr_maskDecal));
      return num == System.IntPtr.Zero ? (MaskDecal) null : Il2CppObjectPool.Get<MaskDecal>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VisibleMaskDecal.NativeFieldInfoPtr_maskDecal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
