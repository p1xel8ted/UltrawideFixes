// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UISavegameButtonScroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UISavegameButtonScroll(System.IntPtr pointer) : Button(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_scrollRect;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeleteRequested;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_ScrollRect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_add_DeleteRequested_Public_add_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_remove_DeleteRequested_Public_rem_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UISavegameButtonScroll()
  {
    Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UISavegameButtonScroll));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr);
    UISavegameButtonScroll.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr, nameof (scrollRect));
    UISavegameButtonScroll.NativeFieldInfoPtr_DeleteRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr, nameof (DeleteRequested));
    UISavegameButtonScroll.NativeMethodInfoPtr_Init_Public_Void_ScrollRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr, 100672434);
    UISavegameButtonScroll.NativeMethodInfoPtr_add_DeleteRequested_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr, 100672435);
    UISavegameButtonScroll.NativeMethodInfoPtr_remove_DeleteRequested_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr, 100672436);
    UISavegameButtonScroll.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr, 100672437);
    UISavegameButtonScroll.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr, 100672438);
    UISavegameButtonScroll.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr, 100672439);
  }

  [CallerCount(0)]
  public unsafe void Init(ScrollRect parentRect)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parentRect)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISavegameButtonScroll.NativeMethodInfoPtr_Init_Public_Void_ScrollRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101164, XrefRangeEnd = 101168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void add_DeleteRequested(Il2CppSystem.Action value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISavegameButtonScroll.NativeMethodInfoPtr_add_DeleteRequested_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101168, XrefRangeEnd = 101172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  [SpecialName]
  public unsafe void remove_DeleteRequested(Il2CppSystem.Action value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISavegameButtonScroll.NativeMethodInfoPtr_remove_DeleteRequested_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101172, XrefRangeEnd = 101177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISavegameButtonScroll.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UISavegameButtonScroll.NativeMethodInfoPtr_OnSelect_Public_Virtual_Void_BaseEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101177, XrefRangeEnd = 101178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UISavegameButtonScroll()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISavegameButtonScroll>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UISavegameButtonScroll.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ScrollRect scrollRect
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISavegameButtonScroll.NativeFieldInfoPtr_scrollRect));
      return num == System.IntPtr.Zero ? (ScrollRect) null : Il2CppObjectPool.Get<ScrollRect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISavegameButtonScroll.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action DeleteRequested
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UISavegameButtonScroll.NativeFieldInfoPtr_DeleteRequested));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UISavegameButtonScroll.NativeFieldInfoPtr_DeleteRequested), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
