// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyValueArticyScriptCondition
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyValueArticyScriptCondition(IntPtr pointer) : ArticyValue<ArticyScriptCondition>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueArticyScriptCondition()
  {
    Il2CppClassPointerStore<ArticyValueArticyScriptCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyValueArticyScriptCondition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueArticyScriptCondition>.NativeClassPtr);
    ArticyValueArticyScriptCondition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyScriptCondition>.NativeClassPtr, 100664059);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 994653, RefRangeEnd = 994661, XrefRangeStart = 994650, XrefRangeEnd = 994653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueArticyScriptCondition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueArticyScriptCondition>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyScriptCondition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
