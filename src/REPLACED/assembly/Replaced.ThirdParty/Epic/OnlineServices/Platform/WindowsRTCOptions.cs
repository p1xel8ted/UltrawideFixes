// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsRTCOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

public class WindowsRTCOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PlatformSpecificOptions_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_WindowsRTCOptionsPlatformSpecificOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_WindowsRTCOptionsPlatformSpecificOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_WindowsRTCOptionsInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static WindowsRTCOptions()
  {
    Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (WindowsRTCOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr);
    WindowsRTCOptions.NativeFieldInfoPtr__PlatformSpecificOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, "<PlatformSpecificOptions>k__BackingField");
    WindowsRTCOptions.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, 100668143);
    WindowsRTCOptions.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, 100668144);
    WindowsRTCOptions.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_WindowsRTCOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, 100668145);
    WindowsRTCOptions.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, 100668146);
    WindowsRTCOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr, 100668147);
  }

  public unsafe WindowsRTCOptionsPlatformSpecificOptions PlatformSpecificOptions
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptions.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_WindowsRTCOptionsPlatformSpecificOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (WindowsRTCOptionsPlatformSpecificOptions) null : Il2CppObjectPool.Get<WindowsRTCOptionsPlatformSpecificOptions>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptions.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_WindowsRTCOptionsPlatformSpecificOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386079, XrefRangeEnd = 386089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<WindowsRTCOptionsInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptions.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_WindowsRTCOptionsInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386089, XrefRangeEnd = 386103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptions.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WindowsRTCOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsRTCOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe WindowsRTCOptionsPlatformSpecificOptions _PlatformSpecificOptions_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsRTCOptions.NativeFieldInfoPtr__PlatformSpecificOptions_k__BackingField));
      return num == System.IntPtr.Zero ? (WindowsRTCOptionsPlatformSpecificOptions) null : Il2CppObjectPool.Get<WindowsRTCOptionsPlatformSpecificOptions>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsRTCOptions.NativeFieldInfoPtr__PlatformSpecificOptions_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
