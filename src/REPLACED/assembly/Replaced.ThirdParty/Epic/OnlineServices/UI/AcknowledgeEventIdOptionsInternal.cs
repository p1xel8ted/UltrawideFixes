// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.AcknowledgeEventIdOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI;

[StructLayout(LayoutKind.Explicit)]
public struct AcknowledgeEventIdOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UiEventId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Result;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Result_Public_set_Void_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AcknowledgeEventIdOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public ulong m_UiEventId;
  [FieldOffset(16 /*0x10*/)]
  public Result m_Result;

  static AcknowledgeEventIdOptionsInternal()
  {
    Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.UI", nameof (AcknowledgeEventIdOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr);
    AcknowledgeEventIdOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    AcknowledgeEventIdOptionsInternal.NativeFieldInfoPtr_m_UiEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, nameof (m_UiEventId));
    AcknowledgeEventIdOptionsInternal.NativeFieldInfoPtr_m_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, nameof (m_Result));
    AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, 100664698);
    AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_set_Result_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, 100664699);
    AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_AcknowledgeEventIdOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, 100664700);
    AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, 100664701);
    AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, 100664702);
  }

  public unsafe ulong UiEventId
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_set_UiEventId_Public_set_Void_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Result Result
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_set_Result_Public_set_Void_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(AcknowledgeEventIdOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_AcknowledgeEventIdOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373474, XrefRangeEnd = 373476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AcknowledgeEventIdOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AcknowledgeEventIdOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
