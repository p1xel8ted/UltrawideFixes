// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.TitleStorage.OnQueryFileListCompleteCallback
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

public sealed class OnQueryFileListCompleteCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_QueryFileListCallbackInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_QueryFileListCallbackInfo_AsyncCallback_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

  static OnQueryFileListCompleteCallback()
  {
    Il2CppClassPointerStore<OnQueryFileListCompleteCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.TitleStorage", nameof (OnQueryFileListCompleteCallback));
    OnQueryFileListCompleteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryFileListCompleteCallback>.NativeClassPtr, 100664956);
    OnQueryFileListCompleteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_QueryFileListCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryFileListCompleteCallback>.NativeClassPtr, 100664957);
    OnQueryFileListCompleteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_QueryFileListCallbackInfo_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryFileListCompleteCallback>.NativeClassPtr, 100664958);
    OnQueryFileListCompleteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryFileListCompleteCallback>.NativeClassPtr, 100664959);
  }

  [CallerCount(160 /*0xA0*/)]
  [CachedScanResults(RefRangeStart = 372139, RefRangeEnd = 372299, XrefRangeStart = 372139, XrefRangeEnd = 372299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnQueryFileListCompleteCallback(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnQueryFileListCompleteCallback>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnQueryFileListCompleteCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Invoke(QueryFileListCallbackInfo data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnQueryFileListCompleteCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_QueryFileListCallbackInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 162033, RefRangeEnd = 162034, XrefRangeStart = 162033, XrefRangeEnd = 162034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
    QueryFileListCallbackInfo data,
    Il2CppSystem.AsyncCallback callback,
    Il2CppSystem.Object @object)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnQueryFileListCompleteCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_QueryFileListCallbackInfo_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 162035, RefRangeEnd = 162037, XrefRangeStart = 162035, XrefRangeEnd = 162037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnQueryFileListCompleteCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static implicit operator OnQueryFileListCompleteCallback(
    [In] System.Action<QueryFileListCallbackInfo> obj0)
  {
    return DelegateSupport.ConvertDelegate<OnQueryFileListCompleteCallback>((System.Delegate) obj0);
  }

  public static OnQueryFileListCompleteCallback operator +(
    [In] OnQueryFileListCompleteCallback obj0,
    [In] OnQueryFileListCompleteCallback obj1)
  {
    return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<OnQueryFileListCompleteCallback>();
  }

  public static OnQueryFileListCompleteCallback operator -(
    [In] OnQueryFileListCompleteCallback obj0,
    [In] OnQueryFileListCompleteCallback obj1)
  {
    Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
    return (object) @delegate == null ? (OnQueryFileListCompleteCallback) @delegate : @delegate.Cast<OnQueryFileListCompleteCallback>();
  }
}
