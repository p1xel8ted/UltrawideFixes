// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.Utils.ArticyVariableCheat
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Sirenix.OdinInspector;
using System.Runtime.InteropServices;

#nullable disable
namespace Replaced.Scripts.Utils;

public class ArticyVariableCheat(System.IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedVariable;
  private static readonly System.IntPtr NativeFieldInfoPtr_selectedVariables;
  private static readonly System.IntPtr NativeFieldInfoPtr_ObjectiveWithInstruction;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVariables_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ObjectiveContents_Private_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddVariable_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_VariableList_Private_List_1_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyVariableCheat()
  {
    Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.Utils", nameof (ArticyVariableCheat));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr);
    ArticyVariableCheat.NativeFieldInfoPtr_selectedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr, nameof (selectedVariable));
    ArticyVariableCheat.NativeFieldInfoPtr_selectedVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr, nameof (selectedVariables));
    ArticyVariableCheat.NativeFieldInfoPtr_ObjectiveWithInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr, nameof (ObjectiveWithInstruction));
    ArticyVariableCheat.NativeMethodInfoPtr_SetVariables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr, 100670617);
    ArticyVariableCheat.NativeMethodInfoPtr_get_ObjectiveContents_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr, 100670618);
    ArticyVariableCheat.NativeMethodInfoPtr_AddVariable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr, 100670619);
    ArticyVariableCheat.NativeMethodInfoPtr_VariableList_Private_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr, 100670620);
    ArticyVariableCheat.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr, 100670621);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86639, XrefRangeEnd = 86670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVariables()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyVariableCheat.NativeMethodInfoPtr_SetVariables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string ObjectiveContents
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86670, XrefRangeEnd = 86676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyVariableCheat.NativeMethodInfoPtr_get_ObjectiveContents_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86676, XrefRangeEnd = 86734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddVariable()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyVariableCheat.NativeMethodInfoPtr_AddVariable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86734, XrefRangeEnd = 86785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe List<string> VariableList()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyVariableCheat.NativeMethodInfoPtr_VariableList_Private_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86785, XrefRangeEnd = 86792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyVariableCheat()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyVariableCheat>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyVariableCheat.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string selectedVariable
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyVariableCheat.NativeFieldInfoPtr_selectedVariable)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyVariableCheat.NativeFieldInfoPtr_selectedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Dictionary<string, Il2CppSystem.Object> selectedVariables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyVariableCheat.NativeFieldInfoPtr_selectedVariables));
      return num == System.IntPtr.Zero ? (Dictionary<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Dictionary<string, Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyVariableCheat.NativeFieldInfoPtr_selectedVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef ObjectiveWithInstruction
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyVariableCheat.NativeFieldInfoPtr_ObjectiveWithInstruction));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyVariableCheat.NativeFieldInfoPtr_ObjectiveWithInstruction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
