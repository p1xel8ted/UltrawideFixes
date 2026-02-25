// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.PauseManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD;
using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MessagePipe;
using SadCatStudios.Foundation.Events;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation;

public class PauseManager(System.IntPtr pointer) : LocalSingletonBehaviour<PauseManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_pausedPublisher;
  private static readonly System.IntPtr NativeFieldInfoPtr_masterBankPath;
  private static readonly System.IntPtr NativeFieldInfoPtr_masterBuses;
  private static readonly System.IntPtr NativeFieldInfoPtr_excludedGuids;
  private static readonly System.IntPtr NativeFieldInfoPtr_timescaleBeforePause;
  private static readonly System.IntPtr NativeFieldInfoPtr_Pause;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorLocked_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetBusesPaused_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPause_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUnPause_Private_Void_GameUnpausedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PauseGameIfNeed_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PauseManager()
  {
    Il2CppClassPointerStore<PauseManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (PauseManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PauseManager>.NativeClassPtr);
    PauseManager.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, nameof (eventDisposable));
    PauseManager.NativeFieldInfoPtr_pausedPublisher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, nameof (pausedPublisher));
    PauseManager.NativeFieldInfoPtr_masterBankPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, nameof (masterBankPath));
    PauseManager.NativeFieldInfoPtr_masterBuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, nameof (masterBuses));
    PauseManager.NativeFieldInfoPtr_excludedGuids = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, nameof (excludedGuids));
    PauseManager.NativeFieldInfoPtr_timescaleBeforePause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, nameof (timescaleBeforePause));
    PauseManager.NativeFieldInfoPtr_Pause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, nameof (Pause));
    PauseManager.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671258);
    PauseManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671259);
    PauseManager.NativeMethodInfoPtr_SetCursorLocked_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671260);
    PauseManager.NativeMethodInfoPtr_SetBusesPaused_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671261);
    PauseManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671262);
    PauseManager.NativeMethodInfoPtr_OnPause_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671263);
    PauseManager.NativeMethodInfoPtr_OnUnPause_Private_Void_GameUnpausedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671264);
    PauseManager.NativeMethodInfoPtr_PauseGameIfNeed_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671265);
    PauseManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671266);
    PauseManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PauseManager>.NativeClassPtr, 100671267);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92499, XrefRangeEnd = 92500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnApplicationPause(bool pauseStatus)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pauseStatus
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92500, XrefRangeEnd = 92548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92548, XrefRangeEnd = 92550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetCursorLocked(bool locked)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &locked
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr_SetCursorLocked_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 92556, RefRangeEnd = 92559, XrefRangeStart = 92550, XrefRangeEnd = 92556, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBusesPaused(bool paused)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &paused
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr_SetBusesPaused_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92559, XrefRangeEnd = 92565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PauseManager.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92565, XrefRangeEnd = 92575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnPause()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr_OnPause_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92575, XrefRangeEnd = 92584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnUnPause(GameUnpausedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr_OnUnPause_Private_Void_GameUnpausedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 92604, RefRangeEnd = 92607, XrefRangeStart = 92584, XrefRangeEnd = 92604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void PauseGameIfNeed(bool checkButton)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &checkButton
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr_PauseGameIfNeed_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92607, XrefRangeEnd = 92608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92608, XrefRangeEnd = 92617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PauseManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PauseManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PauseManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe IPublisher<GamePausedEvent> pausedPublisher
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_pausedPublisher));
      return num == System.IntPtr.Zero ? (IPublisher<GamePausedEvent>) null : Il2CppObjectPool.Get<IPublisher<GamePausedEvent>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_pausedPublisher), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string masterBankPath
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_masterBankPath)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_masterBankPath), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppStructArray<Bus> masterBuses
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_masterBuses));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Bus>) null : Il2CppObjectPool.Get<Il2CppStructArray<Bus>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_masterBuses), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<GUID> excludedGuids
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_excludedGuids));
      return num == System.IntPtr.Zero ? (List<GUID>) null : Il2CppObjectPool.Get<List<GUID>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_excludedGuids), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float timescaleBeforePause
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_timescaleBeforePause));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_timescaleBeforePause)) = value;
    }
  }

  public unsafe bool Pause
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_Pause));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PauseManager.NativeFieldInfoPtr_Pause)) = value;
    }
  }
}
