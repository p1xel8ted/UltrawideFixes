// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Platform.InitializeOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Platform;

[StructLayout(LayoutKind.Explicit)]
public struct InitializeOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_AllocateMemoryFunction;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReallocateMemoryFunction;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ReleaseMemoryFunction;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductVersion;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Reserved;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SystemInitializeOptions;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideThreadAffinity;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_InitializeThreadAffinity_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_InitializeOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;
  [FieldOffset(8)]
  public System.IntPtr m_AllocateMemoryFunction;
  [FieldOffset(16 /*0x10*/)]
  public System.IntPtr m_ReallocateMemoryFunction;
  [FieldOffset(24)]
  public System.IntPtr m_ReleaseMemoryFunction;
  [FieldOffset(32 /*0x20*/)]
  public System.IntPtr m_ProductName;
  [FieldOffset(40)]
  public System.IntPtr m_ProductVersion;
  [FieldOffset(48 /*0x30*/)]
  public System.IntPtr m_Reserved;
  [FieldOffset(56)]
  public System.IntPtr m_SystemInitializeOptions;
  [FieldOffset(64 /*0x40*/)]
  public System.IntPtr m_OverrideThreadAffinity;

  static InitializeOptionsInternal()
  {
    Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Platform", nameof (InitializeOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr);
    InitializeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    InitializeOptionsInternal.NativeFieldInfoPtr_m_AllocateMemoryFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_AllocateMemoryFunction));
    InitializeOptionsInternal.NativeFieldInfoPtr_m_ReallocateMemoryFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_ReallocateMemoryFunction));
    InitializeOptionsInternal.NativeFieldInfoPtr_m_ReleaseMemoryFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_ReleaseMemoryFunction));
    InitializeOptionsInternal.NativeFieldInfoPtr_m_ProductName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_ProductName));
    InitializeOptionsInternal.NativeFieldInfoPtr_m_ProductVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_ProductVersion));
    InitializeOptionsInternal.NativeFieldInfoPtr_m_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_Reserved));
    InitializeOptionsInternal.NativeFieldInfoPtr_m_SystemInitializeOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_SystemInitializeOptions));
    InitializeOptionsInternal.NativeFieldInfoPtr_m_OverrideThreadAffinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, nameof (m_OverrideThreadAffinity));
    InitializeOptionsInternal.NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667962);
    InitializeOptionsInternal.NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667963);
    InitializeOptionsInternal.NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667964);
    InitializeOptionsInternal.NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667965);
    InitializeOptionsInternal.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667966);
    InitializeOptionsInternal.NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667967);
    InitializeOptionsInternal.NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_InitializeThreadAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667968);
    InitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_InitializeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667969);
    InitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667970);
    InitializeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, 100667971);
  }

  public unsafe System.IntPtr AllocateMemoryFunction
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_set_AllocateMemoryFunction_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr ReallocateMemoryFunction
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_set_ReallocateMemoryFunction_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr ReleaseMemoryFunction
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_set_ReleaseMemoryFunction_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductName
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385518, XrefRangeEnd = 385522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_set_ProductName_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ProductVersion
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385522, XrefRangeEnd = 385526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr SystemInitializeOptions
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_set_SystemInitializeOptions_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe InitializeThreadAffinity OverrideThreadAffinity
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 385532, RefRangeEnd = 385533, XrefRangeStart = 385526, XrefRangeEnd = 385532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_set_OverrideThreadAffinity_Public_set_Void_InitializeThreadAffinity_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 385551, RefRangeEnd = 385552, XrefRangeStart = 385533, XrefRangeEnd = 385551, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(InitializeOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_InitializeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385552, XrefRangeEnd = 385555, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 385555, XrefRangeEnd = 385566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitializeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InitializeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
