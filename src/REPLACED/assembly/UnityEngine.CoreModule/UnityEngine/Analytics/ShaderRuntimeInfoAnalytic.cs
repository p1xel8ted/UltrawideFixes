// Decompiled with JetBrains decompiler
// Type: UnityEngine.Analytics.ShaderRuntimeInfoAnalytic
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Analytics;

[Serializable]
public class ShaderRuntimeInfoAnalytic(IntPtr pointer) : AnalyticsEventBase(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_VariantsRequested;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsRequestedMissing;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsRequestedUnsupported;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsRequestedCompiled;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsRequestedViaWarmup;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsUnused;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsCompilationTimeTotal;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsCompilationTimeMax;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsCompilationTimeMedian;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsWarmupTimeTotal;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsWarmupTimeMax;
  private static readonly IntPtr NativeFieldInfoPtr_VariantsWarmupTimeMedian;
  private static readonly IntPtr NativeFieldInfoPtr_UseProgressiveWarmup;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkSizeMin;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkSizeMax;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkSizeAvg;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkCountMin;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkCountMax;
  private static readonly IntPtr NativeFieldInfoPtr_ShaderChunkCountAvg;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateShaderRuntimeInfoAnalytic_Public_Static_ShaderRuntimeInfoAnalytic_0;

  static ShaderRuntimeInfoAnalytic()
  {
    Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Analytics", nameof (ShaderRuntimeInfoAnalytic));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr);
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsRequested));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedMissing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsRequestedMissing));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedUnsupported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsRequestedUnsupported));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedCompiled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsRequestedCompiled));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedViaWarmup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsRequestedViaWarmup));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsUnused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsUnused));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsCompilationTimeTotal));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsCompilationTimeMax));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeMedian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsCompilationTimeMedian));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeTotal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsWarmupTimeTotal));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsWarmupTimeMax));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeMedian = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (VariantsWarmupTimeMedian));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_UseProgressiveWarmup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (UseProgressiveWarmup));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (ShaderChunkSizeMin));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (ShaderChunkSizeMax));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeAvg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (ShaderChunkSizeAvg));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (ShaderChunkCountMin));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (ShaderChunkCountMax));
    ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountAvg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, nameof (ShaderChunkCountAvg));
    ShaderRuntimeInfoAnalytic.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, 100669602);
    ShaderRuntimeInfoAnalytic.NativeMethodInfoPtr_CreateShaderRuntimeInfoAnalytic_Public_Static_ShaderRuntimeInfoAnalytic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr, 100669603);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481920, XrefRangeEnd = 481925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShaderRuntimeInfoAnalytic()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderRuntimeInfoAnalytic>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShaderRuntimeInfoAnalytic.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481925, XrefRangeEnd = 481933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ShaderRuntimeInfoAnalytic.NativeMethodInfoPtr_CreateShaderRuntimeInfoAnalytic_Public_Static_ShaderRuntimeInfoAnalytic_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ShaderRuntimeInfoAnalytic) null : Il2CppObjectPool.Get<ShaderRuntimeInfoAnalytic>(num3);
  }

  public unsafe long VariantsRequested
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequested));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequested)) = value;
    }
  }

  public unsafe long VariantsRequestedMissing
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedMissing));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedMissing)) = value;
    }
  }

  public unsafe long VariantsRequestedUnsupported
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedUnsupported));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedUnsupported)) = value;
    }
  }

  public unsafe long VariantsRequestedCompiled
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedCompiled));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedCompiled)) = value;
    }
  }

  public unsafe long VariantsRequestedViaWarmup
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedViaWarmup));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsRequestedViaWarmup)) = value;
    }
  }

  public unsafe long VariantsUnused
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsUnused));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsUnused)) = value;
    }
  }

  public unsafe int VariantsCompilationTimeTotal
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeTotal));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeTotal)) = value;
    }
  }

  public unsafe int VariantsCompilationTimeMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeMax)) = value;
    }
  }

  public unsafe int VariantsCompilationTimeMedian
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeMedian));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsCompilationTimeMedian)) = value;
    }
  }

  public unsafe int VariantsWarmupTimeTotal
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeTotal));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeTotal)) = value;
    }
  }

  public unsafe int VariantsWarmupTimeMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeMax)) = value;
    }
  }

  public unsafe int VariantsWarmupTimeMedian
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeMedian));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_VariantsWarmupTimeMedian)) = value;
    }
  }

  public unsafe bool UseProgressiveWarmup
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_UseProgressiveWarmup));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_UseProgressiveWarmup)) = value;
    }
  }

  public unsafe int ShaderChunkSizeMin
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeMin));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeMin)) = value;
    }
  }

  public unsafe int ShaderChunkSizeMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeMax)) = value;
    }
  }

  public unsafe int ShaderChunkSizeAvg
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeAvg));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkSizeAvg)) = value;
    }
  }

  public unsafe int ShaderChunkCountMin
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountMin));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountMin)) = value;
    }
  }

  public unsafe int ShaderChunkCountMax
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountMax));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountMax)) = value;
    }
  }

  public unsafe int ShaderChunkCountAvg
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountAvg));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderRuntimeInfoAnalytic.NativeFieldInfoPtr_ShaderChunkCountAvg)) = value;
    }
  }
}
