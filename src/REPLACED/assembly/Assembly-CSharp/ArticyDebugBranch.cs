// Decompiled with JetBrains decompiler
// Type: ArticyDebugBranch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
public class ArticyDebugBranch(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_dialogText;
  private static readonly IntPtr NativeFieldInfoPtr_branch;
  private static readonly IntPtr NativeFieldInfoPtr_processor;
  private static readonly IntPtr NativeMethodInfoPtr_AssignBranch_Public_Void_ArticyFlowPlayer_Branch_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnBranchSelected_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyDebugBranch()
  {
    Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (ArticyDebugBranch));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr);
    ArticyDebugBranch.NativeFieldInfoPtr_dialogText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr, nameof (dialogText));
    ArticyDebugBranch.NativeFieldInfoPtr_branch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr, nameof (branch));
    ArticyDebugBranch.NativeFieldInfoPtr_processor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr, nameof (processor));
    ArticyDebugBranch.NativeMethodInfoPtr_AssignBranch_Public_Void_ArticyFlowPlayer_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr, 100663299 /*0x06000003*/);
    ArticyDebugBranch.NativeMethodInfoPtr_OnBranchSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr, 100663300 /*0x06000004*/);
    ArticyDebugBranch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr, 100663301 /*0x06000005*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 354, RefRangeEnd = 355, XrefRangeStart = 292, XrefRangeEnd = 354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AssignBranch(ArticyFlowPlayer aProcessor, Branch aBranch)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aProcessor);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranch);
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugBranch.NativeMethodInfoPtr_AssignBranch_Public_Void_ArticyFlowPlayer_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 355, XrefRangeEnd = 357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnBranchSelected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugBranch.NativeMethodInfoPtr_OnBranchSelected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 357, XrefRangeEnd = 358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyDebugBranch()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyDebugBranch>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyDebugBranch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Text dialogText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugBranch.NativeFieldInfoPtr_dialogText));
      return num == IntPtr.Zero ? (Text) null : Il2CppObjectPool.Get<Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugBranch.NativeFieldInfoPtr_dialogText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Branch branch
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugBranch.NativeFieldInfoPtr_branch));
      return num == IntPtr.Zero ? (Branch) null : Il2CppObjectPool.Get<Branch>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugBranch.NativeFieldInfoPtr_branch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyFlowPlayer processor
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugBranch.NativeFieldInfoPtr_processor));
      return num == IntPtr.Zero ? (ArticyFlowPlayer) null : Il2CppObjectPool.Get<ArticyFlowPlayer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyDebugBranch.NativeFieldInfoPtr_processor), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
