// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Playables.CameraPlayable
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Experimental.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct CameraPlayable
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0;
  [FieldOffset(0)]
  public PlayableHandle m_Handle;
  private static readonly CameraPlayable.ValidateTypeDelegate ValidateTypeDelegateField;
  private static readonly CameraPlayable.GetCameraInternal_InjectedDelegate GetCameraInternal_InjectedDelegateField;
  private static readonly CameraPlayable.SetCameraInternal_InjectedDelegate SetCameraInternal_InjectedDelegateField;
  private static readonly CameraPlayable.InternalCreateCameraPlayable_InjectedDelegate InternalCreateCameraPlayable_InjectedDelegateField;

  static CameraPlayable()
  {
    Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", nameof (CameraPlayable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr);
    CameraPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, nameof (m_Handle));
    CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100670728);
    CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, 100670729);
    CameraPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<CameraPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::ValidateType");
    CameraPlayable.GetCameraInternal_InjectedDelegateField = IL2CPP.ResolveICall<CameraPlayable.GetCameraInternal_InjectedDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::GetCameraInternal_Injected");
    CameraPlayable.SetCameraInternal_InjectedDelegateField = IL2CPP.ResolveICall<CameraPlayable.SetCameraInternal_InjectedDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::SetCameraInternal_Injected");
    CameraPlayable.InternalCreateCameraPlayable_InjectedDelegateField = IL2CPP.ResolveICall<CameraPlayable.InternalCreateCameraPlayable_InjectedDelegate>("UnityEngine.Experimental.Playables.CameraPlayable::InternalCreateCameraPlayable_Injected");
  }

  [CallerCount(49)]
  [CachedScanResults(RefRangeStart = 480002, RefRangeEnd = 480051, XrefRangeStart = 480002, XrefRangeEnd = 480051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PlayableHandle GetHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489648, XrefRangeEnd = 489652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(CameraPlayable other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CameraPlayable_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CameraPlayable>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static CameraPlayable Create(PlayableGraph graph, Camera camera)
  {
    return new CameraPlayable(CameraPlayable.CreateHandle(graph, camera));
  }

  public static PlayableHandle CreateHandle(PlayableGraph graph, Camera camera)
  {
    PlayableHandle handle = PlayableHandle.Null;
    return !CameraPlayable.InternalCreateCameraPlayable(ref graph, camera, ref handle) ? PlayableHandle.Null : handle;
  }

  public static implicit operator Playable(CameraPlayable playable)
  {
    return new Playable(playable.GetHandle());
  }

  public static explicit operator CameraPlayable(Playable playable)
  {
    return new CameraPlayable(playable.GetHandle());
  }

  public Camera GetCamera() => CameraPlayable.GetCameraInternal(ref this.m_Handle);

  public void SetCamera(Camera value) => CameraPlayable.SetCameraInternal(ref this.m_Handle, value);

  public static Camera GetCameraInternal(ref PlayableHandle hdl)
  {
    return Unmarshal.UnmarshalUnityObject<Camera>(CameraPlayable.GetCameraInternal_Injected(ref hdl));
  }

  public static void SetCameraInternal(ref PlayableHandle hdl, Camera camera)
  {
    CameraPlayable.SetCameraInternal_Injected(ref hdl, UnityEngine.Object.MarshalledUnityObject.Marshal<Camera>(camera));
  }

  public static bool InternalCreateCameraPlayable(
    ref PlayableGraph graph,
    Camera camera,
    ref PlayableHandle handle)
  {
    return CameraPlayable.InternalCreateCameraPlayable_Injected(ref graph, UnityEngine.Object.MarshalledUnityObject.Marshal<Camera>(camera), ref handle);
  }

  public static bool ValidateType(ref PlayableHandle hdl)
  {
    return CameraPlayable.ValidateTypeDelegateField((System.IntPtr) ref hdl);
  }

  public static System.IntPtr GetCameraInternal_Injected(ref PlayableHandle hdl)
  {
    return CameraPlayable.GetCameraInternal_InjectedDelegateField((System.IntPtr) ref hdl);
  }

  public static void SetCameraInternal_Injected(ref PlayableHandle hdl, System.IntPtr camera)
  {
    CameraPlayable.SetCameraInternal_InjectedDelegateField((System.IntPtr) ref hdl, camera);
  }

  public static bool InternalCreateCameraPlayable_Injected(
    ref PlayableGraph graph,
    System.IntPtr camera,
    ref PlayableHandle handle)
  {
    return CameraPlayable.InternalCreateCameraPlayable_InjectedDelegateField((System.IntPtr) ref graph, camera, (System.IntPtr) ref handle);
  }

  private delegate bool ValidateTypeDelegate(System.IntPtr hdl);

  private delegate System.IntPtr GetCameraInternal_InjectedDelegate(System.IntPtr hdl);

  private delegate void SetCameraInternal_InjectedDelegate(System.IntPtr hdl, System.IntPtr camera);

  private delegate bool InternalCreateCameraPlayable_InjectedDelegate(
    System.IntPtr graph,
    System.IntPtr camera,
    System.IntPtr handle);
}
