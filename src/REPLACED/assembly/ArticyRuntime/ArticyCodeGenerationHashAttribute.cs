// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyCodeGenerationHashAttribute
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyCodeGenerationHashAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__Hash_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Hash_Public_get_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Hash_Private_set_Void_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

  static ArticyCodeGenerationHashAttribute()
  {
    Il2CppClassPointerStore<ArticyCodeGenerationHashAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyCodeGenerationHashAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyCodeGenerationHashAttribute>.NativeClassPtr);
    ArticyCodeGenerationHashAttribute.NativeFieldInfoPtr__Hash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyCodeGenerationHashAttribute>.NativeClassPtr, "<Hash>k__BackingField");
    ArticyCodeGenerationHashAttribute.NativeMethodInfoPtr_get_Hash_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyCodeGenerationHashAttribute>.NativeClassPtr, 100663315 /*0x06000013*/);
    ArticyCodeGenerationHashAttribute.NativeMethodInfoPtr_set_Hash_Private_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyCodeGenerationHashAttribute>.NativeClassPtr, 100663316 /*0x06000014*/);
    ArticyCodeGenerationHashAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyCodeGenerationHashAttribute>.NativeClassPtr, 100663317 /*0x06000015*/);
  }

  public unsafe long Hash
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyCodeGenerationHashAttribute.NativeMethodInfoPtr_get_Hash_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(long*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyCodeGenerationHashAttribute.NativeMethodInfoPtr_set_Hash_Private_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 255058, RefRangeEnd = 255093, XrefRangeStart = 255058, XrefRangeEnd = 255093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyCodeGenerationHashAttribute(long aHash)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyCodeGenerationHashAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aHash
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyCodeGenerationHashAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe long _Hash_k__BackingField
  {
    get
    {
      return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyCodeGenerationHashAttribute.NativeFieldInfoPtr__Hash_k__BackingField));
    }
    [param: In] set
    {
      *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyCodeGenerationHashAttribute.NativeFieldInfoPtr__Hash_k__BackingField)) = value;
    }
  }
}
