// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Hub
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

public class Hub(System.IntPtr pointer) : ArticyObject(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mDisplayName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_mText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mExternalId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mPosition;
  private static readonly System.IntPtr NativeFieldInfoPtr_mZIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_mShortId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInputPins;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOutputPins;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DisplayName_Public_Virtual_Final_New_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DisplayName_Public_Virtual_Final_New_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0;
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

  static Hub()
  {
    Il2CppClassPointerStore<Hub>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (Hub));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hub>.NativeClassPtr);
    Hub.NativeFieldInfoPtr_mDisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mDisplayName));
    Hub.NativeFieldInfoPtr_mColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mColor));
    Hub.NativeFieldInfoPtr_mText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mText));
    Hub.NativeFieldInfoPtr_mExternalId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mExternalId));
    Hub.NativeFieldInfoPtr_mPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mPosition));
    Hub.NativeFieldInfoPtr_mZIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mZIndex));
    Hub.NativeFieldInfoPtr_mSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mSize));
    Hub.NativeFieldInfoPtr_mShortId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mShortId));
    Hub.NativeFieldInfoPtr_mInputPins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mInputPins));
    Hub.NativeFieldInfoPtr_mOutputPins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hub>.NativeClassPtr, nameof (mOutputPins));
    Hub.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_Final_New_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678300);
    Hub.NativeMethodInfoPtr_set_DisplayName_Public_Virtual_Final_New_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678301);
    Hub.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678302);
    Hub.NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678303);
    Hub.NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678304);
    Hub.NativeMethodInfoPtr_set_Text_Public_Virtual_Final_New_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678305);
    Hub.NativeMethodInfoPtr_get_ExternalId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678306);
    Hub.NativeMethodInfoPtr_set_ExternalId_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678307);
    Hub.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678308);
    Hub.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678309);
    Hub.NativeMethodInfoPtr_get_ZIndex_Public_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678310);
    Hub.NativeMethodInfoPtr_set_ZIndex_Public_Virtual_Final_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678311);
    Hub.NativeMethodInfoPtr_get_Size_Public_Virtual_Final_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678312);
    Hub.NativeMethodInfoPtr_set_Size_Public_Virtual_Final_New_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678313);
    Hub.NativeMethodInfoPtr_get_ShortId_Public_Virtual_Final_New_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678314);
    Hub.NativeMethodInfoPtr_set_ShortId_Public_Virtual_Final_New_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678315);
    Hub.NativeMethodInfoPtr_get_InputPins_Public_get_List_1_InputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678316);
    Hub.NativeMethodInfoPtr_set_InputPins_Public_set_Void_List_1_InputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678317);
    Hub.NativeMethodInfoPtr_get_OutputPins_Public_get_List_1_OutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678318);
    Hub.NativeMethodInfoPtr_set_OutputPins_Public_set_Void_List_1_OutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678319);
    Hub.NativeMethodInfoPtr_GetInputPins_Public_Virtual_Final_New_List_1_IInputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678320);
    Hub.NativeMethodInfoPtr_GetOutputPins_Public_Virtual_Final_New_List_1_IOutputPin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678321);
    Hub.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678322);
    Hub.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678323);
    Hub.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678324);
    Hub.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hub>.NativeClassPtr, 100678325);
  }

  public virtual unsafe ArticyString DisplayName
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 132977, RefRangeEnd = 132980, XrefRangeStart = 132977, XrefRangeEnd = 132980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_DisplayName_Public_Virtual_Final_New_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_DisplayName_Public_Virtual_Final_New_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 135894, RefRangeEnd = 135896, XrefRangeStart = 135882, XrefRangeEnd = 135894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyString Text
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_Text_Public_Virtual_Final_New_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_Text_Public_Virtual_Final_New_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe string ExternalId
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_ExternalId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135905, XrefRangeStart = 135896, XrefRangeEnd = 135903, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_ExternalId_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_Position_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 135917, RefRangeEnd = 135919, XrefRangeStart = 135905, XrefRangeEnd = 135917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_Position_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_ZIndex_Public_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 135930, RefRangeEnd = 135932, XrefRangeStart = 135919, XrefRangeEnd = 135930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_ZIndex_Public_Virtual_Final_New_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_Size_Public_Virtual_Final_New_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 135944, RefRangeEnd = 135946, XrefRangeStart = 135932, XrefRangeEnd = 135944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_Size_Public_Virtual_Final_New_set_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_ShortId_Public_Virtual_Final_New_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 135957, RefRangeEnd = 135959, XrefRangeStart = 135946, XrefRangeEnd = 135957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_ShortId_Public_Virtual_Final_New_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<InputPin> InputPins
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135959, XrefRangeEnd = 135960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_InputPins_Public_get_List_1_InputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<InputPin>) null : Il2CppObjectPool.Get<List<InputPin>>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 135967, RefRangeEnd = 135970, XrefRangeStart = 135960, XrefRangeEnd = 135967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_InputPins_Public_set_Void_List_1_InputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<OutputPin> OutputPins
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_get_OutputPins_Public_get_List_1_OutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<OutputPin>) null : Il2CppObjectPool.Get<List<OutputPin>>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 135977, RefRangeEnd = 135980, XrefRangeStart = 135970, XrefRangeEnd = 135977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_set_OutputPins_Public_set_Void_List_1_OutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135980, XrefRangeEnd = 135987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<IInputPin> GetInputPins()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_GetInputPins_Public_Virtual_Final_New_List_1_IInputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IInputPin>) null : Il2CppObjectPool.Get<List<IInputPin>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135987, XrefRangeEnd = 135994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<IOutputPin> GetOutputPins()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr_GetOutputPins_Public_Virtual_Final_New_List_1_IOutputPin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IOutputPin>) null : Il2CppObjectPool.Get<List<IOutputPin>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 135994, XrefRangeEnd = 136059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Hub.NativeMethodInfoPtr_CloneProperties_Protected_Virtual_Void_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136059, XrefRangeEnd = 136126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Hub.NativeMethodInfoPtr_setProp_Public_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136126, XrefRangeEnd = 136180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Hub.NativeMethodInfoPtr_getProp_Public_Virtual_ScriptDataProxy_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136180, XrefRangeEnd = 136200, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Hub()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hub>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Hub.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyString mDisplayName
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mDisplayName));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mDisplayName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color mColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mColor)) = value;
    }
  }

  public unsafe ArticyValueArticyString mText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mExternalId
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mExternalId)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mExternalId), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Vector2 mPosition
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mPosition));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mPosition)) = value;
    }
  }

  public unsafe float mZIndex
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mZIndex));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mZIndex)) = value;
    }
  }

  public unsafe Vector2 mSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mSize)) = value;
    }
  }

  public unsafe uint mShortId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mShortId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mShortId)) = value;
    }
  }

  public unsafe ArticyValueListInputPin mInputPins
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mInputPins));
      return num == System.IntPtr.Zero ? (ArticyValueListInputPin) null : Il2CppObjectPool.Get<ArticyValueListInputPin>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mInputPins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueListOutputPin mOutputPins
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mOutputPins));
      return num == System.IntPtr.Zero ? (ArticyValueListOutputPin) null : Il2CppObjectPool.Get<ArticyValueListOutputPin>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Hub.NativeFieldInfoPtr_mOutputPins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
