// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.OnIncomingPacketQueueFullInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

public class OnIncomingPacketQueueFullInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PacketQueueMaxSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PacketQueueCurrentSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OverflowPacketLocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OverflowPacketChannel_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OverflowPacketSizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Private_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Private_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Private_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketChannel_Private_set_Void_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Private_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnIncomingPacketQueueFullInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OnIncomingPacketQueueFullInfo()
  {
    Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (OnIncomingPacketQueueFullInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr);
    OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<ClientData>k__BackingField");
    OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueMaxSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<PacketQueueMaxSizeBytes>k__BackingField");
    OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueCurrentSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<PacketQueueCurrentSizeBytes>k__BackingField");
    OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketLocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<OverflowPacketLocalUserId>k__BackingField");
    OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketChannel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<OverflowPacketChannel>k__BackingField");
    OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketSizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, "<OverflowPacketSizeBytes>k__BackingField");
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668305);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668306);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668307);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668308);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668309);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668310);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668311);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Private_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668312);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668313);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketChannel_Private_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668314);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668315);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Private_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668316);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668317);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnIncomingPacketQueueFullInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668318);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668319);
    OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr, 100668320);
  }

  public virtual unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong PacketQueueMaxSizeBytes
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_PacketQueueMaxSizeBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_PacketQueueMaxSizeBytes_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong PacketQueueCurrentSizeBytes
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_PacketQueueCurrentSizeBytes_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_PacketQueueCurrentSizeBytes_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId OverflowPacketLocalUserId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketLocalUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketLocalUserId_Private_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe byte OverflowPacketChannel
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80472, XrefRangeStart = 80471, XrefRangeEnd = 80472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketChannel_Public_get_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(byte*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketChannel_Private_set_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint OverflowPacketSizeBytes
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16660, RefRangeEnd = 16661, XrefRangeStart = 16660, XrefRangeEnd = 16661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_get_OverflowPacketSizeBytes_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_set_OverflowPacketSizeBytes_Private_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Nullable<Result> GetResultCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<Result>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386515, XrefRangeEnd = 386539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<OnIncomingPacketQueueFullInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnIncomingPacketQueueFullInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386539, XrefRangeEnd = 386567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnIncomingPacketQueueFullInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnIncomingPacketQueueFullInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnIncomingPacketQueueFullInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Object _ClientData_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ulong _PacketQueueMaxSizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueMaxSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueMaxSizeBytes_k__BackingField)) = value;
    }
  }

  public unsafe ulong _PacketQueueCurrentSizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueCurrentSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__PacketQueueCurrentSizeBytes_k__BackingField)) = value;
    }
  }

  public unsafe ProductUserId _OverflowPacketLocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketLocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketLocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe byte _OverflowPacketChannel_k__BackingField
  {
    get
    {
      return *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketChannel_k__BackingField));
    }
    [param: In] set
    {
      *(byte*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketChannel_k__BackingField)) = value;
    }
  }

  public unsafe uint _OverflowPacketSizeBytes_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketSizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnIncomingPacketQueueFullInfo.NativeFieldInfoPtr__OverflowPacketSizeBytes_k__BackingField)) = value;
    }
  }
}
