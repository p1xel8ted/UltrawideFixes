// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.AttachmentDescriptor
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using UnityEngine.Experimental.Rendering;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AttachmentDescriptor
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StoreAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Format;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LoadStoreTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ResolveTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearDepth;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClearStencil;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_resolveTarget_Public_set_Void_RenderTargetIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_clearColor_Public_set_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_clearDepth_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_clearStencil_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public RenderBufferLoadAction m_LoadAction;
  [FieldOffset(4)]
  public RenderBufferStoreAction m_StoreAction;
  [FieldOffset(8)]
  public GraphicsFormat m_Format;
  [FieldOffset(16 /*0x10*/)]
  public RenderTargetIdentifier m_LoadStoreTarget;
  [FieldOffset(56)]
  public RenderTargetIdentifier m_ResolveTarget;
  [FieldOffset(96 /*0x60*/)]
  public Color m_ClearColor;
  [FieldOffset(112 /*0x70*/)]
  public float m_ClearDepth;
  [FieldOffset(116)]
  public uint m_ClearStencil;

  static AttachmentDescriptor()
  {
    Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (AttachmentDescriptor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr);
    AttachmentDescriptor.NativeFieldInfoPtr_m_LoadAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, nameof (m_LoadAction));
    AttachmentDescriptor.NativeFieldInfoPtr_m_StoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, nameof (m_StoreAction));
    AttachmentDescriptor.NativeFieldInfoPtr_m_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, nameof (m_Format));
    AttachmentDescriptor.NativeFieldInfoPtr_m_LoadStoreTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, nameof (m_LoadStoreTarget));
    AttachmentDescriptor.NativeFieldInfoPtr_m_ResolveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, nameof (m_ResolveTarget));
    AttachmentDescriptor.NativeFieldInfoPtr_m_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, nameof (m_ClearColor));
    AttachmentDescriptor.NativeFieldInfoPtr_m_ClearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, nameof (m_ClearDepth));
    AttachmentDescriptor.NativeFieldInfoPtr_m_ClearStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, nameof (m_ClearStencil));
    AttachmentDescriptor.NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670315);
    AttachmentDescriptor.NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670316);
    AttachmentDescriptor.NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670317);
    AttachmentDescriptor.NativeMethodInfoPtr_set_resolveTarget_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670318);
    AttachmentDescriptor.NativeMethodInfoPtr_set_clearColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670319);
    AttachmentDescriptor.NativeMethodInfoPtr_set_clearDepth_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670320);
    AttachmentDescriptor.NativeMethodInfoPtr_set_clearStencil_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670321);
    AttachmentDescriptor.NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670322);
    AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670323);
    AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670324);
    AttachmentDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100670325);
  }

  public unsafe RenderBufferLoadAction loadAction
  {
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_LoadAction;
  }

  public unsafe RenderBufferStoreAction storeAction
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_StoreAction;
  }

  public unsafe RenderTargetIdentifier loadStoreTarget
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 487263, RefRangeEnd = 487264, XrefRangeStart = 487263, XrefRangeEnd = 487263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_LoadStoreTarget;
  }

  public unsafe RenderTargetIdentifier resolveTarget
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 487264, RefRangeEnd = 487265, XrefRangeStart = 487264, XrefRangeEnd = 487264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_resolveTarget_Public_set_Void_RenderTargetIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ResolveTarget;
  }

  public unsafe Color clearColor
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 487265, RefRangeEnd = 487267, XrefRangeStart = 487265, XrefRangeEnd = 487265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_clearColor_Public_set_Void_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ClearColor;
  }

  public unsafe float clearDepth
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 487267, RefRangeEnd = 487269, XrefRangeStart = 487267, XrefRangeEnd = 487267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_clearDepth_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ClearDepth;
  }

  public unsafe uint clearStencil
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 487269, RefRangeEnd = 487270, XrefRangeStart = 487269, XrefRangeEnd = 487269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_clearStencil_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_ClearStencil;
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487272, RefRangeEnd = 487273, XrefRangeStart = 487270, XrefRangeEnd = 487272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttachmentDescriptor(GraphicsFormat format)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &format
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487281, RefRangeEnd = 487282, XrefRangeStart = 487273, XrefRangeEnd = 487281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(AttachmentDescriptor other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487282, XrefRangeEnd = 487286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487286, XrefRangeEnd = 487290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public GraphicsFormat graphicsFormat
  {
    get => this.m_Format;
    set => this.m_Format = value;
  }

  public RenderTextureFormat format
  {
    get
    {
      return GraphicsFormatUtility.IsDepthStencilFormat(this.m_Format) ? RenderTextureFormat.Depth : GraphicsFormatUtility.GetRenderTextureFormat(this.m_Format);
    }
    set
    {
      this.m_Format = AttachmentDescriptor.GetAdjustedFormat(value, RenderTextureReadWrite.Default);
    }
  }

  public void ConfigureTarget(
    RenderTargetIdentifier target,
    bool loadExistingContents,
    bool storeResults)
  {
    this.m_LoadStoreTarget = target;
    if (loadExistingContents && this.m_LoadAction != RenderBufferLoadAction.Clear)
      this.m_LoadAction = RenderBufferLoadAction.Load;
    if (!storeResults)
      return;
    this.m_StoreAction = this.m_StoreAction != RenderBufferStoreAction.StoreAndResolve && this.m_StoreAction != RenderBufferStoreAction.Resolve ? RenderBufferStoreAction.Store : RenderBufferStoreAction.StoreAndResolve;
  }

  public void ConfigureResolveTarget(RenderTargetIdentifier target)
  {
    this.m_ResolveTarget = target;
    if (this.m_StoreAction == RenderBufferStoreAction.StoreAndResolve || this.m_StoreAction == RenderBufferStoreAction.Store)
      this.m_StoreAction = RenderBufferStoreAction.StoreAndResolve;
    else
      this.m_StoreAction = RenderBufferStoreAction.Resolve;
  }

  public void ConfigureClear(Color clearColor, float clearDepth = default (float), uint clearStencil = default (uint))
  {
    this.m_ClearColor = clearColor;
    this.m_ClearDepth = clearDepth;
    this.m_ClearStencil = clearStencil;
    this.m_LoadAction = RenderBufferLoadAction.Clear;
  }

  public static GraphicsFormat GetAdjustedFormat(
    RenderTextureFormat format,
    RenderTextureReadWrite readWrite)
  {
    switch (format)
    {
      case RenderTextureFormat.Depth:
      case RenderTextureFormat.Shadowmap:
        return SystemInfo.GetGraphicsFormat(format == RenderTextureFormat.Depth ? DefaultFormat.DepthStencil : DefaultFormat.Shadow);
      default:
        return GraphicsFormatUtility.GetGraphicsFormat(format, readWrite);
    }
  }

  public static bool operator ==(AttachmentDescriptor left, AttachmentDescriptor right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(AttachmentDescriptor left, AttachmentDescriptor right)
  {
    return !left.Equals(right);
  }
}
