// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.ArcadeCounter
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
using TMPro;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class ArcadeCounter(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_locaKey;
  private static readonly IntPtr NativeFieldInfoPtr_counterText;
  private static readonly IntPtr NativeFieldInfoPtr_localizedFormatting;
  private static readonly IntPtr NativeFieldInfoPtr__CurrentCounter_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr__MaxCounter_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_CurrentCounter_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_CurrentCounter_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxCounter_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_MaxCounter_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateCounterText_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeCounter()
  {
    Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (ArcadeCounter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr);
    ArcadeCounter.NativeFieldInfoPtr_locaKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, nameof (locaKey));
    ArcadeCounter.NativeFieldInfoPtr_counterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, nameof (counterText));
    ArcadeCounter.NativeFieldInfoPtr_localizedFormatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, nameof (localizedFormatting));
    ArcadeCounter.NativeFieldInfoPtr__CurrentCounter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, "<CurrentCounter>k__BackingField");
    ArcadeCounter.NativeFieldInfoPtr__MaxCounter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, "<MaxCounter>k__BackingField");
    ArcadeCounter.NativeMethodInfoPtr_get_CurrentCounter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, 100676444);
    ArcadeCounter.NativeMethodInfoPtr_set_CurrentCounter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, 100676445);
    ArcadeCounter.NativeMethodInfoPtr_get_MaxCounter_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, 100676446);
    ArcadeCounter.NativeMethodInfoPtr_set_MaxCounter_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, 100676447);
    ArcadeCounter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, 100676448);
    ArcadeCounter.NativeMethodInfoPtr_UpdateCounterText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, 100676449);
    ArcadeCounter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr, 100676450);
  }

  public unsafe int CurrentCounter
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeCounter.NativeMethodInfoPtr_get_CurrentCounter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 123407, RefRangeEnd = 123416, XrefRangeStart = 123407, XrefRangeEnd = 123407, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArcadeCounter.NativeMethodInfoPtr_set_CurrentCounter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int MaxCounter
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeCounter.NativeMethodInfoPtr_get_MaxCounter_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(13), CachedScanResults(RefRangeStart = 123416, RefRangeEnd = 123429, XrefRangeStart = 123416, XrefRangeEnd = 123416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArcadeCounter.NativeMethodInfoPtr_set_MaxCounter_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123429, XrefRangeEnd = 123436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCounter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 123441, RefRangeEnd = 123446, XrefRangeStart = 123436, XrefRangeEnd = 123441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateCounterText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCounter.NativeMethodInfoPtr_UpdateCounterText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeCounter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeCounter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeCounter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef locaKey
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr_locaKey));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr_locaKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text counterText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr_counterText));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr_counterText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string localizedFormatting
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr_localizedFormatting)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr_localizedFormatting), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int _CurrentCounter_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr__CurrentCounter_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr__CurrentCounter_k__BackingField)) = value;
    }
  }

  public unsafe int _MaxCounter_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr__MaxCounter_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeCounter.NativeFieldInfoPtr__MaxCounter_k__BackingField)) = value;
    }
  }
}
