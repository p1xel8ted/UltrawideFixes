// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.AsyncGPUReadback
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine.Experimental.Rendering;

#nullable disable
namespace UnityEngine.Rendering;

public static class AsyncGPUReadback : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_IntPtr_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0;
  private static readonly AsyncGPUReadback.WaitAllRequestsDelegate WaitAllRequestsDelegateField;
  private static readonly AsyncGPUReadback.Request_Internal_ComputeBuffer_1_InjectedDelegate Request_Internal_ComputeBuffer_1_InjectedDelegateField;
  private static readonly AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegate Request_Internal_ComputeBuffer_2_InjectedDelegateField;
  private static readonly AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegate Request_Internal_GraphicsBuffer_2_InjectedDelegateField;
  private static readonly AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegate Request_Internal_Texture_1_InjectedDelegateField;
  private static readonly AsyncGPUReadback.Request_Internal_Texture_2_InjectedDelegate Request_Internal_Texture_2_InjectedDelegateField;
  private static readonly AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegate Request_Internal_Texture_3_InjectedDelegateField;
  private static readonly AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegate Request_Internal_Texture_4_InjectedDelegateField;

  static AsyncGPUReadback()
  {
    Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (AsyncGPUReadback));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr);
    AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100669625);
    AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100669626);
    AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_IntPtr_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncGPUReadback>.NativeClassPtr, 100669627);
    AsyncGPUReadback.WaitAllRequestsDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.WaitAllRequestsDelegate>("UnityEngine.Rendering.AsyncGPUReadback::WaitAllRequests");
    AsyncGPUReadback.Request_Internal_ComputeBuffer_1_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_ComputeBuffer_1_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_1_Injected");
    AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_ComputeBuffer_2_Injected");
    AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_GraphicsBuffer_2_Injected");
    AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_1_Injected");
    AsyncGPUReadback.Request_Internal_Texture_2_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_2_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_2_Injected");
    AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_3_Injected");
    AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegateField = IL2CPP.ResolveICall<AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegate>("UnityEngine.Rendering.AsyncGPUReadback::Request_Internal_Texture_4_Injected");
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 482004, RefRangeEnd = 482006, XrefRangeStart = 481999, XrefRangeEnd = 482004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncGPUReadbackRequest Request(
    GraphicsBuffer src,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) src);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Public_Static_AsyncGPUReadbackRequest_GraphicsBuffer_Action_1_AsyncGPUReadbackRequest_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AsyncGPUReadbackRequest*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482006, XrefRangeEnd = 482009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_1(
    GraphicsBuffer buffer,
    AsyncRequestNativeArrayData* data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) data;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Private_Static_AsyncGPUReadbackRequest_GraphicsBuffer_ptr_AsyncRequestNativeArrayData_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(AsyncGPUReadbackRequest*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482009, XrefRangeEnd = 482011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Request_Internal_GraphicsBuffer_1_Injected(
    System.IntPtr buffer,
    AsyncRequestNativeArrayData* data,
    out AsyncGPUReadbackRequest ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &buffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) data;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AsyncGPUReadback.NativeMethodInfoPtr_Request_Internal_GraphicsBuffer_1_Injected_Private_Static_Void_IntPtr_ptr_AsyncRequestNativeArrayData_byref_AsyncGPUReadbackRequest_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public AsyncGPUReadback(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static void ValidateFormat(Texture src, GraphicsFormat dstformat)
  {
    GraphicsFormat format = GraphicsFormatUtility.GetFormat(src);
    if (SystemInfo.IsFormatSupported(format, GraphicsFormatUsage.ReadPixels))
      return;
    Debug.LogError((Il2CppSystem.Object) Il2CppSystem.String.Format("'{0}' doesn't support ReadPixels usage on this platform. Async GPU readback failed.", (Il2CppSystem.Object) (System.Enum) format));
  }

  public static void WaitAllRequests() => AsyncGPUReadback.WaitAllRequestsDelegateField();

  public static unsafe AsyncGPUReadbackRequest Request(
    ComputeBuffer src,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    AsyncGPUReadbackRequest buffer1 = AsyncGPUReadback.Request_Internal_ComputeBuffer_1(src, (AsyncRequestNativeArrayData*) null);
    buffer1.SetScriptingCallback(callback);
    return buffer1;
  }

  public static unsafe AsyncGPUReadbackRequest Request(
    ComputeBuffer src,
    int size,
    int offset,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    AsyncGPUReadbackRequest buffer2 = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, (AsyncRequestNativeArrayData*) null);
    buffer2.SetScriptingCallback(callback);
    return buffer2;
  }

  public static unsafe AsyncGPUReadbackRequest Request(
    GraphicsBuffer src,
    int size,
    int offset,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, (AsyncRequestNativeArrayData*) null);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest Request(
    Texture src,
    int mipIndex = default (int),
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, (AsyncRequestNativeArrayData*) null);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static AsyncGPUReadbackRequest Request(
    Texture src,
    int mipIndex,
    TextureFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    return AsyncGPUReadback.Request(src, mipIndex, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
  }

  public static unsafe AsyncGPUReadbackRequest Request(
    Texture src,
    int mipIndex,
    GraphicsFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    AsyncGPUReadback.ValidateFormat(src, dstFormat);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_2(src, mipIndex, dstFormat, (AsyncRequestNativeArrayData*) null);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest Request(
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_3(src, mipIndex, x, width, y, height, z, depth, (AsyncRequestNativeArrayData*) null);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static AsyncGPUReadbackRequest Request(
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    TextureFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    return AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
  }

  public static unsafe AsyncGPUReadbackRequest Request(
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
  {
    AsyncGPUReadback.ValidateFormat(src, dstFormat);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, (AsyncRequestNativeArrayData*) null);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    ComputeBuffer src,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest buffer1 = AsyncGPUReadback.Request_Internal_ComputeBuffer_1(src, &andCheckAccess);
    buffer1.SetScriptingCallback(callback);
    return buffer1;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    ComputeBuffer src,
    int size,
    int offset,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest buffer2 = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, &andCheckAccess);
    buffer2.SetScriptingCallback(callback);
    return buffer2;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    GraphicsBuffer src,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_1(src, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    GraphicsBuffer src,
    int size,
    int offset,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex = default (int),
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex,
    TextureFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    return AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex,
    GraphicsFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncGPUReadback.ValidateFormat(src, dstFormat);
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_2(src, mipIndex, dstFormat, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    TextureFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    return AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, x, width, y, height, z, depth, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeArray<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncGPUReadback.ValidateFormat(src, dstFormat);
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    ComputeBuffer src,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest buffer1 = AsyncGPUReadback.Request_Internal_ComputeBuffer_1(src, &andCheckAccess);
    buffer1.SetScriptingCallback(callback);
    return buffer1;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    ComputeBuffer src,
    int size,
    int offset,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest buffer2 = AsyncGPUReadback.Request_Internal_ComputeBuffer_2(src, size, offset, &andCheckAccess);
    buffer2.SetScriptingCallback(callback);
    return buffer2;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    GraphicsBuffer src,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_1(src, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    GraphicsBuffer src,
    int size,
    int offset,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_GraphicsBuffer_2(src, size, offset, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex = default (int),
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_1(src, mipIndex, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex,
    TextureFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    return AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex,
    GraphicsFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncGPUReadback.ValidateFormat(src, dstFormat);
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_2(src, mipIndex, dstFormat, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    TextureFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    return AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, x, width, y, height, z, depth, GraphicsFormatUtility.GetGraphicsFormat(dstFormat, QualitySettings.activeColorSpace == ColorSpace.Linear), callback);
  }

  public static unsafe AsyncGPUReadbackRequest RequestIntoNativeSlice<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat,
    Il2CppSystem.Action<AsyncGPUReadbackRequest> callback = null)
    where T : struct
  {
    AsyncGPUReadback.ValidateFormat(src, dstFormat);
    AsyncRequestNativeArrayData andCheckAccess = AsyncRequestNativeArrayData.CreateAndCheckAccess<T>(output);
    AsyncGPUReadbackRequest gpuReadbackRequest = AsyncGPUReadback.Request_Internal_Texture_4(src, mipIndex, x, width, y, height, z, depth, dstFormat, &andCheckAccess);
    gpuReadbackRequest.SetScriptingCallback(callback);
    return gpuReadbackRequest;
  }

  public static unsafe AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_1(
    ComputeBuffer buffer,
    AsyncRequestNativeArrayData* data)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    AsyncGPUReadbackRequest ret;
    AsyncGPUReadback.Request_Internal_ComputeBuffer_1_Injected(native, data, out ret);
    return ret;
  }

  public static unsafe AsyncGPUReadbackRequest Request_Internal_ComputeBuffer_2(
    ComputeBuffer src,
    int size,
    int offset,
    AsyncRequestNativeArrayData* data)
  {
    if (src == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(src);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    AsyncGPUReadbackRequest ret;
    AsyncGPUReadback.Request_Internal_ComputeBuffer_2_Injected(native, size, offset, data, out ret);
    return ret;
  }

  public static unsafe AsyncGPUReadbackRequest Request_Internal_GraphicsBuffer_2(
    GraphicsBuffer src,
    int size,
    int offset,
    AsyncRequestNativeArrayData* data)
  {
    if (src == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(src);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    AsyncGPUReadbackRequest ret;
    AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_Injected(native, size, offset, data, out ret);
    return ret;
  }

  public static unsafe AsyncGPUReadbackRequest Request_Internal_Texture_1(
    Texture src,
    int mipIndex,
    AsyncRequestNativeArrayData* data)
  {
    if (src == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    System.IntPtr src1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Texture>(src);
    if (src1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    AsyncGPUReadbackRequest ret;
    AsyncGPUReadback.Request_Internal_Texture_1_Injected(src1, mipIndex, data, out ret);
    return ret;
  }

  public static unsafe AsyncGPUReadbackRequest Request_Internal_Texture_2(
    Texture src,
    int mipIndex,
    GraphicsFormat dstFormat,
    AsyncRequestNativeArrayData* data)
  {
    if (src == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    System.IntPtr src1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Texture>(src);
    if (src1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    AsyncGPUReadbackRequest ret;
    AsyncGPUReadback.Request_Internal_Texture_2_Injected(src1, mipIndex, dstFormat, data, out ret);
    return ret;
  }

  public static unsafe AsyncGPUReadbackRequest Request_Internal_Texture_3(
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    AsyncRequestNativeArrayData* data)
  {
    if (src == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    System.IntPtr src1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Texture>(src);
    if (src1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    AsyncGPUReadbackRequest ret;
    AsyncGPUReadback.Request_Internal_Texture_3_Injected(src1, mipIndex, x, width, y, height, z, depth, data, out ret);
    return ret;
  }

  public static unsafe AsyncGPUReadbackRequest Request_Internal_Texture_4(
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat,
    AsyncRequestNativeArrayData* data)
  {
    if (src == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    System.IntPtr src1 = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<Texture>(src);
    if (src1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) src, nameof (src));
    AsyncGPUReadbackRequest ret;
    AsyncGPUReadback.Request_Internal_Texture_4_Injected(src1, mipIndex, x, width, y, height, z, depth, dstFormat, data, out ret);
    return ret;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(ComputeBuffer src)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(
    ComputeBuffer src,
    int size,
    int offset)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, size, offset, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(GraphicsBuffer src)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(
    GraphicsBuffer src,
    int size,
    int offset)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, size, offset, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(Texture src, int mipIndex = default (int))
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, mipIndex, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(
    Texture src,
    int mipIndex,
    TextureFormat dstFormat)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, mipIndex, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(
    Texture src,
    int mipIndex,
    GraphicsFormat dstFormat)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, mipIndex, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    TextureFormat dstFormat)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestAsync(
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat)
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.Request(src, mipIndex, x, width, y, height, z, depth, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    ComputeBuffer src)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    ComputeBuffer src)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    ComputeBuffer src,
    int size,
    int offset)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, size, offset, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    ComputeBuffer src,
    int size,
    int offset)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, size, offset, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    GraphicsBuffer src)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    GraphicsBuffer src)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    GraphicsBuffer src,
    int size,
    int offset)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, size, offset, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    GraphicsBuffer src,
    int size,
    int offset)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, size, offset, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex = default (int))
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex = default (int))
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex,
    TextureFormat dstFormat)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex,
    TextureFormat dstFormat)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex,
    GraphicsFormat dstFormat)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex,
    GraphicsFormat dstFormat)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    TextureFormat dstFormat)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    TextureFormat dstFormat)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeArrayAsync<T>(
    ref NativeArray<T> output,
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeArray<T>(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static Awaitable<AsyncGPUReadbackRequest> RequestIntoNativeSliceAsync<T>(
    ref NativeSlice<T> output,
    Texture src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat)
    where T : struct
  {
    Awaitable<AsyncGPUReadbackRequest> managed = Awaitable<AsyncGPUReadbackRequest>.GetManaged();
    // ISSUE: method pointer
    AsyncGPUReadback.RequestIntoNativeSlice<T>(ref output, src, mipIndex, x, width, y, height, z, depth, dstFormat, new Il2CppSystem.Action<AsyncGPUReadbackRequest>((Il2CppSystem.Object) managed, __methodptr(SetResultAndRaiseContinuation)));
    return managed;
  }

  public static unsafe void Request_Internal_ComputeBuffer_1_Injected(
    System.IntPtr buffer,
    AsyncRequestNativeArrayData* data,
    out AsyncGPUReadbackRequest ret)
  {
    AsyncGPUReadback.Request_Internal_ComputeBuffer_1_InjectedDelegateField(buffer, (System.IntPtr) data, (System.IntPtr) ref ret);
  }

  public static unsafe void Request_Internal_ComputeBuffer_2_Injected(
    System.IntPtr src,
    int size,
    int offset,
    AsyncRequestNativeArrayData* data,
    out AsyncGPUReadbackRequest ret)
  {
    AsyncGPUReadback.Request_Internal_ComputeBuffer_2_InjectedDelegateField(src, size, offset, (System.IntPtr) data, (System.IntPtr) ref ret);
  }

  public static unsafe void Request_Internal_GraphicsBuffer_2_Injected(
    System.IntPtr src,
    int size,
    int offset,
    AsyncRequestNativeArrayData* data,
    out AsyncGPUReadbackRequest ret)
  {
    AsyncGPUReadback.Request_Internal_GraphicsBuffer_2_InjectedDelegateField(src, size, offset, (System.IntPtr) data, (System.IntPtr) ref ret);
  }

  public static unsafe void Request_Internal_Texture_1_Injected(
    System.IntPtr src,
    int mipIndex,
    AsyncRequestNativeArrayData* data,
    out AsyncGPUReadbackRequest ret)
  {
    AsyncGPUReadback.Request_Internal_Texture_1_InjectedDelegateField(src, mipIndex, (System.IntPtr) data, (System.IntPtr) ref ret);
  }

  public static unsafe void Request_Internal_Texture_2_Injected(
    System.IntPtr src,
    int mipIndex,
    GraphicsFormat dstFormat,
    AsyncRequestNativeArrayData* data,
    out AsyncGPUReadbackRequest ret)
  {
    AsyncGPUReadback.Request_Internal_Texture_2_InjectedDelegateField(src, mipIndex, dstFormat, (System.IntPtr) data, (System.IntPtr) ref ret);
  }

  public static unsafe void Request_Internal_Texture_3_Injected(
    System.IntPtr src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    AsyncRequestNativeArrayData* data,
    out AsyncGPUReadbackRequest ret)
  {
    AsyncGPUReadback.Request_Internal_Texture_3_InjectedDelegateField(src, mipIndex, x, width, y, height, z, depth, (System.IntPtr) data, (System.IntPtr) ref ret);
  }

  public static unsafe void Request_Internal_Texture_4_Injected(
    System.IntPtr src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat,
    AsyncRequestNativeArrayData* data,
    out AsyncGPUReadbackRequest ret)
  {
    AsyncGPUReadback.Request_Internal_Texture_4_InjectedDelegateField(src, mipIndex, x, width, y, height, z, depth, dstFormat, (System.IntPtr) data, (System.IntPtr) ref ret);
  }

  private delegate void WaitAllRequestsDelegate();

  private delegate void Request_Internal_ComputeBuffer_1_InjectedDelegate(
    System.IntPtr buffer,
    System.IntPtr data,
    [Out] System.IntPtr ret);

  private delegate void Request_Internal_ComputeBuffer_2_InjectedDelegate(
    System.IntPtr src,
    int size,
    int offset,
    System.IntPtr data,
    [Out] System.IntPtr ret);

  private delegate void Request_Internal_GraphicsBuffer_2_InjectedDelegate(
    System.IntPtr src,
    int size,
    int offset,
    System.IntPtr data,
    [Out] System.IntPtr ret);

  private delegate void Request_Internal_Texture_1_InjectedDelegate(
    System.IntPtr src,
    int mipIndex,
    System.IntPtr data,
    [Out] System.IntPtr ret);

  private delegate void Request_Internal_Texture_2_InjectedDelegate(
    System.IntPtr src,
    int mipIndex,
    GraphicsFormat dstFormat,
    System.IntPtr data,
    [Out] System.IntPtr ret);

  private delegate void Request_Internal_Texture_3_InjectedDelegate(
    System.IntPtr src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    System.IntPtr data,
    [Out] System.IntPtr ret);

  private delegate void Request_Internal_Texture_4_InjectedDelegate(
    System.IntPtr src,
    int mipIndex,
    int x,
    int width,
    int y,
    int height,
    int z,
    int depth,
    GraphicsFormat dstFormat,
    System.IntPtr data,
    [Out] System.IntPtr ret);
}
