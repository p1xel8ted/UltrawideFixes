// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ShadowCastersCullingInfos
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class ShadowCastersCullingInfos : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_splitBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_perLightInfos;

  static ShadowCastersCullingInfos()
  {
    Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ShadowCastersCullingInfos));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr);
    ShadowCastersCullingInfos.NativeFieldInfoPtr_splitBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr, nameof (splitBuffer));
    ShadowCastersCullingInfos.NativeFieldInfoPtr_perLightInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr, nameof (perLightInfos));
  }

  public ShadowCastersCullingInfos(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ShadowCastersCullingInfos()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShadowCastersCullingInfos>.NativeClassPtr))
  {
  }

  public NativeArray<ShadowSplitData> splitBuffer
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastersCullingInfos.NativeFieldInfoPtr_splitBuffer);
      return new NativeArray<ShadowSplitData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<ShadowSplitData>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastersCullingInfos.NativeFieldInfoPtr_splitBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<ShadowSplitData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<LightShadowCasterCullingInfo> perLightInfos
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastersCullingInfos.NativeFieldInfoPtr_perLightInfos);
      return new NativeArray<LightShadowCasterCullingInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<LightShadowCasterCullingInfo>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShadowCastersCullingInfos.NativeFieldInfoPtr_perLightInfos), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<LightShadowCasterCullingInfo>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
