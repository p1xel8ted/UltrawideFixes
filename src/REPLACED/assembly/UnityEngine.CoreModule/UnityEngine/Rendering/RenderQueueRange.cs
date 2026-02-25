// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderQueueRange
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
public struct RenderQueueRange
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LowerBound;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UpperBound;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_MinimumBound;
  private static readonly System.IntPtr NativeFieldInfoPtr_minimumBound;
  private static readonly System.IntPtr NativeFieldInfoPtr_k_MaximumBound;
  private static readonly System.IntPtr NativeFieldInfoPtr_maximumBound;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lowerBound_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_upperBound_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public int m_LowerBound;
  [FieldOffset(4)]
  public int m_UpperBound;

  static RenderQueueRange()
  {
    Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderQueueRange));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr);
    RenderQueueRange.NativeFieldInfoPtr_m_LowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, nameof (m_LowerBound));
    RenderQueueRange.NativeFieldInfoPtr_m_UpperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, nameof (m_UpperBound));
    RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, nameof (k_MinimumBound));
    RenderQueueRange.NativeFieldInfoPtr_minimumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, nameof (minimumBound));
    RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, nameof (k_MaximumBound));
    RenderQueueRange.NativeFieldInfoPtr_maximumBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, nameof (maximumBound));
    RenderQueueRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670483);
    RenderQueueRange.NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670484);
    RenderQueueRange.NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670485);
    RenderQueueRange.NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670486);
    RenderQueueRange.NativeMethodInfoPtr_get_lowerBound_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670487);
    RenderQueueRange.NativeMethodInfoPtr_get_upperBound_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670488);
    RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670489);
    RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670490);
    RenderQueueRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, 100670491);
  }

  [CallerCount(0)]
  public unsafe RenderQueueRange(int lowerBound, int upperBound)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lowerBound;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &upperBound;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe RenderQueueRange all
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_all_Public_Static_get_RenderQueueRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderQueueRange*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe RenderQueueRange opaque
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_opaque_Public_Static_get_RenderQueueRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderQueueRange*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe RenderQueueRange transparent
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488155, RefRangeEnd = 488156, XrefRangeStart = 488155, XrefRangeEnd = 488155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_transparent_Public_Static_get_RenderQueueRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(RenderQueueRange*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int lowerBound
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_lowerBound_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      this.m_LowerBound = value >= 0 && value <= 5000 ? value : throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("The lower bound must be at least {0} and at most {1}.", (Il2CppSystem.Object) (System.ValueType) 0, (Il2CppSystem.Object) (System.ValueType) 5000));
    }
  }

  public unsafe int upperBound
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 328510, RefRangeEnd = 328569, XrefRangeStart = 328510, XrefRangeEnd = 328569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_get_upperBound_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      this.m_UpperBound = value >= 0 && value <= 5000 ? value : throw new Il2CppSystem.ArgumentOutOfRangeException(Il2CppSystem.String.Format("The upper bound must be at least {0} and at most {1}.", (Il2CppSystem.Object) (System.ValueType) 0, (Il2CppSystem.Object) (System.ValueType) 5000));
    }
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(RenderQueueRange other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderQueueRange_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488156, XrefRangeEnd = 488161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderQueueRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderQueueRange>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe int k_MinimumBound
  {
    get
    {
      int kMinimumBound;
      IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound, (void*) &kMinimumBound);
      return kMinimumBound;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_k_MinimumBound, (void*) &value);
    }
  }

  public static unsafe int minimumBound
  {
    get
    {
      int minimumBound;
      IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_minimumBound, (void*) &minimumBound);
      return minimumBound;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_minimumBound, (void*) &value);
    }
  }

  public static unsafe int k_MaximumBound
  {
    get
    {
      int kMaximumBound;
      IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound, (void*) &kMaximumBound);
      return kMaximumBound;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_k_MaximumBound, (void*) &value);
    }
  }

  public static unsafe int maximumBound
  {
    get
    {
      int maximumBound;
      IL2CPP.il2cpp_field_static_get_value(RenderQueueRange.NativeFieldInfoPtr_maximumBound, (void*) &maximumBound);
      return maximumBound;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderQueueRange.NativeFieldInfoPtr_maximumBound, (void*) &value);
    }
  }

  public static bool operator ==(RenderQueueRange left, RenderQueueRange right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(RenderQueueRange left, RenderQueueRange right)
  {
    return !left.Equals(right);
  }
}
