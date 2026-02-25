// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogPlayerSpawnOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

public class LogPlayerSpawnOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__SpawnedPlayerHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TeamId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CharacterId_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SpawnedPlayerHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TeamId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CharacterId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LogPlayerSpawnOptions()
  {
    Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogPlayerSpawnOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr);
    LogPlayerSpawnOptions.NativeFieldInfoPtr__SpawnedPlayerHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, "<SpawnedPlayerHandle>k__BackingField");
    LogPlayerSpawnOptions.NativeFieldInfoPtr__TeamId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, "<TeamId>k__BackingField");
    LogPlayerSpawnOptions.NativeFieldInfoPtr__CharacterId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, "<CharacterId>k__BackingField");
    LogPlayerSpawnOptions.NativeMethodInfoPtr_get_SpawnedPlayerHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100672722);
    LogPlayerSpawnOptions.NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100672723);
    LogPlayerSpawnOptions.NativeMethodInfoPtr_get_TeamId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100672724);
    LogPlayerSpawnOptions.NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100672725);
    LogPlayerSpawnOptions.NativeMethodInfoPtr_get_CharacterId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100672726);
    LogPlayerSpawnOptions.NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100672727);
    LogPlayerSpawnOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr, 100672728);
  }

  public unsafe System.IntPtr SpawnedPlayerHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_get_SpawnedPlayerHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_set_SpawnedPlayerHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint TeamId
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_get_TeamId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_set_TeamId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint CharacterId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_get_CharacterId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr_set_CharacterId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LogPlayerSpawnOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogPlayerSpawnOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogPlayerSpawnOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _SpawnedPlayerHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerSpawnOptions.NativeFieldInfoPtr__SpawnedPlayerHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerSpawnOptions.NativeFieldInfoPtr__SpawnedPlayerHandle_k__BackingField)) = value;
    }
  }

  public unsafe uint _TeamId_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerSpawnOptions.NativeFieldInfoPtr__TeamId_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerSpawnOptions.NativeFieldInfoPtr__TeamId_k__BackingField)) = value;
    }
  }

  public unsafe uint _CharacterId_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerSpawnOptions.NativeFieldInfoPtr__CharacterId_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogPlayerSpawnOptions.NativeFieldInfoPtr__CharacterId_k__BackingField)) = value;
    }
  }
}
