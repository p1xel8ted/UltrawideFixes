// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.InitializeThreadAffinity
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

public class InitializeThreadAffinity(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__NetworkWork_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__StorageIo_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__WebSocketIo_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__P2PIo_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__HttpRequestIo_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_InitializeThreadAffinityInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InitializeThreadAffinity()
  {
    Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (InitializeThreadAffinity));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr);
    InitializeThreadAffinity.NativeFieldInfoPtr__NetworkWork_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<NetworkWork>k__BackingField");
    InitializeThreadAffinity.NativeFieldInfoPtr__StorageIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<StorageIo>k__BackingField");
    InitializeThreadAffinity.NativeFieldInfoPtr__WebSocketIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<WebSocketIo>k__BackingField");
    InitializeThreadAffinity.NativeFieldInfoPtr__P2PIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<P2PIo>k__BackingField");
    InitializeThreadAffinity.NativeFieldInfoPtr__HttpRequestIo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, "<HttpRequestIo>k__BackingField");
    InitializeThreadAffinity.NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667972);
    InitializeThreadAffinity.NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667973);
    InitializeThreadAffinity.NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667974);
    InitializeThreadAffinity.NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667975);
    InitializeThreadAffinity.NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667976);
    InitializeThreadAffinity.NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667977);
    InitializeThreadAffinity.NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667978);
    InitializeThreadAffinity.NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667979);
    InitializeThreadAffinity.NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667980);
    InitializeThreadAffinity.NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667981);
    InitializeThreadAffinity.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_InitializeThreadAffinityInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667982);
    InitializeThreadAffinity.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667983);
    InitializeThreadAffinity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr, 100667984);
  }

  public unsafe ulong NetworkWork
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_NetworkWork_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_NetworkWork_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong StorageIo
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_StorageIo_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_StorageIo_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong WebSocketIo
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_WebSocketIo_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_WebSocketIo_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong P2PIo
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_P2PIo_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_P2PIo_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong HttpRequestIo
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_get_HttpRequestIo_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_set_HttpRequestIo_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385566, XrefRangeEnd = 385578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(Il2CppSystem.Nullable<InitializeThreadAffinityInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_InitializeThreadAffinityInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385578, XrefRangeEnd = 385594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InitializeThreadAffinity()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeThreadAffinity>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeThreadAffinity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong _NetworkWork_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__NetworkWork_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__NetworkWork_k__BackingField)) = value;
    }
  }

  public unsafe ulong _StorageIo_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__StorageIo_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__StorageIo_k__BackingField)) = value;
    }
  }

  public unsafe ulong _WebSocketIo_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__WebSocketIo_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__WebSocketIo_k__BackingField)) = value;
    }
  }

  public unsafe ulong _P2PIo_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__P2PIo_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__P2PIo_k__BackingField)) = value;
    }
  }

  public unsafe ulong _HttpRequestIo_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__HttpRequestIo_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeThreadAffinity.NativeFieldInfoPtr__HttpRequestIo_k__BackingField)) = value;
    }
  }
}
