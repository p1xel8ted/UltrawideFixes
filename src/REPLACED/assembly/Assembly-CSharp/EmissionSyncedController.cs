// Decompiled with JetBrains decompiler
// Type: EmissionSyncedController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class EmissionSyncedController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_lightController;
  private static readonly IntPtr NativeFieldInfoPtr_animateInEditor;
  private static readonly IntPtr NativeFieldInfoPtr_mat;
  private static readonly IntPtr NativeFieldInfoPtr_EmissionColor;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetEmission_Private_Void_Color_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EmissionSyncedController()
  {
    Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (EmissionSyncedController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr);
    EmissionSyncedController.NativeFieldInfoPtr_lightController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, nameof (lightController));
    EmissionSyncedController.NativeFieldInfoPtr_animateInEditor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, nameof (animateInEditor));
    EmissionSyncedController.NativeFieldInfoPtr_mat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, nameof (mat));
    EmissionSyncedController.NativeFieldInfoPtr_EmissionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, nameof (EmissionColor));
    EmissionSyncedController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, 100663540 /*0x060000F4*/);
    EmissionSyncedController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, 100663541 /*0x060000F5*/);
    EmissionSyncedController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, 100663542 /*0x060000F6*/);
    EmissionSyncedController.NativeMethodInfoPtr_SetEmission_Private_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, 100663543 /*0x060000F7*/);
    EmissionSyncedController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr, 100663544 /*0x060000F8*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20362, XrefRangeEnd = 20366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EmissionSyncedController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20366, XrefRangeEnd = 20372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EmissionSyncedController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20372, XrefRangeEnd = 20386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EmissionSyncedController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20386, XrefRangeEnd = 20391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetEmission(Color color)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &color
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EmissionSyncedController.NativeMethodInfoPtr_SetEmission_Private_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20391, XrefRangeEnd = 20392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EmissionSyncedController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmissionSyncedController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EmissionSyncedController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LightController lightController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionSyncedController.NativeFieldInfoPtr_lightController));
      return num == IntPtr.Zero ? (LightController) null : Il2CppObjectPool.Get<LightController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmissionSyncedController.NativeFieldInfoPtr_lightController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool animateInEditor
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionSyncedController.NativeFieldInfoPtr_animateInEditor));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionSyncedController.NativeFieldInfoPtr_animateInEditor)) = value;
    }
  }

  public unsafe Material mat
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmissionSyncedController.NativeFieldInfoPtr_mat));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmissionSyncedController.NativeFieldInfoPtr_mat), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe int EmissionColor
  {
    get
    {
      int emissionColor;
      IL2CPP.il2cpp_field_static_get_value(EmissionSyncedController.NativeFieldInfoPtr_EmissionColor, (void*) &emissionColor);
      return emissionColor;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EmissionSyncedController.NativeFieldInfoPtr_EmissionColor, (void*) &value);
    }
  }
}
