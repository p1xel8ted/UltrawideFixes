// Decompiled with JetBrains decompiler
// Type: UnityEngine.Serialization.ManagedReferenceUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Serialization;

public sealed class ManagedReferenceUtility
{
  public const long RefIdUnknown = -1;
  public const long RefIdNull = -2;
  private static readonly ManagedReferenceUtility.SetManagedReferenceIdForObjectInternal_InjectedDelegate SetManagedReferenceIdForObjectInternal_InjectedDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.SetManagedReferenceIdForObjectInternal_InjectedDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::SetManagedReferenceIdForObjectInternal_Injected");
  private static readonly ManagedReferenceUtility.GetManagedReferenceIdForObjectInternal_InjectedDelegate GetManagedReferenceIdForObjectInternal_InjectedDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceIdForObjectInternal_InjectedDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceIdForObjectInternal_Injected");
  private static readonly ManagedReferenceUtility.GetManagedReferenceInternal_InjectedDelegate GetManagedReferenceInternal_InjectedDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceInternal_InjectedDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceInternal_Injected");
  private static readonly ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternal_InjectedDelegate GetManagedReferenceIdsForObjectInternal_InjectedDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternal_InjectedDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceIdsForObjectInternal_Injected");

  public static bool SetManagedReferenceIdForObjectInternal(
    UnityEngine.Object obj,
    Il2CppSystem.Object scriptObj,
    long refId)
  {
    return ManagedReferenceUtility.SetManagedReferenceIdForObjectInternal_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<UnityEngine.Object>(obj), scriptObj, refId);
  }

  public static bool SetManagedReferenceIdForObject(UnityEngine.Object obj, Il2CppSystem.Object scriptObj, long refId)
  {
    if (scriptObj == null)
      return refId == -2L;
    Il2CppSystem.Type type = scriptObj.GetType();
    if (type == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<UnityEngine.Object>()) || type.IsSubclassOf(Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<UnityEngine.Object>())))
      throw new Il2CppSystem.InvalidOperationException("Cannot assign an object deriving from UnityEngine.Object to a managed reference. This is not supported.");
    return ManagedReferenceUtility.SetManagedReferenceIdForObjectInternal(obj, scriptObj, refId);
  }

  public static long GetManagedReferenceIdForObjectInternal(UnityEngine.Object obj, Il2CppSystem.Object scriptObj)
  {
    return ManagedReferenceUtility.GetManagedReferenceIdForObjectInternal_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<UnityEngine.Object>(obj), scriptObj);
  }

  public static long GetManagedReferenceIdForObject(UnityEngine.Object obj, Il2CppSystem.Object scriptObj)
  {
    return ManagedReferenceUtility.GetManagedReferenceIdForObjectInternal(obj, scriptObj);
  }

  public static Il2CppSystem.Object GetManagedReferenceInternal(UnityEngine.Object obj, long id)
  {
    return ManagedReferenceUtility.GetManagedReferenceInternal_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<UnityEngine.Object>(obj), id);
  }

  public static Il2CppSystem.Object GetManagedReference(UnityEngine.Object obj, long id)
  {
    return ManagedReferenceUtility.GetManagedReferenceInternal(obj, id);
  }

  public static Il2CppStructArray<long> GetManagedReferenceIdsForObjectInternal(UnityEngine.Object obj)
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<long> forObjectInternal;
    try
    {
      ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternal_Injected(UnityEngine.Object.MarshalledUnityObject.Marshal<UnityEngine.Object>(obj), out ret);
    }
    finally
    {
      Il2CppStructArray<long> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<long>((Il2CppArrayBase<long>&) ref il2CppStructArray);
      forObjectInternal = il2CppStructArray;
    }
    return forObjectInternal;
  }

  public static Il2CppStructArray<long> GetManagedReferenceIds(UnityEngine.Object obj)
  {
    return ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternal(obj);
  }

  public static bool SetManagedReferenceIdForObjectInternal_Injected(
    System.IntPtr obj,
    Il2CppSystem.Object scriptObj,
    long refId)
  {
    return ManagedReferenceUtility.SetManagedReferenceIdForObjectInternal_InjectedDelegateField(obj, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) scriptObj), refId);
  }

  public static long GetManagedReferenceIdForObjectInternal_Injected(System.IntPtr obj, Il2CppSystem.Object scriptObj)
  {
    return ManagedReferenceUtility.GetManagedReferenceIdForObjectInternal_InjectedDelegateField(obj, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) scriptObj));
  }

  public static Il2CppSystem.Object GetManagedReferenceInternal_Injected(System.IntPtr obj, long id)
  {
    System.IntPtr num = ManagedReferenceUtility.GetManagedReferenceInternal_InjectedDelegateField(obj, id);
    return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
  }

  public static void GetManagedReferenceIdsForObjectInternal_Injected(
    System.IntPtr obj,
    out BlittableArrayWrapper ret)
  {
    ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternal_InjectedDelegateField(obj, (System.IntPtr) ref ret);
  }

  private delegate bool SetManagedReferenceIdForObjectInternal_InjectedDelegate(
    System.IntPtr obj,
    System.IntPtr scriptObj,
    long refId);

  private delegate long GetManagedReferenceIdForObjectInternal_InjectedDelegate(
    System.IntPtr obj,
    System.IntPtr scriptObj);

  private delegate System.IntPtr GetManagedReferenceInternal_InjectedDelegate(System.IntPtr obj, long id);

  private delegate void GetManagedReferenceIdsForObjectInternal_InjectedDelegate(
    System.IntPtr obj,
    [Out] System.IntPtr ret);
}
