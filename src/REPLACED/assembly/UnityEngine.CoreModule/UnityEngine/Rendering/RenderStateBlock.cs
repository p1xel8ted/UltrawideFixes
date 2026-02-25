// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderStateBlock
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
public struct RenderStateBlock
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BlendState;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RasterState;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthState;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StencilState;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StencilReference;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Mask;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public BlendState m_BlendState;
  [FieldOffset(68)]
  public RasterState m_RasterState;
  [FieldOffset(84)]
  public DepthState m_DepthState;
  [FieldOffset(86)]
  public StencilState m_StencilState;
  [FieldOffset(100)]
  public int m_StencilReference;
  [FieldOffset(104)]
  public RenderStateMask m_Mask;

  static RenderStateBlock()
  {
    Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderStateBlock));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr);
    RenderStateBlock.NativeFieldInfoPtr_m_BlendState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, nameof (m_BlendState));
    RenderStateBlock.NativeFieldInfoPtr_m_RasterState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, nameof (m_RasterState));
    RenderStateBlock.NativeFieldInfoPtr_m_DepthState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, nameof (m_DepthState));
    RenderStateBlock.NativeFieldInfoPtr_m_StencilState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, nameof (m_StencilState));
    RenderStateBlock.NativeFieldInfoPtr_m_StencilReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, nameof (m_StencilReference));
    RenderStateBlock.NativeFieldInfoPtr_m_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, nameof (m_Mask));
    RenderStateBlock.NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100670493);
    RenderStateBlock.NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100670494);
    RenderStateBlock.NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100670495);
    RenderStateBlock.NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100670496);
    RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100670497);
    RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100670498);
    RenderStateBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, 100670499);
  }

  public unsafe BlendState blendState
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_blendState_Public_set_Void_BlendState_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_BlendState;
  }

  public unsafe RasterState rasterState
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_rasterState_Public_set_Void_RasterState_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_RasterState;
  }

  public unsafe DepthState depthState
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_depthState_Public_set_Void_DepthState_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_DepthState;
  }

  public unsafe RenderStateMask mask
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 298986, RefRangeEnd = 298987, XrefRangeStart = 298986, XrefRangeEnd = 298987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_set_mask_Public_set_Void_RenderStateMask_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_Mask;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488167, RefRangeEnd = 488168, XrefRangeStart = 488161, XrefRangeEnd = 488167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(RenderStateBlock other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderStateBlock_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488168, XrefRangeEnd = 488172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488172, XrefRangeEnd = 488182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderStateBlock.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderStateBlock>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public StencilState stencilState
  {
    get => this.m_StencilState;
    set => this.m_StencilState = value;
  }

  public int stencilReference
  {
    get => this.m_StencilReference;
    set => this.m_StencilReference = value;
  }

  public static bool operator ==(RenderStateBlock left, RenderStateBlock right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(RenderStateBlock left, RenderStateBlock right)
  {
    return !left.Equals(right);
  }
}
