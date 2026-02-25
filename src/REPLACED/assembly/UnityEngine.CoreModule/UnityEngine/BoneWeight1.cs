// Decompiled with JetBrains decompiler
// Type: UnityEngine.BoneWeight1
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
public struct BoneWeight1
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoneIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_weight_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_boneIndex_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight1_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public float m_Weight;
  [FieldOffset(4)]
  public int m_BoneIndex;

  static BoneWeight1()
  {
    Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BoneWeight1));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr);
    BoneWeight1.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, nameof (m_Weight));
    BoneWeight1.NativeFieldInfoPtr_m_BoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, nameof (m_BoneIndex));
    BoneWeight1.NativeMethodInfoPtr_get_weight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100666536);
    BoneWeight1.NativeMethodInfoPtr_get_boneIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100666537);
    BoneWeight1.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100666538);
    BoneWeight1.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100666539);
    BoneWeight1.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, 100666540);
  }

  public unsafe float weight
  {
    [CallerCount(113), CachedScanResults(RefRangeStart = 415878, RefRangeEnd = 415991, XrefRangeStart = 415878, XrefRangeEnd = 415991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_get_weight_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Weight = value;
  }

  public unsafe int boneIndex
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 328510, RefRangeEnd = 328569, XrefRangeStart = 328510, XrefRangeEnd = 328569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_get_boneIndex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_BoneIndex = value;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434222, XrefRangeEnd = 434227, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434227, XrefRangeEnd = 434228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(BoneWeight1 other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoneWeight1_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 434228, XrefRangeEnd = 434230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoneWeight1.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoneWeight1>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool operator ==(BoneWeight1 lhs, BoneWeight1 rhs)
  {
    return lhs.boneIndex == rhs.boneIndex && (double) lhs.weight == (double) rhs.weight;
  }

  public static bool operator !=(BoneWeight1 lhs, BoneWeight1 rhs) => !(lhs == rhs);
}
