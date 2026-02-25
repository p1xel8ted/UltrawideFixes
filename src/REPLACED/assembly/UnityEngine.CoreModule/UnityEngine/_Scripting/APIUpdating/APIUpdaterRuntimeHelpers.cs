// Decompiled with JetBrains decompiler
// Type: UnityEngine._Scripting.APIUpdating.APIUpdaterRuntimeHelpers
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine._Scripting.APIUpdating;

public class APIUpdaterRuntimeHelpers(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0;

  static APIUpdaterRuntimeHelpers()
  {
    Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine._Scripting.APIUpdating", nameof (APIUpdaterRuntimeHelpers));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr);
    APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr, 100668895);
    APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<APIUpdaterRuntimeHelpers>.NativeClassPtr, 100668896);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472275, XrefRangeEnd = 472282, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetMovedFromAttributeDataForType(
    Il2CppSystem.Type sourceType,
    out string assembly,
    out string nsp,
    out string klass)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceType);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero3 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero3;
    *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetMovedFromAttributeDataForType_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    assembly = IL2CPP.Il2CppStringToManaged(zero1);
    nsp = IL2CPP.Il2CppStringToManaged(zero2);
    klass = IL2CPP.Il2CppStringToManaged(zero3);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472282, XrefRangeEnd = 472307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool GetObsoleteTypeRedirection(
    Il2CppSystem.Type sourceType,
    out string assemblyName,
    out string nsp,
    out string className)
  {
    System.IntPtr* numPtr1 = stackalloc System.IntPtr[4];
    numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceType);
    System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    System.IntPtr zero1 = System.IntPtr.Zero;
    System.IntPtr* numPtr2 = &zero1;
    *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
    System.IntPtr num2 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
    System.IntPtr zero2 = System.IntPtr.Zero;
    System.IntPtr* numPtr3 = &zero2;
    *(System.IntPtr*) num2 = (System.IntPtr) numPtr3;
    System.IntPtr num3 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(3) * sizeof (System.IntPtr));
    System.IntPtr zero3 = System.IntPtr.Zero;
    System.IntPtr* numPtr4 = &zero3;
    *(System.IntPtr*) num3 = (System.IntPtr) numPtr4;
    System.IntPtr num4;
    System.IntPtr num5 = IL2CPP.il2cpp_runtime_invoke(APIUpdaterRuntimeHelpers.NativeMethodInfoPtr_GetObsoleteTypeRedirection_Internal_Static_Boolean_Type_byref_String_byref_String_byref_String_0, System.IntPtr.Zero, (void**) numPtr1, ref num4);
    Il2CppException.RaiseExceptionIfNecessary(num4);
    assemblyName = IL2CPP.Il2CppStringToManaged(zero1);
    nsp = IL2CPP.Il2CppStringToManaged(zero2);
    className = IL2CPP.Il2CppStringToManaged(zero3);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num5);
  }
}
