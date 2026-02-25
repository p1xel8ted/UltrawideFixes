// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.IRenderPipelineGraphicsSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine.Rendering;

public class IRenderPipelineGraphicsSettings(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_get_version_Public_Abstract_Virtual_New_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_isAvailableInPlayerBuild_Public_Virtual_New_get_Boolean_0;

  static IRenderPipelineGraphicsSettings()
  {
    Il2CppClassPointerStore<IRenderPipelineGraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (IRenderPipelineGraphicsSettings));
    IRenderPipelineGraphicsSettings.NativeMethodInfoPtr_get_version_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderPipelineGraphicsSettings>.NativeClassPtr, 100669704);
    IRenderPipelineGraphicsSettings.NativeMethodInfoPtr_get_isAvailableInPlayerBuild_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IRenderPipelineGraphicsSettings>.NativeClassPtr, 100669705);
  }

  public virtual unsafe int version
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRenderPipelineGraphicsSettings.NativeMethodInfoPtr_get_version_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual unsafe bool isAvailableInPlayerBuild
  {
    [CallerCount(194), CachedScanResults(RefRangeStart = 65249, RefRangeEnd = 65443, XrefRangeStart = 65249, XrefRangeEnd = 65443, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IRenderPipelineGraphicsSettings.NativeMethodInfoPtr_get_isAvailableInPlayerBuild_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public virtual void Reset()
  {
  }
}
