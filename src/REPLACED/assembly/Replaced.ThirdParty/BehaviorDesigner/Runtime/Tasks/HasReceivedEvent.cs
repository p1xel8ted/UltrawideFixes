// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.HasReceivedEvent
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace BehaviorDesigner.Runtime.Tasks;

public class HasReceivedEvent(System.IntPtr pointer) : Conditional(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_eventName;
  private static readonly System.IntPtr NativeFieldInfoPtr_storedValue1;
  private static readonly System.IntPtr NativeFieldInfoPtr_storedValue2;
  private static readonly System.IntPtr NativeFieldInfoPtr_storedValue3;
  private static readonly System.IntPtr NativeFieldInfoPtr_eventReceived;
  private static readonly System.IntPtr NativeFieldInfoPtr_registered;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceivedEvent_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBehaviorComplete_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static HasReceivedEvent()
  {
    Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks", nameof (HasReceivedEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr);
    HasReceivedEvent.NativeFieldInfoPtr_eventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, nameof (eventName));
    HasReceivedEvent.NativeFieldInfoPtr_storedValue1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, nameof (storedValue1));
    HasReceivedEvent.NativeFieldInfoPtr_storedValue2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, nameof (storedValue2));
    HasReceivedEvent.NativeFieldInfoPtr_storedValue3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, nameof (storedValue3));
    HasReceivedEvent.NativeFieldInfoPtr_eventReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, nameof (eventReceived));
    HasReceivedEvent.NativeFieldInfoPtr_registered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, nameof (registered));
    HasReceivedEvent.NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673880);
    HasReceivedEvent.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673881);
    HasReceivedEvent.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673882);
    HasReceivedEvent.NativeMethodInfoPtr_ReceivedEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673883);
    HasReceivedEvent.NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673884);
    HasReceivedEvent.NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673885);
    HasReceivedEvent.NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673886);
    HasReceivedEvent.NativeMethodInfoPtr_OnBehaviorComplete_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673887);
    HasReceivedEvent.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673888);
    HasReceivedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr, 100673889);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404748, XrefRangeEnd = 404791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnStart()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HasReceivedEvent.NativeMethodInfoPtr_OnStart_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe TaskStatus OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HasReceivedEvent.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404791, XrefRangeEnd = 404834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnEnd()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HasReceivedEvent.NativeMethodInfoPtr_OnEnd_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ReceivedEvent()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HasReceivedEvent.NativeMethodInfoPtr_ReceivedEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404834, XrefRangeEnd = 404835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReceivedEvent(Il2CppSystem.Object arg1)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arg1)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HasReceivedEvent.NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404835, XrefRangeEnd = 404837, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReceivedEvent(Il2CppSystem.Object arg1, Il2CppSystem.Object arg2)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arg1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arg2);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HasReceivedEvent.NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404837, XrefRangeEnd = 404840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReceivedEvent(Il2CppSystem.Object arg1, Il2CppSystem.Object arg2, Il2CppSystem.Object arg3)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arg1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arg2);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arg3);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HasReceivedEvent.NativeMethodInfoPtr_ReceivedEvent_Private_Void_Object_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404840, XrefRangeEnd = 404883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnBehaviorComplete()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HasReceivedEvent.NativeMethodInfoPtr_OnBehaviorComplete_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404883, XrefRangeEnd = 404886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnReset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HasReceivedEvent.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 404886, XrefRangeEnd = 404890, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe HasReceivedEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasReceivedEvent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(HasReceivedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SharedString eventName
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_eventName));
      return num == System.IntPtr.Zero ? (SharedString) null : Il2CppObjectPool.Get<SharedString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_eventName), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SharedVariable storedValue1
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_storedValue1));
      return num == System.IntPtr.Zero ? (SharedVariable) null : Il2CppObjectPool.Get<SharedVariable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_storedValue1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SharedVariable storedValue2
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_storedValue2));
      return num == System.IntPtr.Zero ? (SharedVariable) null : Il2CppObjectPool.Get<SharedVariable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_storedValue2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SharedVariable storedValue3
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_storedValue3));
      return num == System.IntPtr.Zero ? (SharedVariable) null : Il2CppObjectPool.Get<SharedVariable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_storedValue3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool eventReceived
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_eventReceived));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_eventReceived)) = value;
    }
  }

  public unsafe bool registered
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_registered));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HasReceivedEvent.NativeFieldInfoPtr_registered)) = value;
    }
  }
}
