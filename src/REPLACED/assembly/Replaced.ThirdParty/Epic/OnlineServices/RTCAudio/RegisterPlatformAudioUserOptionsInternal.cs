// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.RegisterPlatformAudioUserOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio;

[StructLayout(LayoutKind.Explicit)]
public struct RegisterPlatformAudioUserOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RegisterPlatformAudioUserOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_UserId;

  static RegisterPlatformAudioUserOptionsInternal()
  {
    Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.RTCAudio", nameof (RegisterPlatformAudioUserOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr);
    RegisterPlatformAudioUserOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    RegisterPlatformAudioUserOptionsInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr, nameof (m_UserId));
    RegisterPlatformAudioUserOptionsInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr, 100666519);
    RegisterPlatformAudioUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterPlatformAudioUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr, 100666520);
    RegisterPlatformAudioUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr, 100666521);
    RegisterPlatformAudioUserOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr, 100666522);
  }

  public unsafe string UserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380810, XrefRangeEnd = 380814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPlatformAudioUserOptionsInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380814, XrefRangeEnd = 380818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(RegisterPlatformAudioUserOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPlatformAudioUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterPlatformAudioUserOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380818, XrefRangeEnd = 380824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPlatformAudioUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 380824, XrefRangeEnd = 380828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPlatformAudioUserOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterPlatformAudioUserOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
