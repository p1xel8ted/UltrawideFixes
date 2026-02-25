// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.ArcadeMenuButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SadCatStudios.Arcade;

public class ArcadeMenuButton(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_selectionSound;
  private static readonly IntPtr NativeFieldInfoPtr_confirmSound;
  private static readonly IntPtr NativeFieldInfoPtr_selectionInstance;
  private static readonly IntPtr NativeFieldInfoPtr_confirmInstance;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeMenuButton()
  {
    Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (ArcadeMenuButton));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr);
    ArcadeMenuButton.NativeFieldInfoPtr_selectionSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, nameof (selectionSound));
    ArcadeMenuButton.NativeFieldInfoPtr_confirmSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, nameof (confirmSound));
    ArcadeMenuButton.NativeFieldInfoPtr_selectionInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, nameof (selectionInstance));
    ArcadeMenuButton.NativeFieldInfoPtr_confirmInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, nameof (confirmInstance));
    ArcadeMenuButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, 100676737);
    ArcadeMenuButton.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, 100676738);
    ArcadeMenuButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, 100676739);
    ArcadeMenuButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, 100676740);
    ArcadeMenuButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr, 100676741);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126125, XrefRangeEnd = 126130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeMenuButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126130, XrefRangeEnd = 126132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeMenuButton.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnSelect(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeMenuButton.NativeMethodInfoPtr_OnSelect_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126132, XrefRangeEnd = 126133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnSubmit(BaseEventData eventData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) eventData)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeMenuButton.NativeMethodInfoPtr_OnSubmit_Public_Virtual_Final_New_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeMenuButton()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeMenuButton>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeMenuButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe EventReference selectionSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeMenuButton.NativeFieldInfoPtr_selectionSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeMenuButton.NativeFieldInfoPtr_selectionSound)) = value;
    }
  }

  public unsafe EventReference confirmSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeMenuButton.NativeFieldInfoPtr_confirmSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeMenuButton.NativeFieldInfoPtr_confirmSound)) = value;
    }
  }

  public unsafe EventInstance selectionInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeMenuButton.NativeFieldInfoPtr_selectionInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeMenuButton.NativeFieldInfoPtr_selectionInstance)) = value;
    }
  }

  public unsafe EventInstance confirmInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeMenuButton.NativeFieldInfoPtr_confirmInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeMenuButton.NativeFieldInfoPtr_confirmInstance)) = value;
    }
  }
}
