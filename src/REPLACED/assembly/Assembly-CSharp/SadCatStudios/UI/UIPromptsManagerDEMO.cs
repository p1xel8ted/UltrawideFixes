// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UIPromptsManagerDEMO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Foundation.Events;
using SadCatStudios.UI.Elements;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI;

public class UIPromptsManagerDEMO(System.IntPtr pointer) : 
  LocalSingletonBehaviour<UIPromptsManagerDEMO>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultPoolSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptPrefab;
  private static readonly System.IntPtr NativeFieldInfoPtr_root;
  private static readonly System.IntPtr NativeFieldInfoPtr_rootPostProcess;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_promptPostProcessPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPrompt_Public_UIButtonPrompt_String_Transform_Vector3_Boolean_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPromptOnScreen_Public_UIButtonPrompt_String_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowTextPrompt_Public_UIButtonPrompt_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowArticyPrompt_Public_UIButtonPrompt_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreePrompt_Public_Void_UIButtonPrompt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FreeAll_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__9_0_Private_Void_ResetToCheckpointEvent_0;

  static UIPromptsManagerDEMO()
  {
    Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UIPromptsManagerDEMO));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr);
    UIPromptsManagerDEMO.NativeFieldInfoPtr_defaultPoolSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, nameof (defaultPoolSize));
    UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, nameof (promptPrefab));
    UIPromptsManagerDEMO.NativeFieldInfoPtr_root = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, nameof (root));
    UIPromptsManagerDEMO.NativeFieldInfoPtr_rootPostProcess = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, nameof (rootPostProcess));
    UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, nameof (promptPool));
    UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPostProcessPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, nameof (promptPostProcessPool));
    UIPromptsManagerDEMO.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, nameof (eventDisposable));
    UIPromptsManagerDEMO.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671980);
    UIPromptsManagerDEMO.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671981);
    UIPromptsManagerDEMO.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671982);
    UIPromptsManagerDEMO.NativeMethodInfoPtr_GetPrompt_Public_UIButtonPrompt_String_Transform_Vector3_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671983);
    UIPromptsManagerDEMO.NativeMethodInfoPtr_GetPromptOnScreen_Public_UIButtonPrompt_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671984);
    UIPromptsManagerDEMO.NativeMethodInfoPtr_ShowTextPrompt_Public_UIButtonPrompt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671985);
    UIPromptsManagerDEMO.NativeMethodInfoPtr_ShowArticyPrompt_Public_UIButtonPrompt_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671986);
    UIPromptsManagerDEMO.NativeMethodInfoPtr_FreePrompt_Public_Void_UIButtonPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671987);
    UIPromptsManagerDEMO.NativeMethodInfoPtr_FreeAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671988);
    UIPromptsManagerDEMO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671989);
    UIPromptsManagerDEMO.NativeMethodInfoPtr__Start_b__9_0_Private_Void_ResetToCheckpointEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr, 100671990);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97049, XrefRangeEnd = 97069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPromptsManagerDEMO.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97069, XrefRangeEnd = 97088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97088, XrefRangeEnd = 97092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPromptsManagerDEMO.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97092, XrefRangeEnd = 97101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt GetPrompt(
    string text,
    Transform target,
    Vector3 offset,
    bool mash = false,
    bool postProcess = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mash;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &postProcess;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr_GetPrompt_Public_UIButtonPrompt_String_Transform_Vector3_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 97109, RefRangeEnd = 97111, XrefRangeStart = 97101, XrefRangeEnd = 97109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt GetPromptOnScreen(string text, Vector2 anchoredPosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &anchoredPosition;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr_GetPromptOnScreen_Public_UIButtonPrompt_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 97112, RefRangeEnd = 97113, XrefRangeStart = 97111, XrefRangeEnd = 97112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt ShowTextPrompt(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr_ShowTextPrompt_Public_UIButtonPrompt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 97112, RefRangeEnd = 97113, XrefRangeStart = 97112, XrefRangeEnd = 97113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt ShowArticyPrompt(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr_ShowArticyPrompt_Public_UIButtonPrompt_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97113, XrefRangeEnd = 97115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreePrompt(UIButtonPrompt prompt)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prompt)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr_FreePrompt_Public_Void_UIButtonPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 97117, RefRangeEnd = 97118, XrefRangeStart = 97115, XrefRangeEnd = 97117, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FreeAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr_FreeAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97118, XrefRangeEnd = 97121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIPromptsManagerDEMO()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPromptsManagerDEMO>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 97117, RefRangeEnd = 97118, XrefRangeStart = 97117, XrefRangeEnd = 97118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void _Start_b__9_0(ResetToCheckpointEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromptsManagerDEMO.NativeMethodInfoPtr__Start_b__9_0_Private_Void_ResetToCheckpointEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int defaultPoolSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_defaultPoolSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_defaultPoolSize)) = value;
    }
  }

  public unsafe UIButtonPrompt promptPrefab
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPrefab));
      return num == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform root
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_root));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_root), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform rootPostProcess
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_rootPostProcess));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_rootPostProcess), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ObjectPool promptPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ObjectPool promptPostProcessPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPostProcessPool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_promptPostProcessPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromptsManagerDEMO.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public enum ArticyPromptField
  {
    SmallText,
    Counter,
    Description,
  }
}
