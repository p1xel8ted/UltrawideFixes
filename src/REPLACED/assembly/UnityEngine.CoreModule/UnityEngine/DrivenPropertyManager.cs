// Decompiled with JetBrains decompiler
// Type: UnityEngine.DrivenPropertyManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public class DrivenPropertyManager
{
  private static readonly DrivenPropertyManager.UnregisterProperties_InjectedDelegate UnregisterProperties_InjectedDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterProperties_InjectedDelegate>("UnityEngine.DrivenPropertyManager::UnregisterProperties_Injected");
  private static readonly DrivenPropertyManager.RegisterPropertyPartial_InjectedDelegate RegisterPropertyPartial_InjectedDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.RegisterPropertyPartial_InjectedDelegate>("UnityEngine.DrivenPropertyManager::RegisterPropertyPartial_Injected");
  private static readonly DrivenPropertyManager.TryRegisterPropertyPartial_InjectedDelegate TryRegisterPropertyPartial_InjectedDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.TryRegisterPropertyPartial_InjectedDelegate>("UnityEngine.DrivenPropertyManager::TryRegisterPropertyPartial_Injected");
  private static readonly DrivenPropertyManager.UnregisterPropertyPartial_InjectedDelegate UnregisterPropertyPartial_InjectedDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertyPartial_InjectedDelegate>("UnityEngine.DrivenPropertyManager::UnregisterPropertyPartial_Injected");

  public static void RegisterProperty(Object driver, Object target, string propertyPath)
  {
    DrivenPropertyManager.RegisterPropertyPartial(driver, target, propertyPath);
  }

  public static void TryRegisterProperty(Object driver, Object target, string propertyPath)
  {
    DrivenPropertyManager.TryRegisterPropertyPartial(driver, target, propertyPath);
  }

  public static void UnregisterProperty(Object driver, Object target, string propertyPath)
  {
    DrivenPropertyManager.UnregisterPropertyPartial(driver, target, propertyPath);
  }

  public static void UnregisterProperties(Object driver)
  {
    if ((object) driver == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) driver, nameof (driver));
    System.IntPtr driver1 = Object.MarshalledUnityObject.MarshalNotNull<Object>(driver);
    if (driver1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) driver, nameof (driver));
    DrivenPropertyManager.UnregisterProperties_Injected(driver1);
  }

  public static unsafe void RegisterPropertyPartial(
    Object driver,
    Object target,
    string propertyPath)
  {
    if ((object) driver == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) driver, nameof (driver));
    if ((object) target == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) target, nameof (target));
    if (propertyPath == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) propertyPath, nameof (propertyPath));
    try
    {
      System.IntPtr driver1 = Object.MarshalledUnityObject.MarshalNotNull<Object>(driver);
      if (driver1 == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) driver, nameof (driver));
      System.IntPtr target1 = Object.MarshalledUnityObject.MarshalNotNull<Object>(target);
      if (target1 == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) target, nameof (target));
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(propertyPath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = propertyPath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      DrivenPropertyManager.RegisterPropertyPartial_Injected(driver1, target1, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void TryRegisterPropertyPartial(
    Object driver,
    Object target,
    string propertyPath)
  {
    if ((object) driver == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) driver, nameof (driver));
    if ((object) target == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) target, nameof (target));
    if (propertyPath == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) propertyPath, nameof (propertyPath));
    try
    {
      System.IntPtr driver1 = Object.MarshalledUnityObject.MarshalNotNull<Object>(driver);
      if (driver1 == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) driver, nameof (driver));
      System.IntPtr target1 = Object.MarshalledUnityObject.MarshalNotNull<Object>(target);
      if (target1 == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) target, nameof (target));
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(propertyPath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = propertyPath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      DrivenPropertyManager.TryRegisterPropertyPartial_Injected(driver1, target1, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static unsafe void UnregisterPropertyPartial(
    Object driver,
    Object target,
    string propertyPath)
  {
    if ((object) driver == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) driver, nameof (driver));
    if ((object) target == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) target, nameof (target));
    if (propertyPath == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) propertyPath, nameof (propertyPath));
    try
    {
      System.IntPtr driver1 = Object.MarshalledUnityObject.MarshalNotNull<Object>(driver);
      if (driver1 == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) driver, nameof (driver));
      System.IntPtr target1 = Object.MarshalledUnityObject.MarshalNotNull<Object>(target);
      if (target1 == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) target, nameof (target));
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(propertyPath, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = propertyPath.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      DrivenPropertyManager.UnregisterPropertyPartial_Injected(driver1, target1, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static void UnregisterProperties_Injected(System.IntPtr driver)
  {
    DrivenPropertyManager.UnregisterProperties_InjectedDelegateField(driver);
  }

  public static void RegisterPropertyPartial_Injected(
    System.IntPtr driver,
    System.IntPtr target,
    ref ManagedSpanWrapper propertyPath)
  {
    DrivenPropertyManager.RegisterPropertyPartial_InjectedDelegateField(driver, target, (System.IntPtr) ref propertyPath);
  }

  public static void TryRegisterPropertyPartial_Injected(
    System.IntPtr driver,
    System.IntPtr target,
    ref ManagedSpanWrapper propertyPath)
  {
    DrivenPropertyManager.TryRegisterPropertyPartial_InjectedDelegateField(driver, target, (System.IntPtr) ref propertyPath);
  }

  public static void UnregisterPropertyPartial_Injected(
    System.IntPtr driver,
    System.IntPtr target,
    ref ManagedSpanWrapper propertyPath)
  {
    DrivenPropertyManager.UnregisterPropertyPartial_InjectedDelegateField(driver, target, (System.IntPtr) ref propertyPath);
  }

  private delegate void UnregisterProperties_InjectedDelegate(System.IntPtr driver);

  private delegate void RegisterPropertyPartial_InjectedDelegate(
    System.IntPtr driver,
    System.IntPtr target,
    System.IntPtr propertyPath);

  private delegate void TryRegisterPropertyPartial_InjectedDelegate(
    System.IntPtr driver,
    System.IntPtr target,
    System.IntPtr propertyPath);

  private delegate void UnregisterPropertyPartial_InjectedDelegate(
    System.IntPtr driver,
    System.IntPtr target,
    System.IntPtr propertyPath);
}
