// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PlayerDataStorage.DuplicateFileOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.PlayerDataStorage;

[StructLayout(LayoutKind.Explicit)]
public struct DuplicateFileOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceFilename;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_DestinationFilename;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SourceFilename_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DestinationFilename_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_DuplicateFileOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_LocalUserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_SourceFilename;
  [FieldOffset(24)]
  public System.IntPtr m_DestinationFilename;

  static DuplicateFileOptionsInternal()
  {
    Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.PlayerDataStorage", nameof (DuplicateFileOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr);
    DuplicateFileOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    DuplicateFileOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
    DuplicateFileOptionsInternal.NativeFieldInfoPtr_m_SourceFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, nameof (m_SourceFilename));
    DuplicateFileOptionsInternal.NativeFieldInfoPtr_m_DestinationFilename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, nameof (m_DestinationFilename));
    DuplicateFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, 100667602);
    DuplicateFileOptionsInternal.NativeMethodInfoPtr_set_SourceFilename_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, 100667603);
    DuplicateFileOptionsInternal.NativeMethodInfoPtr_set_DestinationFilename_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, 100667604);
    DuplicateFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_DuplicateFileOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, 100667605);
    DuplicateFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, 100667606);
    DuplicateFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, 100667607);
  }

  public unsafe ProductUserId LocalUserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384251, XrefRangeEnd = 384255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DuplicateFileOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string SourceFilename
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384255, XrefRangeEnd = 384259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DuplicateFileOptionsInternal.NativeMethodInfoPtr_set_SourceFilename_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string DestinationFilename
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384259, XrefRangeEnd = 384263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DuplicateFileOptionsInternal.NativeMethodInfoPtr_set_DestinationFilename_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 384275, RefRangeEnd = 384276, XrefRangeStart = 384263, XrefRangeEnd = 384275, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(DuplicateFileOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DuplicateFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_DuplicateFileOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384276, XrefRangeEnd = 384279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DuplicateFileOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384279, XrefRangeEnd = 384285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DuplicateFileOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DuplicateFileOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
