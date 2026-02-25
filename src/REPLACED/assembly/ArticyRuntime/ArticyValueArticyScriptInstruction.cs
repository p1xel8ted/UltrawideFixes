// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyValueArticyScriptInstruction
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
public class ArticyValueArticyScriptInstruction(IntPtr pointer) : 
  ArticyValue<ArticyScriptInstruction>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueArticyScriptInstruction()
  {
    Il2CppClassPointerStore<ArticyValueArticyScriptInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyValueArticyScriptInstruction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueArticyScriptInstruction>.NativeClassPtr);
    ArticyValueArticyScriptInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyScriptInstruction>.NativeClassPtr, 100664060);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 994664, RefRangeEnd = 994669, XrefRangeStart = 994661, XrefRangeEnd = 994664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueArticyScriptInstruction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueArticyScriptInstruction>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyScriptInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
