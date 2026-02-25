// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.SetClientDetailsOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

[StructLayout(LayoutKind.Explicit)]
public struct SetClientDetailsOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientFlags;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientInputMethod;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SetClientDetailsOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ClientHandle;
  [FieldOffset(16 /*0x10*/)]
  public AntiCheatCommonClientFlags m_ClientFlags;
  [FieldOffset(20)]
  public AntiCheatCommonClientInput m_ClientInputMethod;

  static SetClientDetailsOptionsInternal()
  {
    Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (SetClientDetailsOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr);
    SetClientDetailsOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SetClientDetailsOptionsInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, nameof (m_ClientHandle));
    SetClientDetailsOptionsInternal.NativeFieldInfoPtr_m_ClientFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, nameof (m_ClientFlags));
    SetClientDetailsOptionsInternal.NativeFieldInfoPtr_m_ClientInputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, nameof (m_ClientInputMethod));
    SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100672975);
    SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100672976);
    SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100672977);
    SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetClientDetailsOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100672978);
    SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100672979);
    SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, 100672980);
  }

  public unsafe System.IntPtr ClientHandle
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientFlags ClientFlags
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientFlags_Public_set_Void_AntiCheatCommonClientFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientInput ClientInputMethod
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_set_ClientInputMethod_Public_set_Void_AntiCheatCommonClientInput_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(SetClientDetailsOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetClientDetailsOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401028, XrefRangeEnd = 401030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401030, XrefRangeEnd = 401034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetClientDetailsOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetClientDetailsOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
