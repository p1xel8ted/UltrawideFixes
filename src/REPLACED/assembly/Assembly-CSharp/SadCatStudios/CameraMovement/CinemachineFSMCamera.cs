// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CinemachineFSMCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using SadCatStudios.FSM;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.CameraMovement;

public class CinemachineFSMCamera(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_stateController;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraStates;
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultCamera;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStateChanged_Private_Void_State_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetCameras_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableCamera_Private_Void_CinemachineVirtualCameraBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineFSMCamera()
  {
    Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CinemachineFSMCamera));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr);
    CinemachineFSMCamera.NativeFieldInfoPtr_stateController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, nameof (stateController));
    CinemachineFSMCamera.NativeFieldInfoPtr_cameraStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, nameof (cameraStates));
    CinemachineFSMCamera.NativeFieldInfoPtr_defaultCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, nameof (defaultCamera));
    CinemachineFSMCamera.NativeMethodInfoPtr_Start_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, 100676345);
    CinemachineFSMCamera.NativeMethodInfoPtr_OnStateChanged_Private_Void_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, 100676346);
    CinemachineFSMCamera.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, 100676347);
    CinemachineFSMCamera.NativeMethodInfoPtr_ResetCameras_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, 100676348);
    CinemachineFSMCamera.NativeMethodInfoPtr_EnableCamera_Private_Void_CinemachineVirtualCameraBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, 100676349);
    CinemachineFSMCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, 100676350);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122909, XrefRangeEnd = 122913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera.NativeMethodInfoPtr_Start_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122913, XrefRangeEnd = 122927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnStateChanged(SadCatStudios.FSM.State state)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) state)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera.NativeMethodInfoPtr_OnStateChanged_Private_Void_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122927, XrefRangeEnd = 122935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122935, XrefRangeEnd = 122952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetCameras()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera.NativeMethodInfoPtr_ResetCameras_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122952, XrefRangeEnd = 122956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableCamera(CinemachineVirtualCameraBase vCam)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) vCam)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera.NativeMethodInfoPtr_EnableCamera_Private_Void_CinemachineVirtualCameraBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineFSMCamera()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StateController stateController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera.NativeFieldInfoPtr_stateController));
      return num == System.IntPtr.Zero ? (StateController) null : Il2CppObjectPool.Get<StateController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera.NativeFieldInfoPtr_stateController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CameraStateDictionary cameraStates
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera.NativeFieldInfoPtr_cameraStates));
      return num == System.IntPtr.Zero ? (CameraStateDictionary) null : Il2CppObjectPool.Get<CameraStateDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera.NativeFieldInfoPtr_cameraStates), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CinemachineVirtualCameraBase defaultCamera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera.NativeFieldInfoPtr_defaultCamera));
      return num == System.IntPtr.Zero ? (CinemachineVirtualCameraBase) null : Il2CppObjectPool.Get<CinemachineVirtualCameraBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera.NativeFieldInfoPtr_defaultCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.CameraMovement.CinemachineFSMCamera+<Start>d__3")]
  public sealed class _Start_d__3(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Start_d__3()
    {
      Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineFSMCamera>.NativeClassPtr, "<Start>d__3");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr);
      CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, "<>1__state");
      CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, "<>2__current");
      CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, "<>4__this");
      CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, 100676351);
      CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, 100676352 /*0x06003300*/);
      CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, 100676353);
      CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, 100676354);
      CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, 100676355);
      CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr, 100676356);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Start_d__3(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineFSMCamera._Start_d__3>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122898, XrefRangeEnd = 122904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122904, XrefRangeEnd = 122909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineFSMCamera._Start_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CinemachineFSMCamera __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (CinemachineFSMCamera) null : Il2CppObjectPool.Get<CinemachineFSMCamera>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineFSMCamera._Start_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
