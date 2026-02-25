// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.PacketQueueInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

public class PacketQueueInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IncomingPacketQueueCurrentSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IncomingPacketQueueCurrentPacketCount_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OutgoingPacketQueueCurrentSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OutgoingPacketQueueCurrentPacketCount_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PacketQueueInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PacketQueueInfo()
  {
    Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (PacketQueueInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr);
    PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<IncomingPacketQueueMaxSizeBytes>k__BackingField");
    PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueCurrentSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<IncomingPacketQueueCurrentSizeBytes>k__BackingField");
    PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueCurrentPacketCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<IncomingPacketQueueCurrentPacketCount>k__BackingField");
    PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<OutgoingPacketQueueMaxSizeBytes>k__BackingField");
    PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueCurrentSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<OutgoingPacketQueueCurrentSizeBytes>k__BackingField");
    PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueCurrentPacketCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, "<OutgoingPacketQueueCurrentPacketCount>k__BackingField");
    PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668436);
    PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668437);
    PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668438);
    PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668439);
    PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668440);
    PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668441);
    PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668442);
    PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668443);
    PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668444);
    PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668445);
    PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668446);
    PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668447);
    PacketQueueInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PacketQueueInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668448);
    PacketQueueInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668449);
    PacketQueueInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr, 100668450);
  }

  public unsafe ulong IncomingPacketQueueMaxSizeBytes
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueMaxSizeBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong IncomingPacketQueueCurrentSizeBytes
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentSizeBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong IncomingPacketQueueCurrentPacketCount
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_IncomingPacketQueueCurrentPacketCount_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_IncomingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OutgoingPacketQueueMaxSizeBytes
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueMaxSizeBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueMaxSizeBytes_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OutgoingPacketQueueCurrentSizeBytes
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentSizeBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentSizeBytes_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OutgoingPacketQueueCurrentPacketCount
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_get_OutgoingPacketQueueCurrentPacketCount_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_set_OutgoingPacketQueueCurrentPacketCount_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387098, XrefRangeEnd = 387112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<PacketQueueInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PacketQueueInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387112, XrefRangeEnd = 387130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PacketQueueInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PacketQueueInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PacketQueueInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong _IncomingPacketQueueMaxSizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueMaxSizeBytes_k__BackingField)) = value;
    }
  }

  public unsafe ulong _IncomingPacketQueueCurrentSizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueCurrentSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueCurrentSizeBytes_k__BackingField)) = value;
    }
  }

  public unsafe ulong _IncomingPacketQueueCurrentPacketCount_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueCurrentPacketCount_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__IncomingPacketQueueCurrentPacketCount_k__BackingField)) = value;
    }
  }

  public unsafe ulong _OutgoingPacketQueueMaxSizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueMaxSizeBytes_k__BackingField)) = value;
    }
  }

  public unsafe ulong _OutgoingPacketQueueCurrentSizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueCurrentSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueCurrentSizeBytes_k__BackingField)) = value;
    }
  }

  public unsafe ulong _OutgoingPacketQueueCurrentPacketCount_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueCurrentPacketCount_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PacketQueueInfo.NativeFieldInfoPtr__OutgoingPacketQueueCurrentPacketCount_k__BackingField)) = value;
    }
  }
}
