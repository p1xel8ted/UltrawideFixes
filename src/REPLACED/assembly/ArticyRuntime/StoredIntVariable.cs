// Decompiled with JetBrains decompiler
// Type: Articy.Unity.StoredIntVariable
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
public sealed class StoredIntVariable(System.IntPtr pointer) : StoredBaseVariable(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mVar;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArticyIntVariable_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Var_Internal_get_ArticyIntVariable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

  static StoredIntVariable()
  {
    Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (StoredIntVariable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr);
    StoredIntVariable.NativeFieldInfoPtr_mVar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr, nameof (mVar));
    StoredIntVariable.NativeMethodInfoPtr__ctor_Internal_Void_ArticyIntVariable_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr, 100664082);
    StoredIntVariable.NativeMethodInfoPtr_get_Value_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr, 100664083);
    StoredIntVariable.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr, 100664084);
    StoredIntVariable.NativeMethodInfoPtr_get_Var_Internal_get_ArticyIntVariable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr, 100664085);
    StoredIntVariable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr, 100664086);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StoredIntVariable(ArticyIntVariable aVar, string aFullQualifiedName)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredIntVariable>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVar);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aFullQualifiedName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StoredIntVariable.NativeMethodInfoPtr__ctor_Internal_Void_ArticyIntVariable_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int Value
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 994706, RefRangeEnd = 994707, XrefRangeStart = 994704, XrefRangeEnd = 994706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredIntVariable.NativeMethodInfoPtr_get_Value_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994707, XrefRangeEnd = 994709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StoredIntVariable.NativeMethodInfoPtr_set_Value_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyIntVariable Var
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredIntVariable.NativeMethodInfoPtr_get_Var_Internal_get_ArticyIntVariable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyIntVariable) null : Il2CppObjectPool.Get<ArticyIntVariable>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994709, XrefRangeEnd = 994716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object Clone()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StoredIntVariable.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  public unsafe ArticyIntVariable mVar
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StoredIntVariable.NativeFieldInfoPtr_mVar));
      return num == System.IntPtr.Zero ? (ArticyIntVariable) null : Il2CppObjectPool.Get<ArticyIntVariable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StoredIntVariable.NativeFieldInfoPtr_mVar), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
