// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.ImpactShakeEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.CameraMovement;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Effects;

[Serializable]
public class ImpactShakeEvent(IntPtr pointer) : ImpactEvent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ShakeOptions;
  private static readonly IntPtr NativeFieldInfoPtr_InverseShakeOptions;
  private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ImpactShakeEvent()
  {
    Il2CppClassPointerStore<ImpactShakeEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (ImpactShakeEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactShakeEvent>.NativeClassPtr);
    ImpactShakeEvent.NativeFieldInfoPtr_ShakeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactShakeEvent>.NativeClassPtr, nameof (ShakeOptions));
    ImpactShakeEvent.NativeFieldInfoPtr_InverseShakeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactShakeEvent>.NativeClassPtr, nameof (InverseShakeOptions));
    ImpactShakeEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactShakeEvent>.NativeClassPtr, 100675689);
    ImpactShakeEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactShakeEvent>.NativeClassPtr, 100675690);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118771, XrefRangeEnd = 118790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Handle(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ImpactShakeEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImpactShakeEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactShakeEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactShakeEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CameraShakeOptions ShakeOptions
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactShakeEvent.NativeFieldInfoPtr_ShakeOptions));
      return num == IntPtr.Zero ? (CameraShakeOptions) null : Il2CppObjectPool.Get<CameraShakeOptions>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactShakeEvent.NativeFieldInfoPtr_ShakeOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CameraShakeOptions InverseShakeOptions
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactShakeEvent.NativeFieldInfoPtr_InverseShakeOptions));
      return num == IntPtr.Zero ? (CameraShakeOptions) null : Il2CppObjectPool.Get<CameraShakeOptions>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactShakeEvent.NativeFieldInfoPtr_InverseShakeOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
