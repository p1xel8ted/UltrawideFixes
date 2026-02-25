// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventParamPairParamValueInternal
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

[StructLayout(LayoutKind.Explicit)]
public struct LogEventParamPairParamValueInternal
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
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_LogEventParamPairParamValue_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public AntiCheatCommonEventParamType m_ParamValueType;
  [FieldOffset(8)]
  public System.IntPtr m_ClientHandle;
  [FieldOffset(8)]
  public System.IntPtr m_String;
  [FieldOffset(8)]
  public uint m_UInt32;
  [FieldOffset(8)]
  public int m_Int32;
  [FieldOffset(8)]
  public ulong m_UInt64;
  [FieldOffset(8)]
  public long m_Int64;
  [FieldOffset(8)]
  public Vec3fInternal m_Vec3f;
  [FieldOffset(8)]
  public QuatInternal m_Quat;

  static LogEventParamPairParamValueInternal()
  {
    Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventParamPairParamValueInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr);
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_ParamValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_ParamValueType));
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_ClientHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_ClientHandle));
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_String));
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_UInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_UInt32));
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_Int32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_Int32));
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_UInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_UInt64));
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_Int64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_Int64));
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_Vec3f = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_Vec3f));
    LogEventParamPairParamValueInternal.NativeFieldInfoPtr_m_Quat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, nameof (m_Quat));
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672663);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672664);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_String_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672665);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_String_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672666);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672667);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_1_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672668);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Int32_Public_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672669);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672670);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672671);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_1_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672672);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Int64_Public_get_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672673);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672674);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672675);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672676);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Quat_Public_get_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672677);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672678);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Set_Public_Void_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672679);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672680);
    LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, 100672681);
  }

  public unsafe Il2CppSystem.Nullable<System.IntPtr> ClientHandle
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400220, XrefRangeEnd = 400226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_ClientHandle_Public_get_Nullable_1_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<System.IntPtr>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400235, RefRangeEnd = 400236, XrefRangeStart = 400226, XrefRangeEnd = 400235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_ClientHandle_Public_set_Void_Nullable_1_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe string String
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400236, XrefRangeEnd = 400242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_String_Public_get_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400251, RefRangeEnd = 400252, XrefRangeStart = 400242, XrefRangeEnd = 400251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_String_Public_set_Void_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<uint> UInt32
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400252, XrefRangeEnd = 400258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_UInt32_Public_get_Nullable_1_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<uint>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400267, RefRangeEnd = 400268, XrefRangeStart = 400258, XrefRangeEnd = 400267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_UInt32_Public_set_Void_Nullable_1_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<int> Int32
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400268, XrefRangeEnd = 400274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Int32_Public_get_Nullable_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<int>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400283, RefRangeEnd = 400284, XrefRangeStart = 400274, XrefRangeEnd = 400283, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Int32_Public_set_Void_Nullable_1_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<ulong> UInt64
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400284, XrefRangeEnd = 400290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_UInt64_Public_get_Nullable_1_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<ulong>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400299, RefRangeEnd = 400300, XrefRangeStart = 400290, XrefRangeEnd = 400299, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_UInt64_Public_set_Void_Nullable_1_UInt64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Il2CppSystem.Nullable<long> Int64
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400300, XrefRangeEnd = 400306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Int64_Public_get_Nullable_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new Il2CppSystem.Nullable<long>(pointer);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400315, RefRangeEnd = 400316, XrefRangeStart = 400306, XrefRangeEnd = 400315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value))
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Int64_Public_set_Void_Nullable_1_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vec3f Vec3f
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400325, RefRangeEnd = 400326, XrefRangeStart = 400316, XrefRangeEnd = 400325, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Vec3f_Public_get_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Vec3f) null : Il2CppObjectPool.Get<Vec3f>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400335, RefRangeEnd = 400336, XrefRangeStart = 400326, XrefRangeEnd = 400335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Vec3f_Public_set_Void_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Quat Quat
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 400345, RefRangeEnd = 400346, XrefRangeStart = 400336, XrefRangeEnd = 400345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_get_Quat_Public_get_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Quat) null : Il2CppObjectPool.Get<Quat>(num3);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 400355, RefRangeEnd = 400356, XrefRangeStart = 400346, XrefRangeEnd = 400355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_set_Quat_Public_set_Void_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 400412, RefRangeEnd = 400413, XrefRangeStart = 400356, XrefRangeEnd = 400412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Set(LogEventParamPairParamValue other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Set_Public_Void_LogEventParamPairParamValue_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400413, XrefRangeEnd = 400416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400416, XrefRangeEnd = 400430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LogEventParamPairParamValueInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventParamPairParamValueInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
