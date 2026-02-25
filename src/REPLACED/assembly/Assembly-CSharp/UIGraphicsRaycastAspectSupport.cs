// Decompiled with JetBrains decompiler
// Type: UIGraphicsRaycastAspectSupport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
public class UIGraphicsRaycastAspectSupport(IntPtr pointer) : GraphicRaycaster(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_screenCamera;
  private static readonly IntPtr NativeFieldInfoPtr_screenCaster;
  private static readonly IntPtr NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIGraphicsRaycastAspectSupport()
  {
    Il2CppClassPointerStore<UIGraphicsRaycastAspectSupport>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (UIGraphicsRaycastAspectSupport));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIGraphicsRaycastAspectSupport>.NativeClassPtr);
    UIGraphicsRaycastAspectSupport.NativeFieldInfoPtr_screenCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGraphicsRaycastAspectSupport>.NativeClassPtr, nameof (screenCamera));
    UIGraphicsRaycastAspectSupport.NativeFieldInfoPtr_screenCaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIGraphicsRaycastAspectSupport>.NativeClassPtr, nameof (screenCaster));
    UIGraphicsRaycastAspectSupport.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGraphicsRaycastAspectSupport>.NativeClassPtr, 100663469 /*0x060000AD*/);
    UIGraphicsRaycastAspectSupport.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIGraphicsRaycastAspectSupport>.NativeClassPtr, 100663470 /*0x060000AE*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16679, XrefRangeEnd = 16698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Raycast(
    PointerEventData eventData,
    List<RaycastResult> resultAppendList)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) resultAppendList);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIGraphicsRaycastAspectSupport.NativeMethodInfoPtr_Raycast_Public_Virtual_Void_PointerEventData_List_1_RaycastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16698, XrefRangeEnd = 16702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIGraphicsRaycastAspectSupport()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIGraphicsRaycastAspectSupport>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIGraphicsRaycastAspectSupport.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Camera screenCamera
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGraphicsRaycastAspectSupport.NativeFieldInfoPtr_screenCamera));
      return num == IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGraphicsRaycastAspectSupport.NativeFieldInfoPtr_screenCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GraphicRaycaster screenCaster
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIGraphicsRaycastAspectSupport.NativeFieldInfoPtr_screenCaster));
      return num == IntPtr.Zero ? (GraphicRaycaster) null : Il2CppObjectPool.Get<GraphicRaycaster>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIGraphicsRaycastAspectSupport.NativeFieldInfoPtr_screenCaster), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
