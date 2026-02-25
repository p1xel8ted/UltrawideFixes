// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.AddExternalIntegrityCatalogOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient;

[StructLayout(LayoutKind.Explicit)]
public struct AddExternalIntegrityCatalogOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PathToBinFile;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PathToBinFile_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_AddExternalIntegrityCatalogOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_PathToBinFile;

  static AddExternalIntegrityCatalogOptionsInternal()
  {
    Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatClient", nameof (AddExternalIntegrityCatalogOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr);
    AddExternalIntegrityCatalogOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    AddExternalIntegrityCatalogOptionsInternal.NativeFieldInfoPtr_m_PathToBinFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, nameof (m_PathToBinFile));
    AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_set_PathToBinFile_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, 100673009);
    AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_AddExternalIntegrityCatalogOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, 100673010);
    AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, 100673011);
    AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, 100673012);
  }

  public unsafe string PathToBinFile
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401074, XrefRangeEnd = 401078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_set_PathToBinFile_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401078, XrefRangeEnd = 401082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(AddExternalIntegrityCatalogOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_AddExternalIntegrityCatalogOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401082, XrefRangeEnd = 401088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401088, XrefRangeEnd = 401092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
