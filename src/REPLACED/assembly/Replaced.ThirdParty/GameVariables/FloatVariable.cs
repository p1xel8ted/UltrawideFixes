// Decompiled with JetBrains decompiler
// Type: GameVariables.FloatVariable
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

public class FloatVariable(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Value;
  private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_FloatVariable_0;
  private static readonly IntPtr NativeMethodInfoPtr_ApplyChange_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_ApplyChange_Public_Void_FloatVariable_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FloatVariable()
  {
    Il2CppClassPointerStore<FloatVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameVariables", nameof (FloatVariable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr);
    FloatVariable.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr, nameof (Value));
    FloatVariable.NativeMethodInfoPtr_SetValue_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr, 100663364 /*0x06000044*/);
    FloatVariable.NativeMethodInfoPtr_SetValue_Public_Void_FloatVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr, 100663365 /*0x06000045*/);
    FloatVariable.NativeMethodInfoPtr_ApplyChange_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr, 100663366 /*0x06000046*/);
    FloatVariable.NativeMethodInfoPtr_ApplyChange_Public_Void_FloatVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr, 100663367 /*0x06000047*/);
    FloatVariable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr, 100663368 /*0x06000048*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 70590, RefRangeEnd = 70591, XrefRangeStart = 70590, XrefRangeEnd = 70591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetValue(float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &value
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatVariable.NativeMethodInfoPtr_SetValue_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void SetValue(FloatVariable value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatVariable.NativeMethodInfoPtr_SetValue_Public_Void_FloatVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 360907, RefRangeEnd = 360910, XrefRangeStart = 360907, XrefRangeEnd = 360907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ApplyChange(float amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &amount
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatVariable.NativeMethodInfoPtr_ApplyChange_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ApplyChange(FloatVariable amount)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) amount)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatVariable.NativeMethodInfoPtr_ApplyChange_Public_Void_FloatVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FloatVariable()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatVariable>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatVariable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float Value
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatVariable.NativeFieldInfoPtr_Value));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatVariable.NativeFieldInfoPtr_Value)) = value;
    }
  }
}
