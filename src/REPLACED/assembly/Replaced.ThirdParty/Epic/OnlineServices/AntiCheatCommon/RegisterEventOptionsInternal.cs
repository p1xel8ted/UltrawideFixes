// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.RegisterEventOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

[StructLayout(LayoutKind.Explicit)]
public struct RegisterEventOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EventId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EventName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EventType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamDefsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamDefs;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EventName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_RegisterEventOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_EventId;
  [FieldOffset(8)]
  public System.IntPtr m_EventName;
  [FieldOffset(16 /*0x10*/)]
  public AntiCheatCommonEventType m_EventType;
  [FieldOffset(20)]
  public uint m_ParamDefsCount;
  [FieldOffset(24)]
  public System.IntPtr m_ParamDefs;

  static RegisterEventOptionsInternal()
  {
    Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (RegisterEventOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr);
    RegisterEventOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    RegisterEventOptionsInternal.NativeFieldInfoPtr_m_EventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_EventId));
    RegisterEventOptionsInternal.NativeFieldInfoPtr_m_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_EventName));
    RegisterEventOptionsInternal.NativeFieldInfoPtr_m_EventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_EventType));
    RegisterEventOptionsInternal.NativeFieldInfoPtr_m_ParamDefsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_ParamDefsCount));
    RegisterEventOptionsInternal.NativeFieldInfoPtr_m_ParamDefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, nameof (m_ParamDefs));
    RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100672947);
    RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100672948);
    RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100672949);
    RegisterEventOptionsInternal.NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100672950);
    RegisterEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterEventOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100672951);
    RegisterEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100672952);
    RegisterEventOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, 100672953);
  }

  public unsafe uint EventId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string EventName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400953, XrefRangeEnd = 400957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonEventType EventType
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_set_EventType_Public_set_Void_AntiCheatCommonEventType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<RegisterEventParamDef> ParamDefs
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 400963, RefRangeEnd = 400965, XrefRangeStart = 400957, XrefRangeEnd = 400963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_set_ParamDefs_Public_set_Void_Il2CppReferenceArray_1_RegisterEventParamDef_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400965, XrefRangeEnd = 400970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(RegisterEventOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_RegisterEventOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400970, XrefRangeEnd = 400977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400977, XrefRangeEnd = 400982, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RegisterEventOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterEventOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
