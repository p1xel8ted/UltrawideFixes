// Decompiled with JetBrains decompiler
// Type: UnityEngine.DisplayInfo
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class DisplayInfo : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_handle;
  private static readonly System.IntPtr NativeFieldInfoPtr_width;
  private static readonly System.IntPtr NativeFieldInfoPtr_height;
  private static readonly System.IntPtr NativeFieldInfoPtr_refreshRate;
  private static readonly System.IntPtr NativeFieldInfoPtr_workArea;
  private static readonly System.IntPtr NativeFieldInfoPtr_name;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DisplayInfo_0;

  static DisplayInfo()
  {
    Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (DisplayInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr);
    DisplayInfo.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, nameof (handle));
    DisplayInfo.NativeFieldInfoPtr_width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, nameof (width));
    DisplayInfo.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, nameof (height));
    DisplayInfo.NativeFieldInfoPtr_refreshRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, nameof (refreshRate));
    DisplayInfo.NativeFieldInfoPtr_workArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, nameof (workArea));
    DisplayInfo.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, nameof (name));
    DisplayInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DisplayInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr, 100664675);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422985, XrefRangeEnd = 422987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(DisplayInfo other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DisplayInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DisplayInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public DisplayInfo(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public DisplayInfo()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplayInfo>.NativeClassPtr))
  {
  }

  public unsafe ulong handle
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_handle));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_handle)) = value;
    }
  }

  public unsafe int width
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_width));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_width)) = value;
    }
  }

  public unsafe int height
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_height));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_height)) = value;
    }
  }

  public unsafe RefreshRate refreshRate
  {
    get
    {
      return *(RefreshRate*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_refreshRate));
    }
    [param: In] set
    {
      *(RefreshRate*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_refreshRate)) = value;
    }
  }

  public unsafe RectInt workArea
  {
    get
    {
      return *(RectInt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_workArea));
    }
    [param: In] set
    {
      *(RectInt*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_workArea)) = value;
    }
  }

  public unsafe string name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DisplayInfo.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
