// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.WindowsRTCOptionsInternal
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

[StructLayout(LayoutKind.Explicit)]
public struct WindowsRTCOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlatformSpecificOptions;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_WindowsRTCOptionsPlatformSpecificOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_WindowsRTCOptionsPlatformSpecificOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_WindowsRTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_PlatformSpecificOptions;

  static WindowsRTCOptionsInternal()
  {
    Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (WindowsRTCOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr);
    WindowsRTCOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    WindowsRTCOptionsInternal.NativeFieldInfoPtr_m_PlatformSpecificOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, nameof (m_PlatformSpecificOptions));
    WindowsRTCOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100668148);
    WindowsRTCOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_WindowsRTCOptionsPlatformSpecificOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100668149);
    WindowsRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_WindowsRTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100668150);
    WindowsRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100668151);
    WindowsRTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, 100668152);
  }

  public unsafe WindowsRTCOptionsPlatformSpecificOptions PlatformSpecificOptions
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386103, XrefRangeEnd = 386109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_WindowsRTCOptionsPlatformSpecificOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (WindowsRTCOptionsPlatformSpecificOptions) null : Il2CppObjectPool.Get<WindowsRTCOptionsPlatformSpecificOptions>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 386115, RefRangeEnd = 386117, XrefRangeStart = 386109, XrefRangeEnd = 386115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_WindowsRTCOptionsPlatformSpecificOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386117, XrefRangeEnd = 386118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(WindowsRTCOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_WindowsRTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386118, XrefRangeEnd = 386121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 386121, XrefRangeEnd = 386125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WindowsRTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WindowsRTCOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
