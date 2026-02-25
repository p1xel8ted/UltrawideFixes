// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionSearchRemoveParameterOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct SessionSearchRemoveParameterOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Key;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ComparisonOp;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SessionSearchRemoveParameterOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Key;
  [FieldOffset(16 /*0x10*/)]
  public ComparisonOp m_ComparisonOp;

  static SessionSearchRemoveParameterOptionsInternal()
  {
    Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionSearchRemoveParameterOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr);
    SessionSearchRemoveParameterOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SessionSearchRemoveParameterOptionsInternal.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, nameof (m_Key));
    SessionSearchRemoveParameterOptionsInternal.NativeFieldInfoPtr_m_ComparisonOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, nameof (m_ComparisonOp));
    SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, 100665986);
    SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, 100665987);
    SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionSearchRemoveParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, 100665988);
    SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, 100665989);
    SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, 100665990);
  }

  public unsafe string Key
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379056, XrefRangeEnd = 379060, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ComparisonOp ComparisonOp
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379060, XrefRangeEnd = 379064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SessionSearchRemoveParameterOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionSearchRemoveParameterOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379064, XrefRangeEnd = 379070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379070, XrefRangeEnd = 379074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearchRemoveParameterOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionSearchRemoveParameterOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
