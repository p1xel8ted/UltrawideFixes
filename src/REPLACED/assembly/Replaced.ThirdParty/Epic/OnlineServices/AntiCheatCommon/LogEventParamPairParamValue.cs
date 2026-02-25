// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventParamPairParamValue
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

public class LogEventParamPairParamValue(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamValueType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientHandle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_String;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UInt32;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Int32;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UInt64;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Int64;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Vec3f;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Quat;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamValueType_Public_get_AntiCheatCommonEventParamType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamValueType_Private_set_Void_AntiCheatCommonEventParamType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_1_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_1_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_String_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_String_Public_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_1_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_1_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Int32_Public_get_Nullable_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_1_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_1_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_1_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Int64_Public_get_Nullable_1_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_1_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Quat_Public_get_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LogEventParamPairParamValueInternal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LogEventParamPairParamValue()
  {
    Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventParamPairParamValue));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr);
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_ParamValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_ParamValueType));
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_ClientHandle));
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_String));
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_UInt32));
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_Int32));
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_UInt64));
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_Int64));
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_Vec3f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_Vec3f));
    LogEventParamPairParamValue.NativeFieldInfoPtr_m_Quat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, nameof (m_Quat));
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_ParamValueType_Public_get_AntiCheatCommonEventParamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672634);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_ParamValueType_Private_set_Void_AntiCheatCommonEventParamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672635);
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672636);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672637);
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_String_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672638);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_String_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672639);
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672640);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672641);
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_Int32_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672642);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672643);
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672644);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672645);
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_Int64_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672646);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672647);
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672648);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672649);
    LogEventParamPairParamValue.NativeMethodInfoPtr_get_Quat_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672650);
    LogEventParamPairParamValue.NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672651);
    LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672652);
    LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672653);
    LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672654);
    LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672655);
    LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672656);
    LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672657);
    LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672658);
    LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672659);
    LogEventParamPairParamValue.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LogEventParamPairParamValueInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672660);
    LogEventParamPairParamValue.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672661);
    LogEventParamPairParamValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, 100672662);
  }

  public unsafe AntiCheatCommonEventParamType ParamValueType
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_ParamValueType_Public_get_AntiCheatCommonEventParamType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AntiCheatCommonEventParamType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64574, RefRangeEnd = 64580, XrefRangeStart = 64574, XrefRangeEnd = 64580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_ParamValueType_Private_set_Void_AntiCheatCommonEventParamType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<System.IntPtr> ClientHandle
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399959, XrefRangeEnd = 399965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_1_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<System.IntPtr>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399965, XrefRangeEnd = 399971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_1_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string String
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399971, XrefRangeEnd = 399977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_String_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 399983, RefRangeEnd = 399985, XrefRangeStart = 399977, XrefRangeEnd = 399983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_String_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<uint> UInt32
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399985, XrefRangeEnd = 399991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<uint>(pointer);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 399997, RefRangeEnd = 399999, XrefRangeStart = 399991, XrefRangeEnd = 399997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_1_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<int> Int32
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399999, XrefRangeEnd = 400005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_Int32_Public_get_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<int>(pointer);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 400011, RefRangeEnd = 400013, XrefRangeStart = 400005, XrefRangeEnd = 400011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<ulong> UInt64
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400013, XrefRangeEnd = 400019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<ulong>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400019, XrefRangeEnd = 400025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_1_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<long> Int64
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400025, XrefRangeEnd = 400031, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_Int64_Public_get_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<long>(pointer);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400031, XrefRangeEnd = 400037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f Vec3f
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400037, XrefRangeEnd = 400043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 400049, RefRangeEnd = 400051, XrefRangeStart = 400043, XrefRangeEnd = 400049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat Quat
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400051, XrefRangeEnd = 400057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_get_Quat_Public_get_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num3);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 400063, RefRangeEnd = 400065, XrefRangeStart = 400057, XrefRangeEnd = 400063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400065, XrefRangeEnd = 400078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LogEventParamPairParamValue(System.IntPtr value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400078, XrefRangeEnd = 400083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LogEventParamPairParamValue(string value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400083, XrefRangeEnd = 400091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LogEventParamPairParamValue(uint value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400091, XrefRangeEnd = 400099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LogEventParamPairParamValue(int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400099, XrefRangeEnd = 400112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LogEventParamPairParamValue(ulong value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400112, XrefRangeEnd = 400125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LogEventParamPairParamValue(long value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400125, XrefRangeEnd = 400130, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LogEventParamPairParamValue(Vec3f value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Vec3f_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400130, XrefRangeEnd = 400135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator LogEventParamPairParamValue(Quat value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_op_Implicit_Public_Static_LogEventParamPairParamValue_Quat_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (LogEventParamPairParamValue) null : Il2CppObjectPool.Get<LogEventParamPairParamValue>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 400214, RefRangeEnd = 400215, XrefRangeStart = 400135, XrefRangeEnd = 400214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(
    Il2CppSystem.Nullable<LogEventParamPairParamValueInternal> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_Set_Internal_Void_Nullable_1_LogEventParamPairParamValueInternal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400215, XrefRangeEnd = 400220, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LogEventParamPairParamValue()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AntiCheatCommonEventParamType m_ParamValueType
  {
    get
    {
      return *(AntiCheatCommonEventParamType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_ParamValueType));
    }
    [param: In] set
    {
      *(AntiCheatCommonEventParamType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_ParamValueType)) = value;
    }
  }

  public Il2CppSystem.Nullable<System.IntPtr> m_ClientHandle
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_ClientHandle);
      return new Il2CppSystem.Nullable<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<System.IntPtr>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_ClientHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<System.IntPtr>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe string m_String
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_String)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_String), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public Il2CppSystem.Nullable<uint> m_UInt32
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt32);
      return new Il2CppSystem.Nullable<uint>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<uint>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt32), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<uint>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<int> m_Int32
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int32);
      return new Il2CppSystem.Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int32), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<ulong> m_UInt64
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt64);
      return new Il2CppSystem.Nullable<ulong>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_UInt64), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<ulong>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.Nullable<long> m_Int64
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int64);
      return new Il2CppSystem.Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<long>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Int64), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<long>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe Vec3f m_Vec3f
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Vec3f));
      return num == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Vec3f), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Quat m_Quat
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Quat));
      return num == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPairParamValue.NativeFieldInfoPtr_m_Quat), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
