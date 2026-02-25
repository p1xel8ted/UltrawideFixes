// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyMultiLanguageString
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyMultiLanguageString(System.IntPtr pointer) : ArticyString(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mOverwrittenValues;
  private static readonly System.IntPtr NativeFieldInfoPtr_mLastUsedLanguage;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCachedVOAssettRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCachedUnresolvedValue;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnresolvedValue_Public_Virtual_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UnresolvedValue_Public_Virtual_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOverridden_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocaKey_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_VOAssetRef_Public_get_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadVOAssetAsAudioClip_Public_AudioClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadVOAssetAsAudioClipAsync_Public_Task_1_AudioClip_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseVOAsset_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArticyRef_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyMultiLanguageString_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckLanguageChange_Private_Void_0;

  static ArticyMultiLanguageString()
  {
    Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyMultiLanguageString));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr);
    ArticyMultiLanguageString.NativeFieldInfoPtr_mOverwrittenValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, nameof (mOverwrittenValues));
    ArticyMultiLanguageString.NativeFieldInfoPtr_mLastUsedLanguage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, nameof (mLastUsedLanguage));
    ArticyMultiLanguageString.NativeFieldInfoPtr_mCachedVOAssettRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, nameof (mCachedVOAssettRef));
    ArticyMultiLanguageString.NativeFieldInfoPtr_mCachedUnresolvedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, nameof (mCachedUnresolvedValue));
    ArticyMultiLanguageString.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663602);
    ArticyMultiLanguageString.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663603);
    ArticyMultiLanguageString.NativeMethodInfoPtr_get_UnresolvedValue_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663604);
    ArticyMultiLanguageString.NativeMethodInfoPtr_set_UnresolvedValue_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663605);
    ArticyMultiLanguageString.NativeMethodInfoPtr_get_IsOverridden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663606);
    ArticyMultiLanguageString.NativeMethodInfoPtr_get_LocaKey_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663607);
    ArticyMultiLanguageString.NativeMethodInfoPtr_get_VOAssetRef_Public_get_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663608);
    ArticyMultiLanguageString.NativeMethodInfoPtr_LoadVOAssetAsAudioClip_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663609);
    ArticyMultiLanguageString.NativeMethodInfoPtr_LoadVOAssetAsAudioClipAsync_Public_Task_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663610);
    ArticyMultiLanguageString.NativeMethodInfoPtr_ReleaseVOAsset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663611);
    ArticyMultiLanguageString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663612);
    ArticyMultiLanguageString.NativeMethodInfoPtr__ctor_Public_Void_ArticyRef_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663613);
    ArticyMultiLanguageString.NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyMultiLanguageString_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663614);
    ArticyMultiLanguageString.NativeMethodInfoPtr_CheckLanguageChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, 100663615);
  }

  public override unsafe string Value
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988822, XrefRangeEnd = 988823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyMultiLanguageString.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988823, XrefRangeEnd = 988824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyMultiLanguageString.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe string UnresolvedValue
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988824, XrefRangeEnd = 988830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyMultiLanguageString.NativeMethodInfoPtr_get_UnresolvedValue_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988830, XrefRangeEnd = 988851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyMultiLanguageString.NativeMethodInfoPtr_set_UnresolvedValue_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool IsOverridden
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988851, XrefRangeEnd = 988852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr_get_IsOverridden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe string LocaKey
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr_get_LocaKey_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe ArticyRef VOAssetRef
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 988861, RefRangeEnd = 988864, XrefRangeStart = 988852, XrefRangeEnd = 988861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr_get_VOAssetRef_Public_get_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988864, XrefRangeEnd = 988870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioClip LoadVOAssetAsAudioClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr_LoadVOAssetAsAudioClip_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (AudioClip) null : Il2CppObjectPool.Get<AudioClip>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988870, XrefRangeEnd = 988882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Task<AudioClip> LoadVOAssetAsAudioClipAsync()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr_LoadVOAssetAsAudioClipAsync_Public_Task_1_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task<AudioClip>) null : Il2CppObjectPool.Get<Task<AudioClip>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988882, XrefRangeEnd = 988889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReleaseVOAsset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr_ReleaseVOAsset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyMultiLanguageString()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 988890, RefRangeEnd = 988891, XrefRangeStart = 988889, XrefRangeEnd = 988890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyMultiLanguageString(ArticyRef aOwner, string aPropertyName, string aValue)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOwner);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPropertyName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr__ctor_Public_Void_ArticyRef_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(11)]
  [CachedScanResults(RefRangeStart = 988895, RefRangeEnd = 988906, XrefRangeStart = 988891, XrefRangeEnd = 988895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ArticyMultiLanguageString(string aStr)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aStr)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyMultiLanguageString_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 988919, RefRangeEnd = 988921, XrefRangeStart = 988906, XrefRangeEnd = 988919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckLanguageChange()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString.NativeMethodInfoPtr_CheckLanguageChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Dictionary<ulong, string> mOverwrittenValues
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString.NativeFieldInfoPtr_mOverwrittenValues));
      return num == System.IntPtr.Zero ? (Dictionary<ulong, string>) null : Il2CppObjectPool.Get<Dictionary<ulong, string>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString.NativeFieldInfoPtr_mOverwrittenValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ushort mLastUsedLanguage
  {
    get
    {
      return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString.NativeFieldInfoPtr_mLastUsedLanguage));
    }
    [param: In] set
    {
      *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString.NativeFieldInfoPtr_mLastUsedLanguage)) = value;
    }
  }

  public unsafe ArticyRef mCachedVOAssettRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString.NativeFieldInfoPtr_mCachedVOAssettRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString.NativeFieldInfoPtr_mCachedVOAssettRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mCachedUnresolvedValue
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString.NativeFieldInfoPtr_mCachedUnresolvedValue)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString.NativeFieldInfoPtr_mCachedUnresolvedValue), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  [ObfuscatedName("Articy.Unity.ArticyMultiLanguageString+<LoadVOAssetAsAudioClipAsync>d__13")]
  public sealed class _LoadVOAssetAsAudioClipAsync_d__13 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _LoadVOAssetAsAudioClipAsync_d__13()
    {
      Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyMultiLanguageString>.NativeClassPtr, "<LoadVOAssetAsAudioClipAsync>d__13");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr);
      ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr, "<>1__state");
      ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr, "<>t__builder");
      ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr, "<>4__this");
      ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr, "<>u__1");
      ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr, 100663616 /*0x06000140*/);
      ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr, 100663617);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988788, XrefRangeEnd = 988816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988816, XrefRangeEnd = 988822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _LoadVOAssetAsAudioClipAsync_d__13(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _LoadVOAssetAsAudioClipAsync_d__13()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncTaskMethodBuilder<AudioClip> __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___t__builder);
        return new AsyncTaskMethodBuilder<AudioClip>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AudioClip>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<AudioClip>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ArticyMultiLanguageString __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public TaskAwaiter<AudioClip> __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___u__1);
        return new TaskAwaiter<AudioClip>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter<AudioClip>>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyMultiLanguageString._LoadVOAssetAsAudioClipAsync_d__13.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter<AudioClip>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
