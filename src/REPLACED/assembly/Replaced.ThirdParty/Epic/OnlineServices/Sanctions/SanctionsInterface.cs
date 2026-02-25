// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sanctions.SanctionsInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sanctions;

public sealed class SanctionsInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CopyplayersanctionbyindexApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_GetplayersanctioncountApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_PlayersanctionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_QueryactiveplayersanctionsApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyPlayerSanctionByIndex_Public_Result_CopyPlayerSanctionByIndexOptions_byref_PlayerSanction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerSanctionCount_Public_UInt32_GetPlayerSanctionCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_QueryActivePlayerSanctions_Public_Void_QueryActivePlayerSanctionsOptions_Object_OnQueryActivePlayerSanctionsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryActivePlayerSanctionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static SanctionsInterface()
  {
    Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sanctions", nameof (SanctionsInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr);
    SanctionsInterface.NativeFieldInfoPtr_CopyplayersanctionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, nameof (CopyplayersanctionbyindexApiLatest));
    SanctionsInterface.NativeFieldInfoPtr_GetplayersanctioncountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, nameof (GetplayersanctioncountApiLatest));
    SanctionsInterface.NativeFieldInfoPtr_PlayersanctionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, nameof (PlayersanctionApiLatest));
    SanctionsInterface.NativeFieldInfoPtr_QueryactiveplayersanctionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, nameof (QueryactiveplayersanctionsApiLatest));
    SanctionsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666211);
    SanctionsInterface.NativeMethodInfoPtr_CopyPlayerSanctionByIndex_Public_Result_CopyPlayerSanctionByIndexOptions_byref_PlayerSanction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666213);
    SanctionsInterface.NativeMethodInfoPtr_GetPlayerSanctionCount_Public_UInt32_GetPlayerSanctionCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666214);
    SanctionsInterface.NativeMethodInfoPtr_QueryActivePlayerSanctions_Public_Void_QueryActivePlayerSanctionsOptions_Object_OnQueryActivePlayerSanctionsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666215);
    SanctionsInterface.NativeMethodInfoPtr_OnQueryActivePlayerSanctionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr, 100666216);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SanctionsInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SanctionsInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380011, XrefRangeEnd = 380023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyPlayerSanctionByIndex(
    CopyPlayerSanctionByIndexOptions options,
    out PlayerSanction outSanction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr_CopyPlayerSanctionByIndex_Public_Result_CopyPlayerSanctionByIndexOptions_byref_PlayerSanction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref PlayerSanction local = ref outSanction;
    System.IntPtr pointer = zero;
    PlayerSanction playerSanction = pointer == System.IntPtr.Zero ? (PlayerSanction) null : new PlayerSanction(pointer);
    local = playerSanction;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380023, XrefRangeEnd = 380031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetPlayerSanctionCount(GetPlayerSanctionCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr_GetPlayerSanctionCount_Public_UInt32_GetPlayerSanctionCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380031, XrefRangeEnd = 380050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void QueryActivePlayerSanctions(
    QueryActivePlayerSanctionsOptions options,
    Il2CppSystem.Object clientData,
    OnQueryActivePlayerSanctionsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr_QueryActivePlayerSanctions_Public_Void_QueryActivePlayerSanctionsOptions_Object_OnQueryActivePlayerSanctionsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380050, XrefRangeEnd = 380056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnQueryActivePlayerSanctionsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SanctionsInterface.NativeMethodInfoPtr_OnQueryActivePlayerSanctionsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int CopyplayersanctionbyindexApiLatest
  {
    get
    {
      int copyplayersanctionbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SanctionsInterface.NativeFieldInfoPtr_CopyplayersanctionbyindexApiLatest, (void*) &copyplayersanctionbyindexApiLatest);
      return copyplayersanctionbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SanctionsInterface.NativeFieldInfoPtr_CopyplayersanctionbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int GetplayersanctioncountApiLatest
  {
    get
    {
      int getplayersanctioncountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SanctionsInterface.NativeFieldInfoPtr_GetplayersanctioncountApiLatest, (void*) &getplayersanctioncountApiLatest);
      return getplayersanctioncountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SanctionsInterface.NativeFieldInfoPtr_GetplayersanctioncountApiLatest, (void*) &value);
    }
  }

  public static unsafe int PlayersanctionApiLatest
  {
    get
    {
      int playersanctionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SanctionsInterface.NativeFieldInfoPtr_PlayersanctionApiLatest, (void*) &playersanctionApiLatest);
      return playersanctionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SanctionsInterface.NativeFieldInfoPtr_PlayersanctionApiLatest, (void*) &value);
    }
  }

  public static unsafe int QueryactiveplayersanctionsApiLatest
  {
    get
    {
      int queryactiveplayersanctionsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(SanctionsInterface.NativeFieldInfoPtr_QueryactiveplayersanctionsApiLatest, (void*) &queryactiveplayersanctionsApiLatest);
      return queryactiveplayersanctionsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SanctionsInterface.NativeFieldInfoPtr_QueryactiveplayersanctionsApiLatest, (void*) &value);
    }
  }
}
