// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.ArcadeScore
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

public class ArcadeScore(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_scoreLoca;
  private static readonly IntPtr NativeFieldInfoPtr_scoreText;
  private static readonly IntPtr NativeFieldInfoPtr_localizedFormatting;
  private static readonly IntPtr NativeFieldInfoPtr__CurrentScore_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_CurrentScore_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_CurrentScore_Private_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_ResetScore_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddScore_Public_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateScoreText_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeScore()
  {
    Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (ArcadeScore));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr);
    ArcadeScore.NativeFieldInfoPtr_scoreLoca = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, nameof (scoreLoca));
    ArcadeScore.NativeFieldInfoPtr_scoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, nameof (scoreText));
    ArcadeScore.NativeFieldInfoPtr_localizedFormatting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, nameof (localizedFormatting));
    ArcadeScore.NativeFieldInfoPtr__CurrentScore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, "<CurrentScore>k__BackingField");
    ArcadeScore.NativeMethodInfoPtr_get_CurrentScore_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, 100676742);
    ArcadeScore.NativeMethodInfoPtr_set_CurrentScore_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, 100676743);
    ArcadeScore.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, 100676744);
    ArcadeScore.NativeMethodInfoPtr_ResetScore_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, 100676745);
    ArcadeScore.NativeMethodInfoPtr_AddScore_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, 100676746);
    ArcadeScore.NativeMethodInfoPtr_UpdateScoreText_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, 100676747);
    ArcadeScore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr, 100676748);
  }

  public unsafe int CurrentScore
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeScore.NativeMethodInfoPtr_get_CurrentScore_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 123407, RefRangeEnd = 123416, XrefRangeStart = 123407, XrefRangeEnd = 123416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArcadeScore.NativeMethodInfoPtr_set_CurrentScore_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126133, XrefRangeEnd = 126140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeScore.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 126143, RefRangeEnd = 126145, XrefRangeStart = 126140, XrefRangeEnd = 126143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ResetScore()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeScore.NativeMethodInfoPtr_ResetScore_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 126148, RefRangeEnd = 126153, XrefRangeStart = 126145, XrefRangeEnd = 126148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddScore(int score)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &score
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeScore.NativeMethodInfoPtr_AddScore_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 126153, XrefRangeEnd = 126156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateScoreText()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeScore.NativeMethodInfoPtr_UpdateScoreText_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeScore()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeScore>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeScore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef scoreLoca
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeScore.NativeFieldInfoPtr_scoreLoca));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeScore.NativeFieldInfoPtr_scoreLoca), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text scoreText
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeScore.NativeFieldInfoPtr_scoreText));
      return num == IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeScore.NativeFieldInfoPtr_scoreText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string localizedFormatting
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeScore.NativeFieldInfoPtr_localizedFormatting)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeScore.NativeFieldInfoPtr_localizedFormatting), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int _CurrentScore_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeScore.NativeFieldInfoPtr__CurrentScore_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeScore.NativeFieldInfoPtr__CurrentScore_k__BackingField)) = value;
    }
  }
}
