// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.OnRemoteConnectionClosedInfo
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

public class OnRemoteConnectionClosedInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RemoteUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SocketId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Reason_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoteUserId_Private_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketId_Private_set_Void_SocketId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Reason_Public_get_ConnectionClosedReason_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Reason_Private_set_Void_ConnectionClosedReason_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnRemoteConnectionClosedInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OnRemoteConnectionClosedInfo()
  {
    Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (OnRemoteConnectionClosedInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr);
    OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, "<ClientData>k__BackingField");
    OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, "<LocalUserId>k__BackingField");
    OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__RemoteUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, "<RemoteUserId>k__BackingField");
    OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__SocketId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, "<SocketId>k__BackingField");
    OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__Reason_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, "<Reason>k__BackingField");
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668386);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668387);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668388);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668389);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668390);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_RemoteUserId_Private_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668391);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668392);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_SocketId_Private_set_Void_SocketId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668393);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_Reason_Public_get_ConnectionClosedReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668394);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_Reason_Private_set_Void_ConnectionClosedReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668395);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668396);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnRemoteConnectionClosedInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668397);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668398);
    OnRemoteConnectionClosedInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr, 100668399);
  }

  public virtual unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_LocalUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_LocalUserId_Private_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId RemoteUserId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_RemoteUserId_Public_get_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_RemoteUserId_Private_set_Void_ProductUserId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SocketId SocketId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_SocketId_Public_get_SocketId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (SocketId) null : Il2CppObjectPool.Get<SocketId>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_SocketId_Private_set_Void_SocketId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ConnectionClosedReason Reason
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_get_Reason_Public_get_ConnectionClosedReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ConnectionClosedReason*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_set_Reason_Private_set_Void_ConnectionClosedReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<Result>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386706, XrefRangeEnd = 386740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<OnRemoteConnectionClosedInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnRemoteConnectionClosedInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386740, XrefRangeEnd = 386778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnRemoteConnectionClosedInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnRemoteConnectionClosedInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnRemoteConnectionClosedInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Object _ClientData_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProductUserId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ProductUserId _RemoteUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__RemoteUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__RemoteUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SocketId _SocketId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__SocketId_k__BackingField));
      return num == System.IntPtr.Zero ? (SocketId) null : Il2CppObjectPool.Get<SocketId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__SocketId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ConnectionClosedReason _Reason_k__BackingField
  {
    get
    {
      return *(ConnectionClosedReason*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__Reason_k__BackingField));
    }
    [param: In] set
    {
      *(ConnectionClosedReason*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnRemoteConnectionClosedInfo.NativeFieldInfoPtr__Reason_k__BackingField)) = value;
    }
  }
}
