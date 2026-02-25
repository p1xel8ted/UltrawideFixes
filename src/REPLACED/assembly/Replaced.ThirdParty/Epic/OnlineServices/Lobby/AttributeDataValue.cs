// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.AttributeDataValue
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

public class AttributeDataValue(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AsInt64;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AsDouble;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AsBool;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AsUtf8;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ValueType;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_1_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_1_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_1_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_1_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AsUtf8_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ValueType_Public_get_AttributeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ValueType_Private_set_Void_AttributeType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_AttributeDataValueInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AttributeDataValue()
  {
    Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (AttributeDataValue));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr);
    AttributeDataValue.NativeFieldInfoPtr_m_AsInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_AsInt64));
    AttributeDataValue.NativeFieldInfoPtr_m_AsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_AsDouble));
    AttributeDataValue.NativeFieldInfoPtr_m_AsBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_AsBool));
    AttributeDataValue.NativeFieldInfoPtr_m_AsUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_AsUtf8));
    AttributeDataValue.NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, nameof (m_ValueType));
    AttributeDataValue.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668900);
    AttributeDataValue.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668901);
    AttributeDataValue.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668902);
    AttributeDataValue.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668903);
    AttributeDataValue.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668904);
    AttributeDataValue.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668905);
    AttributeDataValue.NativeMethodInfoPtr_get_AsUtf8_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668906);
    AttributeDataValue.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668907);
    AttributeDataValue.NativeMethodInfoPtr_get_ValueType_Public_get_AttributeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668908);
    AttributeDataValue.NativeMethodInfoPtr_set_ValueType_Private_set_Void_AttributeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668909);
    AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668910);
    AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668911);
    AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668912);
    AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668913);
    AttributeDataValue.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_AttributeDataValueInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668914);
    AttributeDataValue.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668915);
    AttributeDataValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, 100668916);
  }

  public unsafe Il2CppSystem.Nullable<long> AsInt64
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388542, XrefRangeEnd = 388548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<long>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388548, XrefRangeEnd = 388554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<double> AsDouble
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388554, XrefRangeEnd = 388560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<double>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388560, XrefRangeEnd = 388566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<bool> AsBool
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388566, XrefRangeEnd = 388572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<bool>(pointer);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 388578, RefRangeEnd = 388580, XrefRangeStart = 388572, XrefRangeEnd = 388578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AsUtf8
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388580, XrefRangeEnd = 388586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_AsUtf8_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 388592, RefRangeEnd = 388594, XrefRangeStart = 388586, XrefRangeEnd = 388592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AttributeType ValueType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_get_ValueType_Public_get_AttributeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AttributeType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 139338, RefRangeEnd = 139339, XrefRangeStart = 139338, XrefRangeEnd = 139339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_set_ValueType_Private_set_Void_AttributeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388594, XrefRangeEnd = 388607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator AttributeDataValue(long value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AttributeDataValue) null : Il2CppObjectPool.Get<AttributeDataValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388607, XrefRangeEnd = 388620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator AttributeDataValue(double value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AttributeDataValue) null : Il2CppObjectPool.Get<AttributeDataValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388620, XrefRangeEnd = 388628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator AttributeDataValue(bool value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AttributeDataValue) null : Il2CppObjectPool.Get<AttributeDataValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388628, XrefRangeEnd = 388633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator AttributeDataValue(string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_op_Implicit_Public_Static_AttributeDataValue_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AttributeDataValue) null : Il2CppObjectPool.Get<AttributeDataValue>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 388681, RefRangeEnd = 388682, XrefRangeStart = 388633, XrefRangeEnd = 388681, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<AttributeDataValueInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_AttributeDataValueInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388682, XrefRangeEnd = 388687, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttributeDataValue()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Nullable<long> m_AsInt64
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsInt64);
      return new Il2CppSystem.Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<long>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsInt64), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<long>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<double> m_AsDouble
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsDouble);
      return new Il2CppSystem.Nullable<double>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<double>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsDouble), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<double>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<bool> m_AsBool
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsBool);
      return new Il2CppSystem.Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsBool), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<bool>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe string m_AsUtf8
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsUtf8)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_AsUtf8), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe AttributeType m_ValueType
  {
    get
    {
      return *(AttributeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_ValueType));
    }
    [param: In] set
    {
      *(AttributeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeDataValue.NativeFieldInfoPtr_m_ValueType)) = value;
    }
  }
}
