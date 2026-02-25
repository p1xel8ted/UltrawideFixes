// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionModificationAddAttributeOptionsInternal
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
public struct SessionModificationAddAttributeOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionAttribute;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AdvertisementType;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionAttribute_Public_set_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SessionModificationAddAttributeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SessionAttribute;
  [FieldOffset(16 /*0x10*/)]
  public SessionAttributeAdvertisementType m_AdvertisementType;

  static SessionModificationAddAttributeOptionsInternal()
  {
    Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionModificationAddAttributeOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr);
    SessionModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SessionModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_SessionAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_SessionAttribute));
    SessionModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_AdvertisementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_AdvertisementType));
    SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_SessionAttribute_Public_set_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100665878);
    SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100665879);
    SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionModificationAddAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100665880);
    SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100665881);
    SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100665882);
  }

  public unsafe AttributeData SessionAttribute
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 378822, RefRangeEnd = 378824, XrefRangeStart = 378816, XrefRangeEnd = 378822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_SessionAttribute_Public_set_Void_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SessionAttributeAdvertisementType AdvertisementType
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378824, XrefRangeEnd = 378825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SessionModificationAddAttributeOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionModificationAddAttributeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378825, XrefRangeEnd = 378828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378828, XrefRangeEnd = 378832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
