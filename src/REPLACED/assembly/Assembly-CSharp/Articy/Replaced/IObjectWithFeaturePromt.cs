// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.IObjectWithFeaturePromt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced.Features;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;

#nullable disable
namespace Articy.Replaced;

public class IObjectWithFeaturePromt(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_GetFeaturePromt_Public_Abstract_Virtual_New_PromtFeature_0;

  static IObjectWithFeaturePromt()
  {
    Il2CppClassPointerStore<IObjectWithFeaturePromt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (IObjectWithFeaturePromt));
    IObjectWithFeaturePromt.NativeMethodInfoPtr_GetFeaturePromt_Public_Abstract_Virtual_New_PromtFeature_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IObjectWithFeaturePromt>.NativeClassPtr, 100678257);
  }

  [CallerCount(0)]
  public virtual unsafe PromtFeature GetFeaturePromt()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IObjectWithFeaturePromt.NativeMethodInfoPtr_GetFeaturePromt_Public_Abstract_Virtual_New_PromtFeature_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (PromtFeature) null : Il2CppObjectPool.Get<PromtFeature>(num3);
  }
}
