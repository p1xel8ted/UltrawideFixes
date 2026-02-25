// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.ArcadeHighScoreDisplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Arcade;

public class ArcadeHighScoreDisplay(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_scores;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerName;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerScoreArticyVar;
  private static readonly System.IntPtr NativeFieldInfoPtr_namesText;
  private static readonly System.IntPtr NativeFieldInfoPtr_scoresText;
  private static readonly System.IntPtr NativeFieldInfoPtr_namesBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_scoresBuilder;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateScores_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeHighScoreDisplay()
  {
    Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (ArcadeHighScoreDisplay));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr);
    ArcadeHighScoreDisplay.NativeFieldInfoPtr_scores = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, nameof (scores));
    ArcadeHighScoreDisplay.NativeFieldInfoPtr_playerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, nameof (playerName));
    ArcadeHighScoreDisplay.NativeFieldInfoPtr_playerScoreArticyVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, nameof (playerScoreArticyVar));
    ArcadeHighScoreDisplay.NativeFieldInfoPtr_namesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, nameof (namesText));
    ArcadeHighScoreDisplay.NativeFieldInfoPtr_scoresText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, nameof (scoresText));
    ArcadeHighScoreDisplay.NativeFieldInfoPtr_namesBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, nameof (namesBuilder));
    ArcadeHighScoreDisplay.NativeFieldInfoPtr_scoresBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, nameof (scoresBuilder));
    ArcadeHighScoreDisplay.NativeMethodInfoPtr_UpdateScores_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, 100676527);
    ArcadeHighScoreDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, 100676528);
    ArcadeHighScoreDisplay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, 100676529);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123982, RefRangeEnd = 123983, XrefRangeStart = 123934, XrefRangeEnd = 123982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateScores()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeHighScoreDisplay.NativeMethodInfoPtr_UpdateScores_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123983, XrefRangeEnd = 123984, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnEnable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeHighScoreDisplay.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123984, XrefRangeEnd = 123995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeHighScoreDisplay()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeHighScoreDisplay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<ArcadeHighScoreDisplay.ScoreEntry> scores
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_scores));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<ArcadeHighScoreDisplay.ScoreEntry>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ArcadeHighScoreDisplay.ScoreEntry>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_scores), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string playerName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_playerName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_playerName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string playerScoreArticyVar
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_playerScoreArticyVar)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_playerScoreArticyVar), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe TMP_Text namesText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_namesText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_namesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text scoresText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_scoresText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_scoresText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder namesBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_namesBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_namesBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder scoresBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_scoresBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.NativeFieldInfoPtr_scoresBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ScoreEntry(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Score;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ScoreEntry()
    {
      Il2CppClassPointerStore<ArcadeHighScoreDisplay.ScoreEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, nameof (ScoreEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeHighScoreDisplay.ScoreEntry>.NativeClassPtr);
      ArcadeHighScoreDisplay.ScoreEntry.NativeFieldInfoPtr_Score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay.ScoreEntry>.NativeClassPtr, nameof (Score));
      ArcadeHighScoreDisplay.ScoreEntry.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay.ScoreEntry>.NativeClassPtr, nameof (Name));
      ArcadeHighScoreDisplay.ScoreEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeHighScoreDisplay.ScoreEntry>.NativeClassPtr, 100676530);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScoreEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeHighScoreDisplay.ScoreEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArcadeHighScoreDisplay.ScoreEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe int Score
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.ScoreEntry.NativeFieldInfoPtr_Score));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.ScoreEntry.NativeFieldInfoPtr_Score)) = value;
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.ScoreEntry.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeHighScoreDisplay.ScoreEntry.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Arcade.ArcadeHighScoreDisplay+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__UpdateScores_b__8_0_Internal_Int32_ScoreEntry_ScoreEntry_0;

    static __c()
    {
      Il2CppClassPointerStore<ArcadeHighScoreDisplay.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArcadeHighScoreDisplay>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeHighScoreDisplay.__c>.NativeClassPtr);
      ArcadeHighScoreDisplay.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay.__c>.NativeClassPtr, "<>9");
      ArcadeHighScoreDisplay.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeHighScoreDisplay.__c>.NativeClassPtr, "<>9__8_0");
      ArcadeHighScoreDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeHighScoreDisplay.__c>.NativeClassPtr, 100676532);
      ArcadeHighScoreDisplay.__c.NativeMethodInfoPtr__UpdateScores_b__8_0_Internal_Int32_ScoreEntry_ScoreEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeHighScoreDisplay.__c>.NativeClassPtr, 100676533);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeHighScoreDisplay.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArcadeHighScoreDisplay.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123932, XrefRangeEnd = 123934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _UpdateScores_b__8_0(
      ArcadeHighScoreDisplay.ScoreEntry a,
      ArcadeHighScoreDisplay.ScoreEntry b)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) b);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeHighScoreDisplay.__c.NativeMethodInfoPtr__UpdateScores_b__8_0_Internal_Int32_ScoreEntry_ScoreEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe ArcadeHighScoreDisplay.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArcadeHighScoreDisplay.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (ArcadeHighScoreDisplay.__c) null : Il2CppObjectPool.Get<ArcadeHighScoreDisplay.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArcadeHighScoreDisplay.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Comparison<ArcadeHighScoreDisplay.ScoreEntry> __9__8_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArcadeHighScoreDisplay.__c.NativeFieldInfoPtr___9__8_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Comparison<ArcadeHighScoreDisplay.ScoreEntry>) null : Il2CppObjectPool.Get<Il2CppSystem.Comparison<ArcadeHighScoreDisplay.ScoreEntry>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArcadeHighScoreDisplay.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
