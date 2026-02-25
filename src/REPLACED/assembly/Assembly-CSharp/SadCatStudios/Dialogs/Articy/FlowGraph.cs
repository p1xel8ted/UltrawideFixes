// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowGraph
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
using System;
using System.Runtime.InteropServices;
using XNode;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowGraph(System.IntPtr pointer) : NodeGraph(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_dialogueObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_KnownActors;
  private static readonly System.IntPtr NativeFieldInfoPtr_StartElementsBlocks;
  private static readonly System.IntPtr NativeFieldInfoPtr_EndElementsBlocks;
  private static readonly System.IntPtr NativeFieldInfoPtr_FlowGameObjectHandlerBindings;
  private static readonly System.IntPtr NativeFieldInfoPtr_FlowIdleHandlerBindings;
  private static readonly System.IntPtr NativeFieldInfoPtr_FlowClipHandlerBindings;
  private static readonly System.IntPtr NativeFieldInfoPtr_FlowCinemachineHandlerBindings;
  private static readonly System.IntPtr NativeFieldInfoPtr_FlowTimelineHandlerBindings;
  private static readonly System.IntPtr NativeFieldInfoPtr_FlowMoveToPointHandlerBindings;
  private static readonly System.IntPtr NativeFieldInfoPtr_BoltUnityEventHandlerBindings;
  private static readonly System.IntPtr NativeFieldInfoPtr_WaypointBindings;
  private static readonly System.IntPtr NativeFieldInfoPtr_KnownDialogueJumps;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNode_Public_ArticyNode_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindActorById_Public_ActorReference_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FlowGraph()
  {
    Il2CppClassPointerStore<FlowGraph>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowGraph));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr);
    FlowGraph.NativeFieldInfoPtr_dialogueObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (dialogueObject));
    FlowGraph.NativeFieldInfoPtr_KnownActors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (KnownActors));
    FlowGraph.NativeFieldInfoPtr_StartElementsBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (StartElementsBlocks));
    FlowGraph.NativeFieldInfoPtr_EndElementsBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (EndElementsBlocks));
    FlowGraph.NativeFieldInfoPtr_FlowGameObjectHandlerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (FlowGameObjectHandlerBindings));
    FlowGraph.NativeFieldInfoPtr_FlowIdleHandlerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (FlowIdleHandlerBindings));
    FlowGraph.NativeFieldInfoPtr_FlowClipHandlerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (FlowClipHandlerBindings));
    FlowGraph.NativeFieldInfoPtr_FlowCinemachineHandlerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (FlowCinemachineHandlerBindings));
    FlowGraph.NativeFieldInfoPtr_FlowTimelineHandlerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (FlowTimelineHandlerBindings));
    FlowGraph.NativeFieldInfoPtr_FlowMoveToPointHandlerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (FlowMoveToPointHandlerBindings));
    FlowGraph.NativeFieldInfoPtr_BoltUnityEventHandlerBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (BoltUnityEventHandlerBindings));
    FlowGraph.NativeFieldInfoPtr_WaypointBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (WaypointBindings));
    FlowGraph.NativeFieldInfoPtr_KnownDialogueJumps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (KnownDialogueJumps));
    FlowGraph.NativeMethodInfoPtr_GetNode_Public_ArticyNode_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, 100672718);
    FlowGraph.NativeMethodInfoPtr_FindActorById_Public_ActorReference_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, 100672719);
    FlowGraph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, 100672720);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 103045, RefRangeEnd = 103047, XrefRangeStart = 103033, XrefRangeEnd = 103045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyNode GetNode(ulong id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowGraph.NativeMethodInfoPtr_GetNode_Public_ArticyNode_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyNode) null : Il2CppObjectPool.Get<ArticyNode>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103047, XrefRangeEnd = 103063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ActorReference FindActorById(ulong id)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &id
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowGraph.NativeMethodInfoPtr_FindActorById_Public_ActorReference_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ActorReference) null : Il2CppObjectPool.Get<ActorReference>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103063, XrefRangeEnd = 103074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowGraph()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowGraph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef dialogueObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_dialogueObject));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_dialogueObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<FlowGraph.FlowGraphActorInfo> KnownActors
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_KnownActors));
      return num == System.IntPtr.Zero ? (List<FlowGraph.FlowGraphActorInfo>) null : Il2CppObjectPool.Get<List<FlowGraph.FlowGraphActorInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_KnownActors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<FlowElementBlock> StartElementsBlocks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_StartElementsBlocks));
      return num == System.IntPtr.Zero ? (List<FlowElementBlock>) null : Il2CppObjectPool.Get<List<FlowElementBlock>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_StartElementsBlocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<FlowElementBlock> EndElementsBlocks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_EndElementsBlocks));
      return num == System.IntPtr.Zero ? (List<FlowElementBlock>) null : Il2CppObjectPool.Get<List<FlowElementBlock>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_EndElementsBlocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GuidReference> FlowGameObjectHandlerBindings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowGameObjectHandlerBindings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GuidReference>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowGameObjectHandlerBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GuidReference> FlowIdleHandlerBindings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowIdleHandlerBindings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GuidReference>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowIdleHandlerBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GuidReference> FlowClipHandlerBindings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowClipHandlerBindings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GuidReference>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowClipHandlerBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GuidReference> FlowCinemachineHandlerBindings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowCinemachineHandlerBindings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GuidReference>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowCinemachineHandlerBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GuidReference> FlowTimelineHandlerBindings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowTimelineHandlerBindings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GuidReference>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowTimelineHandlerBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GuidReference> FlowMoveToPointHandlerBindings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowMoveToPointHandlerBindings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GuidReference>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_FlowMoveToPointHandlerBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GuidReference> BoltUnityEventHandlerBindings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_BoltUnityEventHandlerBindings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GuidReference>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_BoltUnityEventHandlerBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<GuidReference> WaypointBindings
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_WaypointBindings));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<GuidReference>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<GuidReference>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_WaypointBindings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowGraph.JumpDictionary KnownDialogueJumps
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_KnownDialogueJumps));
      return num == System.IntPtr.Zero ? (FlowGraph.JumpDictionary) null : Il2CppObjectPool.Get<FlowGraph.JumpDictionary>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.NativeFieldInfoPtr_KnownDialogueJumps), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class JumpDictionary(System.IntPtr pointer) : UnitySerializedDictionary<ulong, FlowGraph>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static JumpDictionary()
    {
      Il2CppClassPointerStore<FlowGraph.JumpDictionary>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (JumpDictionary));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowGraph.JumpDictionary>.NativeClassPtr);
      FlowGraph.JumpDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGraph.JumpDictionary>.NativeClassPtr, 100672721);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103030, XrefRangeEnd = 103033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JumpDictionary()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowGraph.JumpDictionary>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowGraph.JumpDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class FlowGraphActorInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DisplayName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_Reference;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static FlowGraphActorInfo()
    {
      Il2CppClassPointerStore<FlowGraph.FlowGraphActorInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, nameof (FlowGraphActorInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowGraph.FlowGraphActorInfo>.NativeClassPtr);
      FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph.FlowGraphActorInfo>.NativeClassPtr, nameof (DisplayName));
      FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph.FlowGraphActorInfo>.NativeClassPtr, nameof (Id));
      FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_Reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph.FlowGraphActorInfo>.NativeClassPtr, nameof (Reference));
      FlowGraph.FlowGraphActorInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGraph.FlowGraphActorInfo>.NativeClassPtr, 100672722);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FlowGraphActorInfo()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowGraph.FlowGraphActorInfo>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowGraph.FlowGraphActorInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe string DisplayName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_DisplayName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe ulong Id
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_Id));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_Id)) = value;
      }
    }

    public unsafe GuidReference Reference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_Reference));
        return num == System.IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.FlowGraphActorInfo.NativeFieldInfoPtr_Reference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowGraph+<>c__DisplayClass15_0")]
  public sealed class __c__DisplayClass15_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_id;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__FindActorById_b__0_Internal_Boolean_FlowGraphActorInfo_0;

    static __c__DisplayClass15_0()
    {
      Il2CppClassPointerStore<FlowGraph.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowGraph>.NativeClassPtr, "<>c__DisplayClass15_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowGraph.__c__DisplayClass15_0>.NativeClassPtr);
      FlowGraph.__c__DisplayClass15_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGraph.__c__DisplayClass15_0>.NativeClassPtr, nameof (id));
      FlowGraph.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGraph.__c__DisplayClass15_0>.NativeClassPtr, 100672723);
      FlowGraph.__c__DisplayClass15_0.NativeMethodInfoPtr__FindActorById_b__0_Internal_Boolean_FlowGraphActorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGraph.__c__DisplayClass15_0>.NativeClassPtr, 100672724);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass15_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowGraph.__c__DisplayClass15_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowGraph.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe bool _FindActorById_b__0(FlowGraph.FlowGraphActorInfo info)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) info)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowGraph.__c__DisplayClass15_0.NativeMethodInfoPtr__FindActorById_b__0_Internal_Boolean_FlowGraphActorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe ulong id
    {
      get
      {
        return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.__c__DisplayClass15_0.NativeFieldInfoPtr_id));
      }
      [param: In] set
      {
        *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGraph.__c__DisplayClass15_0.NativeFieldInfoPtr_id)) = value;
      }
    }
  }
}
