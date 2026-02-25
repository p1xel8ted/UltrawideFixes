// Decompiled with JetBrains decompiler
// Type: UnityEngine.LowLevel.PlayerLoop
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

#nullable disable
namespace UnityEngine.LowLevel;

public class PlayerLoop(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0;
  private static readonly PlayerLoop.GetDefaultPlayerLoopInternalDelegate GetDefaultPlayerLoopInternalDelegateField;

  static PlayerLoop()
  {
    Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", nameof (PlayerLoop));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr);
    PlayerLoop.NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100669276);
    PlayerLoop.NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100669277);
    PlayerLoop.NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100669278);
    PlayerLoop.NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100669279);
    PlayerLoop.NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100669280);
    PlayerLoop.NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoop>.NativeClassPtr, 100669281);
    PlayerLoop.GetDefaultPlayerLoopInternalDelegateField = IL2CPP.ResolveICall<PlayerLoop.GetDefaultPlayerLoopInternalDelegate>("UnityEngine.LowLevel.PlayerLoop::GetDefaultPlayerLoopInternal");
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 479066, RefRangeEnd = 479069, XrefRangeStart = 479063, XrefRangeEnd = 479066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayerLoopSystem GetCurrentPlayerLoop()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_GetCurrentPlayerLoop_Public_Static_PlayerLoopSystem_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new PlayerLoopSystem(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479081, RefRangeEnd = 479082, XrefRangeStart = 479069, XrefRangeEnd = 479081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPlayerLoop(PlayerLoopSystem loop)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) loop))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_SetPlayerLoop_Public_Static_Void_PlayerLoopSystem_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 479093, RefRangeEnd = 479095, XrefRangeStart = 479082, XrefRangeEnd = 479093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int PlayerLoopSystemToInternal(
    PlayerLoopSystem sys,
    ref List<PlayerLoopSystemInternal> internalSys)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
    numPtr1[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) sys));
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) internalSys);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_PlayerLoopSystemToInternal_Private_Static_Int32_PlayerLoopSystem_byref_List_1_PlayerLoopSystemInternal_0, System.IntPtr.Zero, (void**) numPtr1, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    ref List<PlayerLoopSystemInternal> local = ref internalSys;
    System.IntPtr pointer = ptr;
    List<PlayerLoopSystemInternal> list = pointer == System.IntPtr.Zero ? (List<PlayerLoopSystemInternal>) null : new List<PlayerLoopSystemInternal>(pointer);
    local = list;
    return *(int*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 479110, RefRangeEnd = 479112, XrefRangeStart = 479095, XrefRangeEnd = 479110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayerLoopSystem InternalToPlayerLoopSystem(
    Il2CppReferenceArray<PlayerLoopSystemInternal> internalSys,
    ref int offset)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) internalSys);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref offset;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_InternalToPlayerLoopSystem_Private_Static_PlayerLoopSystem_Il2CppReferenceArray_1_PlayerLoopSystemInternal_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new PlayerLoopSystem(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479112, XrefRangeEnd = 479114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<PlayerLoopSystemInternal> GetCurrentPlayerLoopInternal()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_GetCurrentPlayerLoopInternal_Private_Static_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<PlayerLoopSystemInternal>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 479114, XrefRangeEnd = 479116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPlayerLoopInternal(
    Il2CppReferenceArray<PlayerLoopSystemInternal> loop)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) loop)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerLoop.NativeMethodInfoPtr_SetPlayerLoopInternal_Private_Static_Void_Il2CppReferenceArray_1_PlayerLoopSystemInternal_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static PlayerLoopSystem GetDefaultPlayerLoop()
  {
    Il2CppReferenceArray<PlayerLoopSystemInternal> playerLoopInternal = PlayerLoop.GetDefaultPlayerLoopInternal();
    int offset = 0;
    return PlayerLoop.InternalToPlayerLoopSystem(playerLoopInternal, ref offset);
  }

  public static Il2CppReferenceArray<PlayerLoopSystemInternal> GetDefaultPlayerLoopInternal()
  {
    System.IntPtr num = PlayerLoop.GetDefaultPlayerLoopInternalDelegateField();
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<PlayerLoopSystemInternal>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystemInternal>>(num);
  }

  private delegate System.IntPtr GetDefaultPlayerLoopInternalDelegate();
}
