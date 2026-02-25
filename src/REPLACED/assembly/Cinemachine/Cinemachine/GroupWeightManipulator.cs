// Decompiled with JetBrains decompiler
// Type: Cinemachine.GroupWeightManipulator
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class GroupWeightManipulator(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight0;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight1;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight2;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight3;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight4;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight5;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight6;
  private static readonly IntPtr NativeFieldInfoPtr_m_Weight7;
  private static readonly IntPtr NativeFieldInfoPtr_m_group;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateWeights_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static GroupWeightManipulator()
  {
    Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (GroupWeightManipulator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr);
    GroupWeightManipulator.NativeFieldInfoPtr_m_Weight0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_Weight0));
    GroupWeightManipulator.NativeFieldInfoPtr_m_Weight1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_Weight1));
    GroupWeightManipulator.NativeFieldInfoPtr_m_Weight2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_Weight2));
    GroupWeightManipulator.NativeFieldInfoPtr_m_Weight3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_Weight3));
    GroupWeightManipulator.NativeFieldInfoPtr_m_Weight4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_Weight4));
    GroupWeightManipulator.NativeFieldInfoPtr_m_Weight5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_Weight5));
    GroupWeightManipulator.NativeFieldInfoPtr_m_Weight6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_Weight6));
    GroupWeightManipulator.NativeFieldInfoPtr_m_Weight7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_Weight7));
    GroupWeightManipulator.NativeFieldInfoPtr_m_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, nameof (m_group));
    GroupWeightManipulator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, 100664230);
    GroupWeightManipulator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, 100664231);
    GroupWeightManipulator.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, 100664232);
    GroupWeightManipulator.NativeMethodInfoPtr_UpdateWeights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, 100664233);
    GroupWeightManipulator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr, 100664234);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945261, XrefRangeEnd = 945264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GroupWeightManipulator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GroupWeightManipulator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945264, XrefRangeEnd = 945268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GroupWeightManipulator.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void UpdateWeights()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GroupWeightManipulator.NativeMethodInfoPtr_UpdateWeights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945268, XrefRangeEnd = 945269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GroupWeightManipulator()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupWeightManipulator>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GroupWeightManipulator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float m_Weight0
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight0));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight0)) = value;
    }
  }

  public unsafe float m_Weight1
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight1));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight1)) = value;
    }
  }

  public unsafe float m_Weight2
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight2));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight2)) = value;
    }
  }

  public unsafe float m_Weight3
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight3));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight3)) = value;
    }
  }

  public unsafe float m_Weight4
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight4));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight4)) = value;
    }
  }

  public unsafe float m_Weight5
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight5));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight5)) = value;
    }
  }

  public unsafe float m_Weight6
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight6));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight6)) = value;
    }
  }

  public unsafe float m_Weight7
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight7));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_Weight7)) = value;
    }
  }

  public unsafe CinemachineTargetGroup m_group
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_group));
      return num == IntPtr.Zero ? (CinemachineTargetGroup) null : Il2CppObjectPool.Get<CinemachineTargetGroup>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GroupWeightManipulator.NativeFieldInfoPtr_m_group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
