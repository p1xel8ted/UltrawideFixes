// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.OnReadFileDataCallback
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.TitleStorage;

public sealed class OnReadFileDataCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ReadResult_ReadFileDataCallbackInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ReadFileDataCallbackInfo_AsyncCallback_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ReadResult_IAsyncResult_0;

  static OnReadFileDataCallback()
  {
    Il2CppClassPointerStore<OnReadFileDataCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.TitleStorage", nameof (OnReadFileDataCallback));
    OnReadFileDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReadFileDataCallback>.NativeClassPtr, 100664972);
    OnReadFileDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ReadResult_ReadFileDataCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReadFileDataCallback>.NativeClassPtr, 100664973);
    OnReadFileDataCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ReadFileDataCallbackInfo_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReadFileDataCallback>.NativeClassPtr, 100664974);
    OnReadFileDataCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ReadResult_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReadFileDataCallback>.NativeClassPtr, 100664975);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 374785, RefRangeEnd = 374804, XrefRangeStart = 374776, XrefRangeEnd = 374785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnReadFileDataCallback(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnReadFileDataCallback>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnReadFileDataCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe ReadResult Invoke(ReadFileDataCallbackInfo data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnReadFileDataCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ReadResult_ReadFileDataCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 162033, RefRangeEnd = 162034, XrefRangeStart = 162033, XrefRangeEnd = 162034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
    ReadFileDataCallbackInfo data,
    Il2CppSystem.AsyncCallback callback,
    Il2CppSystem.Object @object)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnReadFileDataCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ReadFileDataCallbackInfo_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 374806, RefRangeEnd = 374807, XrefRangeStart = 374804, XrefRangeEnd = 374806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ReadResult EndInvoke(Il2CppSystem.IAsyncResult result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnReadFileDataCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ReadResult_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static implicit operator OnReadFileDataCallback(
    [In] System.Func<ReadFileDataCallbackInfo, ReadResult> obj0)
  {
    return DelegateSupport.ConvertDelegate<OnReadFileDataCallback>((System.Delegate) obj0);
  }

  public static OnReadFileDataCallback operator +(
    [In] OnReadFileDataCallback obj0,
    [In] OnReadFileDataCallback obj1)
  {
    return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<OnReadFileDataCallback>();
  }

  public static OnReadFileDataCallback operator -(
    [In] OnReadFileDataCallback obj0,
    [In] OnReadFileDataCallback obj1)
  {
    Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
    return (object) @delegate == null ? (OnReadFileDataCallback) @delegate : @delegate.Cast<OnReadFileDataCallback>();
  }
}
