// Decompiled with JetBrains decompiler
// Type: UnityEngine.EnumDataUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public static class EnumDataUtility : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_EnumData;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HandleInspectorOrderAttribute_Public_Static_Void_Type_byref_EnumData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0;

  static EnumDataUtility()
  {
    Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (EnumDataUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr);
    EnumDataUtility.NativeFieldInfoPtr_s_EnumData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, nameof (s_EnumData));
    EnumDataUtility.NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100668013);
    EnumDataUtility.NativeMethodInfoPtr_HandleInspectorOrderAttribute_Public_Static_Void_Type_byref_EnumData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100668014);
    EnumDataUtility.NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100668015);
    EnumDataUtility.NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100668016);
    EnumDataUtility.NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100668017);
    EnumDataUtility.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, 100668019);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 449265, RefRangeEnd = 449266, XrefRangeStart = 449045, XrefRangeEnd = 449265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe EnumData GetCachedEnumData(
    Il2CppSystem.Type enumType,
    EnumDataUtility.CachedType cachedType = EnumDataUtility.CachedType.IncludeObsoleteExceptErrors,
    Il2CppSystem.Func<string, string> nicifyName = null)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cachedType;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nicifyName);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_GetCachedEnumData_Public_Static_EnumData_Type_CachedType_Func_2_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new EnumData(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 449314, RefRangeEnd = 449315, XrefRangeStart = 449266, XrefRangeEnd = 449314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void HandleInspectorOrderAttribute(Il2CppSystem.Type enumType, ref EnumData enumData)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) enumType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) enumData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_HandleInspectorOrderAttribute_Public_Static_Void_Type_byref_EnumData_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449315, XrefRangeEnd = 449325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CheckObsoleteAddition(
    FieldInfo field,
    EnumDataUtility.CachedType cachedType)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &cachedType;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_CheckObsoleteAddition_Private_Static_Boolean_FieldInfo_CachedType_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449325, XrefRangeEnd = 449333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string EnumTooltipFromEnumField(FieldInfo field)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_EnumTooltipFromEnumField_Private_Static_String_FieldInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 449349, RefRangeEnd = 449350, XrefRangeStart = 449333, XrefRangeEnd = 449349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string EnumNameFromEnumField(
    FieldInfo field,
    Il2CppSystem.Func<string, string> nicifyName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) field);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) nicifyName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_EnumNameFromEnumField_Private_Static_String_FieldInfo_Func_2_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  public static unsafe string Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0(
    ref EnumDataUtility.__c__DisplayClass8_0 _param0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param0)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.NativeMethodInfoPtr_Method_Internal_Static_String_byref___c__DisplayClass8_0_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public EnumDataUtility(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Dictionary<Il2CppSystem.ValueTuple<EnumDataUtility.CachedType, Il2CppSystem.Type>, EnumData> s_EnumData
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.NativeFieldInfoPtr_s_EnumData, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.ValueTuple<EnumDataUtility.CachedType, Il2CppSystem.Type>, EnumData>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.ValueTuple<EnumDataUtility.CachedType, Il2CppSystem.Type>, EnumData>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.NativeFieldInfoPtr_s_EnumData, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static int EnumFlagsToInt(EnumData enumData, Il2CppSystem.Enum enumValue)
  {
    if (!enumData.unsigned)
      return Il2CppSystem.Convert.ToInt32((Il2CppSystem.Object) enumValue);
    if (enumData.underlyingType == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>()))
      return (int) Il2CppSystem.Convert.ToUInt32((Il2CppSystem.Object) enumValue);
    if (enumData.underlyingType == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>()))
    {
      ushort uint16 = Il2CppSystem.Convert.ToUInt16((Il2CppSystem.Object) enumValue);
      return uint16 == ushort.MaxValue ? -1 : (int) uint16;
    }
    byte num = Il2CppSystem.Convert.ToByte((Il2CppSystem.Object) enumValue);
    return num == byte.MaxValue ? -1 : (int) num;
  }

  public static Il2CppSystem.Enum IntToEnumFlags(Il2CppSystem.Type enumType, int value)
  {
    EnumData cachedEnumData = EnumDataUtility.GetCachedEnumData(enumType);
    if (!cachedEnumData.unsigned)
      return Il2CppSystem.Enum.Parse(enumType, value.ToString()) as Il2CppSystem.Enum;
    if (cachedEnumData.underlyingType == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>()))
    {
      uint num = (uint) value;
      return Il2CppSystem.Enum.Parse(enumType, num.ToString()) as Il2CppSystem.Enum;
    }
    if (cachedEnumData.underlyingType == Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ushort>()))
    {
      ushort num = (ushort) value;
      return Il2CppSystem.Enum.Parse(enumType, num.ToString()) as Il2CppSystem.Enum;
    }
    byte num1 = (byte) value;
    return Il2CppSystem.Enum.Parse(enumType, num1.ToString()) as Il2CppSystem.Enum;
  }

  public enum CachedType
  {
    ExcludeObsolete,
    IncludeObsoleteExceptErrors,
    IncludeAllObsolete,
  }

  [ObfuscatedName("UnityEngine.EnumDataUtility+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_5;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_2;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_3;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__2_4;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0;

    static __c()
    {
      Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr);
      EnumDataUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9");
      EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_5");
      EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_1");
      EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_2");
      EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_3");
      EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, "<>9__2_4");
      EnumDataUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100668021);
      EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100668022);
      EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100668023);
      EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100668024);
      EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100668025);
      EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr, 100668026);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449011, XrefRangeEnd = 449021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _GetCachedEnumData_b__2_5(FieldInfo f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) f)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_5_Internal_Int32_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449021, XrefRangeEnd = 449032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _GetCachedEnumData_b__2_1(FieldInfo f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) f)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_1_Internal_String_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449032, XrefRangeEnd = 449033, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Il2CppSystem.Enum _GetCachedEnumData_b__2_2(FieldInfo f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) f)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_2_Internal_Enum_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Il2CppSystem.Enum*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449033, XrefRangeEnd = 449037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _GetCachedEnumData_b__2_3(Il2CppSystem.Enum v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &v
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_3_Internal_Int32_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449037, XrefRangeEnd = 449041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int _GetCachedEnumData_b__2_4(Il2CppSystem.Enum v)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &v
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c.NativeMethodInfoPtr__GetCachedEnumData_b__2_4_Internal_Int32_Enum_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe EnumDataUtility.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (EnumDataUtility.__c) null : Il2CppObjectPool.Get<EnumDataUtility.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<FieldInfo, int> __9__2_5
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<FieldInfo, int>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<FieldInfo, int>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_5, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<FieldInfo, string> __9__2_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<FieldInfo, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<FieldInfo, string>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<FieldInfo, Il2CppSystem.Enum> __9__2_2
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<FieldInfo, Il2CppSystem.Enum>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<FieldInfo, Il2CppSystem.Enum>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Enum, int> __9__2_3
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Enum, int>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Enum, int>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Enum, int> __9__2_4
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Enum, int>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Enum, int>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(EnumDataUtility.__c.NativeFieldInfoPtr___9__2_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UnityEngine.EnumDataUtility+<>c__DisplayClass2_0")]
  public sealed class __c__DisplayClass2_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_nicifyName;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0;

    static __c__DisplayClass2_0()
    {
      Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c__DisplayClass2_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr);
      EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, nameof (nicifyName));
      EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, 100668027);
      EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr, 100668028);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass2_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 449041, XrefRangeEnd = 449045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string _GetCachedEnumData_b__0(FieldInfo f)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) f)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(EnumDataUtility.__c__DisplayClass2_0.NativeMethodInfoPtr__GetCachedEnumData_b__0_Internal_String_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }

    public unsafe Il2CppSystem.Func<string, string> nicifyName
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<string, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<string, string>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass2_0.NativeFieldInfoPtr_nicifyName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("UnityEngine.EnumDataUtility+<>c__DisplayClass8_0")]
  public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_nicifyName;
    private static readonly System.IntPtr NativeFieldInfoPtr_field;

    static __c__DisplayClass8_0()
    {
      Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EnumDataUtility>.NativeClassPtr, "<>c__DisplayClass8_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr);
      EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr, nameof (nicifyName));
      EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr, nameof (field));
    }

    public __c__DisplayClass8_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __c__DisplayClass8_0()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumDataUtility.__c__DisplayClass8_0>.NativeClassPtr))
    {
    }

    public unsafe Il2CppSystem.Func<string, string> nicifyName
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Func<string, string>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<string, string>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_nicifyName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FieldInfo field
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field));
        return num == System.IntPtr.Zero ? (FieldInfo) null : Il2CppObjectPool.Get<FieldInfo>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EnumDataUtility.__c__DisplayClass8_0.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class \u003C\u003Ec
  {
  }

  public sealed class \u003C\u003Ec__DisplayClass2_0
  {
  }
}
