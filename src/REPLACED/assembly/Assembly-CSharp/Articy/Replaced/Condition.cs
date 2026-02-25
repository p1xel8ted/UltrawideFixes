// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Condition
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

public class Condition(System.IntPtr pointer) : ArticyObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mDisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mExternalId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_mZIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_mShortId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mExpression;
  private static readonly System.IntPtr NativeFieldInfoPtr_mColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInputPins;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOutputPins;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_Final_New_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_Virtual_Final_New_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Public_Virtual_Final_New_set_Void_ArticyString_0;
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
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Expression_Public_get_ArticyScriptCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Expression_Public_set_Void_ArticyScriptCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_InputPins_Public_get_List_1_InputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_InputPins_Public_set_Void_List_1_InputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OutputPins_Public_get_List_1_OutputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OutputPins_Public_set_Void_List_1_OutputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInputPins_Public_Virtual_Final_New_List_1_IInputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOutputPins_Public_Virtual_Final_New_List_1_IOutputPin_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Condition()
  {
    Il2CppClassPointerStore<Condition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (Condition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Condition>.NativeClassPtr);
    Condition.NativeFieldInfoPtr_mDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mDisplayName));
    Condition.NativeFieldInfoPtr_mText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mText));
    Condition.NativeFieldInfoPtr_mExternalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mExternalId));
    Condition.NativeFieldInfoPtr_mPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mPosition));
    Condition.NativeFieldInfoPtr_mZIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mZIndex));
    Condition.NativeFieldInfoPtr_mSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mSize));
    Condition.NativeFieldInfoPtr_mShortId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mShortId));
    Condition.NativeFieldInfoPtr_mExpression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mExpression));
    Condition.NativeFieldInfoPtr_mColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mColor));
    Condition.NativeFieldInfoPtr_mInputPins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mInputPins));
    Condition.NativeFieldInfoPtr_mOutputPins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Condition>.NativeClassPtr, nameof (mOutputPins));
    Condition.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_Final_New_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678074);
    Condition.NativeMethodInfoPtr_set_DisplayName_Public_Virtual_Final_New_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678075);
    Condition.NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678076);
    Condition.NativeMethodInfoPtr_set_Text_Public_Virtual_Final_New_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678077);
    Condition.NativeMethodInfoPtr_get_ExternalId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678078);
    Condition.NativeMethodInfoPtr_set_ExternalId_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678079);
    Condition.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678080);
    Condition.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678081);
    Condition.NativeMethodInfoPtr_get_ZIndex_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678082);
    Condition.NativeMethodInfoPtr_set_ZIndex_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678083);
    Condition.NativeMethodInfoPtr_get_Size_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678084);
    Condition.NativeMethodInfoPtr_set_Size_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678085);
    Condition.NativeMethodInfoPtr_get_ShortId_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678086);
    Condition.NativeMethodInfoPtr_set_ShortId_Public_Virtual_Final_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678087);
    Condition.NativeMethodInfoPtr_get_Expression_Public_get_ArticyScriptCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678088);
    Condition.NativeMethodInfoPtr_set_Expression_Public_set_Void_ArticyScriptCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678089);
    Condition.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678090);
    Condition.NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678091);
    Condition.NativeMethodInfoPtr_get_InputPins_Public_get_List_1_InputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678092);
    Condition.NativeMethodInfoPtr_set_InputPins_Public_set_Void_List_1_InputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678093);
    Condition.NativeMethodInfoPtr_get_OutputPins_Public_get_List_1_OutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678094);
    Condition.NativeMethodInfoPtr_set_OutputPins_Public_set_Void_List_1_OutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678095);
    Condition.NativeMethodInfoPtr_GetInputPins_Public_Virtual_Final_New_List_1_IInputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678096);
    Condition.NativeMethodInfoPtr_GetOutputPins_Public_Virtual_Final_New_List_1_IOutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678097);
    Condition.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678098);
    Condition.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678099);
    Condition.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678100);
    Condition.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678101);
    Condition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Condition>.NativeClassPtr, 100678102);
  }

  public virtual unsafe ArticyString DisplayName
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 132977, RefRangeEnd = 132980, XrefRangeStart = 132977, XrefRangeEnd = 132980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_Final_New_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_DisplayName_Public_Virtual_Final_New_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyString Text
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 132982, RefRangeEnd = 132985, XrefRangeStart = 132982, XrefRangeEnd = 132985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_Text_Public_Virtual_Final_New_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_ExternalId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 133608, RefRangeEnd = 133609, XrefRangeStart = 133601, XrefRangeEnd = 133608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_ExternalId_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 133621, RefRangeEnd = 133622, XrefRangeStart = 133609, XrefRangeEnd = 133621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_ZIndex_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 133633, RefRangeEnd = 133634, XrefRangeStart = 133622, XrefRangeEnd = 133633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_ZIndex_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_Size_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 133646, RefRangeEnd = 133647, XrefRangeStart = 133634, XrefRangeEnd = 133646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_Size_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_ShortId_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 133658, RefRangeEnd = 133659, XrefRangeStart = 133647, XrefRangeEnd = 133658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_ShortId_Public_Virtual_Final_New_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyScriptCondition Expression
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133659, XrefRangeEnd = 133660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_Expression_Public_get_ArticyScriptCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyScriptCondition) null : Il2CppObjectPool.Get<ArticyScriptCondition>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 133667, RefRangeEnd = 133668, XrefRangeStart = 133660, XrefRangeEnd = 133667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_Expression_Public_set_Void_ArticyScriptCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 133680, RefRangeEnd = 133682, XrefRangeStart = 133668, XrefRangeEnd = 133680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<InputPin> InputPins
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133682, XrefRangeEnd = 133683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_InputPins_Public_get_List_1_InputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<InputPin>) null : Il2CppObjectPool.Get<List<InputPin>>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 133690, RefRangeEnd = 133693, XrefRangeStart = 133683, XrefRangeEnd = 133690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_InputPins_Public_set_Void_List_1_InputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<OutputPin> OutputPins
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133693, XrefRangeEnd = 133694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_get_OutputPins_Public_get_List_1_OutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<OutputPin>) null : Il2CppObjectPool.Get<List<OutputPin>>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 133701, RefRangeEnd = 133704, XrefRangeStart = 133694, XrefRangeEnd = 133701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_set_OutputPins_Public_set_Void_List_1_OutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133704, XrefRangeEnd = 133711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<IInputPin> GetInputPins()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_GetInputPins_Public_Virtual_Final_New_List_1_IInputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IInputPin>) null : Il2CppObjectPool.Get<List<IInputPin>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133711, XrefRangeEnd = 133718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<IOutputPin> GetOutputPins()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_GetOutputPins_Public_Virtual_Final_New_List_1_IOutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IOutputPin>) null : Il2CppObjectPool.Get<List<IOutputPin>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133718, XrefRangeEnd = 133720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Evaluate(
    [Optional] IBaseScriptMethodProvider aMethodProvider,
    [Optional] IGlobalVariables aGlobalVariables)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133720, XrefRangeEnd = 133789, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Condition.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133789, XrefRangeEnd = 133838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Condition.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133838, XrefRangeEnd = 133895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Condition.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133895, XrefRangeEnd = 133919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Condition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Condition>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Condition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyString mDisplayName
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mDisplayName));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mDisplayName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyString mText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mExternalId
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mExternalId)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mExternalId), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Vector2 mPosition
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mPosition));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mPosition)) = value;
    }
  }

  public unsafe float mZIndex
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mZIndex));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mZIndex)) = value;
    }
  }

  public unsafe Vector2 mSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mSize)) = value;
    }
  }

  public unsafe uint mShortId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mShortId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mShortId)) = value;
    }
  }

  public unsafe ArticyValueArticyScriptCondition mExpression
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mExpression));
      return num == System.IntPtr.Zero ? (ArticyValueArticyScriptCondition) null : Il2CppObjectPool.Get<ArticyValueArticyScriptCondition>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mExpression), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color mColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mColor)) = value;
    }
  }

  public unsafe ArticyValueListInputPin mInputPins
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mInputPins));
      return num == System.IntPtr.Zero ? (ArticyValueListInputPin) null : Il2CppObjectPool.Get<ArticyValueListInputPin>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mInputPins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueListOutputPin mOutputPins
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mOutputPins));
      return num == System.IntPtr.Zero ? (ArticyValueListOutputPin) null : Il2CppObjectPool.Get<ArticyValueListOutputPin>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Condition.NativeFieldInfoPtr_mOutputPins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
