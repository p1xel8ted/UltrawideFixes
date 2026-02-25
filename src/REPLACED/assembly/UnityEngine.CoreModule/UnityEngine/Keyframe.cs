// Decompiled with JetBrains decompiler
// Type: UnityEngine.Keyframe
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Keyframe
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Time;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Value;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InTangent;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutTangent;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WeightedMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InWeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OutWeight;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_value_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_value_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_inTangent_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_outTangent_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_inWeight_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_outWeight_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_tangentMode_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_tangentMode_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_tangentModeInternal_Internal_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_tangentModeInternal_Internal_set_Void_Int32_0;
  [FieldOffset(0)]
  public float m_Time;
  [FieldOffset(4)]
  public float m_Value;
  [FieldOffset(8)]
  public float m_InTangent;
  [FieldOffset(12)]
  public float m_OutTangent;
  [FieldOffset(16 /*0x10*/)]
  public int m_WeightedMode;
  [FieldOffset(20)]
  public float m_InWeight;
  [FieldOffset(24)]
  public float m_OutWeight;

  static Keyframe()
  {
    Il2CppClassPointerStore<Keyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Keyframe));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Keyframe>.NativeClassPtr);
    Keyframe.NativeFieldInfoPtr_m_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, nameof (m_Time));
    Keyframe.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, nameof (m_Value));
    Keyframe.NativeFieldInfoPtr_m_InTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, nameof (m_InTangent));
    Keyframe.NativeFieldInfoPtr_m_OutTangent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, nameof (m_OutTangent));
    Keyframe.NativeFieldInfoPtr_m_WeightedMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, nameof (m_WeightedMode));
    Keyframe.NativeFieldInfoPtr_m_InWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, nameof (m_InWeight));
    Keyframe.NativeFieldInfoPtr_m_OutWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, nameof (m_OutWeight));
    Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663780);
    Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663781);
    Keyframe.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663782);
    Keyframe.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663783);
    Keyframe.NativeMethodInfoPtr_get_value_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663784);
    Keyframe.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663785);
    Keyframe.NativeMethodInfoPtr_get_inTangent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663786);
    Keyframe.NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663787);
    Keyframe.NativeMethodInfoPtr_get_outTangent_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663788);
    Keyframe.NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663789);
    Keyframe.NativeMethodInfoPtr_get_inWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663790);
    Keyframe.NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663791);
    Keyframe.NativeMethodInfoPtr_get_outWeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663792 /*0x060001F0*/);
    Keyframe.NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663793);
    Keyframe.NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663794);
    Keyframe.NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663795);
    Keyframe.NativeMethodInfoPtr_get_tangentMode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663796);
    Keyframe.NativeMethodInfoPtr_set_tangentMode_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663797);
    Keyframe.NativeMethodInfoPtr_get_tangentModeInternal_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663798);
    Keyframe.NativeMethodInfoPtr_set_tangentModeInternal_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, 100663799);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 415831, RefRangeEnd = 415847, XrefRangeStart = 415831, XrefRangeEnd = 415831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Keyframe(float time, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(31 /*0x1F*/)]
  [CachedScanResults(RefRangeStart = 415847, RefRangeEnd = 415878, XrefRangeStart = 415847, XrefRangeEnd = 415847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Keyframe(float time, float value, float inTangent, float outTangent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &time;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inTangent;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &outTangent;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float time
  {
    [CallerCount(113), CachedScanResults(RefRangeStart = 415878, RefRangeEnd = 415991, XrefRangeStart = 415878, XrefRangeEnd = 415878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_time_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(43), CachedScanResults(RefRangeStart = 70541, RefRangeEnd = 70584, XrefRangeStart = 70541, XrefRangeEnd = 70584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float value
  {
    [CallerCount(95), CachedScanResults(RefRangeStart = 415991, RefRangeEnd = 416086, XrefRangeStart = 415991, XrefRangeEnd = 415991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_value_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(22), CachedScanResults(RefRangeStart = 400905, RefRangeEnd = 400927, XrefRangeStart = 400905, XrefRangeEnd = 400927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_value_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float inTangent
  {
    [CallerCount(45), CachedScanResults(RefRangeStart = 416086, RefRangeEnd = 416131, XrefRangeStart = 416086, XrefRangeEnd = 416086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_inTangent_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(13), CachedScanResults(RefRangeStart = 400927, RefRangeEnd = 400940, XrefRangeStart = 400927, XrefRangeEnd = 400940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_inTangent_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float outTangent
  {
    [CallerCount(36), CachedScanResults(RefRangeStart = 416131, RefRangeEnd = 416167, XrefRangeStart = 416131, XrefRangeEnd = 416131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_outTangent_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(11), CachedScanResults(RefRangeStart = 400940, RefRangeEnd = 400951, XrefRangeStart = 400940, XrefRangeEnd = 400951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_outTangent_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float inWeight
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 416167, RefRangeEnd = 416169, XrefRangeStart = 416167, XrefRangeEnd = 416167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_inWeight_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 70589, RefRangeEnd = 70590, XrefRangeStart = 70589, XrefRangeEnd = 70590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_inWeight_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float outWeight
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 416169, RefRangeEnd = 416228, XrefRangeStart = 416169, XrefRangeEnd = 416169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_outWeight_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 70590, RefRangeEnd = 70591, XrefRangeStart = 70590, XrefRangeEnd = 70591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_outWeight_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe WeightedMode weightedMode
  {
    [CallerCount(54), CachedScanResults(RefRangeStart = 327675, RefRangeEnd = 327729, XrefRangeStart = 327675, XrefRangeEnd = 327729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_weightedMode_Public_get_WeightedMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(WeightedMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_weightedMode_Public_set_Void_WeightedMode_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int tangentMode
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 337858, RefRangeEnd = 337861, XrefRangeStart = 337858, XrefRangeEnd = 337861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_tangentMode_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(15159), CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_tangentMode_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int tangentModeInternal
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 337858, RefRangeEnd = 337861, XrefRangeStart = 337858, XrefRangeEnd = 337861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_get_tangentModeInternal_Internal_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(15159), CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Keyframe.NativeMethodInfoPtr_set_tangentModeInternal_Internal_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Keyframe>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
