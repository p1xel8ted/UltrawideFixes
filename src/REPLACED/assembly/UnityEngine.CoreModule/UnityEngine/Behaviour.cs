// Decompiled with JetBrains decompiler
// Type: UnityEngine.Behaviour
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine;

public class Behaviour(IntPtr pointer) : Component(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_isActiveAndEnabled_Injected_Private_Static_Boolean_IntPtr_0;

  static Behaviour()
  {
    Il2CppClassPointerStore<Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Behaviour));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Behaviour>.NativeClassPtr);
    Behaviour.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100667950);
    Behaviour.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100667951);
    Behaviour.NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100667952);
    Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100667953);
    Behaviour.NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100667954);
    Behaviour.NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100667955);
    Behaviour.NativeMethodInfoPtr_get_isActiveAndEnabled_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Behaviour>.NativeClassPtr, 100667956);
  }

  public unsafe bool enabled
  {
    [CallerCount(97), CachedScanResults(RefRangeStart = 443507, RefRangeEnd = 443604, XrefRangeStart = 443502, XrefRangeEnd = 443507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(141), CachedScanResults(RefRangeStart = 443609, RefRangeEnd = 443750, XrefRangeStart = 443604, XrefRangeEnd = 443609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe bool isActiveAndEnabled
  {
    [CallerCount(61), CachedScanResults(RefRangeStart = 443755, RefRangeEnd = 443816, XrefRangeStart = 443750, XrefRangeEnd = 443755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_isActiveAndEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(753)]
  [CachedScanResults(RefRangeStart = 443820, RefRangeEnd = 444573, XrefRangeStart = 443816, XrefRangeEnd = 443820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Behaviour()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Behaviour>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444573, XrefRangeEnd = 444575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_enabled_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_enabled_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444575, XrefRangeEnd = 444577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void set_enabled_Injected(IntPtr _unity_self, bool value)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &_unity_self;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_set_enabled_Injected_Private_Static_Void_IntPtr_Boolean_0, IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444577, XrefRangeEnd = 444579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_isActiveAndEnabled_Injected(IntPtr _unity_self)
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &_unity_self
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Behaviour.NativeMethodInfoPtr_get_isActiveAndEnabled_Injected_Private_Static_Boolean_IntPtr_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
