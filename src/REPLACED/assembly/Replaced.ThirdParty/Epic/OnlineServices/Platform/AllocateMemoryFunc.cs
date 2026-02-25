// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.AllocateMemoryFunc
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

public sealed class AllocateMemoryFunc(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_UIntPtr_UIntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIntPtr_UIntPtr_AsyncCallback_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0;

  static AllocateMemoryFunc()
  {
    Il2CppClassPointerStore<AllocateMemoryFunc>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (AllocateMemoryFunc));
    AllocateMemoryFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocateMemoryFunc>.NativeClassPtr, 100667929);
    AllocateMemoryFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_UIntPtr_UIntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocateMemoryFunc>.NativeClassPtr, 100667930);
    AllocateMemoryFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIntPtr_UIntPtr_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocateMemoryFunc>.NativeClassPtr, 100667931);
    AllocateMemoryFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllocateMemoryFunc>.NativeClassPtr, 100667932);
  }

  [CallerCount(30)]
  [CachedScanResults(RefRangeStart = 385416, RefRangeEnd = 385446, XrefRangeStart = 385414, XrefRangeEnd = 385416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AllocateMemoryFunc(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllocateMemoryFunc>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AllocateMemoryFunc.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe System.IntPtr Invoke(System.UIntPtr sizeInBytes, System.UIntPtr alignment)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &sizeInBytes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &alignment;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AllocateMemoryFunc.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_UIntPtr_UIntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385446, XrefRangeEnd = 385451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
    System.UIntPtr sizeInBytes,
    System.UIntPtr alignment,
    Il2CppSystem.AsyncCallback callback,
    Il2CppSystem.Object @object)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &sizeInBytes;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &alignment;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AllocateMemoryFunc.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIntPtr_UIntPtr_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385451, XrefRangeEnd = 385453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe System.IntPtr EndInvoke(Il2CppSystem.IAsyncResult result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AllocateMemoryFunc.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_IntPtr_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static implicit operator AllocateMemoryFunc([In] System.Func<System.UIntPtr, System.UIntPtr, System.IntPtr> obj0)
  {
    return DelegateSupport.ConvertDelegate<AllocateMemoryFunc>((System.Delegate) obj0);
  }

  public static AllocateMemoryFunc operator +([In] AllocateMemoryFunc obj0, [In] AllocateMemoryFunc obj1)
  {
    return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<AllocateMemoryFunc>();
  }

  public static AllocateMemoryFunc operator -([In] AllocateMemoryFunc obj0, [In] AllocateMemoryFunc obj1)
  {
    Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
    return (object) @delegate == null ? (AllocateMemoryFunc) @delegate : @delegate.Cast<AllocateMemoryFunc>();
  }
}
