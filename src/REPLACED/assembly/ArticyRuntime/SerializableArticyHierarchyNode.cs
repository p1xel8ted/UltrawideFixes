// Decompiled with JetBrains decompiler
// Type: Articy.Unity.SerializableArticyHierarchyNode
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public sealed class SerializableArticyHierarchyNode : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeFieldInfoPtr_parent;
  private static readonly System.IntPtr NativeFieldInfoPtr_technicalName;
  private static readonly System.IntPtr NativeFieldInfoPtr_articyType;
  private static readonly System.IntPtr NativeFieldInfoPtr_childCount;

  static SerializableArticyHierarchyNode()
  {
    Il2CppClassPointerStore<SerializableArticyHierarchyNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (SerializableArticyHierarchyNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableArticyHierarchyNode>.NativeClassPtr);
    SerializableArticyHierarchyNode.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableArticyHierarchyNode>.NativeClassPtr, nameof (id));
    SerializableArticyHierarchyNode.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableArticyHierarchyNode>.NativeClassPtr, nameof (parent));
    SerializableArticyHierarchyNode.NativeFieldInfoPtr_technicalName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableArticyHierarchyNode>.NativeClassPtr, nameof (technicalName));
    SerializableArticyHierarchyNode.NativeFieldInfoPtr_articyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableArticyHierarchyNode>.NativeClassPtr, nameof (articyType));
    SerializableArticyHierarchyNode.NativeFieldInfoPtr_childCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableArticyHierarchyNode>.NativeClassPtr, nameof (childCount));
  }

  public SerializableArticyHierarchyNode(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public SerializableArticyHierarchyNode()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableArticyHierarchyNode>.NativeClassPtr))
  {
  }

  public unsafe ulong id
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_id)) = value;
    }
  }

  public unsafe ulong parent
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_parent));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_parent)) = value;
    }
  }

  public unsafe string technicalName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_technicalName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_technicalName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string articyType
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_articyType)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_articyType), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int childCount
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_childCount));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SerializableArticyHierarchyNode.NativeFieldInfoPtr_childCount)) = value;
    }
  }
}
