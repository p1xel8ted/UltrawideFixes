// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyValueArticyMultiLanguageString
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
public class ArticyValueArticyMultiLanguageString(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_value;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;

  static ArticyValueArticyMultiLanguageString()
  {
    Il2CppClassPointerStore<ArticyValueArticyMultiLanguageString>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyValueArticyMultiLanguageString));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueArticyMultiLanguageString>.NativeClassPtr);
    ArticyValueArticyMultiLanguageString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyValueArticyMultiLanguageString>.NativeClassPtr, nameof (value));
    ArticyValueArticyMultiLanguageString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyMultiLanguageString>.NativeClassPtr, 100664036);
    ArticyValueArticyMultiLanguageString.NativeMethodInfoPtr_GetValue_Public_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyMultiLanguageString>.NativeClassPtr, 100664037);
    ArticyValueArticyMultiLanguageString.NativeMethodInfoPtr_SetValue_Public_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyMultiLanguageString>.NativeClassPtr, 100664038);
    ArticyValueArticyMultiLanguageString.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyMultiLanguageString>.NativeClassPtr, 100664039);
  }

  [CallerCount(48 /*0x30*/)]
  [CachedScanResults(RefRangeStart = 994468, RefRangeEnd = 994516, XrefRangeStart = 994463, XrefRangeEnd = 994468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueArticyMultiLanguageString()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueArticyMultiLanguageString>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyMultiLanguageString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyMultiLanguageString GetValue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyMultiLanguageString.NativeMethodInfoPtr_GetValue_Public_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
  }

  [CallerCount(82)]
  [CachedScanResults(RefRangeStart = 994337, RefRangeEnd = 994419, XrefRangeStart = 994337, XrefRangeEnd = 994419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetValue(ArticyMultiLanguageString aNew)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNew)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyMultiLanguageString.NativeMethodInfoPtr_SetValue_Public_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(26)]
  [CachedScanResults(RefRangeStart = 994529, RefRangeEnd = 994555, XrefRangeStart = 994516, XrefRangeEnd = 994529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyMultiLanguageString.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  public unsafe ArticyMultiLanguageString value
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyValueArticyMultiLanguageString.NativeFieldInfoPtr_value));
      return num == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyValueArticyMultiLanguageString.NativeFieldInfoPtr_value), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
