// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.OnClientActionRequiredCallbackInfo
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

public class OnClientActionRequiredCallbackInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientData_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientAction_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ActionReasonCode_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ActionReasonDetailsString_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Private_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientAction_Private_set_Void_AntiCheatCommonClientAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ActionReasonCode_Private_set_Void_AntiCheatCommonClientActionReason_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ActionReasonDetailsString_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnClientActionRequiredCallbackInfoInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OnClientActionRequiredCallbackInfo()
  {
    Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (OnClientActionRequiredCallbackInfo));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr);
    OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, "<ClientData>k__BackingField");
    OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, "<ClientHandle>k__BackingField");
    OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, "<ClientAction>k__BackingField");
    OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ActionReasonCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, "<ActionReasonCode>k__BackingField");
    OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ActionReasonDetailsString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, "<ActionReasonDetailsString>k__BackingField");
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672868);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672869);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672870);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ClientHandle_Private_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672871);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672872);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ClientAction_Private_set_Void_AntiCheatCommonClientAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672873);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672874);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ActionReasonCode_Private_set_Void_AntiCheatCommonClientActionReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672875);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672876);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ActionReasonDetailsString_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672877);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672878);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnClientActionRequiredCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672879);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672880);
    OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr, 100672881);
  }

  public virtual unsafe Il2CppSystem.Object ClientData
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ClientData_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ClientData_Private_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe System.IntPtr ClientHandle
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ClientHandle_Private_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientAction ClientAction
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ClientAction_Public_get_AntiCheatCommonClientAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonClientAction*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ClientAction_Private_set_Void_AntiCheatCommonClientAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe AntiCheatCommonClientActionReason ActionReasonCode
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ActionReasonCode_Public_get_AntiCheatCommonClientActionReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonClientActionReason*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ActionReasonCode_Private_set_Void_AntiCheatCommonClientActionReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string ActionReasonDetailsString
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_get_ActionReasonDetailsString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_set_ActionReasonDetailsString_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Nullable<Result> GetResultCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_GetResultCode_Public_Virtual_Final_New_Nullable_1_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new Il2CppSystem.Nullable<Result>(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400747, XrefRangeEnd = 400767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<OnClientActionRequiredCallbackInfoInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_OnClientActionRequiredCallbackInfoInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400767, XrefRangeEnd = 400791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OnClientActionRequiredCallbackInfo()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OnClientActionRequiredCallbackInfo>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OnClientActionRequiredCallbackInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Object _ClientData_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe System.IntPtr _ClientHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientHandle_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonClientAction _ClientAction_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonClientAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientAction_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonClientAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ClientAction_k__BackingField)) = value;
    }
  }

  public unsafe AntiCheatCommonClientActionReason _ActionReasonCode_k__BackingField
  {
    get
    {
      return *(AntiCheatCommonClientActionReason*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ActionReasonCode_k__BackingField));
    }
    [param: In] set
    {
      *(AntiCheatCommonClientActionReason*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ActionReasonCode_k__BackingField)) = value;
    }
  }

  public unsafe string _ActionReasonDetailsString_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ActionReasonDetailsString_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OnClientActionRequiredCallbackInfo.NativeFieldInfoPtr__ActionReasonDetailsString_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
