// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RenderPipelineGraphicsSettingsCollection
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[Serializable]
public class RenderPipelineGraphicsSettingsCollection(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_List;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_settingsList_Public_get_List_1_IRenderPipelineGraphicsSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static RenderPipelineGraphicsSettingsCollection()
  {
    Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RenderPipelineGraphicsSettingsCollection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr);
    RenderPipelineGraphicsSettingsCollection.NativeFieldInfoPtr_m_List = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr, nameof (m_List));
    RenderPipelineGraphicsSettingsCollection.NativeMethodInfoPtr_get_settingsList_Public_get_List_1_IRenderPipelineGraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr, 100670255);
    RenderPipelineGraphicsSettingsCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr, 100670256);
  }

  public unsafe List<IRenderPipelineGraphicsSettings> settingsList
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RenderPipelineGraphicsSettingsCollection.NativeMethodInfoPtr_get_settingsList_Public_get_List_1_IRenderPipelineGraphicsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<IRenderPipelineGraphicsSettings>) null : Il2CppObjectPool.Get<List<IRenderPipelineGraphicsSettings>>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 486853, RefRangeEnd = 486854, XrefRangeStart = 486846, XrefRangeEnd = 486853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RenderPipelineGraphicsSettingsCollection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipelineGraphicsSettingsCollection>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RenderPipelineGraphicsSettingsCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<IRenderPipelineGraphicsSettings> m_List
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RenderPipelineGraphicsSettingsCollection.NativeFieldInfoPtr_m_List));
      return num == System.IntPtr.Zero ? (List<IRenderPipelineGraphicsSettings>) null : Il2CppObjectPool.Get<List<IRenderPipelineGraphicsSettings>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RenderPipelineGraphicsSettingsCollection.NativeFieldInfoPtr_m_List), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
