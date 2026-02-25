// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Mods.ModInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Mods;

[StructLayout(LayoutKind.Explicit)]
public struct ModInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ModsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Mods;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_ModInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public int m_ModsCount;
  [FieldOffset(8)]
  public System.IntPtr m_Mods;
  [FieldOffset(16 /*0x10*/)]
  public ModEnumerationType m_Type;

  static ModInfoInternal()
  {
    Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Mods", nameof (ModInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr);
    ModInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    ModInfoInternal.NativeFieldInfoPtr_m_ModsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, nameof (m_ModsCount));
    ModInfoInternal.NativeFieldInfoPtr_m_Mods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, nameof (m_Mods));
    ModInfoInternal.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, nameof (m_Type));
    ModInfoInternal.NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100668645);
    ModInfoInternal.NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100668646);
    ModInfoInternal.NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100668647);
    ModInfoInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100668648);
    ModInfoInternal.NativeMethodInfoPtr_Set_Public_Void_ModInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100668649);
    ModInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100668650);
    ModInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, 100668651);
  }

  public unsafe Il2CppReferenceArray<ModIdentifier> Mods
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387601, XrefRangeEnd = 387607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_get_Mods_Public_get_Il2CppReferenceArray_1_ModIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<ModIdentifier>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ModIdentifier>>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 387613, RefRangeEnd = 387615, XrefRangeStart = 387607, XrefRangeEnd = 387613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_set_Mods_Public_set_Void_Il2CppReferenceArray_1_ModIdentifier_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ModEnumerationType Type
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_get_Type_Public_get_ModEnumerationType_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ModEnumerationType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_ModEnumerationType_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387615, XrefRangeEnd = 387616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(ModInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_Set_Public_Void_ModInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387616, XrefRangeEnd = 387619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 387619, XrefRangeEnd = 387623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ModInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
