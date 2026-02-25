// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.ControllerElementGlyphSelectorOptions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Glyphs;

[Serializable]
public class ControllerElementGlyphSelectorOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__useLastActiveController;
  private static readonly System.IntPtr NativeFieldInfoPtr__controllerTypeOrder;
  private static readonly System.IntPtr NativeFieldInfoPtr_s_defaultOptions;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_useLastActiveController_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_useLastActiveController_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_controllerTypeOrder_Public_get_Il2CppStructArray_1_ControllerType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_controllerTypeOrder_Public_set_Void_Il2CppStructArray_1_ControllerType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetControllerTypeOrder_Public_Virtual_New_Boolean_Int32_byref_ControllerType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_defaultOptions_Public_Static_get_ControllerElementGlyphSelectorOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_defaultOptions_Public_Static_set_Void_ControllerElementGlyphSelectorOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ControllerElementGlyphSelectorOptions()
  {
    Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (ControllerElementGlyphSelectorOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr);
    ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr__useLastActiveController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, nameof (_useLastActiveController));
    ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr__controllerTypeOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, nameof (_controllerTypeOrder));
    ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr_s_defaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, nameof (s_defaultOptions));
    ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_get_useLastActiveController_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, 100668538);
    ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_set_useLastActiveController_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, 100668539);
    ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_get_controllerTypeOrder_Public_get_Il2CppStructArray_1_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, 100668540);
    ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_set_controllerTypeOrder_Public_set_Void_Il2CppStructArray_1_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, 100668541);
    ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_TryGetControllerTypeOrder_Public_Virtual_New_Boolean_Int32_byref_ControllerType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, 100668542);
    ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_get_defaultOptions_Public_Static_get_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, 100668543);
    ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_set_defaultOptions_Public_Static_set_Void_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, 100668544);
    ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr, 100668545);
  }

  public unsafe bool useLastActiveController
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_get_useLastActiveController_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_set_useLastActiveController_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppStructArray<ControllerType> controllerTypeOrder
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_get_controllerTypeOrder_Public_get_Il2CppStructArray_1_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppStructArray<ControllerType>) null : Il2CppObjectPool.Get<Il2CppStructArray<ControllerType>>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_set_controllerTypeOrder_Public_set_Void_Il2CppStructArray_1_ControllerType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public virtual unsafe bool TryGetControllerTypeOrder(int index, out ControllerType controllerType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref controllerType;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_TryGetControllerTypeOrder_Public_Virtual_New_Boolean_Int32_byref_ControllerType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe ControllerElementGlyphSelectorOptions defaultOptions
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 69120 /*0x010E00*/, RefRangeEnd = 69122, XrefRangeStart = 69118, XrefRangeEnd = 69120 /*0x010E00*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_get_defaultOptions_Public_Static_get_ControllerElementGlyphSelectorOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69122, XrefRangeEnd = 69124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr_set_defaultOptions_Public_Static_set_Void_ControllerElementGlyphSelectorOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69124, XrefRangeEnd = 69131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ControllerElementGlyphSelectorOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControllerElementGlyphSelectorOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ControllerElementGlyphSelectorOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _useLastActiveController
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr__useLastActiveController));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr__useLastActiveController)) = value;
    }
  }

  public unsafe Il2CppStructArray<ControllerType> _controllerTypeOrder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr__controllerTypeOrder));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<ControllerType>) null : Il2CppObjectPool.Get<Il2CppStructArray<ControllerType>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr__controllerTypeOrder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe ControllerElementGlyphSelectorOptions s_defaultOptions
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr_s_defaultOptions, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ControllerElementGlyphSelectorOptions) null : Il2CppObjectPool.Get<ControllerElementGlyphSelectorOptions>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ControllerElementGlyphSelectorOptions.NativeFieldInfoPtr_s_defaultOptions, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
