// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.UnityEvent
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

[Serializable]
public class UnityEvent(System.IntPtr pointer) : UnityEventBase(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_InvokeArray;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

  static UnityEvent()
  {
    Il2CppClassPointerStore<UnityEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", nameof (UnityEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr);
    UnityEvent.NativeFieldInfoPtr_m_InvokeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, nameof (m_InvokeArray));
    UnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100669140);
    UnityEvent.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100669141);
    UnityEvent.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100669142);
    UnityEvent.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100669143);
    UnityEvent.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100669144);
    UnityEvent.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100669145);
    UnityEvent.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr, 100669146);
  }

  [CallerCount(25)]
  [CachedScanResults(RefRangeStart = 473740, RefRangeEnd = 473765, XrefRangeStart = 473711, XrefRangeEnd = 473740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityEvent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(54)]
  [CachedScanResults(RefRangeStart = 473774, RefRangeEnd = 473828, XrefRangeStart = 473765, XrefRangeEnd = 473774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddListener(UnityAction call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 473831, RefRangeEnd = 473853, XrefRangeStart = 473828, XrefRangeEnd = 473831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveListener(UnityAction call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr_RemoveListener_Public_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473853, XrefRangeEnd = 473857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe MethodInfo FindMethod_Impl(string name, Il2CppSystem.Type targetObjType)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetObjType);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEvent.NativeMethodInfoPtr_FindMethod_Impl_Protected_Virtual_MethodInfo_String_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (MethodInfo) null : Il2CppObjectPool.Get<MethodInfo>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473857, XrefRangeEnd = 473861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe BaseInvokableCall GetDelegate(Il2CppSystem.Object target, MethodInfo theFunction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) theFunction);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnityEvent.NativeMethodInfoPtr_GetDelegate_Internal_Virtual_BaseInvokableCall_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473861, XrefRangeEnd = 473866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe BaseInvokableCall GetDelegate(UnityAction action)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr_GetDelegate_Private_Static_BaseInvokableCall_UnityAction_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (BaseInvokableCall) null : Il2CppObjectPool.Get<BaseInvokableCall>(num3);
  }

  [CallerCount(81)]
  [CachedScanResults(RefRangeStart = 473893, RefRangeEnd = 473974, XrefRangeStart = 473866, XrefRangeEnd = 473893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invoke()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityEvent.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> m_InvokeArray
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityEvent.NativeFieldInfoPtr_m_InvokeArray));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityEvent.NativeFieldInfoPtr_m_InvokeArray), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
