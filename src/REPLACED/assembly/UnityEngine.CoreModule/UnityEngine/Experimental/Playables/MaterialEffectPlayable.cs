// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Playables.MaterialEffectPlayable
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Experimental.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct MaterialEffectPlayable
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0;
  [FieldOffset(0)]
  public PlayableHandle m_Handle;
  private static readonly MaterialEffectPlayable.GetPassInternalDelegate GetPassInternalDelegateField;
  private static readonly MaterialEffectPlayable.SetPassInternalDelegate SetPassInternalDelegateField;
  private static readonly MaterialEffectPlayable.ValidateTypeDelegate ValidateTypeDelegateField;
  private static readonly MaterialEffectPlayable.GetMaterialInternal_InjectedDelegate GetMaterialInternal_InjectedDelegateField;
  private static readonly MaterialEffectPlayable.SetMaterialInternal_InjectedDelegate SetMaterialInternal_InjectedDelegateField;
  private static readonly MaterialEffectPlayable.InternalCreateMaterialEffectPlayable_InjectedDelegate InternalCreateMaterialEffectPlayable_InjectedDelegateField;

  static MaterialEffectPlayable()
  {
    Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", nameof (MaterialEffectPlayable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr);
    MaterialEffectPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, nameof (m_Handle));
    MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100670730);
    MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100670731);
    MaterialEffectPlayable.GetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetPassInternal");
    MaterialEffectPlayable.SetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetPassInternal");
    MaterialEffectPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::ValidateType");
    MaterialEffectPlayable.GetMaterialInternal_InjectedDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetMaterialInternal_InjectedDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetMaterialInternal_Injected");
    MaterialEffectPlayable.SetMaterialInternal_InjectedDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetMaterialInternal_InjectedDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetMaterialInternal_Injected");
    MaterialEffectPlayable.InternalCreateMaterialEffectPlayable_InjectedDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.InternalCreateMaterialEffectPlayable_InjectedDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::InternalCreateMaterialEffectPlayable_Injected");
  }

  [CallerCount(49)]
  [CachedScanResults(RefRangeStart = 480002, RefRangeEnd = 480051, XrefRangeStart = 480002, XrefRangeEnd = 480051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PlayableHandle GetHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489652, XrefRangeEnd = 489656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(MaterialEffectPlayable other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static MaterialEffectPlayable Create(PlayableGraph graph, Material material, int pass = default (int))
  {
    return new MaterialEffectPlayable(MaterialEffectPlayable.CreateHandle(graph, material, pass));
  }

  public static PlayableHandle CreateHandle(PlayableGraph graph, Material material, int pass)
  {
    PlayableHandle handle = PlayableHandle.Null;
    return !MaterialEffectPlayable.InternalCreateMaterialEffectPlayable(ref graph, material, pass, ref handle) ? PlayableHandle.Null : handle;
  }

  public static implicit operator Playable(MaterialEffectPlayable playable)
  {
    return new Playable(playable.GetHandle());
  }

  public static explicit operator MaterialEffectPlayable(Playable playable)
  {
    return new MaterialEffectPlayable(playable.GetHandle());
  }

  public Material GetMaterial() => MaterialEffectPlayable.GetMaterialInternal(ref this.m_Handle);

  public void SetMaterial(Material value)
  {
    MaterialEffectPlayable.SetMaterialInternal(ref this.m_Handle, value);
  }

  public int GetPass() => MaterialEffectPlayable.GetPassInternal(ref this.m_Handle);

  public void SetPass(int value)
  {
    MaterialEffectPlayable.SetPassInternal(ref this.m_Handle, value);
  }

  public static Material GetMaterialInternal(ref PlayableHandle hdl)
  {
    return Unmarshal.UnmarshalUnityObject<Material>(MaterialEffectPlayable.GetMaterialInternal_Injected(ref hdl));
  }

  public static void SetMaterialInternal(ref PlayableHandle hdl, Material material)
  {
    MaterialEffectPlayable.SetMaterialInternal_Injected(ref hdl, UnityEngine.Object.MarshalledUnityObject.Marshal<Material>(material));
  }

  public static int GetPassInternal(ref PlayableHandle hdl)
  {
    return MaterialEffectPlayable.GetPassInternalDelegateField((System.IntPtr) ref hdl);
  }

  public static void SetPassInternal(ref PlayableHandle hdl, int pass)
  {
    MaterialEffectPlayable.SetPassInternalDelegateField((System.IntPtr) ref hdl, pass);
  }

  public static bool InternalCreateMaterialEffectPlayable(
    ref PlayableGraph graph,
    Material material,
    int pass,
    ref PlayableHandle handle)
  {
    return MaterialEffectPlayable.InternalCreateMaterialEffectPlayable_Injected(ref graph, UnityEngine.Object.MarshalledUnityObject.Marshal<Material>(material), pass, ref handle);
  }

  public static bool ValidateType(ref PlayableHandle hdl)
  {
    return MaterialEffectPlayable.ValidateTypeDelegateField((System.IntPtr) ref hdl);
  }

  public static System.IntPtr GetMaterialInternal_Injected(ref PlayableHandle hdl)
  {
    return MaterialEffectPlayable.GetMaterialInternal_InjectedDelegateField((System.IntPtr) ref hdl);
  }

  public static void SetMaterialInternal_Injected(ref PlayableHandle hdl, System.IntPtr material)
  {
    MaterialEffectPlayable.SetMaterialInternal_InjectedDelegateField((System.IntPtr) ref hdl, material);
  }

  public static bool InternalCreateMaterialEffectPlayable_Injected(
    ref PlayableGraph graph,
    System.IntPtr material,
    int pass,
    ref PlayableHandle handle)
  {
    return MaterialEffectPlayable.InternalCreateMaterialEffectPlayable_InjectedDelegateField((System.IntPtr) ref graph, material, pass, (System.IntPtr) ref handle);
  }

  private delegate int GetPassInternalDelegate(System.IntPtr hdl);

  private delegate void SetPassInternalDelegate(System.IntPtr hdl, int pass);

  private delegate bool ValidateTypeDelegate(System.IntPtr hdl);

  private delegate System.IntPtr GetMaterialInternal_InjectedDelegate(System.IntPtr hdl);

  private delegate void SetMaterialInternal_InjectedDelegate(System.IntPtr hdl, System.IntPtr material);

  private delegate bool InternalCreateMaterialEffectPlayable_InjectedDelegate(
    System.IntPtr graph,
    System.IntPtr material,
    int pass,
    System.IntPtr handle);
}
