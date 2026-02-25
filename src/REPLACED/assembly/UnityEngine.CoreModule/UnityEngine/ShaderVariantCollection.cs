// Decompiled with JetBrains decompiler
// Type: UnityEngine.ShaderVariantCollection
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class ShaderVariantCollection : Object
{
  private static readonly ShaderVariantCollection.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.Internal_CreateDelegate>("UnityEngine.ShaderVariantCollection::Internal_Create");
  private static readonly ShaderVariantCollection.get_shaderCount_InjectedDelegate get_shaderCount_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_shaderCount_InjectedDelegate>("UnityEngine.ShaderVariantCollection::get_shaderCount_Injected");
  private static readonly ShaderVariantCollection.get_variantCount_InjectedDelegate get_variantCount_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_variantCount_InjectedDelegate>("UnityEngine.ShaderVariantCollection::get_variantCount_Injected");
  private static readonly ShaderVariantCollection.get_warmedUpVariantCount_InjectedDelegate get_warmedUpVariantCount_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_warmedUpVariantCount_InjectedDelegate>("UnityEngine.ShaderVariantCollection::get_warmedUpVariantCount_Injected");
  private static readonly ShaderVariantCollection.get_isWarmedUp_InjectedDelegate get_isWarmedUp_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_isWarmedUp_InjectedDelegate>("UnityEngine.ShaderVariantCollection::get_isWarmedUp_Injected");
  private static readonly ShaderVariantCollection.AddVariant_InjectedDelegate AddVariant_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.AddVariant_InjectedDelegate>("UnityEngine.ShaderVariantCollection::AddVariant_Injected");
  private static readonly ShaderVariantCollection.RemoveVariant_InjectedDelegate RemoveVariant_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.RemoveVariant_InjectedDelegate>("UnityEngine.ShaderVariantCollection::RemoveVariant_Injected");
  private static readonly ShaderVariantCollection.ContainsVariant_InjectedDelegate ContainsVariant_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ContainsVariant_InjectedDelegate>("UnityEngine.ShaderVariantCollection::ContainsVariant_Injected");
  private static readonly ShaderVariantCollection.Clear_InjectedDelegate Clear_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.Clear_InjectedDelegate>("UnityEngine.ShaderVariantCollection::Clear_Injected");
  private static readonly ShaderVariantCollection.WarmUp_InjectedDelegate WarmUp_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.WarmUp_InjectedDelegate>("UnityEngine.ShaderVariantCollection::WarmUp_Injected");
  private static readonly ShaderVariantCollection.WarmUpProgressively_InjectedDelegate WarmUpProgressively_InjectedDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.WarmUpProgressively_InjectedDelegate>("UnityEngine.ShaderVariantCollection::WarmUpProgressively_Injected");

  public int shaderCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ShaderVariantCollection.get_shaderCount_Injected(_unity_self);
    }
  }

  public int variantCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ShaderVariantCollection.get_variantCount_Injected(_unity_self);
    }
  }

  public int warmedUpVariantCount
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ShaderVariantCollection.get_warmedUpVariantCount_Injected(_unity_self);
    }
  }

  public bool isWarmedUp
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return ShaderVariantCollection.get_isWarmedUp_Injected(_unity_self);
    }
  }

  public bool AddVariant(Shader shader, PassType passType, Il2CppStringArray keywords)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ShaderVariantCollection.AddVariant_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Shader>(shader), passType, keywords);
  }

  public bool RemoveVariant(Shader shader, PassType passType, Il2CppStringArray keywords)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ShaderVariantCollection.RemoveVariant_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Shader>(shader), passType, keywords);
  }

  public bool ContainsVariant(Shader shader, PassType passType, Il2CppStringArray keywords)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ShaderVariantCollection.ContainsVariant_Injected(_unity_self, Object.MarshalledUnityObject.Marshal<Shader>(shader), passType, keywords);
  }

  public void Clear()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ShaderVariantCollection.Clear_Injected(_unity_self);
  }

  public void WarmUp()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ShaderVariantCollection.WarmUp_Injected(_unity_self);
  }

  public bool WarmUpProgressively(int variantCount)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ShaderVariantCollection>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ShaderVariantCollection.WarmUpProgressively_Injected(_unity_self, variantCount);
  }

  public static void Internal_Create(ShaderVariantCollection svc)
  {
    ShaderVariantCollection.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) svc));
  }

  public static int get_shaderCount_Injected(System.IntPtr _unity_self)
  {
    return ShaderVariantCollection.get_shaderCount_InjectedDelegateField(_unity_self);
  }

  public static int get_variantCount_Injected(System.IntPtr _unity_self)
  {
    return ShaderVariantCollection.get_variantCount_InjectedDelegateField(_unity_self);
  }

  public static int get_warmedUpVariantCount_Injected(System.IntPtr _unity_self)
  {
    return ShaderVariantCollection.get_warmedUpVariantCount_InjectedDelegateField(_unity_self);
  }

  public static bool get_isWarmedUp_Injected(System.IntPtr _unity_self)
  {
    return ShaderVariantCollection.get_isWarmedUp_InjectedDelegateField(_unity_self);
  }

  public static bool AddVariant_Injected(
    System.IntPtr _unity_self,
    System.IntPtr shader,
    PassType passType,
    Il2CppStringArray keywords)
  {
    return ShaderVariantCollection.AddVariant_InjectedDelegateField(_unity_self, shader, passType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keywords));
  }

  public static bool RemoveVariant_Injected(
    System.IntPtr _unity_self,
    System.IntPtr shader,
    PassType passType,
    Il2CppStringArray keywords)
  {
    return ShaderVariantCollection.RemoveVariant_InjectedDelegateField(_unity_self, shader, passType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keywords));
  }

  public static bool ContainsVariant_Injected(
    System.IntPtr _unity_self,
    System.IntPtr shader,
    PassType passType,
    Il2CppStringArray keywords)
  {
    return ShaderVariantCollection.ContainsVariant_InjectedDelegateField(_unity_self, shader, passType, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keywords));
  }

  public static void Clear_Injected(System.IntPtr _unity_self)
  {
    ShaderVariantCollection.Clear_InjectedDelegateField(_unity_self);
  }

  public static void WarmUp_Injected(System.IntPtr _unity_self)
  {
    ShaderVariantCollection.WarmUp_InjectedDelegateField(_unity_self);
  }

  public static bool WarmUpProgressively_Injected(System.IntPtr _unity_self, int variantCount)
  {
    return ShaderVariantCollection.WarmUpProgressively_InjectedDelegateField(_unity_self, variantCount);
  }

  private delegate void Internal_CreateDelegate(System.IntPtr svc);

  private delegate int get_shaderCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_variantCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_warmedUpVariantCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool get_isWarmedUp_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool AddVariant_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr shader,
    PassType passType,
    System.IntPtr keywords);

  private delegate bool RemoveVariant_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr shader,
    PassType passType,
    System.IntPtr keywords);

  private delegate bool ContainsVariant_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr shader,
    PassType passType,
    System.IntPtr keywords);

  private delegate void Clear_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void WarmUp_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool WarmUpProgressively_InjectedDelegate(System.IntPtr _unity_self, int variantCount);
}
