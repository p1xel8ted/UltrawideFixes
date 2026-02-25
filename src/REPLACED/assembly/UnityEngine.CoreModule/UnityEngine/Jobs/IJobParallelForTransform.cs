// Decompiled with JetBrains decompiler
// Type: UnityEngine.Jobs.IJobParallelForTransform
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine.Jobs;

public class IJobParallelForTransform(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0;

  static IJobParallelForTransform()
  {
    Il2CppClassPointerStore<IJobParallelForTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", nameof (IJobParallelForTransform));
    IJobParallelForTransform.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IJobParallelForTransform>.NativeClassPtr, 100668924);
  }

  [CallerCount(0)]
  public virtual unsafe void Execute(int index, TransformAccess transform)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &index;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &transform;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IJobParallelForTransform.NativeMethodInfoPtr_Execute_Public_Abstract_Virtual_New_Void_Int32_TransformAccess_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
