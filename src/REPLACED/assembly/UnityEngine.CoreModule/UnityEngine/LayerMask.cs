// Decompiled with JetBrains decompiler
// Type: UnityEngine.LayerMask
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct LayerMask
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Mask;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LayerToName_Public_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NameToLayer_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0;
  [FieldOffset(0)]
  public int m_Mask;

  static LayerMask()
  {
    Il2CppClassPointerStore<LayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LayerMask));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerMask>.NativeClassPtr);
    LayerMask.NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, nameof (m_Mask));
    LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668169);
    LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668170);
    LayerMask.NativeMethodInfoPtr_get_value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668171);
    LayerMask.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668172);
    LayerMask.NativeMethodInfoPtr_LayerToName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668173);
    LayerMask.NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668174);
    LayerMask.NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668175);
    LayerMask.NativeMethodInfoPtr_LayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668176);
    LayerMask.NativeMethodInfoPtr_NameToLayer_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, 100668177);
  }

  [CallerCount(215)]
  [CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313091, XrefRangeStart = 312876, XrefRangeEnd = 313091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator int(LayerMask mask)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mask
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_LayerMask_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(215)]
  [CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313091, XrefRangeStart = 312876, XrefRangeEnd = 313091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LayerMask(int intVal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &intVal
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_LayerMask_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(LayerMask*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe int value
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_get_value_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_set_value_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 452009, RefRangeEnd = 452013, XrefRangeStart = 452004, XrefRangeEnd = 452009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string LayerToName(int layer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &layer
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_LayerToName_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 452027, RefRangeEnd = 452040, XrefRangeStart = 452013, XrefRangeEnd = 452027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int NameToLayer(string layerName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(layerName)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_NameToLayer_Public_Static_Int32_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 452042, RefRangeEnd = 452055, XrefRangeStart = 452040, XrefRangeEnd = 452042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetMask([Optional] Il2CppStringArray layerNames)
  {
    if (layerNames == null)
      layerNames = new Il2CppStringArray(0L);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) layerNames)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_GetMask_Public_Static_Int32_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452055, XrefRangeEnd = 452057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LayerToName_Injected(int layer, out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_LayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 452057, XrefRangeEnd = 452059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int NameToLayer_Injected(ref ManagedSpanWrapper layerName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref layerName
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LayerMask.NativeMethodInfoPtr_NameToLayer_Injected_Private_Static_Int32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static int GetMask(params string[] layerNames)
  {
    return LayerMask.GetMask(new Il2CppStringArray(layerNames));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LayerMask>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
