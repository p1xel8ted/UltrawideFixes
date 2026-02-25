// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetailsAttributeInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct SessionDetailsAttributeInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AdvertisementType;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AdvertisementType_Public_get_SessionAttributeAdvertisementType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SessionDetailsAttribute_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Data;
  [FieldOffset(16 /*0x10*/)]
  public SessionAttributeAdvertisementType m_AdvertisementType;

  static SessionDetailsAttributeInternal()
  {
    Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetailsAttributeInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr);
    SessionDetailsAttributeInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SessionDetailsAttributeInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, nameof (m_Data));
    SessionDetailsAttributeInternal.NativeFieldInfoPtr_m_AdvertisementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, nameof (m_AdvertisementType));
    SessionDetailsAttributeInternal.NativeMethodInfoPtr_get_Data_Public_get_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, 100665744 /*0x06000990*/);
    SessionDetailsAttributeInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, 100665745);
    SessionDetailsAttributeInternal.NativeMethodInfoPtr_get_AdvertisementType_Public_get_SessionAttributeAdvertisementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, 100665746);
    SessionDetailsAttributeInternal.NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, 100665747);
    SessionDetailsAttributeInternal.NativeMethodInfoPtr_Set_Public_Void_SessionDetailsAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, 100665748);
    SessionDetailsAttributeInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, 100665749);
    SessionDetailsAttributeInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, 100665750);
  }

  public unsafe AttributeData Data
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378335, XrefRangeEnd = 378341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttributeInternal.NativeMethodInfoPtr_get_Data_Public_get_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (AttributeData) null : Il2CppObjectPool.Get<AttributeData>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 378347, RefRangeEnd = 378349, XrefRangeStart = 378341, XrefRangeEnd = 378347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttributeInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe SessionAttributeAdvertisementType AdvertisementType
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttributeInternal.NativeMethodInfoPtr_get_AdvertisementType_Public_get_SessionAttributeAdvertisementType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SessionAttributeAdvertisementType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttributeInternal.NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378349, XrefRangeEnd = 378350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SessionDetailsAttribute other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttributeInternal.NativeMethodInfoPtr_Set_Public_Void_SessionDetailsAttribute_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378350, XrefRangeEnd = 378353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttributeInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378353, XrefRangeEnd = 378357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttributeInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionDetailsAttributeInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
