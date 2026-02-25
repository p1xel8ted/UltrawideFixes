// Decompiled with JetBrains decompiler
// Type: Cinemachine.UpdateTracker
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class UpdateTracker(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mUpdateStatus;
  private static readonly System.IntPtr NativeFieldInfoPtr_sToDelete;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLastUpdateTime;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTargets_Private_Static_Void_UpdateClock_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPreferredUpdate_Public_Static_UpdateClock_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Static_Void_UpdateClock_0;

  static UpdateTracker()
  {
    Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (UpdateTracker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr);
    UpdateTracker.NativeFieldInfoPtr_mUpdateStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr, nameof (mUpdateStatus));
    UpdateTracker.NativeFieldInfoPtr_sToDelete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr, nameof (sToDelete));
    UpdateTracker.NativeFieldInfoPtr_mLastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr, nameof (mLastUpdateTime));
    UpdateTracker.NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr, 100664204);
    UpdateTracker.NativeMethodInfoPtr_UpdateTargets_Private_Static_Void_UpdateClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr, 100664205);
    UpdateTracker.NativeMethodInfoPtr_GetPreferredUpdate_Public_Static_UpdateClock_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr, 100664206);
    UpdateTracker.NativeMethodInfoPtr_OnUpdate_Public_Static_Void_UpdateClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr, 100664207);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945010, XrefRangeEnd = 945018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitializeModule()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpdateTracker.NativeMethodInfoPtr_InitializeModule_Private_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 945064, RefRangeEnd = 945065, XrefRangeStart = 945018, XrefRangeEnd = 945064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void UpdateTargets(UpdateTracker.UpdateClock currentClock)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &currentClock
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpdateTracker.NativeMethodInfoPtr_UpdateTargets_Private_Static_Void_UpdateClock_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945065, XrefRangeEnd = 945093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UpdateTracker.UpdateClock GetPreferredUpdate(Transform target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateTracker.NativeMethodInfoPtr_GetPreferredUpdate_Public_Static_UpdateClock_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UpdateTracker.UpdateClock*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 945104, RefRangeEnd = 945106, XrefRangeStart = 945093, XrefRangeEnd = 945104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUpdate(UpdateTracker.UpdateClock currentClock)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &currentClock
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpdateTracker.NativeMethodInfoPtr_OnUpdate_Public_Static_Void_UpdateClock_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Dictionary<Transform, UpdateTracker.UpdateStatus> mUpdateStatus
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UpdateTracker.NativeFieldInfoPtr_mUpdateStatus, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<Transform, UpdateTracker.UpdateStatus>) null : Il2CppObjectPool.Get<Dictionary<Transform, UpdateTracker.UpdateStatus>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UpdateTracker.NativeFieldInfoPtr_mUpdateStatus, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<Transform> sToDelete
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(UpdateTracker.NativeFieldInfoPtr_sToDelete, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<Transform>) null : Il2CppObjectPool.Get<List<Transform>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UpdateTracker.NativeFieldInfoPtr_sToDelete, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe float mLastUpdateTime
  {
    get
    {
      float mLastUpdateTime;
      IL2CPP.il2cpp_field_static_get_value(UpdateTracker.NativeFieldInfoPtr_mLastUpdateTime, (void*) &mLastUpdateTime);
      return mLastUpdateTime;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UpdateTracker.NativeFieldInfoPtr_mLastUpdateTime, (void*) &value);
    }
  }

  public enum UpdateClock
  {
    Fixed,
    Late,
  }

  public class UpdateStatus(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_windowStart;
    private static readonly System.IntPtr NativeFieldInfoPtr_numWindowLateUpdateMoves;
    private static readonly System.IntPtr NativeFieldInfoPtr_numWindowFixedUpdateMoves;
    private static readonly System.IntPtr NativeFieldInfoPtr_numWindows;
    private static readonly System.IntPtr NativeFieldInfoPtr_lastFrameUpdated;
    private static readonly System.IntPtr NativeFieldInfoPtr_lastPos;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreferredUpdate_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PreferredUpdate_Public_get_UpdateClock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PreferredUpdate_Private_set_Void_UpdateClock_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Matrix4x4_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Void_Int32_UpdateClock_Matrix4x4_0;

    static UpdateStatus()
    {
      Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateTracker>.NativeClassPtr, nameof (UpdateStatus));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr);
      UpdateTracker.UpdateStatus.NativeFieldInfoPtr_windowStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, nameof (windowStart));
      UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindowLateUpdateMoves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, nameof (numWindowLateUpdateMoves));
      UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindowFixedUpdateMoves = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, nameof (numWindowFixedUpdateMoves));
      UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, nameof (numWindows));
      UpdateTracker.UpdateStatus.NativeFieldInfoPtr_lastFrameUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, nameof (lastFrameUpdated));
      UpdateTracker.UpdateStatus.NativeFieldInfoPtr_lastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, nameof (lastPos));
      UpdateTracker.UpdateStatus.NativeFieldInfoPtr__PreferredUpdate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, "<PreferredUpdate>k__BackingField");
      UpdateTracker.UpdateStatus.NativeMethodInfoPtr_get_PreferredUpdate_Public_get_UpdateClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, 100664209);
      UpdateTracker.UpdateStatus.NativeMethodInfoPtr_set_PreferredUpdate_Private_set_Void_UpdateClock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, 100664210);
      UpdateTracker.UpdateStatus.NativeMethodInfoPtr__ctor_Public_Void_Int32_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, 100664211);
      UpdateTracker.UpdateStatus.NativeMethodInfoPtr_OnUpdate_Public_Void_Int32_UpdateClock_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr, 100664212);
    }

    public unsafe UpdateTracker.UpdateClock PreferredUpdate
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UpdateTracker.UpdateStatus.NativeMethodInfoPtr_get_PreferredUpdate_Public_get_UpdateClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(UpdateTracker.UpdateClock*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UpdateTracker.UpdateStatus.NativeMethodInfoPtr_set_PreferredUpdate_Private_set_Void_UpdateClock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945005, XrefRangeEnd = 945007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateStatus(int currentFrame, Matrix4x4 pos)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateTracker.UpdateStatus>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &currentFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UpdateTracker.UpdateStatus.NativeMethodInfoPtr__ctor_Public_Void_Int32_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945009, RefRangeEnd = 945010, XrefRangeStart = 945007, XrefRangeEnd = 945009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnUpdate(
      int currentFrame,
      UpdateTracker.UpdateClock currentClock,
      Matrix4x4 pos)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &currentFrame;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentClock;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pos;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UpdateTracker.UpdateStatus.NativeMethodInfoPtr_OnUpdate_Public_Void_Int32_UpdateClock_Matrix4x4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int windowStart
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_windowStart));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_windowStart)) = value;
      }
    }

    public unsafe int numWindowLateUpdateMoves
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindowLateUpdateMoves));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindowLateUpdateMoves)) = value;
      }
    }

    public unsafe int numWindowFixedUpdateMoves
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindowFixedUpdateMoves));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindowFixedUpdateMoves)) = value;
      }
    }

    public unsafe int numWindows
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindows));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_numWindows)) = value;
      }
    }

    public unsafe int lastFrameUpdated
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_lastFrameUpdated));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_lastFrameUpdated)) = value;
      }
    }

    public unsafe Matrix4x4 lastPos
    {
      get
      {
        return *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_lastPos));
      }
      [param: In] set
      {
        *(Matrix4x4*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr_lastPos)) = value;
      }
    }

    public unsafe UpdateTracker.UpdateClock _PreferredUpdate_k__BackingField
    {
      get
      {
        return *(UpdateTracker.UpdateClock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr__PreferredUpdate_k__BackingField));
      }
      [param: In] set
      {
        *(UpdateTracker.UpdateClock*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateTracker.UpdateStatus.NativeFieldInfoPtr__PreferredUpdate_k__BackingField)) = value;
      }
    }
  }
}
