// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Effects.BlinkSpriteTrail
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
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Effects;

public class BlinkSpriteTrail(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteRenderer;
  private static readonly System.IntPtr NativeFieldInfoPtr_fadeTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_startAlpha;
  private static readonly System.IntPtr NativeFieldInfoPtr_componentCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_pool;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Sprite_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Fade_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BlinkSpriteTrail()
  {
    Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Effects", nameof (BlinkSpriteTrail));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr);
    BlinkSpriteTrail.NativeFieldInfoPtr_spriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, nameof (spriteRenderer));
    BlinkSpriteTrail.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, nameof (fadeTime));
    BlinkSpriteTrail.NativeFieldInfoPtr_startAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, nameof (startAlpha));
    BlinkSpriteTrail.NativeFieldInfoPtr_componentCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, nameof (componentCache));
    BlinkSpriteTrail.NativeFieldInfoPtr_pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, nameof (pool));
    BlinkSpriteTrail.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, 100675746);
    BlinkSpriteTrail.NativeMethodInfoPtr_Init_Public_Void_Sprite_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, 100675747);
    BlinkSpriteTrail.NativeMethodInfoPtr_Fade_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, 100675748);
    BlinkSpriteTrail.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, 100675749);
    BlinkSpriteTrail.NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, 100675750);
    BlinkSpriteTrail.NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, 100675751);
    BlinkSpriteTrail.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, 100675752);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119255, XrefRangeEnd = 119259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe T GetComponentFromPoolable<T>() where T : MonoBehaviour
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail.MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119259, XrefRangeEnd = 119261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(Sprite sprite, Color color = default (Color))
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail.NativeMethodInfoPtr_Init_Public_Void_Sprite_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119261, XrefRangeEnd = 119265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator Fade()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail.NativeMethodInfoPtr_Fade_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119265, XrefRangeEnd = 119270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 22243, RefRangeEnd = 22246, XrefRangeStart = 22243, XrefRangeEnd = 22246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Transform GetTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail.NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 22237, RefRangeEnd = 22242, XrefRangeStart = 22237, XrefRangeEnd = 22242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe GameObject GetGameObject()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail.NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119270, XrefRangeEnd = 119277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlinkSpriteTrail()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SpriteRenderer spriteRenderer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_spriteRenderer));
      return num == System.IntPtr.Zero ? (SpriteRenderer) null : Il2CppObjectPool.Get<SpriteRenderer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_spriteRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float fadeTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_fadeTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_fadeTime)) = value;
    }
  }

  public unsafe float startAlpha
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_startAlpha));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_startAlpha)) = value;
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, MonoBehaviour> componentCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_componentCache));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, MonoBehaviour>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, MonoBehaviour>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_componentCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ObjectPool pool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_pool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail.NativeFieldInfoPtr_pool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Effects.BlinkSpriteTrail+<Fade>d__7")]
  public sealed class _Fade_d__7(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__fadeValue_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__fadeStep_5__4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _Fade_d__7()
    {
      Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr, "<Fade>d__7");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr);
      BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, "<>1__state");
      BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, "<>2__current");
      BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, "<>4__this");
      BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, "<timer>5__2");
      BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__fadeValue_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, "<fadeValue>5__3");
      BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__fadeStep_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, "<fadeStep>5__4");
      BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, 100675753);
      BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, 100675754);
      BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, 100675755);
      BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, 100675756);
      BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, 100675757);
      BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr, 100675758);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _Fade_d__7(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BlinkSpriteTrail._Fade_d__7>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119241, XrefRangeEnd = 119250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119250, XrefRangeEnd = 119255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlinkSpriteTrail._Fade_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlinkSpriteTrail __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (BlinkSpriteTrail) null : Il2CppObjectPool.Get<BlinkSpriteTrail>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }

    public unsafe float _fadeValue_5__3
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__fadeValue_5__3));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__fadeValue_5__3)) = value;
      }
    }

    public unsafe float _fadeStep_5__4
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__fadeStep_5__4));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlinkSpriteTrail._Fade_d__7.NativeFieldInfoPtr__fadeStep_5__4)) = value;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Virtual_Final_New_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BlinkSpriteTrail.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0, Il2CppClassPointerStore<BlinkSpriteTrail>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
