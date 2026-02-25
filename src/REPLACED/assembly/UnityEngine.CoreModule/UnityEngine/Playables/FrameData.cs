// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.FrameData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct FrameData
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FrameID;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DeltaTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Weight;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveWeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveParentDelay;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveParentSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EffectiveSpeed;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Output;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0;
  [FieldOffset(0)]
  public ulong m_FrameID;
  [FieldOffset(8)]
  public double m_DeltaTime;
  [FieldOffset(16 /*0x10*/)]
  public float m_Weight;
  [FieldOffset(20)]
  public float m_EffectiveWeight;
  [FieldOffset(24)]
  public double m_EffectiveParentDelay;
  [FieldOffset(32 /*0x20*/)]
  public float m_EffectiveParentSpeed;
  [FieldOffset(36)]
  public float m_EffectiveSpeed;
  [FieldOffset(40)]
  public FrameData.Flags m_Flags;
  [FieldOffset(48 /*0x30*/)]
  public PlayableOutput m_Output;

  static FrameData()
  {
    Il2CppClassPointerStore<FrameData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (FrameData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FrameData>.NativeClassPtr);
    FrameData.NativeFieldInfoPtr_m_FrameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_FrameID));
    FrameData.NativeFieldInfoPtr_m_DeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_DeltaTime));
    FrameData.NativeFieldInfoPtr_m_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_Weight));
    FrameData.NativeFieldInfoPtr_m_EffectiveWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_EffectiveWeight));
    FrameData.NativeFieldInfoPtr_m_EffectiveParentDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_EffectiveParentDelay));
    FrameData.NativeFieldInfoPtr_m_EffectiveParentSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_EffectiveParentSpeed));
    FrameData.NativeFieldInfoPtr_m_EffectiveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_EffectiveSpeed));
    FrameData.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_Flags));
    FrameData.NativeFieldInfoPtr_m_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FrameData>.NativeClassPtr, nameof (m_Output));
    FrameData.NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669353);
    FrameData.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669354);
    FrameData.NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669355);
    FrameData.NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669356);
    FrameData.NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669357);
    FrameData.NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669358);
    FrameData.NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669359);
    FrameData.NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669360);
    FrameData.NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FrameData>.NativeClassPtr, 100669361);
  }

  [CallerCount(0)]
  public unsafe bool HasFlags(FrameData.Flags flag)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &flag
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_HasFlags_Private_Boolean_Flags_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe float deltaTime
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 479876, RefRangeEnd = 479878, XrefRangeStart = 479876, XrefRangeEnd = 479876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_deltaTime_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float effectiveSpeed
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 472992, RefRangeEnd = 473002, XrefRangeStart = 472992, XrefRangeEnd = 473002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_effectiveSpeed_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe FrameData.EvaluationType evaluationType
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 479878, RefRangeEnd = 479881, XrefRangeStart = 479878, XrefRangeEnd = 479878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_evaluationType_Public_get_EvaluationType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(FrameData.EvaluationType*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool seekOccurred
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 479881, RefRangeEnd = 479882, XrefRangeStart = 479881, XrefRangeEnd = 479881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_seekOccurred_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool timeLooped
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 479882, RefRangeEnd = 479888, XrefRangeStart = 479882, XrefRangeEnd = 479882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_timeLooped_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool timeHeld
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 479888, RefRangeEnd = 479889, XrefRangeStart = 479888, XrefRangeEnd = 479888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_timeHeld_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe PlayableOutput output
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 479889, RefRangeEnd = 479892, XrefRangeStart = 479889, XrefRangeEnd = 479889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_output_Public_get_PlayableOutput_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PlayableOutput*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe PlayState effectivePlayState
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 479892, RefRangeEnd = 479896, XrefRangeStart = 479892, XrefRangeEnd = 479892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FrameData.NativeMethodInfoPtr_get_effectivePlayState_Public_get_PlayState_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PlayState*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FrameData>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public ulong frameId => this.m_FrameID;

  public float weight => this.m_Weight;

  public float effectiveWeight => this.m_EffectiveWeight;

  public double effectiveParentDelay => this.m_EffectiveParentDelay;

  public float effectiveParentSpeed => this.m_EffectiveParentSpeed;

  [System.Flags]
  public enum Flags
  {
    Evaluate = 1,
    SeekOccured = 2,
    Loop = 4,
    Hold = 8,
    EffectivePlayStateDelayed = 16, // 0x00000010
    EffectivePlayStatePlaying = 32, // 0x00000020
  }

  public enum EvaluationType
  {
    Evaluate,
    Playback,
  }
}
