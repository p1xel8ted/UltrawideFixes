// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderTargetBlendState
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
public struct RenderTargetBlendState
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceColorBlendMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DestinationColorBlendMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceAlphaBlendMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DestinationAlphaBlendMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ColorBlendOperation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AlphaBlendOperation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public byte m_WriteMask;
  [FieldOffset(1)]
  public byte m_SourceColorBlendMode;
  [FieldOffset(2)]
  public byte m_DestinationColorBlendMode;
  [FieldOffset(3)]
  public byte m_SourceAlphaBlendMode;
  [FieldOffset(4)]
  public byte m_DestinationAlphaBlendMode;
  [FieldOffset(5)]
  public byte m_ColorBlendOperation;
  [FieldOffset(6)]
  public byte m_AlphaBlendOperation;
  [FieldOffset(7)]
  public byte m_Padding;

  static RenderTargetBlendState()
  {
    Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderTargetBlendState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr);
    RenderTargetBlendState.NativeFieldInfoPtr_m_WriteMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, nameof (m_WriteMask));
    RenderTargetBlendState.NativeFieldInfoPtr_m_SourceColorBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, nameof (m_SourceColorBlendMode));
    RenderTargetBlendState.NativeFieldInfoPtr_m_DestinationColorBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, nameof (m_DestinationColorBlendMode));
    RenderTargetBlendState.NativeFieldInfoPtr_m_SourceAlphaBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, nameof (m_SourceAlphaBlendMode));
    RenderTargetBlendState.NativeFieldInfoPtr_m_DestinationAlphaBlendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, nameof (m_DestinationAlphaBlendMode));
    RenderTargetBlendState.NativeFieldInfoPtr_m_ColorBlendOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, nameof (m_ColorBlendOperation));
    RenderTargetBlendState.NativeFieldInfoPtr_m_AlphaBlendOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, nameof (m_AlphaBlendOperation));
    RenderTargetBlendState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, nameof (m_Padding));
    RenderTargetBlendState.NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100670500);
    RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100670501);
    RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100670502);
    RenderTargetBlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, 100670503);
  }

  [CallerCount(0)]
  public unsafe RenderTargetBlendState(
    ColorWriteMask writeMask = ColorWriteMask.All,
    BlendMode sourceColorBlendMode = BlendMode.One,
    BlendMode destinationColorBlendMode = BlendMode.Zero,
    BlendMode sourceAlphaBlendMode = BlendMode.One,
    BlendMode destinationAlphaBlendMode = BlendMode.Zero,
    BlendOp colorBlendOperation = BlendOp.Add,
    BlendOp alphaBlendOperation = BlendOp.Add)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[7];
    numPtr[0] = (System.IntPtr) &writeMask;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceColorBlendMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &destinationColorBlendMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &sourceAlphaBlendMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &destinationAlphaBlendMode;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &colorBlendOperation;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &alphaBlendOperation;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr__ctor_Public_Void_ColorWriteMask_BlendMode_BlendMode_BlendMode_BlendMode_BlendOp_BlendOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 488182, RefRangeEnd = 488187, XrefRangeStart = 488182, XrefRangeEnd = 488182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(RenderTargetBlendState other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetBlendState_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488187, XrefRangeEnd = 488190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 488197, RefRangeEnd = 488199, XrefRangeStart = 488190, XrefRangeEnd = 488197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetBlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetBlendState>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static RenderTargetBlendState defaultValue => new RenderTargetBlendState();

  public ColorWriteMask writeMask
  {
    get => (ColorWriteMask) this.m_WriteMask;
    set => this.m_WriteMask = (byte) value;
  }

  public BlendMode sourceColorBlendMode
  {
    get => (BlendMode) this.m_SourceColorBlendMode;
    set => this.m_SourceColorBlendMode = (byte) value;
  }

  public BlendMode destinationColorBlendMode
  {
    get => (BlendMode) this.m_DestinationColorBlendMode;
    set => this.m_DestinationColorBlendMode = (byte) value;
  }

  public BlendMode sourceAlphaBlendMode
  {
    get => (BlendMode) this.m_SourceAlphaBlendMode;
    set => this.m_SourceAlphaBlendMode = (byte) value;
  }

  public BlendMode destinationAlphaBlendMode
  {
    get => (BlendMode) this.m_DestinationAlphaBlendMode;
    set => this.m_DestinationAlphaBlendMode = (byte) value;
  }

  public BlendOp colorBlendOperation
  {
    get => (BlendOp) this.m_ColorBlendOperation;
    set => this.m_ColorBlendOperation = (byte) value;
  }

  public BlendOp alphaBlendOperation
  {
    get => (BlendOp) this.m_AlphaBlendOperation;
    set => this.m_AlphaBlendOperation = (byte) value;
  }

  public static bool operator ==(RenderTargetBlendState left, RenderTargetBlendState right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(RenderTargetBlendState left, RenderTargetBlendState right)
  {
    return !left.Equals(right);
  }
}
