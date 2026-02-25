// Decompiled with JetBrains decompiler
// Type: UnityEngine.BatchRendererGroupRuntimeAnalytic
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Analytics;

#nullable disable
namespace UnityEngine;

[Serializable]
public class BatchRendererGroupRuntimeAnalytic(IntPtr pointer) : AnalyticsEventBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_brgRuntimeStatus;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateBatchRendererGroupRuntimeAnalytic_Public_Static_BatchRendererGroupRuntimeAnalytic_0;

  static BatchRendererGroupRuntimeAnalytic()
  {
    Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BatchRendererGroupRuntimeAnalytic));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr);
    BatchRendererGroupRuntimeAnalytic.NativeFieldInfoPtr_brgRuntimeStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr, nameof (brgRuntimeStatus));
    BatchRendererGroupRuntimeAnalytic.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr, 100663944);
    BatchRendererGroupRuntimeAnalytic.NativeMethodInfoPtr_CreateBatchRendererGroupRuntimeAnalytic_Public_Static_BatchRendererGroupRuntimeAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr, 100663945);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417721, XrefRangeEnd = 417726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BatchRendererGroupRuntimeAnalytic()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRendererGroupRuntimeAnalytic>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatchRendererGroupRuntimeAnalytic.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 417726, XrefRangeEnd = 417734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchRendererGroupRuntimeAnalytic.NativeMethodInfoPtr_CreateBatchRendererGroupRuntimeAnalytic_Public_Static_BatchRendererGroupRuntimeAnalytic_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (BatchRendererGroupRuntimeAnalytic) null : Il2CppObjectPool.Get<BatchRendererGroupRuntimeAnalytic>(num3);
  }

  public unsafe int brgRuntimeStatus
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRendererGroupRuntimeAnalytic.NativeFieldInfoPtr_brgRuntimeStatus));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRendererGroupRuntimeAnalytic.NativeFieldInfoPtr_brgRuntimeStatus)) = value;
    }
  }
}
