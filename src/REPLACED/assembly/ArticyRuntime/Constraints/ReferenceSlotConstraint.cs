// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Constraints.ReferenceSlotConstraint
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Unity.Constraints;

public sealed class ReferenceSlotConstraint(IntPtr pointer) : BaseReferenceConstraint(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0;

  static ReferenceSlotConstraint()
  {
    Il2CppClassPointerStore<ReferenceSlotConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Constraints", nameof (ReferenceSlotConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceSlotConstraint>.NativeClassPtr);
    ReferenceSlotConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceSlotConstraint>.NativeClassPtr, 100664623);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 1000118, RefRangeEnd = 1000122, XrefRangeStart = 1000117, XrefRangeEnd = 1000118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ReferenceSlotConstraint(
    string aAllowedModelTypes,
    string aPlaceholderValue,
    string aAllowedAssetCategories,
    string aAllowedModelTemplates)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceSlotConstraint>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aAllowedModelTypes);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPlaceholderValue);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aAllowedAssetCategories);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aAllowedModelTemplates);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ReferenceSlotConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
