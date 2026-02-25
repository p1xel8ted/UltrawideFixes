// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.EndPlayerSessionOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics;

[StructLayout(LayoutKind.Explicit)]
public struct EndPlayerSessionOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountId_Public_set_Void_EndPlayerSessionOptionsAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_EndPlayerSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public EndPlayerSessionOptionsAccountIdInternal m_AccountId;

  static EndPlayerSessionOptionsInternal()
  {
    Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Metrics", nameof (EndPlayerSessionOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr);
    EndPlayerSessionOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    EndPlayerSessionOptionsInternal.NativeFieldInfoPtr_m_AccountId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr, nameof (m_AccountId));
    EndPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_EndPlayerSessionOptionsAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr, 100668789);
    EndPlayerSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_EndPlayerSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr, 100668790);
    EndPlayerSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr, 100668791);
    EndPlayerSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr, 100668792);
  }

  public unsafe EndPlayerSessionOptionsAccountId AccountId
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 388135, RefRangeEnd = 388137, XrefRangeStart = 388129, XrefRangeEnd = 388135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsInternal.NativeMethodInfoPtr_set_AccountId_Public_set_Void_EndPlayerSessionOptionsAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388137, XrefRangeEnd = 388138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(EndPlayerSessionOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_EndPlayerSessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388138, XrefRangeEnd = 388141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 388141, XrefRangeEnd = 388147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndPlayerSessionOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
