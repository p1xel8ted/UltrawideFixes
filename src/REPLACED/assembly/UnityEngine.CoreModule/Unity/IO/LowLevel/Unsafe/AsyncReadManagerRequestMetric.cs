// Decompiled with JetBrains decompiler
// Type: Unity.IO.LowLevel.Unsafe.AsyncReadManagerRequestMetric
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.IO.LowLevel.Unsafe;

public sealed class AsyncReadManagerRequestMetric : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr__AssetName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__FileName_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__OffsetBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__SizeBytes_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__AssetTypeId_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__CurrentBytesRead_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__BatchReadCount_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__IsBatchRead_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__State_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ReadType_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__PriorityLevel_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__Subsystem_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField;

  static AsyncReadManagerRequestMetric()
  {
    Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.IO.LowLevel.Unsafe", nameof (AsyncReadManagerRequestMetric));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr);
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetName>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<FileName>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<OffsetBytes>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<SizeBytes>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<AssetTypeId>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<CurrentBytesRead>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<BatchReadCount>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<IsBatchRead>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<State>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<ReadType>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<PriorityLevel>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<Subsystem>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<RequestTimeMicroseconds>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TimeInQueueMicroseconds>k__BackingField");
    AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr, "<TotalTimeMicroseconds>k__BackingField");
  }

  public AsyncReadManagerRequestMetric(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public AsyncReadManagerRequestMetric()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncReadManagerRequestMetric>.NativeClassPtr))
  {
  }

  public unsafe string _AssetName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string _FileName_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__FileName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ulong _OffsetBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__OffsetBytes_k__BackingField)) = value;
    }
  }

  public unsafe ulong _SizeBytes_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__SizeBytes_k__BackingField)) = value;
    }
  }

  public unsafe ulong _AssetTypeId_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__AssetTypeId_k__BackingField)) = value;
    }
  }

  public unsafe ulong _CurrentBytesRead_k__BackingField
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__CurrentBytesRead_k__BackingField)) = value;
    }
  }

  public unsafe uint _BatchReadCount_k__BackingField
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__BatchReadCount_k__BackingField)) = value;
    }
  }

  public unsafe bool _IsBatchRead_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__IsBatchRead_k__BackingField)) = value;
    }
  }

  public unsafe ProcessingState _State_k__BackingField
  {
    get
    {
      return *(ProcessingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField));
    }
    [param: In] set
    {
      *(ProcessingState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__State_k__BackingField)) = value;
    }
  }

  public unsafe FileReadType _ReadType_k__BackingField
  {
    get
    {
      return *(FileReadType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField));
    }
    [param: In] set
    {
      *(FileReadType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__ReadType_k__BackingField)) = value;
    }
  }

  public unsafe Priority _PriorityLevel_k__BackingField
  {
    get
    {
      return *(Priority*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField));
    }
    [param: In] set
    {
      *(Priority*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__PriorityLevel_k__BackingField)) = value;
    }
  }

  public unsafe AssetLoadingSubsystem _Subsystem_k__BackingField
  {
    get
    {
      return *(AssetLoadingSubsystem*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField));
    }
    [param: In] set
    {
      *(AssetLoadingSubsystem*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__Subsystem_k__BackingField)) = value;
    }
  }

  public unsafe double _RequestTimeMicroseconds_k__BackingField
  {
    get
    {
      return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField));
    }
    [param: In] set
    {
      *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__RequestTimeMicroseconds_k__BackingField)) = value;
    }
  }

  public unsafe double _TimeInQueueMicroseconds_k__BackingField
  {
    get
    {
      return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField));
    }
    [param: In] set
    {
      *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TimeInQueueMicroseconds_k__BackingField)) = value;
    }
  }

  public unsafe double _TotalTimeMicroseconds_k__BackingField
  {
    get
    {
      return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField));
    }
    [param: In] set
    {
      *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AsyncReadManagerRequestMetric.NativeFieldInfoPtr__TotalTimeMicroseconds_k__BackingField)) = value;
    }
  }

  public string AssetName => this._AssetName_k__BackingField;

  public string FileName => this._FileName_k__BackingField;

  public ulong OffsetBytes => this._OffsetBytes_k__BackingField;

  public ulong SizeBytes => this._SizeBytes_k__BackingField;

  public ulong AssetTypeId => this._AssetTypeId_k__BackingField;

  public ulong CurrentBytesRead => this._CurrentBytesRead_k__BackingField;

  public uint BatchReadCount => this._BatchReadCount_k__BackingField;

  public bool IsBatchRead => this._IsBatchRead_k__BackingField;

  public ProcessingState State => this._State_k__BackingField;

  public FileReadType ReadType => this._ReadType_k__BackingField;

  public Priority PriorityLevel => this._PriorityLevel_k__BackingField;

  public AssetLoadingSubsystem Subsystem => this._Subsystem_k__BackingField;

  public double RequestTimeMicroseconds => this._RequestTimeMicroseconds_k__BackingField;

  public double TimeInQueueMicroseconds => this._TimeInQueueMicroseconds_k__BackingField;

  public double TotalTimeMicroseconds => this._TotalTimeMicroseconds_k__BackingField;
}
