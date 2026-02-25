// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.RegisterEventOptions
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
namespace Epic.OnlineServices.AntiCheatCommon;

public class RegisterEventOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__EventId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__EventName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__EventType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ParamDefs_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EventName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EventName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EventType_Public_get_AntiCheatCommonEventType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamDefs_Public_get_Il2CppReferenceArray_1_RegisterEventParamDef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static RegisterEventOptions()
  {
    Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (RegisterEventOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr);
    RegisterEventOptions.NativeFieldInfoPtr__EventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, "<EventId>k__BackingField");
    RegisterEventOptions.NativeFieldInfoPtr__EventName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, "<EventName>k__BackingField");
    RegisterEventOptions.NativeFieldInfoPtr__EventType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, "<EventType>k__BackingField");
    RegisterEventOptions.NativeFieldInfoPtr__ParamDefs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, "<ParamDefs>k__BackingField");
    RegisterEventOptions.NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672938);
    RegisterEventOptions.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672939);
    RegisterEventOptions.NativeMethodInfoPtr_get_EventName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672940);
    RegisterEventOptions.NativeMethodInfoPtr_set_EventName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672941);
    RegisterEventOptions.NativeMethodInfoPtr_get_EventType_Public_get_AntiCheatCommonEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672942);
    RegisterEventOptions.NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672943);
    RegisterEventOptions.NativeMethodInfoPtr_get_ParamDefs_Public_get_Il2CppReferenceArray_1_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672944);
    RegisterEventOptions.NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672945);
    RegisterEventOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr, 100672946);
  }

  public unsafe uint EventId
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string EventName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_get_EventName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_set_EventName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonEventType EventType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_get_EventType_Public_get_AntiCheatCommonEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonEventType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<RegisterEventParamDef> ParamDefs
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_get_ParamDefs_Public_get_Il2CppReferenceArray_1_RegisterEventParamDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<RegisterEventParamDef>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RegisterEventParamDef>>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RegisterEventOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegisterEventOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterEventOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe uint _EventId_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventId_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventId_k__BackingField)) = value;
    }
  }

  public unsafe string _EventName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe AntiCheatCommonEventType _EventType_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventType_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonEventType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__EventType_k__BackingField)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<RegisterEventParamDef> _ParamDefs_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__ParamDefs_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<RegisterEventParamDef>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RegisterEventParamDef>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RegisterEventOptions.NativeFieldInfoPtr__ParamDefs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
