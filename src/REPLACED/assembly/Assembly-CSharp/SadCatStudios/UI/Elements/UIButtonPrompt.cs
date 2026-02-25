// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UIButtonPrompt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using SadCatStudios.Effects;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UIButtonPrompt(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_glyphText;
  private static readonly System.IntPtr NativeFieldInfoPtr_rectTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvas;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvasRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_rect;
  private static readonly System.IntPtr NativeFieldInfoPtr_target;
  private static readonly System.IntPtr NativeFieldInfoPtr_offset;
  private static readonly System.IntPtr NativeFieldInfoPtr_normalFontSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_componentCache;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowPrompt_Public_Void_String_Transform_Vector3_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowOnScreen_Public_Void_String_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MashEffect_Private_IEnumerator_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIButtonPrompt()
  {
    Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UIButtonPrompt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr);
    UIButtonPrompt.NativeFieldInfoPtr_glyphText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (glyphText));
    UIButtonPrompt.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (rectTransform));
    UIButtonPrompt.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (canvas));
    UIButtonPrompt.NativeFieldInfoPtr_canvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (canvasRect));
    UIButtonPrompt.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (rect));
    UIButtonPrompt.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (target));
    UIButtonPrompt.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (offset));
    UIButtonPrompt.NativeFieldInfoPtr_normalFontSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (normalFontSize));
    UIButtonPrompt.NativeFieldInfoPtr_componentCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, nameof (componentCache));
    UIButtonPrompt.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672282);
    UIButtonPrompt.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672283);
    UIButtonPrompt.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672284);
    UIButtonPrompt.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672285);
    UIButtonPrompt.NativeMethodInfoPtr_ShowPrompt_Public_Void_String_Transform_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672286);
    UIButtonPrompt.NativeMethodInfoPtr_ShowOnScreen_Public_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672287);
    UIButtonPrompt.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672288);
    UIButtonPrompt.NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672289);
    UIButtonPrompt.NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672290);
    UIButtonPrompt.NativeMethodInfoPtr_MashEffect_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672291);
    UIButtonPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, 100672292);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100319, XrefRangeEnd = 100323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe T GetComponentFromPoolable<T>() where T : MonoBehaviour
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100323, XrefRangeEnd = 100326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100326, XrefRangeEnd = 100335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Init(
    ObjectPool pool,
    FloatReference lifetime = null,
    IImpactPositionProvider positionProvider = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lifetime);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100335, XrefRangeEnd = 100339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string text)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(text)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 100351, RefRangeEnd = 100353, XrefRangeStart = 100339, XrefRangeEnd = 100351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowPrompt(string text, Transform target, Vector3 offset, bool mash = false)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &mash;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_ShowPrompt_Public_Void_String_Transform_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 100361, RefRangeEnd = 100362, XrefRangeStart = 100353, XrefRangeEnd = 100361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowOnScreen(string text, Vector2 screenPos)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &screenPos;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_ShowOnScreen_Public_Void_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100362, XrefRangeEnd = 100377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 22237, RefRangeEnd = 22242, XrefRangeStart = 22237, XrefRangeEnd = 22242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe GameObject GetGameObject()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 22243, RefRangeEnd = 22246, XrefRangeStart = 22243, XrefRangeEnd = 22246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Transform GetTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100377, XrefRangeEnd = 100381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator MashEffect(float frequence)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &frequence
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr_MashEffect_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100381, XrefRangeEnd = 100388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIButtonPrompt()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UIGlyphText glyphText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_glyphText));
      return num == System.IntPtr.Zero ? (UIGlyphText) null : Il2CppObjectPool.Get<UIGlyphText>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_glyphText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rectTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_rectTransform));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Canvas canvas
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_canvas));
      return num == System.IntPtr.Zero ? (Canvas) null : Il2CppObjectPool.Get<Canvas>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform canvasRect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_canvasRect));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_canvasRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_rect));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_rect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Transform target
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_target));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector3 offset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_offset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_offset)) = value;
    }
  }

  public unsafe float normalFontSize
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_normalFontSize));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_normalFontSize)) = value;
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, MonoBehaviour> componentCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_componentCache));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, MonoBehaviour>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, MonoBehaviour>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt.NativeFieldInfoPtr_componentCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.UI.Elements.UIButtonPrompt+<MashEffect>d__18")]
  public sealed class _MashEffect_d__18(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_frequence;
    private static readonly System.IntPtr NativeFieldInfoPtr__i_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__3;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _MashEffect_d__18()
    {
      Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr, "<MashEffect>d__18");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr);
      UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, "<>1__state");
      UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, "<>2__current");
      UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, "<>4__this");
      UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr_frequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, nameof (frequence));
      UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, "<i>5__2");
      UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr__timer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, "<timer>5__3");
      UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, 100672293);
      UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, 100672294);
      UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, 100672295);
      UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, 100672296);
      UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, 100672297);
      UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr, 100672298);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _MashEffect_d__18(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIButtonPrompt._MashEffect_d__18>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100307, XrefRangeEnd = 100314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EGeneric\u002EIEnumerator\u003CSystem\u002EObject\u003E\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100314, XrefRangeEnd = 100319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIButtonPrompt._MashEffect_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UIButtonPrompt __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (UIButtonPrompt) null : Il2CppObjectPool.Get<UIButtonPrompt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float frequence
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr_frequence));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr_frequence)) = value;
      }
    }

    public unsafe int _i_5__2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr__i_5__2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr__i_5__2)) = value;
      }
    }

    public unsafe float _timer_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr__timer_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIButtonPrompt._MashEffect_d__18.NativeFieldInfoPtr__timer_5__3)) = value;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Virtual_Final_New_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(UIButtonPrompt.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0, Il2CppClassPointerStore<UIButtonPrompt>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
