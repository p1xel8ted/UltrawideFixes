// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetPacketQueueSizeOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

public class SetPacketQueueSizeOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SetPacketQueueSizeOptions()
  {
    Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (SetPacketQueueSizeOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr);
    SetPacketQueueSizeOptions.NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, "<IncomingPacketQueueMaxSizeBytes>k__BackingField");
    SetPacketQueueSizeOptions.NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, "<OutgoingPacketQueueMaxSizeBytes>k__BackingField");
    SetPacketQueueSizeOptions.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100668508);
    SetPacketQueueSizeOptions.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100668509);
    SetPacketQueueSizeOptions.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100668510);
    SetPacketQueueSizeOptions.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100668511);
    SetPacketQueueSizeOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr, 100668512);
  }

  public unsafe ulong IncomingPacketQueueMaxSizeBytes
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OutgoingPacketQueueMaxSizeBytes
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SetPacketQueueSizeOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPacketQueueSizeOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetPacketQueueSizeOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong _IncomingPacketQueueMaxSizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPacketQueueSizeOptions.NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPacketQueueSizeOptions.NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField)) = value;
    }
  }

  public unsafe ulong _OutgoingPacketQueueMaxSizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPacketQueueSizeOptions.NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPacketQueueSizeOptions.NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField)) = value;
    }
  }
}
