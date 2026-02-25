// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.ObjectiveFeature
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
public class ObjectiveFeature(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mDescription;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAddItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCondition;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInstruction;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRemoveItem;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerInstanceId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Description_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Description_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AddItem_Public_get_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AddItem_Public_set_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Condition_Public_get_ArticyScriptCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Condition_Public_set_Void_ArticyScriptCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instruction_Public_get_ArticyScriptInstruction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Instruction_Public_set_Void_ArticyScriptInstruction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RemoveItem_Public_get_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RemoveItem_Public_set_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ObjectiveFeature()
  {
    Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (ObjectiveFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr);
    ObjectiveFeature.NativeFieldInfoPtr_mDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, nameof (mDescription));
    ObjectiveFeature.NativeFieldInfoPtr_mAddItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, nameof (mAddItem));
    ObjectiveFeature.NativeFieldInfoPtr_mCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, nameof (mCondition));
    ObjectiveFeature.NativeFieldInfoPtr_mInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, nameof (mInstruction));
    ObjectiveFeature.NativeFieldInfoPtr_mRemoveItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, nameof (mRemoveItem));
    ObjectiveFeature.NativeFieldInfoPtr_mOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, nameof (mOwnerId));
    ObjectiveFeature.NativeFieldInfoPtr_mOwnerInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, nameof (mOwnerInstanceId));
    ObjectiveFeature.NativeMethodInfoPtr_get_Description_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678874);
    ObjectiveFeature.NativeMethodInfoPtr_set_Description_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678875);
    ObjectiveFeature.NativeMethodInfoPtr_get_AddItem_Public_get_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678876);
    ObjectiveFeature.NativeMethodInfoPtr_set_AddItem_Public_set_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678877);
    ObjectiveFeature.NativeMethodInfoPtr_get_Condition_Public_get_ArticyScriptCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678878);
    ObjectiveFeature.NativeMethodInfoPtr_set_Condition_Public_set_Void_ArticyScriptCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678879);
    ObjectiveFeature.NativeMethodInfoPtr_get_Instruction_Public_get_ArticyScriptInstruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678880);
    ObjectiveFeature.NativeMethodInfoPtr_set_Instruction_Public_set_Void_ArticyScriptInstruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678881);
    ObjectiveFeature.NativeMethodInfoPtr_get_RemoveItem_Public_get_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678882);
    ObjectiveFeature.NativeMethodInfoPtr_set_RemoveItem_Public_set_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678883);
    ObjectiveFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678884);
    ObjectiveFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678885);
    ObjectiveFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678886);
    ObjectiveFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678887);
    ObjectiveFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678888);
    ObjectiveFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678889);
    ObjectiveFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678890);
    ObjectiveFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678891);
    ObjectiveFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr, 100678892);
  }

  public unsafe ArticyMultiLanguageString Description
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 136200, RefRangeEnd = 136213, XrefRangeStart = 136200, XrefRangeEnd = 136213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_get_Description_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_set_Description_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyObject AddItem
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139295, XrefRangeEnd = 139297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_get_AddItem_Public_get_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139297, XrefRangeEnd = 139307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_set_AddItem_Public_set_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyScriptCondition Condition
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 139308, RefRangeEnd = 139312, XrefRangeStart = 139307, XrefRangeEnd = 139308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_get_Condition_Public_get_ArticyScriptCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyScriptCondition) null : Il2CppObjectPool.Get<ArticyScriptCondition>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 139319, RefRangeEnd = 139320, XrefRangeStart = 139312, XrefRangeEnd = 139319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_set_Condition_Public_set_Void_ArticyScriptCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyScriptInstruction Instruction
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 136266, RefRangeEnd = 136271, XrefRangeStart = 136266, XrefRangeEnd = 136271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_get_Instruction_Public_get_ArticyScriptInstruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyScriptInstruction) null : Il2CppObjectPool.Get<ArticyScriptInstruction>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 139327, RefRangeEnd = 139328, XrefRangeStart = 139320, XrefRangeEnd = 139327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_set_Instruction_Public_set_Void_ArticyScriptInstruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyObject RemoveItem
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_get_RemoveItem_Public_get_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139328, XrefRangeEnd = 139338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_set_RemoveItem_Public_set_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OwnerId
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 139338, RefRangeEnd = 139339, XrefRangeStart = 139338, XrefRangeEnd = 139338, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139365, RefRangeEnd = 139366, XrefRangeStart = 139339, XrefRangeEnd = 139365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139390, RefRangeEnd = 139391, XrefRangeStart = 139366, XrefRangeEnd = 139390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139423, RefRangeEnd = 139424, XrefRangeStart = 139391, XrefRangeEnd = 139423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139440, RefRangeEnd = 139441, XrefRangeStart = 139424, XrefRangeEnd = 139440, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139441, XrefRangeEnd = 139461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ObjectiveFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectiveFeature>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ObjectiveFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyMultiLanguageString mDescription
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mDescription));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mDescription), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyObject mAddItem
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mAddItem));
      return num == System.IntPtr.Zero ? (ArticyValueArticyObject) null : Il2CppObjectPool.Get<ArticyValueArticyObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mAddItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyScriptCondition mCondition
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mCondition));
      return num == System.IntPtr.Zero ? (ArticyValueArticyScriptCondition) null : Il2CppObjectPool.Get<ArticyValueArticyScriptCondition>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyScriptInstruction mInstruction
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mInstruction));
      return num == System.IntPtr.Zero ? (ArticyValueArticyScriptInstruction) null : Il2CppObjectPool.Get<ArticyValueArticyScriptInstruction>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mInstruction), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyObject mRemoveItem
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mRemoveItem));
      return num == System.IntPtr.Zero ? (ArticyValueArticyObject) null : Il2CppObjectPool.Get<ArticyValueArticyObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mRemoveItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ulong mOwnerId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mOwnerId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mOwnerId)) = value;
    }
  }

  public unsafe uint mOwnerInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mOwnerInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectiveFeature.NativeFieldInfoPtr_mOwnerInstanceId)) = value;
    }
  }
}
