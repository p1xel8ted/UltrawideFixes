// Decompiled with JetBrains decompiler
// Type: UnityEngine.IExposedPropertyTable
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace UnityEngine;

public class IExposedPropertyTable(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0;

  static IExposedPropertyTable()
  {
    Il2CppClassPointerStore<IExposedPropertyTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (IExposedPropertyTable));
    IExposedPropertyTable.NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IExposedPropertyTable>.NativeClassPtr, 100664410);
  }

  [CallerCount(0)]
  public virtual unsafe Object GetReferenceValue(PropertyName id, out bool idValid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &id;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) ref idValid;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IExposedPropertyTable.NativeMethodInfoPtr_GetReferenceValue_Public_Abstract_Virtual_New_Object_PropertyName_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (Object) null : Il2CppObjectPool.Get<Object>(num3);
  }
}
