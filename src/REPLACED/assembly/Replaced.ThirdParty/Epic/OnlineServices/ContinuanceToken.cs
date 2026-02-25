// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ContinuanceToken
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Epic.OnlineServices;

public sealed class ContinuanceToken(IntPtr pointer) : Handle(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Result_byref_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  static ContinuanceToken()
  {
    Il2CppClassPointerStore<ContinuanceToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices", nameof (ContinuanceToken));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContinuanceToken>.NativeClassPtr);
    ContinuanceToken.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuanceToken>.NativeClassPtr, 100664412);
    ContinuanceToken.NativeMethodInfoPtr_ToString_Public_Result_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuanceToken>.NativeClassPtr, 100664414);
    ContinuanceToken.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContinuanceToken>.NativeClassPtr, 100664415);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ContinuanceToken()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContinuanceToken>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ContinuanceToken.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 371476, RefRangeEnd = 371477, XrefRangeStart = 371391, XrefRangeEnd = 371476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result ToString(out string outBuffer)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr1 = stackalloc IntPtr[1];
    IntPtr* numPtr2 = numPtr1;
    IntPtr zero = IntPtr.Zero;
    IntPtr* numPtr3 = &zero;
    *numPtr2 = (IntPtr) numPtr3;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ContinuanceToken.NativeMethodInfoPtr_ToString_Public_Result_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    outBuffer = IL2CPP.Il2CppStringToManaged(zero);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 371477, XrefRangeEnd = 371478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ContinuanceToken.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }
}
