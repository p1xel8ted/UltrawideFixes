// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.TitleStorageFileTransferRequest
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Epic.OnlineServices.TitleStorage;

public sealed class TitleStorageFileTransferRequest(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CancelRequest_Public_Result_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetFileRequestState_Public_Result_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetFilename_Public_Result_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static TitleStorageFileTransferRequest()
  {
    Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.TitleStorage", nameof (TitleStorageFileTransferRequest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr);
    TitleStorageFileTransferRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665090 /*0x06000702*/);
    TitleStorageFileTransferRequest.NativeMethodInfoPtr_CancelRequest_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665092 /*0x06000704*/);
    TitleStorageFileTransferRequest.NativeMethodInfoPtr_GetFileRequestState_Public_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665093 /*0x06000705*/);
    TitleStorageFileTransferRequest.NativeMethodInfoPtr_GetFilename_Public_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665094 /*0x06000706*/);
    TitleStorageFileTransferRequest.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr, 100665095 /*0x06000707*/);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TitleStorageFileTransferRequest()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TitleStorageFileTransferRequest>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375231, XrefRangeEnd = 375233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CancelRequest()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr_CancelRequest_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375233, XrefRangeEnd = 375235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetFileRequestState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr_GetFileRequestState_Public_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375235, XrefRangeEnd = 375320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result GetFilename(out string outStringBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr3 = &zero;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr_GetFilename_Public_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    outStringBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 375320, XrefRangeEnd = 375322, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TitleStorageFileTransferRequest.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
