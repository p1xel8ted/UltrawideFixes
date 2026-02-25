// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventOptions
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

public class LogEventOptions(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ClientHandle_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__EventId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Params_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_LogEventParamPair_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LogEventOptions()
  {
    Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventOptions));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr);
    LogEventOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, "<ClientHandle>k__BackingField");
    LogEventOptions.NativeFieldInfoPtr__EventId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, "<EventId>k__BackingField");
    LogEventOptions.NativeFieldInfoPtr__Params_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, "<Params>k__BackingField");
    LogEventOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, 100672611);
    LogEventOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, 100672612);
    LogEventOptions.NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, 100672613);
    LogEventOptions.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, 100672614);
    LogEventOptions.NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_LogEventParamPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, 100672615);
    LogEventOptions.NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, 100672616);
    LogEventOptions.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr, 100672617);
  }

  public unsafe System.IntPtr ClientHandle
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventOptions.NativeMethodInfoPtr_get_ClientHandle_Public_get_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptions.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint EventId
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventOptions.NativeMethodInfoPtr_get_EventId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptions.NativeMethodInfoPtr_set_EventId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppReferenceArray<LogEventParamPair> Params
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventOptions.NativeMethodInfoPtr_get_Params_Public_get_Il2CppReferenceArray_1_LogEventParamPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<LogEventParamPair>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<LogEventParamPair>>(num3);
    }
    [CallerCount(9), CachedScanResults(RefRangeStart = 69181, RefRangeEnd = 69190, XrefRangeStart = 69181, XrefRangeEnd = 69190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventOptions.NativeMethodInfoPtr_set_Params_Public_set_Void_Il2CppReferenceArray_1_LogEventParamPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LogEventOptions()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogEventOptions>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventOptions.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr _ClientHandle_k__BackingField
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventOptions.NativeFieldInfoPtr__ClientHandle_k__BackingField)) = value;
    }
  }

  public unsafe uint _EventId_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventOptions.NativeFieldInfoPtr__EventId_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventOptions.NativeFieldInfoPtr__EventId_k__BackingField)) = value;
    }
  }

  public unsafe Il2CppReferenceArray<LogEventParamPair> _Params_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventOptions.NativeFieldInfoPtr__Params_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<LogEventParamPair>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<LogEventParamPair>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogEventOptions.NativeFieldInfoPtr__Params_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
