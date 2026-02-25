// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableAsset
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;

#nullable disable
namespace UnityEngine.Playables;

[Serializable]
public class PlayableAsset(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0;
  private static readonly IntPtr NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static PlayableAsset()
  {
    Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (PlayableAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr);
    PlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100669396);
    PlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100669397);
    PlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100669398);
    PlayableAsset.NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100669399);
    PlayableAsset.NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100669400);
    PlayableAsset.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr, 100669401);
  }

  [CallerCount(0)]
  public virtual unsafe Playable CreatePlayable(PlayableGraph graph, GameObject owner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe double duration
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 480094, RefRangeEnd = 480097, XrefRangeStart = 480090, XrefRangeEnd = 480094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayableAsset.NativeMethodInfoPtr_get_duration_Public_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe IEnumerable<PlayableBinding> outputs
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480097, XrefRangeEnd = 480101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PlayableAsset.NativeMethodInfoPtr_get_outputs_Public_Virtual_New_get_IEnumerable_1_PlayableBinding_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (IEnumerable<PlayableBinding>) null : Il2CppObjectPool.Get<IEnumerable<PlayableBinding>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480101, XrefRangeEnd = 480113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Internal_CreatePlayable(
    PlayableAsset asset,
    PlayableGraph graph,
    GameObject go,
    IntPtr ptr)
  {
    IntPtr* numPtr = stackalloc IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) go);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &ptr;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr_Internal_CreatePlayable_Internal_Static_Void_PlayableAsset_PlayableGraph_GameObject_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public static unsafe void Internal_GetPlayableAssetDuration(
    PlayableAsset asset,
    IntPtr ptrToDouble)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &ptrToDouble;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr_Internal_GetPlayableAssetDuration_Internal_Static_Void_PlayableAsset_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayableAsset()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableAsset>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableAsset.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
