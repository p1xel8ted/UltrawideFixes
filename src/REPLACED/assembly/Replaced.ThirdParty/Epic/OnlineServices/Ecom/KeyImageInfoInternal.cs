// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.KeyImageInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom;

[StructLayout(LayoutKind.Explicit)]
public struct KeyImageInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Url;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Width;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Height;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Url_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Url_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Width_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Height_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_KeyImageInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Type;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_Url;
  [FieldOffset(24)]
  public uint m_Width;
  [FieldOffset(28)]
  public uint m_Height;

  static KeyImageInfoInternal()
  {
    Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Ecom", nameof (KeyImageInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr);
    KeyImageInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    KeyImageInfoInternal.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_Type));
    KeyImageInfoInternal.NativeFieldInfoPtr_m_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_Url));
    KeyImageInfoInternal.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_Width));
    KeyImageInfoInternal.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_Height));
    KeyImageInfoInternal.NativeMethodInfoPtr_get_Type_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671083);
    KeyImageInfoInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671084);
    KeyImageInfoInternal.NativeMethodInfoPtr_get_Url_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671085);
    KeyImageInfoInternal.NativeMethodInfoPtr_set_Url_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671086);
    KeyImageInfoInternal.NativeMethodInfoPtr_get_Width_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671087);
    KeyImageInfoInternal.NativeMethodInfoPtr_set_Width_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671088);
    KeyImageInfoInternal.NativeMethodInfoPtr_get_Height_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671089);
    KeyImageInfoInternal.NativeMethodInfoPtr_set_Height_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671090);
    KeyImageInfoInternal.NativeMethodInfoPtr_Set_Public_Void_KeyImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671091);
    KeyImageInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671092);
    KeyImageInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100671093);
  }

  public unsafe string Type
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395375, XrefRangeEnd = 395379, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_get_Type_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395379, XrefRangeEnd = 395383, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Url
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395383, XrefRangeEnd = 395387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_get_Url_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395387, XrefRangeEnd = 395391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_set_Url_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint Width
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_get_Width_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_set_Width_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint Height
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_get_Height_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_set_Height_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 395399, RefRangeEnd = 395400, XrefRangeStart = 395391, XrefRangeEnd = 395399, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(KeyImageInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_Set_Public_Void_KeyImageInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395400, XrefRangeEnd = 395403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395403, XrefRangeEnd = 395408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
