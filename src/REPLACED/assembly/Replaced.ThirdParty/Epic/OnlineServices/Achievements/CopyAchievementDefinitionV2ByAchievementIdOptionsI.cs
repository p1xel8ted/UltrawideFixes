// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.CopyAchievementDefinitionV2ByAchievementIdOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

[StructLayout(LayoutKind.Explicit)]
public struct CopyAchievementDefinitionV2ByAchievementIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionV2ByAchievementIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_AchievementId;

  static CopyAchievementDefinitionV2ByAchievementIdOptionsInternal()
  {
    Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (CopyAchievementDefinitionV2ByAchievementIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr);
    CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr, nameof (m_AchievementId));
    CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr, 100673237);
    CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionV2ByAchievementIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr, 100673238);
    CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr, 100673239);
    CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr, 100673240);
  }

  public unsafe string AchievementId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401772, XrefRangeEnd = 401776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401776, XrefRangeEnd = 401780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    CopyAchievementDefinitionV2ByAchievementIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionV2ByAchievementIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401780, XrefRangeEnd = 401786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401786, XrefRangeEnd = 401790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionV2ByAchievementIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByAchievementIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
