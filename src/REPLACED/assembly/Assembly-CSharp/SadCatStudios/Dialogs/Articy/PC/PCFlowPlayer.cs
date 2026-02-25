// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.PC.PCFlowPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced;
using Articy.Unity;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using FMOD.Studio;
using FMODUnity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Replaced.Scripts.UI;
using SadCatStudios.UI;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.Dialogs.Articy.PC;

public class PCFlowPlayer(System.IntPtr pointer) : LocalSingletonBehaviour<PCFlowPlayer>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_buildText;
  private static readonly System.IntPtr NativeFieldInfoPtr_dateText;
  private static readonly System.IntPtr NativeFieldInfoPtr_copyrightText;
  private static readonly System.IntPtr NativeFieldInfoPtr_domainText;
  private static readonly System.IntPtr NativeFieldInfoPtr_messageText;
  private static readonly System.IntPtr NativeFieldInfoPtr_skipText;
  private static readonly System.IntPtr NativeFieldInfoPtr_scrollView;
  private static readonly System.IntPtr NativeFieldInfoPtr_dialogueChoices;
  private static readonly System.IntPtr NativeFieldInfoPtr_SkipButtonSkipKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_SkipButtonCloseKey;
  private static readonly System.IntPtr NativeFieldInfoPtr_startupSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_shutdownSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundSound;
  private static readonly System.IntPtr NativeFieldInfoPtr_backgroundInstance;
  private static readonly System.IntPtr NativeFieldInfoPtr_onDialogEnded;
  private static readonly System.IntPtr NativeFieldInfoPtr_articyFlowPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_playerJustPaused;
  private static readonly System.IntPtr NativeFieldInfoPtr_blockPromises;
  private static readonly System.IntPtr NativeFieldInfoPtr_lastSelectedChoices;
  private static readonly System.IntPtr NativeFieldInfoPtr_textHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_itemHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_boltUnityEventHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_gameObjectHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr_soundHandler;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsCalledInForecast_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TextHandler_Public_get_FlowPCTextHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ItemHandler_Public_get_FlowItemHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_BoltUnityEventHandler_Public_get_FlowBoltUnityEventHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_GameObjectHandler_Public_get_FlowGameObjectHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SoundHandler_Public_get_FlowSoundHandler_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SkipButtonSetText_Public_Void_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartFlow_Public_Void_FlowGraph_UniTaskCompletionSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunFlow_Public_UniTaskVoid_FlowGraph_UniTaskCompletionSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RunHandlers_Private_UniTask_List_1_FlowElementBlock_DialogueFragment_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsCalledInForecast_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_IsCalledInForecast_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NumberOfArcadesBeaten_Public_Virtual_Final_New_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PCFlowPlayer()
  {
    Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy.PC", nameof (PCFlowPlayer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr);
    PCFlowPlayer.NativeFieldInfoPtr_buildText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (buildText));
    PCFlowPlayer.NativeFieldInfoPtr_dateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (dateText));
    PCFlowPlayer.NativeFieldInfoPtr_copyrightText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (copyrightText));
    PCFlowPlayer.NativeFieldInfoPtr_domainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (domainText));
    PCFlowPlayer.NativeFieldInfoPtr_messageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (messageText));
    PCFlowPlayer.NativeFieldInfoPtr_skipText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (skipText));
    PCFlowPlayer.NativeFieldInfoPtr_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (scrollView));
    PCFlowPlayer.NativeFieldInfoPtr_dialogueChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (dialogueChoices));
    PCFlowPlayer.NativeFieldInfoPtr_SkipButtonSkipKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (SkipButtonSkipKey));
    PCFlowPlayer.NativeFieldInfoPtr_SkipButtonCloseKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (SkipButtonCloseKey));
    PCFlowPlayer.NativeFieldInfoPtr_startupSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (startupSound));
    PCFlowPlayer.NativeFieldInfoPtr_shutdownSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (shutdownSound));
    PCFlowPlayer.NativeFieldInfoPtr_backgroundSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (backgroundSound));
    PCFlowPlayer.NativeFieldInfoPtr_backgroundInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (backgroundInstance));
    PCFlowPlayer.NativeFieldInfoPtr_onDialogEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (onDialogEnded));
    PCFlowPlayer.NativeFieldInfoPtr_articyFlowPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (articyFlowPlayer));
    PCFlowPlayer.NativeFieldInfoPtr_playerJustPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (playerJustPaused));
    PCFlowPlayer.NativeFieldInfoPtr_blockPromises = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (blockPromises));
    PCFlowPlayer.NativeFieldInfoPtr_lastSelectedChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (lastSelectedChoices));
    PCFlowPlayer.NativeFieldInfoPtr_textHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (textHandler));
    PCFlowPlayer.NativeFieldInfoPtr_itemHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (itemHandler));
    PCFlowPlayer.NativeFieldInfoPtr_boltUnityEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (boltUnityEventHandler));
    PCFlowPlayer.NativeFieldInfoPtr_gameObjectHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (gameObjectHandler));
    PCFlowPlayer.NativeFieldInfoPtr_soundHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, nameof (soundHandler));
    PCFlowPlayer.NativeFieldInfoPtr__IsCalledInForecast_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, "<IsCalledInForecast>k__BackingField");
    PCFlowPlayer.NativeMethodInfoPtr_get_TextHandler_Public_get_FlowPCTextHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672949);
    PCFlowPlayer.NativeMethodInfoPtr_get_ItemHandler_Public_get_FlowItemHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672950);
    PCFlowPlayer.NativeMethodInfoPtr_get_BoltUnityEventHandler_Public_get_FlowBoltUnityEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672951);
    PCFlowPlayer.NativeMethodInfoPtr_get_GameObjectHandler_Public_get_FlowGameObjectHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672952);
    PCFlowPlayer.NativeMethodInfoPtr_get_SoundHandler_Public_get_FlowSoundHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672953);
    PCFlowPlayer.NativeMethodInfoPtr_SkipButtonSetText_Public_Void_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672954);
    PCFlowPlayer.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672955);
    PCFlowPlayer.NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672956);
    PCFlowPlayer.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672957);
    PCFlowPlayer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672958);
    PCFlowPlayer.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672959);
    PCFlowPlayer.NativeMethodInfoPtr_StartFlow_Public_Void_FlowGraph_UniTaskCompletionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672960);
    PCFlowPlayer.NativeMethodInfoPtr_RunFlow_Public_UniTaskVoid_FlowGraph_UniTaskCompletionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672961);
    PCFlowPlayer.NativeMethodInfoPtr_RunHandlers_Private_UniTask_List_1_FlowElementBlock_DialogueFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672962);
    PCFlowPlayer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672963);
    PCFlowPlayer.NativeMethodInfoPtr_get_IsCalledInForecast_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672964);
    PCFlowPlayer.NativeMethodInfoPtr_set_IsCalledInForecast_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672965);
    PCFlowPlayer.NativeMethodInfoPtr_NumberOfArcadesBeaten_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672966);
    PCFlowPlayer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, 100672967);
  }

  public unsafe FlowPCTextHandler TextHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105153, XrefRangeEnd = 105157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_get_TextHandler_Public_get_FlowPCTextHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowPCTextHandler) null : Il2CppObjectPool.Get<FlowPCTextHandler>(num3);
    }
  }

  public unsafe FlowItemHandler ItemHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105157, XrefRangeEnd = 105161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_get_ItemHandler_Public_get_FlowItemHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowItemHandler) null : Il2CppObjectPool.Get<FlowItemHandler>(num3);
    }
  }

  public unsafe FlowBoltUnityEventHandler BoltUnityEventHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105161, XrefRangeEnd = 105165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_get_BoltUnityEventHandler_Public_get_FlowBoltUnityEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowBoltUnityEventHandler) null : Il2CppObjectPool.Get<FlowBoltUnityEventHandler>(num3);
    }
  }

  public unsafe FlowGameObjectHandler GameObjectHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105165, XrefRangeEnd = 105169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_get_GameObjectHandler_Public_get_FlowGameObjectHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowGameObjectHandler) null : Il2CppObjectPool.Get<FlowGameObjectHandler>(num3);
    }
  }

  public unsafe FlowSoundHandler SoundHandler
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105169, XrefRangeEnd = 105173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_get_SoundHandler_Public_get_FlowSoundHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (FlowSoundHandler) null : Il2CppObjectPool.Get<FlowSoundHandler>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105179, RefRangeEnd = 105180, XrefRangeStart = 105173, XrefRangeEnd = 105179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SkipButtonSetText(ArticyRef key)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) key)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_SkipButtonSetText_Public_Void_ArticyRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnFlowPlayerPaused(IFlowObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_OnFlowPlayerPaused_Public_Virtual_Final_New_Void_IFlowObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBranchesUpdated(IList<Branch> aBranches)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranches)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_OnBranchesUpdated_Public_Virtual_Final_New_Void_IList_1_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105180, XrefRangeEnd = 105183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCFlowPlayer.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105183, XrefRangeEnd = 105191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105191, XrefRangeEnd = 105199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PCFlowPlayer.NativeMethodInfoPtr_DoDestroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 105203, RefRangeEnd = 105204, XrefRangeStart = 105199, XrefRangeEnd = 105203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StartFlow(FlowGraph flowGraph, UniTaskCompletionSource done)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) flowGraph);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) done);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_StartFlow_Public_Void_FlowGraph_UniTaskCompletionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105204, XrefRangeEnd = 105207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTaskVoid RunFlow(FlowGraph flowGraph, UniTaskCompletionSource done)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) flowGraph);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) done);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_RunFlow_Public_UniTaskVoid_FlowGraph_UniTaskCompletionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(UniTaskVoid*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105207, XrefRangeEnd = 105212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UniTask RunHandlers(
    List<FlowElementBlock> blocks,
    DialogueFragment dialogueFragment = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blocks);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dialogueFragment);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_RunHandlers_Private_UniTask_List_1_FlowElementBlock_DialogueFragment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105212, XrefRangeEnd = 105218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe bool IsCalledInForecast
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_get_IsCalledInForecast_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_set_IsCalledInForecast_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int NumberOfArcadesBeaten()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr_NumberOfArcadesBeaten_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105218, XrefRangeEnd = 105233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PCFlowPlayer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TMP_Text buildText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_buildText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_buildText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text dateText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_dateText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_dateText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text copyrightText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_copyrightText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_copyrightText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe TMP_Text domainText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_domainText));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_domainText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIPCTypeWriter messageText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_messageText));
      return num == System.IntPtr.Zero ? (UIPCTypeWriter) null : Il2CppObjectPool.Get<UIPCTypeWriter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_messageText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIGlyphText skipText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_skipText));
      return num == System.IntPtr.Zero ? (UIGlyphText) null : Il2CppObjectPool.Get<UIGlyphText>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_skipText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ScrollRect scrollView
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_scrollView));
      return num == System.IntPtr.Zero ? (ScrollRect) null : Il2CppObjectPool.Get<ScrollRect>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_scrollView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PCDialogueChoices dialogueChoices
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_dialogueChoices));
      return num == System.IntPtr.Zero ? (PCDialogueChoices) null : Il2CppObjectPool.Get<PCDialogueChoices>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_dialogueChoices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef SkipButtonSkipKey
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_SkipButtonSkipKey));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_SkipButtonSkipKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef SkipButtonCloseKey
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_SkipButtonCloseKey));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_SkipButtonCloseKey), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe EventReference startupSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_startupSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_startupSound)) = value;
    }
  }

  public unsafe EventReference shutdownSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_shutdownSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_shutdownSound)) = value;
    }
  }

  public unsafe EventReference backgroundSound
  {
    get
    {
      return *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_backgroundSound));
    }
    [param: In] set
    {
      *(EventReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_backgroundSound)) = value;
    }
  }

  public unsafe EventInstance backgroundInstance
  {
    get
    {
      return *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_backgroundInstance));
    }
    [param: In] set
    {
      *(EventInstance*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_backgroundInstance)) = value;
    }
  }

  public unsafe UnityEvent onDialogEnded
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_onDialogEnded));
      return num == System.IntPtr.Zero ? (UnityEvent) null : Il2CppObjectPool.Get<UnityEvent>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_onDialogEnded), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyFlowPlayer articyFlowPlayer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_articyFlowPlayer));
      return num == System.IntPtr.Zero ? (ArticyFlowPlayer) null : Il2CppObjectPool.Get<ArticyFlowPlayer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_articyFlowPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool playerJustPaused
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_playerJustPaused));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_playerJustPaused)) = value;
    }
  }

  public unsafe List<UniTask> blockPromises
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_blockPromises));
      return num == System.IntPtr.Zero ? (List<UniTask>) null : Il2CppObjectPool.Get<List<UniTask>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_blockPromises), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<ulong, int> lastSelectedChoices
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_lastSelectedChoices));
      return num == System.IntPtr.Zero ? (Dictionary<ulong, int>) null : Il2CppObjectPool.Get<Dictionary<ulong, int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_lastSelectedChoices), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowPCTextHandler textHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_textHandler));
      return num == System.IntPtr.Zero ? (FlowPCTextHandler) null : Il2CppObjectPool.Get<FlowPCTextHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_textHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowItemHandler itemHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_itemHandler));
      return num == System.IntPtr.Zero ? (FlowItemHandler) null : Il2CppObjectPool.Get<FlowItemHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_itemHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowBoltUnityEventHandler boltUnityEventHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_boltUnityEventHandler));
      return num == System.IntPtr.Zero ? (FlowBoltUnityEventHandler) null : Il2CppObjectPool.Get<FlowBoltUnityEventHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_boltUnityEventHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowGameObjectHandler gameObjectHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_gameObjectHandler));
      return num == System.IntPtr.Zero ? (FlowGameObjectHandler) null : Il2CppObjectPool.Get<FlowGameObjectHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_gameObjectHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowSoundHandler soundHandler
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_soundHandler));
      return num == System.IntPtr.Zero ? (FlowSoundHandler) null : Il2CppObjectPool.Get<FlowSoundHandler>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr_soundHandler), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _IsCalledInForecast_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr__IsCalledInForecast_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer.NativeFieldInfoPtr__IsCalledInForecast_k__BackingField)) = value;
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.PC.PCFlowPlayer+<RunFlow>d__41")]
  public sealed class _RunFlow_d__41 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_flowGraph;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_done;
    private static readonly System.IntPtr NativeFieldInfoPtr__shouldExit_5__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__nextAfterBranching_5__3;
    private static readonly System.IntPtr NativeFieldInfoPtr__nextAfterDialogue_5__4;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__2;
    private static readonly System.IntPtr NativeFieldInfoPtr__hub_5__5;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap5;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__3;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _RunFlow_d__41()
    {
      Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, "<RunFlow>d__41");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr);
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<>1__state");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<>t__builder");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr_flowGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, nameof (flowGraph));
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<>4__this");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, nameof (done));
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__shouldExit_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<shouldExit>5__2");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__nextAfterBranching_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<nextAfterBranching>5__3");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__nextAfterDialogue_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<nextAfterDialogue>5__4");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<>u__1");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<>u__2");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__hub_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<hub>5__5");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<>7__wrap5");
      PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, "<>u__3");
      PCFlowPlayer._RunFlow_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, 100672968);
      PCFlowPlayer._RunFlow_d__41.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr, 100672969);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 105065, XrefRangeEnd = 105104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer._RunFlow_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer._RunFlow_d__41.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _RunFlow_d__41(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _RunFlow_d__41()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCFlowPlayer._RunFlow_d__41>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskVoidMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe FlowGraph flowGraph
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr_flowGraph));
        return num == System.IntPtr.Zero ? (FlowGraph) null : Il2CppObjectPool.Get<FlowGraph>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr_flowGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PCFlowPlayer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (PCFlowPlayer) null : Il2CppObjectPool.Get<PCFlowPlayer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UniTaskCompletionSource done
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr_done));
        return num == System.IntPtr.Zero ? (UniTaskCompletionSource) null : Il2CppObjectPool.Get<UniTaskCompletionSource>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr_done), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _shouldExit_5__2
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__shouldExit_5__2));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__shouldExit_5__2)) = value;
      }
    }

    public unsafe bool _nextAfterBranching_5__3
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__nextAfterBranching_5__3));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__nextAfterBranching_5__3)) = value;
      }
    }

    public unsafe bool _nextAfterDialogue_5__4
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__nextAfterDialogue_5__4));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__nextAfterDialogue_5__4)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe Cysharp.Threading.Tasks.YieldAwaitable.Awaiter __u__2
    {
      get
      {
        return *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__2));
      }
      [param: In] set
      {
        *(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__2)) = value;
      }
    }

    public unsafe Hub _hub_5__5
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__hub_5__5));
        return num == System.IntPtr.Zero ? (Hub) null : Il2CppObjectPool.Get<Hub>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr__hub_5__5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IList<Branch> __7__wrap5
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___7__wrap5));
        return num == System.IntPtr.Zero ? (IList<Branch>) null : Il2CppObjectPool.Get<IList<Branch>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public UniTask<int>.Awaiter __u__3
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__3);
        return new UniTask<int>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunFlow_d__41.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<int>.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.PC.PCFlowPlayer+<RunHandlers>d__42")]
  public sealed class _RunHandlers_d__42 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___1__state;
    private static readonly System.IntPtr NativeFieldInfoPtr___t__builder;
    private static readonly System.IntPtr NativeFieldInfoPtr_blocks;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeFieldInfoPtr_dialogueFragment;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap1;
    private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;
    private static readonly System.IntPtr NativeFieldInfoPtr___u__1;
    private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;

    static _RunHandlers_d__42()
    {
      Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PCFlowPlayer>.NativeClassPtr, "<RunHandlers>d__42");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr);
      PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, "<>1__state");
      PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, "<>t__builder");
      PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr_blocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, nameof (blocks));
      PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, "<>4__this");
      PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr_dialogueFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, nameof (dialogueFragment));
      PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, "<>7__wrap1");
      PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, "<>7__wrap2");
      PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, "<>u__1");
      PCFlowPlayer._RunHandlers_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, 100672970);
      PCFlowPlayer._RunHandlers_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr, 100672971);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 105150, RefRangeEnd = 105153, XrefRangeStart = 105104, XrefRangeEnd = 105150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void MoveNext()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer._RunHandlers_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stateMachine)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PCFlowPlayer._RunHandlers_d__42.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public _RunHandlers_d__42(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public _RunHandlers_d__42()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PCFlowPlayer._RunHandlers_d__42>.NativeClassPtr))
    {
    }

    public unsafe int __1__state
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___1__state));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___1__state)) = value;
      }
    }

    public AsyncUniTaskMethodBuilder __t__builder
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___t__builder);
        return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe List<FlowElementBlock> blocks
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr_blocks));
        return num == System.IntPtr.Zero ? (List<FlowElementBlock>) null : Il2CppObjectPool.Get<List<FlowElementBlock>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr_blocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PCFlowPlayer __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (PCFlowPlayer) null : Il2CppObjectPool.Get<PCFlowPlayer>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DialogueFragment dialogueFragment
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr_dialogueFragment));
        return num == System.IntPtr.Zero ? (DialogueFragment) null : Il2CppObjectPool.Get<DialogueFragment>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr_dialogueFragment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<Il2CppReferenceArray<FlowSequence>> __7__wrap1
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___7__wrap1));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppReferenceArray<FlowSequence>>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppReferenceArray<FlowSequence>>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int __7__wrap2
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___7__wrap2));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___7__wrap2)) = value;
      }
    }

    public UniTask.Awaiter __u__1
    {
      get
      {
        System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___u__1);
        return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, num));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PCFlowPlayer._RunHandlers_d__42.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
