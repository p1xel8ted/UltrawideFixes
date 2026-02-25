// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModificationSetStatusOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence;

public class PresenceModificationSetStatusOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Status_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_Status_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PresenceModificationSetStatusOptions()
  {
    Il2CppClassPointerStore<PresenceModificationSetStatusOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (PresenceModificationSetStatusOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModificationSetStatusOptions>.NativeClassPtr);
    PresenceModificationSetStatusOptions.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetStatusOptions>.NativeClassPtr, "<Status>k__BackingField");
    PresenceModificationSetStatusOptions.NativeMethodInfoPtr_get_Status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetStatusOptions>.NativeClassPtr, 100667450);
    PresenceModificationSetStatusOptions.NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetStatusOptions>.NativeClassPtr, 100667451);
    PresenceModificationSetStatusOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetStatusOptions>.NativeClassPtr, 100667452);
  }

  public unsafe Status Status
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetStatusOptions.NativeMethodInfoPtr_get_Status_Public_get_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Status*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetStatusOptions.NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresenceModificationSetStatusOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresenceModificationSetStatusOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetStatusOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Status _Status_k__BackingField
  {
    get
    {
      return *(Status*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresenceModificationSetStatusOptions.NativeFieldInfoPtr__Status_k__BackingField));
    }
    [param: In] set
    {
      *(Status*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresenceModificationSetStatusOptions.NativeFieldInfoPtr__Status_k__BackingField)) = value;
    }
  }
}
