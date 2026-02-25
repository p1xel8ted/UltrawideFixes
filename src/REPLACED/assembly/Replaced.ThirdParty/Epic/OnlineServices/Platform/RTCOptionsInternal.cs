// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.RTCOptionsInternal
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
public struct RTCOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlatformSpecificOptions;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RTCOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_PlatformSpecificOptions;

  static RTCOptionsInternal()
  {
    Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (RTCOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr);
    RTCOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    RTCOptionsInternal.NativeFieldInfoPtr_m_PlatformSpecificOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, nameof (m_PlatformSpecificOptions));
    RTCOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100668095);
    RTCOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100668096);
    RTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RTCOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100668097);
    RTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100668098);
    RTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, 100668099);
  }

  public unsafe System.IntPtr PlatformSpecificOptions
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_get_PlatformSpecificOptions_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_set_PlatformSpecificOptions_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(RTCOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RTCOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385974, XrefRangeEnd = 385976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385976, XrefRangeEnd = 385980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RTCOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTCOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
