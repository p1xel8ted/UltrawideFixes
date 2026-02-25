// Decompiled with JetBrains decompiler
// Type: UnityEngine.Analytics.BatchRenderGroupUsageAnalytic
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Analytics;

[Serializable]
public class BatchRenderGroupUsageAnalytic(IntPtr pointer) : AnalyticsEventBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_maxBRGInstance;
  private static readonly IntPtr NativeFieldInfoPtr_maxMeshCount;
  private static readonly IntPtr NativeFieldInfoPtr_maxMaterialCount;
  private static readonly IntPtr NativeFieldInfoPtr_maxDrawCommandBatch;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateBatchRenderGroupUsageAnalytic_Public_Static_BatchRenderGroupUsageAnalytic_0;

  static BatchRenderGroupUsageAnalytic()
  {
    Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Analytics", nameof (BatchRenderGroupUsageAnalytic));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr);
    BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxBRGInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, nameof (maxBRGInstance));
    BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxMeshCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, nameof (maxMeshCount));
    BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxMaterialCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, nameof (maxMaterialCount));
    BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxDrawCommandBatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, nameof (maxDrawCommandBatch));
    BatchRenderGroupUsageAnalytic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, 100669598);
    BatchRenderGroupUsageAnalytic.NativeMethodInfoPtr_CreateBatchRenderGroupUsageAnalytic_Public_Static_BatchRenderGroupUsageAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr, 100669599);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481894, XrefRangeEnd = 481899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BatchRenderGroupUsageAnalytic()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchRenderGroupUsageAnalytic>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BatchRenderGroupUsageAnalytic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481899, XrefRangeEnd = 481907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchRenderGroupUsageAnalytic.NativeMethodInfoPtr_CreateBatchRenderGroupUsageAnalytic_Public_Static_BatchRenderGroupUsageAnalytic_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (BatchRenderGroupUsageAnalytic) null : Il2CppObjectPool.Get<BatchRenderGroupUsageAnalytic>(num3);
  }

  public unsafe int maxBRGInstance
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxBRGInstance));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxBRGInstance)) = value;
    }
  }

  public unsafe int maxMeshCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxMeshCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxMeshCount)) = value;
    }
  }

  public unsafe int maxMaterialCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxMaterialCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxMaterialCount)) = value;
    }
  }

  public unsafe int maxDrawCommandBatch
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxDrawCommandBatch));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchRenderGroupUsageAnalytic.NativeFieldInfoPtr_maxDrawCommandBatch)) = value;
    }
  }
}
