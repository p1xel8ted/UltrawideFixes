// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.FSMGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using XNode;

#nullable disable
namespace SadCatStudios.FSM;

public class FSMGraph(IntPtr pointer) : NodeGraph(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_initNode;
  private static readonly IntPtr NativeFieldInfoPtr_state;
  private static readonly IntPtr NativeFieldInfoPtr_ability;
  private static readonly IntPtr NativeFieldInfoPtr_continueOnSelfEnter;
  private static readonly IntPtr NativeMethodInfoPtr_get_InitNode_Public_get_InitNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_State_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Ability_Public_get_Abilities_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ContinueOnSelfEnter_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FSMGraph()
  {
    Il2CppClassPointerStore<FSMGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (FSMGraph));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr);
    FSMGraph.NativeFieldInfoPtr_initNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, nameof (initNode));
    FSMGraph.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, nameof (state));
    FSMGraph.NativeFieldInfoPtr_ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, nameof (ability));
    FSMGraph.NativeFieldInfoPtr_continueOnSelfEnter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, nameof (continueOnSelfEnter));
    FSMGraph.NativeMethodInfoPtr_get_InitNode_Public_get_InitNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, 100673243);
    FSMGraph.NativeMethodInfoPtr_get_State_Public_get_State_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, 100673244);
    FSMGraph.NativeMethodInfoPtr_get_Ability_Public_get_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, 100673245);
    FSMGraph.NativeMethodInfoPtr_get_ContinueOnSelfEnter_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, 100673246);
    FSMGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr, 100673247);
  }

  public unsafe InitNode InitNode
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FSMGraph.NativeMethodInfoPtr_get_InitNode_Public_get_InitNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (InitNode) null : Il2CppObjectPool.Get<InitNode>(num3);
    }
  }

  public unsafe State State
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FSMGraph.NativeMethodInfoPtr_get_State_Public_get_State_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (State) null : Il2CppObjectPool.Get<State>(num3);
    }
  }

  public unsafe Abilities Ability
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FSMGraph.NativeMethodInfoPtr_get_Ability_Public_get_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Abilities*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool ContinueOnSelfEnter
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 79543, RefRangeEnd = 79544, XrefRangeStart = 79543, XrefRangeEnd = 79544, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FSMGraph.NativeMethodInfoPtr_get_ContinueOnSelfEnter_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109029, XrefRangeEnd = 109030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FSMGraph()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FSMGraph>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FSMGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InitNode initNode
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraph.NativeFieldInfoPtr_initNode));
      return num == IntPtr.Zero ? (InitNode) null : Il2CppObjectPool.Get<InitNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FSMGraph.NativeFieldInfoPtr_initNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe State state
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraph.NativeFieldInfoPtr_state));
      return num == IntPtr.Zero ? (State) null : Il2CppObjectPool.Get<State>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FSMGraph.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Abilities ability
  {
    get
    {
      return *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraph.NativeFieldInfoPtr_ability));
    }
    [param: In] set
    {
      *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraph.NativeFieldInfoPtr_ability)) = value;
    }
  }

  public unsafe bool continueOnSelfEnter
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraph.NativeFieldInfoPtr_continueOnSelfEnter));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FSMGraph.NativeFieldInfoPtr_continueOnSelfEnter)) = value;
    }
  }
}
