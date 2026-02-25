// Decompiled with JetBrains decompiler
// Type: UnityEngine.ApplicationMemoryUsageChange
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct ApplicationMemoryUsageChange
{
  private static readonly System.IntPtr NativeFieldInfoPtr__memoryUsage_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0;
  [FieldOffset(0)]
  public ApplicationMemoryUsage _memoryUsage_k__BackingField;

  static ApplicationMemoryUsageChange()
  {
    Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ApplicationMemoryUsageChange));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr);
    ApplicationMemoryUsageChange.NativeFieldInfoPtr__memoryUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, "<memoryUsage>k__BackingField");
    ApplicationMemoryUsageChange.NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, 100663901);
    ApplicationMemoryUsageChange.NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, 100663902);
  }

  public unsafe ApplicationMemoryUsage memoryUsage
  {
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ApplicationMemoryUsageChange.NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this._memoryUsage_k__BackingField;
  }

  [CallerCount(19)]
  [CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ApplicationMemoryUsageChange(ApplicationMemoryUsage usage)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &usage
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ApplicationMemoryUsageChange.NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
