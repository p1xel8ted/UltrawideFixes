// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CameraDebugManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.CameraMovement;

public class CameraDebugManager(System.IntPtr pointer) : LocalSingletonBehaviour<CameraDebugManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_DebugActive;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugCameraPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugCameraMovementSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugCameraRotationSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_cameraFly;
  private static readonly System.IntPtr NativeMethodInfoPtr_TogleDebugState_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateDebug_Private_IEnumerator_CameraDebugFly_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CameraDebugManager()
  {
    Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CameraDebugManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr);
    CameraDebugManager.NativeFieldInfoPtr_DebugActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, nameof (DebugActive));
    CameraDebugManager.NativeFieldInfoPtr_debugCameraPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, nameof (debugCameraPrefab));
    CameraDebugManager.NativeFieldInfoPtr_debugCameraMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, nameof (debugCameraMovementSpeed));
    CameraDebugManager.NativeFieldInfoPtr_debugCameraRotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, nameof (debugCameraRotationSpeed));
    CameraDebugManager.NativeFieldInfoPtr_cameraFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, nameof (cameraFly));
    CameraDebugManager.NativeMethodInfoPtr_TogleDebugState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, 100676313);
    CameraDebugManager.NativeMethodInfoPtr_UpdateDebug_Private_IEnumerator_CameraDebugFly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, 100676314);
    CameraDebugManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, 100676315);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122819, XrefRangeEnd = 122828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TogleDebugState()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraDebugManager.NativeMethodInfoPtr_TogleDebugState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122828, XrefRangeEnd = 122832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator UpdateDebug(CameraDebugFly cameraFly)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cameraFly)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraDebugManager.NativeMethodInfoPtr_UpdateDebug_Private_IEnumerator_CameraDebugFly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122832, XrefRangeEnd = 122835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraDebugManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraDebugManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool DebugActive
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_DebugActive));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_DebugActive)) = value;
    }
  }

  public unsafe CinemachineVirtualCamera debugCameraPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_debugCameraPrefab));
      return num == System.IntPtr.Zero ? (CinemachineVirtualCamera) null : Il2CppObjectPool.Get<CinemachineVirtualCamera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_debugCameraPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float debugCameraMovementSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_debugCameraMovementSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_debugCameraMovementSpeed)) = value;
    }
  }

  public unsafe float debugCameraRotationSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_debugCameraRotationSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_debugCameraRotationSpeed)) = value;
    }
  }

  public unsafe CameraDebugFly cameraFly
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_cameraFly));
      return num == System.IntPtr.Zero ? (CameraDebugFly) null : Il2CppObjectPool.Get<CameraDebugFly>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager.NativeFieldInfoPtr_cameraFly), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.CameraMovement.CameraDebugManager+<UpdateDebug>d__6")]
  public sealed class _UpdateDebug_d__6(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr_cameraFly;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _UpdateDebug_d__6()
    {
      Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CameraDebugManager>.NativeClassPtr, "<UpdateDebug>d__6");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr);
      CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, "<>1__state");
      CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, "<>2__current");
      CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr_cameraFly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, nameof (cameraFly));
      CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, 100676316);
      CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, 100676317);
      CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, 100676318);
      CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, 100676319);
      CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, 100676320);
      CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr, 100676321);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _UpdateDebug_d__6(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraDebugManager._UpdateDebug_d__6>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122814, XrefRangeEnd = 122819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CameraDebugManager._UpdateDebug_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CameraDebugFly cameraFly
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr_cameraFly));
        return num == System.IntPtr.Zero ? (CameraDebugFly) null : Il2CppObjectPool.Get<CameraDebugFly>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugManager._UpdateDebug_d__6.NativeFieldInfoPtr_cameraFly), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
