// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.UpdateSessionOptionsInternal
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
public struct UpdateSessionOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionModificationHandle;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionModificationHandle_Public_set_Void_SessionModification_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_UpdateSessionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_SessionModificationHandle;

  static UpdateSessionOptionsInternal()
  {
    Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (UpdateSessionOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr);
    UpdateSessionOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    UpdateSessionOptionsInternal.NativeFieldInfoPtr_m_SessionModificationHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr, nameof (m_SessionModificationHandle));
    UpdateSessionOptionsInternal.NativeMethodInfoPtr_set_SessionModificationHandle_Public_set_Void_SessionModification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr, 100666133);
    UpdateSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_UpdateSessionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr, 100666134);
    UpdateSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr, 100666135);
    UpdateSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr, 100666136);
  }

  public unsafe SessionModification SessionModificationHandle
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379784, XrefRangeEnd = 379788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UpdateSessionOptionsInternal.NativeMethodInfoPtr_set_SessionModificationHandle_Public_set_Void_SessionModification_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379788, XrefRangeEnd = 379792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(UpdateSessionOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpdateSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_UpdateSessionOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379792, XrefRangeEnd = 379798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpdateSessionOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 379798, XrefRangeEnd = 379802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UpdateSessionOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSessionOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
