// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.IAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;

#nullable disable
namespace SadCatStudios.Character;

public class IAnimationController(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_GetClipStatus_Public_Abstract_Virtual_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCurrentClip_Public_Abstract_Virtual_New_MeshClip_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetCurrentFrame_Public_Abstract_Virtual_New_MeshClipFrame_0;

  static IAnimationController()
  {
    Il2CppClassPointerStore<IAnimationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (IAnimationController));
    IAnimationController.NativeMethodInfoPtr_GetClipStatus_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationController>.NativeClassPtr, 100675576);
    IAnimationController.NativeMethodInfoPtr_GetCurrentClip_Public_Abstract_Virtual_New_MeshClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationController>.NativeClassPtr, 100675577);
    IAnimationController.NativeMethodInfoPtr_GetCurrentFrame_Public_Abstract_Virtual_New_MeshClipFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAnimationController>.NativeClassPtr, 100675578);
  }

  [CallerCount(0)]
  public virtual unsafe bool GetClipStatus()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAnimationController.NativeMethodInfoPtr_GetClipStatus_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe MeshClip GetCurrentClip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAnimationController.NativeMethodInfoPtr_GetCurrentClip_Public_Abstract_Virtual_New_MeshClip_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe MeshClipFrame GetCurrentFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAnimationController.NativeMethodInfoPtr_GetCurrentFrame_Public_Abstract_Virtual_New_MeshClipFrame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (MeshClipFrame) null : Il2CppObjectPool.Get<MeshClipFrame>(num3);
  }
}
