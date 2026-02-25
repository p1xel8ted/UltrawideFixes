// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IArticyRefChangedNotifier
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IArticyRefChangedNotifier(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_ReferenceChanged_Public_Abstract_Virtual_New_Void_String_UInt64_UInt64_0;

  static IArticyRefChangedNotifier()
  {
    Il2CppClassPointerStore<IArticyRefChangedNotifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IArticyRefChangedNotifier));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IArticyRefChangedNotifier>.NativeClassPtr);
    IArticyRefChangedNotifier.NativeMethodInfoPtr_ReferenceChanged_Public_Abstract_Virtual_New_Void_String_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IArticyRefChangedNotifier>.NativeClassPtr, 100664540);
  }

  [CallerCount(0)]
  public virtual unsafe void ReferenceChanged(string aPropertyName, ulong aOldId, ulong aNewId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aPropertyName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &aOldId;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &aNewId;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IArticyRefChangedNotifier.NativeMethodInfoPtr_ReferenceChanged_Public_Abstract_Virtual_New_Void_String_UInt64_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
