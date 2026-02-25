// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.DecalCullingResult
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class DecalCullingResult : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleMaskDecals;
  private static readonly System.IntPtr NativeFieldInfoPtr_visibleDecals;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_VisibleMaskDecal_IReadOnlyList_1_VisibleDecal_0;

  static DecalCullingResult()
  {
    Il2CppClassPointerStore<DecalCullingResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (DecalCullingResult));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecalCullingResult>.NativeClassPtr);
    DecalCullingResult.NativeFieldInfoPtr_visibleMaskDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCullingResult>.NativeClassPtr, nameof (visibleMaskDecals));
    DecalCullingResult.NativeFieldInfoPtr_visibleDecals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecalCullingResult>.NativeClassPtr, nameof (visibleDecals));
    DecalCullingResult.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_VisibleMaskDecal_IReadOnlyList_1_VisibleDecal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecalCullingResult>.NativeClassPtr, 100663704);
  }

  [CallerCount(116)]
  [CachedScanResults(RefRangeStart = 261036, RefRangeEnd = 261152, XrefRangeStart = 261036, XrefRangeEnd = 261152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DecalCullingResult(
    IReadOnlyList<VisibleMaskDecal> visibleMaskDecals,
    IReadOnlyList<VisibleDecal> visibleDecals)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalCullingResult>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) visibleMaskDecals);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) visibleDecals);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DecalCullingResult.NativeMethodInfoPtr__ctor_Public_Void_IReadOnlyList_1_VisibleMaskDecal_IReadOnlyList_1_VisibleDecal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public DecalCullingResult(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public DecalCullingResult()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecalCullingResult>.NativeClassPtr))
  {
  }

  public unsafe IReadOnlyList<VisibleMaskDecal> visibleMaskDecals
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalCullingResult.NativeFieldInfoPtr_visibleMaskDecals));
      return num == System.IntPtr.Zero ? (IReadOnlyList<VisibleMaskDecal>) null : Il2CppObjectPool.Get<IReadOnlyList<VisibleMaskDecal>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalCullingResult.NativeFieldInfoPtr_visibleMaskDecals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IReadOnlyList<VisibleDecal> visibleDecals
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DecalCullingResult.NativeFieldInfoPtr_visibleDecals));
      return num == System.IntPtr.Zero ? (IReadOnlyList<VisibleDecal>) null : Il2CppObjectPool.Get<IReadOnlyList<VisibleDecal>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DecalCullingResult.NativeFieldInfoPtr_visibleDecals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
