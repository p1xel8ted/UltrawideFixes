// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderPipelineGraphicsSettingsExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace UnityEngine.Rendering;

public static class RenderPipelineGraphicsSettingsExtensions : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0;

  static RenderPipelineGraphicsSettingsExtensions()
  {
    Il2CppClassPointerStore<RenderPipelineGraphicsSettingsExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderPipelineGraphicsSettingsExtensions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsExtensions>.NativeClassPtr);
    RenderPipelineGraphicsSettingsExtensions.NativeMethodInfoPtr_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsExtensions>.NativeClassPtr, 100670257);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 486863, RefRangeEnd = 486876, XrefRangeStart = 486854, XrefRangeEnd = 486863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetValueAndNotify<T>(
    this IRenderPipelineGraphicsSettings settings,
    ref T currentPropertyValue,
    T newValue,
    string propertyName = null)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) currentPropertyValue);
    System.IntPtr* numPtr2 = &ptr;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) newValue;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref newValue;
    *(System.IntPtr*) num2 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(propertyName);
    System.IntPtr num3;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineGraphicsSettingsExtensions.MethodInfoStoreGeneric_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr1, ref num3);
    Il2CppException.RaiseExceptionIfNecessary(num3);
    ref T local3 = ref currentPropertyValue;
    System.IntPtr num4 = ptr;
    // ISSUE: variable of the null type
    __Null valueGeneric = num4 == System.IntPtr.Zero ? null : (__Null) IL2CPP.PointerToValueGeneric<T>(num4, false, false);
    local3 = (T) valueGeneric;
  }

  public RenderPipelineGraphicsSettingsExtensions(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static void NotifyValueChanged(
    IRenderPipelineGraphicsSettings settings,
    string propertyName = null)
  {
    throw new Il2CppSystem.Exception("Notifying change of a property in standalone builds is forbidden.");
  }

  private sealed class MethodInfoStoreGeneric_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipelineGraphicsSettingsExtensions.NativeMethodInfoPtr_SetValueAndNotify_Public_Static_Void_IRenderPipelineGraphicsSettings_byref_T_T_String_0, Il2CppClassPointerStore<RenderPipelineGraphicsSettingsExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
