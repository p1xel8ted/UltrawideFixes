// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.TransferDeviceIdAccountOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

[StructLayout(LayoutKind.Explicit)]
public struct TransferDeviceIdAccountOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PrimaryLocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalDeviceUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserIdToPreserve;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_TransferDeviceIdAccountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_PrimaryLocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalDeviceUserId;
  [FieldOffset(24)]
  public System.IntPtr m_ProductUserIdToPreserve;

  static TransferDeviceIdAccountOptionsInternal()
  {
    Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (TransferDeviceIdAccountOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr);
    TransferDeviceIdAccountOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    TransferDeviceIdAccountOptionsInternal.NativeFieldInfoPtr_m_PrimaryLocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, nameof (m_PrimaryLocalUserId));
    TransferDeviceIdAccountOptionsInternal.NativeFieldInfoPtr_m_LocalDeviceUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, nameof (m_LocalDeviceUserId));
    TransferDeviceIdAccountOptionsInternal.NativeFieldInfoPtr_m_ProductUserIdToPreserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, nameof (m_ProductUserIdToPreserve));
    TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100671913);
    TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100671914);
    TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100671915);
    TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_TransferDeviceIdAccountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100671916);
    TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100671917);
    TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100671918);
  }

  public unsafe ProductUserId PrimaryLocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397763, XrefRangeEnd = 397767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalDeviceUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397767, XrefRangeEnd = 397771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId ProductUserIdToPreserve
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397771, XrefRangeEnd = 397775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 397787, RefRangeEnd = 397788, XrefRangeStart = 397775, XrefRangeEnd = 397787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(TransferDeviceIdAccountOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_TransferDeviceIdAccountOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397788, XrefRangeEnd = 397791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397791, XrefRangeEnd = 397797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
