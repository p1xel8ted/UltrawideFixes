// Decompiled with JetBrains decompiler
// Type: Cinemachine.ClipperLib
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace Cinemachine;

public static class ClipperLib : Il2CppSystem.Object
{
  static ClipperLib()
  {
    Il2CppClassPointerStore<ClipperLib>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine", nameof (ClipperLib));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr);
  }

  public ClipperLib(System.IntPtr pointer)
    : base(pointer)
  {
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct DoublePoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_X;
    private static readonly System.IntPtr NativeFieldInfoPtr_Y;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_DoublePoint_0;
    [FieldOffset(0)]
    public double X;
    [FieldOffset(8)]
    public double Y;

    static DoublePoint()
    {
      Il2CppClassPointerStore<ClipperLib.DoublePoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (DoublePoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.DoublePoint>.NativeClassPtr);
      ClipperLib.DoublePoint.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.DoublePoint>.NativeClassPtr, nameof (X));
      ClipperLib.DoublePoint.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.DoublePoint>.NativeClassPtr, nameof (Y));
      ClipperLib.DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.DoublePoint>.NativeClassPtr, 100664306);
      ClipperLib.DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_DoublePoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.DoublePoint>.NativeClassPtr, 100664307);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 89011, RefRangeEnd = 89017, XrefRangeStart = 89011, XrefRangeEnd = 89017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DoublePoint(double x = 0.0, double y = 0.0)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945871, RefRangeEnd = 945872, XrefRangeStart = 945871, XrefRangeEnd = 945871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DoublePoint(ClipperLib.DoublePoint dp)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &dp
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.DoublePoint.NativeMethodInfoPtr__ctor_Public_Void_DoublePoint_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClipperLib.DoublePoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public class PolyNode(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_polygon;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_jointype;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_endtype;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Childs;
    private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddChild_Internal_Void_PolyNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Childs_Public_get_List_1_PolyNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static PolyNode()
    {
      Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (PolyNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr);
      ClipperLib.PolyNode.NativeFieldInfoPtr_m_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, nameof (m_Parent));
      ClipperLib.PolyNode.NativeFieldInfoPtr_m_polygon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, nameof (m_polygon));
      ClipperLib.PolyNode.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, nameof (m_Index));
      ClipperLib.PolyNode.NativeFieldInfoPtr_m_jointype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, nameof (m_jointype));
      ClipperLib.PolyNode.NativeFieldInfoPtr_m_endtype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, nameof (m_endtype));
      ClipperLib.PolyNode.NativeFieldInfoPtr_m_Childs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, nameof (m_Childs));
      ClipperLib.PolyNode.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, "<IsOpen>k__BackingField");
      ClipperLib.PolyNode.NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, 100664308);
      ClipperLib.PolyNode.NativeMethodInfoPtr_AddChild_Internal_Void_PolyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, 100664309);
      ClipperLib.PolyNode.NativeMethodInfoPtr_get_Childs_Public_get_List_1_PolyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, 100664310);
      ClipperLib.PolyNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr, 100664311);
    }

    public unsafe int ChildCount
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 945873, RefRangeEnd = 945880, XrefRangeStart = 945872, XrefRangeEnd = 945873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.PolyNode.NativeMethodInfoPtr_get_ChildCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945885, RefRangeEnd = 945886, XrefRangeStart = 945880, XrefRangeEnd = 945885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddChild(ClipperLib.PolyNode Child)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) Child)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.PolyNode.NativeMethodInfoPtr_AddChild_Internal_Void_PolyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe List<ClipperLib.PolyNode> Childs
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.PolyNode.NativeMethodInfoPtr_get_Childs_Public_get_List_1_PolyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (List<ClipperLib.PolyNode>) null : Il2CppObjectPool.Get<List<ClipperLib.PolyNode>>(num3);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 945899, RefRangeEnd = 945901, XrefRangeStart = 945886, XrefRangeEnd = 945899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PolyNode()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.PolyNode>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.PolyNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ClipperLib.PolyNode m_Parent
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_Parent));
        return num == System.IntPtr.Zero ? (ClipperLib.PolyNode) null : Il2CppObjectPool.Get<ClipperLib.PolyNode>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ClipperLib.IntPoint> m_polygon
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_polygon));
        return num == System.IntPtr.Zero ? (List<ClipperLib.IntPoint>) null : Il2CppObjectPool.Get<List<ClipperLib.IntPoint>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_polygon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int m_Index
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_Index));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_Index)) = value;
      }
    }

    public unsafe ClipperLib.JoinType m_jointype
    {
      get
      {
        return *(ClipperLib.JoinType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_jointype));
      }
      [param: In] set
      {
        *(ClipperLib.JoinType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_jointype)) = value;
      }
    }

    public unsafe ClipperLib.EndType m_endtype
    {
      get
      {
        return *(ClipperLib.EndType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_endtype));
      }
      [param: In] set
      {
        *(ClipperLib.EndType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_endtype)) = value;
      }
    }

    public unsafe List<ClipperLib.PolyNode> m_Childs
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_Childs));
        return num == System.IntPtr.Zero ? (List<ClipperLib.PolyNode>) null : Il2CppObjectPool.Get<List<ClipperLib.PolyNode>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr_m_Childs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _IsOpen_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr__IsOpen_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.PolyNode.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
      }
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct Int128
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_hi;
    private static readonly System.IntPtr NativeFieldInfoPtr_lo;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int128_Int128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int128_Int128_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Int128Mul_Public_Static_Int128_Int64_Int64_0;
    [FieldOffset(0)]
    public long hi;
    [FieldOffset(8)]
    public ulong lo;

    static Int128()
    {
      Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (Int128));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr);
      ClipperLib.Int128.NativeFieldInfoPtr_hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, nameof (hi));
      ClipperLib.Int128.NativeFieldInfoPtr_lo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, nameof (lo));
      ClipperLib.Int128.NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, 100664312);
      ClipperLib.Int128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, 100664313);
      ClipperLib.Int128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, 100664314);
      ClipperLib.Int128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, 100664315);
      ClipperLib.Int128.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int128_Int128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, 100664316);
      ClipperLib.Int128.NativeMethodInfoPtr_Int128Mul_Public_Static_Int128_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, 100664317);
    }

    [CallerCount(0)]
    public unsafe Int128(long _hi, ulong _lo)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &_hi;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_lo;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Int128.NativeMethodInfoPtr__ctor_Public_Void_Int64_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945901, XrefRangeEnd = 945906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(ClipperLib.Int128 val1, ClipperLib.Int128 val2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &val1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val2;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Int128.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Int128_Int128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945906, XrefRangeEnd = 945909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Int128.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945909, XrefRangeEnd = 945911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Int128.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe ClipperLib.Int128 operator -(ClipperLib.Int128 val)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &val
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Int128.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_Int128_Int128_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipperLib.Int128*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(14)]
    [CachedScanResults(RefRangeStart = 945912, RefRangeEnd = 945926, XrefRangeStart = 945911, XrefRangeEnd = 945912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ClipperLib.Int128 Int128Mul(long lhs, long rhs)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &lhs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Int128.NativeMethodInfoPtr_Int128Mul_Public_Static_Int128_Int64_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipperLib.Int128*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClipperLib.Int128>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct IntPoint
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_X;
    private static readonly System.IntPtr NativeFieldInfoPtr_Y;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPoint_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPoint_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public long X;
    [FieldOffset(8)]
    public long Y;

    static IntPoint()
    {
      Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (IntPoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr);
      ClipperLib.IntPoint.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, nameof (X));
      ClipperLib.IntPoint.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, nameof (Y));
      ClipperLib.IntPoint.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, 100664318);
      ClipperLib.IntPoint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, 100664319);
      ClipperLib.IntPoint.NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, 100664320 /*0x06000400*/);
      ClipperLib.IntPoint.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, 100664321 /*0x06000401*/);
      ClipperLib.IntPoint.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, 100664322 /*0x06000402*/);
      ClipperLib.IntPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, 100664323 /*0x06000403*/);
      ClipperLib.IntPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, 100664324 /*0x06000404*/);
    }

    [CallerCount(116)]
    [CachedScanResults(RefRangeStart = 261036, RefRangeEnd = 261152, XrefRangeStart = 261036, XrefRangeEnd = 261152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntPoint(long X, long Y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &X;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &Y;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntPoint.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 945926, RefRangeEnd = 945928, XrefRangeStart = 945926, XrefRangeEnd = 945926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntPoint(double x, double y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntPoint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945871, RefRangeEnd = 945872, XrefRangeStart = 945871, XrefRangeEnd = 945872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntPoint(ClipperLib.IntPoint pt)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &pt
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntPoint.NativeMethodInfoPtr__ctor_Public_Void_IntPoint_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 563877, RefRangeEnd = 563878, XrefRangeStart = 563877, XrefRangeEnd = 563878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(ClipperLib.IntPoint a, ClipperLib.IntPoint b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntPoint.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_IntPoint_IntPoint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 563878, RefRangeEnd = 563879, XrefRangeStart = 563878, XrefRangeEnd = 563879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(ClipperLib.IntPoint a, ClipperLib.IntPoint b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntPoint.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_IntPoint_IntPoint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945928, XrefRangeEnd = 945931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntPoint.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945931, XrefRangeEnd = 945935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntPoint.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClipperLib.IntPoint>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct IntRect
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_left;
    private static readonly System.IntPtr NativeFieldInfoPtr_top;
    private static readonly System.IntPtr NativeFieldInfoPtr_right;
    private static readonly System.IntPtr NativeFieldInfoPtr_bottom;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_Int64_Int64_0;
    [FieldOffset(0)]
    public long left;
    [FieldOffset(8)]
    public long top;
    [FieldOffset(16 /*0x10*/)]
    public long right;
    [FieldOffset(24)]
    public long bottom;

    static IntRect()
    {
      Il2CppClassPointerStore<ClipperLib.IntRect>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (IntRect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.IntRect>.NativeClassPtr);
      ClipperLib.IntRect.NativeFieldInfoPtr_left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntRect>.NativeClassPtr, nameof (left));
      ClipperLib.IntRect.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntRect>.NativeClassPtr, nameof (top));
      ClipperLib.IntRect.NativeFieldInfoPtr_right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntRect>.NativeClassPtr, nameof (right));
      ClipperLib.IntRect.NativeFieldInfoPtr_bottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntRect>.NativeClassPtr, nameof (bottom));
      ClipperLib.IntRect.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntRect>.NativeClassPtr, 100664325 /*0x06000405*/);
    }

    [CallerCount(22)]
    [CachedScanResults(RefRangeStart = 271710, RefRangeEnd = 271732, XrefRangeStart = 271710, XrefRangeEnd = 271732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntRect(long l, long t, long r, long b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &l;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &t;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &r;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntRect.NativeMethodInfoPtr__ctor_Public_Void_Int64_Int64_Int64_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClipperLib.IntRect>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }

  public enum ClipType
  {
    ctIntersection,
    ctUnion,
    ctDifference,
    ctXor,
  }

  public enum PolyType
  {
    ptSubject,
    ptClip,
  }

  public enum PolyFillType
  {
    pftEvenOdd,
    pftNonZero,
    pftPositive,
    pftNegative,
  }

  public enum JoinType
  {
    jtSquare,
    jtRound,
    jtMiter,
  }

  public enum EndType
  {
    etClosedPolygon,
    etClosedLine,
    etOpenButt,
    etOpenSquare,
    etOpenRound,
  }

  public enum EdgeSide
  {
    esLeft,
    esRight,
  }

  public enum Direction
  {
    dRightToLeft,
    dLeftToRight,
  }

  public class TEdge(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Bot;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curr;
    private static readonly System.IntPtr NativeFieldInfoPtr_Top;
    private static readonly System.IntPtr NativeFieldInfoPtr_Delta;
    private static readonly System.IntPtr NativeFieldInfoPtr_Dx;
    private static readonly System.IntPtr NativeFieldInfoPtr_PolyTyp;
    private static readonly System.IntPtr NativeFieldInfoPtr_Side;
    private static readonly System.IntPtr NativeFieldInfoPtr_WindDelta;
    private static readonly System.IntPtr NativeFieldInfoPtr_WindCnt;
    private static readonly System.IntPtr NativeFieldInfoPtr_WindCnt2;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutIdx;
    private static readonly System.IntPtr NativeFieldInfoPtr_Next;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prev;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextInLML;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextInAEL;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrevInAEL;
    private static readonly System.IntPtr NativeFieldInfoPtr_NextInSEL;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrevInSEL;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static TEdge()
    {
      Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (TEdge));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr);
      ClipperLib.TEdge.NativeFieldInfoPtr_Bot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (Bot));
      ClipperLib.TEdge.NativeFieldInfoPtr_Curr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (Curr));
      ClipperLib.TEdge.NativeFieldInfoPtr_Top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (Top));
      ClipperLib.TEdge.NativeFieldInfoPtr_Delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (Delta));
      ClipperLib.TEdge.NativeFieldInfoPtr_Dx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (Dx));
      ClipperLib.TEdge.NativeFieldInfoPtr_PolyTyp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (PolyTyp));
      ClipperLib.TEdge.NativeFieldInfoPtr_Side = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (Side));
      ClipperLib.TEdge.NativeFieldInfoPtr_WindDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (WindDelta));
      ClipperLib.TEdge.NativeFieldInfoPtr_WindCnt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (WindCnt));
      ClipperLib.TEdge.NativeFieldInfoPtr_WindCnt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (WindCnt2));
      ClipperLib.TEdge.NativeFieldInfoPtr_OutIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (OutIdx));
      ClipperLib.TEdge.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (Next));
      ClipperLib.TEdge.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (Prev));
      ClipperLib.TEdge.NativeFieldInfoPtr_NextInLML = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (NextInLML));
      ClipperLib.TEdge.NativeFieldInfoPtr_NextInAEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (NextInAEL));
      ClipperLib.TEdge.NativeFieldInfoPtr_PrevInAEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (PrevInAEL));
      ClipperLib.TEdge.NativeFieldInfoPtr_NextInSEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (NextInSEL));
      ClipperLib.TEdge.NativeFieldInfoPtr_PrevInSEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, nameof (PrevInSEL));
      ClipperLib.TEdge.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr, 100664326 /*0x06000406*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TEdge()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.TEdge>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.TEdge.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ClipperLib.IntPoint Bot
    {
      get
      {
        return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Bot));
      }
      [param: In] set
      {
        *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Bot)) = value;
      }
    }

    public unsafe ClipperLib.IntPoint Curr
    {
      get
      {
        return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Curr));
      }
      [param: In] set
      {
        *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Curr)) = value;
      }
    }

    public unsafe ClipperLib.IntPoint Top
    {
      get
      {
        return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Top));
      }
      [param: In] set
      {
        *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Top)) = value;
      }
    }

    public unsafe ClipperLib.IntPoint Delta
    {
      get
      {
        return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Delta));
      }
      [param: In] set
      {
        *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Delta)) = value;
      }
    }

    public unsafe double Dx
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Dx));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Dx)) = value;
      }
    }

    public unsafe ClipperLib.PolyType PolyTyp
    {
      get
      {
        return *(ClipperLib.PolyType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_PolyTyp));
      }
      [param: In] set
      {
        *(ClipperLib.PolyType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_PolyTyp)) = value;
      }
    }

    public unsafe ClipperLib.EdgeSide Side
    {
      get
      {
        return *(ClipperLib.EdgeSide*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Side));
      }
      [param: In] set
      {
        *(ClipperLib.EdgeSide*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Side)) = value;
      }
    }

    public unsafe int WindDelta
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_WindDelta));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_WindDelta)) = value;
      }
    }

    public unsafe int WindCnt
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_WindCnt));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_WindCnt)) = value;
      }
    }

    public unsafe int WindCnt2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_WindCnt2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_WindCnt2)) = value;
      }
    }

    public unsafe int OutIdx
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_OutIdx));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_OutIdx)) = value;
      }
    }

    public unsafe ClipperLib.TEdge Next
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Next));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge Prev
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Prev));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge NextInLML
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_NextInLML));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_NextInLML), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge NextInAEL
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_NextInAEL));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_NextInAEL), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge PrevInAEL
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_PrevInAEL));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_PrevInAEL), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge NextInSEL
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_NextInSEL));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_NextInSEL), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge PrevInSEL
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_PrevInSEL));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.TEdge.NativeFieldInfoPtr_PrevInSEL), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class IntersectNode(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Edge1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Edge2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pt;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static IntersectNode()
    {
      Il2CppClassPointerStore<ClipperLib.IntersectNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (IntersectNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.IntersectNode>.NativeClassPtr);
      ClipperLib.IntersectNode.NativeFieldInfoPtr_Edge1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntersectNode>.NativeClassPtr, nameof (Edge1));
      ClipperLib.IntersectNode.NativeFieldInfoPtr_Edge2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntersectNode>.NativeClassPtr, nameof (Edge2));
      ClipperLib.IntersectNode.NativeFieldInfoPtr_Pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.IntersectNode>.NativeClassPtr, nameof (Pt));
      ClipperLib.IntersectNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.IntersectNode>.NativeClassPtr, 100664327 /*0x06000407*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntersectNode()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.IntersectNode>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.IntersectNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ClipperLib.TEdge Edge1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.IntersectNode.NativeFieldInfoPtr_Edge1));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.IntersectNode.NativeFieldInfoPtr_Edge1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge Edge2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.IntersectNode.NativeFieldInfoPtr_Edge2));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.IntersectNode.NativeFieldInfoPtr_Edge2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.IntPoint Pt
    {
      get
      {
        return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.IntersectNode.NativeFieldInfoPtr_Pt));
      }
      [param: In] set
      {
        *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.IntersectNode.NativeFieldInfoPtr_Pt)) = value;
      }
    }
  }

  public class MyIntersectNodeSort(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IntersectNode_IntersectNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static MyIntersectNodeSort()
    {
      Il2CppClassPointerStore<ClipperLib.MyIntersectNodeSort>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (MyIntersectNodeSort));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.MyIntersectNodeSort>.NativeClassPtr);
      ClipperLib.MyIntersectNodeSort.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IntersectNode_IntersectNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.MyIntersectNodeSort>.NativeClassPtr, 100664328 /*0x06000408*/);
      ClipperLib.MyIntersectNodeSort.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.MyIntersectNodeSort>.NativeClassPtr, 100664329 /*0x06000409*/);
    }

    [CallerCount(0)]
    public virtual unsafe int Compare(
      ClipperLib.IntersectNode node1,
      ClipperLib.IntersectNode node2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.MyIntersectNodeSort.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IntersectNode_IntersectNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MyIntersectNodeSort()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.MyIntersectNodeSort>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.MyIntersectNodeSort.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public class LocalMinima(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Y;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeftBound;
    private static readonly System.IntPtr NativeFieldInfoPtr_RightBound;
    private static readonly System.IntPtr NativeFieldInfoPtr_Next;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static LocalMinima()
    {
      Il2CppClassPointerStore<ClipperLib.LocalMinima>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (LocalMinima));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.LocalMinima>.NativeClassPtr);
      ClipperLib.LocalMinima.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.LocalMinima>.NativeClassPtr, nameof (Y));
      ClipperLib.LocalMinima.NativeFieldInfoPtr_LeftBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.LocalMinima>.NativeClassPtr, nameof (LeftBound));
      ClipperLib.LocalMinima.NativeFieldInfoPtr_RightBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.LocalMinima>.NativeClassPtr, nameof (RightBound));
      ClipperLib.LocalMinima.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.LocalMinima>.NativeClassPtr, nameof (Next));
      ClipperLib.LocalMinima.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.LocalMinima>.NativeClassPtr, 100664330 /*0x0600040A*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalMinima()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.LocalMinima>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.LocalMinima.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe long Y
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.LocalMinima.NativeFieldInfoPtr_Y));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.LocalMinima.NativeFieldInfoPtr_Y)) = value;
      }
    }

    public unsafe ClipperLib.TEdge LeftBound
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.LocalMinima.NativeFieldInfoPtr_LeftBound));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.LocalMinima.NativeFieldInfoPtr_LeftBound), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge RightBound
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.LocalMinima.NativeFieldInfoPtr_RightBound));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.LocalMinima.NativeFieldInfoPtr_RightBound), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.LocalMinima Next
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.LocalMinima.NativeFieldInfoPtr_Next));
        return num == System.IntPtr.Zero ? (ClipperLib.LocalMinima) null : Il2CppObjectPool.Get<ClipperLib.LocalMinima>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.LocalMinima.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class Scanbeam(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Y;
    private static readonly System.IntPtr NativeFieldInfoPtr_Next;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static Scanbeam()
    {
      Il2CppClassPointerStore<ClipperLib.Scanbeam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (Scanbeam));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.Scanbeam>.NativeClassPtr);
      ClipperLib.Scanbeam.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Scanbeam>.NativeClassPtr, nameof (Y));
      ClipperLib.Scanbeam.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Scanbeam>.NativeClassPtr, nameof (Next));
      ClipperLib.Scanbeam.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Scanbeam>.NativeClassPtr, 100664331 /*0x0600040B*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Scanbeam()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.Scanbeam>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Scanbeam.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe long Y
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Scanbeam.NativeFieldInfoPtr_Y));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Scanbeam.NativeFieldInfoPtr_Y)) = value;
      }
    }

    public unsafe ClipperLib.Scanbeam Next
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Scanbeam.NativeFieldInfoPtr_Next));
        return num == System.IntPtr.Zero ? (ClipperLib.Scanbeam) null : Il2CppObjectPool.Get<ClipperLib.Scanbeam>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Scanbeam.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class Maxima(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_X;
    private static readonly System.IntPtr NativeFieldInfoPtr_Next;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prev;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static Maxima()
    {
      Il2CppClassPointerStore<ClipperLib.Maxima>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (Maxima));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.Maxima>.NativeClassPtr);
      ClipperLib.Maxima.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Maxima>.NativeClassPtr, nameof (X));
      ClipperLib.Maxima.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Maxima>.NativeClassPtr, nameof (Next));
      ClipperLib.Maxima.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Maxima>.NativeClassPtr, nameof (Prev));
      ClipperLib.Maxima.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Maxima>.NativeClassPtr, 100664332 /*0x0600040C*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Maxima()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.Maxima>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Maxima.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe long X
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Maxima.NativeFieldInfoPtr_X));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Maxima.NativeFieldInfoPtr_X)) = value;
      }
    }

    public unsafe ClipperLib.Maxima Next
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Maxima.NativeFieldInfoPtr_Next));
        return num == System.IntPtr.Zero ? (ClipperLib.Maxima) null : Il2CppObjectPool.Get<ClipperLib.Maxima>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Maxima.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.Maxima Prev
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Maxima.NativeFieldInfoPtr_Prev));
        return num == System.IntPtr.Zero ? (ClipperLib.Maxima) null : Il2CppObjectPool.Get<ClipperLib.Maxima>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Maxima.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class OutRec(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Idx;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsHole;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsOpen;
    private static readonly System.IntPtr NativeFieldInfoPtr_FirstLeft;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pts;
    private static readonly System.IntPtr NativeFieldInfoPtr_BottomPt;
    private static readonly System.IntPtr NativeFieldInfoPtr_PolyNode;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static OutRec()
    {
      Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (OutRec));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr);
      ClipperLib.OutRec.NativeFieldInfoPtr_Idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr, nameof (Idx));
      ClipperLib.OutRec.NativeFieldInfoPtr_IsHole = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr, nameof (IsHole));
      ClipperLib.OutRec.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr, nameof (IsOpen));
      ClipperLib.OutRec.NativeFieldInfoPtr_FirstLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr, nameof (FirstLeft));
      ClipperLib.OutRec.NativeFieldInfoPtr_Pts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr, nameof (Pts));
      ClipperLib.OutRec.NativeFieldInfoPtr_BottomPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr, nameof (BottomPt));
      ClipperLib.OutRec.NativeFieldInfoPtr_PolyNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr, nameof (PolyNode));
      ClipperLib.OutRec.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr, 100664333 /*0x0600040D*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OutRec()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.OutRec>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.OutRec.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int Idx
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_Idx));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_Idx)) = value;
      }
    }

    public unsafe bool IsHole
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_IsHole));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_IsHole)) = value;
      }
    }

    public unsafe bool IsOpen
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_IsOpen));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_IsOpen)) = value;
      }
    }

    public unsafe ClipperLib.OutRec FirstLeft
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_FirstLeft));
        return num == System.IntPtr.Zero ? (ClipperLib.OutRec) null : Il2CppObjectPool.Get<ClipperLib.OutRec>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_FirstLeft), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.OutPt Pts
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_Pts));
        return num == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_Pts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.OutPt BottomPt
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_BottomPt));
        return num == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_BottomPt), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.PolyNode PolyNode
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_PolyNode));
        return num == System.IntPtr.Zero ? (ClipperLib.PolyNode) null : Il2CppObjectPool.Get<ClipperLib.PolyNode>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutRec.NativeFieldInfoPtr_PolyNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class OutPt(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Idx;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pt;
    private static readonly System.IntPtr NativeFieldInfoPtr_Next;
    private static readonly System.IntPtr NativeFieldInfoPtr_Prev;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static OutPt()
    {
      Il2CppClassPointerStore<ClipperLib.OutPt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (OutPt));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.OutPt>.NativeClassPtr);
      ClipperLib.OutPt.NativeFieldInfoPtr_Idx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutPt>.NativeClassPtr, nameof (Idx));
      ClipperLib.OutPt.NativeFieldInfoPtr_Pt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutPt>.NativeClassPtr, nameof (Pt));
      ClipperLib.OutPt.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutPt>.NativeClassPtr, nameof (Next));
      ClipperLib.OutPt.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.OutPt>.NativeClassPtr, nameof (Prev));
      ClipperLib.OutPt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.OutPt>.NativeClassPtr, 100664334 /*0x0600040E*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OutPt()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.OutPt>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.OutPt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int Idx
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutPt.NativeFieldInfoPtr_Idx));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutPt.NativeFieldInfoPtr_Idx)) = value;
      }
    }

    public unsafe ClipperLib.IntPoint Pt
    {
      get
      {
        return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutPt.NativeFieldInfoPtr_Pt));
      }
      [param: In] set
      {
        *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutPt.NativeFieldInfoPtr_Pt)) = value;
      }
    }

    public unsafe ClipperLib.OutPt Next
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutPt.NativeFieldInfoPtr_Next));
        return num == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutPt.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.OutPt Prev
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutPt.NativeFieldInfoPtr_Prev));
        return num == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.OutPt.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class Join(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OutPt1;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutPt2;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffPt;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static Join()
    {
      Il2CppClassPointerStore<ClipperLib.Join>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (Join));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.Join>.NativeClassPtr);
      ClipperLib.Join.NativeFieldInfoPtr_OutPt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Join>.NativeClassPtr, nameof (OutPt1));
      ClipperLib.Join.NativeFieldInfoPtr_OutPt2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Join>.NativeClassPtr, nameof (OutPt2));
      ClipperLib.Join.NativeFieldInfoPtr_OffPt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Join>.NativeClassPtr, nameof (OffPt));
      ClipperLib.Join.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Join>.NativeClassPtr, 100664335 /*0x0600040F*/);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Join()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.Join>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Join.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ClipperLib.OutPt OutPt1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Join.NativeFieldInfoPtr_OutPt1));
        return num == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Join.NativeFieldInfoPtr_OutPt1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.OutPt OutPt2
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Join.NativeFieldInfoPtr_OutPt2));
        return num == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Join.NativeFieldInfoPtr_OutPt2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.IntPoint OffPt
    {
      get
      {
        return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Join.NativeFieldInfoPtr_OffPt));
      }
      [param: In] set
      {
        *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Join.NativeFieldInfoPtr_OffPt)) = value;
      }
    }
  }

  public class ClipperBase(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MinimaList;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentLM;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_edges;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Scanbeam;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PolyOuts;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ActiveEdges;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UseFullRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_HasOpenPaths;
    private static readonly System.IntPtr NativeFieldInfoPtr__PreserveCollinear_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_near_zero_Internal_Static_Boolean_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PreserveCollinear_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PreserveCollinear_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Swap_Public_Void_byref_Int64_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsHorizontal_Internal_Static_Boolean_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_TEdge_TEdge_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_IntPoint_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisposeLocalMinimaList_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RangeTest_Private_Void_IntPoint_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitEdge_Private_Void_TEdge_TEdge_TEdge_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InitEdge2_Private_Void_TEdge_PolyType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindNextLocMin_Private_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessBound_Private_TEdge_TEdge_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPath_Public_Boolean_List_1_IntPoint_PolyType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPaths_Public_Boolean_List_1_List_1_IntPoint_PolyType_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Pt2IsBetweenPt1AndPt3_Internal_Boolean_IntPoint_IntPoint_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEdge_Private_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetDx_Private_Void_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertLocalMinima_Private_Void_LocalMinima_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PopLocalMinima_Internal_Boolean_Int64_byref_LocalMinima_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReverseHorizontal_Private_Void_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBounds_Public_Static_IntRect_List_1_List_1_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertScanbeam_Internal_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PopScanbeam_Internal_Boolean_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LocalMinimaPending_Internal_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateOutRec_Internal_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisposeOutRec_Internal_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEdgeIntoAEL_Internal_Void_byref_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SwapPositionsInAEL_Internal_Void_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeleteFromAEL_Internal_Void_TEdge_0;

    static ClipperBase()
    {
      Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (ClipperBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr);
      ClipperLib.ClipperBase.NativeFieldInfoPtr_m_MinimaList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, nameof (m_MinimaList));
      ClipperLib.ClipperBase.NativeFieldInfoPtr_m_CurrentLM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, nameof (m_CurrentLM));
      ClipperLib.ClipperBase.NativeFieldInfoPtr_m_edges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, nameof (m_edges));
      ClipperLib.ClipperBase.NativeFieldInfoPtr_m_Scanbeam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, nameof (m_Scanbeam));
      ClipperLib.ClipperBase.NativeFieldInfoPtr_m_PolyOuts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, nameof (m_PolyOuts));
      ClipperLib.ClipperBase.NativeFieldInfoPtr_m_ActiveEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, nameof (m_ActiveEdges));
      ClipperLib.ClipperBase.NativeFieldInfoPtr_m_UseFullRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, nameof (m_UseFullRange));
      ClipperLib.ClipperBase.NativeFieldInfoPtr_m_HasOpenPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, nameof (m_HasOpenPaths));
      ClipperLib.ClipperBase.NativeFieldInfoPtr__PreserveCollinear_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, "<PreserveCollinear>k__BackingField");
      ClipperLib.ClipperBase.NativeMethodInfoPtr_near_zero_Internal_Static_Boolean_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664336 /*0x06000410*/);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_get_PreserveCollinear_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664337);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_set_PreserveCollinear_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664338);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_Swap_Public_Void_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664339);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_IsHorizontal_Internal_Static_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664340);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_TEdge_TEdge_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664341);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664342);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664343);
      ClipperLib.ClipperBase.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664344);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664345);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_DisposeLocalMinimaList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664346);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_RangeTest_Private_Void_IntPoint_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664347);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_InitEdge_Private_Void_TEdge_TEdge_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664348);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_InitEdge2_Private_Void_TEdge_PolyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664349);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_FindNextLocMin_Private_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664350);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_ProcessBound_Private_TEdge_TEdge_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664351);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_AddPath_Public_Boolean_List_1_IntPoint_PolyType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664352 /*0x06000420*/);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_AddPaths_Public_Boolean_List_1_List_1_IntPoint_PolyType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664353);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_Pt2IsBetweenPt1AndPt3_Internal_Boolean_IntPoint_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664354);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_RemoveEdge_Private_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664355);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_SetDx_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664356);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_InsertLocalMinima_Private_Void_LocalMinima_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664357);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_PopLocalMinima_Internal_Boolean_Int64_byref_LocalMinima_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664358);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_ReverseHorizontal_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664359);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664360);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_GetBounds_Public_Static_IntRect_List_1_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664361);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_InsertScanbeam_Internal_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664362);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_PopScanbeam_Internal_Boolean_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664363);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_LocalMinimaPending_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664364);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_CreateOutRec_Internal_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664365);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_DisposeOutRec_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664366);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_UpdateEdgeIntoAEL_Internal_Void_byref_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664367);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_SwapPositionsInAEL_Internal_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664368 /*0x06000430*/);
      ClipperLib.ClipperBase.NativeMethodInfoPtr_DeleteFromAEL_Internal_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr, 100664369);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 945935, RefRangeEnd = 945936, XrefRangeStart = 945935, XrefRangeEnd = 945935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool near_zero(double val)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &val
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_near_zero_Internal_Static_Boolean_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe bool PreserveCollinear
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_get_PreserveCollinear_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_set_PreserveCollinear_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    public unsafe void Swap(ref long val1, ref long val2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref val1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref val2;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_Swap_Public_Void_byref_Int64_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public static unsafe bool IsHorizontal(ClipperLib.TEdge e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_IsHorizontal_Internal_Static_Boolean_TEdge_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe bool SlopesEqual(
      ClipperLib.TEdge e1,
      ClipperLib.TEdge e2,
      bool UseFullRange)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e2);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &UseFullRange;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_TEdge_TEdge_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe bool SlopesEqual(
      ClipperLib.IntPoint pt1,
      ClipperLib.IntPoint pt2,
      ClipperLib.IntPoint pt3,
      bool UseFullRange)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &pt1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pt2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pt3;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &UseFullRange;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe bool SlopesEqual(
      ClipperLib.IntPoint pt1,
      ClipperLib.IntPoint pt2,
      ClipperLib.IntPoint pt3,
      ClipperLib.IntPoint pt4,
      bool UseFullRange)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &pt1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pt2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pt3;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pt4;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &UseFullRange;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_SlopesEqual_Internal_Static_Boolean_IntPoint_IntPoint_IntPoint_IntPoint_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945936, XrefRangeEnd = 945943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.ClipperBase>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945943, XrefRangeEnd = 945960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClipperLib.ClipperBase.NativeMethodInfoPtr_Clear_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void DisposeLocalMinimaList()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_DisposeLocalMinimaList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 945961, RefRangeEnd = 945965, XrefRangeStart = 945960, XrefRangeEnd = 945961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RangeTest(ClipperLib.IntPoint Pt, ref bool useFullRange)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &Pt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref useFullRange;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_RangeTest_Private_Void_IntPoint_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void InitEdge(
      ClipperLib.TEdge e,
      ClipperLib.TEdge eNext,
      ClipperLib.TEdge ePrev,
      ClipperLib.IntPoint pt)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eNext);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ePrev);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &pt;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_InitEdge_Private_Void_TEdge_TEdge_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945965, XrefRangeEnd = 945966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InitEdge2(ClipperLib.TEdge e, ClipperLib.PolyType polyType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &polyType;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_InitEdge2_Private_Void_TEdge_PolyType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945966, XrefRangeEnd = 945968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.TEdge FindNextLocMin(ClipperLib.TEdge E)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) E)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_FindNextLocMin_Private_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num3);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 945971, RefRangeEnd = 945975, XrefRangeStart = 945968, XrefRangeEnd = 945971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.TEdge ProcessBound(ClipperLib.TEdge E, bool LeftBoundIsForward)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) E);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &LeftBoundIsForward;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_ProcessBound_Private_TEdge_TEdge_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num3);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946121, RefRangeEnd = 946123, XrefRangeStart = 945975, XrefRangeEnd = 946121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AddPath(
      List<ClipperLib.IntPoint> pg,
      ClipperLib.PolyType polyType,
      bool Closed)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pg);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &polyType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &Closed;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_AddPath_Public_Boolean_List_1_IntPoint_PolyType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 946129, RefRangeEnd = 946132, XrefRangeStart = 946123, XrefRangeEnd = 946129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool AddPaths(
      List<List<ClipperLib.IntPoint>> ppg,
      ClipperLib.PolyType polyType,
      bool closed)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ppg);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &polyType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &closed;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_AddPaths_Public_Boolean_List_1_List_1_IntPoint_PolyType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool Pt2IsBetweenPt1AndPt3(
      ClipperLib.IntPoint pt1,
      ClipperLib.IntPoint pt2,
      ClipperLib.IntPoint pt3)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &pt1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pt2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pt3;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_Pt2IsBetweenPt1AndPt3_Internal_Boolean_IntPoint_IntPoint_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe ClipperLib.TEdge RemoveEdge(ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_RemoveEdge_Private_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num3);
    }

    [CallerCount(0)]
    public unsafe void SetDx(ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_SetDx_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946132, XrefRangeEnd = 946133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InsertLocalMinima(ClipperLib.LocalMinima newLm)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) newLm)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_InsertLocalMinima_Private_Void_LocalMinima_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool PopLocalMinima(long Y, out ClipperLib.LocalMinima current)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) &Y;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr num2;
      System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_PopLocalMinima_Internal_Boolean_Int64_byref_LocalMinima_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
      Il2CppException.RaiseExceptionIfNecessary(num2);
      ref ClipperLib.LocalMinima local = ref current;
      System.IntPtr pointer = zero;
      ClipperLib.LocalMinima localMinima = pointer == System.IntPtr.Zero ? (ClipperLib.LocalMinima) null : new ClipperLib.LocalMinima(pointer);
      local = localMinima;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
    }

    [CallerCount(0)]
    public unsafe void ReverseHorizontal(ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_ReverseHorizontal_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946133, XrefRangeEnd = 946145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Reset()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClipperLib.ClipperBase.NativeMethodInfoPtr_Reset_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946192, RefRangeEnd = 946194, XrefRangeStart = 946145, XrefRangeEnd = 946192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ClipperLib.IntRect GetBounds(List<List<ClipperLib.IntPoint>> paths)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) paths)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_GetBounds_Public_Static_IntRect_List_1_List_1_IntPoint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipperLib.IntRect*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 946198, RefRangeEnd = 946203, XrefRangeStart = 946194, XrefRangeEnd = 946198, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InsertScanbeam(long Y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &Y
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_InsertScanbeam_Internal_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool PopScanbeam(out long Y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) ref Y
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_PopScanbeam_Internal_Boolean_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 302664, RefRangeEnd = 302672, XrefRangeStart = 302664, XrefRangeEnd = 302672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool LocalMinimaPending()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_LocalMinimaPending_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 946212, RefRangeEnd = 946217, XrefRangeStart = 946203, XrefRangeEnd = 946212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.OutRec CreateOutRec()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_CreateOutRec_Internal_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutRec) null : Il2CppObjectPool.Get<ClipperLib.OutRec>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946217, XrefRangeEnd = 946224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisposeOutRec(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_DisposeOutRec_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 946226, RefRangeEnd = 946229, XrefRangeStart = 946224, XrefRangeEnd = 946226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateEdgeIntoAEL(ref ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_UpdateEdgeIntoAEL_Internal_Void_byref_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      ref ClipperLib.TEdge local = ref e;
      System.IntPtr pointer = ptr;
      ClipperLib.TEdge tedge = pointer == System.IntPtr.Zero ? (ClipperLib.TEdge) null : new ClipperLib.TEdge(pointer);
      local = tedge;
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 946231, RefRangeEnd = 946234, XrefRangeStart = 946229, XrefRangeEnd = 946231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SwapPositionsInAEL(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge2);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_SwapPositionsInAEL_Internal_Void_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946234, XrefRangeEnd = 946235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DeleteFromAEL(ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperBase.NativeMethodInfoPtr_DeleteFromAEL_Internal_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ClipperLib.LocalMinima m_MinimaList
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_MinimaList));
        return num == System.IntPtr.Zero ? (ClipperLib.LocalMinima) null : Il2CppObjectPool.Get<ClipperLib.LocalMinima>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_MinimaList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.LocalMinima m_CurrentLM
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_CurrentLM));
        return num == System.IntPtr.Zero ? (ClipperLib.LocalMinima) null : Il2CppObjectPool.Get<ClipperLib.LocalMinima>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_CurrentLM), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<List<ClipperLib.TEdge>> m_edges
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_edges));
        return num == System.IntPtr.Zero ? (List<List<ClipperLib.TEdge>>) null : Il2CppObjectPool.Get<List<List<ClipperLib.TEdge>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_edges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.Scanbeam m_Scanbeam
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_Scanbeam));
        return num == System.IntPtr.Zero ? (ClipperLib.Scanbeam) null : Il2CppObjectPool.Get<ClipperLib.Scanbeam>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_Scanbeam), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ClipperLib.OutRec> m_PolyOuts
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_PolyOuts));
        return num == System.IntPtr.Zero ? (List<ClipperLib.OutRec>) null : Il2CppObjectPool.Get<List<ClipperLib.OutRec>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_PolyOuts), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge m_ActiveEdges
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_ActiveEdges));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_ActiveEdges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool m_UseFullRange
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_UseFullRange));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_UseFullRange)) = value;
      }
    }

    public unsafe bool m_HasOpenPaths
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_HasOpenPaths));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr_m_HasOpenPaths)) = value;
      }
    }

    public unsafe bool _PreserveCollinear_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr__PreserveCollinear_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperBase.NativeFieldInfoPtr__PreserveCollinear_k__BackingField)) = value;
      }
    }
  }

  public class Clipper(System.IntPtr pointer) : ClipperLib.ClipperBase(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClipType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Maxima;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SortedEdges;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IntersectList;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IntersectNodeComparer;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ExecuteLocked;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClipFillType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SubjFillType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Joins;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_GhostJoins;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UsingPolyTree;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReverseSolution_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__StrictlySimple_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertMaxima_Private_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ReverseSolution_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ReverseSolution_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StrictlySimple_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StrictlySimple_Public_set_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_PolyFillType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExecuteInternal_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisposeAllPolyPts_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddJoin_Private_Void_OutPt_OutPt_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddGhostJoin_Private_Void_OutPt_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertLocalMinimaIntoAEL_Private_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InsertEdgeIntoAEL_Private_Void_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_E2InsertsBeforeE1_Private_Boolean_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEvenOddFillType_Private_Boolean_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEvenOddAltFillType_Private_Boolean_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsContributing_Private_Boolean_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetWindingCount_Private_Void_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddEdgeToSEL_Private_Void_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PopEdgeFromSEL_Internal_Boolean_byref_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAELToSEL_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SwapPositionsInSEL_Private_Void_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLocalMaxPoly_Private_Void_TEdge_TEdge_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddLocalMinPoly_Private_OutPt_TEdge_TEdge_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddOutPt_Private_OutPt_TEdge_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLastOutPt_Private_OutPt_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HorzSegmentsOverlap_Private_Boolean_Int64_Int64_Int64_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetHoleState_Private_Void_TEdge_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDx_Private_Double_IntPoint_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FirstIsBottomPt_Private_Boolean_OutPt_OutPt_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBottomPt_Private_OutPt_OutPt_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLowermostRec_Private_OutRec_OutRec_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OutRec1RightOfOutRec2_Private_Boolean_OutRec_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOutRec_Private_OutRec_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendPolygon_Private_Void_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReversePolyPtLinks_Private_Void_OutPt_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SwapSides_Private_Static_Void_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SwapPolyIndexes_Private_Static_Void_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IntersectEdges_Private_Void_TEdge_TEdge_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessHorizontals_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHorzDirection_Private_Void_TEdge_byref_Direction_byref_Int64_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessHorizontal_Private_Void_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetNextInAEL_Private_TEdge_TEdge_Direction_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsMaxima_Private_Boolean_TEdge_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsIntermediate_Private_Boolean_TEdge_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaximaPair_Internal_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaximaPairEx_Internal_TEdge_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessIntersections_Private_Boolean_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildIntersectList_Private_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EdgesAdjacent_Private_Boolean_IntersectNode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FixupIntersectionOrder_Private_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessIntersectList_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TopX_Private_Static_Int64_TEdge_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IntersectPoint_Private_Void_TEdge_TEdge_byref_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProcessEdgesAtTopOfScanbeam_Private_Void_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoMaxima_Private_Void_TEdge_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Orientation_Public_Static_Boolean_List_1_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PointCount_Private_Int32_OutPt_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BuildResult_Private_Void_List_1_List_1_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FixupOutPolyline_Private_Void_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FixupOutPolygon_Private_Void_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DupOutPt_Private_OutPt_OutPt_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOverlap_Private_Boolean_Int64_Int64_Int64_Int64_byref_Int64_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinHorz_Private_Boolean_OutPt_OutPt_OutPt_OutPt_IntPoint_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinPoints_Private_Boolean_Join_OutRec_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PointInPolygon_Public_Static_Int32_IntPoint_List_1_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PointInPolygon_Private_Static_Int32_IntPoint_OutPt_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Poly2ContainsPoly1_Private_Static_Boolean_OutPt_OutPt_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FixupFirstLefts1_Private_Void_OutRec_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FixupFirstLefts2_Private_Void_OutRec_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FixupFirstLefts3_Private_Void_OutRec_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParseFirstLeft_Private_Static_OutRec_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_JoinCommonEdges_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateOutPtIdxs_Private_Void_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoSimplePolygons_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Area_Public_Static_Double_List_1_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Area_Internal_Double_OutRec_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Area_Internal_Double_OutPt_0;

    static Clipper()
    {
      Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (Clipper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr);
      ClipperLib.Clipper.NativeFieldInfoPtr_m_ClipType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_ClipType));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_Maxima = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_Maxima));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_SortedEdges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_SortedEdges));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_IntersectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_IntersectList));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_IntersectNodeComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_IntersectNodeComparer));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_ExecuteLocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_ExecuteLocked));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_ClipFillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_ClipFillType));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_SubjFillType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_SubjFillType));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_Joins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_Joins));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_GhostJoins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_GhostJoins));
      ClipperLib.Clipper.NativeFieldInfoPtr_m_UsingPolyTree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, nameof (m_UsingPolyTree));
      ClipperLib.Clipper.NativeFieldInfoPtr__ReverseSolution_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, "<ReverseSolution>k__BackingField");
      ClipperLib.Clipper.NativeFieldInfoPtr__StrictlySimple_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, "<StrictlySimple>k__BackingField");
      ClipperLib.Clipper.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664370);
      ClipperLib.Clipper.NativeMethodInfoPtr_InsertMaxima_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664371);
      ClipperLib.Clipper.NativeMethodInfoPtr_get_ReverseSolution_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664372);
      ClipperLib.Clipper.NativeMethodInfoPtr_set_ReverseSolution_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664373);
      ClipperLib.Clipper.NativeMethodInfoPtr_get_StrictlySimple_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664374);
      ClipperLib.Clipper.NativeMethodInfoPtr_set_StrictlySimple_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664375);
      ClipperLib.Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_PolyFillType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664376);
      ClipperLib.Clipper.NativeMethodInfoPtr_ExecuteInternal_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664377);
      ClipperLib.Clipper.NativeMethodInfoPtr_DisposeAllPolyPts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664378);
      ClipperLib.Clipper.NativeMethodInfoPtr_AddJoin_Private_Void_OutPt_OutPt_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664379);
      ClipperLib.Clipper.NativeMethodInfoPtr_AddGhostJoin_Private_Void_OutPt_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664380);
      ClipperLib.Clipper.NativeMethodInfoPtr_InsertLocalMinimaIntoAEL_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664381);
      ClipperLib.Clipper.NativeMethodInfoPtr_InsertEdgeIntoAEL_Private_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664382);
      ClipperLib.Clipper.NativeMethodInfoPtr_E2InsertsBeforeE1_Private_Boolean_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664383);
      ClipperLib.Clipper.NativeMethodInfoPtr_IsEvenOddFillType_Private_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664384 /*0x06000440*/);
      ClipperLib.Clipper.NativeMethodInfoPtr_IsEvenOddAltFillType_Private_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664385);
      ClipperLib.Clipper.NativeMethodInfoPtr_IsContributing_Private_Boolean_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664386);
      ClipperLib.Clipper.NativeMethodInfoPtr_SetWindingCount_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664387);
      ClipperLib.Clipper.NativeMethodInfoPtr_AddEdgeToSEL_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664388);
      ClipperLib.Clipper.NativeMethodInfoPtr_PopEdgeFromSEL_Internal_Boolean_byref_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664389);
      ClipperLib.Clipper.NativeMethodInfoPtr_CopyAELToSEL_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664390);
      ClipperLib.Clipper.NativeMethodInfoPtr_SwapPositionsInSEL_Private_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664391);
      ClipperLib.Clipper.NativeMethodInfoPtr_AddLocalMaxPoly_Private_Void_TEdge_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664392);
      ClipperLib.Clipper.NativeMethodInfoPtr_AddLocalMinPoly_Private_OutPt_TEdge_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664393);
      ClipperLib.Clipper.NativeMethodInfoPtr_AddOutPt_Private_OutPt_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664394);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetLastOutPt_Private_OutPt_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664395);
      ClipperLib.Clipper.NativeMethodInfoPtr_HorzSegmentsOverlap_Private_Boolean_Int64_Int64_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664396);
      ClipperLib.Clipper.NativeMethodInfoPtr_SetHoleState_Private_Void_TEdge_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664397);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetDx_Private_Double_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664398);
      ClipperLib.Clipper.NativeMethodInfoPtr_FirstIsBottomPt_Private_Boolean_OutPt_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664399);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetBottomPt_Private_OutPt_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664400 /*0x06000450*/);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetLowermostRec_Private_OutRec_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664401);
      ClipperLib.Clipper.NativeMethodInfoPtr_OutRec1RightOfOutRec2_Private_Boolean_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664402);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetOutRec_Private_OutRec_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664403);
      ClipperLib.Clipper.NativeMethodInfoPtr_AppendPolygon_Private_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664404);
      ClipperLib.Clipper.NativeMethodInfoPtr_ReversePolyPtLinks_Private_Void_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664405);
      ClipperLib.Clipper.NativeMethodInfoPtr_SwapSides_Private_Static_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664406);
      ClipperLib.Clipper.NativeMethodInfoPtr_SwapPolyIndexes_Private_Static_Void_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664407);
      ClipperLib.Clipper.NativeMethodInfoPtr_IntersectEdges_Private_Void_TEdge_TEdge_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664408);
      ClipperLib.Clipper.NativeMethodInfoPtr_ProcessHorizontals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664409);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetHorzDirection_Private_Void_TEdge_byref_Direction_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664410);
      ClipperLib.Clipper.NativeMethodInfoPtr_ProcessHorizontal_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664411);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetNextInAEL_Private_TEdge_TEdge_Direction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664412);
      ClipperLib.Clipper.NativeMethodInfoPtr_IsMaxima_Private_Boolean_TEdge_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664413);
      ClipperLib.Clipper.NativeMethodInfoPtr_IsIntermediate_Private_Boolean_TEdge_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664414);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetMaximaPair_Internal_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664415);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetMaximaPairEx_Internal_TEdge_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664416 /*0x06000460*/);
      ClipperLib.Clipper.NativeMethodInfoPtr_ProcessIntersections_Private_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664417);
      ClipperLib.Clipper.NativeMethodInfoPtr_BuildIntersectList_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664418);
      ClipperLib.Clipper.NativeMethodInfoPtr_EdgesAdjacent_Private_Boolean_IntersectNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664419);
      ClipperLib.Clipper.NativeMethodInfoPtr_FixupIntersectionOrder_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664420);
      ClipperLib.Clipper.NativeMethodInfoPtr_ProcessIntersectList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664421);
      ClipperLib.Clipper.NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664422);
      ClipperLib.Clipper.NativeMethodInfoPtr_TopX_Private_Static_Int64_TEdge_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664423);
      ClipperLib.Clipper.NativeMethodInfoPtr_IntersectPoint_Private_Void_TEdge_TEdge_byref_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664424);
      ClipperLib.Clipper.NativeMethodInfoPtr_ProcessEdgesAtTopOfScanbeam_Private_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664425);
      ClipperLib.Clipper.NativeMethodInfoPtr_DoMaxima_Private_Void_TEdge_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664426);
      ClipperLib.Clipper.NativeMethodInfoPtr_Orientation_Public_Static_Boolean_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664427);
      ClipperLib.Clipper.NativeMethodInfoPtr_PointCount_Private_Int32_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664428);
      ClipperLib.Clipper.NativeMethodInfoPtr_BuildResult_Private_Void_List_1_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664429);
      ClipperLib.Clipper.NativeMethodInfoPtr_FixupOutPolyline_Private_Void_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664430);
      ClipperLib.Clipper.NativeMethodInfoPtr_FixupOutPolygon_Private_Void_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664431);
      ClipperLib.Clipper.NativeMethodInfoPtr_DupOutPt_Private_OutPt_OutPt_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664432 /*0x06000470*/);
      ClipperLib.Clipper.NativeMethodInfoPtr_GetOverlap_Private_Boolean_Int64_Int64_Int64_Int64_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664433);
      ClipperLib.Clipper.NativeMethodInfoPtr_JoinHorz_Private_Boolean_OutPt_OutPt_OutPt_OutPt_IntPoint_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664434);
      ClipperLib.Clipper.NativeMethodInfoPtr_JoinPoints_Private_Boolean_Join_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664435);
      ClipperLib.Clipper.NativeMethodInfoPtr_PointInPolygon_Public_Static_Int32_IntPoint_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664436);
      ClipperLib.Clipper.NativeMethodInfoPtr_PointInPolygon_Private_Static_Int32_IntPoint_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664437);
      ClipperLib.Clipper.NativeMethodInfoPtr_Poly2ContainsPoly1_Private_Static_Boolean_OutPt_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664438);
      ClipperLib.Clipper.NativeMethodInfoPtr_FixupFirstLefts1_Private_Void_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664439);
      ClipperLib.Clipper.NativeMethodInfoPtr_FixupFirstLefts2_Private_Void_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664440);
      ClipperLib.Clipper.NativeMethodInfoPtr_FixupFirstLefts3_Private_Void_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664441);
      ClipperLib.Clipper.NativeMethodInfoPtr_ParseFirstLeft_Private_Static_OutRec_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664442);
      ClipperLib.Clipper.NativeMethodInfoPtr_JoinCommonEdges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664443);
      ClipperLib.Clipper.NativeMethodInfoPtr_UpdateOutPtIdxs_Private_Void_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664444);
      ClipperLib.Clipper.NativeMethodInfoPtr_DoSimplePolygons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664445);
      ClipperLib.Clipper.NativeMethodInfoPtr_Area_Public_Static_Double_List_1_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664446);
      ClipperLib.Clipper.NativeMethodInfoPtr_Area_Internal_Double_OutRec_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664447);
      ClipperLib.Clipper.NativeMethodInfoPtr_Area_Internal_Double_OutPt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr, 100664448 /*0x06000480*/);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946268, RefRangeEnd = 946270, XrefRangeStart = 946235, XrefRangeEnd = 946268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Clipper(int InitOptions = 0)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.Clipper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &InitOptions
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946270, XrefRangeEnd = 946275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InsertMaxima(long X)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &X
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_InsertMaxima_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool ReverseSolution
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_get_ReverseSolution_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_set_ReverseSolution_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe bool StrictlySimple
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_get_StrictlySimple_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_set_StrictlySimple_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946282, RefRangeEnd = 946284, XrefRangeStart = 946275, XrefRangeEnd = 946282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Execute(
      ClipperLib.ClipType clipType,
      List<List<ClipperLib.IntPoint>> solution,
      ClipperLib.PolyFillType subjFillType,
      ClipperLib.PolyFillType clipFillType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &clipType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) solution);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &subjFillType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &clipFillType;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_Execute_Public_Boolean_ClipType_List_1_List_1_IntPoint_PolyFillType_PolyFillType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946330, RefRangeEnd = 946331, XrefRangeStart = 946284, XrefRangeEnd = 946330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ExecuteInternal()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_ExecuteInternal_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946331, XrefRangeEnd = 946341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DisposeAllPolyPts()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_DisposeAllPolyPts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 946348, RefRangeEnd = 946355, XrefRangeStart = 946341, XrefRangeEnd = 946348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddJoin(
      ClipperLib.OutPt Op1,
      ClipperLib.OutPt Op2,
      ClipperLib.IntPoint OffPt)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) Op1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) Op2);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &OffPt;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_AddJoin_Private_Void_OutPt_OutPt_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946362, RefRangeEnd = 946363, XrefRangeStart = 946355, XrefRangeEnd = 946362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddGhostJoin(ClipperLib.OutPt Op, ClipperLib.IntPoint OffPt)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) Op);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &OffPt;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_AddGhostJoin_Private_Void_OutPt_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946419, RefRangeEnd = 946421, XrefRangeStart = 946363, XrefRangeEnd = 946419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InsertLocalMinimaIntoAEL(long botY)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &botY
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_InsertLocalMinimaIntoAEL_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946422, RefRangeEnd = 946424, XrefRangeStart = 946421, XrefRangeEnd = 946422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void InsertEdgeIntoAEL(ClipperLib.TEdge edge, ClipperLib.TEdge startEdge)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) startEdge);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_InsertEdgeIntoAEL_Private_Void_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946424, RefRangeEnd = 946426, XrefRangeStart = 946424, XrefRangeEnd = 946424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool E2InsertsBeforeE1(ClipperLib.TEdge e1, ClipperLib.TEdge e2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_E2InsertsBeforeE1_Private_Boolean_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool IsEvenOddFillType(ClipperLib.TEdge edge)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_IsEvenOddFillType_Private_Boolean_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool IsEvenOddAltFillType(ClipperLib.TEdge edge)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_IsEvenOddAltFillType_Private_Boolean_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 946427, RefRangeEnd = 946430, XrefRangeStart = 946426, XrefRangeEnd = 946427, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsContributing(ClipperLib.TEdge edge)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_IsContributing_Private_Boolean_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 946444, RefRangeEnd = 946447, XrefRangeStart = 946430, XrefRangeEnd = 946444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetWindingCount(ClipperLib.TEdge edge)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_SetWindingCount_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void AddEdgeToSEL(ClipperLib.TEdge edge)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_AddEdgeToSEL_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool PopEdgeFromSEL(out ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_PopEdgeFromSEL_Internal_Boolean_byref_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      ref ClipperLib.TEdge local = ref e;
      System.IntPtr pointer = zero;
      ClipperLib.TEdge tedge = pointer == System.IntPtr.Zero ? (ClipperLib.TEdge) null : new ClipperLib.TEdge(pointer);
      local = tedge;
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe void CopyAELToSEL()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_CopyAELToSEL_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946449, RefRangeEnd = 946451, XrefRangeStart = 946447, XrefRangeEnd = 946449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SwapPositionsInSEL(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge2);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_SwapPositionsInSEL_Private_Void_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946451, XrefRangeEnd = 946454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddLocalMaxPoly(
      ClipperLib.TEdge e1,
      ClipperLib.TEdge e2,
      ClipperLib.IntPoint pt)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e2);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pt;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_AddLocalMaxPoly_Private_Void_TEdge_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946474, RefRangeEnd = 946476, XrefRangeStart = 946454, XrefRangeEnd = 946474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.OutPt AddLocalMinPoly(
      ClipperLib.TEdge e1,
      ClipperLib.TEdge e2,
      ClipperLib.IntPoint pt)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e2);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pt;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_AddLocalMinPoly_Private_OutPt_TEdge_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num3);
    }

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 946480, RefRangeEnd = 946500, XrefRangeStart = 946476, XrefRangeEnd = 946480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.OutPt AddOutPt(ClipperLib.TEdge e, ClipperLib.IntPoint pt)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pt;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_AddOutPt_Private_OutPt_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num3);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946503, RefRangeEnd = 946504, XrefRangeStart = 946500, XrefRangeEnd = 946503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.OutPt GetLastOutPt(ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetLastOutPt_Private_OutPt_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num3);
    }

    [CallerCount(0)]
    public unsafe bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &seg1a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &seg1b;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &seg2a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &seg2b;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_HorzSegmentsOverlap_Private_Boolean_Int64_Int64_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946504, XrefRangeEnd = 946508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetHoleState(ClipperLib.TEdge e, ClipperLib.OutRec outRec)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_SetHoleState_Private_Void_TEdge_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe double GetDx(ClipperLib.IntPoint pt1, ClipperLib.IntPoint pt2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pt1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pt2;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetDx_Private_Double_IntPoint_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 946530, RefRangeEnd = 946534, XrefRangeStart = 946508, XrefRangeEnd = 946530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool FirstIsBottomPt(ClipperLib.OutPt btmPt1, ClipperLib.OutPt btmPt2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) btmPt1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) btmPt2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_FirstIsBottomPt_Private_Boolean_OutPt_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 946536, RefRangeEnd = 946540, XrefRangeStart = 946534, XrefRangeEnd = 946536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.OutPt GetBottomPt(ClipperLib.OutPt pp)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pp)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetBottomPt_Private_OutPt_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946540, XrefRangeEnd = 946543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.OutRec GetLowermostRec(
      ClipperLib.OutRec outRec1,
      ClipperLib.OutRec outRec2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetLowermostRec_Private_OutRec_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutRec) null : Il2CppObjectPool.Get<ClipperLib.OutRec>(num3);
    }

    [CallerCount(0)]
    public unsafe bool OutRec1RightOfOutRec2(ClipperLib.OutRec outRec1, ClipperLib.OutRec outRec2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_OutRec1RightOfOutRec2_Private_Boolean_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946551, RefRangeEnd = 946553, XrefRangeStart = 946543, XrefRangeEnd = 946551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.OutRec GetOutRec(int idx)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &idx
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetOutRec_Private_OutRec_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutRec) null : Il2CppObjectPool.Get<ClipperLib.OutRec>(num3);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 946591, RefRangeEnd = 946596, XrefRangeStart = 946553, XrefRangeEnd = 946591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AppendPolygon(ClipperLib.TEdge e1, ClipperLib.TEdge e2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e2);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_AppendPolygon_Private_Void_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void ReversePolyPtLinks(ClipperLib.OutPt pp)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pp)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_ReversePolyPtLinks_Private_Void_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public static unsafe void SwapSides(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge2);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_SwapSides_Private_Static_Void_TEdge_TEdge_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public static unsafe void SwapPolyIndexes(ClipperLib.TEdge edge1, ClipperLib.TEdge edge2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge2);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_SwapPolyIndexes_Private_Static_Void_TEdge_TEdge_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 946632, RefRangeEnd = 946638, XrefRangeStart = 946596, XrefRangeEnd = 946632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IntersectEdges(
      ClipperLib.TEdge e1,
      ClipperLib.TEdge e2,
      ClipperLib.IntPoint pt)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e2);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &pt;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_IntersectEdges_Private_Void_TEdge_TEdge_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946638, XrefRangeEnd = 946640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessHorizontals()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_ProcessHorizontals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void GetHorzDirection(
      ClipperLib.TEdge HorzEdge,
      out ClipperLib.Direction Dir,
      out long Left,
      out long Right)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) HorzEdge);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref Dir;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref Left;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref Right;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetHorzDirection_Private_Void_TEdge_byref_Direction_byref_Int64_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 946726, RefRangeEnd = 946729, XrefRangeStart = 946640, XrefRangeEnd = 946726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessHorizontal(ClipperLib.TEdge horzEdge)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) horzEdge)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_ProcessHorizontal_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe ClipperLib.TEdge GetNextInAEL(ClipperLib.TEdge e, ClipperLib.Direction Direction)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &Direction;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetNextInAEL_Private_TEdge_TEdge_Direction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num3);
    }

    [CallerCount(0)]
    public unsafe bool IsMaxima(ClipperLib.TEdge e, double Y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &Y;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_IsMaxima_Private_Boolean_TEdge_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe bool IsIntermediate(ClipperLib.TEdge e, double Y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &Y;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_IsIntermediate_Private_Boolean_TEdge_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe ClipperLib.TEdge GetMaximaPair(ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetMaximaPair_Internal_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num3);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 946729, RefRangeEnd = 946731, XrefRangeStart = 946729, XrefRangeEnd = 946729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.TEdge GetMaximaPairEx(ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetMaximaPairEx_Internal_TEdge_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num3);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946744, RefRangeEnd = 946745, XrefRangeStart = 946731, XrefRangeEnd = 946744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ProcessIntersections(long topY)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &topY
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_ProcessIntersections_Private_Boolean_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946760, RefRangeEnd = 946761, XrefRangeStart = 946745, XrefRangeEnd = 946760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildIntersectList(long topY)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &topY
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_BuildIntersectList_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool EdgesAdjacent(ClipperLib.IntersectNode inode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) inode)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_EdgesAdjacent_Private_Boolean_IntersectNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946784, RefRangeEnd = 946785, XrefRangeStart = 946761, XrefRangeEnd = 946784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool FixupIntersectionOrder()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_FixupIntersectionOrder_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946785, XrefRangeEnd = 946794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessIntersectList()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_ProcessIntersectList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public static unsafe long Round(double value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public static unsafe long TopX(ClipperLib.TEdge edge, long currentY)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &currentY;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_TopX_Private_Static_Int64_TEdge_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946816, RefRangeEnd = 946817, XrefRangeStart = 946794, XrefRangeEnd = 946816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void IntersectPoint(
      ClipperLib.TEdge edge1,
      ClipperLib.TEdge edge2,
      out ClipperLib.IntPoint ip)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) edge2);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ip;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_IntersectPoint_Private_Void_TEdge_TEdge_byref_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946865, RefRangeEnd = 946866, XrefRangeStart = 946817, XrefRangeEnd = 946865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ProcessEdgesAtTopOfScanbeam(long topY)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &topY
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_ProcessEdgesAtTopOfScanbeam_Private_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946871, RefRangeEnd = 946872, XrefRangeStart = 946866, XrefRangeEnd = 946871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoMaxima(ClipperLib.TEdge e)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) e)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_DoMaxima_Private_Void_TEdge_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 946882, RefRangeEnd = 946885, XrefRangeStart = 946872, XrefRangeEnd = 946882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Orientation(List<ClipperLib.IntPoint> poly)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) poly)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_Orientation_Public_Static_Boolean_List_1_IntPoint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe int PointCount(ClipperLib.OutPt pts)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pts)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_PointCount_Private_Int32_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946908, RefRangeEnd = 946909, XrefRangeStart = 946885, XrefRangeEnd = 946908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BuildResult(List<List<ClipperLib.IntPoint>> polyg)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) polyg)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_BuildResult_Private_Void_List_1_List_1_IntPoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946909, RefRangeEnd = 946910, XrefRangeStart = 946909, XrefRangeEnd = 946909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FixupOutPolyline(ClipperLib.OutRec outrec)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outrec)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_FixupOutPolyline_Private_Void_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946923, RefRangeEnd = 946924, XrefRangeStart = 946910, XrefRangeEnd = 946923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FixupOutPolygon(ClipperLib.OutRec outRec)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_FixupOutPolygon_Private_Void_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946924, XrefRangeEnd = 946928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperLib.OutPt DupOutPt(ClipperLib.OutPt outPt, bool InsertAfter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outPt);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &InsertAfter;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_DupOutPt_Private_OutPt_OutPt_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutPt) null : Il2CppObjectPool.Get<ClipperLib.OutPt>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946928, XrefRangeEnd = 946939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetOverlap(
      long a1,
      long a2,
      long b1,
      long b2,
      out long Left,
      out long Right)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &a1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &a2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &b2;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref Left;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref Right;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_GetOverlap_Private_Boolean_Int64_Int64_Int64_Int64_byref_Int64_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946939, XrefRangeEnd = 946982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool JoinHorz(
      ClipperLib.OutPt op1,
      ClipperLib.OutPt op1b,
      ClipperLib.OutPt op2,
      ClipperLib.OutPt op2b,
      ClipperLib.IntPoint Pt,
      bool DiscardLeft)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op1b);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op2);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op2b);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &Pt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &DiscardLeft;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_JoinHorz_Private_Boolean_OutPt_OutPt_OutPt_OutPt_IntPoint_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946999, RefRangeEnd = 947000, XrefRangeStart = 946982, XrefRangeEnd = 946999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool JoinPoints(
      ClipperLib.Join j,
      ClipperLib.OutRec outRec1,
      ClipperLib.OutRec outRec2)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) j);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_JoinPoints_Private_Boolean_Join_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 947009, RefRangeEnd = 947011, XrefRangeStart = 947000, XrefRangeEnd = 947009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int PointInPolygon(ClipperLib.IntPoint pt, List<ClipperLib.IntPoint> path)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) path);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_PointInPolygon_Public_Static_Int32_IntPoint_List_1_IntPoint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947011, XrefRangeEnd = 947012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int PointInPolygon(ClipperLib.IntPoint pt, ClipperLib.OutPt op)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_PointInPolygon_Private_Static_Int32_IntPoint_OutPt_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 947013, RefRangeEnd = 947020, XrefRangeStart = 947012, XrefRangeEnd = 947013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool Poly2ContainsPoly1(ClipperLib.OutPt outPt1, ClipperLib.OutPt outPt2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outPt1);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outPt2);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_Poly2ContainsPoly1_Private_Static_Boolean_OutPt_OutPt_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 947035, RefRangeEnd = 947037, XrefRangeStart = 947020, XrefRangeEnd = 947035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FixupFirstLefts1(ClipperLib.OutRec OldOutRec, ClipperLib.OutRec NewOutRec)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) OldOutRec);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) NewOutRec);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_FixupFirstLefts1_Private_Void_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 947055, RefRangeEnd = 947058, XrefRangeStart = 947037, XrefRangeEnd = 947055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FixupFirstLefts2(
      ClipperLib.OutRec innerOutRec,
      ClipperLib.OutRec outerOutRec)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) innerOutRec);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outerOutRec);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_FixupFirstLefts2_Private_Void_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 947072, RefRangeEnd = 947073, XrefRangeStart = 947058, XrefRangeEnd = 947072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FixupFirstLefts3(ClipperLib.OutRec OldOutRec, ClipperLib.OutRec NewOutRec)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) OldOutRec);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) NewOutRec);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_FixupFirstLefts3_Private_Void_OutRec_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public static unsafe ClipperLib.OutRec ParseFirstLeft(ClipperLib.OutRec FirstLeft)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) FirstLeft)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_ParseFirstLeft_Private_Static_OutRec_OutRec_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ClipperLib.OutRec) null : Il2CppObjectPool.Get<ClipperLib.OutRec>(num3);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 947120, RefRangeEnd = 947121, XrefRangeStart = 947073, XrefRangeEnd = 947120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void JoinCommonEdges()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_JoinCommonEdges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void UpdateOutPtIdxs(ClipperLib.OutRec outrec)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outrec)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_UpdateOutPtIdxs_Private_Void_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 947134, RefRangeEnd = 947135, XrefRangeStart = 947121, XrefRangeEnd = 947134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoSimplePolygons()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_DoSimplePolygons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947135, XrefRangeEnd = 947145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe double Area(List<ClipperLib.IntPoint> poly)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) poly)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_Area_Public_Static_Double_List_1_IntPoint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 947145, RefRangeEnd = 947147, XrefRangeStart = 947145, XrefRangeEnd = 947145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe double Area(ClipperLib.OutRec outRec)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outRec)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_Area_Internal_Double_OutRec_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe double Area(ClipperLib.OutPt op)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) op)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.Clipper.NativeMethodInfoPtr_Area_Internal_Double_OutPt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ClipperLib.ClipType m_ClipType
    {
      get
      {
        return *(ClipperLib.ClipType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_ClipType));
      }
      [param: In] set
      {
        *(ClipperLib.ClipType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_ClipType)) = value;
      }
    }

    public unsafe ClipperLib.Maxima m_Maxima
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_Maxima));
        return num == System.IntPtr.Zero ? (ClipperLib.Maxima) null : Il2CppObjectPool.Get<ClipperLib.Maxima>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_Maxima), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ClipperLib.TEdge m_SortedEdges
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_SortedEdges));
        return num == System.IntPtr.Zero ? (ClipperLib.TEdge) null : Il2CppObjectPool.Get<ClipperLib.TEdge>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_SortedEdges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ClipperLib.IntersectNode> m_IntersectList
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_IntersectList));
        return num == System.IntPtr.Zero ? (List<ClipperLib.IntersectNode>) null : Il2CppObjectPool.Get<List<ClipperLib.IntersectNode>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_IntersectList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IComparer<ClipperLib.IntersectNode> m_IntersectNodeComparer
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_IntersectNodeComparer));
        return num == System.IntPtr.Zero ? (IComparer<ClipperLib.IntersectNode>) null : Il2CppObjectPool.Get<IComparer<ClipperLib.IntersectNode>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_IntersectNodeComparer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool m_ExecuteLocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_ExecuteLocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_ExecuteLocked)) = value;
      }
    }

    public unsafe ClipperLib.PolyFillType m_ClipFillType
    {
      get
      {
        return *(ClipperLib.PolyFillType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_ClipFillType));
      }
      [param: In] set
      {
        *(ClipperLib.PolyFillType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_ClipFillType)) = value;
      }
    }

    public unsafe ClipperLib.PolyFillType m_SubjFillType
    {
      get
      {
        return *(ClipperLib.PolyFillType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_SubjFillType));
      }
      [param: In] set
      {
        *(ClipperLib.PolyFillType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_SubjFillType)) = value;
      }
    }

    public unsafe List<ClipperLib.Join> m_Joins
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_Joins));
        return num == System.IntPtr.Zero ? (List<ClipperLib.Join>) null : Il2CppObjectPool.Get<List<ClipperLib.Join>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_Joins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ClipperLib.Join> m_GhostJoins
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_GhostJoins));
        return num == System.IntPtr.Zero ? (List<ClipperLib.Join>) null : Il2CppObjectPool.Get<List<ClipperLib.Join>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_GhostJoins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool m_UsingPolyTree
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_UsingPolyTree));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr_m_UsingPolyTree)) = value;
      }
    }

    public unsafe bool _ReverseSolution_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr__ReverseSolution_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr__ReverseSolution_k__BackingField)) = value;
      }
    }

    public unsafe bool _StrictlySimple_k__BackingField
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr__StrictlySimple_k__BackingField));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.Clipper.NativeFieldInfoPtr__StrictlySimple_k__BackingField)) = value;
      }
    }
  }

  public class ClipperOffset(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_destPolys;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_srcPoly;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_destPoly;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_normals;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_delta;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_sinA;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_sin;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_cos;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_miterLim;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StepsPerRad;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_lowest;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_polyNodes;
    private static readonly System.IntPtr NativeFieldInfoPtr__ArcTolerance_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__MiterLimit_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr_two_pi;
    private static readonly System.IntPtr NativeFieldInfoPtr_def_arc_tolerance;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ArcTolerance_Public_get_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ArcTolerance_Public_set_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MiterLimit_Public_get_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MiterLimit_Public_set_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPath_Public_Void_List_1_IntPoint_JoinType_EndType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddPaths_Public_Void_List_1_List_1_IntPoint_JoinType_EndType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FixOrientations_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUnitNormal_Internal_Static_DoublePoint_IntPoint_IntPoint_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoOffset_Private_Void_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_byref_List_1_List_1_IntPoint_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OffsetPoint_Private_Void_Int32_byref_Int32_JoinType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoSquare_Internal_Void_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoMiter_Internal_Void_Int32_Int32_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DoRound_Internal_Void_Int32_Int32_0;

    static ClipperOffset()
    {
      Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (ClipperOffset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr);
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_destPolys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_destPolys));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_srcPoly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_srcPoly));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_destPoly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_destPoly));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_normals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_normals));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_delta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_delta));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_sinA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_sinA));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_sin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_sin));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_cos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_cos));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_miterLim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_miterLim));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_StepsPerRad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_StepsPerRad));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_lowest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_lowest));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_polyNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (m_polyNodes));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr__ArcTolerance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, "<ArcTolerance>k__BackingField");
      ClipperLib.ClipperOffset.NativeFieldInfoPtr__MiterLimit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, "<MiterLimit>k__BackingField");
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_two_pi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (two_pi));
      ClipperLib.ClipperOffset.NativeFieldInfoPtr_def_arc_tolerance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, nameof (def_arc_tolerance));
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_get_ArcTolerance_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664449);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_set_ArcTolerance_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664450);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_get_MiterLimit_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664451);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_set_MiterLimit_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664452);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664453);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664454);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664455);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_AddPath_Public_Void_List_1_IntPoint_JoinType_EndType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664456);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_AddPaths_Public_Void_List_1_List_1_IntPoint_JoinType_EndType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664457);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_FixOrientations_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664458);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_GetUnitNormal_Internal_Static_DoublePoint_IntPoint_IntPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664459);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_DoOffset_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664460);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_Execute_Public_Void_byref_List_1_List_1_IntPoint_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664461);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_OffsetPoint_Private_Void_Int32_byref_Int32_JoinType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664462);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_DoSquare_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664463);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_DoMiter_Internal_Void_Int32_Int32_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664464 /*0x06000490*/);
      ClipperLib.ClipperOffset.NativeMethodInfoPtr_DoRound_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr, 100664465);
    }

    public unsafe double ArcTolerance
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_get_ArcTolerance_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(double*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_set_ArcTolerance_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    public unsafe double MiterLimit
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_get_MiterLimit_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(double*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_set_MiterLimit_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 947158, RefRangeEnd = 947160, XrefRangeStart = 947147, XrefRangeEnd = 947158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperOffset(double miterLimit = 2.0, double arcTolerance = 0.25)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.ClipperOffset>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &miterLimit;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &arcTolerance;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 947162, RefRangeEnd = 947164, XrefRangeStart = 947160, XrefRangeEnd = 947162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public static unsafe long Round(double value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_Round_Internal_Static_Int64_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 947220, RefRangeEnd = 947221, XrefRangeStart = 947164, XrefRangeEnd = 947220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddPath(
      List<ClipperLib.IntPoint> path,
      ClipperLib.JoinType joinType,
      ClipperLib.EndType endType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) path);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &joinType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &endType;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_AddPath_Public_Void_List_1_IntPoint_JoinType_EndType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 947236, RefRangeEnd = 947239, XrefRangeStart = 947221, XrefRangeEnd = 947236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddPaths(
      List<List<ClipperLib.IntPoint>> paths,
      ClipperLib.JoinType joinType,
      ClipperLib.EndType endType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) paths);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &joinType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &endType;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_AddPaths_Public_Void_List_1_List_1_IntPoint_JoinType_EndType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 947258, RefRangeEnd = 947259, XrefRangeStart = 947239, XrefRangeEnd = 947258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FixOrientations()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_FixOrientations_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 947265, RefRangeEnd = 947267, XrefRangeStart = 947259, XrefRangeEnd = 947265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ClipperLib.DoublePoint GetUnitNormal(
      ClipperLib.IntPoint pt1,
      ClipperLib.IntPoint pt2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &pt1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pt2;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_GetUnitNormal_Internal_Static_DoublePoint_IntPoint_IntPoint_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ClipperLib.DoublePoint*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 947476, RefRangeEnd = 947477, XrefRangeStart = 947267, XrefRangeEnd = 947476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoOffset(double delta)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &delta
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_DoOffset_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 947516, RefRangeEnd = 947521, XrefRangeStart = 947477, XrefRangeEnd = 947516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Execute(ref List<List<ClipperLib.IntPoint>> solution, double delta)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) solution);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &delta;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_Execute_Public_Void_byref_List_1_List_1_IntPoint_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      ref List<List<ClipperLib.IntPoint>> local = ref solution;
      System.IntPtr pointer = ptr;
      List<List<ClipperLib.IntPoint>> list = pointer == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : new List<List<ClipperLib.IntPoint>>(pointer);
      local = list;
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 947594, RefRangeEnd = 947599, XrefRangeStart = 947521, XrefRangeEnd = 947594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OffsetPoint(int j, ref int k, ClipperLib.JoinType jointype)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &j;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref k;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &jointype;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_OffsetPoint_Private_Void_Int32_byref_Int32_JoinType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 947650, RefRangeEnd = 947654, XrefRangeStart = 947599, XrefRangeEnd = 947650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoSquare(int j, int k)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &j;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &k;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_DoSquare_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 947674, RefRangeEnd = 947675, XrefRangeStart = 947654, XrefRangeEnd = 947674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoMiter(int j, int k, double r)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &j;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &k;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &r;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_DoMiter_Internal_Void_Int32_Int32_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 947719, RefRangeEnd = 947722, XrefRangeStart = 947675, XrefRangeEnd = 947719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void DoRound(int j, int k)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &j;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &k;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperOffset.NativeMethodInfoPtr_DoRound_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe List<List<ClipperLib.IntPoint>> m_destPolys
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_destPolys));
        return num == System.IntPtr.Zero ? (List<List<ClipperLib.IntPoint>>) null : Il2CppObjectPool.Get<List<List<ClipperLib.IntPoint>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_destPolys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ClipperLib.IntPoint> m_srcPoly
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_srcPoly));
        return num == System.IntPtr.Zero ? (List<ClipperLib.IntPoint>) null : Il2CppObjectPool.Get<List<ClipperLib.IntPoint>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_srcPoly), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ClipperLib.IntPoint> m_destPoly
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_destPoly));
        return num == System.IntPtr.Zero ? (List<ClipperLib.IntPoint>) null : Il2CppObjectPool.Get<List<ClipperLib.IntPoint>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_destPoly), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ClipperLib.DoublePoint> m_normals
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_normals));
        return num == System.IntPtr.Zero ? (List<ClipperLib.DoublePoint>) null : Il2CppObjectPool.Get<List<ClipperLib.DoublePoint>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_normals), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double m_delta
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_delta));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_delta)) = value;
      }
    }

    public unsafe double m_sinA
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_sinA));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_sinA)) = value;
      }
    }

    public unsafe double m_sin
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_sin));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_sin)) = value;
      }
    }

    public unsafe double m_cos
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_cos));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_cos)) = value;
      }
    }

    public unsafe double m_miterLim
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_miterLim));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_miterLim)) = value;
      }
    }

    public unsafe double m_StepsPerRad
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_StepsPerRad));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_StepsPerRad)) = value;
      }
    }

    public unsafe ClipperLib.IntPoint m_lowest
    {
      get
      {
        return *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_lowest));
      }
      [param: In] set
      {
        *(ClipperLib.IntPoint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_lowest)) = value;
      }
    }

    public unsafe ClipperLib.PolyNode m_polyNodes
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_polyNodes));
        return num == System.IntPtr.Zero ? (ClipperLib.PolyNode) null : Il2CppObjectPool.Get<ClipperLib.PolyNode>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr_m_polyNodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double _ArcTolerance_k__BackingField
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr__ArcTolerance_k__BackingField));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr__ArcTolerance_k__BackingField)) = value;
      }
    }

    public unsafe double _MiterLimit_k__BackingField
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr__MiterLimit_k__BackingField));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClipperLib.ClipperOffset.NativeFieldInfoPtr__MiterLimit_k__BackingField)) = value;
      }
    }

    public static unsafe double two_pi
    {
      get
      {
        double twoPi;
        IL2CPP.il2cpp_field_static_get_value(ClipperLib.ClipperOffset.NativeFieldInfoPtr_two_pi, (void*) &twoPi);
        return twoPi;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClipperLib.ClipperOffset.NativeFieldInfoPtr_two_pi, (void*) &value);
      }
    }

    public static unsafe double def_arc_tolerance
    {
      get
      {
        double defArcTolerance;
        IL2CPP.il2cpp_field_static_get_value(ClipperLib.ClipperOffset.NativeFieldInfoPtr_def_arc_tolerance, (void*) &defArcTolerance);
        return defArcTolerance;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ClipperLib.ClipperOffset.NativeFieldInfoPtr_def_arc_tolerance, (void*) &value);
      }
    }
  }

  public class ClipperException(System.IntPtr pointer) : Il2CppSystem.Exception(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

    static ClipperException()
    {
      Il2CppClassPointerStore<ClipperLib.ClipperException>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClipperLib>.NativeClassPtr, nameof (ClipperException));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClipperLib.ClipperException>.NativeClassPtr);
      ClipperLib.ClipperException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClipperLib.ClipperException>.NativeClassPtr, 100664466);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947722, XrefRangeEnd = 947726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClipperException(string description)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClipperLib.ClipperException>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(description)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ClipperLib.ClipperException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
