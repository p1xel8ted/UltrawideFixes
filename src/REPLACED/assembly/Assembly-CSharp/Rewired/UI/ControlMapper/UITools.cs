// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.UITools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Rewired.UI.ControlMapper;

public static class UITools : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0;

  static UITools()
  {
    Il2CppClassPointerStore<UITools>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (UITools));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UITools>.NativeClassPtr);
    UITools.NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100670084);
    UITools.NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100670085);
    UITools.NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100670086);
    UITools.NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100670087);
    UITools.NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100670088);
    UITools.NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100670089);
    UITools.NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100670090);
    UITools.NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UITools>.NativeClassPtr, 100670091);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 80279, RefRangeEnd = 80284, XrefRangeStart = 80255, XrefRangeEnd = 80279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject InstantiateGUIObject<T>(
    GameObject prefab,
    Transform parent,
    string name)
    where T : Component
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITools.MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 80312, RefRangeEnd = 80317, XrefRangeStart = 80284, XrefRangeEnd = 80312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject InstantiateGUIObject<T>(
    GameObject prefab,
    Transform parent,
    string name,
    Vector2 pivot,
    Vector2 anchorMin,
    Vector2 anchorMax,
    Vector2 anchoredPosition)
    where T : Component
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pivot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &anchorMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &anchorMax;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &anchoredPosition;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITools.MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 80353, RefRangeEnd = 80355, XrefRangeStart = 80317, XrefRangeEnd = 80353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject InstantiateGUIObject_Pre<T>(
    GameObject prefab,
    Transform parent,
    string name)
    where T : Component
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITools.MethodInfoStoreGeneric_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80362, RefRangeEnd = 80363, XrefRangeStart = 80355, XrefRangeEnd = 80362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetPointOnRectEdge(RectTransform rectTransform, Vector2 dir)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rectTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_GetPointOnRectEdge_Public_Static_Vector3_RectTransform_Vector2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80363, XrefRangeEnd = 80372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Rect GetWorldSpaceRect(RectTransform rt)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) rt)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_GetWorldSpaceRect_Public_Static_Rect_RectTransform_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 80386, RefRangeEnd = 80387, XrefRangeStart = 80372, XrefRangeEnd = 80386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Rect TransformRectTo(Transform from, Transform to, Rect rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &rect;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_TransformRectTo_Public_Static_Rect_Transform_Transform_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe Rect InvertY(Rect rect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rect
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_InvertY_Public_Static_Rect_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 80393, RefRangeEnd = 80397, XrefRangeStart = 80387, XrefRangeEnd = 80393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetInteractable(Selectable selectable, bool state, bool playTransition)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) selectable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &state;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playTransition;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UITools.NativeMethodInfoPtr_SetInteractable_Public_Static_Void_Selectable_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public UITools(System.IntPtr pointer)
    : base(pointer)
  {
  }

  private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UITools.NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UITools.NativeMethodInfoPtr_InstantiateGUIObject_Public_Static_GameObject_GameObject_Transform_String_Vector2_Vector2_Vector2_Vector2_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UITools.NativeMethodInfoPtr_InstantiateGUIObject_Pre_Private_Static_GameObject_GameObject_Transform_String_0, Il2CppClassPointerStore<UITools>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
