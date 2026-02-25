// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsRTCOptionsPlatformSpecificOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

public class WindowsRTCOptionsPlatformSpecificOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__XAudio29DllPath_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptionsInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static WindowsRTCOptionsPlatformSpecificOptions()
  {
    Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (WindowsRTCOptionsPlatformSpecificOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr);
    WindowsRTCOptionsPlatformSpecificOptions.NativeFieldInfoPtr__XAudio29DllPath_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr, "<XAudio29DllPath>k__BackingField");
    WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr, 100668153);
    WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr, 100668154);
    WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr, 100668155);
    WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr, 100668156);
    WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr, 100668157);
  }

  public unsafe string XAudio29DllPath
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386125, XrefRangeEnd = 386133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<WindowsRTCOptionsPlatformSpecificOptionsInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_WindowsRTCOptionsPlatformSpecificOptionsInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386133, XrefRangeEnd = 386145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WindowsRTCOptionsPlatformSpecificOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _XAudio29DllPath_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WindowsRTCOptionsPlatformSpecificOptions.NativeFieldInfoPtr__XAudio29DllPath_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WindowsRTCOptionsPlatformSpecificOptions.NativeFieldInfoPtr__XAudio29DllPath_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
