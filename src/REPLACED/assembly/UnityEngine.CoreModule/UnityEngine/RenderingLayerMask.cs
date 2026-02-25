// Decompiled with JetBrains decompiler
// Type: UnityEngine.RenderingLayerMask
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct RenderingLayerMask
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Bits;
  private static readonly System.IntPtr NativeFieldInfoPtr__defaultRenderingLayerMask_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr_maxRenderingLayerSize;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RenderingLayerMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RenderingLayerMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RenderingLayerToName_Public_Static_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefinedRenderingLayerCount_Public_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRenderingLayerCount_Public_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RenderingLayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0;
  [FieldOffset(0)]
  public uint m_Bits;
  private static readonly RenderingLayerMask.Internal_GetDefaultRenderingLayerValueDelegate Internal_GetDefaultRenderingLayerValueDelegateField;
  private static readonly RenderingLayerMask.GetLastDefinedRenderingLayerIndexDelegate GetLastDefinedRenderingLayerIndexDelegateField;
  private static readonly RenderingLayerMask.GetDefinedRenderingLayersCombinedMaskValueDelegate GetDefinedRenderingLayersCombinedMaskValueDelegateField;
  private static readonly RenderingLayerMask.GetDefinedRenderingLayerNamesDelegate GetDefinedRenderingLayerNamesDelegateField;
  private static readonly RenderingLayerMask.NameToRenderingLayer_InjectedDelegate NameToRenderingLayer_InjectedDelegateField;
  private static readonly RenderingLayerMask.GetDefinedRenderingLayerValues_InjectedDelegate GetDefinedRenderingLayerValues_InjectedDelegateField;

  static RenderingLayerMask()
  {
    Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RenderingLayerMask));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr);
    RenderingLayerMask.NativeFieldInfoPtr_m_Bits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, nameof (m_Bits));
    RenderingLayerMask.NativeFieldInfoPtr__defaultRenderingLayerMask_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, "<defaultRenderingLayerMask>k__BackingField");
    RenderingLayerMask.NativeFieldInfoPtr_maxRenderingLayerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, nameof (maxRenderingLayerSize));
    RenderingLayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RenderingLayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100667770);
    RenderingLayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RenderingLayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100667771);
    RenderingLayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100667772);
    RenderingLayerMask.NativeMethodInfoPtr_RenderingLayerToName_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100667773);
    RenderingLayerMask.NativeMethodInfoPtr_GetDefinedRenderingLayerCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100667774);
    RenderingLayerMask.NativeMethodInfoPtr_GetRenderingLayerCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100667775);
    RenderingLayerMask.NativeMethodInfoPtr_RenderingLayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, 100667777);
    RenderingLayerMask.Internal_GetDefaultRenderingLayerValueDelegateField = IL2CPP.ResolveICall<RenderingLayerMask.Internal_GetDefaultRenderingLayerValueDelegate>("UnityEngine.RenderingLayerMask::Internal_GetDefaultRenderingLayerValue");
    RenderingLayerMask.GetLastDefinedRenderingLayerIndexDelegateField = IL2CPP.ResolveICall<RenderingLayerMask.GetLastDefinedRenderingLayerIndexDelegate>("UnityEngine.RenderingLayerMask::GetLastDefinedRenderingLayerIndex");
    RenderingLayerMask.GetDefinedRenderingLayersCombinedMaskValueDelegateField = IL2CPP.ResolveICall<RenderingLayerMask.GetDefinedRenderingLayersCombinedMaskValueDelegate>("UnityEngine.RenderingLayerMask::GetDefinedRenderingLayersCombinedMaskValue");
    RenderingLayerMask.GetDefinedRenderingLayerNamesDelegateField = IL2CPP.ResolveICall<RenderingLayerMask.GetDefinedRenderingLayerNamesDelegate>("UnityEngine.RenderingLayerMask::GetDefinedRenderingLayerNames");
    RenderingLayerMask.NameToRenderingLayer_InjectedDelegateField = IL2CPP.ResolveICall<RenderingLayerMask.NameToRenderingLayer_InjectedDelegate>("UnityEngine.RenderingLayerMask::NameToRenderingLayer_Injected");
    RenderingLayerMask.GetDefinedRenderingLayerValues_InjectedDelegateField = IL2CPP.ResolveICall<RenderingLayerMask.GetDefinedRenderingLayerValues_InjectedDelegate>("UnityEngine.RenderingLayerMask::GetDefinedRenderingLayerValues_Injected");
  }

  [CallerCount(215)]
  [CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313091, XrefRangeStart = 312876, XrefRangeEnd = 313091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator uint(RenderingLayerMask mask)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mask
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingLayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RenderingLayerMask_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(215)]
  [CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313091, XrefRangeStart = 312876, XrefRangeEnd = 313091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator int(RenderingLayerMask mask)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mask
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingLayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_RenderingLayerMask_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(215)]
  [CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313091, XrefRangeStart = 312876, XrefRangeEnd = 313091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator RenderingLayerMask(int intVal)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &intVal
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingLayerMask.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderingLayerMask_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RenderingLayerMask*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442098, RefRangeEnd = 442099, XrefRangeStart = 442090, XrefRangeEnd = 442098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string RenderingLayerToName(int layer)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &layer
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingLayerMask.NativeMethodInfoPtr_RenderingLayerToName_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 442101, RefRangeEnd = 442106, XrefRangeStart = 442099, XrefRangeEnd = 442101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetDefinedRenderingLayerCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingLayerMask.NativeMethodInfoPtr_GetDefinedRenderingLayerCount_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 442108, RefRangeEnd = 442111, XrefRangeStart = 442106, XrefRangeEnd = 442108, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetRenderingLayerCount()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderingLayerMask.NativeMethodInfoPtr_GetRenderingLayerCount_Public_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442111, XrefRangeEnd = 442113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void RenderingLayerToName_Injected(int layer, out ManagedSpanWrapper ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &layer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderingLayerMask.NativeMethodInfoPtr_RenderingLayerToName_Injected_Private_Static_Void_Int32_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderingLayerMask>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe RenderingLayerMask _defaultRenderingLayerMask_k__BackingField
  {
    get
    {
      RenderingLayerMask maskKBackingField;
      IL2CPP.il2cpp_field_static_get_value(RenderingLayerMask.NativeFieldInfoPtr__defaultRenderingLayerMask_k__BackingField, (void*) &maskKBackingField);
      return maskKBackingField;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderingLayerMask.NativeFieldInfoPtr__defaultRenderingLayerMask_k__BackingField, (void*) &value);
    }
  }

  public static unsafe int maxRenderingLayerSize
  {
    get
    {
      int renderingLayerSize;
      IL2CPP.il2cpp_field_static_get_value(RenderingLayerMask.NativeFieldInfoPtr_maxRenderingLayerSize, (void*) &renderingLayerSize);
      return renderingLayerSize;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderingLayerMask.NativeFieldInfoPtr_maxRenderingLayerSize, (void*) &value);
    }
  }

  public static RenderingLayerMask defaultRenderingLayerMask
  {
    get => RenderingLayerMask._defaultRenderingLayerMask_k__BackingField;
  }

  public static implicit operator RenderingLayerMask(uint intVal)
  {
    RenderingLayerMask renderingLayerMask;
    renderingLayerMask.m_Bits = intVal;
    return renderingLayerMask;
  }

  public uint value
  {
    get => this.m_Bits;
    set => this.m_Bits = value;
  }

  public static uint Internal_GetDefaultRenderingLayerValue()
  {
    return RenderingLayerMask.Internal_GetDefaultRenderingLayerValueDelegateField();
  }

  public static unsafe int NameToRenderingLayer(string layerName)
  {
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(layerName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = layerName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return RenderingLayerMask.NameToRenderingLayer_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static uint GetMask(Il2CppStringArray renderingLayerNames)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static uint GetMask(params string[] renderingLayerNames)
  {
    return RenderingLayerMask.GetMask(new Il2CppStringArray(renderingLayerNames));
  }

  public static uint GetMask(Il2CppSystem.ReadOnlySpan<string> renderingLayerNames)
  {
    if (Il2CppSystem.ReadOnlySpan<string>.op_Equality(renderingLayerNames, (Il2CppSystem.ReadOnlySpan<string>) (Il2CppArrayBase<string>) null))
      throw new Il2CppSystem.ArgumentNullException(nameof (renderingLayerNames));
    uint mask = 0;
    Il2CppSystem.ReadOnlySpan<string> readOnlySpan = renderingLayerNames;
    for (int index = 0; index < ((Il2CppSystem.ReadOnlySpan<string>) ref readOnlySpan).Length; ++index)
    {
      int renderingLayer = RenderingLayerMask.NameToRenderingLayer(((Il2CppSystem.ReadOnlySpan<string>) ref readOnlySpan)[index]);
      if (renderingLayer != -1)
        mask |= (uint) (1 << renderingLayer);
    }
    return mask;
  }

  public static int GetLastDefinedRenderingLayerIndex()
  {
    return RenderingLayerMask.GetLastDefinedRenderingLayerIndexDelegateField();
  }

  public static uint GetDefinedRenderingLayersCombinedMaskValue()
  {
    return RenderingLayerMask.GetDefinedRenderingLayersCombinedMaskValueDelegateField();
  }

  public static Il2CppStringArray GetDefinedRenderingLayerNames()
  {
    System.IntPtr num = RenderingLayerMask.GetDefinedRenderingLayerNamesDelegateField();
    return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
  }

  public static Il2CppStructArray<int> GetDefinedRenderingLayerValues()
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<int> renderingLayerValues;
    try
    {
      RenderingLayerMask.GetDefinedRenderingLayerValues_Injected(out ret);
    }
    finally
    {
      Il2CppStructArray<int> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<int>((Il2CppArrayBase<int>&) ref il2CppStructArray);
      renderingLayerValues = il2CppStructArray;
    }
    return renderingLayerValues;
  }

  public static int NameToRenderingLayer_Injected(ref ManagedSpanWrapper layerName)
  {
    return RenderingLayerMask.NameToRenderingLayer_InjectedDelegateField((System.IntPtr) ref layerName);
  }

  public static void GetDefinedRenderingLayerValues_Injected(out BlittableArrayWrapper ret)
  {
    RenderingLayerMask.GetDefinedRenderingLayerValues_InjectedDelegateField((System.IntPtr) ref ret);
  }

  private delegate uint Internal_GetDefaultRenderingLayerValueDelegate();

  private delegate int GetLastDefinedRenderingLayerIndexDelegate();

  private delegate uint GetDefinedRenderingLayersCombinedMaskValueDelegate();

  private delegate System.IntPtr GetDefinedRenderingLayerNamesDelegate();

  private delegate int NameToRenderingLayer_InjectedDelegate(System.IntPtr layerName);

  private delegate void GetDefinedRenderingLayerValues_InjectedDelegate([Out] System.IntPtr ret);
}
