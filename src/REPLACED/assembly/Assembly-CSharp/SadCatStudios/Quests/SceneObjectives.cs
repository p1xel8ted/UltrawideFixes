// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Quests.SceneObjectives
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using SadCatStudios.Foundation.Events;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Quests;

public class SceneObjectives(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_objectiveGroups;
  private static readonly System.IntPtr NativeFieldInfoPtr_pendingChanges;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventDisposable;
  private static readonly System.IntPtr NativeFieldInfoPtr_notificationCallbacksHolder;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StateChanged_Private_Void_GameStateChangedEvent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateObjective_Private_Void_ObjectiveGroup_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SceneObjectives()
  {
    Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Quests", nameof (SceneObjectives));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr);
    SceneObjectives.NativeFieldInfoPtr_objectiveGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, nameof (objectiveGroups));
    SceneObjectives.NativeFieldInfoPtr_pendingChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, nameof (pendingChanges));
    SceneObjectives.NativeFieldInfoPtr_eventDisposable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, nameof (eventDisposable));
    SceneObjectives.NativeFieldInfoPtr_notificationCallbacksHolder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, nameof (notificationCallbacksHolder));
    SceneObjectives.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, 100671512);
    SceneObjectives.NativeMethodInfoPtr_StateChanged_Private_Void_GameStateChangedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, 100671513);
    SceneObjectives.NativeMethodInfoPtr_EvaluateObjective_Private_Void_ObjectiveGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, 100671514);
    SceneObjectives.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, 100671515);
    SceneObjectives.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, 100671516);
    SceneObjectives.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, 100671517);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94718, XrefRangeEnd = 94736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneObjectives.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94736, XrefRangeEnd = 94754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StateChanged(GameStateChangedEvent e)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &e
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneObjectives.NativeMethodInfoPtr_StateChanged_Private_Void_GameStateChangedEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 94775, RefRangeEnd = 94778, XrefRangeStart = 94754, XrefRangeEnd = 94775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EvaluateObjective(SceneObjectives.ObjectiveGroup objGroup)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) objGroup)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneObjectives.NativeMethodInfoPtr_EvaluateObjective_Private_Void_ObjectiveGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94778, XrefRangeEnd = 94800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneObjectives.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94800, XrefRangeEnd = 94860, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneObjectives.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94860, XrefRangeEnd = 94873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneObjectives()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneObjectives.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<SceneObjectives.ObjectiveGroup> objectiveGroups
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.NativeFieldInfoPtr_objectiveGroups));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SceneObjectives.ObjectiveGroup>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SceneObjectives.ObjectiveGroup>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.NativeFieldInfoPtr_objectiveGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe HashSet<SceneObjectives.ObjectiveGroup> pendingChanges
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.NativeFieldInfoPtr_pendingChanges));
      return num == System.IntPtr.Zero ? (HashSet<SceneObjectives.ObjectiveGroup>) null : Il2CppObjectPool.Get<HashSet<SceneObjectives.ObjectiveGroup>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.NativeFieldInfoPtr_pendingChanges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.IDisposable eventDisposable
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.NativeFieldInfoPtr_eventDisposable));
      return num == System.IntPtr.Zero ? (Il2CppSystem.IDisposable) null : Il2CppObjectPool.Get<Il2CppSystem.IDisposable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.NativeFieldInfoPtr_eventDisposable), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<Il2CppSystem.ValueTuple<string, Il2CppSystem.Action<string, Il2CppSystem.Object>>> notificationCallbacksHolder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.NativeFieldInfoPtr_notificationCallbacksHolder));
      return num == System.IntPtr.Zero ? (List<Il2CppSystem.ValueTuple<string, Il2CppSystem.Action<string, Il2CppSystem.Object>>>) null : Il2CppObjectPool.Get<List<Il2CppSystem.ValueTuple<string, Il2CppSystem.Action<string, Il2CppSystem.Object>>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.NativeFieldInfoPtr_notificationCallbacksHolder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class ObjectiveData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ObjectiveReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_Actions;
    private static readonly System.IntPtr NativeFieldInfoPtr_UsedVariables;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ObjectiveData()
    {
      Il2CppClassPointerStore<SceneObjectives.ObjectiveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, nameof (ObjectiveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneObjectives.ObjectiveData>.NativeClassPtr);
      SceneObjectives.ObjectiveData.NativeFieldInfoPtr_ObjectiveReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.ObjectiveData>.NativeClassPtr, nameof (ObjectiveReference));
      SceneObjectives.ObjectiveData.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.ObjectiveData>.NativeClassPtr, nameof (Actions));
      SceneObjectives.ObjectiveData.NativeFieldInfoPtr_UsedVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.ObjectiveData>.NativeClassPtr, nameof (UsedVariables));
      SceneObjectives.ObjectiveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives.ObjectiveData>.NativeClassPtr, 100671518);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ObjectiveData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneObjectives.ObjectiveData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SceneObjectives.ObjectiveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe ArticyRef ObjectiveReference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.NativeFieldInfoPtr_ObjectiveReference));
        return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.NativeFieldInfoPtr_ObjectiveReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<SceneObjectives.ObjectiveData.ActionData> Actions
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.NativeFieldInfoPtr_Actions));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SceneObjectives.ObjectiveData.ActionData>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SceneObjectives.ObjectiveData.ActionData>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<string> UsedVariables
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.NativeFieldInfoPtr_UsedVariables));
        return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.NativeFieldInfoPtr_UsedVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum Action
    {
      None,
      Activate,
      Deactivate,
    }

    [Serializable]
    public class ActionData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Object;
      private static readonly System.IntPtr NativeFieldInfoPtr_Action;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      static ActionData()
      {
        Il2CppClassPointerStore<SceneObjectives.ObjectiveData.ActionData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneObjectives.ObjectiveData>.NativeClassPtr, nameof (ActionData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneObjectives.ObjectiveData.ActionData>.NativeClassPtr);
        SceneObjectives.ObjectiveData.ActionData.NativeFieldInfoPtr_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.ObjectiveData.ActionData>.NativeClassPtr, nameof (Object));
        SceneObjectives.ObjectiveData.ActionData.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.ObjectiveData.ActionData>.NativeClassPtr, nameof (Action));
        SceneObjectives.ObjectiveData.ActionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives.ObjectiveData.ActionData>.NativeClassPtr, 100671519);
      }

      [CallerCount(3004)]
      [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ActionData()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneObjectives.ObjectiveData.ActionData>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(SceneObjectives.ObjectiveData.ActionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }

      public unsafe GameObject Object
      {
        get
        {
          System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.ActionData.NativeFieldInfoPtr_Object));
          return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.ActionData.NativeFieldInfoPtr_Object), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SceneObjectives.ObjectiveData.Action Action
      {
        get
        {
          return *(SceneObjectives.ObjectiveData.Action*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.ActionData.NativeFieldInfoPtr_Action));
        }
        [param: In] set
        {
          *(SceneObjectives.ObjectiveData.Action*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveData.ActionData.NativeFieldInfoPtr_Action)) = value;
        }
      }
    }
  }

  [Serializable]
  public class ObjectiveGroup(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GroupCheckingType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Immediate;
    private static readonly System.IntPtr NativeFieldInfoPtr_Objectives;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static ObjectiveGroup()
    {
      Il2CppClassPointerStore<SceneObjectives.ObjectiveGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, nameof (ObjectiveGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneObjectives.ObjectiveGroup>.NativeClassPtr);
      SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_GroupCheckingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.ObjectiveGroup>.NativeClassPtr, nameof (GroupCheckingType));
      SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_Immediate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.ObjectiveGroup>.NativeClassPtr, nameof (Immediate));
      SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_Objectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.ObjectiveGroup>.NativeClassPtr, nameof (Objectives));
      SceneObjectives.ObjectiveGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives.ObjectiveGroup>.NativeClassPtr, 100671520 /*0x06002020*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94699, XrefRangeEnd = 94700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ObjectiveGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneObjectives.ObjectiveGroup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SceneObjectives.ObjectiveGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe SceneObjectives.ObjectiveGroup.GroupCheck GroupCheckingType
    {
      get
      {
        return *(SceneObjectives.ObjectiveGroup.GroupCheck*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_GroupCheckingType));
      }
      [param: In] set
      {
        *(SceneObjectives.ObjectiveGroup.GroupCheck*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_GroupCheckingType)) = value;
      }
    }

    public unsafe bool Immediate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_Immediate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_Immediate)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<SceneObjectives.ObjectiveData> Objectives
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_Objectives));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SceneObjectives.ObjectiveData>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SceneObjectives.ObjectiveData>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.ObjectiveGroup.NativeFieldInfoPtr_Objectives), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum GroupCheck
    {
      StopAtFirstUnmatched,
      Continue,
    }
  }

  [ObfuscatedName("SadCatStudios.Quests.SceneObjectives+<>c__DisplayClass10_0")]
  public sealed class __c__DisplayClass10_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_group;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_String_Object_0;

    static __c__DisplayClass10_0()
    {
      Il2CppClassPointerStore<SceneObjectives.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneObjectives>.NativeClassPtr, "<>c__DisplayClass10_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneObjectives.__c__DisplayClass10_0>.NativeClassPtr);
      SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.__c__DisplayClass10_0>.NativeClassPtr, nameof (group));
      SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
      SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneObjectives.__c__DisplayClass10_0>.NativeClassPtr, "<>9__0");
      SceneObjectives.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives.__c__DisplayClass10_0>.NativeClassPtr, 100671521);
      SceneObjectives.__c__DisplayClass10_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneObjectives.__c__DisplayClass10_0>.NativeClassPtr, 100671522);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass10_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneObjectives.__c__DisplayClass10_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SceneObjectives.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 94700, XrefRangeEnd = 94718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _Initialize_b__0(string k, Il2CppSystem.Object v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(k);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) v);
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SceneObjectives.__c__DisplayClass10_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe SceneObjectives.ObjectiveGroup group
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr_group));
        return num == System.IntPtr.Zero ? (SceneObjectives.ObjectiveGroup) null : Il2CppObjectPool.Get<SceneObjectives.ObjectiveGroup>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SceneObjectives __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (SceneObjectives) null : Il2CppObjectPool.Get<SceneObjectives>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<string, Il2CppSystem.Object> __9__0
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppSystem.Object>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneObjectives.__c__DisplayClass10_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
