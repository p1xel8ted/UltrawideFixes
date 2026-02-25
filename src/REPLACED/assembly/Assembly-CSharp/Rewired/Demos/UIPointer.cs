// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.UIPointer
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
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Demos;

public sealed class UIPointer(IntPtr pointer) : UIBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__hideHardwarePointer;
  private static readonly IntPtr NativeFieldInfoPtr__autoSort;
  private static readonly IntPtr NativeFieldInfoPtr__canvas;
  private static readonly IntPtr NativeMethodInfoPtr_get_autoSort_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_autoSort_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnScreenPositionChanged_Public_Void_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIPointer()
  {
    Il2CppClassPointerStore<UIPointer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos", nameof (UIPointer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPointer>.NativeClassPtr);
    UIPointer.NativeFieldInfoPtr__hideHardwarePointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, nameof (_hideHardwarePointer));
    UIPointer.NativeFieldInfoPtr__autoSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, nameof (_autoSort));
    UIPointer.NativeFieldInfoPtr__canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, nameof (_canvas));
    UIPointer.NativeMethodInfoPtr_get_autoSort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670374);
    UIPointer.NativeMethodInfoPtr_set_autoSort_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670375);
    UIPointer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670376);
    UIPointer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670377);
    UIPointer.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670378);
    UIPointer.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670379);
    UIPointer.NativeMethodInfoPtr_OnScreenPositionChanged_Public_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670380);
    UIPointer.NativeMethodInfoPtr_GetDependencies_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670381);
    UIPointer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPointer>.NativeClassPtr, 100670382);
  }

  public unsafe bool autoSort
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_get_autoSort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83866, XrefRangeEnd = 83868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_set_autoSort_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83868, XrefRangeEnd = 83881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83881, XrefRangeEnd = 83888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83888, XrefRangeEnd = 83894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnTransformParentChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_OnTransformParentChanged_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCanvasGroupChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_OnCanvasGroupChanged_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83894, XrefRangeEnd = 83912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnScreenPositionChanged(Vector2 screenPosition)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &screenPosition
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_OnScreenPositionChanged_Public_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83912, XrefRangeEnd = 83917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void GetDependencies()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr_GetDependencies_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83917, XrefRangeEnd = 83918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIPointer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPointer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPointer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _hideHardwarePointer
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__hideHardwarePointer));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__hideHardwarePointer)) = value;
    }
  }

  public unsafe bool _autoSort
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__autoSort));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__autoSort)) = value;
    }
  }

  public unsafe Canvas _canvas
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__canvas));
      return num == IntPtr.Zero ? (Canvas) null : Il2CppObjectPool.Get<Canvas>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPointer.NativeFieldInfoPtr__canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
