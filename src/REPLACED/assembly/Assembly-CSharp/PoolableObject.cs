// Decompiled with JetBrains decompiler
// Type: PoolableObject
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
public class PoolableObject(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_lifetime;
  private static readonly System.IntPtr NativeFieldInfoPtr_positionProvider;
  private static readonly System.IntPtr NativeFieldInfoPtr_parentPool;
  private static readonly System.IntPtr NativeFieldInfoPtr_releaseAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_componentCache;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Virtual_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_ObjectPool_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetWithProvider_Public_Void_IImpactPositionProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_WaitForPooling_Private_IEnumerator_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PoolableObject()
  {
    Il2CppClassPointerStore<PoolableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (PoolableObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr);
    PoolableObject.NativeFieldInfoPtr_lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, nameof (lifetime));
    PoolableObject.NativeFieldInfoPtr_positionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, nameof (positionProvider));
    PoolableObject.NativeFieldInfoPtr_parentPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, nameof (parentPool));
    PoolableObject.NativeFieldInfoPtr_releaseAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, nameof (releaseAction));
    PoolableObject.NativeFieldInfoPtr_componentCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, nameof (componentCache));
    PoolableObject.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663668);
    PoolableObject.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663669);
    PoolableObject.NativeMethodInfoPtr_Init_Public_Void_ObjectPool_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663670);
    PoolableObject.NativeMethodInfoPtr_Init_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663671);
    PoolableObject.NativeMethodInfoPtr_ResetWithProvider_Public_Void_IImpactPositionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663672);
    PoolableObject.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663673);
    PoolableObject.NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663674);
    PoolableObject.NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663675);
    PoolableObject.NativeMethodInfoPtr_WaitForPooling_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663676);
    PoolableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, 100663677);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22197, XrefRangeEnd = 22201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe T GetComponentFromPoolable<T>() where T : MonoBehaviour
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PoolableObject.MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Virtual_Final_New_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22208, RefRangeEnd = 22209, XrefRangeStart = 22201, XrefRangeEnd = 22208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PoolableObject.NativeMethodInfoPtr_Init_Public_Virtual_New_Void_ObjectPool_FloatReference_IImpactPositionProvider_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22209, XrefRangeEnd = 22216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(ObjectPool pool, float lifetime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pool);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lifetime;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_Init_Public_Void_ObjectPool_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22221, RefRangeEnd = 22222, XrefRangeStart = 22216, XrefRangeEnd = 22221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(Il2CppSystem.Action act)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) act)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_Init_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22226, RefRangeEnd = 22227, XrefRangeStart = 22222, XrefRangeEnd = 22226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetWithProvider(IImpactPositionProvider positionProvider)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) positionProvider)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_ResetWithProvider_Public_Void_IImpactPositionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22235, RefRangeEnd = 22236, XrefRangeStart = 22227, XrefRangeEnd = 22235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 22237, RefRangeEnd = 22242, XrefRangeStart = 22236, XrefRangeEnd = 22237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe GameObject GetGameObject()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_GetGameObject_Public_Virtual_Final_New_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 22243, RefRangeEnd = 22246, XrefRangeStart = 22242, XrefRangeEnd = 22243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Transform GetTransform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_GetTransform_Public_Virtual_Final_New_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22250, RefRangeEnd = 22251, XrefRangeStart = 22246, XrefRangeEnd = 22250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IEnumerator WaitForPooling()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr_WaitForPooling_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IEnumerator) null : Il2CppObjectPool.Get<IEnumerator>(num3);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 22258, RefRangeEnd = 22265, XrefRangeStart = 22251, XrefRangeEnd = 22258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PoolableObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PoolableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatReference lifetime
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_lifetime));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_lifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IImpactPositionProvider positionProvider
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_positionProvider));
      return num == System.IntPtr.Zero ? (IImpactPositionProvider) null : Il2CppObjectPool.Get<IImpactPositionProvider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_positionProvider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ObjectPool parentPool
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_parentPool));
      return num == System.IntPtr.Zero ? (ObjectPool) null : Il2CppObjectPool.Get<ObjectPool>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_parentPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action releaseAction
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_releaseAction));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_releaseAction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, MonoBehaviour> componentCache
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_componentCache));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, MonoBehaviour>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, MonoBehaviour>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject.NativeFieldInfoPtr_componentCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("PoolableObject+<WaitForPooling>d__13")]
  public sealed class _WaitForPooling_d__13(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___2__current;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr__timer_5__2;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

    static _WaitForPooling_d__13()
    {
      Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoolableObject>.NativeClassPtr, "<WaitForPooling>d__13");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr);
      PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, "<>1__state");
      PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, "<>2__current");
      PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, "<>4__this");
      PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr__timer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, "<timer>5__2");
      PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, 100663678);
      PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, 100663679);
      PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, 100663680 /*0x06000180*/);
      PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, 100663681);
      PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, 100663682);
      PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr, 100663683);
    }

    [CallerCount(64 /*0x40*/)]
    [CachedScanResults(RefRangeStart = 16123, RefRangeEnd = 16187, XrefRangeStart = 16123, XrefRangeEnd = 16187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe _WaitForPooling_d__13(int _param1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoolableObject._WaitForPooling_d__13>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &_param1
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_IDisposable_Dispose()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22188, XrefRangeEnd = 22192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22192, XrefRangeEnd = 22197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void System_Collections_IEnumerator_Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe Il2CppSystem.Object System\u002ECollections\u002EIEnumerator\u002ECurrent
    {
      [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PoolableObject._WaitForPooling_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
      }
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public unsafe Il2CppSystem.Object __2__current
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___2__current));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PoolableObject __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (PoolableObject) null : Il2CppObjectPool.Get<PoolableObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _timer_5__2
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr__timer_5__2));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PoolableObject._WaitForPooling_d__13.NativeFieldInfoPtr__timer_5__2)) = value;
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetComponentFromPoolable_Public_Virtual_Final_New_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PoolableObject.NativeMethodInfoPtr_GetComponentFromPoolable_Public_Virtual_Final_New_T_0, Il2CppClassPointerStore<PoolableObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
