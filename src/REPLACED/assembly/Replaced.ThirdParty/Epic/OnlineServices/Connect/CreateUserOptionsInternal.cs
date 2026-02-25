// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.CreateUserOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect;

[StructLayout(LayoutKind.Explicit)]
public struct CreateUserOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ContinuanceToken;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_CreateUserOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_ContinuanceToken;

  static CreateUserOptionsInternal()
  {
    Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Connect", nameof (CreateUserOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr);
    CreateUserOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    CreateUserOptionsInternal.NativeFieldInfoPtr_m_ContinuanceToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, nameof (m_ContinuanceToken));
    CreateUserOptionsInternal.NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100671568 /*0x06002050*/);
    CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreateUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100671569);
    CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100671570);
    CreateUserOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100671571);
  }

  public unsafe ContinuanceToken ContinuanceToken
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396952, XrefRangeEnd = 396956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396956, XrefRangeEnd = 396960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(CreateUserOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_CreateUserOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396960, XrefRangeEnd = 396966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396966, XrefRangeEnd = 396970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
