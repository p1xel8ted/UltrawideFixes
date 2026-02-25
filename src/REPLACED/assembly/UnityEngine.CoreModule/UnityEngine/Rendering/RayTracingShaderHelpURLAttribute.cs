// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RayTracingShaderHelpURLAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine.Rendering;

public class RayTracingShaderHelpURLAttribute(IntPtr pointer) : HelpURLAttribute(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_URL_Public_Virtual_get_String_0;

  static RayTracingShaderHelpURLAttribute()
  {
    Il2CppClassPointerStore<RayTracingShaderHelpURLAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RayTracingShaderHelpURLAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayTracingShaderHelpURLAttribute>.NativeClassPtr);
    RayTracingShaderHelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingShaderHelpURLAttribute>.NativeClassPtr, 100670664);
    RayTracingShaderHelpURLAttribute.NativeMethodInfoPtr_get_URL_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayTracingShaderHelpURLAttribute>.NativeClassPtr, 100670665);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489141, XrefRangeEnd = 489142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RayTracingShaderHelpURLAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RayTracingShaderHelpURLAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RayTracingShaderHelpURLAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public override unsafe string URL
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489142, XrefRangeEnd = 489154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RayTracingShaderHelpURLAttribute.NativeMethodInfoPtr_get_URL_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }
}
