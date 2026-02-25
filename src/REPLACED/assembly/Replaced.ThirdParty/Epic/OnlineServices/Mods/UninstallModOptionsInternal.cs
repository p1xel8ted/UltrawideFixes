// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.UninstallModOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Mods;

[StructLayout(LayoutKind.Explicit)]
public struct UninstallModOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Mod;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_UninstallModOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Mod;

  static UninstallModOptionsInternal()
  {
    Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Mods", nameof (UninstallModOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr);
    UninstallModOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    UninstallModOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    UninstallModOptionsInternal.NativeFieldInfoPtr_m_Mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, nameof (m_Mod));
    UninstallModOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, 100668717);
    UninstallModOptionsInternal.NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, 100668718);
    UninstallModOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_UninstallModOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, 100668719);
    UninstallModOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, 100668720);
    UninstallModOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, 100668721);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387810, XrefRangeEnd = 387814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UninstallModOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ModIdentifier Mod
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 387820, RefRangeEnd = 387822, XrefRangeStart = 387814, XrefRangeEnd = 387820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UninstallModOptionsInternal.NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387822, XrefRangeEnd = 387827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(UninstallModOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UninstallModOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_UninstallModOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387827, XrefRangeEnd = 387834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UninstallModOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387834, XrefRangeEnd = 387839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UninstallModOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UninstallModOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
