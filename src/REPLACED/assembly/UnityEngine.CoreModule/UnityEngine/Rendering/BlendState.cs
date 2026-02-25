// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BlendState
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
public struct BlendState
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState0;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState1;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState2;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState3;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState4;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState5;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState6;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState7;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SeparateMRTBlendStates;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AlphaToMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Padding;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public RenderTargetBlendState m_BlendState0;
  [FieldOffset(8)]
  public RenderTargetBlendState m_BlendState1;
  [FieldOffset(16 /*0x10*/)]
  public RenderTargetBlendState m_BlendState2;
  [FieldOffset(24)]
  public RenderTargetBlendState m_BlendState3;
  [FieldOffset(32 /*0x20*/)]
  public RenderTargetBlendState m_BlendState4;
  [FieldOffset(40)]
  public RenderTargetBlendState m_BlendState5;
  [FieldOffset(48 /*0x30*/)]
  public RenderTargetBlendState m_BlendState6;
  [FieldOffset(56)]
  public RenderTargetBlendState m_BlendState7;
  [FieldOffset(64 /*0x40*/)]
  public byte m_SeparateMRTBlendStates;
  [FieldOffset(65)]
  public byte m_AlphaToMask;
  [FieldOffset(66)]
  public short m_Padding;

  static BlendState()
  {
    Il2CppClassPointerStore<BlendState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BlendState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendState>.NativeClassPtr);
    BlendState.NativeFieldInfoPtr_m_BlendState0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_BlendState0));
    BlendState.NativeFieldInfoPtr_m_BlendState1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_BlendState1));
    BlendState.NativeFieldInfoPtr_m_BlendState2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_BlendState2));
    BlendState.NativeFieldInfoPtr_m_BlendState3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_BlendState3));
    BlendState.NativeFieldInfoPtr_m_BlendState4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_BlendState4));
    BlendState.NativeFieldInfoPtr_m_BlendState5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_BlendState5));
    BlendState.NativeFieldInfoPtr_m_BlendState6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_BlendState6));
    BlendState.NativeFieldInfoPtr_m_BlendState7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_BlendState7));
    BlendState.NativeFieldInfoPtr_m_SeparateMRTBlendStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_SeparateMRTBlendStates));
    BlendState.NativeFieldInfoPtr_m_AlphaToMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_AlphaToMask));
    BlendState.NativeFieldInfoPtr_m_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendState>.NativeClassPtr, nameof (m_Padding));
    BlendState.NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100670331);
    BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100670332);
    BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100670333);
    BlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendState>.NativeClassPtr, 100670334);
  }

  public unsafe RenderTargetBlendState blendState0
  {
    [CallerCount(65), CachedScanResults(RefRangeStart = 79672, RefRangeEnd = 79737, XrefRangeStart = 79672, XrefRangeEnd = 79737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_set_blendState0_Public_set_Void_RenderTargetBlendState_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_BlendState0;
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487307, RefRangeEnd = 487309, XrefRangeStart = 487302, XrefRangeEnd = 487307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(BlendState other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BlendState_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487309, XrefRangeEnd = 487313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487359, RefRangeEnd = 487360, XrefRangeStart = 487313, XrefRangeEnd = 487359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BlendState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlendState>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static BlendState defaultValue => new BlendState(false, false);

  public bool separateMRTBlendStates
  {
    get => Il2CppSystem.Convert.ToBoolean(this.m_SeparateMRTBlendStates);
    set => this.m_SeparateMRTBlendStates = Il2CppSystem.Convert.ToByte(value);
  }

  public bool alphaToMask
  {
    get => Il2CppSystem.Convert.ToBoolean(this.m_AlphaToMask);
    set => this.m_AlphaToMask = Il2CppSystem.Convert.ToByte(value);
  }

  public RenderTargetBlendState blendState1
  {
    get => this.m_BlendState1;
    set => this.m_BlendState1 = value;
  }

  public RenderTargetBlendState blendState2
  {
    get => this.m_BlendState2;
    set => this.m_BlendState2 = value;
  }

  public RenderTargetBlendState blendState3
  {
    get => this.m_BlendState3;
    set => this.m_BlendState3 = value;
  }

  public RenderTargetBlendState blendState4
  {
    get => this.m_BlendState4;
    set => this.m_BlendState4 = value;
  }

  public RenderTargetBlendState blendState5
  {
    get => this.m_BlendState5;
    set => this.m_BlendState5 = value;
  }

  public RenderTargetBlendState blendState6
  {
    get => this.m_BlendState6;
    set => this.m_BlendState6 = value;
  }

  public RenderTargetBlendState blendState7
  {
    get => this.m_BlendState7;
    set => this.m_BlendState7 = value;
  }

  public static bool operator ==(BlendState left, BlendState right) => left.Equals(right);

  public static bool operator !=(BlendState left, BlendState right) => !left.Equals(right);
}
