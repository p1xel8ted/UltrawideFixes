// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderTargetIdentifier
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
public struct RenderTargetIdentifier
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AllDepthSlices;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NameID;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InstanceID;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BufferPointer;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MipLevel;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CubeFace;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DepthSlice;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Texture_Int32_CubemapFace_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0;
  [FieldOffset(0)]
  public BuiltinRenderTextureType m_Type;
  [FieldOffset(4)]
  public int m_NameID;
  [FieldOffset(8)]
  public int m_InstanceID;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_BufferPointer;
  [FieldOffset(24)]
  public int m_MipLevel;
  [FieldOffset(28)]
  public CubemapFace m_CubeFace;
  [FieldOffset(32 /*0x20*/)]
  public int m_DepthSlice;

  static RenderTargetIdentifier()
  {
    Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderTargetIdentifier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr);
    RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, nameof (AllDepthSlices));
    RenderTargetIdentifier.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, nameof (m_Type));
    RenderTargetIdentifier.NativeFieldInfoPtr_m_NameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, nameof (m_NameID));
    RenderTargetIdentifier.NativeFieldInfoPtr_m_InstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, nameof (m_InstanceID));
    RenderTargetIdentifier.NativeFieldInfoPtr_m_BufferPointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, nameof (m_BufferPointer));
    RenderTargetIdentifier.NativeFieldInfoPtr_m_MipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, nameof (m_MipLevel));
    RenderTargetIdentifier.NativeFieldInfoPtr_m_CubeFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, nameof (m_CubeFace));
    RenderTargetIdentifier.NativeFieldInfoPtr_m_DepthSlice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, nameof (m_DepthSlice));
    RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669650);
    RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669651);
    RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669652);
    RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669653);
    RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_Int32_CubemapFace_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669654);
    RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669655);
    RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669656);
    RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669657);
    RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669658);
    RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669659);
    RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669660);
    RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669661);
    RenderTargetIdentifier.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, 100669662);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 482067, RefRangeEnd = 482074, XrefRangeStart = 482067, XrefRangeEnd = 482067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTargetIdentifier(BuiltinRenderTextureType type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &type
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_BuiltinRenderTextureType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe RenderTargetIdentifier(int nameID)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &nameID
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 482074, RefRangeEnd = 482088, XrefRangeStart = 482074, XrefRangeEnd = 482074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTargetIdentifier(
    RenderTargetIdentifier renderTargetIdentifier,
    int mipLevel,
    CubemapFace cubeFace = CubemapFace.Unknown,
    int depthSlice = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &renderTargetIdentifier;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cubeFace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSlice;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_RenderTargetIdentifier_Int32_CubemapFace_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 482101, RefRangeEnd = 482124, XrefRangeStart = 482088, XrefRangeEnd = 482101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTargetIdentifier(Texture tex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tex)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 482136, RefRangeEnd = 482137, XrefRangeStart = 482124, XrefRangeEnd = 482136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderTargetIdentifier(
    Texture tex,
    int mipLevel = 0,
    CubemapFace cubeFace = CubemapFace.Unknown,
    int depthSlice = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tex);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mipLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cubeFace;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depthSlice;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr__ctor_Public_Void_Texture_Int32_CubemapFace_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 482137, RefRangeEnd = 482138, XrefRangeStart = 482137, XrefRangeEnd = 482137, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator RenderTargetIdentifier(BuiltinRenderTextureType type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &type
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_BuiltinRenderTextureType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RenderTargetIdentifier*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 482138, RefRangeEnd = 482142, XrefRangeStart = 482138, XrefRangeEnd = 482138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator RenderTargetIdentifier(int nameID)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &nameID
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RenderTargetIdentifier*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(101)]
  [CachedScanResults(RefRangeStart = 482155, RefRangeEnd = 482256, XrefRangeStart = 482142, XrefRangeEnd = 482155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator RenderTargetIdentifier(Texture tex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) tex)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Implicit_Public_Static_RenderTargetIdentifier_Texture_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(RenderTargetIdentifier*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482256, XrefRangeEnd = 482285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 482288, RefRangeEnd = 482291, XrefRangeStart = 482285, XrefRangeEnd = 482288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 482291, RefRangeEnd = 482293, XrefRangeStart = 482291, XrefRangeEnd = 482291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(RenderTargetIdentifier rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rhs
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RenderTargetIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482293, XrefRangeEnd = 482296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 482296, RefRangeEnd = 482297, XrefRangeStart = 482296, XrefRangeEnd = 482296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderTargetIdentifier.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RenderTargetIdentifier_RenderTargetIdentifier_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RenderTargetIdentifier>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe int AllDepthSlices
  {
    get
    {
      int allDepthSlices;
      IL2CPP.il2cpp_field_static_get_value(RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices, (void*) &allDepthSlices);
      return allDepthSlices;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RenderTargetIdentifier.NativeFieldInfoPtr_AllDepthSlices, (void*) &value);
    }
  }

  public static implicit operator RenderTargetIdentifier(string name)
  {
    return new RenderTargetIdentifier(name);
  }

  public static implicit operator RenderTargetIdentifier(RenderBuffer buf)
  {
    return new RenderTargetIdentifier(buf, 0, CubemapFace.Unknown, 0);
  }

  public static bool operator ==(RenderTargetIdentifier lhs, RenderTargetIdentifier rhs)
  {
    return lhs.Equals(rhs);
  }
}
