// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModificationSetDataOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence;

public class PresenceModificationSetDataOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Records_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PresenceModificationSetDataOptions()
  {
    Il2CppClassPointerStore<PresenceModificationSetDataOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (PresenceModificationSetDataOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModificationSetDataOptions>.NativeClassPtr);
    PresenceModificationSetDataOptions.NativeFieldInfoPtr__Records_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationSetDataOptions>.NativeClassPtr, "<Records>k__BackingField");
    PresenceModificationSetDataOptions.NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetDataOptions>.NativeClassPtr, 100667429);
    PresenceModificationSetDataOptions.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetDataOptions>.NativeClassPtr, 100667430);
    PresenceModificationSetDataOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationSetDataOptions>.NativeClassPtr, 100667431);
  }

  public unsafe Il2CppReferenceArray<DataRecord> Records
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetDataOptions.NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<DataRecord>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<DataRecord>>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetDataOptions.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PresenceModificationSetDataOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresenceModificationSetDataOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PresenceModificationSetDataOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<DataRecord> _Records_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PresenceModificationSetDataOptions.NativeFieldInfoPtr__Records_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<DataRecord>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<DataRecord>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PresenceModificationSetDataOptions.NativeFieldInfoPtr__Records_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
