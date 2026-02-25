// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.ImpactVibrationEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Configs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Effects;

[Serializable]
public class ImpactVibrationEvent(IntPtr pointer) : ImpactEvent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_VibrationConfig;
  private static readonly IntPtr NativeFieldInfoPtr_InverseVibrationConfig;
  private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ImpactVibrationEvent()
  {
    Il2CppClassPointerStore<ImpactVibrationEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (ImpactVibrationEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactVibrationEvent>.NativeClassPtr);
    ImpactVibrationEvent.NativeFieldInfoPtr_VibrationConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactVibrationEvent>.NativeClassPtr, nameof (VibrationConfig));
    ImpactVibrationEvent.NativeFieldInfoPtr_InverseVibrationConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactVibrationEvent>.NativeClassPtr, nameof (InverseVibrationConfig));
    ImpactVibrationEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactVibrationEvent>.NativeClassPtr, 100675691);
    ImpactVibrationEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactVibrationEvent>.NativeClassPtr, 100675692);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118790, XrefRangeEnd = 118802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Handle(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ImpactVibrationEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ImpactVibrationEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactVibrationEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ImpactVibrationEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe JoystickVibrationConfig VibrationConfig
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactVibrationEvent.NativeFieldInfoPtr_VibrationConfig));
      return num == IntPtr.Zero ? (JoystickVibrationConfig) null : Il2CppObjectPool.Get<JoystickVibrationConfig>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactVibrationEvent.NativeFieldInfoPtr_VibrationConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe JoystickVibrationConfig InverseVibrationConfig
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ImpactVibrationEvent.NativeFieldInfoPtr_InverseVibrationConfig));
      return num == IntPtr.Zero ? (JoystickVibrationConfig) null : Il2CppObjectPool.Get<JoystickVibrationConfig>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ImpactVibrationEvent.NativeFieldInfoPtr_InverseVibrationConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
