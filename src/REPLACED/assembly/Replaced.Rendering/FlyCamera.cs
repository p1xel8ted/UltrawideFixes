// Decompiled with JetBrains decompiler
// Type: FlyCamera
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class FlyCamera(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_theCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_lookAtTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_mousePosition;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rotate_Private_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FlyCamera()
  {
    Il2CppClassPointerStore<FlyCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "", nameof (FlyCamera));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr);
    FlyCamera.NativeFieldInfoPtr_theCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr, nameof (theCamera));
    FlyCamera.NativeFieldInfoPtr_lookAtTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr, nameof (lookAtTarget));
    FlyCamera.NativeFieldInfoPtr_mousePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr, nameof (mousePosition));
    FlyCamera.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr, 100663297 /*0x06000001*/);
    FlyCamera.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr, 100663298 /*0x06000002*/);
    FlyCamera.NativeMethodInfoPtr_Rotate_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr, 100663299 /*0x06000003*/);
    FlyCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr, 100663300 /*0x06000004*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923640, XrefRangeEnd = 923647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyCamera.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923647, XrefRangeEnd = 923695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyCamera.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 923709, RefRangeEnd = 923710, XrefRangeStart = 923695, XrefRangeEnd = 923709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Rotate(float deltaPhi, float deltaTheta)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &deltaPhi;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTheta;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyCamera.NativeMethodInfoPtr_Rotate_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlyCamera()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlyCamera>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlyCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Camera theCamera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyCamera.NativeFieldInfoPtr_theCamera));
      return num == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlyCamera.NativeFieldInfoPtr_theCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 lookAtTarget
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyCamera.NativeFieldInfoPtr_lookAtTarget));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyCamera.NativeFieldInfoPtr_lookAtTarget)) = value;
    }
  }

  public Il2CppSystem.Nullable<Vector3> mousePosition
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyCamera.NativeFieldInfoPtr_mousePosition);
      return new Il2CppSystem.Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<Vector3>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlyCamera.NativeFieldInfoPtr_mousePosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<Vector3>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
