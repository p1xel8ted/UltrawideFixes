// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.ObjectiveFeatureConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity.Constraints;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.Features;

public class ObjectiveFeatureConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLoadedConstraints;
  private static readonly System.IntPtr NativeFieldInfoPtr_mDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAddItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCondition;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInstruction;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRemoveItem;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_TextConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AddItem_Public_get_ReferenceSlotConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Condition_Public_get_ScriptConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instruction_Public_get_ScriptConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoveItem_Public_get_ReferenceSlotConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ObjectiveFeatureConstraint()
  {
    Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (ObjectiveFeatureConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr);
    ObjectiveFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, nameof (mLoadedConstraints));
    ObjectiveFeatureConstraint.NativeFieldInfoPtr_mDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, nameof (mDescription));
    ObjectiveFeatureConstraint.NativeFieldInfoPtr_mAddItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, nameof (mAddItem));
    ObjectiveFeatureConstraint.NativeFieldInfoPtr_mCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, nameof (mCondition));
    ObjectiveFeatureConstraint.NativeFieldInfoPtr_mInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, nameof (mInstruction));
    ObjectiveFeatureConstraint.NativeFieldInfoPtr_mRemoveItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, nameof (mRemoveItem));
    ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_Description_Public_get_TextConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, 100678893);
    ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_AddItem_Public_get_ReferenceSlotConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, 100678894);
    ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_Condition_Public_get_ScriptConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, 100678895);
    ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_Instruction_Public_get_ScriptConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, 100678896);
    ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_RemoveItem_Public_get_ReferenceSlotConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, 100678897);
    ObjectiveFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, 100678898);
    ObjectiveFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr, 100678899);
  }

  public unsafe TextConstraint Description
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_Description_Public_get_TextConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num3);
    }
  }

  public unsafe ReferenceSlotConstraint AddItem
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_AddItem_Public_get_ReferenceSlotConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ReferenceSlotConstraint) null : Il2CppObjectPool.Get<ReferenceSlotConstraint>(num3);
    }
  }

  public unsafe ScriptConstraint Condition
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_Condition_Public_get_ScriptConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ScriptConstraint) null : Il2CppObjectPool.Get<ScriptConstraint>(num3);
    }
  }

  public unsafe ScriptConstraint Instruction
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_Instruction_Public_get_ScriptConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ScriptConstraint) null : Il2CppObjectPool.Get<ScriptConstraint>(num3);
    }
  }

  public unsafe ReferenceSlotConstraint RemoveItem
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeatureConstraint.NativeMethodInfoPtr_get_RemoveItem_Public_get_ReferenceSlotConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ReferenceSlotConstraint) null : Il2CppObjectPool.Get<ReferenceSlotConstraint>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139461, XrefRangeEnd = 139498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EnsureConstraints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ObjectiveFeatureConstraint.NativeMethodInfoPtr_EnsureConstraints_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ObjectiveFeatureConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectiveFeatureConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectiveFeatureConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool mLoadedConstraints
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mLoadedConstraints)) = value;
    }
  }

  public unsafe TextConstraint mDescription
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mDescription));
      return num == System.IntPtr.Zero ? (TextConstraint) null : Il2CppObjectPool.Get<TextConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ReferenceSlotConstraint mAddItem
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mAddItem));
      return num == System.IntPtr.Zero ? (ReferenceSlotConstraint) null : Il2CppObjectPool.Get<ReferenceSlotConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mAddItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScriptConstraint mCondition
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mCondition));
      return num == System.IntPtr.Zero ? (ScriptConstraint) null : Il2CppObjectPool.Get<ScriptConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScriptConstraint mInstruction
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mInstruction));
      return num == System.IntPtr.Zero ? (ScriptConstraint) null : Il2CppObjectPool.Get<ScriptConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mInstruction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ReferenceSlotConstraint mRemoveItem
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mRemoveItem));
      return num == System.IntPtr.Zero ? (ReferenceSlotConstraint) null : Il2CppObjectPool.Get<ReferenceSlotConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeatureConstraint.NativeFieldInfoPtr_mRemoveItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
