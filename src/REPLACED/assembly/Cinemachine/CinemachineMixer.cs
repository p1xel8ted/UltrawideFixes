// Decompiled with JetBrains decompiler
// Type: CinemachineMixer
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Cinemachine;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
public sealed class CinemachineMixer(System.IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BrainOverrideStack;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BrainOverrideId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PreviewPlay;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDeltaTime_Private_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CinemachineMixer()
  {
    Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "", nameof (CinemachineMixer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr);
    CinemachineMixer.NativeFieldInfoPtr_m_BrainOverrideStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr, nameof (m_BrainOverrideStack));
    CinemachineMixer.NativeFieldInfoPtr_m_BrainOverrideId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr, nameof (m_BrainOverrideId));
    CinemachineMixer.NativeFieldInfoPtr_m_PreviewPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr, nameof (m_PreviewPlay));
    CinemachineMixer.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr, 100663307 /*0x0600000B*/);
    CinemachineMixer.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr, 100663308 /*0x0600000C*/);
    CinemachineMixer.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr, 100663309 /*0x0600000D*/);
    CinemachineMixer.NativeMethodInfoPtr_GetDeltaTime_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr, 100663310 /*0x0600000E*/);
    CinemachineMixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr, 100663311 /*0x0600000F*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936581, XrefRangeEnd = 936584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPlayableDestroy(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixer.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void PrepareFrame(Playable playable, FrameData info)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixer.NativeMethodInfoPtr_PrepareFrame_Public_Virtual_Void_Playable_FrameData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936584, XrefRangeEnd = 936668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixer.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936668, XrefRangeEnd = 936675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetDeltaTime(float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deltaTime
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineMixer.NativeMethodInfoPtr_GetDeltaTime_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936675, XrefRangeEnd = 936676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CinemachineMixer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineMixer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineMixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ICameraOverrideStack m_BrainOverrideStack
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixer.NativeFieldInfoPtr_m_BrainOverrideStack));
      return num == System.IntPtr.Zero ? (ICameraOverrideStack) null : Il2CppObjectPool.Get<ICameraOverrideStack>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixer.NativeFieldInfoPtr_m_BrainOverrideStack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int m_BrainOverrideId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixer.NativeFieldInfoPtr_m_BrainOverrideId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixer.NativeFieldInfoPtr_m_BrainOverrideId)) = value;
    }
  }

  public unsafe bool m_PreviewPlay
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixer.NativeFieldInfoPtr_m_PreviewPlay));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CinemachineMixer.NativeFieldInfoPtr_m_PreviewPlay)) = value;
    }
  }
}
