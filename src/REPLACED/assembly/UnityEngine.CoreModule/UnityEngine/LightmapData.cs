// Decompiled with JetBrains decompiler
// Type: UnityEngine.LightmapData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class LightmapData(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Light;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Dir;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ShadowMask;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LightmapData()
  {
    Il2CppClassPointerStore<LightmapData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (LightmapData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightmapData>.NativeClassPtr);
    LightmapData.NativeFieldInfoPtr_m_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, nameof (m_Light));
    LightmapData.NativeFieldInfoPtr_m_Dir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, nameof (m_Dir));
    LightmapData.NativeFieldInfoPtr_m_ShadowMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, nameof (m_ShadowMask));
    LightmapData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightmapData>.NativeClassPtr, 100664761);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LightmapData()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightmapData>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LightmapData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Texture2D m_Light
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Light));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Light), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D m_Dir
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Dir));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_Dir), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Texture2D m_ShadowMask
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_ShadowMask));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LightmapData.NativeFieldInfoPtr_m_ShadowMask), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public Texture2D lightmapLight
  {
    get => this.m_Light;
    set => this.m_Light = value;
  }

  public Texture2D lightmapColor
  {
    get => this.m_Light;
    set => this.m_Light = value;
  }

  public Texture2D lightmapDir
  {
    get => this.m_Dir;
    set => this.m_Dir = value;
  }

  public Texture2D shadowMask
  {
    get => this.m_ShadowMask;
    set => this.m_ShadowMask = value;
  }
}
