// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.PlayerDataStorageFileTransferRequest
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage;

public sealed class PlayerDataStorageFileTransferRequest(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CancelRequest_Public_Result_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetFileRequestState_Public_Result_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetFilename_Public_Result_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static PlayerDataStorageFileTransferRequest()
  {
    Il2CppClassPointerStore<PlayerDataStorageFileTransferRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (PlayerDataStorageFileTransferRequest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerDataStorageFileTransferRequest>.NativeClassPtr);
    PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageFileTransferRequest>.NativeClassPtr, 100667741);
    PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr_CancelRequest_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageFileTransferRequest>.NativeClassPtr, 100667743);
    PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr_GetFileRequestState_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageFileTransferRequest>.NativeClassPtr, 100667744);
    PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr_GetFilename_Public_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageFileTransferRequest>.NativeClassPtr, 100667745);
    PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerDataStorageFileTransferRequest>.NativeClassPtr, 100667746);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerDataStorageFileTransferRequest()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerDataStorageFileTransferRequest>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384581, XrefRangeEnd = 384582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CancelRequest()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr_CancelRequest_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384582, XrefRangeEnd = 384583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetFileRequestState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr_GetFileRequestState_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384583, XrefRangeEnd = 384590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetFilename(out string outStringBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr3 = &zero;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr_GetFilename_Public_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    outStringBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384590, XrefRangeEnd = 384591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerDataStorageFileTransferRequest.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
