// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.FarHackablesIndicators
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Foundation.Events;

[StructLayout(LayoutKind.Explicit)]
public struct FarHackablesIndicators
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Show;
  private static readonly System.IntPtr NativeFieldInfoPtr_LeftPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_TopPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_RightPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_BottomPos;
  private static readonly System.IntPtr NativeFieldInfoPtr_LeftDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_TopDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_RightDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_BottomDistance;
  [FieldOffset(0)]
  public bool Show;
  [FieldOffset(4)]
  public Vector2 LeftPos;
  [FieldOffset(12)]
  public Vector2 TopPos;
  [FieldOffset(20)]
  public Vector2 RightPos;
  [FieldOffset(28)]
  public Vector2 BottomPos;
  [FieldOffset(36)]
  public int LeftDistance;
  [FieldOffset(40)]
  public int TopDistance;
  [FieldOffset(44)]
  public int RightDistance;
  [FieldOffset(48 /*0x30*/)]
  public int BottomDistance;

  static FarHackablesIndicators()
  {
    Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (FarHackablesIndicators));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr);
    FarHackablesIndicators.NativeFieldInfoPtr_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (Show));
    FarHackablesIndicators.NativeFieldInfoPtr_LeftPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (LeftPos));
    FarHackablesIndicators.NativeFieldInfoPtr_TopPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (TopPos));
    FarHackablesIndicators.NativeFieldInfoPtr_RightPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (RightPos));
    FarHackablesIndicators.NativeFieldInfoPtr_BottomPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (BottomPos));
    FarHackablesIndicators.NativeFieldInfoPtr_LeftDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (LeftDistance));
    FarHackablesIndicators.NativeFieldInfoPtr_TopDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (TopDistance));
    FarHackablesIndicators.NativeFieldInfoPtr_RightDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (RightDistance));
    FarHackablesIndicators.NativeFieldInfoPtr_BottomDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, nameof (BottomDistance));
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FarHackablesIndicators>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
