// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.InitializeOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

public class InitializeOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__AllocateMemoryFunction_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ReallocateMemoryFunction_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ReleaseMemoryFunction_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ProductName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ProductVersion_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SystemInitializeOptions_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OverrideThreadAffinity_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AllocateMemoryFunction_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReallocateMemoryFunction_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ReleaseMemoryFunction_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductVersion_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SystemInitializeOptions_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OverrideThreadAffinity_Public_get_InitializeThreadAffinity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_InitializeThreadAffinity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InitializeOptions()
  {
    Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (InitializeOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr);
    InitializeOptions.NativeFieldInfoPtr__AllocateMemoryFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<AllocateMemoryFunction>k__BackingField");
    InitializeOptions.NativeFieldInfoPtr__ReallocateMemoryFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<ReallocateMemoryFunction>k__BackingField");
    InitializeOptions.NativeFieldInfoPtr__ReleaseMemoryFunction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<ReleaseMemoryFunction>k__BackingField");
    InitializeOptions.NativeFieldInfoPtr__ProductName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<ProductName>k__BackingField");
    InitializeOptions.NativeFieldInfoPtr__ProductVersion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<ProductVersion>k__BackingField");
    InitializeOptions.NativeFieldInfoPtr__SystemInitializeOptions_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<SystemInitializeOptions>k__BackingField");
    InitializeOptions.NativeFieldInfoPtr__OverrideThreadAffinity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, "<OverrideThreadAffinity>k__BackingField");
    InitializeOptions.NativeMethodInfoPtr_get_AllocateMemoryFunction_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667947);
    InitializeOptions.NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667948);
    InitializeOptions.NativeMethodInfoPtr_get_ReallocateMemoryFunction_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667949);
    InitializeOptions.NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667950);
    InitializeOptions.NativeMethodInfoPtr_get_ReleaseMemoryFunction_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667951);
    InitializeOptions.NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667952);
    InitializeOptions.NativeMethodInfoPtr_get_ProductName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667953);
    InitializeOptions.NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667954);
    InitializeOptions.NativeMethodInfoPtr_get_ProductVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667955);
    InitializeOptions.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667956);
    InitializeOptions.NativeMethodInfoPtr_get_SystemInitializeOptions_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667957);
    InitializeOptions.NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667958);
    InitializeOptions.NativeMethodInfoPtr_get_OverrideThreadAffinity_Public_get_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667959);
    InitializeOptions.NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667960);
    InitializeOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr, 100667961);
  }

  public unsafe System.IntPtr AllocateMemoryFunction
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_AllocateMemoryFunction_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr ReallocateMemoryFunction
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_ReallocateMemoryFunction_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr ReleaseMemoryFunction
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_ReleaseMemoryFunction_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductName
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_ProductName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductVersion
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_ProductVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 68659, RefRangeEnd = 68660, XrefRangeStart = 68659, XrefRangeEnd = 68660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr SystemInitializeOptions
  {
    [CallerCount(15), CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_SystemInitializeOptions_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe InitializeThreadAffinity OverrideThreadAffinity
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_get_OverrideThreadAffinity_Public_get_InitializeThreadAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (InitializeThreadAffinity) null : Il2CppObjectPool.Get<InitializeThreadAffinity>(num3);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_InitializeThreadAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InitializeOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _AllocateMemoryFunction_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__AllocateMemoryFunction_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__AllocateMemoryFunction_k__BackingField)) = value;
    }
  }

  public unsafe System.IntPtr _ReallocateMemoryFunction_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ReallocateMemoryFunction_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ReallocateMemoryFunction_k__BackingField)) = value;
    }
  }

  public unsafe System.IntPtr _ReleaseMemoryFunction_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ReleaseMemoryFunction_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ReleaseMemoryFunction_k__BackingField)) = value;
    }
  }

  public unsafe string _ProductName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ProductName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ProductName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _ProductVersion_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ProductVersion_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__ProductVersion_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe System.IntPtr _SystemInitializeOptions_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__SystemInitializeOptions_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__SystemInitializeOptions_k__BackingField)) = value;
    }
  }

  public unsafe InitializeThreadAffinity _OverrideThreadAffinity_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__OverrideThreadAffinity_k__BackingField));
      return num == System.IntPtr.Zero ? (InitializeThreadAffinity) null : Il2CppObjectPool.Get<InitializeThreadAffinity>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeOptions.NativeFieldInfoPtr__OverrideThreadAffinity_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
