// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.ItemOwnershipInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

[StructLayout(LayoutKind.Explicit)]
public struct ItemOwnershipInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OwnershipStatus;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ItemOwnership_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Id;
  [FieldOffset(16 /*0x10*/)]
  public OwnershipStatus m_OwnershipStatus;

  static ItemOwnershipInternal()
  {
    Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (ItemOwnershipInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr);
    ItemOwnershipInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ItemOwnershipInternal.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, nameof (m_Id));
    ItemOwnershipInternal.NativeFieldInfoPtr_m_OwnershipStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, nameof (m_OwnershipStatus));
    ItemOwnershipInternal.NativeMethodInfoPtr_get_Id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100671065);
    ItemOwnershipInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100671066);
    ItemOwnershipInternal.NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100671067);
    ItemOwnershipInternal.NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100671068);
    ItemOwnershipInternal.NativeMethodInfoPtr_Set_Public_Void_ItemOwnership_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100671069);
    ItemOwnershipInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100671070);
    ItemOwnershipInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100671071);
  }

  public unsafe string Id
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395313, XrefRangeEnd = 395317, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_get_Id_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395317, XrefRangeEnd = 395321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe OwnershipStatus OwnershipStatus
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(OwnershipStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395321, XrefRangeEnd = 395325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ItemOwnership other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_Set_Public_Void_ItemOwnership_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395325, XrefRangeEnd = 395331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395331, XrefRangeEnd = 395335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
