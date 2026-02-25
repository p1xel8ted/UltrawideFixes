// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sanctions.PlayerSanctionInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sanctions;

[StructLayout(LayoutKind.Explicit)]
public struct PlayerSanctionInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TimePlaced;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Action;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeExpires;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReferenceId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Action_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Action_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReferenceId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PlayerSanction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public long m_TimePlaced;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Action;
  [FieldOffset(24)]
  public long m_TimeExpires;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ReferenceId;

  static PlayerSanctionInternal()
  {
    Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sanctions", nameof (PlayerSanctionInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr);
    PlayerSanctionInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_ApiVersion));
    PlayerSanctionInternal.NativeFieldInfoPtr_m_TimePlaced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_TimePlaced));
    PlayerSanctionInternal.NativeFieldInfoPtr_m_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_Action));
    PlayerSanctionInternal.NativeFieldInfoPtr_m_TimeExpires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_TimeExpires));
    PlayerSanctionInternal.NativeFieldInfoPtr_m_ReferenceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, nameof (m_ReferenceId));
    PlayerSanctionInternal.NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666173);
    PlayerSanctionInternal.NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666174);
    PlayerSanctionInternal.NativeMethodInfoPtr_get_Action_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666175);
    PlayerSanctionInternal.NativeMethodInfoPtr_set_Action_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666176 /*0x06000B40*/);
    PlayerSanctionInternal.NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666177);
    PlayerSanctionInternal.NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666178);
    PlayerSanctionInternal.NativeMethodInfoPtr_get_ReferenceId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666179);
    PlayerSanctionInternal.NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666180);
    PlayerSanctionInternal.NativeMethodInfoPtr_Set_Public_Void_PlayerSanction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666181);
    PlayerSanctionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666182);
    PlayerSanctionInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, 100666183);
  }

  public unsafe long TimePlaced
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Action
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379878, XrefRangeEnd = 379882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_get_Action_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379882, XrefRangeEnd = 379886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_set_Action_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe long TimeExpires
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ReferenceId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379886, XrefRangeEnd = 379890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_get_ReferenceId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379890, XrefRangeEnd = 379894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 379902, RefRangeEnd = 379903, XrefRangeStart = 379894, XrefRangeEnd = 379902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(PlayerSanction other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_Set_Public_Void_PlayerSanction_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379903, XrefRangeEnd = 379906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379906, XrefRangeEnd = 379911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerSanctionInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSanctionInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
