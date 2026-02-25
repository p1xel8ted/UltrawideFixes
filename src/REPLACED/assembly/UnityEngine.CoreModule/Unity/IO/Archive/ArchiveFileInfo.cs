// Decompiled with JetBrains decompiler
// Type: Unity.IO.Archive.ArchiveFileInfo
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IO.Archive;

public sealed class ArchiveFileInfo : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Filename;
  private static readonly System.IntPtr NativeFieldInfoPtr_FileSize;

  static ArchiveFileInfo()
  {
    Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.Archive", nameof (ArchiveFileInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr);
    ArchiveFileInfo.NativeFieldInfoPtr_Filename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr, nameof (Filename));
    ArchiveFileInfo.NativeFieldInfoPtr_FileSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr, nameof (FileSize));
  }

  public ArchiveFileInfo(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ArchiveFileInfo()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchiveFileInfo>.NativeClassPtr))
  {
  }

  public unsafe string Filename
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_Filename)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_Filename), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ulong FileSize
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_FileSize));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArchiveFileInfo.NativeFieldInfoPtr_FileSize)) = value;
    }
  }
}
