// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.OnClientActionRequiredCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

[StructLayout(LayoutKind.Explicit)]
public struct OnClientActionRequiredCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionReasonCode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ActionReasonDetailsString;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_String_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public System.IntPtr m_ClientHandle;
  [FieldOffset(16 /*0x10*/)]
  public AntiCheatCommonClientAction m_ClientAction;
  [FieldOffset(20)]
  public AntiCheatCommonClientActionReason m_ActionReasonCode;
  [FieldOffset(24)]
  public System.IntPtr m_ActionReasonDetailsString;

  static OnClientActionRequiredCallbackInfoInternal()
  {
    Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (OnClientActionRequiredCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr);
    OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientHandle));
    OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ClientAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientAction));
    OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ActionReasonCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ActionReasonCode));
    OnClientActionRequiredCallbackInfoInternal.NativeFieldInfoPtr_m_ActionReasonDetailsString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, nameof (m_ActionReasonDetailsString));
    OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100672882);
    OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100672883);
    OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100672884);
    OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100672885);
    OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100672886);
    OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, 100672887);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400791, XrefRangeEnd = 400795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  public virtual unsafe System.IntPtr ClientDataAddress
  {
    [CallerCount(104), CachedScanResults(RefRangeStart = 79568, RefRangeEnd = 79672, XrefRangeStart = 79568, XrefRangeEnd = 79672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe System.IntPtr ClientHandle
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe AntiCheatCommonClientAction ClientAction
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonClientAction*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe AntiCheatCommonClientActionReason ActionReasonCode
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonClientActionReason*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string ActionReasonDetailsString
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400795, XrefRangeEnd = 400799, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfoInternal.NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
