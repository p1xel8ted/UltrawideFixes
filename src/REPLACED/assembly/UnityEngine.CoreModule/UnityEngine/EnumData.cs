// Decompiled with JetBrains decompiler
// Type: UnityEngine.EnumData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class EnumData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_values;
  private static readonly System.IntPtr NativeFieldInfoPtr_flagValues;
  private static readonly System.IntPtr NativeFieldInfoPtr_displayNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_names;
  private static readonly System.IntPtr NativeFieldInfoPtr_tooltip;
  private static readonly System.IntPtr NativeFieldInfoPtr_flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_underlyingType;
  private static readonly System.IntPtr NativeFieldInfoPtr_unsigned;
  private static readonly System.IntPtr NativeFieldInfoPtr_serializable;

  static EnumData()
  {
    Il2CppClassPointerStore<EnumData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (EnumData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumData>.NativeClassPtr);
    EnumData.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (values));
    EnumData.NativeFieldInfoPtr_flagValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (flagValues));
    EnumData.NativeFieldInfoPtr_displayNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (displayNames));
    EnumData.NativeFieldInfoPtr_names = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (names));
    EnumData.NativeFieldInfoPtr_tooltip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (tooltip));
    EnumData.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (flags));
    EnumData.NativeFieldInfoPtr_underlyingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (underlyingType));
    EnumData.NativeFieldInfoPtr_unsigned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (unsigned));
    EnumData.NativeFieldInfoPtr_serializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumData>.NativeClassPtr, nameof (serializable));
  }

  public EnumData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public EnumData()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumData>.NativeClassPtr))
  {
  }

  public unsafe Il2CppStructArray<Il2CppSystem.Enum> values
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_values));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<Il2CppSystem.Enum>) null : Il2CppObjectPool.Get<Il2CppStructArray<Il2CppSystem.Enum>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<int> flagValues
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flagValues));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : Il2CppObjectPool.Get<Il2CppStructArray<int>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flagValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray displayNames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_displayNames));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_displayNames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray names
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_names));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_names), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStringArray tooltip
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_tooltip));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_tooltip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool flags
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flags));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_flags)) = value;
    }
  }

  public unsafe Il2CppSystem.Type underlyingType
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_underlyingType));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_underlyingType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool unsigned
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_unsigned));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_unsigned)) = value;
    }
  }

  public unsafe bool serializable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_serializable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumData.NativeFieldInfoPtr_serializable)) = value;
    }
  }
}
