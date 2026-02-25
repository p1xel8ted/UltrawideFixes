// Decompiled with JetBrains decompiler
// Type: Articy.Unity.StoredStringVariable
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
public sealed class StoredStringVariable(System.IntPtr pointer) : StoredBaseVariable(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mVar;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArticyStringVariable_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Var_Internal_get_ArticyStringVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

  static StoredStringVariable()
  {
    Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (StoredStringVariable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr);
    StoredStringVariable.NativeFieldInfoPtr_mVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr, nameof (mVar));
    StoredStringVariable.NativeMethodInfoPtr__ctor_Internal_Void_ArticyStringVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr, 100664087);
    StoredStringVariable.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr, 100664088);
    StoredStringVariable.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr, 100664089);
    StoredStringVariable.NativeMethodInfoPtr_get_Var_Internal_get_ArticyStringVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr, 100664090);
    StoredStringVariable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr, 100664091);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StoredStringVariable(ArticyStringVariable aVar, string aFullQualifiedName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredStringVariable>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVar);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFullQualifiedName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StoredStringVariable.NativeMethodInfoPtr__ctor_Internal_Void_ArticyStringVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string Value
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 994721, RefRangeEnd = 994724, XrefRangeStart = 994716, XrefRangeEnd = 994721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredStringVariable.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 994729, RefRangeEnd = 994731, XrefRangeStart = 994724, XrefRangeEnd = 994729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StoredStringVariable.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyStringVariable Var
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredStringVariable.NativeMethodInfoPtr_get_Var_Internal_get_ArticyStringVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyStringVariable) null : Il2CppObjectPool.Get<ArticyStringVariable>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994731, XrefRangeEnd = 994745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredStringVariable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  public unsafe ArticyStringVariable mVar
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoredStringVariable.NativeFieldInfoPtr_mVar));
      return num == System.IntPtr.Zero ? (ArticyStringVariable) null : Il2CppObjectPool.Get<ArticyStringVariable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StoredStringVariable.NativeFieldInfoPtr_mVar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
