// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyScriptCondition
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyScriptCondition(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_handlerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_ownerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_ownerInstanceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRawScript;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallScript_Public_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RawScript_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RawScript_Public_Virtual_Final_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignOwnerId_Public_Virtual_Final_New_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignHandlerId_Public_Virtual_Final_New_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDefaultMethodProvider_Internal_Static_IBaseScriptMethodProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyScriptCondition()
  {
    Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyScriptCondition));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr);
    ArticyScriptCondition.NativeFieldInfoPtr_handlerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, nameof (handlerId));
    ArticyScriptCondition.NativeFieldInfoPtr_ownerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, nameof (ownerId));
    ArticyScriptCondition.NativeFieldInfoPtr_ownerInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, nameof (ownerInstanceId));
    ArticyScriptCondition.NativeFieldInfoPtr_mRawScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, nameof (mRawScript));
    ArticyScriptCondition.NativeMethodInfoPtr_CallScript_Public_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, 100664044);
    ArticyScriptCondition.NativeMethodInfoPtr_get_RawScript_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, 100664045);
    ArticyScriptCondition.NativeMethodInfoPtr_set_RawScript_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, 100664046);
    ArticyScriptCondition.NativeMethodInfoPtr_AssignOwnerId_Public_Virtual_Final_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, 100664047);
    ArticyScriptCondition.NativeMethodInfoPtr_AssignHandlerId_Public_Virtual_Final_New_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, 100664048 /*0x060002F0*/);
    ArticyScriptCondition.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, 100664049);
    ArticyScriptCondition.NativeMethodInfoPtr_GetDefaultMethodProvider_Internal_Static_IBaseScriptMethodProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, 100664050);
    ArticyScriptCondition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr, 100664051);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 994573, RefRangeEnd = 994581, XrefRangeStart = 994555, XrefRangeEnd = 994573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CallScript(
    IBaseScriptMethodProvider aMethodProvider = null,
    IGlobalVariables aVariables = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVariables);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyScriptCondition.NativeMethodInfoPtr_CallScript_Public_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe string RawScript
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyScriptCondition.NativeMethodInfoPtr_get_RawScript_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyScriptCondition.NativeMethodInfoPtr_set_RawScript_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void AssignOwnerId(ulong aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyScriptCondition.NativeMethodInfoPtr_AssignOwnerId_Public_Virtual_Final_New_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void AssignHandlerId(uint aId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &aId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyScriptCondition.NativeMethodInfoPtr_AssignHandlerId_Public_Virtual_Final_New_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 994591, RefRangeEnd = 994595, XrefRangeStart = 994581, XrefRangeEnd = 994591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyScriptCondition.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 994611, RefRangeEnd = 994614, XrefRangeStart = 994595, XrefRangeEnd = 994611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IBaseScriptMethodProvider GetDefaultMethodProvider()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyScriptCondition.NativeMethodInfoPtr_GetDefaultMethodProvider_Internal_Static_IBaseScriptMethodProvider_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IBaseScriptMethodProvider) null : Il2CppObjectPool.Get<IBaseScriptMethodProvider>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyScriptCondition()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyScriptCondition>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyScriptCondition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe uint handlerId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptCondition.NativeFieldInfoPtr_handlerId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptCondition.NativeFieldInfoPtr_handlerId)) = value;
    }
  }

  public unsafe ulong ownerId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptCondition.NativeFieldInfoPtr_ownerId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptCondition.NativeFieldInfoPtr_ownerId)) = value;
    }
  }

  public unsafe uint ownerInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptCondition.NativeFieldInfoPtr_ownerInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptCondition.NativeFieldInfoPtr_ownerInstanceId)) = value;
    }
  }

  public unsafe string mRawScript
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptCondition.NativeFieldInfoPtr_mRawScript)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptCondition.NativeFieldInfoPtr_mRawScript), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
