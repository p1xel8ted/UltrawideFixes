// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.IUpgradableController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.Quests;
using System;

#nullable disable
namespace SadCatStudios.Character;

public class IUpgradableController(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_ResetUpgrades_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Upgrade_Public_Abstract_Virtual_New_Void_String_UpgradeConfig_0;

  static IUpgradableController()
  {
    Il2CppClassPointerStore<IUpgradableController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (IUpgradableController));
    IUpgradableController.NativeMethodInfoPtr_ResetUpgrades_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpgradableController>.NativeClassPtr, 100675593 /*0x06003009*/);
    IUpgradableController.NativeMethodInfoPtr_Upgrade_Public_Abstract_Virtual_New_Void_String_UpgradeConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUpgradableController>.NativeClassPtr, 100675594 /*0x0600300A*/);
  }

  [CallerCount(0)]
  public virtual unsafe void ResetUpgrades()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IUpgradableController.NativeMethodInfoPtr_ResetUpgrades_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Upgrade(string upgradedValue, UpgradeConfig config)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(upgradedValue);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) config);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IUpgradableController.NativeMethodInfoPtr_Upgrade_Public_Abstract_Virtual_New_Void_String_UpgradeConfig_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
