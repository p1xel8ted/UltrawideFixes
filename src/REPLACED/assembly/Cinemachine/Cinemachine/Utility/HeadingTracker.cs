// Decompiled with JetBrains decompiler
// Type: Cinemachine.Utility.HeadingTracker
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine.Utility;

public class HeadingTracker(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mHistory;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTop;
  private static readonly System.IntPtr NativeFieldInfoPtr_mBottom;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_mHeadingSum;
  private static readonly System.IntPtr NativeFieldInfoPtr_mWeightSum;
  private static readonly System.IntPtr NativeFieldInfoPtr_mWeightTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLastGoodHeading;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDecayExponent;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FilterSize_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ClearHistory_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Decay_Private_Static_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopBottom_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DecayHistory_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetReliableHeading_Public_Vector3_0;

  static HeadingTracker()
  {
    Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine.Utility", nameof (HeadingTracker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr);
    HeadingTracker.NativeFieldInfoPtr_mHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mHistory));
    HeadingTracker.NativeFieldInfoPtr_mTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mTop));
    HeadingTracker.NativeFieldInfoPtr_mBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mBottom));
    HeadingTracker.NativeFieldInfoPtr_mCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mCount));
    HeadingTracker.NativeFieldInfoPtr_mHeadingSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mHeadingSum));
    HeadingTracker.NativeFieldInfoPtr_mWeightSum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mWeightSum));
    HeadingTracker.NativeFieldInfoPtr_mWeightTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mWeightTime));
    HeadingTracker.NativeFieldInfoPtr_mLastGoodHeading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mLastGoodHeading));
    HeadingTracker.NativeFieldInfoPtr_mDecayExponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (mDecayExponent));
    HeadingTracker.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, 100664484);
    HeadingTracker.NativeMethodInfoPtr_get_FilterSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, 100664485);
    HeadingTracker.NativeMethodInfoPtr_ClearHistory_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, 100664486);
    HeadingTracker.NativeMethodInfoPtr_Decay_Private_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, 100664487);
    HeadingTracker.NativeMethodInfoPtr_Add_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, 100664488);
    HeadingTracker.NativeMethodInfoPtr_PopBottom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, 100664489);
    HeadingTracker.NativeMethodInfoPtr_DecayHistory_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, 100664490);
    HeadingTracker.NativeMethodInfoPtr_GetReliableHeading_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, 100664491);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947895, RefRangeEnd = 947896, XrefRangeStart = 947884, XrefRangeEnd = 947895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HeadingTracker(int filterSize)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &filterSize
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HeadingTracker.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int FilterSize
  {
    [CallerCount(89), CachedScanResults(RefRangeStart = 73100, RefRangeEnd = 73189, XrefRangeStart = 73100, XrefRangeEnd = 73189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HeadingTracker.NativeMethodInfoPtr_get_FilterSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947896, XrefRangeEnd = 947898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ClearHistory()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HeadingTracker.NativeMethodInfoPtr_ClearHistory_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947898, XrefRangeEnd = 947901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float Decay(float time)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &time
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HeadingTracker.NativeMethodInfoPtr_Decay_Private_Static_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947910, RefRangeEnd = 947911, XrefRangeStart = 947901, XrefRangeEnd = 947910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Add(Vector3 velocity)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &velocity
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HeadingTracker.NativeMethodInfoPtr_Add_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947920, RefRangeEnd = 947921, XrefRangeStart = 947911, XrefRangeEnd = 947920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PopBottom()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HeadingTracker.NativeMethodInfoPtr_PopBottom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947928, RefRangeEnd = 947929, XrefRangeStart = 947921, XrefRangeEnd = 947928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DecayHistory()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HeadingTracker.NativeMethodInfoPtr_DecayHistory_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 947937, RefRangeEnd = 947938, XrefRangeStart = 947929, XrefRangeEnd = 947937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector3 GetReliableHeading()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(HeadingTracker.NativeMethodInfoPtr_GetReliableHeading_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Il2CppStructArray<HeadingTracker.Item> mHistory
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mHistory));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<HeadingTracker.Item>) null : Il2CppObjectPool.Get<Il2CppStructArray<HeadingTracker.Item>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mHistory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int mTop
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mTop));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mTop)) = value;
    }
  }

  public unsafe int mBottom
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mBottom));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mBottom)) = value;
    }
  }

  public unsafe int mCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mCount)) = value;
    }
  }

  public unsafe Vector3 mHeadingSum
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mHeadingSum));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mHeadingSum)) = value;
    }
  }

  public unsafe float mWeightSum
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mWeightSum));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mWeightSum)) = value;
    }
  }

  public unsafe float mWeightTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mWeightTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mWeightTime)) = value;
    }
  }

  public unsafe Vector3 mLastGoodHeading
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mLastGoodHeading));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeadingTracker.NativeFieldInfoPtr_mLastGoodHeading)) = value;
    }
  }

  public static unsafe float mDecayExponent
  {
    get
    {
      float mDecayExponent;
      IL2CPP.il2cpp_field_static_get_value(HeadingTracker.NativeFieldInfoPtr_mDecayExponent, (void*) &mDecayExponent);
      return mDecayExponent;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(HeadingTracker.NativeFieldInfoPtr_mDecayExponent, (void*) &value);
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Item
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_velocity;
    private static readonly System.IntPtr NativeFieldInfoPtr_weight;
    private static readonly System.IntPtr NativeFieldInfoPtr_time;
    [FieldOffset(0)]
    public Vector3 velocity;
    [FieldOffset(12)]
    public float weight;
    [FieldOffset(16 /*0x10*/)]
    public float time;

    static Item()
    {
      Il2CppClassPointerStore<HeadingTracker.Item>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HeadingTracker>.NativeClassPtr, nameof (Item));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeadingTracker.Item>.NativeClassPtr);
      HeadingTracker.Item.NativeFieldInfoPtr_velocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker.Item>.NativeClassPtr, nameof (velocity));
      HeadingTracker.Item.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker.Item>.NativeClassPtr, nameof (weight));
      HeadingTracker.Item.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeadingTracker.Item>.NativeClassPtr, nameof (time));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HeadingTracker.Item>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
