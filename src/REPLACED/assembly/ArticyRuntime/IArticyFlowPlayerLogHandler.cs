// Decompiled with JetBrains decompiler
// Type: Articy.Unity.IArticyFlowPlayerLogHandler
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public class IArticyFlowPlayerLogHandler(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Indent_Public_Abstract_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Outdent_Public_Abstract_Virtual_New_Void_0;

  static IArticyFlowPlayerLogHandler()
  {
    Il2CppClassPointerStore<IArticyFlowPlayerLogHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (IArticyFlowPlayerLogHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IArticyFlowPlayerLogHandler>.NativeClassPtr);
    IArticyFlowPlayerLogHandler.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyFlowPlayerLogHandler>.NativeClassPtr, 100664224 /*0x060003A0*/);
    IArticyFlowPlayerLogHandler.NativeMethodInfoPtr_Indent_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyFlowPlayerLogHandler>.NativeClassPtr, 100664225);
    IArticyFlowPlayerLogHandler.NativeMethodInfoPtr_Outdent_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyFlowPlayerLogHandler>.NativeClassPtr, 100664226);
  }

  [CallerCount(0)]
  public virtual unsafe void Log(string aMessage, [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aMessage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyFlowPlayerLogHandler.NativeMethodInfoPtr_Log_Public_Abstract_Virtual_New_Void_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Indent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyFlowPlayerLogHandler.NativeMethodInfoPtr_Indent_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Outdent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyFlowPlayerLogHandler.NativeMethodInfoPtr_Outdent_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual void Log(string aMessage, params Il2CppSystem.Object[] aParams)
  {
    this.Log(aMessage, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams));
  }
}
