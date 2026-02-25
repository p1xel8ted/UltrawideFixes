// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.G_GraphShader
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace Tayx.Graphy;

public class G_GraphShader(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_ArrayMaxSizeFull;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArrayMaxSizeLight;
  private static readonly System.IntPtr NativeFieldInfoPtr_ArrayMaxSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_Array;
  private static readonly System.IntPtr NativeFieldInfoPtr_Image;
  private static readonly System.IntPtr NativeFieldInfoPtr_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_Name_Length;
  private static readonly System.IntPtr NativeFieldInfoPtr_Average;
  private static readonly System.IntPtr NativeFieldInfoPtr_averagePropertyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_GoodThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_CautionThreshold;
  private static readonly System.IntPtr NativeFieldInfoPtr_goodThresholdPropertyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_cautionThresholdPropertyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_GoodColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_CautionColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_CriticalColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_goodColorPropertyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_cautionColorPropertyId;
  private static readonly System.IntPtr NativeFieldInfoPtr_criticalColorPropertyId;
  private static readonly System.IntPtr NativeMethodInfoPtr_InitializeShader_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateArray_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAverage_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateThresholds_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateColors_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePoints_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_GraphShader()
  {
    Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy", nameof (G_GraphShader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr);
    G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (ArrayMaxSizeFull));
    G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (ArrayMaxSizeLight));
    G_GraphShader.NativeFieldInfoPtr_ArrayMaxSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (ArrayMaxSize));
    G_GraphShader.NativeFieldInfoPtr_Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (Array));
    G_GraphShader.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (Image));
    G_GraphShader.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (Name));
    G_GraphShader.NativeFieldInfoPtr_Name_Length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (Name_Length));
    G_GraphShader.NativeFieldInfoPtr_Average = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (Average));
    G_GraphShader.NativeFieldInfoPtr_averagePropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (averagePropertyId));
    G_GraphShader.NativeFieldInfoPtr_GoodThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (GoodThreshold));
    G_GraphShader.NativeFieldInfoPtr_CautionThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (CautionThreshold));
    G_GraphShader.NativeFieldInfoPtr_goodThresholdPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (goodThresholdPropertyId));
    G_GraphShader.NativeFieldInfoPtr_cautionThresholdPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (cautionThresholdPropertyId));
    G_GraphShader.NativeFieldInfoPtr_GoodColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (GoodColor));
    G_GraphShader.NativeFieldInfoPtr_CautionColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (CautionColor));
    G_GraphShader.NativeFieldInfoPtr_CriticalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (CriticalColor));
    G_GraphShader.NativeFieldInfoPtr_goodColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (goodColorPropertyId));
    G_GraphShader.NativeFieldInfoPtr_cautionColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (cautionColorPropertyId));
    G_GraphShader.NativeFieldInfoPtr_criticalColorPropertyId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, nameof (criticalColorPropertyId));
    G_GraphShader.NativeMethodInfoPtr_InitializeShader_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100663516 /*0x060000DC*/);
    G_GraphShader.NativeMethodInfoPtr_UpdateArray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100663517 /*0x060000DD*/);
    G_GraphShader.NativeMethodInfoPtr_UpdateAverage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100663518 /*0x060000DE*/);
    G_GraphShader.NativeMethodInfoPtr_UpdateThresholds_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100663519 /*0x060000DF*/);
    G_GraphShader.NativeMethodInfoPtr_UpdateColors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100663520 /*0x060000E0*/);
    G_GraphShader.NativeMethodInfoPtr_UpdatePoints_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100663521 /*0x060000E1*/);
    G_GraphShader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr, 100663522 /*0x060000E2*/);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 361644, RefRangeEnd = 361650, XrefRangeStart = 361622, XrefRangeEnd = 361644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InitializeShader()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_InitializeShader_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361650, XrefRangeEnd = 361652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateArray()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdateArray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361652, XrefRangeEnd = 361654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateAverage()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdateAverage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361654, XrefRangeEnd = 361657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateThresholds()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdateThresholds_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 361660, RefRangeEnd = 361666, XrefRangeStart = 361657, XrefRangeEnd = 361660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateColors()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdateColors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361666, XrefRangeEnd = 361668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdatePoints()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr_UpdatePoints_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361668, XrefRangeEnd = 361673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_GraphShader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_GraphShader>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_GraphShader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int ArrayMaxSizeFull
  {
    get
    {
      int arrayMaxSizeFull;
      IL2CPP.il2cpp_field_static_get_value(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeFull, (void*) &arrayMaxSizeFull);
      return arrayMaxSizeFull;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeFull, (void*) &value);
    }
  }

  public static unsafe int ArrayMaxSizeLight
  {
    get
    {
      int arrayMaxSizeLight;
      IL2CPP.il2cpp_field_static_get_value(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeLight, (void*) &arrayMaxSizeLight);
      return arrayMaxSizeLight;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSizeLight, (void*) &value);
    }
  }

  public unsafe int ArrayMaxSize
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSize));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_ArrayMaxSize)) = value;
    }
  }

  public unsafe Il2CppStructArray<float> Array
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Array));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Array), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Image Image
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Image));
      return num == System.IntPtr.Zero ? (Image) null : Il2CppObjectPool.Get<Image>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Image), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string Name_Length
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Name_Length)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Name_Length), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe float Average
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Average));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_Average)) = value;
    }
  }

  public unsafe int averagePropertyId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_averagePropertyId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_averagePropertyId)) = value;
    }
  }

  public unsafe float GoodThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_GoodThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_GoodThreshold)) = value;
    }
  }

  public unsafe float CautionThreshold
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CautionThreshold));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CautionThreshold)) = value;
    }
  }

  public unsafe int goodThresholdPropertyId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_goodThresholdPropertyId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_goodThresholdPropertyId)) = value;
    }
  }

  public unsafe int cautionThresholdPropertyId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_cautionThresholdPropertyId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_cautionThresholdPropertyId)) = value;
    }
  }

  public unsafe Color GoodColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_GoodColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_GoodColor)) = value;
    }
  }

  public unsafe Color CautionColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CautionColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CautionColor)) = value;
    }
  }

  public unsafe Color CriticalColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CriticalColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_CriticalColor)) = value;
    }
  }

  public unsafe int goodColorPropertyId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_goodColorPropertyId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_goodColorPropertyId)) = value;
    }
  }

  public unsafe int cautionColorPropertyId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_cautionColorPropertyId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_cautionColorPropertyId)) = value;
    }
  }

  public unsafe int criticalColorPropertyId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_criticalColorPropertyId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(G_GraphShader.NativeFieldInfoPtr_criticalColorPropertyId)) = value;
    }
  }
}
