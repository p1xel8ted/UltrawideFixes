// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionSearchSetParameterOptionsInternal
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
public struct SessionSearchSetParameterOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Parameter;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ComparisonOp;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SessionSearchSetParameterOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Parameter;
  [FieldOffset(16 /*0x10*/)]
  public ComparisonOp m_ComparisonOp;

  static SessionSearchSetParameterOptionsInternal()
  {
    Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionSearchSetParameterOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr);
    SessionSearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SessionSearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_Parameter));
    SessionSearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_ComparisonOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_ComparisonOp));
    SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666003);
    SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666004);
    SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionSearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666005);
    SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666006);
    SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666007);
  }

  public unsafe AttributeData Parameter
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 379082, RefRangeEnd = 379084, XrefRangeStart = 379076, XrefRangeEnd = 379082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379084, XrefRangeEnd = 379085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(SessionSearchSetParameterOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionSearchSetParameterOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379085, XrefRangeEnd = 379088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379088, XrefRangeEnd = 379092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
