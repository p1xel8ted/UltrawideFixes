// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyValueArticyModelList
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyValueArticyModelList(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_listIds;
  private static readonly System.IntPtr NativeFieldInfoPtr_list;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_List_1_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_List_1_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CustomClone_Public_Virtual_Final_New_Void_IArticyCustomValueClone_0;

  static ArticyValueArticyModelList()
  {
    Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyValueArticyModelList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr);
    ArticyValueArticyModelList.NativeFieldInfoPtr_listIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr, nameof (listIds));
    ArticyValueArticyModelList.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr, nameof (list));
    ArticyValueArticyModelList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr, 100664024);
    ArticyValueArticyModelList.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_List_1_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr, 100664025);
    ArticyValueArticyModelList.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_List_1_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr, 100664026);
    ArticyValueArticyModelList.NativeMethodInfoPtr_CustomClone_Public_Virtual_Final_New_Void_IArticyCustomValueClone_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr, 100664027);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 994140, RefRangeEnd = 994148, XrefRangeStart = 994133, XrefRangeEnd = 994140, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueArticyModelList()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueArticyModelList>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyModelList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 994156, RefRangeEnd = 994162, XrefRangeStart = 994148, XrefRangeEnd = 994156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetValue(List<ArticyObject> aNew)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNew)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyModelList.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_List_1_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(23)]
  [CachedScanResults(RefRangeStart = 994180, RefRangeEnd = 994203, XrefRangeStart = 994162, XrefRangeEnd = 994180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<ArticyObject> GetValue()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyModelList.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_List_1_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num3);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 994211, RefRangeEnd = 994219, XrefRangeStart = 994203, XrefRangeEnd = 994211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CustomClone(IArticyCustomValueClone aTargetObject)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueArticyModelList.NativeMethodInfoPtr_CustomClone_Public_Virtual_Final_New_Void_IArticyCustomValueClone_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppStructArray<ulong> listIds
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyValueArticyModelList.NativeFieldInfoPtr_listIds));
      return num == System.IntPtr.Zero ? (Il2CppStructArray<ulong>) null : Il2CppObjectPool.Get<Il2CppStructArray<ulong>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyValueArticyModelList.NativeFieldInfoPtr_listIds), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<ArticyObject> list
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyValueArticyModelList.NativeFieldInfoPtr_list));
      return num == System.IntPtr.Zero ? (List<ArticyObject>) null : Il2CppObjectPool.Get<List<ArticyObject>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyValueArticyModelList.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
