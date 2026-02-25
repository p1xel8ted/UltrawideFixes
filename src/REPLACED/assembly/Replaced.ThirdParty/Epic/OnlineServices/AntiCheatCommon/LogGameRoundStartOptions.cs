// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogGameRoundStartOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

public class LogGameRoundStartOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__SessionIdentifier_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__LevelName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ModeName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RoundTimeSeconds_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SessionIdentifier_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LevelName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LevelName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ModeName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ModeName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RoundTimeSeconds_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LogGameRoundStartOptions()
  {
    Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogGameRoundStartOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr);
    LogGameRoundStartOptions.NativeFieldInfoPtr__SessionIdentifier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, "<SessionIdentifier>k__BackingField");
    LogGameRoundStartOptions.NativeFieldInfoPtr__LevelName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, "<LevelName>k__BackingField");
    LogGameRoundStartOptions.NativeFieldInfoPtr__ModeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, "<ModeName>k__BackingField");
    LogGameRoundStartOptions.NativeFieldInfoPtr__RoundTimeSeconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, "<RoundTimeSeconds>k__BackingField");
    LogGameRoundStartOptions.NativeMethodInfoPtr_get_SessionIdentifier_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672689);
    LogGameRoundStartOptions.NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672690);
    LogGameRoundStartOptions.NativeMethodInfoPtr_get_LevelName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672691);
    LogGameRoundStartOptions.NativeMethodInfoPtr_set_LevelName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672692);
    LogGameRoundStartOptions.NativeMethodInfoPtr_get_ModeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672693);
    LogGameRoundStartOptions.NativeMethodInfoPtr_set_ModeName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672694);
    LogGameRoundStartOptions.NativeMethodInfoPtr_get_RoundTimeSeconds_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672695);
    LogGameRoundStartOptions.NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672696);
    LogGameRoundStartOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr, 100672697);
  }

  public unsafe string SessionIdentifier
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr_get_SessionIdentifier_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr_set_SessionIdentifier_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string LevelName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr_get_LevelName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr_set_LevelName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ModeName
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr_get_ModeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr_set_ModeName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint RoundTimeSeconds
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr_get_RoundTimeSeconds_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr_set_RoundTimeSeconds_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LogGameRoundStartOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogGameRoundStartOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogGameRoundStartOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _SessionIdentifier_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogGameRoundStartOptions.NativeFieldInfoPtr__SessionIdentifier_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogGameRoundStartOptions.NativeFieldInfoPtr__SessionIdentifier_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _LevelName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogGameRoundStartOptions.NativeFieldInfoPtr__LevelName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogGameRoundStartOptions.NativeFieldInfoPtr__LevelName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _ModeName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogGameRoundStartOptions.NativeFieldInfoPtr__ModeName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogGameRoundStartOptions.NativeFieldInfoPtr__ModeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe uint _RoundTimeSeconds_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogGameRoundStartOptions.NativeFieldInfoPtr__RoundTimeSeconds_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogGameRoundStartOptions.NativeFieldInfoPtr__RoundTimeSeconds_k__BackingField)) = value;
    }
  }
}
