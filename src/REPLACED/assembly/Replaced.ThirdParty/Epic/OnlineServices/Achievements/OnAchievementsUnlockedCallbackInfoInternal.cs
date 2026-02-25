// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.OnAchievementsUnlockedCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

[StructLayout(LayoutKind.Explicit)]
public struct OnAchievementsUnlockedCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementIds;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AchievementIds_Public_get_Il2CppStringArray_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_UserId;
  [FieldOffset(16 /*0x10*/)]
  public uint m_AchievementsCount;
  [FieldOffset(24)]
  public System.IntPtr m_AchievementIds;

  static OnAchievementsUnlockedCallbackInfoInternal()
  {
    Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (OnAchievementsUnlockedCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr);
    OnAchievementsUnlockedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    OnAchievementsUnlockedCallbackInfoInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, nameof (m_UserId));
    OnAchievementsUnlockedCallbackInfoInternal.NativeFieldInfoPtr_m_AchievementsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, nameof (m_AchievementsCount));
    OnAchievementsUnlockedCallbackInfoInternal.NativeFieldInfoPtr_m_AchievementIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, nameof (m_AchievementIds));
    OnAchievementsUnlockedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, 100673426);
    OnAchievementsUnlockedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, 100673427);
    OnAchievementsUnlockedCallbackInfoInternal.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, 100673428);
    OnAchievementsUnlockedCallbackInfoInternal.NativeMethodInfoPtr_get_AchievementIds_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, 100673429);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402419, XrefRangeEnd = 402423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe ProductUserId UserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402423, XrefRangeEnd = 402429, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfoInternal.NativeMethodInfoPtr_get_UserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
  }

  public unsafe Il2CppStringArray AchievementIds
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402429, XrefRangeEnd = 402435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnAchievementsUnlockedCallbackInfoInternal.NativeMethodInfoPtr_get_AchievementIds_Public_get_Il2CppStringArray_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num3);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnAchievementsUnlockedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
