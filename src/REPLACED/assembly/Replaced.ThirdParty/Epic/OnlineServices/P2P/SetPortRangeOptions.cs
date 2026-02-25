// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetPortRangeOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

public class SetPortRangeOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Port_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__MaxAdditionalPortsToTry_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Port_Public_get_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxAdditionalPortsToTry_Public_get_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SetPortRangeOptions()
  {
    Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (SetPortRangeOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr);
    SetPortRangeOptions.NativeFieldInfoPtr__Port_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, "<Port>k__BackingField");
    SetPortRangeOptions.NativeFieldInfoPtr__MaxAdditionalPortsToTry_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, "<MaxAdditionalPortsToTry>k__BackingField");
    SetPortRangeOptions.NativeMethodInfoPtr_get_Port_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100668518);
    SetPortRangeOptions.NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100668519);
    SetPortRangeOptions.NativeMethodInfoPtr_get_MaxAdditionalPortsToTry_Public_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100668520);
    SetPortRangeOptions.NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100668521);
    SetPortRangeOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr, 100668522);
  }

  public unsafe ushort Port
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 387216, RefRangeEnd = 387218, XrefRangeStart = 387216, XrefRangeEnd = 387216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr_get_Port_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ushort*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ushort MaxAdditionalPortsToTry
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 387218, RefRangeEnd = 387220, XrefRangeStart = 387218, XrefRangeEnd = 387218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr_get_MaxAdditionalPortsToTry_Public_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ushort*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SetPortRangeOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetPortRangeOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ushort _Port_k__BackingField
  {
    get
    {
      return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPortRangeOptions.NativeFieldInfoPtr__Port_k__BackingField));
    }
    [param: In] set
    {
      *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPortRangeOptions.NativeFieldInfoPtr__Port_k__BackingField)) = value;
    }
  }

  public unsafe ushort _MaxAdditionalPortsToTry_k__BackingField
  {
    get
    {
      return *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPortRangeOptions.NativeFieldInfoPtr__MaxAdditionalPortsToTry_k__BackingField));
    }
    [param: In] set
    {
      *(ushort*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetPortRangeOptions.NativeFieldInfoPtr__MaxAdditionalPortsToTry_k__BackingField)) = value;
    }
  }
}
