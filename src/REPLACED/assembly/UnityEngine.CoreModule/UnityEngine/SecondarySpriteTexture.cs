// Decompiled with JetBrains decompiler
// Type: UnityEngine.SecondarySpriteTexture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[Serializable]
public sealed class SecondarySpriteTexture : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_name;
  private static readonly System.IntPtr NativeFieldInfoPtr_texture;

  static SecondarySpriteTexture()
  {
    Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (SecondarySpriteTexture));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr);
    SecondarySpriteTexture.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr, nameof (name));
    SecondarySpriteTexture.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr, nameof (texture));
  }

  public SecondarySpriteTexture(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public SecondarySpriteTexture()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecondarySpriteTexture>.NativeClassPtr))
  {
  }

  public unsafe string name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Texture2D texture
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_texture));
      return num == System.IntPtr.Zero ? (Texture2D) null : Il2CppObjectPool.Get<Texture2D>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SecondarySpriteTexture.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
