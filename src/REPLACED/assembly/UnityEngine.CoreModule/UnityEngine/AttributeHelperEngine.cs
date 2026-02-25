// Decompiled with JetBrains decompiler
// Type: UnityEngine.AttributeHelperEngine
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class AttributeHelperEngine(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__disallowMultipleComponentArray;
  private static readonly System.IntPtr NativeFieldInfoPtr__executeInEditModeArray;
  private static readonly System.IntPtr NativeFieldInfoPtr__requireComponentArray;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0;

  static AttributeHelperEngine()
  {
    Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AttributeHelperEngine));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr);
    AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, nameof (_disallowMultipleComponentArray));
    AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, nameof (_executeInEditModeArray));
    AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, nameof (_requireComponentArray));
    AttributeHelperEngine.NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100667845);
    AttributeHelperEngine.NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100667846);
    AttributeHelperEngine.NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100667847);
    AttributeHelperEngine.NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100667848);
    AttributeHelperEngine.NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100667849);
    AttributeHelperEngine.NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr, 100667850);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442614, XrefRangeEnd = 442630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Type GetParentTypeDisallowingMultipleInclusion(Il2CppSystem.Type type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetParentTypeDisallowingMultipleInclusion_Private_Static_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442630, XrefRangeEnd = 442686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> GetRequiredComponents(Il2CppSystem.Type klass)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) klass)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetRequiredComponents_Private_Static_Il2CppReferenceArray_1_Type_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442686, XrefRangeEnd = 442696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetExecuteMode(Il2CppSystem.Type klass)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) klass)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetExecuteMode_Private_Static_Int32_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442696, XrefRangeEnd = 442719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int CheckIsEditorScript(Il2CppSystem.Type klass)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) klass)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_CheckIsEditorScript_Private_Static_Int32_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442719, XrefRangeEnd = 442725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetDefaultExecutionOrderFor(Il2CppSystem.Type klass)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) klass)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.NativeMethodInfoPtr_GetDefaultExecutionOrderFor_Private_Static_Int32_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442732, RefRangeEnd = 442733, XrefRangeStart = 442725, XrefRangeEnd = 442732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe T GetCustomAttributeOfType<T>(Il2CppSystem.Type klass) where T : Il2CppSystem.Attribute
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) klass)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttributeHelperEngine.MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  public static unsafe Il2CppReferenceArray<DisallowMultipleComponent> _disallowMultipleComponentArray
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<DisallowMultipleComponent>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<DisallowMultipleComponent>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__disallowMultipleComponentArray, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppReferenceArray<ExecuteInEditMode> _executeInEditModeArray
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<ExecuteInEditMode>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<ExecuteInEditMode>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__executeInEditModeArray, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppReferenceArray<RequireComponent> _requireComponentArray
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<RequireComponent>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<RequireComponent>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AttributeHelperEngine.NativeFieldInfoPtr__requireComponentArray, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_GetCustomAttributeOfType_Private_Static_T_Type_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(AttributeHelperEngine.NativeMethodInfoPtr_GetCustomAttributeOfType_Private_Static_T_Type_0, Il2CppClassPointerStore<AttributeHelperEngine>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
