// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.Events.BossHealthStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation.Events;

public sealed class BossHealthStatus : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_HealthController;
  private static readonly System.IntPtr NativeFieldInfoPtr_Active;
  private static readonly System.IntPtr NativeFieldInfoPtr_Id;
  private static readonly System.IntPtr NativeFieldInfoPtr_Event;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_CharacterHealthController_Boolean_String_StatusEvent_0;

  static BossHealthStatus()
  {
    Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation.Events", nameof (BossHealthStatus));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr);
    BossHealthStatus.NativeFieldInfoPtr_HealthController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr, nameof (HealthController));
    BossHealthStatus.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr, nameof (Active));
    BossHealthStatus.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr, nameof (Id));
    BossHealthStatus.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr, nameof (Event));
    BossHealthStatus.NativeMethodInfoPtr__ctor_Public_Void_CharacterHealthController_Boolean_String_StatusEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr, 100671463);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 94250, RefRangeEnd = 94255, XrefRangeStart = 94250, XrefRangeEnd = 94250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BossHealthStatus(
    CharacterHealthController health,
    bool act,
    string id,
    BossHealthStatus.StatusEvent ev = BossHealthStatus.StatusEvent.Change)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) health);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &act;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &ev;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BossHealthStatus.NativeMethodInfoPtr__ctor_Public_Void_CharacterHealthController_Boolean_String_StatusEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public BossHealthStatus(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public BossHealthStatus()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BossHealthStatus>.NativeClassPtr))
  {
  }

  public unsafe CharacterHealthController HealthController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossHealthStatus.NativeFieldInfoPtr_HealthController));
      return num == System.IntPtr.Zero ? (CharacterHealthController) null : Il2CppObjectPool.Get<CharacterHealthController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossHealthStatus.NativeFieldInfoPtr_HealthController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool Active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossHealthStatus.NativeFieldInfoPtr_Active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossHealthStatus.NativeFieldInfoPtr_Active)) = value;
    }
  }

  public unsafe string Id
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossHealthStatus.NativeFieldInfoPtr_Id)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BossHealthStatus.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe BossHealthStatus.StatusEvent Event
  {
    get
    {
      return *(BossHealthStatus.StatusEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossHealthStatus.NativeFieldInfoPtr_Event));
    }
    [param: In] set
    {
      *(BossHealthStatus.StatusEvent*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BossHealthStatus.NativeFieldInfoPtr_Event)) = value;
    }
  }

  public enum StatusEvent
  {
    Change,
    Register,
    Unregister,
  }
}
