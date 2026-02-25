// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.OnWriteFileDataCallback
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage;

public sealed class OnWriteFileDataCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_WriteResult_WriteFileDataCallbackInfo_byref_Il2CppStructArray_1_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WriteFileDataCallbackInfo_byref_Il2CppStructArray_1_Byte_AsyncCallback_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_WriteResult_byref_Il2CppStructArray_1_Byte_IAsyncResult_0;

  static OnWriteFileDataCallback()
  {
    Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (OnWriteFileDataCallback));
    OnWriteFileDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr, 100667733);
    OnWriteFileDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_WriteResult_WriteFileDataCallbackInfo_byref_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr, 100667734);
    OnWriteFileDataCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WriteFileDataCallbackInfo_byref_Il2CppStructArray_1_Byte_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr, 100667735);
    OnWriteFileDataCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_WriteResult_byref_Il2CppStructArray_1_Byte_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr, 100667736);
  }

  [CallerCount(90)]
  [CachedScanResults(RefRangeStart = 384479, RefRangeEnd = 384569, XrefRangeStart = 384470, XrefRangeEnd = 384479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnWriteFileDataCallback(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnWriteFileDataCallback>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnWriteFileDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe WriteResult Invoke(
    WriteFileDataCallbackInfo data,
    out Il2CppStructArray<byte> outDataBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(OnWriteFileDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_WriteResult_WriteFileDataCallbackInfo_byref_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppStructArray<byte> local = ref outDataBuffer;
    System.IntPtr num4 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num4 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num4);
    local = il2CppStructArray;
    return *(WriteResult*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384569, XrefRangeEnd = 384570, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
    WriteFileDataCallbackInfo data,
    out Il2CppStructArray<byte> outDataBuffer,
    Il2CppSystem.AsyncCallback callback,
    Il2CppSystem.Object @object)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(OnWriteFileDataCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_WriteFileDataCallbackInfo_byref_Il2CppStructArray_1_Byte_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref Il2CppStructArray<byte> local = ref outDataBuffer;
    System.IntPtr num4 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num4 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num4);
    local = il2CppStructArray;
    System.IntPtr num5 = num3;
    return num5 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(num5);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384570, XrefRangeEnd = 384572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe WriteResult EndInvoke(
    out Il2CppStructArray<byte> outDataBuffer,
    Il2CppSystem.IAsyncResult result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero;
    *numPtr2 = (System.IntPtr) numPtr3;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnWriteFileDataCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_WriteResult_byref_Il2CppStructArray_1_Byte_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref Il2CppStructArray<byte> local = ref outDataBuffer;
    System.IntPtr num3 = zero;
    Il2CppStructArray<byte> il2CppStructArray = num3 == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(num3);
    local = il2CppStructArray;
    return *(WriteResult*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
