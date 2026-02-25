// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.UnregisterPeerOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient;

public class UnregisterPeerOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PeerHandle_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PeerHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UnregisterPeerOptions()
  {
    Il2CppClassPointerStore<UnregisterPeerOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatClient", nameof (UnregisterPeerOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnregisterPeerOptions>.NativeClassPtr);
    UnregisterPeerOptions.NativeFieldInfoPtr__PeerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnregisterPeerOptions>.NativeClassPtr, "<PeerHandle>k__BackingField");
    UnregisterPeerOptions.NativeMethodInfoPtr_get_PeerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPeerOptions>.NativeClassPtr, 100673181);
    UnregisterPeerOptions.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPeerOptions>.NativeClassPtr, 100673182);
    UnregisterPeerOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnregisterPeerOptions>.NativeClassPtr, 100673183);
  }

  public unsafe System.IntPtr PeerHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnregisterPeerOptions.NativeMethodInfoPtr_get_PeerHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnregisterPeerOptions.NativeMethodInfoPtr_set_PeerHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnregisterPeerOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnregisterPeerOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnregisterPeerOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _PeerHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnregisterPeerOptions.NativeFieldInfoPtr__PeerHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnregisterPeerOptions.NativeFieldInfoPtr__PeerHandle_k__BackingField)) = value;
    }
  }
}
