// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.LobbySearchSetParameterOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby;

[StructLayout(LayoutKind.Explicit)]
public struct LobbySearchSetParameterOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Parameter;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ComparisonOp;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LobbySearchSetParameterOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Parameter;
  [FieldOffset(16 /*0x10*/)]
  public ComparisonOp m_ComparisonOp;

  static LobbySearchSetParameterOptionsInternal()
  {
    Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Lobby", nameof (LobbySearchSetParameterOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr);
    LobbySearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    LobbySearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_Parameter));
    LobbySearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_ComparisonOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_ComparisonOp));
    LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, 100669553);
    LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, 100669554);
    LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LobbySearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, 100669555);
    LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, 100669556);
    LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, 100669557);
  }

  public unsafe AttributeData Parameter
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 390933, RefRangeEnd = 390935, XrefRangeStart = 390927, XrefRangeEnd = 390933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_Parameter_Public_set_Void_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
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
      IL2CPP.il2cpp_runtime_invoke(LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390935, XrefRangeEnd = 390936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LobbySearchSetParameterOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_LobbySearchSetParameterOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390936, XrefRangeEnd = 390939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 390939, XrefRangeEnd = 390943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LobbySearchSetParameterOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LobbySearchSetParameterOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
