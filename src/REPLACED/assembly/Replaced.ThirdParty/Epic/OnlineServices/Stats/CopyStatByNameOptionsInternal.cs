// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Stats.CopyStatByNameOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Stats;

[StructLayout(LayoutKind.Explicit)]
public struct CopyStatByNameOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyStatByNameOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_TargetUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Name;

  static CopyStatByNameOptionsInternal()
  {
    Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Stats", nameof (CopyStatByNameOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr);
    CopyStatByNameOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyStatByNameOptionsInternal.NativeFieldInfoPtr_m_TargetUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, nameof (m_TargetUserId));
    CopyStatByNameOptionsInternal.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, nameof (m_Name));
    CopyStatByNameOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, 100665126);
    CopyStatByNameOptionsInternal.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, 100665127);
    CopyStatByNameOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyStatByNameOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, 100665128);
    CopyStatByNameOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, 100665129);
    CopyStatByNameOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, 100665130);
  }

  public unsafe ProductUserId TargetUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375938, XrefRangeEnd = 375944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyStatByNameOptionsInternal.NativeMethodInfoPtr_set_TargetUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Name
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375944, XrefRangeEnd = 375948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyStatByNameOptionsInternal.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 375958, RefRangeEnd = 375959, XrefRangeStart = 375948, XrefRangeEnd = 375958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CopyStatByNameOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyStatByNameOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyStatByNameOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375959, XrefRangeEnd = 375962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyStatByNameOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375962, XrefRangeEnd = 375973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyStatByNameOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyStatByNameOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
