// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Rendering.BuiltinRuntimeReflectionSystem
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

#nullable disable
namespace UnityEngine.Experimental.Rendering;

public class BuiltinRuntimeReflectionSystem(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BuiltinRuntimeReflectionSystem()
  {
    Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Rendering", nameof (BuiltinRuntimeReflectionSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr);
    BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100670735);
    BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100670736);
    BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100670737);
    BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100670738);
    BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100670739);
    BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr, 100670740);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489660, XrefRangeEnd = 489662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool TickRealtimeProbes()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_TickRealtimeProbes_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose(bool disposing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &disposing
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool BuiltinUpdate()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_BuiltinUpdate_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489662, XrefRangeEnd = 489666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr_Internal_BuiltinRuntimeReflectionSystem_New_Private_Static_BuiltinRuntimeReflectionSystem_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BuiltinRuntimeReflectionSystem) null : Il2CppObjectPool.Get<BuiltinRuntimeReflectionSystem>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BuiltinRuntimeReflectionSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuiltinRuntimeReflectionSystem>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BuiltinRuntimeReflectionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
