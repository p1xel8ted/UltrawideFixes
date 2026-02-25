// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.BeginPlayerSessionOptionsAccountIdInternal
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
public struct BeginPlayerSessionOptionsAccountIdInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Epic;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_External;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_External_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_External_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_BeginPlayerSessionOptionsAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public MetricsAccountIdType m_AccountIdType;
  [FieldOffset(4)]
  public System.IntPtr m_Epic;
  [FieldOffset(4)]
  public System.IntPtr m_External;

  static BeginPlayerSessionOptionsAccountIdInternal()
  {
    Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Metrics", nameof (BeginPlayerSessionOptionsAccountIdInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr);
    BeginPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_AccountIdType));
    BeginPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_Epic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_Epic));
    BeginPlayerSessionOptionsAccountIdInternal.NativeFieldInfoPtr_m_External = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, nameof (m_External));
    BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668779);
    BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668780);
    BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_External_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668781);
    BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_External_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668782);
    BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Void_BeginPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668783);
    BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668784);
    BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, 100668785);
  }

  public unsafe EpicAccountId Epic
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388072, XrefRangeEnd = 388078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 388087, RefRangeEnd = 388088, XrefRangeStart = 388078, XrefRangeEnd = 388087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string External
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388088, XrefRangeEnd = 388094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_get_External_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 388103, RefRangeEnd = 388104, XrefRangeStart = 388094, XrefRangeEnd = 388103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_set_External_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 388118, RefRangeEnd = 388119, XrefRangeStart = 388104, XrefRangeEnd = 388118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(BeginPlayerSessionOptionsAccountId other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Void_BeginPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388119, XrefRangeEnd = 388122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388122, XrefRangeEnd = 388129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeginPlayerSessionOptionsAccountIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BeginPlayerSessionOptionsAccountIdInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
