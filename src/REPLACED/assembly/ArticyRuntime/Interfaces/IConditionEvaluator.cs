// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IConditionEvaluator
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IConditionEvaluator(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0;

  static IConditionEvaluator()
  {
    Il2CppClassPointerStore<IConditionEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IConditionEvaluator));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IConditionEvaluator>.NativeClassPtr);
    IConditionEvaluator.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IConditionEvaluator>.NativeClassPtr, 100664528 /*0x060004D0*/);
  }

  [CallerCount(0)]
  public virtual unsafe bool Evaluate(
    IBaseScriptMethodProvider aMethodProvider,
    IGlobalVariables aGlobalVariables = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IConditionEvaluator.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
