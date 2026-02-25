// Decompiled with JetBrains decompiler
// Type: UnityEngine.RectOffset
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[Serializable]
public class RectOffset(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceStyle;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_left_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_right_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_top_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_bottom_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Rect_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_left_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_left_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_right_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_right_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_top_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_top_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_bottom_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_bottom_Injected_Private_Static_Void_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_horizontal_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_vertical_Injected_Private_Static_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Injected_Private_Static_Void_IntPtr_byref_Rect_byref_Rect_0;
  private static readonly RectOffset.Add_InjectedDelegate Add_InjectedDelegateField;

  static RectOffset()
  {
    Il2CppClassPointerStore<RectOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RectOffset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectOffset>.NativeClassPtr);
    RectOffset.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, nameof (m_Ptr));
    RectOffset.NativeFieldInfoPtr_m_SourceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, nameof (m_SourceStyle));
    RectOffset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664576 /*0x06000500*/);
    RectOffset.NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664577 /*0x06000501*/);
    RectOffset.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664578 /*0x06000502*/);
    RectOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664579 /*0x06000503*/);
    RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664580 /*0x06000504*/);
    RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664581 /*0x06000505*/);
    RectOffset.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664582 /*0x06000506*/);
    RectOffset.NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664583 /*0x06000507*/);
    RectOffset.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664584 /*0x06000508*/);
    RectOffset.NativeMethodInfoPtr_get_left_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664585 /*0x06000509*/);
    RectOffset.NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664586 /*0x0600050A*/);
    RectOffset.NativeMethodInfoPtr_get_right_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664587 /*0x0600050B*/);
    RectOffset.NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664588 /*0x0600050C*/);
    RectOffset.NativeMethodInfoPtr_get_top_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664589 /*0x0600050D*/);
    RectOffset.NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664590 /*0x0600050E*/);
    RectOffset.NativeMethodInfoPtr_get_bottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664591 /*0x0600050F*/);
    RectOffset.NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664592 /*0x06000510*/);
    RectOffset.NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664593);
    RectOffset.NativeMethodInfoPtr_get_vertical_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664594);
    RectOffset.NativeMethodInfoPtr_Remove_Public_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664595);
    RectOffset.NativeMethodInfoPtr_get_left_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664596);
    RectOffset.NativeMethodInfoPtr_set_left_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664597);
    RectOffset.NativeMethodInfoPtr_get_right_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664598);
    RectOffset.NativeMethodInfoPtr_set_right_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664599);
    RectOffset.NativeMethodInfoPtr_get_top_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664600);
    RectOffset.NativeMethodInfoPtr_set_top_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664601);
    RectOffset.NativeMethodInfoPtr_get_bottom_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664602);
    RectOffset.NativeMethodInfoPtr_set_bottom_Injected_Private_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664603);
    RectOffset.NativeMethodInfoPtr_get_horizontal_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664604);
    RectOffset.NativeMethodInfoPtr_get_vertical_Injected_Private_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664605);
    RectOffset.NativeMethodInfoPtr_Remove_Injected_Private_Static_Void_IntPtr_byref_Rect_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100664606);
    RectOffset.Add_InjectedDelegateField = IL2CPP.ResolveICall<RectOffset.Add_InjectedDelegate>("UnityEngine.RectOffset::Add_Injected");
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 422243, RefRangeEnd = 422248, XrefRangeStart = 422240, XrefRangeEnd = 422243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RectOffset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 422249, RefRangeEnd = 422255, XrefRangeStart = 422248, XrefRangeEnd = 422249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RectOffset(Il2CppSystem.Object sourceStyle, System.IntPtr source)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceStyle);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &source;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422255, XrefRangeEnd = 422260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RectOffset.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 422275, RefRangeEnd = 422279, XrefRangeStart = 422260, XrefRangeEnd = 422275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RectOffset(int left, int right, int top, int bottom)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &left;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &top;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &bottom;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422279, XrefRangeEnd = 422280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422280, XrefRangeEnd = 422310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422310, XrefRangeEnd = 422312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Destroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422312, XrefRangeEnd = 422314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr InternalCreate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422314, XrefRangeEnd = 422316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InternalDestroy(System.IntPtr ptr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ptr
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int left
  {
    [CallerCount(32 /*0x20*/), CachedScanResults(RefRangeStart = 422320, RefRangeEnd = 422352, XrefRangeStart = 422316, XrefRangeEnd = 422320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_left_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 422356, RefRangeEnd = 422365, XrefRangeStart = 422352, XrefRangeEnd = 422356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_left_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int right
  {
    [CallerCount(26), CachedScanResults(RefRangeStart = 422369, RefRangeEnd = 422395, XrefRangeStart = 422365, XrefRangeEnd = 422369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_right_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 422399, RefRangeEnd = 422407, XrefRangeStart = 422395, XrefRangeEnd = 422399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_right_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int top
  {
    [CallerCount(34), CachedScanResults(RefRangeStart = 422411, RefRangeEnd = 422445, XrefRangeStart = 422407, XrefRangeEnd = 422411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_top_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(10), CachedScanResults(RefRangeStart = 422449, RefRangeEnd = 422459, XrefRangeStart = 422445, XrefRangeEnd = 422449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_top_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int bottom
  {
    [CallerCount(25), CachedScanResults(RefRangeStart = 422463, RefRangeEnd = 422488, XrefRangeStart = 422459, XrefRangeEnd = 422463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_bottom_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(10), CachedScanResults(RefRangeStart = 422492, RefRangeEnd = 422502, XrefRangeStart = 422488, XrefRangeEnd = 422492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_bottom_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int horizontal
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 422506, RefRangeEnd = 422516, XrefRangeStart = 422502, XrefRangeEnd = 422506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int vertical
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 422520, RefRangeEnd = 422530, XrefRangeStart = 422516, XrefRangeEnd = 422520, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_vertical_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 422533, RefRangeEnd = 422542, XrefRangeStart = 422530, XrefRangeEnd = 422533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Rect Remove(Rect rect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rect
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Remove_Public_Rect_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422542, XrefRangeEnd = 422544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_left_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_left_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422544, XrefRangeEnd = 422546, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_left_Injected(System.IntPtr _unity_self, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_left_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422546, XrefRangeEnd = 422548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_right_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_right_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422548, XrefRangeEnd = 422550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_right_Injected(System.IntPtr _unity_self, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_right_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422550, XrefRangeEnd = 422552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_top_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_top_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422552, XrefRangeEnd = 422554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_top_Injected(System.IntPtr _unity_self, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_top_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422554, XrefRangeEnd = 422556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_bottom_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_bottom_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422556, XrefRangeEnd = 422558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_bottom_Injected(System.IntPtr _unity_self, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_set_bottom_Injected_Private_Static_Void_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422558, XrefRangeEnd = 422560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_horizontal_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_horizontal_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422560, XrefRangeEnd = 422562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int get_vertical_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_vertical_Injected_Private_Static_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422562, XrefRangeEnd = 422564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Remove_Injected(System.IntPtr _unity_self, [In] ref Rect rect, out Rect ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref rect;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Remove_Injected_Private_Static_Void_IntPtr_byref_Rect_byref_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public unsafe Il2CppSystem.Object m_SourceStyle
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_SourceStyle));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_SourceStyle), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public Rect Add(Rect rect)
  {
    System.IntPtr native = RectOffset.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Rect ret;
    RectOffset.Add_Injected(native, ref rect, out ret);
    return ret;
  }

  public static void Add_Injected(System.IntPtr _unity_self, [In] ref Rect rect, out Rect ret)
  {
    RectOffset.Add_InjectedDelegateField(_unity_self, (System.IntPtr) ref rect, (System.IntPtr) ref ret);
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RectOffset_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<RectOffset.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectOffset.BindingsMarshaller>.NativeClassPtr);
      RectOffset.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RectOffset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset.BindingsMarshaller>.NativeClassPtr, 100664607);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(RectOffset rectOffset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectOffset)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectOffset.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_RectOffset_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  private delegate void Add_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr rect, [Out] System.IntPtr ret);
}
