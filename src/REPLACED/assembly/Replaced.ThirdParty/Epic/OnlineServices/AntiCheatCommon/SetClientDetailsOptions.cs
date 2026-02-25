// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.SetClientDetailsOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

public class SetClientDetailsOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientFlags_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientInputMethod_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientFlags_Public_get_AntiCheatCommonClientFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientInputMethod_Public_get_AntiCheatCommonClientInput_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SetClientDetailsOptions()
  {
    Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (SetClientDetailsOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr);
    SetClientDetailsOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, "<ClientHandle>k__BackingField");
    SetClientDetailsOptions.NativeFieldInfoPtr__ClientFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, "<ClientFlags>k__BackingField");
    SetClientDetailsOptions.NativeFieldInfoPtr__ClientInputMethod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, "<ClientInputMethod>k__BackingField");
    SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100672968);
    SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100672969);
    SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientFlags_Public_get_AntiCheatCommonClientFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100672970);
    SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100672971);
    SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientInputMethod_Public_get_AntiCheatCommonClientInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100672972);
    SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100672973);
    SetClientDetailsOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr, 100672974);
  }

  public unsafe System.IntPtr ClientHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientFlags ClientFlags
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientFlags_Public_get_AntiCheatCommonClientFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonClientFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientInput ClientInputMethod
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_get_ClientInputMethod_Public_get_AntiCheatCommonClientInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonClientInput*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SetClientDetailsOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetClientDetailsOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _ClientHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetClientDetailsOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetClientDetailsOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonClientFlags _ClientFlags_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonClientFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetClientDetailsOptions.NativeFieldInfoPtr__ClientFlags_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonClientFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetClientDetailsOptions.NativeFieldInfoPtr__ClientFlags_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonClientInput _ClientInputMethod_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonClientInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetClientDetailsOptions.NativeFieldInfoPtr__ClientInputMethod_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonClientInput*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetClientDetailsOptions.NativeFieldInfoPtr__ClientInputMethod_k__BackingField)) = value;
    }
  }
}
