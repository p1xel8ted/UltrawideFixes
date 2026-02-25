// Decompiled with JetBrains decompiler
// Type: UnityEngine.PropertyName
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct PropertyName
{
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_PropertyName_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PropertyName_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  [FieldOffset(0)]
  public int id;

  static PropertyName()
  {
    Il2CppClassPointerStore<PropertyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (PropertyName));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyName>.NativeClassPtr);
    PropertyName.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, nameof (id));
    PropertyName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667752);
    PropertyName.NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667753);
    PropertyName.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667754);
    PropertyName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667755);
    PropertyName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667756);
    PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667757);
    PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667758);
    PropertyName.NativeMethodInfoPtr_op_Implicit_Public_Static_PropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667759);
    PropertyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, 100667760);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441908, RefRangeEnd = 441909, XrefRangeStart = 441907, XrefRangeEnd = 441908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PropertyName(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr__ctor_Public_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PropertyName(PropertyName other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr__ctor_Public_Void_PropertyName_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 441909, RefRangeEnd = 441910, XrefRangeStart = 441909, XrefRangeEnd = 441909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsNullOrEmpty(PropertyName prop)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &prop
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_PropertyName_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 307349, RefRangeEnd = 307358, XrefRangeStart = 307349, XrefRangeEnd = 307358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(PropertyName lhs, PropertyName rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PropertyName_PropertyName_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(239)]
  [CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441910, XrefRangeEnd = 441913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(PropertyName other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PropertyName_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 441914, RefRangeEnd = 441939, XrefRangeStart = 441913, XrefRangeEnd = 441914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator PropertyName(string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_op_Implicit_Public_Static_PropertyName_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PropertyName*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441939, XrefRangeEnd = 441944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PropertyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PropertyName>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool operator !=(PropertyName lhs, PropertyName rhs) => lhs.id != rhs.id;

  public static implicit operator PropertyName(int id) => new PropertyName(id);
}
