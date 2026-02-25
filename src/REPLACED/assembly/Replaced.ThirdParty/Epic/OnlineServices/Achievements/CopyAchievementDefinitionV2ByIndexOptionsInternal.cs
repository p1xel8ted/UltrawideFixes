// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.CopyAchievementDefinitionV2ByIndexOptionsInternal
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
public struct CopyAchievementDefinitionV2ByIndexOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AchievementIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AchievementIndex_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionV2ByIndexOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_AchievementIndex;

  static CopyAchievementDefinitionV2ByIndexOptionsInternal()
  {
    Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (CopyAchievementDefinitionV2ByIndexOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr);
    CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeFieldInfoPtr_m_AchievementIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr, nameof (m_AchievementIndex));
    CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeMethodInfoPtr_set_AchievementIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr, 100673244);
    CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionV2ByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr, 100673245);
    CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr, 100673246);
    CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr, 100673247);
  }

  public unsafe uint AchievementIndex
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeMethodInfoPtr_set_AchievementIndex_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(CopyAchievementDefinitionV2ByIndexOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CopyAchievementDefinitionV2ByIndexOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401790, XrefRangeEnd = 401792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyAchievementDefinitionV2ByIndexOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CopyAchievementDefinitionV2ByIndexOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
