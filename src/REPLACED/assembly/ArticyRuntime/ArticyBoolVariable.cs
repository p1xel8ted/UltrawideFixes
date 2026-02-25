// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyBoolVariable
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public sealed class ArticyBoolVariable(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_values;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatePushed_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StatePopped_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

  static ArticyBoolVariable()
  {
    Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyBoolVariable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr);
    ArticyBoolVariable.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr, nameof (values));
    ArticyBoolVariable.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr, 100663303 /*0x06000007*/);
    ArticyBoolVariable.NativeMethodInfoPtr_StatePushed_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr, 100663304 /*0x06000008*/);
    ArticyBoolVariable.NativeMethodInfoPtr_StatePopped_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr, 100663305 /*0x06000009*/);
    ArticyBoolVariable.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr, 100663306 /*0x0600000A*/);
    ArticyBoolVariable.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr, 100663307 /*0x0600000B*/);
    ArticyBoolVariable.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr, 100663308 /*0x0600000C*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 984451, RefRangeEnd = 984452, XrefRangeStart = 984441, XrefRangeEnd = 984451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyBoolVariable(bool aInitialValue)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyBoolVariable>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aInitialValue
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyBoolVariable.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 984459, RefRangeEnd = 984460, XrefRangeStart = 984452, XrefRangeEnd = 984459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void StatePushed()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyBoolVariable.NativeMethodInfoPtr_StatePushed_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 984465, RefRangeEnd = 984466, XrefRangeStart = 984460, XrefRangeEnd = 984465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void StatePopped()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyBoolVariable.NativeMethodInfoPtr_StatePopped_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe bool Value
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 984471, RefRangeEnd = 984475, XrefRangeStart = 984466, XrefRangeEnd = 984471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyBoolVariable.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 984480, RefRangeEnd = 984483, XrefRangeStart = 984475, XrefRangeEnd = 984480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyBoolVariable.NativeMethodInfoPtr_set_Value_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 984500, RefRangeEnd = 984501, XrefRangeStart = 984483, XrefRangeEnd = 984500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyBoolVariable.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  public unsafe List<bool> values
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyBoolVariable.NativeFieldInfoPtr_values));
      return num == System.IntPtr.Zero ? (List<bool>) null : Il2CppObjectPool.Get<List<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyBoolVariable.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
