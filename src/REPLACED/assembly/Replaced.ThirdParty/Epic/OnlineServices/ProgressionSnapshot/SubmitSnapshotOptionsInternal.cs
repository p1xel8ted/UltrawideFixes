// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ProgressionSnapshot.SubmitSnapshotOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.ProgressionSnapshot;

[StructLayout(LayoutKind.Explicit)]
public struct SubmitSnapshotOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SnapshotId;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SnapshotId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SubmitSnapshotOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public uint m_SnapshotId;

  static SubmitSnapshotOptionsInternal()
  {
    Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.ProgressionSnapshot", nameof (SubmitSnapshotOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr);
    SubmitSnapshotOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SubmitSnapshotOptionsInternal.NativeFieldInfoPtr_m_SnapshotId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr, nameof (m_SnapshotId));
    SubmitSnapshotOptionsInternal.NativeMethodInfoPtr_set_SnapshotId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr, 100667229);
    SubmitSnapshotOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SubmitSnapshotOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr, 100667230);
    SubmitSnapshotOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr, 100667231);
    SubmitSnapshotOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr, 100667232 /*0x06000F60*/);
  }

  public unsafe uint SnapshotId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SubmitSnapshotOptionsInternal.NativeMethodInfoPtr_set_SnapshotId_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(SubmitSnapshotOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubmitSnapshotOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SubmitSnapshotOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383042, XrefRangeEnd = 383044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubmitSnapshotOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SubmitSnapshotOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SubmitSnapshotOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
