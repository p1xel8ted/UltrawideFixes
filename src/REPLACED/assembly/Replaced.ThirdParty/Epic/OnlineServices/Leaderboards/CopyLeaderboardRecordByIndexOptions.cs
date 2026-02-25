// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.CopyLeaderboardRecordByIndexOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards;

public class CopyLeaderboardRecordByIndexOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LeaderboardRecordIndex_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LeaderboardRecordIndex_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LeaderboardRecordIndex_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CopyLeaderboardRecordByIndexOptions()
  {
    Il2CppClassPointerStore<CopyLeaderboardRecordByIndexOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Leaderboards", nameof (CopyLeaderboardRecordByIndexOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLeaderboardRecordByIndexOptions>.NativeClassPtr);
    CopyLeaderboardRecordByIndexOptions.NativeFieldInfoPtr__LeaderboardRecordIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLeaderboardRecordByIndexOptions>.NativeClassPtr, "<LeaderboardRecordIndex>k__BackingField");
    CopyLeaderboardRecordByIndexOptions.NativeMethodInfoPtr_get_LeaderboardRecordIndex_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardRecordByIndexOptions>.NativeClassPtr, 100669898);
    CopyLeaderboardRecordByIndexOptions.NativeMethodInfoPtr_set_LeaderboardRecordIndex_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardRecordByIndexOptions>.NativeClassPtr, 100669899);
    CopyLeaderboardRecordByIndexOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLeaderboardRecordByIndexOptions>.NativeClassPtr, 100669900);
  }

  public unsafe uint LeaderboardRecordIndex
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardRecordByIndexOptions.NativeMethodInfoPtr_get_LeaderboardRecordIndex_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardRecordByIndexOptions.NativeMethodInfoPtr_set_LeaderboardRecordIndex_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CopyLeaderboardRecordByIndexOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyLeaderboardRecordByIndexOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CopyLeaderboardRecordByIndexOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe uint _LeaderboardRecordIndex_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyLeaderboardRecordByIndexOptions.NativeFieldInfoPtr__LeaderboardRecordIndex_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CopyLeaderboardRecordByIndexOptions.NativeFieldInfoPtr__LeaderboardRecordIndex_k__BackingField)) = value;
    }
  }
}
