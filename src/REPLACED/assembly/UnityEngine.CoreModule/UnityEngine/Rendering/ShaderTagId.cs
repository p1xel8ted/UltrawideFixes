// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ShaderTagId
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
public struct ShaderTagId
{
  private static readonly System.IntPtr NativeFieldInfoPtr_none;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Internal_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0;
  [FieldOffset(0)]
  public int m_Id;

  static ShaderTagId()
  {
    Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ShaderTagId));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr);
    ShaderTagId.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, nameof (none));
    ShaderTagId.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, nameof (m_Id));
    ShaderTagId.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100670557);
    ShaderTagId.NativeMethodInfoPtr_get_id_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100670558);
    ShaderTagId.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100670559);
    ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100670560);
    ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100670561);
    ShaderTagId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100670562);
    ShaderTagId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100670563);
    ShaderTagId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, 100670564);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 488609, RefRangeEnd = 488610, XrefRangeStart = 488608, XrefRangeEnd = 488609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShaderTagId(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr__ctor_Public_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int id
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_get_id_Internal_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_set_id_Internal_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488610, XrefRangeEnd = 488613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(ShaderTagId other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ShaderTagId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488613, XrefRangeEnd = 488614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 307349, RefRangeEnd = 307358, XrefRangeStart = 307349, XrefRangeEnd = 307358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(ShaderTagId tag1, ShaderTagId tag2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &tag1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tag2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 478733, RefRangeEnd = 478734, XrefRangeStart = 478733, XrefRangeEnd = 478734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(ShaderTagId tag1, ShaderTagId tag2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &tag1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &tag2;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderTagId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ShaderTagId_ShaderTagId_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderTagId>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe ShaderTagId none
  {
    get
    {
      ShaderTagId none;
      IL2CPP.il2cpp_field_static_get_value(ShaderTagId.NativeFieldInfoPtr_none, (void*) &none);
      return none;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ShaderTagId.NativeFieldInfoPtr_none, (void*) &value);
    }
  }

  public string name => Shader.IDToTag(this.id);

  public static explicit operator ShaderTagId(string name) => new ShaderTagId(name);

  public static explicit operator string(ShaderTagId tagId) => tagId.name;
}
