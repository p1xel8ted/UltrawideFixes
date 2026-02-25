// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.PDAEntryText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.UI;

public class PDAEntryText(IntPtr pointer) : Selectable(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_scrollRect;
  private static readonly IntPtr NativeFieldInfoPtr_scrollSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_scrollSound;
  private static readonly IntPtr NativeFieldInfoPtr_scrollErrorSound;
  private static readonly IntPtr NativeFieldInfoPtr_scrollInstance;
  private static readonly IntPtr NativeFieldInfoPtr_scrollErrorInstance;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PDAEntryText()
  {
    Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (PDAEntryText));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr);
    PDAEntryText.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, nameof (scrollRect));
    PDAEntryText.NativeFieldInfoPtr_scrollSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, nameof (scrollSpeed));
    PDAEntryText.NativeFieldInfoPtr_scrollSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, nameof (scrollSound));
    PDAEntryText.NativeFieldInfoPtr_scrollErrorSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, nameof (scrollErrorSound));
    PDAEntryText.NativeFieldInfoPtr_scrollInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, nameof (scrollInstance));
    PDAEntryText.NativeFieldInfoPtr_scrollErrorInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, nameof (scrollErrorInstance));
    PDAEntryText.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, 100672040);
    PDAEntryText.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, 100672041);
    PDAEntryText.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, 100672042);
    PDAEntryText.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, 100672043);
    PDAEntryText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr, 100672044);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97576, XrefRangeEnd = 97582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAEntryText.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97582, XrefRangeEnd = 97585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PDAEntryText.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97585, XrefRangeEnd = 97604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAEntryText.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97604, XrefRangeEnd = 97609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnCancel(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAEntryText.NativeMethodInfoPtr_OnCancel_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 97609, XrefRangeEnd = 97613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PDAEntryText()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAEntryText>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAEntryText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ScrollRect scrollRect
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollRect));
      return num == IntPtr.Zero ? (ScrollRect) null : Il2CppObjectPool.Get<ScrollRect>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float scrollSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollSpeed)) = value;
    }
  }

  public unsafe EventReference scrollSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollSound)) = value;
    }
  }

  public unsafe EventReference scrollErrorSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollErrorSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollErrorSound)) = value;
    }
  }

  public unsafe EventInstance scrollInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollInstance)) = value;
    }
  }

  public unsafe EventInstance scrollErrorInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollErrorInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryText.NativeFieldInfoPtr_scrollErrorInstance)) = value;
    }
  }
}
