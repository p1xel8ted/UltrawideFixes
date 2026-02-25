// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.ModsInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Mods;

public sealed class ModsInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CopymodinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_EnumeratemodsApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_InstallmodApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ModIdentifierApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_ModinfoApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UninstallmodApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_UpdatemodApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CopyModInfo_Public_Result_CopyModInfoOptions_byref_ModInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnumerateMods_Public_Void_EnumerateModsOptions_Object_OnEnumerateModsCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InstallMod_Public_Void_InstallModOptions_Object_OnInstallModCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UninstallMod_Public_Void_UninstallModOptions_Object_OnUninstallModCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateMod_Public_Void_UpdateModOptions_Object_OnUpdateModCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnumerateModsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnInstallModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUninstallModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static ModsInterface()
  {
    Il2CppClassPointerStore<ModsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Mods", nameof (ModsInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr);
    ModsInterface.NativeFieldInfoPtr_CopymodinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (CopymodinfoApiLatest));
    ModsInterface.NativeFieldInfoPtr_EnumeratemodsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (EnumeratemodsApiLatest));
    ModsInterface.NativeFieldInfoPtr_InstallmodApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (InstallmodApiLatest));
    ModsInterface.NativeFieldInfoPtr_ModIdentifierApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (ModIdentifierApiLatest));
    ModsInterface.NativeFieldInfoPtr_ModinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (ModinfoApiLatest));
    ModsInterface.NativeFieldInfoPtr_UninstallmodApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (UninstallmodApiLatest));
    ModsInterface.NativeFieldInfoPtr_UpdatemodApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, nameof (UpdatemodApiLatest));
    ModsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668652);
    ModsInterface.NativeMethodInfoPtr_CopyModInfo_Public_Result_CopyModInfoOptions_byref_ModInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668654);
    ModsInterface.NativeMethodInfoPtr_EnumerateMods_Public_Void_EnumerateModsOptions_Object_OnEnumerateModsCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668655);
    ModsInterface.NativeMethodInfoPtr_InstallMod_Public_Void_InstallModOptions_Object_OnInstallModCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668656);
    ModsInterface.NativeMethodInfoPtr_UninstallMod_Public_Void_UninstallModOptions_Object_OnUninstallModCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668657);
    ModsInterface.NativeMethodInfoPtr_UpdateMod_Public_Void_UpdateModOptions_Object_OnUpdateModCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668658);
    ModsInterface.NativeMethodInfoPtr_OnEnumerateModsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668659);
    ModsInterface.NativeMethodInfoPtr_OnInstallModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668660);
    ModsInterface.NativeMethodInfoPtr_OnUninstallModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668661);
    ModsInterface.NativeMethodInfoPtr_OnUpdateModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr, 100668662);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ModsInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModsInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387623, XrefRangeEnd = 387635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result CopyModInfo(CopyModInfoOptions options, out ModInfo outEnumeratedMods)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_CopyModInfo_Public_Result_CopyModInfoOptions_byref_ModInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref ModInfo local = ref outEnumeratedMods;
    System.IntPtr pointer = zero;
    ModInfo modInfo = pointer == System.IntPtr.Zero ? (ModInfo) null : new ModInfo(pointer);
    local = modInfo;
    return *(Result*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387635, XrefRangeEnd = 387654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnumerateMods(
    EnumerateModsOptions options,
    Il2CppSystem.Object clientData,
    OnEnumerateModsCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_EnumerateMods_Public_Void_EnumerateModsOptions_Object_OnEnumerateModsCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387654, XrefRangeEnd = 387673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InstallMod(
    InstallModOptions options,
    Il2CppSystem.Object clientData,
    OnInstallModCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_InstallMod_Public_Void_InstallModOptions_Object_OnInstallModCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387673, XrefRangeEnd = 387692, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UninstallMod(
    UninstallModOptions options,
    Il2CppSystem.Object clientData,
    OnUninstallModCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_UninstallMod_Public_Void_UninstallModOptions_Object_OnUninstallModCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387692, XrefRangeEnd = 387711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateMod(
    UpdateModOptions options,
    Il2CppSystem.Object clientData,
    OnUpdateModCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_UpdateMod_Public_Void_UpdateModOptions_Object_OnUpdateModCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387711, XrefRangeEnd = 387717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnEnumerateModsCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_OnEnumerateModsCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387717, XrefRangeEnd = 387723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnInstallModCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_OnInstallModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387723, XrefRangeEnd = 387729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUninstallModCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_OnUninstallModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387729, XrefRangeEnd = 387735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnUpdateModCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModsInterface.NativeMethodInfoPtr_OnUpdateModCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int CopymodinfoApiLatest
  {
    get
    {
      int copymodinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_CopymodinfoApiLatest, (void*) &copymodinfoApiLatest);
      return copymodinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_CopymodinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int EnumeratemodsApiLatest
  {
    get
    {
      int enumeratemodsApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_EnumeratemodsApiLatest, (void*) &enumeratemodsApiLatest);
      return enumeratemodsApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_EnumeratemodsApiLatest, (void*) &value);
    }
  }

  public static unsafe int InstallmodApiLatest
  {
    get
    {
      int installmodApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_InstallmodApiLatest, (void*) &installmodApiLatest);
      return installmodApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_InstallmodApiLatest, (void*) &value);
    }
  }

  public static unsafe int ModIdentifierApiLatest
  {
    get
    {
      int identifierApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_ModIdentifierApiLatest, (void*) &identifierApiLatest);
      return identifierApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_ModIdentifierApiLatest, (void*) &value);
    }
  }

  public static unsafe int ModinfoApiLatest
  {
    get
    {
      int modinfoApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_ModinfoApiLatest, (void*) &modinfoApiLatest);
      return modinfoApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_ModinfoApiLatest, (void*) &value);
    }
  }

  public static unsafe int UninstallmodApiLatest
  {
    get
    {
      int uninstallmodApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_UninstallmodApiLatest, (void*) &uninstallmodApiLatest);
      return uninstallmodApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_UninstallmodApiLatest, (void*) &value);
    }
  }

  public static unsafe int UpdatemodApiLatest
  {
    get
    {
      int updatemodApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ModsInterface.NativeFieldInfoPtr_UpdatemodApiLatest, (void*) &updatemodApiLatest);
      return updatemodApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ModsInterface.NativeFieldInfoPtr_UpdatemodApiLatest, (void*) &value);
    }
  }
}
