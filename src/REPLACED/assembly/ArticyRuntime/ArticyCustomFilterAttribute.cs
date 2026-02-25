// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyCustomFilterAttribute
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyCustomFilterAttribute : Il2CppSystem.Attribute
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mType;
  private static readonly System.IntPtr NativeFieldInfoPtr_mMethodName;
  private static readonly System.IntPtr NativeFieldInfoPtr_mParams;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MethodName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0;

  static ArticyCustomFilterAttribute()
  {
    Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyCustomFilterAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr);
    ArticyCustomFilterAttribute.NativeFieldInfoPtr_mType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr, nameof (mType));
    ArticyCustomFilterAttribute.NativeFieldInfoPtr_mMethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr, nameof (mMethodName));
    ArticyCustomFilterAttribute.NativeFieldInfoPtr_mParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr, nameof (mParams));
    ArticyCustomFilterAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr, 100663949);
    ArticyCustomFilterAttribute.NativeMethodInfoPtr_get_MethodName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr, 100663950);
    ArticyCustomFilterAttribute.NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr, 100663951);
    ArticyCustomFilterAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr, 100663952 /*0x06000290*/);
    ArticyCustomFilterAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr, 100663953);
  }

  public unsafe Il2CppSystem.Type Type
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyCustomFilterAttribute.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
    }
  }

  public unsafe string MethodName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyCustomFilterAttribute.NativeMethodInfoPtr_get_MethodName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> Params
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyCustomFilterAttribute.NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993019, XrefRangeEnd = 993020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyCustomFilterAttribute(
    string aMethodName,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    // ISSUE: explicit constructor call
    this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr));
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aMethodName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyCustomFilterAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993020, XrefRangeEnd = 993021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyCustomFilterAttribute(
    Il2CppSystem.Type aType,
    string aMethodName,
    [Optional] Il2CppReferenceArray<Il2CppSystem.Object> aParams)
  {
    if (aParams == null)
      aParams = new Il2CppReferenceArray<Il2CppSystem.Object>(0L);
    // ISSUE: explicit constructor call
    this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyCustomFilterAttribute>.NativeClassPtr));
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aMethodName);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParams);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyCustomFilterAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ArticyCustomFilterAttribute(string aMethodName, params Il2CppSystem.Object[] aParams)
    : this(aMethodName, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams))
  {
  }

  public ArticyCustomFilterAttribute(Il2CppSystem.Type aType, string aMethodName, params Il2CppSystem.Object[] aParams)
    : this(aType, aMethodName, new Il2CppReferenceArray<Il2CppSystem.Object>(aParams))
  {
  }

  public ArticyCustomFilterAttribute(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppSystem.Type mType
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyCustomFilterAttribute.NativeFieldInfoPtr_mType));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyCustomFilterAttribute.NativeFieldInfoPtr_mType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string mMethodName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyCustomFilterAttribute.NativeFieldInfoPtr_mMethodName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyCustomFilterAttribute.NativeFieldInfoPtr_mMethodName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> mParams
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyCustomFilterAttribute.NativeFieldInfoPtr_mParams));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyCustomFilterAttribute.NativeFieldInfoPtr_mParams), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
