// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.BlittableListWrapper
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Bindings;

[StructLayout(LayoutKind.Explicit)]
public struct BlittableListWrapper
{
  private static readonly System.IntPtr NativeFieldInfoPtr_arrayWrapper;
  private static readonly System.IntPtr NativeFieldInfoPtr_listSize;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BlittableArrayWrapper_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Unmarshal_Internal_Void_List_1_T_0;
  [FieldOffset(0)]
  public BlittableArrayWrapper arrayWrapper;
  [FieldOffset(16 /*0x10*/)]
  public int listSize;

  static BlittableListWrapper()
  {
    Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (BlittableListWrapper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr);
    BlittableListWrapper.NativeFieldInfoPtr_arrayWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, nameof (arrayWrapper));
    BlittableListWrapper.NativeFieldInfoPtr_listSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, nameof (listSize));
    BlittableListWrapper.NativeMethodInfoPtr__ctor_Public_Void_BlittableArrayWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, 100669194);
    BlittableListWrapper.NativeMethodInfoPtr_Unmarshal_Internal_Void_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, 100669195);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 327729, RefRangeEnd = 327730, XrefRangeStart = 327729, XrefRangeEnd = 327730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BlittableListWrapper(BlittableArrayWrapper arrayWrapper, int listSize)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &arrayWrapper;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &listSize;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BlittableListWrapper.NativeMethodInfoPtr__ctor_Public_Void_BlittableArrayWrapper_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478528, XrefRangeEnd = 478531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Unmarshal<T>(List<T> list) where T : new()
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) list)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BlittableListWrapper.MethodInfoStoreGeneric_Unmarshal_Internal_Void_List_1_T_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr, (System.IntPtr) ref this));
  }

  private sealed class MethodInfoStoreGeneric_Unmarshal_Internal_Void_List_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BlittableListWrapper.NativeMethodInfoPtr_Unmarshal_Internal_Void_List_1_T_0, Il2CppClassPointerStore<BlittableListWrapper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
