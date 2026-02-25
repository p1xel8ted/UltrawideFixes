// Decompiled with JetBrains decompiler
// Type: UnityEngine.InstantiateParameters
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.SceneManagement;

#nullable disable
namespace UnityEngine;

public sealed class InstantiateParameters : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_parent;
  private static readonly System.IntPtr NativeFieldInfoPtr_scene;
  private static readonly System.IntPtr NativeFieldInfoPtr_worldSpace;
  private static readonly System.IntPtr NativeFieldInfoPtr_originalImmutable;

  static InstantiateParameters()
  {
    Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (InstantiateParameters));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr);
    InstantiateParameters.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr, nameof (parent));
    InstantiateParameters.NativeFieldInfoPtr_scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr, nameof (scene));
    InstantiateParameters.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr, nameof (worldSpace));
    InstantiateParameters.NativeFieldInfoPtr_originalImmutable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr, nameof (originalImmutable));
  }

  public InstantiateParameters(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public InstantiateParameters()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstantiateParameters>.NativeClassPtr))
  {
  }

  public unsafe Transform parent
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_parent));
      return num == System.IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Scene scene
  {
    get
    {
      return *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_scene));
    }
    [param: In] set
    {
      *(Scene*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_scene)) = value;
    }
  }

  public unsafe bool worldSpace
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_worldSpace));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_worldSpace)) = value;
    }
  }

  public unsafe bool originalImmutable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_originalImmutable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InstantiateParameters.NativeFieldInfoPtr_originalImmutable)) = value;
    }
  }
}
