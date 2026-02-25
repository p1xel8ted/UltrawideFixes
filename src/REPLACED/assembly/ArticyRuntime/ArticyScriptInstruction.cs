// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyScriptInstruction
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
public class ArticyScriptInstruction(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_handlerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_ownerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_ownerInstanceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRawScript;
  private static readonly System.IntPtr NativeMethodInfoPtr_CallScript_Public_Void_IBaseScriptMethodProvider_IGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_RawScript_Public_Virtual_Final_New_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_RawScript_Public_Virtual_Final_New_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignOwnerId_Public_Virtual_Final_New_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AssignHandlerId_Public_Virtual_Final_New_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyScriptInstruction()
  {
    Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyScriptInstruction));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr);
    ArticyScriptInstruction.NativeFieldInfoPtr_handlerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, nameof (handlerId));
    ArticyScriptInstruction.NativeFieldInfoPtr_ownerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, nameof (ownerId));
    ArticyScriptInstruction.NativeFieldInfoPtr_ownerInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, nameof (ownerInstanceId));
    ArticyScriptInstruction.NativeFieldInfoPtr_mRawScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, nameof (mRawScript));
    ArticyScriptInstruction.NativeMethodInfoPtr_CallScript_Public_Void_IBaseScriptMethodProvider_IGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, 100664052);
    ArticyScriptInstruction.NativeMethodInfoPtr_get_RawScript_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, 100664053);
    ArticyScriptInstruction.NativeMethodInfoPtr_set_RawScript_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, 100664054);
    ArticyScriptInstruction.NativeMethodInfoPtr_AssignOwnerId_Public_Virtual_Final_New_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, 100664055);
    ArticyScriptInstruction.NativeMethodInfoPtr_AssignHandlerId_Public_Virtual_Final_New_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, 100664056);
    ArticyScriptInstruction.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, 100664057);
    ArticyScriptInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr, 100664058);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 994631, RefRangeEnd = 994637, XrefRangeStart = 994614, XrefRangeEnd = 994631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CallScript(
    IBaseScriptMethodProvider aMethodProvider = null,
    IGlobalVariables aVariables = null)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVariables);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyScriptInstruction.NativeMethodInfoPtr_CallScript_Public_Void_IBaseScriptMethodProvider_IGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public virtual unsafe string RawScript
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyScriptInstruction.NativeMethodInfoPtr_get_RawScript_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArticyScriptInstruction.NativeMethodInfoPtr_set_RawScript_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(ArticyScriptInstruction.NativeMethodInfoPtr_AssignOwnerId_Public_Virtual_Final_New_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
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
    IL2CPP.il2cpp_runtime_invoke(ArticyScriptInstruction.NativeMethodInfoPtr_AssignHandlerId_Public_Virtual_Final_New_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 994647, RefRangeEnd = 994650, XrefRangeStart = 994637, XrefRangeEnd = 994647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyScriptInstruction.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyScriptInstruction()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyScriptInstruction>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyScriptInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe uint handlerId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptInstruction.NativeFieldInfoPtr_handlerId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptInstruction.NativeFieldInfoPtr_handlerId)) = value;
    }
  }

  public unsafe ulong ownerId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptInstruction.NativeFieldInfoPtr_ownerId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptInstruction.NativeFieldInfoPtr_ownerId)) = value;
    }
  }

  public unsafe uint ownerInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptInstruction.NativeFieldInfoPtr_ownerInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptInstruction.NativeFieldInfoPtr_ownerInstanceId)) = value;
    }
  }

  public unsafe string mRawScript
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptInstruction.NativeFieldInfoPtr_mRawScript)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyScriptInstruction.NativeFieldInfoPtr_mRawScript), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
