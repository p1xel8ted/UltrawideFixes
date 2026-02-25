// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyAssetCaretaker
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyAssetCaretaker(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Logger;
  private static readonly IntPtr NativeFieldInfoPtr_targetComponent;
  private static readonly IntPtr NativeFieldInfoPtr_assetRef;
  private static readonly IntPtr NativeFieldInfoPtr_sSetResource;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_RepairReferencedAsset_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetResource_Private_Static_Boolean_Object_Object_0;
  private static readonly IntPtr NativeMethodInfoPtr_ReferenceChanged_Public_Virtual_Final_New_Void_String_UInt64_UInt64_0;

  static ArticyAssetCaretaker()
  {
    Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyAssetCaretaker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr);
    ArticyAssetCaretaker.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, nameof (Logger));
    ArticyAssetCaretaker.NativeFieldInfoPtr_targetComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, nameof (targetComponent));
    ArticyAssetCaretaker.NativeFieldInfoPtr_assetRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, nameof (assetRef));
    ArticyAssetCaretaker.NativeFieldInfoPtr_sSetResource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, nameof (sSetResource));
    ArticyAssetCaretaker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, 100663297 /*0x06000001*/);
    ArticyAssetCaretaker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, 100663298 /*0x06000002*/);
    ArticyAssetCaretaker.NativeMethodInfoPtr_RepairReferencedAsset_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, 100663299 /*0x06000003*/);
    ArticyAssetCaretaker.NativeMethodInfoPtr_SetResource_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, 100663300 /*0x06000004*/);
    ArticyAssetCaretaker.NativeMethodInfoPtr_ReferenceChanged_Public_Virtual_Final_New_Void_String_UInt64_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr, 100663301 /*0x06000005*/);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyAssetCaretaker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyAssetCaretaker>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyAssetCaretaker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984246, XrefRangeEnd = 984253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyAssetCaretaker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 984401, RefRangeEnd = 984403, XrefRangeStart = 984253, XrefRangeEnd = 984401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RepairReferencedAsset(bool aForced)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &aForced
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyAssetCaretaker.NativeMethodInfoPtr_RepairReferencedAsset_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 984434, RefRangeEnd = 984437, XrefRangeStart = 984403, XrefRangeEnd = 984434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool SetResource(UnityEngine.Object aTargetComp, UnityEngine.Object aAsset)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetComp);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAsset);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyAssetCaretaker.NativeMethodInfoPtr_SetResource_Private_Static_Boolean_Object_Object_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984437, XrefRangeEnd = 984441, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void ReferenceChanged(string aPropertyName, ulong aOldId, ulong aNewId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aPropertyName);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &aOldId;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &aNewId;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyAssetCaretaker.NativeMethodInfoPtr_ReferenceChanged_Public_Virtual_Final_New_Void_String_UInt64_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyAssetCaretaker.NativeFieldInfoPtr_Logger, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyAssetCaretaker.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Component targetComponent
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetCaretaker.NativeFieldInfoPtr_targetComponent));
      return num == IntPtr.Zero ? (Component) null : Il2CppObjectPool.Get<Component>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetCaretaker.NativeFieldInfoPtr_targetComponent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef assetRef
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetCaretaker.NativeFieldInfoPtr_assetRef));
      return num == IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyAssetCaretaker.NativeFieldInfoPtr_assetRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe MethodInfo sSetResource
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyAssetCaretaker.NativeFieldInfoPtr_sSetResource, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyAssetCaretaker.NativeFieldInfoPtr_sSetResource, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
