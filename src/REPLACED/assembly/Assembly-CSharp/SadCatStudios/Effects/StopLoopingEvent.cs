// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.StopLoopingEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Effects;

[Serializable]
public class StopLoopingEvent(IntPtr pointer) : ImpactEvent(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_EventId;
  private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static StopLoopingEvent()
  {
    Il2CppClassPointerStore<StopLoopingEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (StopLoopingEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StopLoopingEvent>.NativeClassPtr);
    StopLoopingEvent.NativeFieldInfoPtr_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StopLoopingEvent>.NativeClassPtr, nameof (EventId));
    StopLoopingEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopingEvent>.NativeClassPtr, 100675687);
    StopLoopingEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StopLoopingEvent>.NativeClassPtr, 100675688);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118763, XrefRangeEnd = 118768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Handle(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StopLoopingEvent.NativeMethodInfoPtr_Handle_Public_Virtual_Void_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118768, XrefRangeEnd = 118771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StopLoopingEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StopLoopingEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StopLoopingEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string EventId
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StopLoopingEvent.NativeFieldInfoPtr_EventId)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StopLoopingEvent.NativeFieldInfoPtr_EventId), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
