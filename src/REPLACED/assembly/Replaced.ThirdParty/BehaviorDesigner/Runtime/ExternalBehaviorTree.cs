// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.ExternalBehaviorTree
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace BehaviorDesigner.Runtime;

[Serializable]
public class ExternalBehaviorTree(IntPtr pointer) : ExternalBehavior(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ExternalBehaviorTree()
  {
    Il2CppClassPointerStore<ExternalBehaviorTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (ExternalBehaviorTree));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExternalBehaviorTree>.NativeClassPtr);
    ExternalBehaviorTree.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExternalBehaviorTree>.NativeClassPtr, 100673668);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ExternalBehaviorTree()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExternalBehaviorTree>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExternalBehaviorTree.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
