// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsRTCOptionsPlatformSpecificOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

[StructLayout(LayoutKind.Explicit)]
public struct WindowsRTCOptionsPlatformSpecificOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_XAudio29DllPath;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_WindowsRTCOptionsPlatformSpecificOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_XAudio29DllPath;

  static WindowsRTCOptionsPlatformSpecificOptionsInternal()
  {
    Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (WindowsRTCOptionsPlatformSpecificOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr);
    WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeFieldInfoPtr_m_XAudio29DllPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, nameof (m_XAudio29DllPath));
    WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100668158);
    WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100668159);
    WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100668160 /*0x06001300*/);
    WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100668161);
    WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, 100668162);
  }

  public unsafe string XAudio29DllPath
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386145, XrefRangeEnd = 386149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_get_XAudio29DllPath_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386149, XrefRangeEnd = 386153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_set_XAudio29DllPath_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386153, XrefRangeEnd = 386157, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(WindowsRTCOptionsPlatformSpecificOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_WindowsRTCOptionsPlatformSpecificOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386157, XrefRangeEnd = 386163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386163, XrefRangeEnd = 386167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsPlatformSpecificOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowsRTCOptionsPlatformSpecificOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
