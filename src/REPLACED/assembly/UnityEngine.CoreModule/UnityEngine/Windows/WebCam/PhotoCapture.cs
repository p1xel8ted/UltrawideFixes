// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.WebCam.PhotoCapture
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

public class PhotoCapture(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NativePtr;
  private static readonly System.IntPtr NativeFieldInfoPtr_HR_SUCCESS;
  private static readonly System.IntPtr NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0;
  private static readonly PhotoCapture.Instantiate_InternalDelegate Instantiate_InternalDelegateField;
  private static readonly PhotoCapture.GetSupportedResolutions_Internal_InjectedDelegate GetSupportedResolutions_Internal_InjectedDelegateField;
  private static readonly PhotoCapture.StopPhotoModeAsync_InjectedDelegate StopPhotoModeAsync_InjectedDelegateField;
  private static readonly PhotoCapture.CapturePhotoToDisk_Internal_InjectedDelegate CapturePhotoToDisk_Internal_InjectedDelegateField;
  private static readonly PhotoCapture.CapturePhotoToMemory_Internal_InjectedDelegate CapturePhotoToMemory_Internal_InjectedDelegateField;
  private static readonly PhotoCapture.GetUnsafePointerToVideoDeviceController_InjectedDelegate GetUnsafePointerToVideoDeviceController_InjectedDelegateField;

  static PhotoCapture()
  {
    Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", nameof (PhotoCapture));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr);
    PhotoCapture.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (m_NativePtr));
    PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (HR_SUCCESS));
    PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668984);
    PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668985);
    PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668987);
    PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668988);
    PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668989);
    PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668990);
    PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668991);
    PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668992);
    PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668993);
    PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668994);
    PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668995);
    PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, 100668996);
    PhotoCapture.Instantiate_InternalDelegateField = IL2CPP.ResolveICall<PhotoCapture.Instantiate_InternalDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::Instantiate_Internal");
    PhotoCapture.GetSupportedResolutions_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCapture.GetSupportedResolutions_Internal_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::GetSupportedResolutions_Internal_Injected");
    PhotoCapture.StopPhotoModeAsync_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCapture.StopPhotoModeAsync_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::StopPhotoModeAsync_Injected");
    PhotoCapture.CapturePhotoToDisk_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCapture.CapturePhotoToDisk_Internal_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::CapturePhotoToDisk_Internal_Injected");
    PhotoCapture.CapturePhotoToMemory_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCapture.CapturePhotoToMemory_Internal_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::CapturePhotoToMemory_Internal_Injected");
    PhotoCapture.GetUnsafePointerToVideoDeviceController_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCapture.GetUnsafePointerToVideoDeviceController_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCapture::GetUnsafePointerToVideoDeviceController_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472825, XrefRangeEnd = 472827, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PhotoCapture.PhotoCaptureResult MakeCaptureResult(long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &hResult
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_MakeCaptureResult_Private_Static_PhotoCaptureResult_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PhotoCapture.PhotoCaptureResult*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472827, XrefRangeEnd = 472831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnCreatedResourceDelegate(
    PhotoCapture.OnCaptureResourceCreatedCallback callback,
    System.IntPtr nativePtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nativePtr;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCreatedResourceDelegate_Private_Static_Void_OnCaptureResourceCreatedCallback_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472831, XrefRangeEnd = 472833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnPhotoModeStartedDelegate(
    PhotoCapture.OnPhotoModeStartedCallback callback,
    long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hResult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStartedDelegate_Private_Static_Void_OnPhotoModeStartedCallback_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnPhotoModeStoppedDelegate(
    PhotoCapture.OnPhotoModeStoppedCallback callback,
    long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hResult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnPhotoModeStoppedDelegate_Private_Static_Void_OnPhotoModeStoppedCallback_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnCapturedPhotoToDiskDelegate(
    PhotoCapture.OnCapturedToDiskCallback callback,
    long hResult)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hResult;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToDiskDelegate_Private_Static_Void_OnCapturedToDiskCallback_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472833, XrefRangeEnd = 472849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InvokeOnCapturedPhotoToMemoryDelegate(
    PhotoCapture.OnCapturedToMemoryCallback callback,
    long hResult,
    System.IntPtr photoCaptureFramePtr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hResult;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &photoCaptureFramePtr;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_InvokeOnCapturedPhotoToMemoryDelegate_Private_Static_Void_OnCapturedToMemoryCallback_Int64_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472849, XrefRangeEnd = 472855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472855, XrefRangeEnd = 472859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose_Internal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472859, XrefRangeEnd = 472864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PhotoCapture.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472864, XrefRangeEnd = 472868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisposeThreaded_Internal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472868, XrefRangeEnd = 472870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Dispose_Internal_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472870, XrefRangeEnd = 472872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DisposeThreaded_Internal_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCapture.NativeMethodInfoPtr_DisposeThreaded_Internal_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_NativePtr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCapture.NativeFieldInfoPtr_m_NativePtr)) = value;
    }
  }

  public static unsafe long HR_SUCCESS
  {
    get
    {
      long hrSuccess;
      IL2CPP.il2cpp_field_static_get_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*) &hrSuccess);
      return hrSuccess;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PhotoCapture.NativeFieldInfoPtr_HR_SUCCESS, (void*) &value);
    }
  }

  public static PhotoCapture.PhotoCaptureResult MakeCaptureResult(
    PhotoCapture.CaptureResultType resultType,
    long hResult)
  {
    return new PhotoCapture.PhotoCaptureResult()
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
      PhotoCapture.GetSupportedResolutions_Internal_Injected(out ret);
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

  public static void CreateAsync(
    bool showHolograms,
    PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
  {
    if (onCreatedCallback == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (onCreatedCallback));
    PhotoCapture.Instantiate_Internal(showHolograms, onCreatedCallback);
  }

  public static void CreateAsync(
    PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
  {
    if (onCreatedCallback == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (onCreatedCallback));
    PhotoCapture.Instantiate_Internal(false, onCreatedCallback);
  }

  public static System.IntPtr Instantiate_Internal(
    bool showHolograms,
    PhotoCapture.OnCaptureResourceCreatedCallback onCreatedCallback)
  {
    return PhotoCapture.Instantiate_InternalDelegateField(showHolograms, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onCreatedCallback));
  }

  public void StopPhotoModeAsync(
    PhotoCapture.OnPhotoModeStoppedCallback onPhotoModeStoppedCallback)
  {
    System.IntPtr native = PhotoCapture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    PhotoCapture.StopPhotoModeAsync_Injected(native, onPhotoModeStoppedCallback);
  }

  public void TakePhotoAsync(
    string filename,
    PhotoCaptureFileOutputFormat fileOutputFormat,
    PhotoCapture.OnCapturedToDiskCallback onCapturedPhotoToDiskCallback)
  {
    if (onCapturedPhotoToDiskCallback == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (onCapturedPhotoToDiskCallback));
    filename = !Il2CppSystem.String.IsNullOrEmpty(filename) ? filename.Replace("/", "\\") : throw new Il2CppSystem.ArgumentNullException(nameof (filename));
    string directoryName = Path.GetDirectoryName(filename);
    if (!Il2CppSystem.String.IsNullOrEmpty(directoryName) && !Directory.Exists(directoryName))
      throw new Il2CppSystem.ArgumentException("The specified directory does not exist.", nameof (filename));
    FileInfo fileInfo = new FileInfo(filename);
    if (fileInfo.Exists && fileInfo.IsReadOnly)
      throw new Il2CppSystem.ArgumentException("Cannot write to the file because it is read-only.", nameof (filename));
    this.CapturePhotoToDisk_Internal(filename, fileOutputFormat, onCapturedPhotoToDiskCallback);
  }

  public unsafe void CapturePhotoToDisk_Internal(
    string filename,
    PhotoCaptureFileOutputFormat fileOutputFormat,
    PhotoCapture.OnCapturedToDiskCallback onCapturedPhotoToDiskCallback)
  {
    try
    {
      System.IntPtr native = PhotoCapture.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(filename, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = filename.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      PhotoCapture.CapturePhotoToDisk_Internal_Injected(native, ref managedSpanWrapper, fileOutputFormat, onCapturedPhotoToDiskCallback);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void TakePhotoAsync(
    PhotoCapture.OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback)
  {
    if (onCapturedPhotoToMemoryCallback == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (onCapturedPhotoToMemoryCallback));
    this.CapturePhotoToMemory_Internal(onCapturedPhotoToMemoryCallback);
  }

  public void CapturePhotoToMemory_Internal(
    PhotoCapture.OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback)
  {
    System.IntPtr native = PhotoCapture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    PhotoCapture.CapturePhotoToMemory_Internal_Injected(native, onCapturedPhotoToMemoryCallback);
  }

  public System.IntPtr GetUnsafePointerToVideoDeviceController()
  {
    System.IntPtr native = PhotoCapture.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return PhotoCapture.GetUnsafePointerToVideoDeviceController_Injected(native);
  }

  public static void GetSupportedResolutions_Internal_Injected(out BlittableArrayWrapper ret)
  {
    PhotoCapture.GetSupportedResolutions_Internal_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void StopPhotoModeAsync_Injected(
    System.IntPtr _unity_self,
    PhotoCapture.OnPhotoModeStoppedCallback onPhotoModeStoppedCallback)
  {
    PhotoCapture.StopPhotoModeAsync_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onPhotoModeStoppedCallback));
  }

  public static void CapturePhotoToDisk_Internal_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper filename,
    PhotoCaptureFileOutputFormat fileOutputFormat,
    PhotoCapture.OnCapturedToDiskCallback onCapturedPhotoToDiskCallback)
  {
    PhotoCapture.CapturePhotoToDisk_Internal_InjectedDelegateField(_unity_self, (System.IntPtr) ref filename, fileOutputFormat, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onCapturedPhotoToDiskCallback));
  }

  public static void CapturePhotoToMemory_Internal_Injected(
    System.IntPtr _unity_self,
    PhotoCapture.OnCapturedToMemoryCallback onCapturedPhotoToMemoryCallback)
  {
    PhotoCapture.CapturePhotoToMemory_Internal_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onCapturedPhotoToMemoryCallback));
  }

  public static System.IntPtr GetUnsafePointerToVideoDeviceController_Injected(System.IntPtr _unity_self)
  {
    return PhotoCapture.GetUnsafePointerToVideoDeviceController_InjectedDelegateField(_unity_self);
  }

  public enum CaptureResultType
  {
    Success,
    UnknownError,
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct PhotoCaptureResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_resultType;
    private static readonly System.IntPtr NativeFieldInfoPtr_hResult;
    [FieldOffset(0)]
    public PhotoCapture.CaptureResultType resultType;
    [FieldOffset(8)]
    public long hResult;

    static PhotoCaptureResult()
    {
      Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (PhotoCaptureResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr);
      PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_resultType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, nameof (resultType));
      PhotoCapture.PhotoCaptureResult.NativeFieldInfoPtr_hResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, nameof (hResult));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhotoCapture.PhotoCaptureResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public sealed class OnCaptureResourceCreatedCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0;

    static OnCaptureResourceCreatedCallback()
    {
      Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (OnCaptureResourceCreatedCallback));
      PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100668997);
      PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr, 100668998);
    }

    [CallerCount(160 /*0xA0*/)]
    [CachedScanResults(RefRangeStart = 372139, RefRangeEnd = 372299, XrefRangeStart = 372139, XrefRangeEnd = 372299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnCaptureResourceCreatedCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCaptureResourceCreatedCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(PhotoCapture captureObject)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) captureObject)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCaptureResourceCreatedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCapture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PhotoCapture.OnCaptureResourceCreatedCallback(
      [In] System.Action<PhotoCapture> obj0)
    {
      return DelegateSupport.ConvertDelegate<PhotoCapture.OnCaptureResourceCreatedCallback>((System.Delegate) obj0);
    }

    public static PhotoCapture.OnCaptureResourceCreatedCallback operator +(
      [In] PhotoCapture.OnCaptureResourceCreatedCallback obj0,
      [In] PhotoCapture.OnCaptureResourceCreatedCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
    }

    public static PhotoCapture.OnCaptureResourceCreatedCallback operator -(
      [In] PhotoCapture.OnCaptureResourceCreatedCallback obj0,
      [In] PhotoCapture.OnCaptureResourceCreatedCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PhotoCapture.OnCaptureResourceCreatedCallback) @delegate : @delegate.Cast<PhotoCapture.OnCaptureResourceCreatedCallback>();
    }
  }

  public sealed class OnPhotoModeStartedCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

    static OnPhotoModeStartedCallback()
    {
      Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (OnPhotoModeStartedCallback));
      PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100668999);
      PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr, 100669000);
    }

    [CallerCount(60)]
    [CachedScanResults(RefRangeStart = 472761, RefRangeEnd = 472821, XrefRangeStart = 472759, XrefRangeEnd = 472761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnPhotoModeStartedCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStartedCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &result
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStartedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PhotoCapture.OnPhotoModeStartedCallback(
      [In] System.Action<PhotoCapture.PhotoCaptureResult> obj0)
    {
      return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStartedCallback>((System.Delegate) obj0);
    }

    public static PhotoCapture.OnPhotoModeStartedCallback operator +(
      [In] PhotoCapture.OnPhotoModeStartedCallback obj0,
      [In] PhotoCapture.OnPhotoModeStartedCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PhotoCapture.OnPhotoModeStartedCallback>();
    }

    public static PhotoCapture.OnPhotoModeStartedCallback operator -(
      [In] PhotoCapture.OnPhotoModeStartedCallback obj0,
      [In] PhotoCapture.OnPhotoModeStartedCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PhotoCapture.OnPhotoModeStartedCallback) @delegate : @delegate.Cast<PhotoCapture.OnPhotoModeStartedCallback>();
    }
  }

  public sealed class OnPhotoModeStoppedCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

    static OnPhotoModeStoppedCallback()
    {
      Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (OnPhotoModeStoppedCallback));
      PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100669001);
      PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr, 100669002);
    }

    [CallerCount(60)]
    [CachedScanResults(RefRangeStart = 472761, RefRangeEnd = 472821, XrefRangeStart = 472761, XrefRangeEnd = 472821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnPhotoModeStoppedCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnPhotoModeStoppedCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &result
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnPhotoModeStoppedCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PhotoCapture.OnPhotoModeStoppedCallback(
      [In] System.Action<PhotoCapture.PhotoCaptureResult> obj0)
    {
      return DelegateSupport.ConvertDelegate<PhotoCapture.OnPhotoModeStoppedCallback>((System.Delegate) obj0);
    }

    public static PhotoCapture.OnPhotoModeStoppedCallback operator +(
      [In] PhotoCapture.OnPhotoModeStoppedCallback obj0,
      [In] PhotoCapture.OnPhotoModeStoppedCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
    }

    public static PhotoCapture.OnPhotoModeStoppedCallback operator -(
      [In] PhotoCapture.OnPhotoModeStoppedCallback obj0,
      [In] PhotoCapture.OnPhotoModeStoppedCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PhotoCapture.OnPhotoModeStoppedCallback) @delegate : @delegate.Cast<PhotoCapture.OnPhotoModeStoppedCallback>();
    }
  }

  public sealed class OnCapturedToDiskCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0;

    static OnCapturedToDiskCallback()
    {
      Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (OnCapturedToDiskCallback));
      PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100669003);
      PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr, 100669004);
    }

    [CallerCount(60)]
    [CachedScanResults(RefRangeStart = 472761, RefRangeEnd = 472821, XrefRangeStart = 472761, XrefRangeEnd = 472821, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnCapturedToDiskCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToDiskCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(PhotoCapture.PhotoCaptureResult result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &result
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToDiskCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PhotoCapture.OnCapturedToDiskCallback(
      [In] System.Action<PhotoCapture.PhotoCaptureResult> obj0)
    {
      return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToDiskCallback>((System.Delegate) obj0);
    }

    public static PhotoCapture.OnCapturedToDiskCallback operator +(
      [In] PhotoCapture.OnCapturedToDiskCallback obj0,
      [In] PhotoCapture.OnCapturedToDiskCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PhotoCapture.OnCapturedToDiskCallback>();
    }

    public static PhotoCapture.OnCapturedToDiskCallback operator -(
      [In] PhotoCapture.OnCapturedToDiskCallback obj0,
      [In] PhotoCapture.OnCapturedToDiskCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PhotoCapture.OnCapturedToDiskCallback) @delegate : @delegate.Cast<PhotoCapture.OnCapturedToDiskCallback>();
    }
  }

  public sealed class OnCapturedToMemoryCallback(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0;

    static OnCapturedToMemoryCallback()
    {
      Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (OnCapturedToMemoryCallback));
      PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100669005);
      PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr, 100669006);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 472823, RefRangeEnd = 472825, XrefRangeStart = 472821, XrefRangeEnd = 472823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnCapturedToMemoryCallback(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhotoCapture.OnCapturedToMemoryCallback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(
      PhotoCapture.PhotoCaptureResult result,
      PhotoCaptureFrame photoCaptureFrame)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) photoCaptureFrame);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCapture.OnCapturedToMemoryCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PhotoCaptureResult_PhotoCaptureFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PhotoCapture.OnCapturedToMemoryCallback(
      [In] System.Action<PhotoCapture.PhotoCaptureResult, PhotoCaptureFrame> obj0)
    {
      return DelegateSupport.ConvertDelegate<PhotoCapture.OnCapturedToMemoryCallback>((System.Delegate) obj0);
    }

    public static PhotoCapture.OnCapturedToMemoryCallback operator +(
      [In] PhotoCapture.OnCapturedToMemoryCallback obj0,
      [In] PhotoCapture.OnCapturedToMemoryCallback obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PhotoCapture.OnCapturedToMemoryCallback>();
    }

    public static PhotoCapture.OnCapturedToMemoryCallback operator -(
      [In] PhotoCapture.OnCapturedToMemoryCallback obj0,
      [In] PhotoCapture.OnCapturedToMemoryCallback obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PhotoCapture.OnCapturedToMemoryCallback) @delegate : @delegate.Cast<PhotoCapture.OnCapturedToMemoryCallback>();
    }
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCapture_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<PhotoCapture.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCapture>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCapture.BindingsMarshaller>.NativeClassPtr);
      PhotoCapture.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCapture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCapture.BindingsMarshaller>.NativeClassPtr, 100669007);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(PhotoCapture photoCapture)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) photoCapture)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCapture.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCapture_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  private delegate System.IntPtr Instantiate_InternalDelegate(
    bool showHolograms,
    System.IntPtr onCreatedCallback);

  private delegate void GetSupportedResolutions_Internal_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void StopPhotoModeAsync_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr onPhotoModeStoppedCallback);

  private delegate void CapturePhotoToDisk_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr filename,
    PhotoCaptureFileOutputFormat fileOutputFormat,
    System.IntPtr onCapturedPhotoToDiskCallback);

  private delegate void CapturePhotoToMemory_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr onCapturedPhotoToMemoryCallback);

  private delegate System.IntPtr GetUnsafePointerToVideoDeviceController_InjectedDelegate(
    System.IntPtr _unity_self);
}
