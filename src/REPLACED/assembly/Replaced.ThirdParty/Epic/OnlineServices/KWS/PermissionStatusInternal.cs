// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.KWS.PermissionStatusInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.KWS;

[StructLayout(LayoutKind.Explicit)]
public struct PermissionStatusInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Status;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_KWSPermissionStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_KWSPermissionStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PermissionStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Name;
  [FieldOffset(16 /*0x10*/)]
  public KWSPermissionStatus m_Status;

  static PermissionStatusInternal()
  {
    Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.KWS", nameof (PermissionStatusInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr);
    PermissionStatusInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, nameof (m_ApiVersion));
    PermissionStatusInternal.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, nameof (m_Name));
    PermissionStatusInternal.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, nameof (m_Status));
    PermissionStatusInternal.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, 100670276);
    PermissionStatusInternal.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, 100670277);
    PermissionStatusInternal.NativeMethodInfoPtr_get_Status_Public_get_KWSPermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, 100670278);
    PermissionStatusInternal.NativeMethodInfoPtr_set_Status_Public_set_Void_KWSPermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, 100670279);
    PermissionStatusInternal.NativeMethodInfoPtr_Set_Public_Void_PermissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, 100670280);
    PermissionStatusInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, 100670281);
    PermissionStatusInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, 100670282);
  }

  public unsafe string Name
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392703, XrefRangeEnd = 392707, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PermissionStatusInternal.NativeMethodInfoPtr_get_Name_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392707, XrefRangeEnd = 392711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PermissionStatusInternal.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe KWSPermissionStatus Status
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PermissionStatusInternal.NativeMethodInfoPtr_get_Status_Public_get_KWSPermissionStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(KWSPermissionStatus*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PermissionStatusInternal.NativeMethodInfoPtr_set_Status_Public_set_Void_KWSPermissionStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392711, XrefRangeEnd = 392715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(PermissionStatus other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PermissionStatusInternal.NativeMethodInfoPtr_Set_Public_Void_PermissionStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392715, XrefRangeEnd = 392721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PermissionStatusInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392721, XrefRangeEnd = 392725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PermissionStatusInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PermissionStatusInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
