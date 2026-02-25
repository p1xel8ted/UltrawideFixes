// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.VisibleDecal
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

public sealed class VisibleDecal : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_sortingKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_decal;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Decal_0;

  static VisibleDecal()
  {
    Il2CppClassPointerStore<VisibleDecal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (VisibleDecal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibleDecal>.NativeClassPtr);
    VisibleDecal.NativeFieldInfoPtr_sortingKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleDecal>.NativeClassPtr, nameof (sortingKey));
    VisibleDecal.NativeFieldInfoPtr_decal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibleDecal>.NativeClassPtr, nameof (decal));
    VisibleDecal.NativeMethodInfoPtr__ctor_Public_Void_Decal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibleDecal>.NativeClassPtr, 100663706);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 927885, RefRangeEnd = 927886, XrefRangeStart = 927878, XrefRangeEnd = 927885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VisibleDecal(Decal decal)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleDecal>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) decal)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VisibleDecal.NativeMethodInfoPtr__ctor_Public_Void_Decal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public VisibleDecal(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public VisibleDecal()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibleDecal>.NativeClassPtr))
  {
  }

  public unsafe ulong sortingKey
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisibleDecal.NativeFieldInfoPtr_sortingKey));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisibleDecal.NativeFieldInfoPtr_sortingKey)) = value;
    }
  }

  public unsafe Decal decal
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VisibleDecal.NativeFieldInfoPtr_decal));
      return num == System.IntPtr.Zero ? (Decal) null : Il2CppObjectPool.Get<Decal>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VisibleDecal.NativeFieldInfoPtr_decal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
