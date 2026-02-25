// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.DefaultExtendedCharacterFeatureFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.Features;

[Serializable]
public class DefaultExtendedCharacterFeatureFeature(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mMotivation;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInnerConflict;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSkills;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFears;
  private static readonly System.IntPtr NativeFieldInfoPtr_mHabits;
  private static readonly System.IntPtr NativeFieldInfoPtr_mFurtherDetails;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerInstanceId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Motivation_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Motivation_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InnerConflict_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InnerConflict_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Skills_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Skills_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Fears_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Fears_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Habits_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Habits_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_FurtherDetails_Public_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_FurtherDetails_Public_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefaultExtendedCharacterFeatureFeature()
  {
    Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (DefaultExtendedCharacterFeatureFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr);
    DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mMotivation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, nameof (mMotivation));
    DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mInnerConflict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, nameof (mInnerConflict));
    DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mSkills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, nameof (mSkills));
    DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mFears = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, nameof (mFears));
    DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mHabits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, nameof (mHabits));
    DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mFurtherDetails = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, nameof (mFurtherDetails));
    DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, nameof (mOwnerId));
    DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, nameof (mOwnerInstanceId));
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_Motivation_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678797);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_Motivation_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678798);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_InnerConflict_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678799);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_InnerConflict_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678800);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_Skills_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678801);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_Skills_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678802);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_Fears_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678803);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_Fears_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678804);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_Habits_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678805);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_Habits_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678806);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_FurtherDetails_Public_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678807);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_FurtherDetails_Public_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678808);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678809);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678810);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678811);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678812);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678813);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678814);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678815);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678816);
    DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr, 100678817);
  }

  public unsafe ArticyMultiLanguageString Motivation
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 136200, RefRangeEnd = 136213, XrefRangeStart = 136200, XrefRangeEnd = 136213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_Motivation_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_Motivation_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyMultiLanguageString InnerConflict
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 138599, RefRangeEnd = 138608, XrefRangeStart = 138599, XrefRangeEnd = 138608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_InnerConflict_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_InnerConflict_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyMultiLanguageString Skills
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 138696, RefRangeEnd = 138701, XrefRangeStart = 138696, XrefRangeEnd = 138701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_Skills_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_Skills_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyMultiLanguageString Fears
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_Fears_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138915, XrefRangeEnd = 138917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_Fears_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyMultiLanguageString Habits
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 138717, RefRangeEnd = 138718, XrefRangeStart = 138717, XrefRangeEnd = 138718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_Habits_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_Habits_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyString FurtherDetails
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_FurtherDetails_Public_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyString) null : Il2CppObjectPool.Get<ArticyString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_FurtherDetails_Public_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OwnerId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint OwnerInstanceId
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 109649, RefRangeEnd = 109652, XrefRangeStart = 109649, XrefRangeEnd = 109652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 138917, RefRangeEnd = 138918, XrefRangeStart = 138917, XrefRangeEnd = 138917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 138948, RefRangeEnd = 138949, XrefRangeStart = 138918, XrefRangeEnd = 138948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 138974, RefRangeEnd = 138975, XrefRangeStart = 138949, XrefRangeEnd = 138974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139004, RefRangeEnd = 139005, XrefRangeStart = 138975, XrefRangeEnd = 139004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139005, XrefRangeEnd = 139024, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139024, XrefRangeEnd = 139045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultExtendedCharacterFeatureFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultExtendedCharacterFeatureFeature>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultExtendedCharacterFeatureFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyMultiLanguageString mMotivation
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mMotivation));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mMotivation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyMultiLanguageString mInnerConflict
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mInnerConflict));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mInnerConflict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyMultiLanguageString mSkills
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mSkills));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mSkills), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyMultiLanguageString mFears
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mFears));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mFears), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyMultiLanguageString mHabits
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mHabits));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mHabits), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyString mFurtherDetails
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mFurtherDetails));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mFurtherDetails), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ulong mOwnerId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerId)) = value;
    }
  }

  public unsafe uint mOwnerInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExtendedCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerInstanceId)) = value;
    }
  }
}
