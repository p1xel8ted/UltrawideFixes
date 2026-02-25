// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.PlayerStatInfoInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements;

[StructLayout(LayoutKind.Explicit)]
public struct PlayerStatInfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CurrentValue;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ThresholdValue;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ThresholdValue_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ThresholdValue_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_PlayerStatInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_Name;
  [FieldOffset(16 /*0x10*/)]
  public int m_CurrentValue;
  [FieldOffset(20)]
  public int m_ThresholdValue;

  static PlayerStatInfoInternal()
  {
    Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Achievements", nameof (PlayerStatInfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr);
    PlayerStatInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    PlayerStatInfoInternal.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, nameof (m_Name));
    PlayerStatInfoInternal.NativeFieldInfoPtr_m_CurrentValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, nameof (m_CurrentValue));
    PlayerStatInfoInternal.NativeFieldInfoPtr_m_ThresholdValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, nameof (m_ThresholdValue));
    PlayerStatInfoInternal.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673568);
    PlayerStatInfoInternal.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673569);
    PlayerStatInfoInternal.NativeMethodInfoPtr_get_CurrentValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673570);
    PlayerStatInfoInternal.NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673571);
    PlayerStatInfoInternal.NativeMethodInfoPtr_get_ThresholdValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673572);
    PlayerStatInfoInternal.NativeMethodInfoPtr_set_ThresholdValue_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673573);
    PlayerStatInfoInternal.NativeMethodInfoPtr_Set_Public_Void_PlayerStatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673574);
    PlayerStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673575);
    PlayerStatInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, 100673576);
  }

  public unsafe string Name
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402835, XrefRangeEnd = 402839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_get_Name_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402839, XrefRangeEnd = 402843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int CurrentValue
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_get_CurrentValue_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_set_CurrentValue_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int ThresholdValue
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_get_ThresholdValue_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 64580, RefRangeEnd = 64585, XrefRangeStart = 64580, XrefRangeEnd = 64585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_set_ThresholdValue_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402843, XrefRangeEnd = 402847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(PlayerStatInfo other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_Set_Public_Void_PlayerStatInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402847, XrefRangeEnd = 402853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 402853, XrefRangeEnd = 402857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerStatInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerStatInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
