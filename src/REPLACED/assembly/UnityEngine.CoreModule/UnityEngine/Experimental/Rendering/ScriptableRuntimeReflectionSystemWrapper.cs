// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.ScriptableRuntimeReflectionSystemWrapper
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public class ScriptableRuntimeReflectionSystemWrapper(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__implementation_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ScriptableRuntimeReflectionSystemWrapper()
  {
    Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", nameof (ScriptableRuntimeReflectionSystemWrapper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr);
    ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, "<implementation>k__BackingField");
    ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100670746);
    ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100670747);
    ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100670748);
    ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr, 100670749);
  }

  public unsafe IScriptableRuntimeReflectionSystem implementation
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_get_implementation_Internal_get_IScriptableRuntimeReflectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IScriptableRuntimeReflectionSystem) null : Il2CppObjectPool.Get<IScriptableRuntimeReflectionSystem>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_set_implementation_Internal_set_Void_IScriptableRuntimeReflectionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489692, XrefRangeEnd = 489693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(
    out bool result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref result
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr_Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes_Private_Void_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptableRuntimeReflectionSystemWrapper()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableRuntimeReflectionSystemWrapper>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptableRuntimeReflectionSystemWrapper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe IScriptableRuntimeReflectionSystem _implementation_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField));
      return num == System.IntPtr.Zero ? (IScriptableRuntimeReflectionSystem) null : Il2CppObjectPool.Get<IScriptableRuntimeReflectionSystem>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptableRuntimeReflectionSystemWrapper.NativeFieldInfoPtr__implementation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
