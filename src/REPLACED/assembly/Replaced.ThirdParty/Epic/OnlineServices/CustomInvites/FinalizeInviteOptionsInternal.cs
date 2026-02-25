// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.CustomInvites.FinalizeInviteOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.CustomInvites;

[StructLayout(LayoutKind.Explicit)]
public struct FinalizeInviteOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CustomInviteId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProcessingResult;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CustomInviteId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProcessingResult_Public_set_Void_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_FinalizeInviteOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_TargetUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(24)]
  public System.IntPtr m_CustomInviteId;
  [FieldOffset(32 /*0x20*/)]
  public Result m_ProcessingResult;

  static FinalizeInviteOptionsInternal()
  {
    Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.CustomInvites", nameof (FinalizeInviteOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr);
    FinalizeInviteOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    FinalizeInviteOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    FinalizeInviteOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    FinalizeInviteOptionsInternal.NativeFieldInfoPtr_m_CustomInviteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, nameof (m_CustomInviteId));
    FinalizeInviteOptionsInternal.NativeFieldInfoPtr_m_ProcessingResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, nameof (m_ProcessingResult));
    FinalizeInviteOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, 100671323);
    FinalizeInviteOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, 100671324);
    FinalizeInviteOptionsInternal.NativeMethodInfoPtr_set_CustomInviteId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, 100671325);
    FinalizeInviteOptionsInternal.NativeMethodInfoPtr_set_ProcessingResult_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, 100671326);
    FinalizeInviteOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_FinalizeInviteOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, 100671327);
    FinalizeInviteOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, 100671328);
    FinalizeInviteOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, 100671329);
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396005, XrefRangeEnd = 396009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FinalizeInviteOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396009, XrefRangeEnd = 396013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FinalizeInviteOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string CustomInviteId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396013, XrefRangeEnd = 396017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FinalizeInviteOptionsInternal.NativeMethodInfoPtr_set_CustomInviteId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Result ProcessingResult
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FinalizeInviteOptionsInternal.NativeMethodInfoPtr_set_ProcessingResult_Public_set_Void_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 396029, RefRangeEnd = 396030, XrefRangeStart = 396017, XrefRangeEnd = 396029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(FinalizeInviteOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalizeInviteOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_FinalizeInviteOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396030, XrefRangeEnd = 396033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalizeInviteOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396033, XrefRangeEnd = 396039, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FinalizeInviteOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FinalizeInviteOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
