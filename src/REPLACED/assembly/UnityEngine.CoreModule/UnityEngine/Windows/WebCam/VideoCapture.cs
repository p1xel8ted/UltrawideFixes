// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.WebCam.VideoCapture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Windows.WebCam;

public class VideoCapture(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NativePtr;
  private static readonly System.IntPtr NativeFieldInfoPtr_HR_SUCCESS;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0;
  private static readonly VideoCapture.Instantiate_InternalDelegate Instantiate_InternalDelegateField;
  private static readonly VideoCapture.GetSupportedResolutions_Internal_InjectedDelegate GetSupportedResolutions_Internal_InjectedDelegateField;
  private static readonly VideoCapture.GetSupportedFrameRatesForResolution_Internal_InjectedDelegate GetSupportedFrameRatesForResolution_Internal_InjectedDelegateField;
  private static readonly VideoCapture.get_IsRecording_InjectedDelegate get_IsRecording_InjectedDelegateField;
  private static readonly VideoCapture.StopVideoModeAsync_InjectedDelegate StopVideoModeAsync_InjectedDelegateField;
  private static readonly VideoCapture.StartRecordingVideoToDisk_Internal_InjectedDelegate StartRecordingVideoToDisk_Internal_InjectedDelegateField;
  private static readonly VideoCapture.StopRecordingAsync_InjectedDelegate StopRecordingAsync_InjectedDelegateField;
  private static readonly VideoCapture.GetUnsafePointerToVideoDeviceController_InjectedDelegate GetUnsafePointerToVideoDeviceController_InjectedDelegateField;

  static VideoCapture()
  {
    Il2CppClassPointerStore<VideoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", nameof (VideoCapture));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr);
    VideoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (m_NativePtr));
    VideoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (HR_SUCCESS));
    VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669025);
    VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669026);
    VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669028);
    VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669029);
    VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669030);
    VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669031);
    VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669032);
    VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669033);
    VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669034);
    VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669035);
    VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669036);
    VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, 100669037);
    VideoCapture.Instantiate_InternalDelegateField = IL2CPP.ResolveICall<VideoCapture.Instantiate_InternalDelegate>("UnityEngine.Windows.WebCam.VideoCapture::Instantiate_Internal");
    VideoCapture.GetSupportedResolutions_Internal_InjectedDelegateField = IL2CPP.ResolveICall<VideoCapture.GetSupportedResolutions_Internal_InjectedDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetSupportedResolutions_Internal_Injected");
    VideoCapture.GetSupportedFrameRatesForResolution_Internal_InjectedDelegateField = IL2CPP.ResolveICall<VideoCapture.GetSupportedFrameRatesForResolution_Internal_InjectedDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetSupportedFrameRatesForResolution_Internal_Injected");
    VideoCapture.get_IsRecording_InjectedDelegateField = IL2CPP.ResolveICall<VideoCapture.get_IsRecording_InjectedDelegate>("UnityEngine.Windows.WebCam.VideoCapture::get_IsRecording_Injected");
    VideoCapture.StopVideoModeAsync_InjectedDelegateField = IL2CPP.ResolveICall<VideoCapture.StopVideoModeAsync_InjectedDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StopVideoModeAsync_Injected");
    VideoCapture.StartRecordingVideoToDisk_Internal_InjectedDelegateField = IL2CPP.ResolveICall<VideoCapture.StartRecordingVideoToDisk_Internal_InjectedDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StartRecordingVideoToDisk_Internal_Injected");
    VideoCapture.StopRecordingAsync_InjectedDelegateField = IL2CPP.ResolveICall<VideoCapture.StopRecordingAsync_InjectedDelegate>("UnityEngine.Windows.WebCam.VideoCapture::StopRecordingAsync_Injected");
    VideoCapture.GetUnsafePointerToVideoDeviceController_InjectedDelegateField = IL2CPP.ResolveICall<VideoCapture.GetUnsafePointerToVideoDeviceController_InjectedDelegate>("UnityEngine.Windows.WebCam.VideoCapture::GetUnsafePointerToVideoDeviceController_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472925, XrefRangeEnd = 472927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe VideoCapture.VideoCaptureResult MakeCaptureResult(long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &hResult
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_VideoCaptureResult_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(VideoCapture.VideoCaptureResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472927, XrefRangeEnd = 472931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnCreatedVideoCaptureResourceDelegate(
    VideoCapture.OnVideoCaptureResourceCreatedCallback callback,
    System.IntPtr nativePtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nativePtr;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnCreatedVideoCaptureResourceDelegate_Private_Static_Void_OnVideoCaptureResourceCreatedCallback_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472931, XrefRangeEnd = 472933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnVideoModeStartedDelegate(
    VideoCapture.OnVideoModeStartedCallback callback,
    long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hResult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStartedDelegate_Private_Static_Void_OnVideoModeStartedCallback_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnVideoModeStoppedDelegate(
    VideoCapture.OnVideoModeStoppedCallback callback,
    long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hResult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnVideoModeStoppedDelegate_Private_Static_Void_OnVideoModeStoppedCallback_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnStartedRecordingVideoToDiskDelegate(
    VideoCapture.OnStartedRecordingVideoCallback callback,
    long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hResult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStartedRecordingVideoToDiskDelegate_Private_Static_Void_OnStartedRecordingVideoCallback_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnStoppedRecordingVideoToDiskDelegate(
    VideoCapture.OnStoppedRecordingVideoCallback callback,
    long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hResult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_InvokeOnStoppedRecordingVideoToDiskDelegate_Private_Static_Void_OnStoppedRecordingVideoCallback_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472933, XrefRangeEnd = 472939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472939, XrefRangeEnd = 472943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose_Internal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472943, XrefRangeEnd = 472948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VideoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472948, XrefRangeEnd = 472952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisposeThreaded_Internal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472952, XrefRangeEnd = 472954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Dispose_Internal_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472954, XrefRangeEnd = 472956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DisposeThreaded_Internal_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VideoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_NativePtr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VideoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
    }
  }

  public static unsafe long HR_SUCCESS
  {
    get
    {
      long hrSuccess;
      IL2CPP.il2cpp_field_static_get_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*) &hrSuccess);
      return hrSuccess;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VideoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*) &value);
    }
  }

  public static VideoCapture.VideoCaptureResult MakeCaptureResult(
    VideoCapture.CaptureResultType resultType,
    long hResult)
  {
    return new VideoCapture.VideoCaptureResult()
    {
      resultType = resultType,
      hResult = hResult
    };
  }

  public static IEnumerable<Resolution> SupportedResolutions
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Il2CppStructArray<Resolution> GetSupportedResolutions_Internal()
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<Resolution> resolutionsInternal;
    try
    {
      VideoCapture.GetSupportedResolutions_Internal_Injected(out ret);
    }
    finally
    {
      Il2CppStructArray<Resolution> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<Resolution>((Il2CppArrayBase<Resolution>&) ref il2CppStructArray);
      resolutionsInternal = il2CppStructArray;
    }
    return resolutionsInternal;
  }

  public static IEnumerable<float> GetSupportedFrameRatesForResolution(Resolution resolution)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static Il2CppStructArray<float> GetSupportedFrameRatesForResolution_Internal(
    int resolutionWidth,
    int resolutionHeight)
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<float> resolutionInternal;
    try
    {
      VideoCapture.GetSupportedFrameRatesForResolution_Internal_Injected(resolutionWidth, resolutionHeight, out ret);
    }
    finally
    {
      Il2CppStructArray<float> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<float>((Il2CppArrayBase<float>&) ref il2CppStructArray);
      resolutionInternal = il2CppStructArray;
    }
    return resolutionInternal;
  }

  public bool IsRecording
  {
    get
    {
      System.IntPtr native = VideoCapture.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return VideoCapture.get_IsRecording_Injected(native);
    }
  }

  public static void CreateAsync(
    bool showHolograms,
    VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
  {
    if (onCreatedCallback == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (onCreatedCallback));
    VideoCapture.Instantiate_Internal(showHolograms, onCreatedCallback);
  }

  public static void CreateAsync(
    VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
  {
    if (onCreatedCallback == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (onCreatedCallback));
    VideoCapture.Instantiate_Internal(false, onCreatedCallback);
  }

  public static void Instantiate_Internal(
    bool showHolograms,
    VideoCapture.OnVideoCaptureResourceCreatedCallback onCreatedCallback)
  {
    VideoCapture.Instantiate_InternalDelegateField(showHolograms, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onCreatedCallback));
  }

  public void StopVideoModeAsync(
    VideoCapture.OnVideoModeStoppedCallback onVideoModeStoppedCallback)
  {
    if (onVideoModeStoppedCallback == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) onVideoModeStoppedCallback, nameof (onVideoModeStoppedCallback));
    System.IntPtr native = VideoCapture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    VideoCapture.StopVideoModeAsync_Injected(native, onVideoModeStoppedCallback);
  }

  public void StartRecordingAsync(
    string filename,
    VideoCapture.OnStartedRecordingVideoCallback onStartedRecordingVideoCallback)
  {
    if (onStartedRecordingVideoCallback == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (onStartedRecordingVideoCallback));
    string path = !Il2CppSystem.String.IsNullOrEmpty(filename) ? Path.GetDirectoryName(filename) : throw new Il2CppSystem.ArgumentNullException(nameof (filename));
    if (!Il2CppSystem.String.IsNullOrEmpty(path) && !Directory.Exists(path))
      throw new Il2CppSystem.ArgumentException("The specified directory does not exist.", nameof (filename));
    FileInfo fileInfo = new FileInfo(filename);
    if (fileInfo.Exists && fileInfo.IsReadOnly)
      throw new Il2CppSystem.ArgumentException("Cannot write to the file because it is read-only.", nameof (filename));
    this.StartRecordingVideoToDisk_Internal(fileInfo.FullName, onStartedRecordingVideoCallback);
  }

  public unsafe void StartRecordingVideoToDisk_Internal(
    string filename,
    VideoCapture.OnStartedRecordingVideoCallback onStartedRecordingVideoCallback)
  {
    try
    {
      System.IntPtr native = VideoCapture.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(filename, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = filename.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      VideoCapture.StartRecordingVideoToDisk_Internal_Injected(native, ref managedSpanWrapper, onStartedRecordingVideoCallback);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void StopRecordingAsync(
    VideoCapture.OnStoppedRecordingVideoCallback onStoppedRecordingVideoCallback)
  {
    if (onStoppedRecordingVideoCallback == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) onStoppedRecordingVideoCallback, nameof (onStoppedRecordingVideoCallback));
    System.IntPtr native = VideoCapture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    VideoCapture.StopRecordingAsync_Injected(native, onStoppedRecordingVideoCallback);
  }

  public System.IntPtr GetUnsafePointerToVideoDeviceController()
  {
    System.IntPtr native = VideoCapture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return VideoCapture.GetUnsafePointerToVideoDeviceController_Injected(native);
  }

  public static void GetSupportedResolutions_Internal_Injected(out BlittableArrayWrapper ret)
  {
    VideoCapture.GetSupportedResolutions_Internal_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void GetSupportedFrameRatesForResolution_Internal_Injected(
    int resolutionWidth,
    int resolutionHeight,
    out BlittableArrayWrapper ret)
  {
    VideoCapture.GetSupportedFrameRatesForResolution_Internal_InjectedDelegateField(resolutionWidth, resolutionHeight, (System.IntPtr) ref ret);
  }

  public static bool get_IsRecording_Injected(System.IntPtr _unity_self)
  {
    return VideoCapture.get_IsRecording_InjectedDelegateField(_unity_self);
  }

  public static void StopVideoModeAsync_Injected(
    System.IntPtr _unity_self,
    VideoCapture.OnVideoModeStoppedCallback onVideoModeStoppedCallback)
  {
    VideoCapture.StopVideoModeAsync_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onVideoModeStoppedCallback));
  }

  public static void StartRecordingVideoToDisk_Internal_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper filename,
    VideoCapture.OnStartedRecordingVideoCallback onStartedRecordingVideoCallback)
  {
    VideoCapture.StartRecordingVideoToDisk_Internal_InjectedDelegateField(_unity_self, (System.IntPtr) ref filename, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onStartedRecordingVideoCallback));
  }

  public static void StopRecordingAsync_Injected(
    System.IntPtr _unity_self,
    VideoCapture.OnStoppedRecordingVideoCallback onStoppedRecordingVideoCallback)
  {
    VideoCapture.StopRecordingAsync_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onStoppedRecordingVideoCallback));
  }

  public static System.IntPtr GetUnsafePointerToVideoDeviceController_Injected(System.IntPtr _unity_self)
  {
    return VideoCapture.GetUnsafePointerToVideoDeviceController_InjectedDelegateField(_unity_self);
  }

  public enum CaptureResultType
  {
    Success,
    UnknownError,
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct VideoCaptureResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_resultType;
    private static readonly System.IntPtr NativeFieldInfoPtr_hResult;
    [FieldOffset(0)]
    public VideoCapture.CaptureResultType resultType;
    [FieldOffset(8)]
    public long hResult;

    static VideoCaptureResult()
    {
      Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (VideoCaptureResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr);
      VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, nameof (resultType));
      VideoCapture.VideoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, nameof (hResult));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VideoCapture.VideoCaptureResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public sealed class OnVideoCaptureResourceCreatedCallback(System.IntPtr pointer) : 
    Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0;

    static OnVideoCaptureResourceCreatedCallback()
    {
      Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (OnVideoCaptureResourceCreatedCallback));
      VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100669038);
      VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr, 100669039);
    }

    [CallerCount(160 /*0xA0*/)]
    [CachedScanResults(RefRangeStart = 372139, RefRangeEnd = 372299, XrefRangeStart = 372139, XrefRangeEnd = 372299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnVideoCaptureResourceCreatedCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoCaptureResourceCreatedCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(VideoCapture captureObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) captureObject)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator VideoCapture.OnVideoCaptureResourceCreatedCallback(
      [In] System.Action<VideoCapture> obj0)
    {
      return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoCaptureResourceCreatedCallback>((System.Delegate) obj0);
    }

    public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator +(
      [In] VideoCapture.OnVideoCaptureResourceCreatedCallback obj0,
      [In] VideoCapture.OnVideoCaptureResourceCreatedCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
    }

    public static VideoCapture.OnVideoCaptureResourceCreatedCallback operator -(
      [In] VideoCapture.OnVideoCaptureResourceCreatedCallback obj0,
      [In] VideoCapture.OnVideoCaptureResourceCreatedCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (VideoCapture.OnVideoCaptureResourceCreatedCallback) @delegate : @delegate.Cast<VideoCapture.OnVideoCaptureResourceCreatedCallback>();
    }
  }

  public sealed class OnVideoModeStartedCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

    static OnVideoModeStartedCallback()
    {
      Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (OnVideoModeStartedCallback));
      VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100669040);
      VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr, 100669041);
    }

    [CallerCount(60)]
    [CachedScanResults(RefRangeStart = 472761, RefRangeEnd = 472821, XrefRangeStart = 472761, XrefRangeEnd = 472821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnVideoModeStartedCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStartedCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(VideoCapture.VideoCaptureResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &result
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator VideoCapture.OnVideoModeStartedCallback(
      [In] System.Action<VideoCapture.VideoCaptureResult> obj0)
    {
      return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStartedCallback>((System.Delegate) obj0);
    }

    public static VideoCapture.OnVideoModeStartedCallback operator +(
      [In] VideoCapture.OnVideoModeStartedCallback obj0,
      [In] VideoCapture.OnVideoModeStartedCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<VideoCapture.OnVideoModeStartedCallback>();
    }

    public static VideoCapture.OnVideoModeStartedCallback operator -(
      [In] VideoCapture.OnVideoModeStartedCallback obj0,
      [In] VideoCapture.OnVideoModeStartedCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (VideoCapture.OnVideoModeStartedCallback) @delegate : @delegate.Cast<VideoCapture.OnVideoModeStartedCallback>();
    }
  }

  public sealed class OnVideoModeStoppedCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

    static OnVideoModeStoppedCallback()
    {
      Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (OnVideoModeStoppedCallback));
      VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100669042);
      VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr, 100669043);
    }

    [CallerCount(60)]
    [CachedScanResults(RefRangeStart = 472761, RefRangeEnd = 472821, XrefRangeStart = 472761, XrefRangeEnd = 472821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnVideoModeStoppedCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnVideoModeStoppedCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(VideoCapture.VideoCaptureResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &result
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnVideoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator VideoCapture.OnVideoModeStoppedCallback(
      [In] System.Action<VideoCapture.VideoCaptureResult> obj0)
    {
      return DelegateSupport.ConvertDelegate<VideoCapture.OnVideoModeStoppedCallback>((System.Delegate) obj0);
    }

    public static VideoCapture.OnVideoModeStoppedCallback operator +(
      [In] VideoCapture.OnVideoModeStoppedCallback obj0,
      [In] VideoCapture.OnVideoModeStoppedCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<VideoCapture.OnVideoModeStoppedCallback>();
    }

    public static VideoCapture.OnVideoModeStoppedCallback operator -(
      [In] VideoCapture.OnVideoModeStoppedCallback obj0,
      [In] VideoCapture.OnVideoModeStoppedCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (VideoCapture.OnVideoModeStoppedCallback) @delegate : @delegate.Cast<VideoCapture.OnVideoModeStoppedCallback>();
    }
  }

  public sealed class OnStartedRecordingVideoCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

    static OnStartedRecordingVideoCallback()
    {
      Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (OnStartedRecordingVideoCallback));
      VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100669044);
      VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr, 100669045);
    }

    [CallerCount(60)]
    [CachedScanResults(RefRangeStart = 472761, RefRangeEnd = 472821, XrefRangeStart = 472761, XrefRangeEnd = 472821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnStartedRecordingVideoCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStartedRecordingVideoCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(VideoCapture.VideoCaptureResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &result
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStartedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator VideoCapture.OnStartedRecordingVideoCallback(
      [In] System.Action<VideoCapture.VideoCaptureResult> obj0)
    {
      return DelegateSupport.ConvertDelegate<VideoCapture.OnStartedRecordingVideoCallback>((System.Delegate) obj0);
    }

    public static VideoCapture.OnStartedRecordingVideoCallback operator +(
      [In] VideoCapture.OnStartedRecordingVideoCallback obj0,
      [In] VideoCapture.OnStartedRecordingVideoCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<VideoCapture.OnStartedRecordingVideoCallback>();
    }

    public static VideoCapture.OnStartedRecordingVideoCallback operator -(
      [In] VideoCapture.OnStartedRecordingVideoCallback obj0,
      [In] VideoCapture.OnStartedRecordingVideoCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (VideoCapture.OnStartedRecordingVideoCallback) @delegate : @delegate.Cast<VideoCapture.OnStartedRecordingVideoCallback>();
    }
  }

  public sealed class OnStoppedRecordingVideoCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0;

    static OnStoppedRecordingVideoCallback()
    {
      Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (OnStoppedRecordingVideoCallback));
      VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100669046);
      VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr, 100669047);
    }

    [CallerCount(60)]
    [CachedScanResults(RefRangeStart = 472761, RefRangeEnd = 472821, XrefRangeStart = 472761, XrefRangeEnd = 472821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnStoppedRecordingVideoCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VideoCapture.OnStoppedRecordingVideoCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(VideoCapture.VideoCaptureResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &result
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VideoCapture.OnStoppedRecordingVideoCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_VideoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator VideoCapture.OnStoppedRecordingVideoCallback(
      [In] System.Action<VideoCapture.VideoCaptureResult> obj0)
    {
      return DelegateSupport.ConvertDelegate<VideoCapture.OnStoppedRecordingVideoCallback>((System.Delegate) obj0);
    }

    public static VideoCapture.OnStoppedRecordingVideoCallback operator +(
      [In] VideoCapture.OnStoppedRecordingVideoCallback obj0,
      [In] VideoCapture.OnStoppedRecordingVideoCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
    }

    public static VideoCapture.OnStoppedRecordingVideoCallback operator -(
      [In] VideoCapture.OnStoppedRecordingVideoCallback obj0,
      [In] VideoCapture.OnStoppedRecordingVideoCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (VideoCapture.OnStoppedRecordingVideoCallback) @delegate : @delegate.Cast<VideoCapture.OnStoppedRecordingVideoCallback>();
    }
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VideoCapture_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<VideoCapture.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VideoCapture>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VideoCapture.BindingsMarshaller>.NativeClassPtr);
      VideoCapture.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VideoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VideoCapture.BindingsMarshaller>.NativeClassPtr, 100669048);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(VideoCapture videoCapture)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) videoCapture)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VideoCapture.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_VideoCapture_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  public enum AudioState
  {
    MicAudio,
    ApplicationAudio,
    ApplicationAndMicAudio,
    None,
  }

  private delegate void Instantiate_InternalDelegate(bool showHolograms, System.IntPtr onCreatedCallback);

  private delegate void GetSupportedResolutions_Internal_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void GetSupportedFrameRatesForResolution_Internal_InjectedDelegate(
    int resolutionWidth,
    int resolutionHeight,
    [Out] System.IntPtr ret);

  private delegate bool get_IsRecording_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void StopVideoModeAsync_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr onVideoModeStoppedCallback);

  private delegate void StartRecordingVideoToDisk_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr filename,
    System.IntPtr onStartedRecordingVideoCallback);

  private delegate void StopRecordingAsync_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr onStoppedRecordingVideoCallback);

  private delegate System.IntPtr GetUnsafePointerToVideoDeviceController_InjectedDelegate(
    System.IntPtr _unity_self);
}
