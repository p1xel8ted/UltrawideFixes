// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.FilteringSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct FilteringSettings
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderQueueRange;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RenderingLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BatchLayerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ExcludeMotionVectorObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ForceAllMotionVectorObjects;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SortingLayerRange;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0;
  [FieldOffset(0)]
  public RenderQueueRange m_RenderQueueRange;
  [FieldOffset(8)]
  public int m_LayerMask;
  [FieldOffset(12)]
  public uint m_RenderingLayerMask;
  [FieldOffset(16 /*0x10*/)]
  public uint m_BatchLayerMask;
  [FieldOffset(20)]
  public int m_ExcludeMotionVectorObjects;
  [FieldOffset(24)]
  public int m_ForceAllMotionVectorObjects;
  [FieldOffset(28)]
  public SortingLayerRange m_SortingLayerRange;

  static FilteringSettings()
  {
    Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (FilteringSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr);
    FilteringSettings.NativeFieldInfoPtr_m_RenderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, nameof (m_RenderQueueRange));
    FilteringSettings.NativeFieldInfoPtr_m_LayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, nameof (m_LayerMask));
    FilteringSettings.NativeFieldInfoPtr_m_RenderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, nameof (m_RenderingLayerMask));
    FilteringSettings.NativeFieldInfoPtr_m_BatchLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, nameof (m_BatchLayerMask));
    FilteringSettings.NativeFieldInfoPtr_m_ExcludeMotionVectorObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, nameof (m_ExcludeMotionVectorObjects));
    FilteringSettings.NativeFieldInfoPtr_m_ForceAllMotionVectorObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, nameof (m_ForceAllMotionVectorObjects));
    FilteringSettings.NativeFieldInfoPtr_m_SortingLayerRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, nameof (m_SortingLayerRange));
    FilteringSettings.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100670386);
    FilteringSettings.NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100670387);
    FilteringSettings.NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100670388);
    FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100670389);
    FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100670390);
    FilteringSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100670391);
    FilteringSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, 100670392);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487619, XrefRangeEnd = 487625, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FilteringSettings(
    Il2CppSystem.Nullable<RenderQueueRange> renderQueueRange = null,
    int layerMask = -1,
    uint renderingLayerMask = 4294967295 /*0xFFFFFFFF*/,
    int excludeMotionVectorObjects = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) renderQueueRange));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &layerMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &renderingLayerMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &excludeMotionVectorObjects;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RenderQueueRange_Int32_UInt32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe uint batchLayerMask
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_batchLayerMask_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_BatchLayerMask;
  }

  public unsafe bool excludeMotionVectorObjects
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_set_excludeMotionVectorObjects_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ExcludeMotionVectorObjects != 0;
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487628, RefRangeEnd = 487630, XrefRangeStart = 487625, XrefRangeEnd = 487628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(FilteringSettings other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_FilteringSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487630, XrefRangeEnd = 487634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487634, XrefRangeEnd = 487637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487637, XrefRangeEnd = 487638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(FilteringSettings left, FilteringSettings right)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &left;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FilteringSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FilteringSettings_FilteringSettings_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FilteringSettings>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static FilteringSettings defaultValue
  {
    get => new FilteringSettings(new Il2CppSystem.Nullable<RenderQueueRange>(RenderQueueRange.all));
  }

  public RenderQueueRange renderQueueRange
  {
    get => this.m_RenderQueueRange;
    set => this.m_RenderQueueRange = value;
  }

  public int layerMask
  {
    get => this.m_LayerMask;
    set => this.m_LayerMask = value;
  }

  public uint renderingLayerMask
  {
    get => this.m_RenderingLayerMask;
    set => this.m_RenderingLayerMask = value;
  }

  public bool forceAllMotionVectorObjects
  {
    get => this.m_ForceAllMotionVectorObjects != 0;
    set => this.m_ForceAllMotionVectorObjects = value ? 1 : 0;
  }

  public SortingLayerRange sortingLayerRange
  {
    get => this.m_SortingLayerRange;
    set => this.m_SortingLayerRange = value;
  }

  public static bool operator !=(FilteringSettings left, FilteringSettings right)
  {
    return !left.Equals(right);
  }
}
