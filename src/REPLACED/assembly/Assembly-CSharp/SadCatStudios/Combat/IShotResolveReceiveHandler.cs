// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.IShotResolveReceiveHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class IShotResolveReceiveHandler(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessShot_Public_Virtual_New_Void_GunShot_Transform_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanResolve_Protected_Abstract_Virtual_New_Boolean_GunShot_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveShot_Protected_Abstract_Virtual_New_Void_GunShot_Transform_0;

  static IShotResolveReceiveHandler()
  {
    Il2CppClassPointerStore<IShotResolveReceiveHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (IShotResolveReceiveHandler));
    IShotResolveReceiveHandler.NativeMethodInfoPtr_ProcessShot_Public_Virtual_New_Void_GunShot_Transform_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShotResolveReceiveHandler>.NativeClassPtr, 100677594);
    IShotResolveReceiveHandler.NativeMethodInfoPtr_CanResolve_Protected_Abstract_Virtual_New_Boolean_GunShot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShotResolveReceiveHandler>.NativeClassPtr, 100677595);
    IShotResolveReceiveHandler.NativeMethodInfoPtr_ResolveShot_Protected_Abstract_Virtual_New_Void_GunShot_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IShotResolveReceiveHandler>.NativeClassPtr, 100677596);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130761, XrefRangeEnd = 130768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ProcessShot(
    GunShot gunshot,
    Transform senderTransform,
    Il2CppSystem.Action fallbackAction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gunshot);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) senderTransform);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fallbackAction);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IShotResolveReceiveHandler.NativeMethodInfoPtr_ProcessShot_Public_Virtual_New_Void_GunShot_Transform_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool CanResolve(GunShot gunshot)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gunshot)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IShotResolveReceiveHandler.NativeMethodInfoPtr_CanResolve_Protected_Abstract_Virtual_New_Boolean_GunShot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void ResolveShot(GunShot gunshot, Transform senderTransform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gunshot);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) senderTransform);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IShotResolveReceiveHandler.NativeMethodInfoPtr_ResolveShot_Protected_Abstract_Virtual_New_Void_GunShot_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
