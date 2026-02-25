// Decompiled with JetBrains decompiler
// Type: UnityEngine.WaitUntil
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class WaitUntil(System.IntPtr pointer) : CustomYieldInstruction(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Predicate;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeoutCallback;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_TimeoutMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxExecutionTime;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTime_Private_Double_0;

  static WaitUntil()
  {
    Il2CppClassPointerStore<WaitUntil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (WaitUntil));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr);
    WaitUntil.NativeFieldInfoPtr_m_Predicate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, nameof (m_Predicate));
    WaitUntil.NativeFieldInfoPtr_m_TimeoutCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, nameof (m_TimeoutCallback));
    WaitUntil.NativeFieldInfoPtr_m_TimeoutMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, nameof (m_TimeoutMode));
    WaitUntil.NativeFieldInfoPtr_m_MaxExecutionTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, nameof (m_MaxExecutionTime));
    WaitUntil.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100668448);
    WaitUntil.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100668449);
    WaitUntil.NativeMethodInfoPtr_GetTime_Private_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr, 100668450);
  }

  public override unsafe bool keepWaiting
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464487, XrefRangeEnd = 464493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464493, XrefRangeEnd = 464494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WaitUntil(Il2CppSystem.Func<bool> predicate)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitUntil>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) predicate)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr__ctor_Public_Void_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464494, XrefRangeEnd = 464496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe double GetTime()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WaitUntil.NativeMethodInfoPtr_GetTime_Private_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe Il2CppSystem.Func<bool> m_Predicate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_Predicate));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Func<bool>) null : Il2CppObjectPool.Get<Il2CppSystem.Func<bool>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_Predicate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action m_TimeoutCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_TimeoutCallback));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_TimeoutCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe WaitTimeoutMode m_TimeoutMode
  {
    get
    {
      return *(WaitTimeoutMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_TimeoutMode));
    }
    [param: In] set
    {
      *(WaitTimeoutMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_TimeoutMode)) = value;
    }
  }

  public unsafe double m_MaxExecutionTime
  {
    get
    {
      return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_MaxExecutionTime));
    }
    [param: In] set
    {
      *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitUntil.NativeFieldInfoPtr_m_MaxExecutionTime)) = value;
    }
  }
}
