// Decompiled with JetBrains decompiler
// Type: Rewired.IFlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace Rewired;

public class IFlightPedalsTemplate(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0;

  static IFlightPedalsTemplate()
  {
    Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (IFlightPedalsTemplate));
    IFlightPedalsTemplate.NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100667759);
    IFlightPedalsTemplate.NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100667760);
    IFlightPedalsTemplate.NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IFlightPedalsTemplate>.NativeClassPtr, 100667761);
  }

  public virtual unsafe IControllerTemplateAxis leftPedal
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_leftPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  public virtual unsafe IControllerTemplateAxis rightPedal
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_rightPedal_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  public virtual unsafe IControllerTemplateAxis slide
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IFlightPedalsTemplate.NativeMethodInfoPtr_get_slide_Public_Abstract_Virtual_New_get_IControllerTemplateAxis_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }
}
