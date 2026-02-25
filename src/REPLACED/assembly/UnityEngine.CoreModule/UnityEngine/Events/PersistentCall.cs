// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.PersistentCall
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

[Serializable]
public class PersistentCall(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Target;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TargetAssemblyTypeName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MethodName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Mode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Arguments;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CallState;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_target_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_methodName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PersistentCall()
  {
    Il2CppClassPointerStore<PersistentCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", nameof (PersistentCall));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr);
    PersistentCall.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, nameof (m_Target));
    PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, nameof (m_TargetAssemblyTypeName));
    PersistentCall.NativeFieldInfoPtr_m_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, nameof (m_MethodName));
    PersistentCall.NativeFieldInfoPtr_m_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, nameof (m_Mode));
    PersistentCall.NativeFieldInfoPtr_m_Arguments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, nameof (m_Arguments));
    PersistentCall.NativeFieldInfoPtr_m_CallState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, nameof (m_CallState));
    PersistentCall.NativeMethodInfoPtr_get_target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669099);
    PersistentCall.NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669100);
    PersistentCall.NativeMethodInfoPtr_get_methodName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669101);
    PersistentCall.NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669102);
    PersistentCall.NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669103);
    PersistentCall.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669104);
    PersistentCall.NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669105);
    PersistentCall.NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669106);
    PersistentCall.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669107);
    PersistentCall.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669108);
    PersistentCall.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr, 100669109);
  }

  public unsafe UnityEngine.Object target
  {
    [CallerCount(211), CachedScanResults(RefRangeStart = 296220, RefRangeEnd = 296431, XrefRangeStart = 296220, XrefRangeEnd = 296431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_target_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num3);
    }
  }

  public unsafe string targetAssemblyTypeName
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 473215, RefRangeEnd = 473218, XrefRangeStart = 473208, XrefRangeEnd = 473215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_targetAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string methodName
  {
    [CallerCount(86), CachedScanResults(RefRangeStart = 331337, RefRangeEnd = 331423, XrefRangeStart = 331337, XrefRangeEnd = 331423, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_methodName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe PersistentListenerMode mode
  {
    [CallerCount(34), CachedScanResults(RefRangeStart = 473218, RefRangeEnd = 473252, XrefRangeStart = 473218, XrefRangeEnd = 473218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_mode_Public_get_PersistentListenerMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PersistentListenerMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Mode = value;
  }

  public unsafe ArgumentCache arguments
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 473252, RefRangeEnd = 473253, XrefRangeStart = 473252, XrefRangeEnd = 473252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_get_arguments_Public_get_ArgumentCache_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArgumentCache) null : Il2CppObjectPool.Get<ArgumentCache>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473253, XrefRangeEnd = 473255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsValid()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473299, RefRangeEnd = 473300, XrefRangeStart = 473255, XrefRangeEnd = 473299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) theEvent)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_GetRuntimeCall_Public_BaseInvokableCall_UnityEventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 473352, RefRangeEnd = 473353, XrefRangeStart = 473300, XrefRangeEnd = 473352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BaseInvokableCall GetObjectCall(
    UnityEngine.Object target,
    MethodInfo method,
    ArgumentCache arguments)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arguments);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_GetObjectCall_Private_Static_BaseInvokableCall_Object_MethodInfo_ArgumentCache_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473353, XrefRangeEnd = 473358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PersistentCall()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentCall>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PersistentCall.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UnityEngine.Object m_Target
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Target));
      return num == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string m_TargetAssemblyTypeName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_TargetAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string m_MethodName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_MethodName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe PersistentListenerMode m_Mode
  {
    get
    {
      return *(PersistentListenerMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Mode));
    }
    [param: In] set
    {
      *(PersistentListenerMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Mode)) = value;
    }
  }

  public unsafe ArgumentCache m_Arguments
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Arguments));
      return num == System.IntPtr.Zero ? (ArgumentCache) null : Il2CppObjectPool.Get<ArgumentCache>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_Arguments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UnityEventCallState m_CallState
  {
    get
    {
      return *(UnityEventCallState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_CallState));
    }
    [param: In] set
    {
      *(UnityEventCallState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PersistentCall.NativeFieldInfoPtr_m_CallState)) = value;
    }
  }

  public UnityEventCallState callState
  {
    get => this.m_CallState;
    set => this.m_CallState = value;
  }

  public void RegisterPersistentListener(UnityEngine.Object ttarget, Il2CppSystem.Type targetType, string mmethodName)
  {
    this.m_Target = ttarget;
    this.m_TargetAssemblyTypeName = UnityEventTools.TidyAssemblyTypeName(targetType.AssemblyQualifiedName);
    this.m_MethodName = mmethodName;
  }

  public void UnregisterPersistentListener()
  {
    this.m_MethodName = Il2CppSystem.String.Empty;
    this.m_Target = (UnityEngine.Object) null;
    this.m_TargetAssemblyTypeName = Il2CppSystem.String.Empty;
  }
}
