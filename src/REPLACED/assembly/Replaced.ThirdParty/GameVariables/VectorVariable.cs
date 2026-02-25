// Decompiled with JetBrains decompiler
// Type: GameVariables.VectorVariable
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace GameVariables;

public class VectorVariable(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Value;
  private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_VectorVariable_0;
  private static readonly IntPtr NativeMethodInfoPtr_ApplyChange_Public_Void_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_ApplyChange_Public_Void_VectorVariable_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VectorVariable()
  {
    Il2CppClassPointerStore<VectorVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameVariables", nameof (VectorVariable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorVariable>.NativeClassPtr);
    VectorVariable.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorVariable>.NativeClassPtr, nameof (Value));
    VectorVariable.NativeMethodInfoPtr_SetValue_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorVariable>.NativeClassPtr, 100663393 /*0x06000061*/);
    VectorVariable.NativeMethodInfoPtr_SetValue_Public_Void_VectorVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorVariable>.NativeClassPtr, 100663394 /*0x06000062*/);
    VectorVariable.NativeMethodInfoPtr_ApplyChange_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorVariable>.NativeClassPtr, 100663395 /*0x06000063*/);
    VectorVariable.NativeMethodInfoPtr_ApplyChange_Public_Void_VectorVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorVariable>.NativeClassPtr, 100663396 /*0x06000064*/);
    VectorVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorVariable>.NativeClassPtr, 100663397 /*0x06000065*/);
  }

  [CallerCount(0)]
  public unsafe void SetValue(Vector3 value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VectorVariable.NativeMethodInfoPtr_SetValue_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetValue(VectorVariable value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VectorVariable.NativeMethodInfoPtr_SetValue_Public_Void_VectorVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ApplyChange(Vector3 amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &amount
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VectorVariable.NativeMethodInfoPtr_ApplyChange_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ApplyChange(VectorVariable amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) amount)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VectorVariable.NativeMethodInfoPtr_ApplyChange_Public_Void_VectorVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VectorVariable()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorVariable>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VectorVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 Value
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VectorVariable.NativeFieldInfoPtr_Value));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VectorVariable.NativeFieldInfoPtr_Value)) = value;
    }
  }
}
