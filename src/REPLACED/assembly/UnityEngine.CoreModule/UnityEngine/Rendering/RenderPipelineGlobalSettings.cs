// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderPipelineGlobalSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public class RenderPipelineGlobalSettings(System.IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__settingsMap_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsList_Protected_Virtual_New_get_List_1_IRenderPipelineGraphicsSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsMap_Private_get_Dictionary_2_Type_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RecreateSettingsMap_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGet_FamOrAssem_Boolean_Type_byref_IRenderPipelineGraphicsSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TryGetFirstSettingsImplementingInterface_FamOrAssem_Boolean_byref_TSettingsInterfaceType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSettingsImplementingInterface_FamOrAssem_Boolean_byref_List_1_TSettingsInterfaceType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Contains_FamOrAssem_Boolean_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static RenderPipelineGlobalSettings()
  {
    Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderPipelineGlobalSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr);
    RenderPipelineGlobalSettings.NativeFieldInfoPtr__settingsMap_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, "<settingsMap>k__BackingField");
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_get_settingsList_Protected_Virtual_New_get_List_1_IRenderPipelineGraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670460);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_get_settingsMap_Private_get_Dictionary_2_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670461);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_RecreateSettingsMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670462);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_TryGet_FamOrAssem_Boolean_Type_byref_IRenderPipelineGraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670463);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_TryGetFirstSettingsImplementingInterface_FamOrAssem_Boolean_byref_TSettingsInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670464 /*0x06001C00*/);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_GetSettingsImplementingInterface_FamOrAssem_Boolean_byref_List_1_TSettingsInterfaceType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670465);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_Contains_FamOrAssem_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670466);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670467);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670468);
    RenderPipelineGlobalSettings.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr, 100670469);
  }

  public virtual unsafe List<IRenderPipelineGraphicsSettings> settingsList
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487870, XrefRangeEnd = 487901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineGlobalSettings.NativeMethodInfoPtr_get_settingsList_Protected_Virtual_New_get_List_1_IRenderPipelineGraphicsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<IRenderPipelineGraphicsSettings>) null : Il2CppObjectPool.Get<List<IRenderPipelineGraphicsSettings>>(num3);
    }
  }

  public unsafe Dictionary<Il2CppSystem.Type, int> settingsMap
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.NativeMethodInfoPtr_get_settingsMap_Private_get_Dictionary_2_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, int>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, int>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487901, XrefRangeEnd = 487913, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RecreateSettingsMap()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.NativeMethodInfoPtr_RecreateSettingsMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487919, RefRangeEnd = 487921, XrefRangeStart = 487913, XrefRangeEnd = 487919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGet(Il2CppSystem.Type type, out IRenderPipelineGraphicsSettings settings)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.NativeMethodInfoPtr_TryGet_FamOrAssem_Boolean_Type_byref_IRenderPipelineGraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref IRenderPipelineGraphicsSettings local = ref settings;
    System.IntPtr pointer = zero;
    IRenderPipelineGraphicsSettings graphicsSettings = pointer == System.IntPtr.Zero ? (IRenderPipelineGraphicsSettings) null : new IRenderPipelineGraphicsSettings(pointer);
    local = graphicsSettings;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487921, XrefRangeEnd = 487930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool TryGetFirstSettingsImplementingInterface<TSettingsInterfaceType>(
    out TSettingsInterfaceType settings)
    where TSettingsInterfaceType : class
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero;
    // ISSUE: variable of a reference type
    TSettingsInterfaceType& local1;
    if (!typeof (TSettingsInterfaceType).IsValueType)
    {
      zero = System.IntPtr.Zero;
      local1 = ref (*(TSettingsInterfaceType*) &zero);
    }
    else
      local1 = ref settings;
    *numPtr2 = (System.IntPtr) ref local1;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.MethodInfoStoreGeneric_TryGetFirstSettingsImplementingInterface_FamOrAssem_Boolean_byref_TSettingsInterfaceType_0<TSettingsInterfaceType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    if (!typeof (TSettingsInterfaceType).IsValueType)
    {
      ref TSettingsInterfaceType local2 = ref settings;
      System.IntPtr num3 = zero;
      // ISSUE: variable of the null type
      __Null valueGeneric = num3 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<TSettingsInterfaceType>(num3, false, false);
      local2 = (TSettingsInterfaceType) valueGeneric;
    }
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487930, XrefRangeEnd = 487942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetSettingsImplementingInterface<TSettingsInterfaceType>(
    out List<TSettingsInterfaceType> settings)
    where TSettingsInterfaceType : class
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
    System.IntPtr* numPtr2 = numPtr1;
    System.IntPtr zero = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero;
    *numPtr2 = (System.IntPtr) numPtr3;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.MethodInfoStoreGeneric_GetSettingsImplementingInterface_FamOrAssem_Boolean_byref_List_1_TSettingsInterfaceType_0<TSettingsInterfaceType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    ref List<TSettingsInterfaceType> local = ref settings;
    System.IntPtr pointer = zero;
    List<TSettingsInterfaceType> list = pointer == System.IntPtr.Zero ? (List<TSettingsInterfaceType>) null : new List<TSettingsInterfaceType>(pointer);
    local = list;
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487942, XrefRangeEnd = 487943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Contains(Il2CppSystem.Type type)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.NativeMethodInfoPtr_Contains_FamOrAssem_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineGlobalSettings.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RenderPipelineGlobalSettings.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 487950, RefRangeEnd = 487951, XrefRangeStart = 487943, XrefRangeEnd = 487950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderPipelineGlobalSettings()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineGlobalSettings.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Dictionary<Il2CppSystem.Type, int> _settingsMap_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderPipelineGlobalSettings.NativeFieldInfoPtr__settingsMap_k__BackingField));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Type, int>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Type, int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderPipelineGlobalSettings.NativeFieldInfoPtr__settingsMap_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_TryGetFirstSettingsImplementingInterface_FamOrAssem_Boolean_byref_TSettingsInterfaceType_0<TSettingsInterfaceType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipelineGlobalSettings.NativeMethodInfoPtr_TryGetFirstSettingsImplementingInterface_FamOrAssem_Boolean_byref_TSettingsInterfaceType_0, Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSettingsInterfaceType>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetSettingsImplementingInterface_FamOrAssem_Boolean_byref_List_1_TSettingsInterfaceType_0<TSettingsInterfaceType>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipelineGlobalSettings.NativeMethodInfoPtr_GetSettingsImplementingInterface_FamOrAssem_Boolean_byref_List_1_TSettingsInterfaceType_0, Il2CppClassPointerStore<RenderPipelineGlobalSettings>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSettingsInterfaceType>.NativeClassPtr))
    }))));
  }
}
