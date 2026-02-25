// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.RegisterPlayersOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct RegisterPlayersOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayersToRegister;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PlayersToRegisterCount;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RegisterPlayersOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SessionName;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_PlayersToRegister;
  [FieldOffset(24)]
  public uint m_PlayersToRegisterCount;

  static RegisterPlayersOptionsInternal()
  {
    Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (RegisterPlayersOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr);
    RegisterPlayersOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    RegisterPlayersOptionsInternal.NativeFieldInfoPtr_m_SessionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_SessionName));
    RegisterPlayersOptionsInternal.NativeFieldInfoPtr_m_PlayersToRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_PlayersToRegister));
    RegisterPlayersOptionsInternal.NativeFieldInfoPtr_m_PlayersToRegisterCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, nameof (m_PlayersToRegisterCount));
    RegisterPlayersOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100665680 /*0x06000950*/);
    RegisterPlayersOptionsInternal.NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100665681);
    RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterPlayersOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100665682);
    RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100665683);
    RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, 100665684);
  }

  public unsafe string SessionName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378112, XrefRangeEnd = 378116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_set_SessionName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<ProductUserId> PlayersToRegister
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 378122, RefRangeEnd = 378124, XrefRangeStart = 378116, XrefRangeEnd = 378122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_set_PlayersToRegister_Public_set_Void_Il2CppReferenceArray_1_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378124, XrefRangeEnd = 378129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(RegisterPlayersOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterPlayersOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378129, XrefRangeEnd = 378136, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378136, XrefRangeEnd = 378141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterPlayersOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterPlayersOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
