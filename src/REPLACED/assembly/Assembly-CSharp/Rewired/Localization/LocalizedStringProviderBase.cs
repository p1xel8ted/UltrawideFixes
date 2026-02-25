// Decompiled with JetBrains decompiler
// Type: Rewired.Localization.LocalizedStringProviderBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Localization;

public class LocalizedStringProviderBase(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__prefetch;
  private static readonly IntPtr NativeMethodInfoPtr_get_prefetch_Public_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_prefetch_Public_Virtual_New_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_initialized_Protected_Abstract_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_TrySetLocalizedStringProvider_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_TryGetLocalizedString_Protected_Abstract_Virtual_New_Boolean_String_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Rewired_Interfaces_ILocalizedStringProvider_TryGetLocalizedString_Private_Virtual_Final_New_Boolean_String_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static LocalizedStringProviderBase()
  {
    Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Localization", nameof (LocalizedStringProviderBase));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr);
    LocalizedStringProviderBase.NativeFieldInfoPtr__prefetch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, nameof (_prefetch));
    LocalizedStringProviderBase.NativeMethodInfoPtr_get_prefetch_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668481);
    LocalizedStringProviderBase.NativeMethodInfoPtr_set_prefetch_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668482);
    LocalizedStringProviderBase.NativeMethodInfoPtr_get_initialized_Protected_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668483);
    LocalizedStringProviderBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668484);
    LocalizedStringProviderBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668485);
    LocalizedStringProviderBase.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668486);
    LocalizedStringProviderBase.NativeMethodInfoPtr_TrySetLocalizedStringProvider_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668487);
    LocalizedStringProviderBase.NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668488);
    LocalizedStringProviderBase.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668489);
    LocalizedStringProviderBase.NativeMethodInfoPtr_TryGetLocalizedString_Protected_Abstract_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668490);
    LocalizedStringProviderBase.NativeMethodInfoPtr_Rewired_Interfaces_ILocalizedStringProvider_TryGetLocalizedString_Private_Virtual_Final_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668491);
    LocalizedStringProviderBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr, 100668492);
  }

  public virtual unsafe bool prefetch
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_get_prefetch_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68691, XrefRangeEnd = 68709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_set_prefetch_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe bool initialized
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_get_initialized_Protected_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68709, XrefRangeEnd = 68732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDisable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_OnDisable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68732, XrefRangeEnd = 68765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void TrySetLocalizedStringProvider()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_TrySetLocalizedStringProvider_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 68765, XrefRangeEnd = 68783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Reload()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_Reload_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool TryGetLocalizedString(string key, out string result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LocalizedStringProviderBase.NativeMethodInfoPtr_TryGetLocalizedString_Protected_Abstract_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    result = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(0)]
  public virtual unsafe bool Rewired_Interfaces_ILocalizedStringProvider_TryGetLocalizedString(
    string key,
    out string result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[2];
    numPtr1[0] = IL2CPP.ManagedStringToIl2Cpp(key);
    IntPtr num1 = (IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr));
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr2 = &zero;
    *(IntPtr*) num1 = (IntPtr) numPtr2;
    IntPtr num2;
    IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(LocalizedStringProviderBase.NativeMethodInfoPtr_Rewired_Interfaces_ILocalizedStringProvider_TryGetLocalizedString_Private_Virtual_Final_New_Boolean_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    result = IL2CPP.Il2CppStringToManaged(zero);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocalizedStringProviderBase()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStringProviderBase>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocalizedStringProviderBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _prefetch
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringProviderBase.NativeFieldInfoPtr__prefetch));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStringProviderBase.NativeFieldInfoPtr__prefetch)) = value;
    }
  }
}
