// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Constraints.NumberConstraint
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Constraints;

public sealed class NumberConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__MinValue_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__MaxValue_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Precision_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__MinPrecision_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__MaxPrecision_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Unit_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinValue_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MinValue_Private_set_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxValue_Public_get_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxValue_Private_set_Void_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Precision_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Precision_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinPrecision_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MinPrecision_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxPrecision_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxPrecision_Private_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Unit_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Unit_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Int32_Int32_Int32_String_0;

  static NumberConstraint()
  {
    Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Constraints", nameof (NumberConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr);
    NumberConstraint.NativeFieldInfoPtr__MinValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, "<MinValue>k__BackingField");
    NumberConstraint.NativeFieldInfoPtr__MaxValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, "<MaxValue>k__BackingField");
    NumberConstraint.NativeFieldInfoPtr__Precision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, "<Precision>k__BackingField");
    NumberConstraint.NativeFieldInfoPtr__MinPrecision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, "<MinPrecision>k__BackingField");
    NumberConstraint.NativeFieldInfoPtr__MaxPrecision_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, "<MaxPrecision>k__BackingField");
    NumberConstraint.NativeFieldInfoPtr__Unit_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, "<Unit>k__BackingField");
    NumberConstraint.NativeMethodInfoPtr_get_MinValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664607);
    NumberConstraint.NativeMethodInfoPtr_set_MinValue_Private_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664608 /*0x06000520*/);
    NumberConstraint.NativeMethodInfoPtr_get_MaxValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664609);
    NumberConstraint.NativeMethodInfoPtr_set_MaxValue_Private_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664610);
    NumberConstraint.NativeMethodInfoPtr_get_Precision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664611);
    NumberConstraint.NativeMethodInfoPtr_set_Precision_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664612);
    NumberConstraint.NativeMethodInfoPtr_get_MinPrecision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664613);
    NumberConstraint.NativeMethodInfoPtr_set_MinPrecision_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664614);
    NumberConstraint.NativeMethodInfoPtr_get_MaxPrecision_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664615);
    NumberConstraint.NativeMethodInfoPtr_set_MaxPrecision_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664616);
    NumberConstraint.NativeMethodInfoPtr_get_Unit_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664617);
    NumberConstraint.NativeMethodInfoPtr_set_Unit_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664618);
    NumberConstraint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Int32_Int32_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr, 100664619);
  }

  public unsafe double MinValue
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_get_MinValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_set_MinValue_Private_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe double MaxValue
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 198926, RefRangeEnd = 198931, XrefRangeStart = 198926, XrefRangeEnd = 198931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_get_MaxValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_set_MaxValue_Private_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int Precision
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_get_Precision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_set_Precision_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int MinPrecision
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_get_MinPrecision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_set_MinPrecision_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int MaxPrecision
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_get_MaxPrecision_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_set_MaxPrecision_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string Unit
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 64595, RefRangeEnd = 64606, XrefRangeStart = 64595, XrefRangeEnd = 64606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_get_Unit_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr_set_Unit_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 1000113, RefRangeEnd = 1000114, XrefRangeStart = 1000112, XrefRangeEnd = 1000113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe NumberConstraint(
    double aMinValue,
    double aMaxValue,
    int aPrecision,
    int aMinPrecision,
    int aMaxPrecision,
    string aUnit)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[6];
    numPtr[0] = (System.IntPtr) &aMinValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aMaxValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &aPrecision;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &aMinPrecision;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &aMaxPrecision;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aUnit);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(NumberConstraint.NativeMethodInfoPtr__ctor_Public_Void_Double_Double_Int32_Int32_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe double _MinValue_k__BackingField
  {
    get
    {
      return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__MinValue_k__BackingField));
    }
    [param: In] set
    {
      *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__MinValue_k__BackingField)) = value;
    }
  }

  public unsafe double _MaxValue_k__BackingField
  {
    get
    {
      return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__MaxValue_k__BackingField));
    }
    [param: In] set
    {
      *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__MaxValue_k__BackingField)) = value;
    }
  }

  public unsafe int _Precision_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__Precision_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__Precision_k__BackingField)) = value;
    }
  }

  public unsafe int _MinPrecision_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__MinPrecision_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__MinPrecision_k__BackingField)) = value;
    }
  }

  public unsafe int _MaxPrecision_k__BackingField
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__MaxPrecision_k__BackingField));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__MaxPrecision_k__BackingField)) = value;
    }
  }

  public unsafe string _Unit_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__Unit_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NumberConstraint.NativeFieldInfoPtr__Unit_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
