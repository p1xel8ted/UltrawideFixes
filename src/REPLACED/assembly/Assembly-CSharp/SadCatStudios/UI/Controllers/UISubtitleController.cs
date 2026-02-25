// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Controllers.UISubtitleController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.UI.Elements;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI.Controllers;

public class UISubtitleController(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_typeWriter;
  private static readonly IntPtr NativeFieldInfoPtr_active;
  private static readonly IntPtr NativeMethodInfoPtr_ActivateDialog_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DeactivateDialog_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UISubtitleController()
  {
    Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Controllers", nameof (UISubtitleController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr);
    UISubtitleController.NativeFieldInfoPtr_typeWriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr, nameof (typeWriter));
    UISubtitleController.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr, nameof (active));
    UISubtitleController.NativeMethodInfoPtr_ActivateDialog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr, 100672619);
    UISubtitleController.NativeMethodInfoPtr_DeactivateDialog_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr, 100672620);
    UISubtitleController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr, 100672621);
    UISubtitleController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr, 100672622);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 16652, RefRangeEnd = 16658, XrefRangeStart = 16652, XrefRangeEnd = 16658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ActivateDialog()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleController.NativeMethodInfoPtr_ActivateDialog_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 102333, RefRangeEnd = 102345, XrefRangeStart = 102333, XrefRangeEnd = 102333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeactivateDialog()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleController.NativeMethodInfoPtr_DeactivateDialog_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 102345, XrefRangeEnd = 102355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISubtitleController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISubtitleController>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISubtitleController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UITextTypeWriter typeWriter
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleController.NativeFieldInfoPtr_typeWriter));
      return num == IntPtr.Zero ? (UITextTypeWriter) null : Il2CppObjectPool.Get<UITextTypeWriter>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleController.NativeFieldInfoPtr_typeWriter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleController.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISubtitleController.NativeFieldInfoPtr_active)) = value;
    }
  }
}
