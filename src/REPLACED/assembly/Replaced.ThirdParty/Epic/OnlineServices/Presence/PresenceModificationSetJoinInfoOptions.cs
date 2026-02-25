// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModificationSetJoinInfoOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence;

public class PresenceModificationSetJoinInfoOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__JoinInfo_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_JoinInfo_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PresenceModificationSetJoinInfoOptions()
  {
    Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (PresenceModificationSetJoinInfoOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptions>.NativeClassPtr);
    PresenceModificationSetJoinInfoOptions.NativeFieldInfoPtr__JoinInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptions>.NativeClassPtr, "<JoinInfo>k__BackingField");
    PresenceModificationSetJoinInfoOptions.NativeMethodInfoPtr_get_JoinInfo_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptions>.NativeClassPtr, 100667436);
    PresenceModificationSetJoinInfoOptions.NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptions>.NativeClassPtr, 100667437);
    PresenceModificationSetJoinInfoOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptions>.NativeClassPtr, 100667438);
  }

  public unsafe string JoinInfo
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptions.NativeMethodInfoPtr_get_JoinInfo_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptions.NativeMethodInfoPtr_set_JoinInfo_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresenceModificationSetJoinInfoOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresenceModificationSetJoinInfoOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetJoinInfoOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _JoinInfo_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresenceModificationSetJoinInfoOptions.NativeFieldInfoPtr__JoinInfo_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PresenceModificationSetJoinInfoOptions.NativeFieldInfoPtr__JoinInfo_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
