// Decompiled with JetBrains decompiler
// Type: PlayModeSaver.SavePlayModeChanges
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using UnityEngine;

#nullable disable
namespace PlayModeSaver;

public class SavePlayModeChanges(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_AnyAncestorHasThisComponent_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_AnyDescendentIsStatic_Public_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAllAncestors_Private_List_1_Transform_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetAllDescendents_Private_List_1_Transform_Transform_List_1_Transform_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SavePlayModeChanges()
  {
    Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "PlayModeSaver", nameof (SavePlayModeChanges));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr);
    SavePlayModeChanges.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr, 100663745);
    SavePlayModeChanges.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr, 100663746);
    SavePlayModeChanges.NativeMethodInfoPtr_AnyAncestorHasThisComponent_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr, 100663747);
    SavePlayModeChanges.NativeMethodInfoPtr_AnyDescendentIsStatic_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr, 100663748);
    SavePlayModeChanges.NativeMethodInfoPtr_GetAllAncestors_Private_List_1_Transform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr, 100663749);
    SavePlayModeChanges.NativeMethodInfoPtr_GetAllDescendents_Private_List_1_Transform_Transform_List_1_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr, 100663750);
    SavePlayModeChanges.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr, 100663751);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SavePlayModeChanges.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364050, XrefRangeEnd = 364053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SavePlayModeChanges.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 364091, RefRangeEnd = 364092, XrefRangeStart = 364053, XrefRangeEnd = 364091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AnyAncestorHasThisComponent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SavePlayModeChanges.NativeMethodInfoPtr_AnyAncestorHasThisComponent_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 364106, RefRangeEnd = 364107, XrefRangeStart = 364092, XrefRangeEnd = 364106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool AnyDescendentIsStatic()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SavePlayModeChanges.NativeMethodInfoPtr_AnyDescendentIsStatic_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364107, XrefRangeEnd = 364124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Transform> GetAllAncestors(Transform _transform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _transform)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SavePlayModeChanges.NativeMethodInfoPtr_GetAllAncestors_Private_List_1_Transform_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (List<Transform>) null : Il2CppObjectPool.Get<List<Transform>>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 364138, RefRangeEnd = 364140, XrefRangeStart = 364124, XrefRangeEnd = 364138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<Transform> GetAllDescendents(Transform current, List<Transform> transforms = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) current);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transforms);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SavePlayModeChanges.NativeMethodInfoPtr_GetAllDescendents_Private_List_1_Transform_Transform_List_1_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (List<Transform>) null : Il2CppObjectPool.Get<List<Transform>>(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SavePlayModeChanges()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SavePlayModeChanges>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SavePlayModeChanges.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
