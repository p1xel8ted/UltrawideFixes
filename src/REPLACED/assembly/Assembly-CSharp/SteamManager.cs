// Decompiled with JetBrains decompiler
// Type: SteamManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using Steamworks;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class SteamManager(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_s_EverInitialized;
  private static readonly IntPtr NativeFieldInfoPtr_s_instance;
  private static readonly IntPtr NativeFieldInfoPtr_m_bInitialized;
  private static readonly IntPtr NativeFieldInfoPtr_m_SteamAPIWarningMessageHook;
  private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Protected_Static_get_SteamManager_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SteamAPIDebugTextHook_Protected_Static_Void_Int32_StringBuilder_0;
  private static readonly IntPtr NativeMethodInfoPtr_InitOnPlayMode_Private_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SteamManager()
  {
    Il2CppClassPointerStore<SteamManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SteamManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamManager>.NativeClassPtr);
    SteamManager.NativeFieldInfoPtr_s_EverInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, nameof (s_EverInitialized));
    SteamManager.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, nameof (s_instance));
    SteamManager.NativeFieldInfoPtr_m_bInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, nameof (m_bInitialized));
    SteamManager.NativeFieldInfoPtr_m_SteamAPIWarningMessageHook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, nameof (m_SteamAPIWarningMessageHook));
    SteamManager.NativeMethodInfoPtr_get_Instance_Protected_Static_get_SteamManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663440 /*0x06000090*/);
    SteamManager.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663441 /*0x06000091*/);
    SteamManager.NativeMethodInfoPtr_SteamAPIDebugTextHook_Protected_Static_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663442 /*0x06000092*/);
    SteamManager.NativeMethodInfoPtr_InitOnPlayMode_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663443 /*0x06000093*/);
    SteamManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663444 /*0x06000094*/);
    SteamManager.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663445 /*0x06000095*/);
    SteamManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663446 /*0x06000096*/);
    SteamManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663447 /*0x06000097*/);
    SteamManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamManager>.NativeClassPtr, 100663448 /*0x06000098*/);
  }

  public static unsafe SteamManager Instance
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16563, XrefRangeEnd = 16573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_get_Instance_Protected_Static_get_SteamManager_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (SteamManager) null : Il2CppObjectPool.Get<SteamManager>(num3);
    }
  }

  public static unsafe bool Initialized
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16590, RefRangeEnd = 16591, XrefRangeStart = 16573, XrefRangeEnd = 16590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_get_Initialized_Public_Static_get_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16591, XrefRangeEnd = 16595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &nSeverity;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) pchDebugText);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_SteamAPIDebugTextHook_Protected_Static_Void_Int32_StringBuilder_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16595, XrefRangeEnd = 16598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void InitOnPlayMode()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr_InitOnPlayMode_Private_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16598, XrefRangeEnd = 16629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamManager.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16629, XrefRangeEnd = 16643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamManager.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16643, XrefRangeEnd = 16651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16651, XrefRangeEnd = 16652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SteamManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SteamManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool s_EverInitialized
  {
    get
    {
      bool sEverInitialized;
      IL2CPP.il2cpp_field_static_get_value(SteamManager.NativeFieldInfoPtr_s_EverInitialized, (void*) &sEverInitialized);
      return sEverInitialized;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SteamManager.NativeFieldInfoPtr_s_EverInitialized, (void*) &value);
    }
  }

  public static unsafe SteamManager s_instance
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(SteamManager.NativeFieldInfoPtr_s_instance, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (SteamManager) null : Il2CppObjectPool.Get<SteamManager>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SteamManager.NativeFieldInfoPtr_s_instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool m_bInitialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_bInitialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_bInitialized)) = value;
    }
  }

  public unsafe SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_SteamAPIWarningMessageHook));
      return num == IntPtr.Zero ? (SteamAPIWarningMessageHook_t) null : Il2CppObjectPool.Get<SteamAPIWarningMessageHook_t>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamManager.NativeFieldInfoPtr_m_SteamAPIWarningMessageHook), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
