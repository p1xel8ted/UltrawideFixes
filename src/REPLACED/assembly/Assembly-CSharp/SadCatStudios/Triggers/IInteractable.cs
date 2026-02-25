// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.IInteractable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.Character;
using System;

#nullable disable
namespace SadCatStudios.Triggers;

public class IInteractable(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_HasInteracted_Public_Abstract_Virtual_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Interact_Public_Abstract_Virtual_New_Void_CharacterInteractionController_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ZoneInteractionType_Public_Abstract_Virtual_New_get_InteractionIcon_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanBeInteracted_Public_Abstract_Virtual_New_Boolean_CharacterInteractionController_0;

  static IInteractable()
  {
    Il2CppClassPointerStore<IInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (IInteractable));
    IInteractable.NativeMethodInfoPtr_HasInteracted_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100671753);
    IInteractable.NativeMethodInfoPtr_Interact_Public_Abstract_Virtual_New_Void_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100671754);
    IInteractable.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Abstract_Virtual_New_get_InteractionIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100671755);
    IInteractable.NativeMethodInfoPtr_CanBeInteracted_Public_Abstract_Virtual_New_Boolean_CharacterInteractionController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IInteractable>.NativeClassPtr, 100671756);
  }

  [CallerCount(0)]
  public virtual unsafe bool HasInteracted()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IInteractable.NativeMethodInfoPtr_HasInteracted_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void Interact(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IInteractable.NativeMethodInfoPtr_Interact_Public_Abstract_Virtual_New_Void_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe InteractionZone.InteractionIcon ZoneInteractionType
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IInteractable.NativeMethodInfoPtr_get_ZoneInteractionType_Public_Abstract_Virtual_New_get_InteractionIcon_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(InteractionZone.InteractionIcon*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe bool CanBeInteracted(
    CharacterInteractionController interactionController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) interactionController)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IInteractable.NativeMethodInfoPtr_CanBeInteracted_Public_Abstract_Virtual_New_Boolean_CharacterInteractionController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
