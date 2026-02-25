// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.QuestProgressFeature
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
public class QuestProgressFeature(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLongObjective;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCondition;
  private static readonly System.IntPtr NativeFieldInfoPtr_mShortObjective;
  private static readonly System.IntPtr NativeFieldInfoPtr_mMainStoryQuest;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerInstanceId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_LongObjective_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LongObjective_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Condition_Public_get_ArticyScriptCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Condition_Public_set_Void_ArticyScriptCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ShortObjective_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ShortObjective_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MainStoryQuest_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MainStoryQuest_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static QuestProgressFeature()
  {
    Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (QuestProgressFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr);
    QuestProgressFeature.NativeFieldInfoPtr_mLongObjective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, nameof (mLongObjective));
    QuestProgressFeature.NativeFieldInfoPtr_mCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, nameof (mCondition));
    QuestProgressFeature.NativeFieldInfoPtr_mShortObjective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, nameof (mShortObjective));
    QuestProgressFeature.NativeFieldInfoPtr_mMainStoryQuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, nameof (mMainStoryQuest));
    QuestProgressFeature.NativeFieldInfoPtr_mOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, nameof (mOwnerId));
    QuestProgressFeature.NativeFieldInfoPtr_mOwnerInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, nameof (mOwnerInstanceId));
    QuestProgressFeature.NativeMethodInfoPtr_get_LongObjective_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678960);
    QuestProgressFeature.NativeMethodInfoPtr_set_LongObjective_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678961);
    QuestProgressFeature.NativeMethodInfoPtr_get_Condition_Public_get_ArticyScriptCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678962);
    QuestProgressFeature.NativeMethodInfoPtr_set_Condition_Public_set_Void_ArticyScriptCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678963);
    QuestProgressFeature.NativeMethodInfoPtr_get_ShortObjective_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678964);
    QuestProgressFeature.NativeMethodInfoPtr_set_ShortObjective_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678965);
    QuestProgressFeature.NativeMethodInfoPtr_get_MainStoryQuest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678966);
    QuestProgressFeature.NativeMethodInfoPtr_set_MainStoryQuest_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678967);
    QuestProgressFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678968);
    QuestProgressFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678969);
    QuestProgressFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678970);
    QuestProgressFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678971);
    QuestProgressFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678972);
    QuestProgressFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678973);
    QuestProgressFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678974);
    QuestProgressFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678975);
    QuestProgressFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr, 100678976);
  }

  public unsafe ArticyMultiLanguageString LongObjective
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 136200, RefRangeEnd = 136213, XrefRangeStart = 136200, XrefRangeEnd = 136213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_get_LongObjective_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_set_LongObjective_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyScriptCondition Condition
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 136254, RefRangeEnd = 136257, XrefRangeStart = 136254, XrefRangeEnd = 136257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_get_Condition_Public_get_ArticyScriptCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyScriptCondition) null : Il2CppObjectPool.Get<ArticyScriptCondition>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 139800, RefRangeEnd = 139801, XrefRangeStart = 139793, XrefRangeEnd = 139800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_set_Condition_Public_set_Void_ArticyScriptCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyMultiLanguageString ShortObjective
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 138696, RefRangeEnd = 138701, XrefRangeStart = 138696, XrefRangeEnd = 138701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_get_ShortObjective_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_set_ShortObjective_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool MainStoryQuest
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_get_MainStoryQuest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 139812, RefRangeEnd = 139814, XrefRangeStart = 139801, XrefRangeEnd = 139812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_set_MainStoryQuest_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OwnerId
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 123407, RefRangeEnd = 123416, XrefRangeStart = 123407, XrefRangeEnd = 123416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 139832, RefRangeEnd = 139834, XrefRangeStart = 139814, XrefRangeEnd = 139832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139834, XrefRangeEnd = 139850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139873, RefRangeEnd = 139874, XrefRangeStart = 139850, XrefRangeEnd = 139873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139874, XrefRangeEnd = 139887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139887, XrefRangeEnd = 139899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe QuestProgressFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestProgressFeature>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QuestProgressFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyMultiLanguageString mLongObjective
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mLongObjective));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mLongObjective), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyScriptCondition mCondition
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mCondition));
      return num == System.IntPtr.Zero ? (ArticyValueArticyScriptCondition) null : Il2CppObjectPool.Get<ArticyValueArticyScriptCondition>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mCondition), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyMultiLanguageString mShortObjective
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mShortObjective));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mShortObjective), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool mMainStoryQuest
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mMainStoryQuest));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mMainStoryQuest)) = value;
    }
  }

  public unsafe ulong mOwnerId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mOwnerId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mOwnerId)) = value;
    }
  }

  public unsafe uint mOwnerInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mOwnerInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestProgressFeature.NativeFieldInfoPtr_mOwnerInstanceId)) = value;
    }
  }
}
