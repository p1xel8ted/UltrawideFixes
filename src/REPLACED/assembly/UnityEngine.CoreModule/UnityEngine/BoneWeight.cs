// Decompiled with JetBrains decompiler
// Type: UnityEngine.BoneWeight
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct BoneWeight
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight0;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight1;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight2;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight3;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex0;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex1;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex2;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex3;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_weight0_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_weight1_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_weight2_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_weight3_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0;
  [FieldOffset(0)]
  public float m_Weight0;
  [FieldOffset(4)]
  public float m_Weight1;
  [FieldOffset(8)]
  public float m_Weight2;
  [FieldOffset(12)]
  public float m_Weight3;
  [FieldOffset(16 /*0x10*/)]
  public int m_BoneIndex0;
  [FieldOffset(20)]
  public int m_BoneIndex1;
  [FieldOffset(24)]
  public int m_BoneIndex2;
  [FieldOffset(28)]
  public int m_BoneIndex3;

  static BoneWeight()
  {
    Il2CppClassPointerStore<BoneWeight>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BoneWeight));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr);
    BoneWeight.NativeFieldInfoPtr_m_Weight0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, nameof (m_Weight0));
    BoneWeight.NativeFieldInfoPtr_m_Weight1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, nameof (m_Weight1));
    BoneWeight.NativeFieldInfoPtr_m_Weight2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, nameof (m_Weight2));
    BoneWeight.NativeFieldInfoPtr_m_Weight3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, nameof (m_Weight3));
    BoneWeight.NativeFieldInfoPtr_m_BoneIndex0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, nameof (m_BoneIndex0));
    BoneWeight.NativeFieldInfoPtr_m_BoneIndex1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, nameof (m_BoneIndex1));
    BoneWeight.NativeFieldInfoPtr_m_BoneIndex2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, nameof (m_BoneIndex2));
    BoneWeight.NativeFieldInfoPtr_m_BoneIndex3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, nameof (m_BoneIndex3));
    BoneWeight.NativeMethodInfoPtr_get_weight0_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666525);
    BoneWeight.NativeMethodInfoPtr_get_weight1_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666526);
    BoneWeight.NativeMethodInfoPtr_get_weight2_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666527);
    BoneWeight.NativeMethodInfoPtr_get_weight3_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666528 /*0x06000CA0*/);
    BoneWeight.NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666529);
    BoneWeight.NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666530);
    BoneWeight.NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666531);
    BoneWeight.NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666532);
    BoneWeight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666533);
    BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666534);
    BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, 100666535);
  }

  public unsafe float weight0
  {
    [CallerCount(113), CachedScanResults(RefRangeStart = 415878, RefRangeEnd = 415991, XrefRangeStart = 415878, XrefRangeEnd = 415991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight0_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Weight0 = value;
  }

  public unsafe float weight1
  {
    [CallerCount(95), CachedScanResults(RefRangeStart = 415991, RefRangeEnd = 416086, XrefRangeStart = 415991, XrefRangeEnd = 416086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight1_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Weight1 = value;
  }

  public unsafe float weight2
  {
    [CallerCount(45), CachedScanResults(RefRangeStart = 416086, RefRangeEnd = 416131, XrefRangeStart = 416086, XrefRangeEnd = 416131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight2_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Weight2 = value;
  }

  public unsafe float weight3
  {
    [CallerCount(36), CachedScanResults(RefRangeStart = 416131, RefRangeEnd = 416167, XrefRangeStart = 416131, XrefRangeEnd = 416167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_weight3_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Weight3 = value;
  }

  public unsafe int boneIndex0
  {
    [CallerCount(54), CachedScanResults(RefRangeStart = 327675, RefRangeEnd = 327729, XrefRangeStart = 327675, XrefRangeEnd = 327729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex0_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_BoneIndex0 = value;
  }

  public unsafe int boneIndex1
  {
    [CallerCount(37), CachedScanResults(RefRangeStart = 327622, RefRangeEnd = 327659, XrefRangeStart = 327622, XrefRangeEnd = 327659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex1_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_BoneIndex1 = value;
  }

  public unsafe int boneIndex2
  {
    [CallerCount(41), CachedScanResults(RefRangeStart = 304774, RefRangeEnd = 304815, XrefRangeStart = 304774, XrefRangeEnd = 304815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex2_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_BoneIndex2 = value;
  }

  public unsafe int boneIndex3
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 342938, RefRangeEnd = 342946, XrefRangeStart = 342938, XrefRangeEnd = 342946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_get_boneIndex3_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_BoneIndex3 = value;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434205, XrefRangeEnd = 434213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434213, XrefRangeEnd = 434217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 434221, RefRangeEnd = 434222, XrefRangeStart = 434217, XrefRangeEnd = 434221, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(BoneWeight other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoneWeight>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool operator ==(BoneWeight lhs, BoneWeight rhs)
  {
    return lhs.boneIndex0 == rhs.boneIndex0 && lhs.boneIndex1 == rhs.boneIndex1 && lhs.boneIndex2 == rhs.boneIndex2 && lhs.boneIndex3 == rhs.boneIndex3 && new Vector4(lhs.weight0, lhs.weight1, lhs.weight2, lhs.weight3) == new Vector4(rhs.weight0, rhs.weight1, rhs.weight2, rhs.weight3);
  }

  public static bool operator !=(BoneWeight lhs, BoneWeight rhs) => !(lhs == rhs);
}
