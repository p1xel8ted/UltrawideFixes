// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.LoopingEvent
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
public class LoopingEvent(IntPtr pointer) : ImpactEvent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_EventId;
  private static readonly IntPtr NativeFieldInfoPtr_SoundEventReference;
  private static readonly IntPtr NativeFieldInfoPtr_VfxSurfaceCollection;
  private static readonly IntPtr NativeFieldInfoPtr_Detach;
  private static readonly IntPtr NativeFieldInfoPtr_DetachedLifetime;
  private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LoopingEvent()
  {
    Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (LoopingEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr);
    LoopingEvent.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr, nameof (EventId));
    LoopingEvent.NativeFieldInfoPtr_SoundEventReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr, nameof (SoundEventReference));
    LoopingEvent.NativeFieldInfoPtr_VfxSurfaceCollection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr, nameof (VfxSurfaceCollection));
    LoopingEvent.NativeFieldInfoPtr_Detach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr, nameof (Detach));
    LoopingEvent.NativeFieldInfoPtr_DetachedLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr, nameof (DetachedLifetime));
    LoopingEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr, 100675685);
    LoopingEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr, 100675686);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118755, XrefRangeEnd = 118760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Handle(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LoopingEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118760, XrefRangeEnd = 118763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LoopingEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoopingEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LoopingEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string EventId
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_EventId)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_EventId), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe EventReference SoundEventReference
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_SoundEventReference));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_SoundEventReference)) = value;
    }
  }

  public unsafe VFXSurfaceCollection VfxSurfaceCollection
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_VfxSurfaceCollection));
      return num == IntPtr.Zero ? (VFXSurfaceCollection) null : Il2CppObjectPool.Get<VFXSurfaceCollection>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_VfxSurfaceCollection), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool Detach
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_Detach));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_Detach)) = value;
    }
  }

  public unsafe float DetachedLifetime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_DetachedLifetime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LoopingEvent.NativeFieldInfoPtr_DetachedLifetime)) = value;
    }
  }
}
