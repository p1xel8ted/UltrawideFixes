// Decompiled with JetBrains decompiler
// Type: Rewired.InputManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Rewired.Utils.Interfaces;
using System;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

#nullable disable
namespace Rewired;

public sealed class InputManager(IntPtr pointer) : InputManager_Base(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ignoreRecompile;
  private static readonly IntPtr NativeMethodInfoPtr_OnInitialized_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDeinitialized_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DetectPlatform_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckRecompile_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetExternalTools_Protected_Virtual_IExternalTools_0;
  private static readonly IntPtr NativeMethodInfoPtr_CheckDeviceName_Private_Boolean_String_String_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_SubscribeEvents_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UnsubscribeEvents_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InputManager()
  {
    Il2CppClassPointerStore<InputManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (InputManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputManager>.NativeClassPtr);
    InputManager.NativeFieldInfoPtr_ignoreRecompile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputManager>.NativeClassPtr, nameof (ignoreRecompile));
    InputManager.NativeMethodInfoPtr_OnInitialized_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668067);
    InputManager.NativeMethodInfoPtr_OnDeinitialized_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668068);
    InputManager.NativeMethodInfoPtr_DetectPlatform_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668069);
    InputManager.NativeMethodInfoPtr_CheckRecompile_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668070);
    InputManager.NativeMethodInfoPtr_GetExternalTools_Protected_Virtual_IExternalTools_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668071);
    InputManager.NativeMethodInfoPtr_CheckDeviceName_Private_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668072);
    InputManager.NativeMethodInfoPtr_SubscribeEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668073);
    InputManager.NativeMethodInfoPtr_UnsubscribeEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668074);
    InputManager.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668075);
    InputManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputManager>.NativeClassPtr, 100668076);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64525, XrefRangeEnd = 64536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnInitialized()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnInitialized_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64536, XrefRangeEnd = 64537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDeinitialized()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnDeinitialized_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64537, XrefRangeEnd = 64539, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DetectPlatform()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_DetectPlatform_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CheckRecompile()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_CheckRecompile_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64539, XrefRangeEnd = 64543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe IExternalTools GetExternalTools()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_GetExternalTools_Protected_Virtual_IExternalTools_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (IExternalTools) null : Il2CppObjectPool.Get<IExternalTools>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64543, XrefRangeEnd = 64547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(searchPattern);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(deviceName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(deviceModel);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_CheckDeviceName_Private_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SubscribeEvents()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_SubscribeEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 64557, RefRangeEnd = 64560, XrefRangeStart = 64547, XrefRangeEnd = 64557, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UnsubscribeEvents()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_UnsubscribeEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64560, XrefRangeEnd = 64561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnSceneLoaded(Scene scene, LoadSceneMode mode)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &scene;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &mode;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr_OnSceneLoaded_Private_Void_Scene_LoadSceneMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64561, XrefRangeEnd = 64562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool ignoreRecompile
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_ignoreRecompile));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputManager.NativeFieldInfoPtr_ignoreRecompile)) = value;
    }
  }
}
