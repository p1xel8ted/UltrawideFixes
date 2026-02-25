// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.DialogueFragment
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Replaced;

public class DialogueFragment(System.IntPtr pointer) : ArticyObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mMenuText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mStageDirections;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSpeaker;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSplitHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_mColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_mText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mExternalId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_mZIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_mShortId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInputPins;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOutputPins;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MenuText_Public_Virtual_Final_New_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MenuText_Public_Virtual_Final_New_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StageDirections_Public_Virtual_Final_New_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StageDirections_Public_Virtual_Final_New_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Speaker_Public_Virtual_Final_New_get_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Speaker_Public_Virtual_Final_New_set_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SplitHeight_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SplitHeight_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Public_Virtual_Final_New_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ExternalId_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ExternalId_Public_Virtual_Final_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ZIndex_Public_Virtual_Final_New_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ZIndex_Public_Virtual_Final_New_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Size_Public_Virtual_Final_New_get_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Size_Public_Virtual_Final_New_set_Void_Vector2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ShortId_Public_Virtual_Final_New_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ShortId_Public_Virtual_Final_New_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InputPins_Public_get_List_1_InputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InputPins_Public_set_Void_List_1_InputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutputPins_Public_get_List_1_OutputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutputPins_Public_set_Void_List_1_OutputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputPins_Public_Virtual_Final_New_List_1_IInputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOutputPins_Public_Virtual_Final_New_List_1_IOutputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DialogueFragment()
  {
    Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (DialogueFragment));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr);
    DialogueFragment.NativeFieldInfoPtr_mMenuText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mMenuText));
    DialogueFragment.NativeFieldInfoPtr_mStageDirections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mStageDirections));
    DialogueFragment.NativeFieldInfoPtr_mSpeaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mSpeaker));
    DialogueFragment.NativeFieldInfoPtr_mSplitHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mSplitHeight));
    DialogueFragment.NativeFieldInfoPtr_mColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mColor));
    DialogueFragment.NativeFieldInfoPtr_mText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mText));
    DialogueFragment.NativeFieldInfoPtr_mExternalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mExternalId));
    DialogueFragment.NativeFieldInfoPtr_mPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mPosition));
    DialogueFragment.NativeFieldInfoPtr_mZIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mZIndex));
    DialogueFragment.NativeFieldInfoPtr_mSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mSize));
    DialogueFragment.NativeFieldInfoPtr_mShortId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mShortId));
    DialogueFragment.NativeFieldInfoPtr_mInputPins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mInputPins));
    DialogueFragment.NativeFieldInfoPtr_mOutputPins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, nameof (mOutputPins));
    DialogueFragment.NativeMethodInfoPtr_get_MenuText_Public_Virtual_Final_New_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678161);
    DialogueFragment.NativeMethodInfoPtr_set_MenuText_Public_Virtual_Final_New_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678162);
    DialogueFragment.NativeMethodInfoPtr_get_StageDirections_Public_Virtual_Final_New_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678163);
    DialogueFragment.NativeMethodInfoPtr_set_StageDirections_Public_Virtual_Final_New_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678164);
    DialogueFragment.NativeMethodInfoPtr_get_Speaker_Public_Virtual_Final_New_get_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678165);
    DialogueFragment.NativeMethodInfoPtr_set_Speaker_Public_Virtual_Final_New_set_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678166);
    DialogueFragment.NativeMethodInfoPtr_get_SplitHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678167);
    DialogueFragment.NativeMethodInfoPtr_set_SplitHeight_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678168);
    DialogueFragment.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678169);
    DialogueFragment.NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678170);
    DialogueFragment.NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678171);
    DialogueFragment.NativeMethodInfoPtr_set_Text_Public_Virtual_Final_New_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678172);
    DialogueFragment.NativeMethodInfoPtr_get_ExternalId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678173);
    DialogueFragment.NativeMethodInfoPtr_set_ExternalId_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678174);
    DialogueFragment.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678175);
    DialogueFragment.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678176);
    DialogueFragment.NativeMethodInfoPtr_get_ZIndex_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678177);
    DialogueFragment.NativeMethodInfoPtr_set_ZIndex_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678178);
    DialogueFragment.NativeMethodInfoPtr_get_Size_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678179);
    DialogueFragment.NativeMethodInfoPtr_set_Size_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678180);
    DialogueFragment.NativeMethodInfoPtr_get_ShortId_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678181);
    DialogueFragment.NativeMethodInfoPtr_set_ShortId_Public_Virtual_Final_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678182);
    DialogueFragment.NativeMethodInfoPtr_get_InputPins_Public_get_List_1_InputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678183);
    DialogueFragment.NativeMethodInfoPtr_set_InputPins_Public_set_Void_List_1_InputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678184);
    DialogueFragment.NativeMethodInfoPtr_get_OutputPins_Public_get_List_1_OutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678185);
    DialogueFragment.NativeMethodInfoPtr_set_OutputPins_Public_set_Void_List_1_OutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678186);
    DialogueFragment.NativeMethodInfoPtr_GetInputPins_Public_Virtual_Final_New_List_1_IInputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678187);
    DialogueFragment.NativeMethodInfoPtr_GetOutputPins_Public_Virtual_Final_New_List_1_IOutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678188);
    DialogueFragment.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678189);
    DialogueFragment.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678190);
    DialogueFragment.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678191);
    DialogueFragment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr, 100678192);
  }

  public virtual unsafe ArticyMultiLanguageString MenuText
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 132977, RefRangeEnd = 132980, XrefRangeStart = 132977, XrefRangeEnd = 132980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_MenuText_Public_Virtual_Final_New_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_MenuText_Public_Virtual_Final_New_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyString StageDirections
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 132982, RefRangeEnd = 132985, XrefRangeStart = 132982, XrefRangeEnd = 132985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_StageDirections_Public_Virtual_Final_New_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_StageDirections_Public_Virtual_Final_New_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyObject Speaker
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 134457, RefRangeEnd = 134458, XrefRangeStart = 134455, XrefRangeEnd = 134457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_Speaker_Public_Virtual_Final_New_get_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134458, XrefRangeEnd = 134468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_Speaker_Public_Virtual_Final_New_set_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float SplitHeight
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_SplitHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 134479, RefRangeEnd = 134480, XrefRangeStart = 134468, XrefRangeEnd = 134479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_SplitHeight_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Color Color
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 134492, RefRangeEnd = 134493, XrefRangeStart = 134480, XrefRangeEnd = 134492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyMultiLanguageString Text
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 133011, RefRangeEnd = 133012, XrefRangeStart = 133011, XrefRangeEnd = 133012, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_Text_Public_Virtual_Final_New_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe string ExternalId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_ExternalId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 134500, RefRangeEnd = 134502, XrefRangeStart = 134493, XrefRangeEnd = 134500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_ExternalId_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Vector2 Position
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 134514, RefRangeEnd = 134516, XrefRangeStart = 134502, XrefRangeEnd = 134514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe float ZIndex
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_ZIndex_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 134527, RefRangeEnd = 134529, XrefRangeStart = 134516, XrefRangeEnd = 134527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_ZIndex_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Vector2 Size
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_Size_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 134541, RefRangeEnd = 134543, XrefRangeStart = 134529, XrefRangeEnd = 134541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_Size_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe uint ShortId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_ShortId_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 134554, RefRangeEnd = 134556, XrefRangeStart = 134543, XrefRangeEnd = 134554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_ShortId_Public_Virtual_Final_New_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<InputPin> InputPins
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 132567, RefRangeEnd = 132572, XrefRangeStart = 132567, XrefRangeEnd = 132572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_InputPins_Public_get_List_1_InputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<InputPin>) null : Il2CppObjectPool.Get<List<InputPin>>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 134563, RefRangeEnd = 134566, XrefRangeStart = 134556, XrefRangeEnd = 134563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_InputPins_Public_set_Void_List_1_InputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<OutputPin> OutputPins
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134566, XrefRangeEnd = 134567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_get_OutputPins_Public_get_List_1_OutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<OutputPin>) null : Il2CppObjectPool.Get<List<OutputPin>>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 134574, RefRangeEnd = 134577, XrefRangeStart = 134567, XrefRangeEnd = 134574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_set_OutputPins_Public_set_Void_List_1_OutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134577, XrefRangeEnd = 134584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<IInputPin> GetInputPins()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_GetInputPins_Public_Virtual_Final_New_List_1_IInputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IInputPin>) null : Il2CppObjectPool.Get<List<IInputPin>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134584, XrefRangeEnd = 134591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<IOutputPin> GetOutputPins()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr_GetOutputPins_Public_Virtual_Final_New_List_1_IOutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IOutputPin>) null : Il2CppObjectPool.Get<List<IOutputPin>>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134673, RefRangeEnd = 134675, XrefRangeStart = 134591, XrefRangeEnd = 134673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DialogueFragment.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134759, RefRangeEnd = 134761, XrefRangeStart = 134675, XrefRangeEnd = 134759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DialogueFragment.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134820, RefRangeEnd = 134822, XrefRangeStart = 134761, XrefRangeEnd = 134820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DialogueFragment.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 134850, RefRangeEnd = 134852, XrefRangeStart = 134822, XrefRangeEnd = 134850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DialogueFragment()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueFragment>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DialogueFragment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyMultiLanguageString mMenuText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mMenuText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mMenuText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyString mStageDirections
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mStageDirections));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mStageDirections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyObject mSpeaker
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mSpeaker));
      return num == System.IntPtr.Zero ? (ArticyValueArticyObject) null : Il2CppObjectPool.Get<ArticyValueArticyObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mSpeaker), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float mSplitHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mSplitHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mSplitHeight)) = value;
    }
  }

  public unsafe Color mColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mColor)) = value;
    }
  }

  public unsafe ArticyValueArticyMultiLanguageString mText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mExternalId
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mExternalId)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mExternalId), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Vector2 mPosition
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mPosition));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mPosition)) = value;
    }
  }

  public unsafe float mZIndex
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mZIndex));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mZIndex)) = value;
    }
  }

  public unsafe Vector2 mSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mSize)) = value;
    }
  }

  public unsafe uint mShortId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mShortId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mShortId)) = value;
    }
  }

  public unsafe ArticyValueListInputPin mInputPins
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mInputPins));
      return num == System.IntPtr.Zero ? (ArticyValueListInputPin) null : Il2CppObjectPool.Get<ArticyValueListInputPin>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mInputPins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueListOutputPin mOutputPins
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mOutputPins));
      return num == System.IntPtr.Zero ? (ArticyValueListOutputPin) null : Il2CppObjectPool.Get<ArticyValueListOutputPin>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DialogueFragment.NativeFieldInfoPtr_mOutputPins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
