// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IGrabSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace SadCatStudios.Combat;

public class IGrabSender(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ConnectGrab_Public_Abstract_Virtual_New_Void_GrabCastResult_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResolveConnection_Public_Abstract_Virtual_New_Void_GrabConnectionType_0;
  private static readonly IntPtr NativeMethodInfoPtr_SendLaunch_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_BreakGrab_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ClearConnection_Public_Abstract_Virtual_New_Void_0;

  static IGrabSender()
  {
    Il2CppClassPointerStore<IGrabSender>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IGrabSender));
    IGrabSender.NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabSender>.NativeClassPtr, 100677392);
    IGrabSender.NativeMethodInfoPtr_ConnectGrab_Public_Abstract_Virtual_New_Void_GrabCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabSender>.NativeClassPtr, 100677393);
    IGrabSender.NativeMethodInfoPtr_ResolveConnection_Public_Abstract_Virtual_New_Void_GrabConnectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabSender>.NativeClassPtr, 100677394);
    IGrabSender.NativeMethodInfoPtr_SendLaunch_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabSender>.NativeClassPtr, 100677395);
    IGrabSender.NativeMethodInfoPtr_BreakGrab_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabSender>.NativeClassPtr, 100677396);
    IGrabSender.NativeMethodInfoPtr_ClearConnection_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGrabSender>.NativeClassPtr, 100677397);
  }

  [CallerCount(0)]
  public virtual unsafe void CastGrab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabSender.NativeMethodInfoPtr_CastGrab_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ConnectGrab(GrabCastResult grabCastResult)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) grabCastResult))
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabSender.NativeMethodInfoPtr_ConnectGrab_Public_Abstract_Virtual_New_Void_GrabCastResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ResolveConnection(GrabConnectionType connectionType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &connectionType
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabSender.NativeMethodInfoPtr_ResolveConnection_Public_Abstract_Virtual_New_Void_GrabConnectionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void SendLaunch()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabSender.NativeMethodInfoPtr_SendLaunch_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void BreakGrab()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabSender.NativeMethodInfoPtr_BreakGrab_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ClearConnection()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGrabSender.NativeMethodInfoPtr_ClearConnection_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
