// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetRelayControlOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

[StructLayout(LayoutKind.Explicit)]
public struct SetRelayControlOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RelayControl;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RelayControl_Public_set_Void_RelayControl_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SetRelayControlOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public RelayControl m_RelayControl;

  static SetRelayControlOptionsInternal()
  {
    Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (SetRelayControlOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr);
    SetRelayControlOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SetRelayControlOptionsInternal.NativeFieldInfoPtr_m_RelayControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, nameof (m_RelayControl));
    SetRelayControlOptionsInternal.NativeMethodInfoPtr_set_RelayControl_Public_set_Void_RelayControl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, 100668531);
    SetRelayControlOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetRelayControlOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, 100668532);
    SetRelayControlOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, 100668533);
    SetRelayControlOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, 100668534);
  }

  public unsafe RelayControl RelayControl
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetRelayControlOptionsInternal.NativeMethodInfoPtr_set_RelayControl_Public_set_Void_RelayControl_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(SetRelayControlOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetRelayControlOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetRelayControlOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387222, XrefRangeEnd = 387224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetRelayControlOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetRelayControlOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetRelayControlOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
