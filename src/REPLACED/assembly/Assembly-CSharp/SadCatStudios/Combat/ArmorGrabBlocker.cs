// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.ArmorGrabBlocker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class ArmorGrabBlocker(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_armorController;
  private static readonly IntPtr NativeFieldInfoPtr_attackSender;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CanBeGrabbed_Public_Virtual_Final_New_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ConnectionType_Public_Virtual_Final_New_GrabConnectionType_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArmorGrabBlocker()
  {
    Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (ArmorGrabBlocker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr);
    ArmorGrabBlocker.NativeFieldInfoPtr_armorController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr, nameof (armorController));
    ArmorGrabBlocker.NativeFieldInfoPtr_attackSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr, nameof (attackSender));
    ArmorGrabBlocker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr, 100677131);
    ArmorGrabBlocker.NativeMethodInfoPtr_CanBeGrabbed_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr, 100677132);
    ArmorGrabBlocker.NativeMethodInfoPtr_ConnectionType_Public_Virtual_Final_New_GrabConnectionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr, 100677133);
    ArmorGrabBlocker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr, 100677134);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128349, XrefRangeEnd = 128355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorGrabBlocker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool CanBeGrabbed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorGrabBlocker.NativeMethodInfoPtr_CanBeGrabbed_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128355, XrefRangeEnd = 128356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe GrabConnectionType ConnectionType()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArmorGrabBlocker.NativeMethodInfoPtr_ConnectionType_Public_Virtual_Final_New_GrabConnectionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(GrabConnectionType*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArmorGrabBlocker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArmorGrabBlocker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArmorGrabBlocker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CharacterArmorController armorController
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorGrabBlocker.NativeFieldInfoPtr_armorController));
      return num == IntPtr.Zero ? (CharacterArmorController) null : Il2CppObjectPool.Get<CharacterArmorController>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArmorGrabBlocker.NativeFieldInfoPtr_armorController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAttackSender attackSender
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArmorGrabBlocker.NativeFieldInfoPtr_attackSender));
      return num == IntPtr.Zero ? (CharacterAttackSender) null : Il2CppObjectPool.Get<CharacterAttackSender>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArmorGrabBlocker.NativeFieldInfoPtr_attackSender), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
