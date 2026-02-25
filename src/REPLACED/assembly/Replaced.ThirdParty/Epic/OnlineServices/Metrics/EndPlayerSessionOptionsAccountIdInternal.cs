// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.EndPlayerSessionOptionsAccountIdInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics;

[StructLayout(LayoutKind.Explicit)]
public struct EndPlayerSessionOptionsAccountIdInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Epic;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_External;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_External_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_External_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_EndPlayerSessionOptionsAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public MetricsAccountIdType m_AccountIdType;
  [FieldOffset(4)]
  public System.IntPtr m_Epic;
  [FieldOffset(4)]
  public System.IntPtr m_External;

  static EndPlayerSessionOptionsAccountIdInternal()
  {
    Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Metrics", nameof (EndPlayerSessionOptionsAccountIdInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr);
    EndPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_AccountIdType));
    EndPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_Epic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_Epic));
    EndPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_External = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_External));
    EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668804);
    EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668805);
    EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_External_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668806);
    EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_External_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668807);
    EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Void_EndPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668808);
    EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668809);
    EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668810);
  }

  public unsafe EpicAccountId Epic
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388231, XrefRangeEnd = 388237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 388246, RefRangeEnd = 388247, XrefRangeStart = 388237, XrefRangeEnd = 388246, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string External
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388247, XrefRangeEnd = 388253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_External_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 388262, RefRangeEnd = 388263, XrefRangeStart = 388253, XrefRangeEnd = 388262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_External_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 388277, RefRangeEnd = 388278, XrefRangeStart = 388263, XrefRangeEnd = 388277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(EndPlayerSessionOptionsAccountId other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Void_EndPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388278, XrefRangeEnd = 388281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388281, XrefRangeEnd = 388288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
