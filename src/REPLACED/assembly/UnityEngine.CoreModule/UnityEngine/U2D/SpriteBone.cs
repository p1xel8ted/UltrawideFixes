// Decompiled with JetBrains decompiler
// Type: UnityEngine.U2D.SpriteBone
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.U2D;

[Serializable]
public sealed class SpriteBone : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Guid;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Rotation;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Length;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParentId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Color;

  static SpriteBone()
  {
    Il2CppClassPointerStore<SpriteBone>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", nameof (SpriteBone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr);
    SpriteBone.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, nameof (m_Name));
    SpriteBone.NativeFieldInfoPtr_m_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, nameof (m_Guid));
    SpriteBone.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, nameof (m_Position));
    SpriteBone.NativeFieldInfoPtr_m_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, nameof (m_Rotation));
    SpriteBone.NativeFieldInfoPtr_m_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, nameof (m_Length));
    SpriteBone.NativeFieldInfoPtr_m_ParentId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, nameof (m_ParentId));
    SpriteBone.NativeFieldInfoPtr_m_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr, nameof (m_Color));
  }

  public SpriteBone(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public SpriteBone()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpriteBone>.NativeClassPtr))
  {
  }

  public unsafe string m_Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string m_Guid
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Guid)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Vector3 m_Position
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Position)) = value;
    }
  }

  public unsafe Quaternion m_Rotation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Rotation)) = value;
    }
  }

  public unsafe float m_Length
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Length)) = value;
    }
  }

  public unsafe int m_ParentId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_ParentId)) = value;
    }
  }

  public unsafe Color32 m_Color
  {
    get
    {
      return *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Color));
    }
    [param: In] set
    {
      *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpriteBone.NativeFieldInfoPtr_m_Color)) = value;
    }
  }

  public string name
  {
    get => this.m_Name;
    set => this.m_Name = value;
  }

  public string guid
  {
    get => this.m_Guid;
    set => this.m_Guid = value;
  }

  public Vector3 position
  {
    get => this.m_Position;
    set => this.m_Position = value;
  }

  public Quaternion rotation
  {
    get => this.m_Rotation;
    set => this.m_Rotation = value;
  }

  public float length
  {
    get => this.m_Length;
    set => this.m_Length = value;
  }

  public int parentId
  {
    get => this.m_ParentId;
    set => this.m_ParentId = value;
  }

  public Color32 color
  {
    get => this.m_Color;
    set => this.m_Color = value;
  }
}
