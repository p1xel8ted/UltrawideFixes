// Decompiled with JetBrains decompiler
// Type: SadCatStudios.MovementPhysics.MoveUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.MovementPhysics;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct MoveUnit
{
  private static readonly System.IntPtr NativeFieldInfoPtr_HorizontalMove;
  private static readonly System.IntPtr NativeFieldInfoPtr_VerticalMove;
  private static readonly System.IntPtr NativeFieldInfoPtr_DepthMove;
  private static readonly System.IntPtr NativeFieldInfoPtr_Friction;
  private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
  private static readonly System.IntPtr NativeFieldInfoPtr_Gravity;
  private static readonly System.IntPtr NativeFieldInfoPtr_CustomRotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_SafetyMeasures;
  private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreSlowdown;
  private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreGravity;
  private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_RestrictAutoStep;
  private static readonly System.IntPtr NativeFieldInfoPtr_PushOut;
  private static readonly System.IntPtr NativeFieldInfoPtr_Push;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0;
  [FieldOffset(0)]
  public float HorizontalMove;
  [FieldOffset(4)]
  public float VerticalMove;
  [FieldOffset(8)]
  public float DepthMove;
  [FieldOffset(12)]
  public float Friction;
  [FieldOffset(16 /*0x10*/)]
  public float Acceleration;
  [FieldOffset(20)]
  public float Gravity;
  [FieldOffset(24)]
  public bool CustomRotation;
  [FieldOffset(25)]
  public bool SafetyMeasures;
  [FieldOffset(26)]
  public bool IgnoreSlowdown;
  [FieldOffset(27)]
  public bool IgnoreGravity;
  [FieldOffset(28)]
  public bool IgnoreDepth;
  [FieldOffset(29)]
  public bool RestrictAutoStep;
  [FieldOffset(30)]
  public bool PushOut;
  [FieldOffset(31 /*0x1F*/)]
  public bool Push;

  static MoveUnit()
  {
    Il2CppClassPointerStore<MoveUnit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.MovementPhysics", nameof (MoveUnit));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr);
    MoveUnit.NativeFieldInfoPtr_HorizontalMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (HorizontalMove));
    MoveUnit.NativeFieldInfoPtr_VerticalMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (VerticalMove));
    MoveUnit.NativeFieldInfoPtr_DepthMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (DepthMove));
    MoveUnit.NativeFieldInfoPtr_Friction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (Friction));
    MoveUnit.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (Acceleration));
    MoveUnit.NativeFieldInfoPtr_Gravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (Gravity));
    MoveUnit.NativeFieldInfoPtr_CustomRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (CustomRotation));
    MoveUnit.NativeFieldInfoPtr_SafetyMeasures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (SafetyMeasures));
    MoveUnit.NativeFieldInfoPtr_IgnoreSlowdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (IgnoreSlowdown));
    MoveUnit.NativeFieldInfoPtr_IgnoreGravity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (IgnoreGravity));
    MoveUnit.NativeFieldInfoPtr_IgnoreDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (IgnoreDepth));
    MoveUnit.NativeFieldInfoPtr_RestrictAutoStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (RestrictAutoStep));
    MoveUnit.NativeFieldInfoPtr_PushOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (PushOut));
    MoveUnit.NativeFieldInfoPtr_Push = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, nameof (Push));
    MoveUnit.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, 100670982);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 90057, RefRangeEnd = 90077, XrefRangeStart = 90057, XrefRangeEnd = 90057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MoveUnit(
    float horizontalMove = 0.0f,
    float verticalMove = 0.0f,
    float depthMove = 0.0f,
    float friction = 0.0f,
    float acceleration = 0.0f,
    float gravity = 0.0f,
    bool customRotation = false,
    bool safetyMeasures = false,
    bool ignoreSlowdown = false,
    bool ignoreGravity = false,
    bool ignoreDepth = false,
    bool restrictAutoStep = false,
    bool pushOut = false,
    bool push = false)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[14];
    numPtr[0] = (System.IntPtr) &horizontalMove;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &verticalMove;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &depthMove;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &friction;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &acceleration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &gravity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &customRotation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &safetyMeasures;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreSlowdown;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreGravity;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(10) * sizeof (System.IntPtr))) = (System.IntPtr) &ignoreDepth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(11) * sizeof (System.IntPtr))) = (System.IntPtr) &restrictAutoStep;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(12) * sizeof (System.IntPtr))) = (System.IntPtr) &pushOut;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(13) * sizeof (System.IntPtr))) = (System.IntPtr) &push;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MoveUnit.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_Single_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveUnit>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
