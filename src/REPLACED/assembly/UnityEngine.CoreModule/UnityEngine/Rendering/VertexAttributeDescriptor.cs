// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.VertexAttributeDescriptor
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
public struct VertexAttributeDescriptor
{
  private static readonly System.IntPtr NativeFieldInfoPtr__attribute_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__format_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__dimension_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__stream_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_dimension_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_stream_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0;
  [FieldOffset(0)]
  public VertexAttribute _attribute_k__BackingField;
  [FieldOffset(4)]
  public VertexAttributeFormat _format_k__BackingField;
  [FieldOffset(8)]
  public int _dimension_k__BackingField;
  [FieldOffset(12)]
  public int _stream_k__BackingField;

  static VertexAttributeDescriptor()
  {
    Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (VertexAttributeDescriptor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr);
    VertexAttributeDescriptor.NativeFieldInfoPtr__attribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<attribute>k__BackingField");
    VertexAttributeDescriptor.NativeFieldInfoPtr__format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<format>k__BackingField");
    VertexAttributeDescriptor.NativeFieldInfoPtr__dimension_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<dimension>k__BackingField");
    VertexAttributeDescriptor.NativeFieldInfoPtr__stream_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, "<stream>k__BackingField");
    VertexAttributeDescriptor.NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669637);
    VertexAttributeDescriptor.NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669638);
    VertexAttributeDescriptor.NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669639);
    VertexAttributeDescriptor.NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669640);
    VertexAttributeDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669641);
    VertexAttributeDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669642);
    VertexAttributeDescriptor.NativeMethodInfoPtr_get_stream_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669643);
    VertexAttributeDescriptor.NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669644);
    VertexAttributeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669645);
    VertexAttributeDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669646);
    VertexAttributeDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669647);
    VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669648);
    VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, 100669649);
  }

  public unsafe VertexAttribute attribute
  {
    [CallerCount(280), CachedScanResults(RefRangeStart = 147948, RefRangeEnd = 148228, XrefRangeStart = 147948, XrefRangeEnd = 148228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_attribute_Public_get_VertexAttribute_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(VertexAttribute*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_attribute_Public_set_Void_VertexAttribute_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe VertexAttributeFormat format
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_format_Public_get_VertexAttributeFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(VertexAttributeFormat*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_format_Public_set_Void_VertexAttributeFormat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int dimension
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_dimension_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 147413, RefRangeEnd = 147418, XrefRangeStart = 147413, XrefRangeEnd = 147418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_dimension_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int stream
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_get_stream_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147852, RefRangeEnd = 147856, XrefRangeStart = 147852, XrefRangeEnd = 147856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_set_stream_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 148568, RefRangeEnd = 148585, XrefRangeStart = 148568, XrefRangeEnd = 148585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VertexAttributeDescriptor(
    VertexAttribute attribute = VertexAttribute.Position,
    VertexAttributeFormat format = VertexAttributeFormat.Float32,
    int dimension = 3,
    int stream = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &attribute;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &format;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &dimension;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stream;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_VertexAttribute_VertexAttributeFormat_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482044, XrefRangeEnd = 482064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 482064, XrefRangeEnd = 482067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(VertexAttributeDescriptor other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VertexAttributeDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_VertexAttributeDescriptor_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VertexAttributeDescriptor>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool operator ==(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
  {
    return lhs.Equals(rhs);
  }

  public static bool operator !=(VertexAttributeDescriptor lhs, VertexAttributeDescriptor rhs)
  {
    return !lhs.Equals(rhs);
  }
}
