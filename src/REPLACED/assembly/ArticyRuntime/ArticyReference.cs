// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyReference
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public class ArticyReference(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_reference;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_TModel_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetObject_Public_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyReference()
  {
    Il2CppClassPointerStore<ArticyReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyReference));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyReference>.NativeClassPtr);
    ArticyReference.NativeFieldInfoPtr_reference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyReference>.NativeClassPtr, nameof (reference));
    ArticyReference.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyReference>.NativeClassPtr, 100663817 /*0x06000209*/);
    ArticyReference.NativeMethodInfoPtr_GetObject_Public_TModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyReference>.NativeClassPtr, 100663818 /*0x0600020A*/);
    ArticyReference.NativeMethodInfoPtr_SetObject_Public_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyReference>.NativeClassPtr, 100663819 /*0x0600020B*/);
    ArticyReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyReference>.NativeClassPtr, 100663820 /*0x0600020C*/);
  }

  public unsafe bool IsValid
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 990996, RefRangeEnd = 990997, XrefRangeStart = 990996, XrefRangeEnd = 990996, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyReference.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990997, XrefRangeEnd = 990999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TModel GetObject<TModel>() where TModel : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyReference.MethodInfoStoreGeneric_GetObject_Public_TModel_0<TModel>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TModel>(num2, false, true);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990999, XrefRangeEnd = 991004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetObject(ArticyObject aObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyReference.NativeMethodInfoPtr_SetObject_Public_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyReference()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyReference>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef reference
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyReference.NativeFieldInfoPtr_reference));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyReference.NativeFieldInfoPtr_reference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  private sealed class MethodInfoStoreGeneric_GetObject_Public_TModel_0<TModel>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyReference.NativeMethodInfoPtr_GetObject_Public_TModel_0, Il2CppClassPointerStore<ArticyReference>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TModel>.NativeClassPtr))
    }))));
  }
}
