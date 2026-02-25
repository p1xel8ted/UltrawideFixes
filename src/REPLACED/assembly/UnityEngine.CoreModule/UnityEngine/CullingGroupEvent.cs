// Decompiled with JetBrains decompiler
// Type: UnityEngine.CullingGroupEvent
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct CullingGroupEvent
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Index;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PrevState;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ThisState;
  [FieldOffset(0)]
  public int m_Index;
  [FieldOffset(4)]
  public byte m_PrevState;
  [FieldOffset(5)]
  public byte m_ThisState;
  public const byte kIsVisibleMask = 128 /*0x80*/;
  public const byte kDistanceMask = 127 /*0x7F*/;

  static CullingGroupEvent()
  {
    Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (CullingGroupEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr);
    CullingGroupEvent.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, nameof (m_Index));
    CullingGroupEvent.NativeFieldInfoPtr_m_PrevState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, nameof (m_PrevState));
    CullingGroupEvent.NativeFieldInfoPtr_m_ThisState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, nameof (m_ThisState));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CullingGroupEvent>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public int index => this.m_Index;

  public bool isVisible => ((uint) this.m_ThisState & 128U /*0x80*/) > 0U;

  public bool wasVisible => ((uint) this.m_PrevState & 128U /*0x80*/) > 0U;

  public bool hasBecomeVisible => this.isVisible && !this.wasVisible;

  public bool hasBecomeInvisible => !this.isVisible && this.wasVisible;

  public int currentDistance => (int) this.m_ThisState & (int) sbyte.MaxValue;

  public int previousDistance => (int) this.m_PrevState & (int) sbyte.MaxValue;
}
