// Decompiled with JetBrains decompiler
// Type: Articy.Unity.StoredBoolVariable
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public sealed class StoredBoolVariable(System.IntPtr pointer) : StoredBaseVariable(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mVar;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArticyBoolVariable_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Var_Internal_get_ArticyBoolVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

  static StoredBoolVariable()
  {
    Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (StoredBoolVariable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr);
    StoredBoolVariable.NativeFieldInfoPtr_mVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr, nameof (mVar));
    StoredBoolVariable.NativeMethodInfoPtr__ctor_Internal_Void_ArticyBoolVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr, 100664077 /*0x0600030D*/);
    StoredBoolVariable.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr, 100664078 /*0x0600030E*/);
    StoredBoolVariable.NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr, 100664079 /*0x0600030F*/);
    StoredBoolVariable.NativeMethodInfoPtr_get_Var_Internal_get_ArticyBoolVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr, 100664080 /*0x06000310*/);
    StoredBoolVariable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr, 100664081);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StoredBoolVariable(ArticyBoolVariable aVar, string aFullQualifiedName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredBoolVariable>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVar);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFullQualifiedName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StoredBoolVariable.NativeMethodInfoPtr__ctor_Internal_Void_ArticyBoolVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool Value
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 994694, RefRangeEnd = 994695, XrefRangeStart = 994692, XrefRangeEnd = 994694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredBoolVariable.NativeMethodInfoPtr_get_Value_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994695, XrefRangeEnd = 994697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StoredBoolVariable.NativeMethodInfoPtr_set_Value_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyBoolVariable Var
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredBoolVariable.NativeMethodInfoPtr_get_Var_Internal_get_ArticyBoolVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyBoolVariable) null : Il2CppObjectPool.Get<ArticyBoolVariable>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994697, XrefRangeEnd = 994704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredBoolVariable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  public unsafe ArticyBoolVariable mVar
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoredBoolVariable.NativeFieldInfoPtr_mVar));
      return num == System.IntPtr.Zero ? (ArticyBoolVariable) null : Il2CppObjectPool.Get<ArticyBoolVariable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StoredBoolVariable.NativeFieldInfoPtr_mVar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
