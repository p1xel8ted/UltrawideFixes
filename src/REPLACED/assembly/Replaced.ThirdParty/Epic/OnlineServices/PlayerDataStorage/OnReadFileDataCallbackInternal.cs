// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.OnReadFileDataCallbackInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage;

public sealed class OnReadFileDataCallbackInternal(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_ReadResult_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ReadResult_IAsyncResult_0;

  static OnReadFileDataCallbackInternal()
  {
    Il2CppClassPointerStore<OnReadFileDataCallbackInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (OnReadFileDataCallbackInternal));
    OnReadFileDataCallbackInternal.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReadFileDataCallbackInternal>.NativeClassPtr, 100667721);
    OnReadFileDataCallbackInternal.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ReadResult_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReadFileDataCallbackInternal>.NativeClassPtr, 100667722);
    OnReadFileDataCallbackInternal.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReadFileDataCallbackInternal>.NativeClassPtr, 100667723);
    OnReadFileDataCallbackInternal.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ReadResult_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnReadFileDataCallbackInternal>.NativeClassPtr, 100667724);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 374809, RefRangeEnd = 374821, XrefRangeStart = 374809, XrefRangeEnd = 374821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnReadFileDataCallbackInternal(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnReadFileDataCallbackInternal>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnReadFileDataCallbackInternal.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe ReadResult Invoke(System.IntPtr data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnReadFileDataCallbackInternal.NativeMethodInfoPtr_Invoke_Public_Virtual_New_ReadResult_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
    System.IntPtr data,
    Il2CppSystem.AsyncCallback callback,
    Il2CppSystem.Object @object)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnReadFileDataCallbackInternal.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 374806, RefRangeEnd = 374807, XrefRangeStart = 374806, XrefRangeEnd = 374807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ReadResult EndInvoke(Il2CppSystem.IAsyncResult result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnReadFileDataCallbackInternal.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_ReadResult_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ReadResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static implicit operator OnReadFileDataCallbackInternal([In] System.Func<System.IntPtr, ReadResult> obj0)
  {
    return DelegateSupport.ConvertDelegate<OnReadFileDataCallbackInternal>((System.Delegate) obj0);
  }

  public static OnReadFileDataCallbackInternal operator +(
    [In] OnReadFileDataCallbackInternal obj0,
    [In] OnReadFileDataCallbackInternal obj1)
  {
    return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<OnReadFileDataCallbackInternal>();
  }

  public static OnReadFileDataCallbackInternal operator -(
    [In] OnReadFileDataCallbackInternal obj0,
    [In] OnReadFileDataCallbackInternal obj1)
  {
    Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
    return (object) @delegate == null ? (OnReadFileDataCallbackInternal) @delegate : @delegate.Cast<OnReadFileDataCallbackInternal>();
  }
}
