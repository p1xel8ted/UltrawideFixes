// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IGlobalVariables
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IGlobalVariables(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_IsInShadowState_Public_Abstract_Virtual_New_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_SeenCounters_Public_Abstract_Virtual_New_get_Dictionary_2_UInt64_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_SeenCounters_Public_Abstract_Virtual_New_set_Void_Dictionary_2_UInt64_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetSeenCounter_Public_Abstract_Virtual_New_Int32_UInt64_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetSeenCounter_Public_Abstract_Virtual_New_Void_UInt64_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetAllSeenCounters_Public_Abstract_Virtual_New_Void_0;

  static IGlobalVariables()
  {
    Il2CppClassPointerStore<IGlobalVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IGlobalVariables));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IGlobalVariables>.NativeClassPtr);
    IGlobalVariables.NativeMethodInfoPtr_get_IsInShadowState_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGlobalVariables>.NativeClassPtr, 100664529);
    IGlobalVariables.NativeMethodInfoPtr_get_SeenCounters_Public_Abstract_Virtual_New_get_Dictionary_2_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGlobalVariables>.NativeClassPtr, 100664530);
    IGlobalVariables.NativeMethodInfoPtr_set_SeenCounters_Public_Abstract_Virtual_New_set_Void_Dictionary_2_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGlobalVariables>.NativeClassPtr, 100664531);
    IGlobalVariables.NativeMethodInfoPtr_GetSeenCounter_Public_Abstract_Virtual_New_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGlobalVariables>.NativeClassPtr, 100664532);
    IGlobalVariables.NativeMethodInfoPtr_SetSeenCounter_Public_Abstract_Virtual_New_Void_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGlobalVariables>.NativeClassPtr, 100664533);
    IGlobalVariables.NativeMethodInfoPtr_ResetAllSeenCounters_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGlobalVariables>.NativeClassPtr, 100664534);
  }

  public virtual unsafe bool IsInShadowState
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGlobalVariables.NativeMethodInfoPtr_get_IsInShadowState_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe Dictionary<ulong, int> SeenCounters
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGlobalVariables.NativeMethodInfoPtr_get_SeenCounters_Public_Abstract_Virtual_New_get_Dictionary_2_UInt64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Dictionary<ulong, int>) null : Il2CppObjectPool.Get<Dictionary<ulong, int>>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGlobalVariables.NativeMethodInfoPtr_set_SeenCounters_Public_Abstract_Virtual_New_set_Void_Dictionary_2_UInt64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public virtual unsafe int GetSeenCounter(ulong aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &aId
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGlobalVariables.NativeMethodInfoPtr_GetSeenCounter_Public_Abstract_Virtual_New_Int32_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void SetSeenCounter(ulong aId, int aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &aId;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &aValue;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGlobalVariables.NativeMethodInfoPtr_SetSeenCounter_Public_Abstract_Virtual_New_Void_UInt64_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ResetAllSeenCounters()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGlobalVariables.NativeMethodInfoPtr_ResetAllSeenCounters_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
