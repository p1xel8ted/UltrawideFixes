// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.ActiveSession
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

public sealed class ActiveSession(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ActivesessionCopyinfoApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_ActivesessionGetregisteredplayerbyindexApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_ActivesessionGetregisteredplayercountApiLatest;
  private static readonly IntPtr NativeFieldInfoPtr_ActivesessionInfoApiLatest;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CopyInfo_Public_Result_ActiveSessionCopyInfoOptions_byref_ActiveSessionInfo_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredPlayerByIndex_Public_ProductUserId_ActiveSessionGetRegisteredPlayerByIndexOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetRegisteredPlayerCount_Public_UInt32_ActiveSessionGetRegisteredPlayerCountOptions_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static ActiveSession()
  {
    Il2CppClassPointerStore<ActiveSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (ActiveSession));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr);
    ActiveSession.NativeFieldInfoPtr_ActivesessionCopyinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, nameof (ActivesessionCopyinfoApiLatest));
    ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayerbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, nameof (ActivesessionGetregisteredplayerbyindexApiLatest));
    ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayercountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, nameof (ActivesessionGetregisteredplayercountApiLatest));
    ActiveSession.NativeFieldInfoPtr_ActivesessionInfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, nameof (ActivesessionInfoApiLatest));
    ActiveSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665265);
    ActiveSession.NativeMethodInfoPtr_CopyInfo_Public_Result_ActiveSessionCopyInfoOptions_byref_ActiveSessionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665267);
    ActiveSession.NativeMethodInfoPtr_GetRegisteredPlayerByIndex_Public_ProductUserId_ActiveSessionGetRegisteredPlayerByIndexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665268);
    ActiveSession.NativeMethodInfoPtr_GetRegisteredPlayerCount_Public_UInt32_ActiveSessionGetRegisteredPlayerCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665269);
    ActiveSession.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr, 100665270);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActiveSession()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveSession>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376797, XrefRangeEnd = 376871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyInfo(
    ActiveSessionCopyInfoOptions options,
    out ActiveSessionInfo outActiveSessionInfo)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr_CopyInfo_Public_Result_ActiveSessionCopyInfoOptions_byref_ActiveSessionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ActiveSessionInfo local = ref outActiveSessionInfo;
    IntPtr pointer = zero;
    ActiveSessionInfo activeSessionInfo = pointer == IntPtr.Zero ? (ActiveSessionInfo) null : new ActiveSessionInfo(pointer);
    local = activeSessionInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376871, XrefRangeEnd = 376943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProductUserId GetRegisteredPlayerByIndex(
    ActiveSessionGetRegisteredPlayerByIndexOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr_GetRegisteredPlayerByIndex_Public_ProductUserId_ActiveSessionGetRegisteredPlayerByIndexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376943, XrefRangeEnd = 377012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe uint GetRegisteredPlayerCount(
    ActiveSessionGetRegisteredPlayerCountOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr_GetRegisteredPlayerCount_Public_UInt32_ActiveSessionGetRegisteredPlayerCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377012, XrefRangeEnd = 377014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ActiveSession.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int ActivesessionCopyinfoApiLatest
  {
    get
    {
      int copyinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ActiveSession.NativeFieldInfoPtr_ActivesessionCopyinfoApiLatest, (void*) &copyinfoApiLatest);
      return copyinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ActiveSession.NativeFieldInfoPtr_ActivesessionCopyinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int ActivesessionGetregisteredplayerbyindexApiLatest
  {
    get
    {
      int getregisteredplayerbyindexApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayerbyindexApiLatest, (void*) &getregisteredplayerbyindexApiLatest);
      return getregisteredplayerbyindexApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayerbyindexApiLatest, (void*) &value);
    }
  }

  public static unsafe int ActivesessionGetregisteredplayercountApiLatest
  {
    get
    {
      int getregisteredplayercountApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayercountApiLatest, (void*) &getregisteredplayercountApiLatest);
      return getregisteredplayercountApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ActiveSession.NativeFieldInfoPtr_ActivesessionGetregisteredplayercountApiLatest, (void*) &value);
    }
  }

  public static unsafe int ActivesessionInfoApiLatest
  {
    get
    {
      int activesessionInfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ActiveSession.NativeFieldInfoPtr_ActivesessionInfoApiLatest, (void*) &activesessionInfoApiLatest);
      return activesessionInfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ActiveSession.NativeFieldInfoPtr_ActivesessionInfoApiLatest, (void*) &value);
    }
  }
}
