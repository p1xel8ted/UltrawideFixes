// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.StateOverride
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.FSM;

public class StateOverride(IntPtr pointer) : SerializedScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_enterOverride;
  private static readonly IntPtr NativeFieldInfoPtr_exitOverride;
  private static readonly IntPtr NativeFieldInfoPtr_clipsOverride;
  private static readonly IntPtr NativeFieldInfoPtr_floatsOverride;
  private static readonly IntPtr NativeFieldInfoPtr_restrictedAbilities;
  private static readonly IntPtr NativeMethodInfoPtr_get_EnterOverride_Public_get_TransitionOverride_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ExitOverride_Public_get_TransitionOverride_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_ClipsOverride_Public_get_ClipsOverride_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_FloatsOverride_Public_get_FloatsOverride_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_RestrictedAbilities_Public_get_Abilities_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static StateOverride()
  {
    Il2CppClassPointerStore<StateOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (StateOverride));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StateOverride>.NativeClassPtr);
    StateOverride.NativeFieldInfoPtr_enterOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, nameof (enterOverride));
    StateOverride.NativeFieldInfoPtr_exitOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, nameof (exitOverride));
    StateOverride.NativeFieldInfoPtr_clipsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, nameof (clipsOverride));
    StateOverride.NativeFieldInfoPtr_floatsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, nameof (floatsOverride));
    StateOverride.NativeFieldInfoPtr_restrictedAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, nameof (restrictedAbilities));
    StateOverride.NativeMethodInfoPtr_get_EnterOverride_Public_get_TransitionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, 100673207);
    StateOverride.NativeMethodInfoPtr_get_ExitOverride_Public_get_TransitionOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, 100673208);
    StateOverride.NativeMethodInfoPtr_get_ClipsOverride_Public_get_ClipsOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, 100673209);
    StateOverride.NativeMethodInfoPtr_get_FloatsOverride_Public_get_FloatsOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, 100673210);
    StateOverride.NativeMethodInfoPtr_get_RestrictedAbilities_Public_get_Abilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, 100673211);
    StateOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StateOverride>.NativeClassPtr, 100673212);
  }

  public unsafe TransitionOverride EnterOverride
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64621, RefRangeEnd = 64622, XrefRangeStart = 64621, XrefRangeEnd = 64622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateOverride.NativeMethodInfoPtr_get_EnterOverride_Public_get_TransitionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (TransitionOverride) null : Il2CppObjectPool.Get<TransitionOverride>(num3);
    }
  }

  public unsafe TransitionOverride ExitOverride
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64622, RefRangeEnd = 64623, XrefRangeStart = 64622, XrefRangeEnd = 64623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateOverride.NativeMethodInfoPtr_get_ExitOverride_Public_get_TransitionOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (TransitionOverride) null : Il2CppObjectPool.Get<TransitionOverride>(num3);
    }
  }

  public unsafe ClipsOverride ClipsOverride
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 64623, RefRangeEnd = 64624, XrefRangeStart = 64623, XrefRangeEnd = 64624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateOverride.NativeMethodInfoPtr_get_ClipsOverride_Public_get_ClipsOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ClipsOverride) null : Il2CppObjectPool.Get<ClipsOverride>(num3);
    }
  }

  public unsafe FloatsOverride FloatsOverride
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateOverride.NativeMethodInfoPtr_get_FloatsOverride_Public_get_FloatsOverride_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (FloatsOverride) null : Il2CppObjectPool.Get<FloatsOverride>(num3);
    }
  }

  public unsafe Abilities RestrictedAbilities
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StateOverride.NativeMethodInfoPtr_get_RestrictedAbilities_Public_get_Abilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Abilities*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StateOverride()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StateOverride>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StateOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TransitionOverride enterOverride
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_enterOverride));
      return num == IntPtr.Zero ? (TransitionOverride) null : Il2CppObjectPool.Get<TransitionOverride>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_enterOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TransitionOverride exitOverride
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_exitOverride));
      return num == IntPtr.Zero ? (TransitionOverride) null : Il2CppObjectPool.Get<TransitionOverride>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_exitOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ClipsOverride clipsOverride
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_clipsOverride));
      return num == IntPtr.Zero ? (ClipsOverride) null : Il2CppObjectPool.Get<ClipsOverride>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_clipsOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FloatsOverride floatsOverride
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_floatsOverride));
      return num == IntPtr.Zero ? (FloatsOverride) null : Il2CppObjectPool.Get<FloatsOverride>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_floatsOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Abilities restrictedAbilities
  {
    get
    {
      return *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_restrictedAbilities));
    }
    [param: In] set
    {
      *(Abilities*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StateOverride.NativeFieldInfoPtr_restrictedAbilities)) = value;
    }
  }
}
