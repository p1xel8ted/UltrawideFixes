// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.InstallModOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Mods;

public class InstallModOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__LocalUserId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Mod_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RemoveAfterExit_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Mod_Public_get_ModIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoveAfterExit_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoveAfterExit_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InstallModOptions()
  {
    Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Mods", nameof (InstallModOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr);
    InstallModOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, "<LocalUserId>k__BackingField");
    InstallModOptions.NativeFieldInfoPtr__Mod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, "<Mod>k__BackingField");
    InstallModOptions.NativeFieldInfoPtr__RemoveAfterExit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, "<RemoveAfterExit>k__BackingField");
    InstallModOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, 100668599);
    InstallModOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, 100668600);
    InstallModOptions.NativeMethodInfoPtr_get_Mod_Public_get_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, 100668601);
    InstallModOptions.NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, 100668602);
    InstallModOptions.NativeMethodInfoPtr_get_RemoveAfterExit_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, 100668603);
    InstallModOptions.NativeMethodInfoPtr_set_RemoveAfterExit_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, 100668604);
    InstallModOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr, 100668605);
  }

  public unsafe EpicAccountId LocalUserId
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InstallModOptions.NativeMethodInfoPtr_get_LocalUserId_Public_get_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InstallModOptions.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_EpicAccountId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ModIdentifier Mod
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InstallModOptions.NativeMethodInfoPtr_get_Mod_Public_get_ModIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ModIdentifier) null : Il2CppObjectPool.Get<ModIdentifier>(num3);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InstallModOptions.NativeMethodInfoPtr_set_Mod_Public_set_Void_ModIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool RemoveAfterExit
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InstallModOptions.NativeMethodInfoPtr_get_RemoveAfterExit_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InstallModOptions.NativeMethodInfoPtr_set_RemoveAfterExit_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InstallModOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstallModOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InstallModOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EpicAccountId _LocalUserId_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstallModOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField));
      return num == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InstallModOptions.NativeFieldInfoPtr__LocalUserId_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ModIdentifier _Mod_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstallModOptions.NativeFieldInfoPtr__Mod_k__BackingField));
      return num == System.IntPtr.Zero ? (ModIdentifier) null : Il2CppObjectPool.Get<ModIdentifier>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InstallModOptions.NativeFieldInfoPtr__Mod_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _RemoveAfterExit_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstallModOptions.NativeFieldInfoPtr__RemoveAfterExit_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstallModOptions.NativeFieldInfoPtr__RemoveAfterExit_k__BackingField)) = value;
    }
  }
}
