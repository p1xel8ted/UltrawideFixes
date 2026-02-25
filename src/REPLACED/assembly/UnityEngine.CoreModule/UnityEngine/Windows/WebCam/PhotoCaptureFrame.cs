// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.WebCam.PhotoCaptureFrame
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Windows.WebCam;

public sealed class PhotoCaptureFrame(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NativePtr;
  private static readonly System.IntPtr NativeFieldInfoPtr__dataLength_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__hasLocationData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__pixelFormat_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataLength_Private_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDataLength_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHasLocationData_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCapturePixelFormat_Injected_Private_Static_CapturePixelFormat_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0;
  private static readonly PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegate GetCameraToWorldMatrix_InjectedDelegateField;
  private static readonly PhotoCaptureFrame.GetProjection_InjectedDelegate GetProjection_InjectedDelegateField;
  private static readonly PhotoCaptureFrame.UploadImageDataToTexture_Internal_InjectedDelegate UploadImageDataToTexture_Internal_InjectedDelegateField;
  private static readonly PhotoCaptureFrame.GetUnsafePointerToBuffer_InjectedDelegate GetUnsafePointerToBuffer_InjectedDelegateField;
  private static readonly PhotoCaptureFrame.CopyRawImageDataIntoBuffer_Internal_InjectedDelegate CopyRawImageDataIntoBuffer_Internal_InjectedDelegateField;

  static PhotoCaptureFrame()
  {
    Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.WebCam", nameof (PhotoCaptureFrame));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr);
    PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, nameof (m_NativePtr));
    PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<dataLength>k__BackingField");
    PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<hasLocationData>k__BackingField");
    PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, "<pixelFormat>k__BackingField");
    PhotoCaptureFrame.NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669008);
    PhotoCaptureFrame.NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669009);
    PhotoCaptureFrame.NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669010);
    PhotoCaptureFrame.NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669011);
    PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669012);
    PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669013);
    PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669014);
    PhotoCaptureFrame.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669016);
    PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669017);
    PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669018);
    PhotoCaptureFrame.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669019);
    PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669020);
    PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669021);
    PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Injected_Private_Static_CapturePixelFormat_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669022);
    PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, 100669023);
    PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetCameraToWorldMatrix_Injected");
    PhotoCaptureFrame.GetProjection_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetProjection_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetProjection_Injected");
    PhotoCaptureFrame.UploadImageDataToTexture_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.UploadImageDataToTexture_Internal_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::UploadImageDataToTexture_Internal_Injected");
    PhotoCaptureFrame.GetUnsafePointerToBuffer_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.GetUnsafePointerToBuffer_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::GetUnsafePointerToBuffer_Injected");
    PhotoCaptureFrame.CopyRawImageDataIntoBuffer_Internal_InjectedDelegateField = IL2CPP.ResolveICall<PhotoCaptureFrame.CopyRawImageDataIntoBuffer_Internal_InjectedDelegate>("UnityEngine.Windows.WebCam.PhotoCaptureFrame::CopyRawImageDataIntoBuffer_Internal_Injected");
  }

  public unsafe int dataLength
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_get_dataLength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_dataLength_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool hasLocationData
  {
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_hasLocationData_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._hasLocationData_k__BackingField;
  }

  public unsafe CapturePixelFormat pixelFormat
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_set_pixelFormat_Private_set_Void_CapturePixelFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._pixelFormat_k__BackingField;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472872, XrefRangeEnd = 472876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int GetDataLength()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472876, XrefRangeEnd = 472892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetHasLocationData()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472892, XrefRangeEnd = 472896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CapturePixelFormat GetCapturePixelFormat()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Private_CapturePixelFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(CapturePixelFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 472902, RefRangeEnd = 472904, XrefRangeStart = 472896, XrefRangeEnd = 472902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Cleanup()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472904, XrefRangeEnd = 472908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose_Internal()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472908, XrefRangeEnd = 472913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472913, XrefRangeEnd = 472917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472917, XrefRangeEnd = 472919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetDataLength_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetDataLength_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472919, XrefRangeEnd = 472921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetHasLocationData_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetHasLocationData_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472921, XrefRangeEnd = 472923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe CapturePixelFormat GetCapturePixelFormat_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_GetCapturePixelFormat_Injected_Private_Static_CapturePixelFormat_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(CapturePixelFormat*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472923, XrefRangeEnd = 472925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Dispose_Internal_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.NativeMethodInfoPtr_Dispose_Internal_Injected_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_NativePtr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr_m_NativePtr)) = value;
    }
  }

  public unsafe int _dataLength_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__dataLength_k__BackingField)) = value;
    }
  }

  public unsafe bool _hasLocationData_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__hasLocationData_k__BackingField)) = value;
    }
  }

  public unsafe CapturePixelFormat _pixelFormat_k__BackingField
  {
    get
    {
      return *(CapturePixelFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField));
    }
    [param: In] set
    {
      *(CapturePixelFormat*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhotoCaptureFrame.NativeFieldInfoPtr__pixelFormat_k__BackingField)) = value;
    }
  }

  public bool TryGetCameraToWorldMatrix(out Matrix4x4 cameraToWorldMatrix)
  {
    cameraToWorldMatrix = Matrix4x4.identity;
    return false;
  }

  public Matrix4x4 GetCameraToWorldMatrix()
  {
    System.IntPtr native = PhotoCaptureFrame.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Matrix4x4 ret;
    PhotoCaptureFrame.GetCameraToWorldMatrix_Injected(native, out ret);
    return ret;
  }

  public bool TryGetProjectionMatrix(out Matrix4x4 projectionMatrix)
  {
    projectionMatrix = Matrix4x4.identity;
    return false;
  }

  public bool TryGetProjectionMatrix(
    float nearClipPlane,
    float farClipPlane,
    out Matrix4x4 projectionMatrix)
  {
    if (this.hasLocationData)
    {
      float num1 = 0.01f;
      if ((double) nearClipPlane < (double) num1)
        nearClipPlane = num1;
      if ((double) farClipPlane < (double) nearClipPlane + (double) num1)
        farClipPlane = nearClipPlane + num1;
      projectionMatrix = this.GetProjection();
      float num2 = (float) (1.0 / ((double) farClipPlane - (double) nearClipPlane));
      float num3 = (float) -((double) farClipPlane + (double) nearClipPlane) * num2;
      float num4 = (float) -(2.0 * (double) farClipPlane * (double) nearClipPlane) * num2;
      projectionMatrix.m22 = num3;
      projectionMatrix.m23 = num4;
      return true;
    }
    projectionMatrix = Matrix4x4.identity;
    return false;
  }

  public Matrix4x4 GetProjection()
  {
    System.IntPtr native = PhotoCaptureFrame.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Matrix4x4 ret;
    PhotoCaptureFrame.GetProjection_Injected(native, out ret);
    return ret;
  }

  public void UploadImageDataToTexture(Texture2D targetTexture)
  {
    if ((UnityEngine.Object) targetTexture == (UnityEngine.Object) null)
      throw new Il2CppSystem.ArgumentNullException(nameof (targetTexture));
    if (this.pixelFormat != 0)
      throw new Il2CppSystem.ArgumentException("Uploading PhotoCaptureFrame to a texture is only supported with BGRA32 CameraFrameFormat!");
    this.UploadImageDataToTexture_Internal(targetTexture);
  }

  public void UploadImageDataToTexture_Internal(Texture2D targetTexture)
  {
    System.IntPtr native = PhotoCaptureFrame.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    PhotoCaptureFrame.UploadImageDataToTexture_Internal_Injected(native, UnityEngine.Object.MarshalledUnityObject.Marshal<Texture2D>(targetTexture));
  }

  public System.IntPtr GetUnsafePointerToBuffer()
  {
    System.IntPtr native = PhotoCaptureFrame.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return PhotoCaptureFrame.GetUnsafePointerToBuffer_Injected(native);
  }

  public void CopyRawImageDataIntoBuffer(List<byte> byteBuffer)
  {
  }

  public void CopyRawImageDataIntoBuffer_Internal([Out] Il2CppStructArray<byte> byteArray)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void GetCameraToWorldMatrix_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
  {
    PhotoCaptureFrame.GetCameraToWorldMatrix_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void GetProjection_Injected(System.IntPtr _unity_self, out Matrix4x4 ret)
  {
    PhotoCaptureFrame.GetProjection_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static void UploadImageDataToTexture_Internal_Injected(
    System.IntPtr _unity_self,
    System.IntPtr targetTexture)
  {
    PhotoCaptureFrame.UploadImageDataToTexture_Internal_InjectedDelegateField(_unity_self, targetTexture);
  }

  public static System.IntPtr GetUnsafePointerToBuffer_Injected(System.IntPtr _unity_self)
  {
    return PhotoCaptureFrame.GetUnsafePointerToBuffer_InjectedDelegateField(_unity_self);
  }

  public static void CopyRawImageDataIntoBuffer_Internal_Injected(
    System.IntPtr _unity_self,
    out BlittableArrayWrapper byteArray)
  {
    PhotoCaptureFrame.CopyRawImageDataIntoBuffer_Internal_InjectedDelegateField(_unity_self, (System.IntPtr) ref byteArray);
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCaptureFrame_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<PhotoCaptureFrame.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhotoCaptureFrame>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhotoCaptureFrame.BindingsMarshaller>.NativeClassPtr);
      PhotoCaptureFrame.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCaptureFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhotoCaptureFrame.BindingsMarshaller>.NativeClassPtr, 100669024);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(PhotoCaptureFrame photoCaptureFrame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) photoCaptureFrame)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhotoCaptureFrame.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_PhotoCaptureFrame_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  private delegate void GetCameraToWorldMatrix_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void GetProjection_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate void UploadImageDataToTexture_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr targetTexture);

  private delegate System.IntPtr GetUnsafePointerToBuffer_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void CopyRawImageDataIntoBuffer_Internal_InjectedDelegate(
    System.IntPtr _unity_self,
    [Out] System.IntPtr byteArray);
}
