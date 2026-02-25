// Decompiled with JetBrains decompiler
// Type: Rewired.Glyphs.GlyphTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

#nullable disable
namespace Rewired.Glyphs;

public static class GlyphTools : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetActionElementMaps_Public_Static_Boolean_Int32_Int32_AxisRange_ControllerElementGlyphSelectorOptions_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetActionElementMaps_Public_Static_Boolean_InputAction_AxisRange_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstFullAxisBinding_Public_Static_ActionElementMap_List_1_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstBinding_Public_Static_ActionElementMap_List_1_ActionElementMap_AxisRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindFirstSplitAxisBindingPair_Public_Static_Boolean_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsMousePrioritizedOverKeyboard_Public_Static_Boolean_ControllerElementGlyphSelectorOptions_0;

  static GlyphTools()
  {
    Il2CppClassPointerStore<GlyphTools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Glyphs", nameof (GlyphTools));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphTools>.NativeClassPtr);
    GlyphTools.NativeMethodInfoPtr_TryGetActionElementMaps_Public_Static_Boolean_Int32_Int32_AxisRange_ControllerElementGlyphSelectorOptions_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphTools>.NativeClassPtr, 100668621);
    GlyphTools.NativeMethodInfoPtr_TryGetActionElementMaps_Public_Static_Boolean_InputAction_AxisRange_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphTools>.NativeClassPtr, 100668622);
    GlyphTools.NativeMethodInfoPtr_FindFirstFullAxisBinding_Public_Static_ActionElementMap_List_1_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphTools>.NativeClassPtr, 100668623);
    GlyphTools.NativeMethodInfoPtr_FindFirstBinding_Public_Static_ActionElementMap_List_1_ActionElementMap_AxisRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphTools>.NativeClassPtr, 100668624);
    GlyphTools.NativeMethodInfoPtr_FindFirstSplitAxisBindingPair_Public_Static_Boolean_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphTools>.NativeClassPtr, 100668625);
    GlyphTools.NativeMethodInfoPtr_IsMousePrioritizedOverKeyboard_Public_Static_Boolean_ControllerElementGlyphSelectorOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphTools>.NativeClassPtr, 100668626);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 69683, RefRangeEnd = 69685, XrefRangeStart = 69620, XrefRangeEnd = 69683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetActionElementMaps(
    int playerId,
    int actionId,
    AxisRange actionRange,
    ControllerElementGlyphSelectorOptions options,
    List<ActionElementMap> workingActionElementMaps,
    out ActionElementMap aemResult1,
    out ActionElementMap aemResult2)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[7];
    numPtr1[0] = (System.IntPtr) &playerId;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionId;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &actionRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) workingActionElementMaps);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(5) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(6) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(GlyphTools.NativeMethodInfoPtr_TryGetActionElementMaps_Public_Static_Boolean_Int32_Int32_AxisRange_ControllerElementGlyphSelectorOptions_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref ActionElementMap local1 = ref aemResult1;
    System.IntPtr pointer1 = zero1;
    ActionElementMap actionElementMap1 = pointer1 == System.IntPtr.Zero ? (ActionElementMap) null : new ActionElementMap(pointer1);
    local1 = actionElementMap1;
    ref ActionElementMap local2 = ref aemResult2;
    System.IntPtr pointer2 = zero2;
    ActionElementMap actionElementMap2 = pointer2 == System.IntPtr.Zero ? (ActionElementMap) null : new ActionElementMap(pointer2);
    local2 = actionElementMap2;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 69687, RefRangeEnd = 69692, XrefRangeStart = 69685, XrefRangeEnd = 69687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool TryGetActionElementMaps(
    InputAction action,
    AxisRange actionRange,
    List<ActionElementMap> tempAems,
    out ActionElementMap aemResult1,
    out ActionElementMap aemResult2)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[5];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionRange;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tempAems);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(4) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(GlyphTools.NativeMethodInfoPtr_TryGetActionElementMaps_Public_Static_Boolean_InputAction_AxisRange_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref ActionElementMap local1 = ref aemResult1;
    System.IntPtr pointer1 = zero1;
    ActionElementMap actionElementMap1 = pointer1 == System.IntPtr.Zero ? (ActionElementMap) null : new ActionElementMap(pointer1);
    local1 = actionElementMap1;
    ref ActionElementMap local2 = ref aemResult2;
    System.IntPtr pointer2 = zero2;
    ActionElementMap actionElementMap2 = pointer2 == System.IntPtr.Zero ? (ActionElementMap) null : new ActionElementMap(pointer2);
    local2 = actionElementMap2;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69692, XrefRangeEnd = 69697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ActionElementMap FindFirstFullAxisBinding(
    List<ActionElementMap> actionElementMaps)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMaps)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphTools.NativeMethodInfoPtr_FindFirstFullAxisBinding_Public_Static_ActionElementMap_List_1_ActionElementMap_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ActionElementMap) null : Il2CppObjectPool.Get<ActionElementMap>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 69711, RefRangeEnd = 69712, XrefRangeStart = 69697, XrefRangeEnd = 69711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ActionElementMap FindFirstBinding(
    List<ActionElementMap> actionElementMaps,
    AxisRange actionRange)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMaps);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionRange;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphTools.NativeMethodInfoPtr_FindFirstBinding_Public_Static_ActionElementMap_List_1_ActionElementMap_AxisRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ActionElementMap) null : Il2CppObjectPool.Get<ActionElementMap>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69712, XrefRangeEnd = 69720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool FindFirstSplitAxisBindingPair(
    List<ActionElementMap> actionElementMaps,
    out ActionElementMap negativeAem,
    out ActionElementMap positiveAem)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actionElementMaps);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3;
    System.IntPtr num4 = IL2CPP.il2cpp_runtime_invoke(GlyphTools.NativeMethodInfoPtr_FindFirstSplitAxisBindingPair_Public_Static_Boolean_List_1_ActionElementMap_byref_ActionElementMap_byref_ActionElementMap_0, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref ActionElementMap local1 = ref negativeAem;
    System.IntPtr pointer1 = zero1;
    ActionElementMap actionElementMap1 = pointer1 == System.IntPtr.Zero ? (ActionElementMap) null : new ActionElementMap(pointer1);
    local1 = actionElementMap1;
    ref ActionElementMap local2 = ref positiveAem;
    System.IntPtr pointer2 = zero2;
    ActionElementMap actionElementMap2 = pointer2 == System.IntPtr.Zero ? (ActionElementMap) null : new ActionElementMap(pointer2);
    local2 = actionElementMap2;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num4);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 69720, XrefRangeEnd = 69721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsMousePrioritizedOverKeyboard(
    ControllerElementGlyphSelectorOptions options)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GlyphTools.NativeMethodInfoPtr_IsMousePrioritizedOverKeyboard_Public_Static_Boolean_ControllerElementGlyphSelectorOptions_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public GlyphTools(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
