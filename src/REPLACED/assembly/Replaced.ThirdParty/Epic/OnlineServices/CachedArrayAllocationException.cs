// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.CachedArrayAllocationException
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Epic.OnlineServices;

public class CachedArrayAllocationException(IntPtr pointer) : AllocationException(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0;

  static CachedArrayAllocationException()
  {
    Il2CppClassPointerStore<CachedArrayAllocationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (CachedArrayAllocationException));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedArrayAllocationException>.NativeClassPtr);
    CachedArrayAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedArrayAllocationException>.NativeClassPtr, 100663767);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364182, XrefRangeEnd = 364196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CachedArrayAllocationException(IntPtr address, int foundLength, int expectedLength)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedArrayAllocationException>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = (IntPtr) &address;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &foundLength;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &expectedLength;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CachedArrayAllocationException.NativeMethodInfoPtr__ctor_Public_Void_IntPtr_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
