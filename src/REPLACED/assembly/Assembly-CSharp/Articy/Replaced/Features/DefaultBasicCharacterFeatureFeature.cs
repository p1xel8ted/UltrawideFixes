// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.DefaultBasicCharacterFeatureFeature
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
public class DefaultBasicCharacterFeatureFeature(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mAge;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSpecies;
  private static readonly System.IntPtr NativeFieldInfoPtr_mBornIn;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSex;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOccupation;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAccent;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPersonality;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAppearance;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerInstanceId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Age_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Age_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Species_Public_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Species_Public_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BornIn_Public_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_BornIn_Public_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Sex_Public_get_Sex_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Sex_Public_set_Void_Sex_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Occupation_Public_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Occupation_Public_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Accent_Public_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Accent_Public_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Personality_Public_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Personality_Public_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Appearance_Public_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Appearance_Public_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DefaultBasicCharacterFeatureFeature()
  {
    Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (DefaultBasicCharacterFeatureFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr);
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mAge));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mSpecies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mSpecies));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mBornIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mBornIn));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mSex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mSex));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOccupation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mOccupation));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAccent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mAccent));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mPersonality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mPersonality));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAppearance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mAppearance));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mOwnerId));
    DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, nameof (mOwnerInstanceId));
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Age_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678762);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Age_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678763);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Species_Public_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678764);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Species_Public_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678765);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_BornIn_Public_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678766);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_BornIn_Public_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678767);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Sex_Public_get_Sex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678768);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Sex_Public_set_Void_Sex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678769);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Occupation_Public_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678770);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Occupation_Public_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678771);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Accent_Public_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678772);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Accent_Public_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678773);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Personality_Public_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678774);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Personality_Public_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678775);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Appearance_Public_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678776);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Appearance_Public_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678777);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678778);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678779);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678780);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678781);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678782);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678783);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678784);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678785);
    DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr, 100678786);
  }

  public unsafe float Age
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Age_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 138694, RefRangeEnd = 138696, XrefRangeStart = 138683, XrefRangeEnd = 138694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Age_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyString Species
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 138599, RefRangeEnd = 138608, XrefRangeStart = 138599, XrefRangeEnd = 138608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Species_Public_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Species_Public_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyString BornIn
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 138696, RefRangeEnd = 138701, XrefRangeStart = 138696, XrefRangeEnd = 138696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_BornIn_Public_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyString) null : Il2CppObjectPool.Get<ArticyString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138701, XrefRangeEnd = 138703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_BornIn_Public_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Sex Sex
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Sex_Public_get_Sex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Sex*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 138715, RefRangeEnd = 138717, XrefRangeStart = 138703, XrefRangeEnd = 138715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Sex_Public_set_Void_Sex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyString Occupation
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 138717, RefRangeEnd = 138718, XrefRangeStart = 138717, XrefRangeEnd = 138717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Occupation_Public_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyString) null : Il2CppObjectPool.Get<ArticyString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138718, XrefRangeEnd = 138720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Occupation_Public_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyString Accent
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Accent_Public_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyString) null : Il2CppObjectPool.Get<ArticyString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138720, XrefRangeEnd = 138722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Accent_Public_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyString Personality
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 132977, RefRangeEnd = 132980, XrefRangeStart = 132977, XrefRangeEnd = 132980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Personality_Public_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Personality_Public_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyString Appearance
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 132982, RefRangeEnd = 132985, XrefRangeStart = 132982, XrefRangeEnd = 132985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_Appearance_Public_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_Appearance_Public_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint OwnerInstanceId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 68783, RefRangeEnd = 68785, XrefRangeStart = 68783, XrefRangeEnd = 68785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 138739, RefRangeEnd = 138740, XrefRangeStart = 138722, XrefRangeEnd = 138739, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 138764, RefRangeEnd = 138766, XrefRangeStart = 138740, XrefRangeEnd = 138764, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 138829, RefRangeEnd = 138831, XrefRangeStart = 138766, XrefRangeEnd = 138829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 138857, RefRangeEnd = 138859, XrefRangeStart = 138831, XrefRangeEnd = 138857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138859, XrefRangeEnd = 138879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultBasicCharacterFeatureFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultBasicCharacterFeatureFeature>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultBasicCharacterFeatureFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float mAge
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAge));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAge)) = value;
    }
  }

  public unsafe ArticyValueArticyString mSpecies
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mSpecies));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mSpecies), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyString mBornIn
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mBornIn));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mBornIn), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Sex mSex
  {
    get
    {
      return *(Sex*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mSex));
    }
    [param: In] set
    {
      *(Sex*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mSex)) = value;
    }
  }

  public unsafe ArticyValueArticyString mOccupation
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOccupation));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOccupation), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyString mAccent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAccent));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAccent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyString mPersonality
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mPersonality));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mPersonality), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyString mAppearance
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAppearance));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mAppearance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ulong mOwnerId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerId)) = value;
    }
  }

  public unsafe uint mOwnerInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultBasicCharacterFeatureFeature.NativeFieldInfoPtr_mOwnerInstanceId)) = value;
    }
  }
}
