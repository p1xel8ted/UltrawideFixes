// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.OnDisplaySettingsUpdatedCallbackInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI;

[StructLayout(LayoutKind.Explicit)]
public struct OnDisplaySettingsUpdatedCallbackInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsVisible;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IsExclusiveInput;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsExclusiveInput_Public_get_Boolean_0;
  [FieldOffset(0)]
  public System.IntPtr m_ClientData;
  [FieldOffset(8)]
  public int m_IsVisible;
  [FieldOffset(12)]
  public int m_IsExclusiveInput;

  static OnDisplaySettingsUpdatedCallbackInfoInternal()
  {
    Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.UI", nameof (OnDisplaySettingsUpdatedCallbackInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr);
    OnDisplaySettingsUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
    OnDisplaySettingsUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_IsVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_IsVisible));
    OnDisplaySettingsUpdatedCallbackInfoInternal.NativeFieldInfoPtr_m_IsExclusiveInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr, nameof (m_IsExclusiveInput));
    OnDisplaySettingsUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr, 100664757);
    OnDisplaySettingsUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr, 100664758);
    OnDisplaySettingsUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr, 100664759);
    OnDisplaySettingsUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_IsExclusiveInput_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr, 100664760);
  }

  public unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 373635, RefRangeEnd = 373637, XrefRangeStart = 373626, XrefRangeEnd = 373635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsVisible
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373637, XrefRangeEnd = 373643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_IsVisible_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsExclusiveInput
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 373643, XrefRangeEnd = 373649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnDisplaySettingsUpdatedCallbackInfoInternal.NativeMethodInfoPtr_get_IsExclusiveInput_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnDisplaySettingsUpdatedCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
