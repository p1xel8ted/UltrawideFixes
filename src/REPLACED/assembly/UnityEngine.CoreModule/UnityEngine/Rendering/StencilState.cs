// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.StencilState
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
public struct StencilState
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Enabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReadMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CompareFunctionFront;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PassOperationFront;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FailOperationFront;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ZFailOperationFront;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CompareFunctionBack;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PassOperationBack;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FailOperationBack;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ZFailOperationBack;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public byte m_Enabled;
  [FieldOffset(1)]
  public byte m_ReadMask;
  [FieldOffset(2)]
  public byte m_WriteMask;
  [FieldOffset(3)]
  public byte m_Padding;
  [FieldOffset(4)]
  public byte m_CompareFunctionFront;
  [FieldOffset(5)]
  public byte m_PassOperationFront;
  [FieldOffset(6)]
  public byte m_FailOperationFront;
  [FieldOffset(7)]
  public byte m_ZFailOperationFront;
  [FieldOffset(8)]
  public byte m_CompareFunctionBack;
  [FieldOffset(9)]
  public byte m_PassOperationBack;
  [FieldOffset(10)]
  public byte m_FailOperationBack;
  [FieldOffset(11)]
  public byte m_ZFailOperationBack;

  static StencilState()
  {
    Il2CppClassPointerStore<StencilState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (StencilState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StencilState>.NativeClassPtr);
    StencilState.NativeFieldInfoPtr_m_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_Enabled));
    StencilState.NativeFieldInfoPtr_m_ReadMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_ReadMask));
    StencilState.NativeFieldInfoPtr_m_WriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_WriteMask));
    StencilState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_Padding));
    StencilState.NativeFieldInfoPtr_m_CompareFunctionFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_CompareFunctionFront));
    StencilState.NativeFieldInfoPtr_m_PassOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_PassOperationFront));
    StencilState.NativeFieldInfoPtr_m_FailOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_FailOperationFront));
    StencilState.NativeFieldInfoPtr_m_ZFailOperationFront = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_ZFailOperationFront));
    StencilState.NativeFieldInfoPtr_m_CompareFunctionBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_CompareFunctionBack));
    StencilState.NativeFieldInfoPtr_m_PassOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_PassOperationBack));
    StencilState.NativeFieldInfoPtr_m_FailOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_FailOperationBack));
    StencilState.NativeFieldInfoPtr_m_ZFailOperationBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StencilState>.NativeClassPtr, nameof (m_ZFailOperationBack));
    StencilState.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670589);
    StencilState.NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670590);
    StencilState.NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670591);
    StencilState.NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670592);
    StencilState.NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670593);
    StencilState.NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670594);
    StencilState.NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670595);
    StencilState.NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670596);
    StencilState.NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670597);
    StencilState.NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670598);
    StencilState.NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670599);
    StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670600);
    StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670601);
    StencilState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StencilState>.NativeClassPtr, 100670602);
  }

  public unsafe bool enabled
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488722, RefRangeEnd = 488723, XrefRangeStart = 488718, XrefRangeEnd = 488722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => Il2CppSystem.Convert.ToBoolean(this.m_Enabled);
  }

  public unsafe byte readMask
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 147851, RefRangeEnd = 147852, XrefRangeStart = 147851, XrefRangeEnd = 147852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_readMask_Public_set_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ReadMask;
  }

  public unsafe byte writeMask
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488723, RefRangeEnd = 488724, XrefRangeStart = 488723, XrefRangeEnd = 488723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_writeMask_Public_set_Void_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_WriteMask;
  }

  public unsafe CompareFunction compareFunctionFront
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488724, RefRangeEnd = 488725, XrefRangeStart = 488724, XrefRangeEnd = 488724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_compareFunctionFront_Public_set_Void_CompareFunction_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (CompareFunction) this.m_CompareFunctionFront;
  }

  public unsafe StencilOp passOperationFront
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488725, RefRangeEnd = 488726, XrefRangeStart = 488725, XrefRangeEnd = 488725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_passOperationFront_Public_set_Void_StencilOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (StencilOp) this.m_PassOperationFront;
  }

  public unsafe StencilOp failOperationFront
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488726, RefRangeEnd = 488727, XrefRangeStart = 488726, XrefRangeEnd = 488726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_failOperationFront_Public_set_Void_StencilOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (StencilOp) this.m_FailOperationFront;
  }

  public unsafe StencilOp zFailOperationFront
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488727, RefRangeEnd = 488728, XrefRangeStart = 488727, XrefRangeEnd = 488727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_zFailOperationFront_Public_set_Void_StencilOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (StencilOp) this.m_ZFailOperationFront;
  }

  public unsafe CompareFunction compareFunctionBack
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488728, RefRangeEnd = 488729, XrefRangeStart = 488728, XrefRangeEnd = 488728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_compareFunctionBack_Public_set_Void_CompareFunction_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (CompareFunction) this.m_CompareFunctionBack;
  }

  public unsafe StencilOp passOperationBack
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488729, RefRangeEnd = 488730, XrefRangeStart = 488729, XrefRangeEnd = 488729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_passOperationBack_Public_set_Void_StencilOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (StencilOp) this.m_PassOperationBack;
  }

  public unsafe StencilOp failOperationBack
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488730, RefRangeEnd = 488731, XrefRangeStart = 488730, XrefRangeEnd = 488730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_failOperationBack_Public_set_Void_StencilOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (StencilOp) this.m_FailOperationBack;
  }

  public unsafe StencilOp zFailOperationBack
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 488731, RefRangeEnd = 488732, XrefRangeStart = 488731, XrefRangeEnd = 488731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_set_zFailOperationBack_Public_set_Void_StencilOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (StencilOp) this.m_ZFailOperationBack;
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(StencilState other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StencilState_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488732, XrefRangeEnd = 488736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488747, RefRangeEnd = 488748, XrefRangeStart = 488736, XrefRangeEnd = 488747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StencilState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StencilState>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static StencilState defaultValue
  {
    get
    {
      return new StencilState(true, byte.MaxValue, byte.MaxValue, CompareFunction.Always, StencilOp.Keep, StencilOp.Keep, StencilOp.Keep);
    }
  }

  public void SetCompareFunction(CompareFunction value)
  {
    this.compareFunctionFront = value;
    this.compareFunctionBack = value;
  }

  public void SetPassOperation(StencilOp value)
  {
    this.passOperationFront = value;
    this.passOperationBack = value;
  }

  public void SetFailOperation(StencilOp value)
  {
    this.failOperationFront = value;
    this.failOperationBack = value;
  }

  public void SetZFailOperation(StencilOp value)
  {
    this.zFailOperationFront = value;
    this.zFailOperationBack = value;
  }

  public static bool operator ==(StencilState left, StencilState right) => left.Equals(right);

  public static bool operator !=(StencilState left, StencilState right) => !left.Equals(right);
}
