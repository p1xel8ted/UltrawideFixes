// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.InfoInternal
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
namespace Epic.OnlineServices.Presence;

[StructLayout(LayoutKind.Explicit)]
public struct InfoInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Status;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Platform;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RichText;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_RecordsCount;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Records;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductName;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_Status_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductId_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductVersion_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Platform_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Platform_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RichText_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RichText_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Info_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(4)]
  public Status m_Status;
  [FieldOffset(8)]
  public System.IntPtr m_UserId;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ProductId;
  [FieldOffset(24)]
  public System.IntPtr m_ProductVersion;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_Platform;
  [FieldOffset(40)]
  public System.IntPtr m_RichText;
  [FieldOffset(48 /*0x30*/)]
  public int m_RecordsCount;
  [FieldOffset(56)]
  public System.IntPtr m_Records;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_ProductName;

  static InfoInternal()
  {
    Il2CppClassPointerStore<InfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Presence", nameof (InfoInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr);
    InfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
    InfoInternal.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_Status));
    InfoInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_UserId));
    InfoInternal.NativeFieldInfoPtr_m_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_ProductId));
    InfoInternal.NativeFieldInfoPtr_m_ProductVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_ProductVersion));
    InfoInternal.NativeFieldInfoPtr_m_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_Platform));
    InfoInternal.NativeFieldInfoPtr_m_RichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_RichText));
    InfoInternal.NativeFieldInfoPtr_m_RecordsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_RecordsCount));
    InfoInternal.NativeFieldInfoPtr_m_Records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_Records));
    InfoInternal.NativeFieldInfoPtr_m_ProductName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_ProductName));
    InfoInternal.NativeMethodInfoPtr_get_Status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667311);
    InfoInternal.NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667312 /*0x06000FB0*/);
    InfoInternal.NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667313);
    InfoInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667314);
    InfoInternal.NativeMethodInfoPtr_get_ProductId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667315);
    InfoInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667316);
    InfoInternal.NativeMethodInfoPtr_get_ProductVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667317);
    InfoInternal.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667318);
    InfoInternal.NativeMethodInfoPtr_get_Platform_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667319);
    InfoInternal.NativeMethodInfoPtr_set_Platform_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667320);
    InfoInternal.NativeMethodInfoPtr_get_RichText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667321);
    InfoInternal.NativeMethodInfoPtr_set_RichText_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667322);
    InfoInternal.NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667323);
    InfoInternal.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667324);
    InfoInternal.NativeMethodInfoPtr_get_ProductName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667325);
    InfoInternal.NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667326);
    InfoInternal.NativeMethodInfoPtr_Set_Public_Void_Info_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667327);
    InfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667328 /*0x06000FC0*/);
    InfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100667329);
  }

  public unsafe Status Status
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_Status_Public_get_Status_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Status*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe EpicAccountId UserId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383262, XrefRangeEnd = 383268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (EpicAccountId) null : Il2CppObjectPool.Get<EpicAccountId>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383268, XrefRangeEnd = 383272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductId
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383272, XrefRangeEnd = 383276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_ProductId_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383276, XrefRangeEnd = 383280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductVersion
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383280, XrefRangeEnd = 383284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_ProductVersion_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383284, XrefRangeEnd = 383288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Platform
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383288, XrefRangeEnd = 383292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_Platform_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383292, XrefRangeEnd = 383296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_Platform_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string RichText
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383296, XrefRangeEnd = 383300, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_RichText_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383300, XrefRangeEnd = 383304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_RichText_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<DataRecord> Records
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383304, XrefRangeEnd = 383310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<DataRecord>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<DataRecord>>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 383316, RefRangeEnd = 383317, XrefRangeStart = 383310, XrefRangeEnd = 383316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383317, XrefRangeEnd = 383321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_ProductName_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383321, XrefRangeEnd = 383325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 383350, RefRangeEnd = 383351, XrefRangeStart = 383325, XrefRangeEnd = 383350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Info other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_Set_Public_Void_Info_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383351, XrefRangeEnd = 383354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383354, XrefRangeEnd = 383364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
