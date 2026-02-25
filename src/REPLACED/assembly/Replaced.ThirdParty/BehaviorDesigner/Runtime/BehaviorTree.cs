// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.BehaviorTree
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace BehaviorDesigner.Runtime;

public class BehaviorTree(IntPtr pointer) : Behavior(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BehaviorTree()
  {
    Il2CppClassPointerStore<BehaviorTree>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime", nameof (BehaviorTree));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BehaviorTree>.NativeClassPtr);
    BehaviorTree.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BehaviorTree>.NativeClassPtr, 100673667);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403279, XrefRangeEnd = 403280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BehaviorTree()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BehaviorTree>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BehaviorTree.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
