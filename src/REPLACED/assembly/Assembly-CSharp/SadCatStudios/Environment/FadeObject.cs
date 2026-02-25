// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.FadeObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class FadeObject(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_childrenRenderers;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FadeObject()
  {
    Il2CppClassPointerStore<FadeObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (FadeObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeObject>.NativeClassPtr);
    FadeObject.NativeFieldInfoPtr_childrenRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeObject>.NativeClassPtr, nameof (childrenRenderers));
    FadeObject.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeObject>.NativeClassPtr, 100676040);
    FadeObject.NativeMethodInfoPtr_FadeIn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeObject>.NativeClassPtr, 100676041);
    FadeObject.NativeMethodInfoPtr_FadeOut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeObject>.NativeClassPtr, 100676042);
    FadeObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeObject>.NativeClassPtr, 100676043);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120979, XrefRangeEnd = 120982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FadeObject.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120982, XrefRangeEnd = 120984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeIn()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FadeObject.NativeMethodInfoPtr_FadeIn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 120986, RefRangeEnd = 120987, XrefRangeStart = 120984, XrefRangeEnd = 120986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FadeOut()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FadeObject.NativeMethodInfoPtr_FadeOut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FadeObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeObject>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FadeObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<MeshRenderer> childrenRenderers
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeObject.NativeFieldInfoPtr_childrenRenderers));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<MeshRenderer>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FadeObject.NativeFieldInfoPtr_childrenRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
