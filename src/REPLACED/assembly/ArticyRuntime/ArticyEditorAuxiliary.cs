// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyEditorAuxiliary
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyEditorAuxiliary(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__AssetDatabaseSaveAssets_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AssetDatabaseAddObjectToAsset_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SetDirty_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__DomainReloadEnabled_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CreateRuntimeSettings_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsAwaitingImport_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AssetDatabaseSaveAssets_Public_get_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AssetDatabaseSaveAssets_Public_set_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AssetDatabaseAddObjectToAsset_Public_get_Action_2_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AssetDatabaseAddObjectToAsset_Public_set_Void_Action_2_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SetDirty_Public_get_Action_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SetDirty_Public_set_Void_Action_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Func_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlaying_Public_set_Void_Func_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DomainReloadEnabled_Public_get_Func_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DomainReloadEnabled_Public_set_Void_Func_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CreateRuntimeSettings_Public_get_Func_1_ArticyRuntimeSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CreateRuntimeSettings_Public_set_Void_Func_1_ArticyRuntimeSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAwaitingImport_Public_get_Func_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsAwaitingImport_Public_set_Void_Func_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyEditorAuxiliary()
  {
    Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyEditorAuxiliary));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr);
    ArticyEditorAuxiliary.NativeFieldInfoPtr__AssetDatabaseSaveAssets_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, "<AssetDatabaseSaveAssets>k__BackingField");
    ArticyEditorAuxiliary.NativeFieldInfoPtr__AssetDatabaseAddObjectToAsset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, "<AssetDatabaseAddObjectToAsset>k__BackingField");
    ArticyEditorAuxiliary.NativeFieldInfoPtr__SetDirty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, "<SetDirty>k__BackingField");
    ArticyEditorAuxiliary.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, "<IsPlaying>k__BackingField");
    ArticyEditorAuxiliary.NativeFieldInfoPtr__DomainReloadEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, "<DomainReloadEnabled>k__BackingField");
    ArticyEditorAuxiliary.NativeFieldInfoPtr__CreateRuntimeSettings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, "<CreateRuntimeSettings>k__BackingField");
    ArticyEditorAuxiliary.NativeFieldInfoPtr__IsAwaitingImport_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, "<IsAwaitingImport>k__BackingField");
    ArticyEditorAuxiliary.NativeMethodInfoPtr_get_AssetDatabaseSaveAssets_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663469 /*0x060000AD*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_set_AssetDatabaseSaveAssets_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663470 /*0x060000AE*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_get_AssetDatabaseAddObjectToAsset_Public_get_Action_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663471 /*0x060000AF*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_set_AssetDatabaseAddObjectToAsset_Public_set_Void_Action_2_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663472 /*0x060000B0*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_get_SetDirty_Public_get_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663473 /*0x060000B1*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_set_SetDirty_Public_set_Void_Action_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663474 /*0x060000B2*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_get_IsPlaying_Public_get_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663475 /*0x060000B3*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_set_IsPlaying_Public_set_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663476 /*0x060000B4*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_get_DomainReloadEnabled_Public_get_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663477 /*0x060000B5*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_set_DomainReloadEnabled_Public_set_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663478 /*0x060000B6*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_get_CreateRuntimeSettings_Public_get_Func_1_ArticyRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663479 /*0x060000B7*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_set_CreateRuntimeSettings_Public_set_Void_Func_1_ArticyRuntimeSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663480 /*0x060000B8*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_get_IsAwaitingImport_Public_get_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663481 /*0x060000B9*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr_set_IsAwaitingImport_Public_set_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663482 /*0x060000BA*/);
    ArticyEditorAuxiliary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr, 100663483 /*0x060000BB*/);
  }

  public unsafe Il2CppSystem.Action AssetDatabaseSaveAssets
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_get_AssetDatabaseSaveAssets_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_set_AssetDatabaseSaveAssets_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Action<UnityEngine.Object, string> AssetDatabaseAddObjectToAsset
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_get_AssetDatabaseAddObjectToAsset_Public_get_Action_2_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<UnityEngine.Object, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<UnityEngine.Object, string>>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_set_AssetDatabaseAddObjectToAsset_Public_set_Void_Action_2_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Action<UnityEngine.Object> SetDirty
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_get_SetDirty_Public_get_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<UnityEngine.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<UnityEngine.Object>>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_set_SetDirty_Public_set_Void_Action_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Func<bool> IsPlaying
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_get_IsPlaying_Public_get_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_set_IsPlaying_Public_set_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Func<bool> DomainReloadEnabled
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_get_DomainReloadEnabled_Public_get_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_set_DomainReloadEnabled_Public_set_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Func<ArticyRuntimeSettings> CreateRuntimeSettings
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_get_CreateRuntimeSettings_Public_get_Func_1_ArticyRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyRuntimeSettings>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyRuntimeSettings>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_set_CreateRuntimeSettings_Public_set_Void_Func_1_ArticyRuntimeSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Func<bool> IsAwaitingImport
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_get_IsAwaitingImport_Public_get_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr_set_IsAwaitingImport_Public_set_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyEditorAuxiliary()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyEditorAuxiliary>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyEditorAuxiliary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Action _AssetDatabaseSaveAssets_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__AssetDatabaseSaveAssets_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__AssetDatabaseSaveAssets_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<UnityEngine.Object, string> _AssetDatabaseAddObjectToAsset_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__AssetDatabaseAddObjectToAsset_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<UnityEngine.Object, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<UnityEngine.Object, string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__AssetDatabaseAddObjectToAsset_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action<UnityEngine.Object> _SetDirty_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__SetDirty_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action<UnityEngine.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<UnityEngine.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__SetDirty_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Func<bool> _IsPlaying_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__IsPlaying_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__IsPlaying_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Func<bool> _DomainReloadEnabled_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__DomainReloadEnabled_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__DomainReloadEnabled_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Func<ArticyRuntimeSettings> _CreateRuntimeSettings_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__CreateRuntimeSettings_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Func<ArticyRuntimeSettings>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<ArticyRuntimeSettings>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__CreateRuntimeSettings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Func<bool> _IsAwaitingImport_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__IsAwaitingImport_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyEditorAuxiliary.NativeFieldInfoPtr__IsAwaitingImport_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
