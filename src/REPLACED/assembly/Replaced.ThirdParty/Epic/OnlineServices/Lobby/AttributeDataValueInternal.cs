// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.AttributeDataValueInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

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
    Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (AttributeDataValueInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr);
    AttributeDataValueInternal.NativeFieldInfoPtr_m_AsInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsInt64));
    AttributeDataValueInternal.NativeFieldInfoPtr_m_AsDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsDouble));
    AttributeDataValueInternal.NativeFieldInfoPtr_m_AsBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsBool));
    AttributeDataValueInternal.NativeFieldInfoPtr_m_AsUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_AsUtf8));
    AttributeDataValueInternal.NativeFieldInfoPtr_m_ValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, nameof (m_ValueType));
    AttributeDataValueInternal.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668917);
    AttributeDataValueInternal.NativeMethodInfoPtr_set_AsInt64_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668918);
    AttributeDataValueInternal.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668919);
    AttributeDataValueInternal.NativeMethodInfoPtr_set_AsDouble_Public_set_Void_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668920);
    AttributeDataValueInternal.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668921);
    AttributeDataValueInternal.NativeMethodInfoPtr_set_AsBool_Public_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668922);
    AttributeDataValueInternal.NativeMethodInfoPtr_get_AsUtf8_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668923);
    AttributeDataValueInternal.NativeMethodInfoPtr_set_AsUtf8_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668924);
    AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Void_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668925);
    AttributeDataValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668926);
    AttributeDataValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueInternal>.NativeClassPtr, 100668927);
  }

  public unsafe Il2CppSystem.Nullable<long> AsInt64
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388687, XrefRangeEnd = 388693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsInt64_Public_get_Nullable_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<long>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 388702, RefRangeEnd = 388703, XrefRangeStart = 388693, XrefRangeEnd = 388702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388703, XrefRangeEnd = 388709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsDouble_Public_get_Nullable_1_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<double>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 388718, RefRangeEnd = 388719, XrefRangeStart = 388709, XrefRangeEnd = 388718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388719, XrefRangeEnd = 388725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsBool_Public_get_Nullable_1_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<bool>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 388734, RefRangeEnd = 388735, XrefRangeStart = 388725, XrefRangeEnd = 388734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388735, XrefRangeEnd = 388741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueInternal.NativeMethodInfoPtr_get_AsUtf8_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 388750, RefRangeEnd = 388751, XrefRangeStart = 388741, XrefRangeEnd = 388750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
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
  [CachedScanResults(RefRangeStart = 388779, RefRangeEnd = 388780, XrefRangeStart = 388751, XrefRangeEnd = 388779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388780, XrefRangeEnd = 388783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 388789, RefRangeEnd = 388790, XrefRangeStart = 388783, XrefRangeEnd = 388789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
