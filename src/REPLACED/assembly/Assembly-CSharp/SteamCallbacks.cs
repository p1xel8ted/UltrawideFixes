// Decompiled with JetBrains decompiler
// Type: SteamCallbacks
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Steamworks;
using System;
using System.Runtime.InteropServices;

#nullable disable
public class SteamCallbacks(IntPtr pointer) : GlobalSingletonBehaviour<SteamCallbacks>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_onOverlayActivated;
  private static readonly IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnOverlayActivated_Private_Void_GameOverlayActivated_t_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SteamCallbacks()
  {
    Il2CppClassPointerStore<SteamCallbacks>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SteamCallbacks));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamCallbacks>.NativeClassPtr);
    SteamCallbacks.NativeFieldInfoPtr_onOverlayActivated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamCallbacks>.NativeClassPtr, nameof (onOverlayActivated));
    SteamCallbacks.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamCallbacks>.NativeClassPtr, 100663735);
    SteamCallbacks.NativeMethodInfoPtr_OnOverlayActivated_Private_Void_GameOverlayActivated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamCallbacks>.NativeClassPtr, 100663736);
    SteamCallbacks.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamCallbacks>.NativeClassPtr, 100663737);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22426, XrefRangeEnd = 22435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SteamCallbacks.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22435, XrefRangeEnd = 22442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnOverlayActivated(GameOverlayActivated_t e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &e
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SteamCallbacks.NativeMethodInfoPtr_OnOverlayActivated_Private_Void_GameOverlayActivated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22442, XrefRangeEnd = 22445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SteamCallbacks()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamCallbacks>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SteamCallbacks.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Callback<GameOverlayActivated_t> onOverlayActivated
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SteamCallbacks.NativeFieldInfoPtr_onOverlayActivated));
      return num == IntPtr.Zero ? (Callback<GameOverlayActivated_t>) null : Il2CppObjectPool.Get<Callback<GameOverlayActivated_t>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SteamCallbacks.NativeFieldInfoPtr_onOverlayActivated), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
