// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.InstallModOptionsInternal
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
public struct InstallModOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Mod;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RemoveAfterExit;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoveAfterExit_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_InstallModOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Mod;
  [FieldOffset(24)]
  public int m_RemoveAfterExit;

  static InstallModOptionsInternal()
  {
    Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Mods", nameof (InstallModOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr);
    InstallModOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    InstallModOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    InstallModOptionsInternal.NativeFieldInfoPtr_m_Mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, nameof (m_Mod));
    InstallModOptionsInternal.NativeFieldInfoPtr_m_RemoveAfterExit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, nameof (m_RemoveAfterExit));
    InstallModOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, 100668606);
    InstallModOptionsInternal.NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, 100668607);
    InstallModOptionsInternal.NativeMethodInfoPtr_set_RemoveAfterExit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, 100668608);
    InstallModOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_InstallModOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, 100668609);
    InstallModOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, 100668610);
    InstallModOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, 100668611);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387430, XrefRangeEnd = 387434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InstallModOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ModIdentifier Mod
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 387440, RefRangeEnd = 387441, XrefRangeStart = 387434, XrefRangeEnd = 387440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InstallModOptionsInternal.NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool RemoveAfterExit
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387441, XrefRangeEnd = 387445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InstallModOptionsInternal.NativeMethodInfoPtr_set_RemoveAfterExit_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 387454, RefRangeEnd = 387455, XrefRangeStart = 387445, XrefRangeEnd = 387454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(InstallModOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InstallModOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_InstallModOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387455, XrefRangeEnd = 387458, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InstallModOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387458, XrefRangeEnd = 387463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InstallModOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InstallModOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
