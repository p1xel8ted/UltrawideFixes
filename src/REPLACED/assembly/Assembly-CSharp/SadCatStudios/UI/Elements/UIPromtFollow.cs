// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UIPromtFollow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UIPromtFollow(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_targetTransform;
  private static readonly System.IntPtr NativeFieldInfoPtr_isFollow;
  private static readonly System.IntPtr NativeFieldInfoPtr_currBounds;
  private static readonly System.IntPtr NativeFieldInfoPtr_boundsYOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_center;
  private static readonly System.IntPtr NativeFieldInfoPtr_providedOffset;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvas;
  private static readonly System.IntPtr NativeFieldInfoPtr_canvasRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_mainCamera;
  private static readonly System.IntPtr NativeFieldInfoPtr_corners;
  private static readonly System.IntPtr NativeFieldInfoPtr_rectTransform;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateScreenPosition_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowAtObjectShared_Private_Void_Transform_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowAtObject_Public_Void_Transform_Renderer_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShowAtObject_Public_Void_Transform_IBounds_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIPromtFollow()
  {
    Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UIPromtFollow));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr);
    UIPromtFollow.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (targetTransform));
    UIPromtFollow.NativeFieldInfoPtr_isFollow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (isFollow));
    UIPromtFollow.NativeFieldInfoPtr_currBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (currBounds));
    UIPromtFollow.NativeFieldInfoPtr_boundsYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (boundsYOffset));
    UIPromtFollow.NativeFieldInfoPtr_center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (center));
    UIPromtFollow.NativeFieldInfoPtr_providedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (providedOffset));
    UIPromtFollow.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (canvas));
    UIPromtFollow.NativeFieldInfoPtr_canvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (canvasRect));
    UIPromtFollow.NativeFieldInfoPtr_mainCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (mainCamera));
    UIPromtFollow.NativeFieldInfoPtr_corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (corners));
    UIPromtFollow.NativeFieldInfoPtr_rectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (rectTransform));
    UIPromtFollow.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, 100672562);
    UIPromtFollow.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, 100672563);
    UIPromtFollow.NativeMethodInfoPtr_UpdateScreenPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, 100672564);
    UIPromtFollow.NativeMethodInfoPtr_ShowAtObjectShared_Private_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, 100672565);
    UIPromtFollow.NativeMethodInfoPtr_ShowAtObject_Public_Void_Transform_Renderer_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, 100672566);
    UIPromtFollow.NativeMethodInfoPtr_ShowAtObject_Public_Void_Transform_IBounds_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, 100672567);
    UIPromtFollow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, 100672568);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102048, XrefRangeEnd = 102059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102059, XrefRangeEnd = 102060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102087, RefRangeEnd = 102089, XrefRangeStart = 102060, XrefRangeEnd = 102087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateScreenPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.NativeMethodInfoPtr_UpdateScreenPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ShowAtObjectShared(Transform target, Vector3 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.NativeMethodInfoPtr_ShowAtObjectShared_Private_Void_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 102104, RefRangeEnd = 102106, XrefRangeStart = 102089, XrefRangeEnd = 102104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowAtObject(Transform target, Renderer renderer, Vector3 offset = default (Vector3))
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) renderer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.NativeMethodInfoPtr_ShowAtObject_Public_Void_Transform_Renderer_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102106, XrefRangeEnd = 102111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowAtObject(Transform target, UIPromtFollow.IBounds bounds, Vector3 offset = default (Vector3))
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) bounds);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.NativeMethodInfoPtr_ShowAtObject_Public_Void_Transform_IBounds_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102111, XrefRangeEnd = 102115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIPromtFollow()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform targetTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_targetTransform));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool isFollow
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_isFollow));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_isFollow)) = value;
    }
  }

  public unsafe UIPromtFollow.IBounds currBounds
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_currBounds));
      return num == System.IntPtr.Zero ? (UIPromtFollow.IBounds) null : Il2CppObjectPool.Get<UIPromtFollow.IBounds>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_currBounds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float boundsYOffset
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_boundsYOffset));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_boundsYOffset)) = value;
    }
  }

  public unsafe Vector3 center
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_center));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_center)) = value;
    }
  }

  public unsafe Vector3 providedOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_providedOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_providedOffset)) = value;
    }
  }

  public unsafe Canvas canvas
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_canvas));
      return num == System.IntPtr.Zero ? (Canvas) null : Il2CppObjectPool.Get<Canvas>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform canvasRect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_canvasRect));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_canvasRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Camera mainCamera
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_mainCamera));
      return num == System.IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_mainCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<Vector3> corners
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_corners));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Vector3>) null : Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_corners), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RectTransform rectTransform
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_rectTransform));
      return num == System.IntPtr.Zero ? (RectTransform) null : Il2CppObjectPool.Get<RectTransform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.NativeFieldInfoPtr_rectTransform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class IBounds(System.IntPtr pointer) : Il2CppObjectBase(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Bounds_0;

    static IBounds()
    {
      Il2CppClassPointerStore<UIPromtFollow.IBounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (IBounds));
      UIPromtFollow.IBounds.NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow.IBounds>.NativeClassPtr, 100672569);
    }

    public virtual unsafe Bounds Bounds
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIPromtFollow.IBounds.NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }
  }

  public class RendererBounds(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Renderer;
    private static readonly System.IntPtr NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static RendererBounds()
    {
      Il2CppClassPointerStore<UIPromtFollow.RendererBounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (RendererBounds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPromtFollow.RendererBounds>.NativeClassPtr);
      UIPromtFollow.RendererBounds.NativeFieldInfoPtr_Renderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow.RendererBounds>.NativeClassPtr, nameof (Renderer));
      UIPromtFollow.RendererBounds.NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow.RendererBounds>.NativeClassPtr, 100672570);
      UIPromtFollow.RendererBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow.RendererBounds>.NativeClassPtr, 100672571);
    }

    public virtual unsafe Bounds SadCatStudios\u002EUI\u002EElements\u002EUIPromtFollow\u002EIBounds\u002EBounds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102043, XrefRangeEnd = 102044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.RendererBounds.NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RendererBounds()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPromtFollow.RendererBounds>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.RendererBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Renderer Renderer
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.RendererBounds.NativeFieldInfoPtr_Renderer));
        return num == System.IntPtr.Zero ? (Renderer) null : Il2CppObjectPool.Get<Renderer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.RendererBounds.NativeFieldInfoPtr_Renderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class ColliderBounds(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Collider;
    private static readonly System.IntPtr NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ColliderBounds()
    {
      Il2CppClassPointerStore<UIPromtFollow.ColliderBounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (ColliderBounds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPromtFollow.ColliderBounds>.NativeClassPtr);
      UIPromtFollow.ColliderBounds.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow.ColliderBounds>.NativeClassPtr, nameof (Collider));
      UIPromtFollow.ColliderBounds.NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow.ColliderBounds>.NativeClassPtr, 100672572);
      UIPromtFollow.ColliderBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow.ColliderBounds>.NativeClassPtr, 100672573);
    }

    public virtual unsafe Bounds SadCatStudios\u002EUI\u002EElements\u002EUIPromtFollow\u002EIBounds\u002EBounds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102044, XrefRangeEnd = 102045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.ColliderBounds.NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ColliderBounds()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPromtFollow.ColliderBounds>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.ColliderBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Collider Collider
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.ColliderBounds.NativeFieldInfoPtr_Collider));
        return num == System.IntPtr.Zero ? (Collider) null : Il2CppObjectPool.Get<Collider>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.ColliderBounds.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class TransformBounds(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Transform;
    private static readonly System.IntPtr NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static TransformBounds()
    {
      Il2CppClassPointerStore<UIPromtFollow.TransformBounds>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIPromtFollow>.NativeClassPtr, nameof (TransformBounds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPromtFollow.TransformBounds>.NativeClassPtr);
      UIPromtFollow.TransformBounds.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPromtFollow.TransformBounds>.NativeClassPtr, nameof (Transform));
      UIPromtFollow.TransformBounds.NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow.TransformBounds>.NativeClassPtr, 100672574);
      UIPromtFollow.TransformBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPromtFollow.TransformBounds>.NativeClassPtr, 100672575);
    }

    public virtual unsafe Bounds SadCatStudios\u002EUI\u002EElements\u002EUIPromtFollow\u002EIBounds\u002EBounds
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102045, XrefRangeEnd = 102048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.TransformBounds.NativeMethodInfoPtr_SadCatStudios_UI_Elements_UIPromtFollow_IBounds_get_Bounds_Private_Virtual_Final_New_get_Bounds_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(Bounds*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TransformBounds()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPromtFollow.TransformBounds>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIPromtFollow.TransformBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Transform Transform
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.TransformBounds.NativeFieldInfoPtr_Transform));
        return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPromtFollow.TransformBounds.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
