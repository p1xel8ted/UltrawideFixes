// Decompiled with JetBrains decompiler
// Type: Unity.Jobs.LowLevel.Unsafe.JobProducerTypeAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Jobs.LowLevel.Unsafe;

public sealed class JobProducerTypeAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ProducerType_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

  static JobProducerTypeAttribute()
  {
    Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Jobs.LowLevel.Unsafe", nameof (JobProducerTypeAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr);
    JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr, "<ProducerType>k__BackingField");
    JobProducerTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr, 100663330 /*0x06000022*/);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 255058, RefRangeEnd = 255093, XrefRangeStart = 255058, XrefRangeEnd = 255093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe JobProducerTypeAttribute(Il2CppSystem.Type producerType)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JobProducerTypeAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) producerType)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(JobProducerTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Type _ProducerType_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JobProducerTypeAttribute.NativeFieldInfoPtr__ProducerType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public Il2CppSystem.Type ProducerType => this._ProducerType_k__BackingField;
}
