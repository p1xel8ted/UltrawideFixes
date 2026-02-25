// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.CopyAchievementDefinitionByAchievementIdOptionsInternal
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
public struct CopyAchievementDefinitionByAchievementIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionByAchievementIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_AchievementId;

  static CopyAchievementDefinitionByAchievementIdOptionsInternal()
  {
    Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (CopyAchievementDefinitionByAchievementIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr);
    CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeFieldInfoPtr_m_AchievementId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr, nameof (m_AchievementId));
    CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr, 100673223);
    CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionByAchievementIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr, 100673224);
    CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr, 100673225);
    CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr, 100673226);
  }

  public unsafe string AchievementId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401752, XrefRangeEnd = 401756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeMethodInfoPtr_set_AchievementId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401756, XrefRangeEnd = 401760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    CopyAchievementDefinitionByAchievementIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionByAchievementIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401760, XrefRangeEnd = 401766, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401766, XrefRangeEnd = 401770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionByAchievementIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyAchievementDefinitionByAchievementIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
