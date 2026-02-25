// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.IdTokenInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

[StructLayout(LayoutKind.Explicit)]
public struct IdTokenInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_JsonWebToken;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_JsonWebToken_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_JsonWebToken_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_IdToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ProductUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_JsonWebToken;

  static IdTokenInternal()
  {
    Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (IdTokenInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr);
    IdTokenInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, nameof (m_ApiVersion));
    IdTokenInternal.NativeFieldInfoPtr_m_ProductUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, nameof (m_ProductUserId));
    IdTokenInternal.NativeFieldInfoPtr_m_JsonWebToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, nameof (m_JsonWebToken));
    IdTokenInternal.NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, 100671667);
    IdTokenInternal.NativeMethodInfoPtr_set_ProductUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, 100671668);
    IdTokenInternal.NativeMethodInfoPtr_get_JsonWebToken_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, 100671669);
    IdTokenInternal.NativeMethodInfoPtr_set_JsonWebToken_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, 100671670);
    IdTokenInternal.NativeMethodInfoPtr_Set_Public_Void_IdToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, 100671671);
    IdTokenInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, 100671672);
    IdTokenInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, 100671673);
  }

  public unsafe ProductUserId ProductUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397277, XrefRangeEnd = 397283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IdTokenInternal.NativeMethodInfoPtr_get_ProductUserId_Public_get_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ProductUserId) null : Il2CppObjectPool.Get<ProductUserId>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397283, XrefRangeEnd = 397287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IdTokenInternal.NativeMethodInfoPtr_set_ProductUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string JsonWebToken
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397287, XrefRangeEnd = 397291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IdTokenInternal.NativeMethodInfoPtr_get_JsonWebToken_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397291, XrefRangeEnd = 397295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IdTokenInternal.NativeMethodInfoPtr_set_JsonWebToken_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 397303, RefRangeEnd = 397304, XrefRangeStart = 397295, XrefRangeEnd = 397303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(IdToken other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IdTokenInternal.NativeMethodInfoPtr_Set_Public_Void_IdToken_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397304, XrefRangeEnd = 397307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IdTokenInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 397307, XrefRangeEnd = 397312 /*0x061000*/, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IdTokenInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<IdTokenInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
