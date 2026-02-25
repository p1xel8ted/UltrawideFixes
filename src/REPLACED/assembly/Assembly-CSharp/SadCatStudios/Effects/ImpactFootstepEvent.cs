// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.ImpactFootstepEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Effects;

[Serializable]
public class ImpactFootstepEvent(IntPtr pointer) : ImpactEvent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_SoundEventReference;
  private static readonly IntPtr NativeFieldInfoPtr_vfxSurfaceCollection;
  private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ImpactFootstepEvent()
  {
    Il2CppClassPointerStore<ImpactFootstepEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (ImpactFootstepEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactFootstepEvent>.NativeClassPtr);
    ImpactFootstepEvent.NativeFieldInfoPtr_SoundEventReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepEvent>.NativeClassPtr, nameof (SoundEventReference));
    ImpactFootstepEvent.NativeFieldInfoPtr_vfxSurfaceCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactFootstepEvent>.NativeClassPtr, nameof (vfxSurfaceCollection));
    ImpactFootstepEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepEvent>.NativeClassPtr, 100675679);
    ImpactFootstepEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactFootstepEvent>.NativeClassPtr, 100675680 /*0x06003060*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118701, XrefRangeEnd = 118732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Handle(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ImpactFootstepEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImpactFootstepEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactFootstepEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactFootstepEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference SoundEventReference
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepEvent.NativeFieldInfoPtr_SoundEventReference));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepEvent.NativeFieldInfoPtr_SoundEventReference)) = value;
    }
  }

  public unsafe VFXSurfaceCollection vfxSurfaceCollection
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepEvent.NativeFieldInfoPtr_vfxSurfaceCollection));
      return num == IntPtr.Zero ? (VFXSurfaceCollection) null : Il2CppObjectPool.Get<VFXSurfaceCollection>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactFootstepEvent.NativeFieldInfoPtr_vfxSurfaceCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
