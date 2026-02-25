// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.AttributeDataValueInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct AttributeDataValueInternal
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AttributeDataValue_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public long m_AsInt64;
  [FieldOffset(0)]
  public double m_AsDouble;
  [FieldOffset(0)]
  public int m_AsBool;
  [FieldOffset(0)]
  public System.IntPtr m_AsUtf8;
  [FieldOffset(8)]
  public AttributeType m_ValueType;

  static AttributeDataValueInternal()
  {
    Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (AttributeDataValueInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr);
    AttributeDataValueInternal.NativeFieldInfoPtr_m_AsInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsInt64));
    AttributeDataValueInternal.NativeFieldInfoPtr_m_AsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsDouble));
    AttributeDataValueInternal.NativeFieldInfoPtr_m_AsBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsBool));
    AttributeDataValueInternal.NativeFieldInfoPtr_m_AsUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsUtf8));
    AttributeDataValueInternal.NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_ValueType));
    AttributeDataValueInternal.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665351 /*0x06000807*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665352 /*0x06000808*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665353 /*0x06000809*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665354 /*0x0600080A*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665355 /*0x0600080B*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665356 /*0x0600080C*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_get_AsUtf8_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665357 /*0x0600080D*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665358 /*0x0600080E*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Void_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665359 /*0x0600080F*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665360 /*0x06000810*/);
    AttributeDataValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100665361);
  }

  public unsafe Il2CppSystem.Nullable<long> AsInt64
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377370, XrefRangeEnd = 377376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<long>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 377385, RefRangeEnd = 377386, XrefRangeStart = 377376, XrefRangeEnd = 377385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<double> AsDouble
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377386, XrefRangeEnd = 377392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_1_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<double>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 377401, RefRangeEnd = 377402, XrefRangeStart = 377392, XrefRangeEnd = 377401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_1_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<bool> AsBool
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377402, XrefRangeEnd = 377408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_1_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<bool>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 377417, RefRangeEnd = 377418, XrefRangeStart = 377408, XrefRangeEnd = 377417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_1_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string AsUtf8
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377418, XrefRangeEnd = 377424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsUtf8_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 377433, RefRangeEnd = 377434, XrefRangeStart = 377424, XrefRangeEnd = 377433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 377462, RefRangeEnd = 377463, XrefRangeStart = 377434, XrefRangeEnd = 377462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(AttributeDataValue other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Void_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377463, XrefRangeEnd = 377466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 377466, XrefRangeEnd = 377472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
