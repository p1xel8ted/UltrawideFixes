// Decompiled with JetBrains decompiler
// Type: UnityEngine.InspectorOrderAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class InspectorOrderAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__m_inspectorSort_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__m_sortDirection_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0;

  static InspectorOrderAttribute()
  {
    Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (InspectorOrderAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr);
    InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, "<m_inspectorSort>k__BackingField");
    InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, "<m_sortDirection>k__BackingField");
    InspectorOrderAttribute.NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, 100668167);
    InspectorOrderAttribute.NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InspectorOrderAttribute>.NativeClassPtr, 100668168);
  }

  public unsafe InspectorSort m_inspectorSort
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InspectorOrderAttribute.NativeMethodInfoPtr_get_m_inspectorSort_Internal_get_InspectorSort_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InspectorSort*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._m_inspectorSort_k__BackingField = value;
  }

  public unsafe InspectorSortDirection m_sortDirection
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InspectorOrderAttribute.NativeMethodInfoPtr_get_m_sortDirection_Internal_get_InspectorSortDirection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InspectorSortDirection*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this._m_sortDirection_k__BackingField = value;
  }

  public unsafe InspectorSort _m_inspectorSort_k__BackingField
  {
    get
    {
      return *(InspectorSort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField));
    }
    [param: In] set
    {
      *(InspectorSort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_inspectorSort_k__BackingField)) = value;
    }
  }

  public unsafe InspectorSortDirection _m_sortDirection_k__BackingField
  {
    get
    {
      return *(InspectorSortDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField));
    }
    [param: In] set
    {
      *(InspectorSortDirection*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InspectorOrderAttribute.NativeFieldInfoPtr__m_sortDirection_k__BackingField)) = value;
    }
  }
}
