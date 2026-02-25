// Decompiled with JetBrains decompiler
// Type: UnityEngine.ApiRestrictions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using System;

#nullable disable
namespace UnityEngine;

public class ApiRestrictions
{
  private static readonly ApiRestrictions.PushDisableApiInternal_InjectedDelegate PushDisableApiInternal_InjectedDelegateField = IL2CPP.ResolveICall<ApiRestrictions.PushDisableApiInternal_InjectedDelegate>("UnityEngine.ApiRestrictions::PushDisableApiInternal_Injected");
  private static readonly ApiRestrictions.PopDisableApiInternal_InjectedDelegate PopDisableApiInternal_InjectedDelegateField = IL2CPP.ResolveICall<ApiRestrictions.PopDisableApiInternal_InjectedDelegate>("UnityEngine.ApiRestrictions::PopDisableApiInternal_Injected");
  private static readonly ApiRestrictions.TryApiInternal_InjectedDelegate TryApiInternal_InjectedDelegateField = IL2CPP.ResolveICall<ApiRestrictions.TryApiInternal_InjectedDelegate>("UnityEngine.ApiRestrictions::TryApiInternal_Injected");

  public static void PushDisableApiInternal(
    ApiRestrictions.ContextRestrictions contextApi,
    Object context,
    ApiRestrictions.GlobalRestrictions globalApi)
  {
    ApiRestrictions.PushDisableApiInternal_Injected(contextApi, Object.MarshalledUnityObject.Marshal<Object>(context), globalApi);
  }

  public static void PopDisableApiInternal(
    ApiRestrictions.ContextRestrictions contextApi,
    Object context,
    ApiRestrictions.GlobalRestrictions globalApi)
  {
    ApiRestrictions.PopDisableApiInternal_Injected(contextApi, Object.MarshalledUnityObject.Marshal<Object>(context), globalApi);
  }

  public static bool TryApiInternal(
    ApiRestrictions.ContextRestrictions contextApi,
    Object context,
    ApiRestrictions.GlobalRestrictions globalApi,
    bool allowErrorLogging)
  {
    return ApiRestrictions.TryApiInternal_Injected(contextApi, Object.MarshalledUnityObject.Marshal<Object>(context), globalApi, allowErrorLogging);
  }

  public static void PushDisableApi(ApiRestrictions.ContextRestrictions api, Object owner)
  {
    ApiRestrictions.PushDisableApiInternal(api, owner, ApiRestrictions.GlobalRestrictions.GLOBALCOUNT);
  }

  public static void PushDisableApi(ApiRestrictions.GlobalRestrictions api)
  {
    ApiRestrictions.PushDisableApiInternal(ApiRestrictions.ContextRestrictions.CONTEXTCOUNT, (Object) null, api);
  }

  public static void PopDisableApi(ApiRestrictions.ContextRestrictions api, Object context)
  {
    ApiRestrictions.PopDisableApiInternal(api, context, ApiRestrictions.GlobalRestrictions.GLOBALCOUNT);
  }

  public static void PopDisableApi(ApiRestrictions.GlobalRestrictions api)
  {
    ApiRestrictions.PopDisableApiInternal(ApiRestrictions.ContextRestrictions.CONTEXTCOUNT, (Object) null, api);
  }

  public static bool TryApi(
    ApiRestrictions.ContextRestrictions api,
    Object context,
    bool allowErrorLogging = default (bool))
  {
    return ApiRestrictions.TryApiInternal(api, context, ApiRestrictions.GlobalRestrictions.GLOBALCOUNT, allowErrorLogging);
  }

  public static bool TryApi(ApiRestrictions.GlobalRestrictions api, bool allowErrorLogging = default (bool))
  {
    return ApiRestrictions.TryApiInternal(ApiRestrictions.ContextRestrictions.CONTEXTCOUNT, (Object) null, api, allowErrorLogging);
  }

  public static void PushDisableApiInternal_Injected(
    ApiRestrictions.ContextRestrictions contextApi,
    IntPtr context,
    ApiRestrictions.GlobalRestrictions globalApi)
  {
    ApiRestrictions.PushDisableApiInternal_InjectedDelegateField(contextApi, context, globalApi);
  }

  public static void PopDisableApiInternal_Injected(
    ApiRestrictions.ContextRestrictions contextApi,
    IntPtr context,
    ApiRestrictions.GlobalRestrictions globalApi)
  {
    ApiRestrictions.PopDisableApiInternal_InjectedDelegateField(contextApi, context, globalApi);
  }

  public static bool TryApiInternal_Injected(
    ApiRestrictions.ContextRestrictions contextApi,
    IntPtr context,
    ApiRestrictions.GlobalRestrictions globalApi,
    bool allowErrorLogging)
  {
    return ApiRestrictions.TryApiInternal_InjectedDelegateField(contextApi, context, globalApi, allowErrorLogging);
  }

  public enum GlobalRestrictions
  {
    OBJECT_DESTROYIMMEDIATE,
    OBJECT_SENDMESSAGE,
    OBJECT_RENDERING,
    GLOBALCOUNT,
  }

  public enum ContextRestrictions
  {
    RENDERERSCENE_ADDREMOVE,
    OBJECT_ADDCOMPONENTTRANSFORM,
    CONTEXTCOUNT,
  }

  private delegate void PushDisableApiInternal_InjectedDelegate(
    ApiRestrictions.ContextRestrictions contextApi,
    IntPtr context,
    ApiRestrictions.GlobalRestrictions globalApi);

  private delegate void PopDisableApiInternal_InjectedDelegate(
    ApiRestrictions.ContextRestrictions contextApi,
    IntPtr context,
    ApiRestrictions.GlobalRestrictions globalApi);

  private delegate bool TryApiInternal_InjectedDelegate(
    ApiRestrictions.ContextRestrictions contextApi,
    IntPtr context,
    ApiRestrictions.GlobalRestrictions globalApi,
    bool allowErrorLogging);
}
