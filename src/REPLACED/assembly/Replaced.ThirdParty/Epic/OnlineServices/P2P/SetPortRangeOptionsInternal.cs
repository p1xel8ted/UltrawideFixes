// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SetPortRangeOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P;

[StructLayout(LayoutKind.Explicit)]
public struct SetPortRangeOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Port;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxAdditionalPortsToTry;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SetPortRangeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public ushort m_Port;
  [FieldOffset(6)]
  public ushort m_MaxAdditionalPortsToTry;

  static SetPortRangeOptionsInternal()
  {
    Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.P2P", nameof (SetPortRangeOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr);
    SetPortRangeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SetPortRangeOptionsInternal.NativeFieldInfoPtr_m_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, nameof (m_Port));
    SetPortRangeOptionsInternal.NativeFieldInfoPtr_m_MaxAdditionalPortsToTry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, nameof (m_MaxAdditionalPortsToTry));
    SetPortRangeOptionsInternal.NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100668523);
    SetPortRangeOptionsInternal.NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100668524);
    SetPortRangeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetPortRangeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100668525);
    SetPortRangeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100668526);
    SetPortRangeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, 100668527);
  }

  public unsafe ushort Port
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_set_Port_Public_set_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ushort MaxAdditionalPortsToTry
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_set_MaxAdditionalPortsToTry_Public_set_Void_UInt16_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(SetPortRangeOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SetPortRangeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387220, XrefRangeEnd = 387222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SetPortRangeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetPortRangeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
