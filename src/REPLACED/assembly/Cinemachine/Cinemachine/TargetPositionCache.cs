// Decompiled with JetBrains decompiler
// Type: Cinemachine.TargetPositionCache
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine;

public class TargetPositionCache(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_UseCache;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CacheMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentFrame;
  private static readonly System.IntPtr NativeFieldInfoPtr_IsCameraCut;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Cache;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CacheTimeRange;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CacheMode_Public_Static_get_Mode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasCurrentTime_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetPosition_Public_Static_Vector3_Transform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTargetRotation_Public_Static_Quaternion_Transform_0;

  static TargetPositionCache()
  {
    Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (TargetPositionCache));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr);
    TargetPositionCache.NativeFieldInfoPtr_UseCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (UseCache));
    TargetPositionCache.NativeFieldInfoPtr_m_CacheMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (m_CacheMode));
    TargetPositionCache.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (CurrentTime));
    TargetPositionCache.NativeFieldInfoPtr_CurrentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (CurrentFrame));
    TargetPositionCache.NativeFieldInfoPtr_IsCameraCut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (IsCameraCut));
    TargetPositionCache.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (m_Cache));
    TargetPositionCache.NativeFieldInfoPtr_m_CacheTimeRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (m_CacheTimeRange));
    TargetPositionCache.NativeMethodInfoPtr_get_CacheMode_Public_Static_get_Mode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, 100664190);
    TargetPositionCache.NativeMethodInfoPtr_get_HasCurrentTime_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, 100664191);
    TargetPositionCache.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, 100664192 /*0x06000380*/);
    TargetPositionCache.NativeMethodInfoPtr_GetTargetPosition_Public_Static_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, 100664193);
    TargetPositionCache.NativeMethodInfoPtr_GetTargetRotation_Public_Static_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, 100664194);
  }

  public static unsafe TargetPositionCache.Mode CacheMode
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944913, XrefRangeEnd = 944915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.NativeMethodInfoPtr_get_CacheMode_Public_Static_get_Mode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TargetPositionCache.Mode*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe bool HasCurrentTime
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 944917, RefRangeEnd = 944922, XrefRangeStart = 944915, XrefRangeEnd = 944917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.NativeMethodInfoPtr_get_HasCurrentTime_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 944937, RefRangeEnd = 944939, XrefRangeStart = 944922, XrefRangeEnd = 944937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ClearCache()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 944967, RefRangeEnd = 944973, XrefRangeStart = 944939, XrefRangeEnd = 944967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 GetTargetPosition(Transform target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.NativeMethodInfoPtr_GetTargetPosition_Public_Static_Vector3_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 945000, RefRangeEnd = 945005, XrefRangeStart = 944973, XrefRangeEnd = 945000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Quaternion GetTargetRotation(Transform target)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.NativeMethodInfoPtr_GetTargetRotation_Public_Static_Quaternion_Transform_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public static unsafe bool UseCache
  {
    get
    {
      bool useCache;
      IL2CPP.il2cpp_field_static_get_value(TargetPositionCache.NativeFieldInfoPtr_UseCache, (void*) &useCache);
      return useCache;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TargetPositionCache.NativeFieldInfoPtr_UseCache, (void*) &value);
    }
  }

  public static unsafe TargetPositionCache.Mode m_CacheMode
  {
    get
    {
      TargetPositionCache.Mode mCacheMode;
      IL2CPP.il2cpp_field_static_get_value(TargetPositionCache.NativeFieldInfoPtr_m_CacheMode, (void*) &mCacheMode);
      return mCacheMode;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TargetPositionCache.NativeFieldInfoPtr_m_CacheMode, (void*) &value);
    }
  }

  public static unsafe float CurrentTime
  {
    get
    {
      float currentTime;
      IL2CPP.il2cpp_field_static_get_value(TargetPositionCache.NativeFieldInfoPtr_CurrentTime, (void*) &currentTime);
      return currentTime;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TargetPositionCache.NativeFieldInfoPtr_CurrentTime, (void*) &value);
    }
  }

  public static unsafe int CurrentFrame
  {
    get
    {
      int currentFrame;
      IL2CPP.il2cpp_field_static_get_value(TargetPositionCache.NativeFieldInfoPtr_CurrentFrame, (void*) &currentFrame);
      return currentFrame;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TargetPositionCache.NativeFieldInfoPtr_CurrentFrame, (void*) &value);
    }
  }

  public static unsafe bool IsCameraCut
  {
    get
    {
      bool isCameraCut;
      IL2CPP.il2cpp_field_static_get_value(TargetPositionCache.NativeFieldInfoPtr_IsCameraCut, (void*) &isCameraCut);
      return isCameraCut;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TargetPositionCache.NativeFieldInfoPtr_IsCameraCut, (void*) &value);
    }
  }

  public static unsafe Dictionary<Transform, TargetPositionCache.CacheEntry> m_Cache
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(TargetPositionCache.NativeFieldInfoPtr_m_Cache, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<Transform, TargetPositionCache.CacheEntry>) null : Il2CppObjectPool.Get<Dictionary<Transform, TargetPositionCache.CacheEntry>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TargetPositionCache.NativeFieldInfoPtr_m_Cache, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe TargetPositionCache.TimeRange m_CacheTimeRange
  {
    get
    {
      TargetPositionCache.TimeRange mCacheTimeRange;
      IL2CPP.il2cpp_field_static_get_value(TargetPositionCache.NativeFieldInfoPtr_m_CacheTimeRange, (void*) &mCacheTimeRange);
      return mCacheTimeRange;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(TargetPositionCache.NativeFieldInfoPtr_m_CacheTimeRange, (void*) &value);
    }
  }

  public enum Mode
  {
    Disabled,
    Record,
    Playback,
  }

  public class CacheCurve(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_StepSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Cache;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Item_Single_0;

    static CacheCurve()
    {
      Il2CppClassPointerStore<TargetPositionCache.CacheCurve>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (CacheCurve));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPositionCache.CacheCurve>.NativeClassPtr);
      TargetPositionCache.CacheCurve.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheCurve>.NativeClassPtr, nameof (StartTime));
      TargetPositionCache.CacheCurve.NativeFieldInfoPtr_StepSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheCurve>.NativeClassPtr, nameof (StepSize));
      TargetPositionCache.CacheCurve.NativeFieldInfoPtr_m_Cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheCurve>.NativeClassPtr, nameof (m_Cache));
      TargetPositionCache.CacheCurve.NativeMethodInfoPtr_Evaluate_Public_Item_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.CacheCurve>.NativeClassPtr, 100664195);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 944889, RefRangeEnd = 944891, XrefRangeStart = 944877, XrefRangeEnd = 944889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TargetPositionCache.CacheCurve.Item Evaluate(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &time
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.CacheCurve.NativeMethodInfoPtr_Evaluate_Public_Item_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(TargetPositionCache.CacheCurve.Item*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe float StartTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheCurve.NativeFieldInfoPtr_StartTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheCurve.NativeFieldInfoPtr_StartTime)) = value;
      }
    }

    public unsafe float StepSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheCurve.NativeFieldInfoPtr_StepSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheCurve.NativeFieldInfoPtr_StepSize)) = value;
      }
    }

    public unsafe List<TargetPositionCache.CacheCurve.Item> m_Cache
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheCurve.NativeFieldInfoPtr_m_Cache));
        return num == System.IntPtr.Zero ? (List<TargetPositionCache.CacheCurve.Item>) null : Il2CppObjectPool.Get<List<TargetPositionCache.CacheCurve.Item>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheCurve.NativeFieldInfoPtr_m_Cache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Item
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Pos;
      private static readonly System.IntPtr NativeFieldInfoPtr_Rot;
      private static readonly System.IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Item_Item_Item_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_Item_0;
      [FieldOffset(0)]
      public Vector3 Pos;
      [FieldOffset(12)]
      public Quaternion Rot;

      static Item()
      {
        Il2CppClassPointerStore<TargetPositionCache.CacheCurve.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPositionCache.CacheCurve>.NativeClassPtr, nameof (Item));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPositionCache.CacheCurve.Item>.NativeClassPtr);
        TargetPositionCache.CacheCurve.Item.NativeFieldInfoPtr_Pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheCurve.Item>.NativeClassPtr, nameof (Pos));
        TargetPositionCache.CacheCurve.Item.NativeFieldInfoPtr_Rot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheCurve.Item>.NativeClassPtr, nameof (Rot));
        TargetPositionCache.CacheCurve.Item.NativeMethodInfoPtr_Lerp_Public_Static_Item_Item_Item_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.CacheCurve.Item>.NativeClassPtr, 100664196);
        TargetPositionCache.CacheCurve.Item.NativeMethodInfoPtr_get_Empty_Public_Static_get_Item_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.CacheCurve.Item>.NativeClassPtr, 100664197);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944874, XrefRangeEnd = 944875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe TargetPositionCache.CacheCurve.Item Lerp(
        TargetPositionCache.CacheCurve.Item a,
        TargetPositionCache.CacheCurve.Item b,
        float t)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &a;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.CacheCurve.Item.NativeMethodInfoPtr_Lerp_Public_Static_Item_Item_Item_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(TargetPositionCache.CacheCurve.Item*) IL2CPP.il2cpp_object_unbox(num2);
      }

      public static unsafe TargetPositionCache.CacheCurve.Item Empty
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944875, XrefRangeEnd = 944877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr num1;
          System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.CacheCurve.Item.NativeMethodInfoPtr_get_Empty_Public_Static_get_Item_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
          Il2CppException.RaiseExceptionIfNecessary(num1);
          return *(TargetPositionCache.CacheCurve.Item*) IL2CPP.il2cpp_object_unbox(num2);
        }
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetPositionCache.CacheCurve.Item>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }

  public class CacheEntry(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawItems;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRawItem_Public_Void_Single_Boolean_Transform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static CacheEntry()
    {
      Il2CppClassPointerStore<TargetPositionCache.CacheEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (CacheEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPositionCache.CacheEntry>.NativeClassPtr);
      TargetPositionCache.CacheEntry.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheEntry>.NativeClassPtr, nameof (Curve));
      TargetPositionCache.CacheEntry.NativeFieldInfoPtr_RawItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheEntry>.NativeClassPtr, nameof (RawItems));
      TargetPositionCache.CacheEntry.NativeMethodInfoPtr_AddRawItem_Public_Void_Single_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.CacheEntry>.NativeClassPtr, 100664198);
      TargetPositionCache.CacheEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.CacheEntry>.NativeClassPtr, 100664199);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 944891, XrefRangeEnd = 944904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddRawItem(float time, bool isCut, Transform target)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isCut;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.CacheEntry.NativeMethodInfoPtr_AddRawItem_Public_Void_Single_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 944911, RefRangeEnd = 944913, XrefRangeStart = 944904, XrefRangeEnd = 944911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CacheEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetPositionCache.CacheEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.CacheEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe TargetPositionCache.CacheCurve Curve
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheEntry.NativeFieldInfoPtr_Curve));
        return num == System.IntPtr.Zero ? (TargetPositionCache.CacheCurve) null : Il2CppObjectPool.Get<TargetPositionCache.CacheCurve>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheEntry.NativeFieldInfoPtr_Curve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<TargetPositionCache.CacheEntry.RecordingItem> RawItems
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheEntry.NativeFieldInfoPtr_RawItems));
        return num == System.IntPtr.Zero ? (List<TargetPositionCache.CacheEntry.RecordingItem>) null : Il2CppObjectPool.Get<List<TargetPositionCache.CacheEntry.RecordingItem>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetPositionCache.CacheEntry.NativeFieldInfoPtr_RawItems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct RecordingItem
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Time;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsCut;
      private static readonly System.IntPtr NativeFieldInfoPtr_Item;
      [FieldOffset(0)]
      public float Time;
      [FieldOffset(4)]
      public bool IsCut;
      [FieldOffset(8)]
      public TargetPositionCache.CacheCurve.Item Item;

      static RecordingItem()
      {
        Il2CppClassPointerStore<TargetPositionCache.CacheEntry.RecordingItem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPositionCache.CacheEntry>.NativeClassPtr, nameof (RecordingItem));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPositionCache.CacheEntry.RecordingItem>.NativeClassPtr);
        TargetPositionCache.CacheEntry.RecordingItem.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheEntry.RecordingItem>.NativeClassPtr, nameof (Time));
        TargetPositionCache.CacheEntry.RecordingItem.NativeFieldInfoPtr_IsCut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheEntry.RecordingItem>.NativeClassPtr, nameof (IsCut));
        TargetPositionCache.CacheEntry.RecordingItem.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.CacheEntry.RecordingItem>.NativeClassPtr, nameof (Item));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetPositionCache.CacheEntry.RecordingItem>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TimeRange
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Start;
    private static readonly System.IntPtr NativeFieldInfoPtr_End;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_TimeRange_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Include_Public_Void_Single_0;
    [FieldOffset(0)]
    public float Start;
    [FieldOffset(4)]
    public float End;

    static TimeRange()
    {
      Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetPositionCache>.NativeClassPtr, nameof (TimeRange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr);
      TargetPositionCache.TimeRange.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr, nameof (Start));
      TargetPositionCache.TimeRange.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr, nameof (End));
      TargetPositionCache.TimeRange.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr, 100664200);
      TargetPositionCache.TimeRange.NativeMethodInfoPtr_Contains_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr, 100664201);
      TargetPositionCache.TimeRange.NativeMethodInfoPtr_get_Empty_Public_Static_get_TimeRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr, 100664202);
      TargetPositionCache.TimeRange.NativeMethodInfoPtr_Include_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr, 100664203);
    }

    public unsafe bool IsEmpty
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.TimeRange.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    public unsafe bool Contains(float time)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &time
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.TimeRange.NativeMethodInfoPtr_Contains_Public_Boolean_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe TargetPositionCache.TimeRange Empty
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.TimeRange.NativeMethodInfoPtr_get_Empty_Public_Static_get_TimeRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(TargetPositionCache.TimeRange*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    public unsafe void Include(float time)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &time
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TargetPositionCache.TimeRange.NativeMethodInfoPtr_Include_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetPositionCache.TimeRange>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
