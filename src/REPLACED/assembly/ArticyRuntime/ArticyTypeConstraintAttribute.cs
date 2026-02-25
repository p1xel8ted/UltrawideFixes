// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyTypeConstraintAttribute
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

public sealed class ArticyTypeConstraintAttribute : Il2CppSystem.Attribute
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mConstraintType;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ConstraintTypes_Public_get_Il2CppReferenceArray_1_Type_0;

  static ArticyTypeConstraintAttribute()
  {
    Il2CppClassPointerStore<ArticyTypeConstraintAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyTypeConstraintAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyTypeConstraintAttribute>.NativeClassPtr);
    ArticyTypeConstraintAttribute.NativeFieldInfoPtr_mConstraintType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTypeConstraintAttribute>.NativeClassPtr, nameof (mConstraintType));
    ArticyTypeConstraintAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeConstraintAttribute>.NativeClassPtr, 100663995);
    ArticyTypeConstraintAttribute.NativeMethodInfoPtr_get_ConstraintTypes_Public_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTypeConstraintAttribute>.NativeClassPtr, 100663996);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 255058, RefRangeEnd = 255093, XrefRangeStart = 255058, XrefRangeEnd = 255093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyTypeConstraintAttribute([Optional] Il2CppReferenceArray<Il2CppSystem.Type> aConstraintType)
  {
    if (aConstraintType == null)
      aConstraintType = new Il2CppReferenceArray<Il2CppSystem.Type>(0L);
    // ISSUE: explicit constructor call
    this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyTypeConstraintAttribute>.NativeClassPtr));
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aConstraintType)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTypeConstraintAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Type> ConstraintTypes
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyTypeConstraintAttribute.NativeMethodInfoPtr_get_ConstraintTypes_Public_get_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num3);
    }
  }

  public ArticyTypeConstraintAttribute(params Il2CppSystem.Type[] aConstraintType)
    : this(new Il2CppReferenceArray<Il2CppSystem.Type>(aConstraintType))
  {
  }

  public ArticyTypeConstraintAttribute(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Type> mConstraintType
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeConstraintAttribute.NativeFieldInfoPtr_mConstraintType));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTypeConstraintAttribute.NativeFieldInfoPtr_mConstraintType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
