// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyNotificationManager
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class ArticyNotificationManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr_mStorage;
  private static readonly System.IntPtr NativeFieldInfoPtr_mNotificationMap;
  private static readonly System.IntPtr NativeFieldInfoPtr_mRemoveAllBlackListedTypes;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_String_Action_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddRawListener_Private_Void_String_WeakDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRawListener_Private_Void_String_Action_2_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveRawListener_Private_Void_WeakDelegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_NotifyPropertyChanged_Public_Void_String_Object_0;

  static ArticyNotificationManager()
  {
    Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyNotificationManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr);
    ArticyNotificationManager.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, nameof (Logger));
    ArticyNotificationManager.NativeFieldInfoPtr_mStorage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, nameof (mStorage));
    ArticyNotificationManager.NativeFieldInfoPtr_mNotificationMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, nameof (mNotificationMap));
    ArticyNotificationManager.NativeFieldInfoPtr_mRemoveAllBlackListedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, nameof (mRemoveAllBlackListedTypes));
    ArticyNotificationManager.NativeMethodInfoPtr__ctor_Internal_Void_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, 100663713);
    ArticyNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_Action_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, 100663714);
    ArticyNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, 100663715);
    ArticyNotificationManager.NativeMethodInfoPtr_AddRawListener_Private_Void_String_WeakDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, 100663716);
    ArticyNotificationManager.NativeMethodInfoPtr_RemoveRawListener_Private_Void_String_Action_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, 100663717);
    ArticyNotificationManager.NativeMethodInfoPtr_RemoveRawListener_Private_Void_WeakDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, 100663718);
    ArticyNotificationManager.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, 100663719);
    ArticyNotificationManager.NativeMethodInfoPtr_NotifyPropertyChanged_Public_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, 100663720);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 990075, RefRangeEnd = 990077, XrefRangeStart = 990059, XrefRangeEnd = 990075, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyNotificationManager(BaseGlobalVariables aStorage)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStorage)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.NativeMethodInfoPtr__ctor_Internal_Void_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 990127, RefRangeEnd = 990130, XrefRangeStart = 990077, XrefRangeEnd = 990127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(string aVariable, Il2CppSystem.Action<string, Il2CppSystem.Object> aNotificationFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNotificationFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.NativeMethodInfoPtr_AddListener_Public_Void_String_Action_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 990164, RefRangeEnd = 990169, XrefRangeStart = 990130, XrefRangeEnd = 990164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(string aVariable, Il2CppSystem.Action<string, Il2CppSystem.Object> aNotificationFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNotificationFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.NativeMethodInfoPtr_RemoveListener_Public_Void_String_Action_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 990184, RefRangeEnd = 990186, XrefRangeStart = 990169, XrefRangeEnd = 990184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddRawListener(
    string aVariable,
    ArticyNotificationManager.WeakDelegate aWeakDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aWeakDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.NativeMethodInfoPtr_AddRawListener_Private_Void_String_WeakDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 990196, RefRangeEnd = 990198, XrefRangeStart = 990186, XrefRangeEnd = 990196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveRawListener(string aVariable, Il2CppSystem.Action<string, Il2CppSystem.Object> aNotificationFunc)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNotificationFunc);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.NativeMethodInfoPtr_RemoveRawListener_Private_Void_String_Action_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 990216, RefRangeEnd = 990217, XrefRangeStart = 990198, XrefRangeEnd = 990216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveRawListener(
    ArticyNotificationManager.WeakDelegate aWeakDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aWeakDelegate)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.NativeMethodInfoPtr_RemoveRawListener_Private_Void_WeakDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 990283, RefRangeEnd = 990284, XrefRangeStart = 990217, XrefRangeEnd = 990283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveAllListeners()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 990313, RefRangeEnd = 990317, XrefRangeStart = 990284, XrefRangeEnd = 990313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void NotifyPropertyChanged(string aVariable, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariable);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.NativeMethodInfoPtr_NotifyPropertyChanged_Public_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ArticyNotificationManager.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ArticyNotificationManager.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BaseGlobalVariables mStorage
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.NativeFieldInfoPtr_mStorage));
      return num == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.NativeFieldInfoPtr_mStorage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<string, HashSet<ArticyNotificationManager.WeakDelegate>> mNotificationMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.NativeFieldInfoPtr_mNotificationMap));
      return num == System.IntPtr.Zero ? (Dictionary<string, HashSet<ArticyNotificationManager.WeakDelegate>>) null : Il2CppObjectPool.Get<Dictionary<string, HashSet<ArticyNotificationManager.WeakDelegate>>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.NativeFieldInfoPtr_mNotificationMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Type> mRemoveAllBlackListedTypes
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.NativeFieldInfoPtr_mRemoveAllBlackListedTypes));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.NativeFieldInfoPtr_mRemoveAllBlackListedTypes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class WeakDelegate(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sGetMethodInfoMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_sCreateDelegateMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_sActionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_sGetMethodInfoFunc;
    private static readonly System.IntPtr NativeFieldInfoPtr_sCreateDelegateFunc;
    private static readonly System.IntPtr NativeFieldInfoPtr_mReference;
    private static readonly System.IntPtr NativeFieldInfoPtr_mMethod;
    private static readonly System.IntPtr NativeFieldInfoPtr_mMethodInfo;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_2_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Reference_Public_get_WeakReference_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Boolean_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegate_Private_Static_Action_2_String_Object_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Action_2_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Action_2_String_Object_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Action_2_String_Object_Object_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0;

    static WeakDelegate()
    {
      Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArticyNotificationManager>.NativeClassPtr, nameof (WeakDelegate));
      ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sGetMethodInfoMethod));
      ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sCreateDelegateMethod));
      ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sActionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sActionType));
      ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sGetMethodInfoFunc));
      ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, nameof (sCreateDelegateFunc));
      ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, nameof (mReference));
      ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, nameof (mMethod));
      ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, nameof (mMethodInfo));
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663723);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663724);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr__ctor_Public_Void_Action_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663725);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663726);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_get_Reference_Public_get_WeakReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663727);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Boolean_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663728 /*0x060001B0*/);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Action_2_String_Object_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663729);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Action_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663730);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Action_2_String_Object_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663731);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663732);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Action_2_String_Object_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663733);
      ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr, 100663734);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 989999, XrefRangeEnd = 990001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Equals(Il2CppSystem.Object aOther)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOther)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 990004, RefRangeEnd = 990006, XrefRangeStart = 990001, XrefRangeEnd = 990004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WeakDelegate(Il2CppSystem.Action<string, Il2CppSystem.Object> aStrongReferenceAction)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyNotificationManager.WeakDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aStrongReferenceAction)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr__ctor_Public_Void_Action_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe bool IsAlive
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_get_IsAlive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    public unsafe Il2CppSystem.WeakReference Reference
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_get_Reference_Public_get_WeakReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        System.IntPtr num3 = num2;
        return num3 == System.IntPtr.Zero ? (Il2CppSystem.WeakReference) null : Il2CppObjectPool.Get<Il2CppSystem.WeakReference>(num3);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 990008, RefRangeEnd = 990009, XrefRangeStart = 990006, XrefRangeEnd = 990008, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool Invoke(string aVariable, Il2CppSystem.Object aValue)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aVariable);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_Invoke_Public_Boolean_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990009, XrefRangeEnd = 990014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Action<string, Il2CppSystem.Object> CreateDelegate(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegate_Private_Static_Action_2_String_Object_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppSystem.Object>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990014, XrefRangeEnd = 990019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfo(Il2CppSystem.Action<string, Il2CppSystem.Object> aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfo_Private_Static_MethodInfo_Action_2_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990019, XrefRangeEnd = 990026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Action<string, Il2CppSystem.Object> CreateDelegateNormal(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegateNormal_Private_Static_Action_2_String_Object_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppSystem.Object>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990026, XrefRangeEnd = 990028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfoNormal(Il2CppSystem.Delegate aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoNormal_Private_Static_MethodInfo_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990028, XrefRangeEnd = 990048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppSystem.Action<string, Il2CppSystem.Object> CreateDelegateUwp(
      Il2CppSystem.Object aTargetObject,
      MethodInfo aMethod)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aTargetObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethod);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_CreateDelegateUwp_Private_Static_Action_2_String_Object_Object_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Action<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppSystem.Object>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 990048, XrefRangeEnd = 990059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe MethodInfo GetMethodInfoUwp(Il2CppSystem.Delegate aAction)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aAction)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyNotificationManager.WeakDelegate.NativeMethodInfoPtr_GetMethodInfoUwp_Private_Static_MethodInfo_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
    }

    public static unsafe MethodInfo sGetMethodInfoMethod
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoMethod, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe MethodInfo sCreateDelegateMethod
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateMethod, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Type sActionType
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sActionType, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sActionType, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo> sGetMethodInfoFunc
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Delegate, MethodInfo>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sGetMethodInfoFunc, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Action<string, Il2CppSystem.Object>> sCreateDelegateFunc
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Action<string, Il2CppSystem.Object>>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<Il2CppSystem.Object, MethodInfo, Il2CppSystem.Action<string, Il2CppSystem.Object>>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_sCreateDelegateFunc, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.WeakReference mReference
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mReference));
        return num == System.IntPtr.Zero ? (Il2CppSystem.WeakReference) null : Il2CppObjectPool.Get<Il2CppSystem.WeakReference>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mReference), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<string, Il2CppSystem.Object> mMethod
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethod));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<string, Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<string, Il2CppSystem.Object>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MethodInfo mMethodInfo
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethodInfo));
        return num == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyNotificationManager.WeakDelegate.NativeFieldInfoPtr_mMethodInfo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
