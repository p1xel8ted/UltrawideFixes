// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sanctions.PlayerSanction
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sanctions;

public class PlayerSanction(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__TimePlaced_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Action_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TimeExpires_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ReferenceId_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Action_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Action_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReferenceId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PlayerSanctionInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PlayerSanction()
  {
    Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sanctions", nameof (PlayerSanction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr);
    PlayerSanction.NativeFieldInfoPtr__TimePlaced_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, "<TimePlaced>k__BackingField");
    PlayerSanction.NativeFieldInfoPtr__Action_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, "<Action>k__BackingField");
    PlayerSanction.NativeFieldInfoPtr__TimeExpires_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, "<TimeExpires>k__BackingField");
    PlayerSanction.NativeFieldInfoPtr__ReferenceId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, "<ReferenceId>k__BackingField");
    PlayerSanction.NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666162);
    PlayerSanction.NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666163);
    PlayerSanction.NativeMethodInfoPtr_get_Action_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666164);
    PlayerSanction.NativeMethodInfoPtr_set_Action_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666165);
    PlayerSanction.NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666166);
    PlayerSanction.NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666167);
    PlayerSanction.NativeMethodInfoPtr_get_ReferenceId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666168);
    PlayerSanction.NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666169);
    PlayerSanction.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PlayerSanctionInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666170);
    PlayerSanction.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666171);
    PlayerSanction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr, 100666172);
  }

  public unsafe long TimePlaced
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_get_TimePlaced_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_set_TimePlaced_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Action
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_get_Action_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_set_Action_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe long TimeExpires
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_get_TimeExpires_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_set_TimeExpires_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ReferenceId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_get_ReferenceId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_set_ReferenceId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379838, XrefRangeEnd = 379856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<PlayerSanctionInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_PlayerSanctionInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379856, XrefRangeEnd = 379878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerSanction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSanction>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerSanction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe long _TimePlaced_k__BackingField
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSanction.NativeFieldInfoPtr__TimePlaced_k__BackingField));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSanction.NativeFieldInfoPtr__TimePlaced_k__BackingField)) = value;
    }
  }

  public unsafe string _Action_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSanction.NativeFieldInfoPtr__Action_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerSanction.NativeFieldInfoPtr__Action_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe long _TimeExpires_k__BackingField
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSanction.NativeFieldInfoPtr__TimeExpires_k__BackingField));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSanction.NativeFieldInfoPtr__TimeExpires_k__BackingField)) = value;
    }
  }

  public unsafe string _ReferenceId_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerSanction.NativeFieldInfoPtr__ReferenceId_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerSanction.NativeFieldInfoPtr__ReferenceId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
