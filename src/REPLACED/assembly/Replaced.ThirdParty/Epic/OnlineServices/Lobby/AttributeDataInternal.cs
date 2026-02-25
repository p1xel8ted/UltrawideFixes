// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.AttributeDataInternal
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

[StructLayout(LayoutKind.Explicit)]
public struct AttributeDataInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Key;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Value;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_AttributeDataValue_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_AttributeDataValue_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Key;
  [FieldOffset(16 /*0x10*/)]
  public AttributeDataValueInternal m_Value;

  static AttributeDataInternal()
  {
    Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (AttributeDataInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr);
    AttributeDataInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, nameof (m_ApiVersion));
    AttributeDataInternal.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, nameof (m_Key));
    AttributeDataInternal.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, nameof (m_Value));
    AttributeDataInternal.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100668893);
    AttributeDataInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100668894);
    AttributeDataInternal.NativeMethodInfoPtr_get_Value_Public_get_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100668895);
    AttributeDataInternal.NativeMethodInfoPtr_set_Value_Public_set_Void_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100668896);
    AttributeDataInternal.NativeMethodInfoPtr_Set_Public_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100668897);
    AttributeDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100668898);
    AttributeDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100668899);
  }

  public unsafe string Key
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388501, XrefRangeEnd = 388505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_get_Key_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388505, XrefRangeEnd = 388509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AttributeDataValue Value
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388509, XrefRangeEnd = 388515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_get_Value_Public_get_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AttributeDataValue) null : Il2CppObjectPool.Get<AttributeDataValue>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 388521, RefRangeEnd = 388523, XrefRangeStart = 388515, XrefRangeEnd = 388521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_set_Value_Public_set_Void_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388523, XrefRangeEnd = 388528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(AttributeData other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_Set_Public_Void_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388528, XrefRangeEnd = 388535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388535, XrefRangeEnd = 388542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
