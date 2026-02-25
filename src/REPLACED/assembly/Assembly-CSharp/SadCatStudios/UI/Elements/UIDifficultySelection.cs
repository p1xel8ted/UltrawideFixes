// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.Elements.UIDifficultySelection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace SadCatStudios.UI.Elements;

public class UIDifficultySelection(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyLevels;
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_SelectedDifficulty;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DifficultyButtonSelected_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DifficultyButtonPressed_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIDifficultySelection()
  {
    Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI.Elements", nameof (UIDifficultySelection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr);
    UIDifficultySelection.NativeFieldInfoPtr_difficultyLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, nameof (difficultyLevels));
    UIDifficultySelection.NativeFieldInfoPtr_difficultyDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, nameof (difficultyDescription));
    UIDifficultySelection.NativeFieldInfoPtr_SelectedDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, nameof (SelectedDifficulty));
    UIDifficultySelection.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, 100672322);
    UIDifficultySelection.NativeMethodInfoPtr_OnEnable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, 100672323);
    UIDifficultySelection.NativeMethodInfoPtr_DifficultyButtonSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, 100672324);
    UIDifficultySelection.NativeMethodInfoPtr_DifficultyButtonPressed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, 100672325);
    UIDifficultySelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, 100672326);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100580, XrefRangeEnd = 100589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnValidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDifficultySelection.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100589, XrefRangeEnd = 100595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDifficultySelection.NativeMethodInfoPtr_OnEnable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100595, XrefRangeEnd = 100602, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DifficultyButtonSelected(int i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDifficultySelection.NativeMethodInfoPtr_DifficultyButtonSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void DifficultyButtonPressed(int i)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &i
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDifficultySelection.NativeMethodInfoPtr_DifficultyButtonPressed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIDifficultySelection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIDifficultySelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<UIDifficultySelection.DifficultyLevel> difficultyLevels
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.NativeFieldInfoPtr_difficultyLevels));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UIDifficultySelection.DifficultyLevel>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UIDifficultySelection.DifficultyLevel>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.NativeFieldInfoPtr_difficultyLevels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text difficultyDescription
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.NativeFieldInfoPtr_difficultyDescription));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.NativeFieldInfoPtr_difficultyDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SadCatStudios.Foundation.DifficultyLevel SelectedDifficulty
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.NativeFieldInfoPtr_SelectedDifficulty));
      return num == System.IntPtr.Zero ? (SadCatStudios.Foundation.DifficultyLevel) null : Il2CppObjectPool.Get<SadCatStudios.Foundation.DifficultyLevel>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.NativeFieldInfoPtr_SelectedDifficulty), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class DifficultyLevel(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DifficultyName;
    private static readonly System.IntPtr NativeFieldInfoPtr_ArticyDifficulty;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static DifficultyLevel()
    {
      Il2CppClassPointerStore<UIDifficultySelection.DifficultyLevel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIDifficultySelection>.NativeClassPtr, nameof (DifficultyLevel));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIDifficultySelection.DifficultyLevel>.NativeClassPtr);
      UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_DifficultyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDifficultySelection.DifficultyLevel>.NativeClassPtr, nameof (DifficultyName));
      UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_ArticyDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDifficultySelection.DifficultyLevel>.NativeClassPtr, nameof (ArticyDifficulty));
      UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIDifficultySelection.DifficultyLevel>.NativeClassPtr, nameof (Level));
      UIDifficultySelection.DifficultyLevel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIDifficultySelection.DifficultyLevel>.NativeClassPtr, 100672327);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DifficultyLevel()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIDifficultySelection.DifficultyLevel>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIDifficultySelection.DifficultyLevel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe TMP_Text DifficultyName
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_DifficultyName));
        return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_DifficultyName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ArticyRef ArticyDifficulty
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_ArticyDifficulty));
        return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_ArticyDifficulty), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SadCatStudios.Foundation.DifficultyLevel Level
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_Level));
        return num == System.IntPtr.Zero ? (SadCatStudios.Foundation.DifficultyLevel) null : Il2CppObjectPool.Get<SadCatStudios.Foundation.DifficultyLevel>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIDifficultySelection.DifficultyLevel.NativeFieldInfoPtr_Level), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
