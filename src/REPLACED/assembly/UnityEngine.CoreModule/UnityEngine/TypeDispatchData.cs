// Decompiled with JetBrains decompiler
// Type: UnityEngine.TypeDispatchData
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine;

public sealed class TypeDispatchData : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_changed;
  private static readonly System.IntPtr NativeFieldInfoPtr_changedID;
  private static readonly System.IntPtr NativeFieldInfoPtr_destroyedID;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

  static TypeDispatchData()
  {
    Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (TypeDispatchData));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr);
    TypeDispatchData.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, nameof (changed));
    TypeDispatchData.NativeFieldInfoPtr_changedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, nameof (changedID));
    TypeDispatchData.NativeFieldInfoPtr_destroyedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, nameof (destroyedID));
    TypeDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, 100667667);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441361, XrefRangeEnd = 441366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TypeDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public TypeDispatchData(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public TypeDispatchData()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr))
  {
  }

  public unsafe Il2CppReferenceArray<Object> changed
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changed));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public NativeArray<int> changedID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changedID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<int> destroyedID
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_destroyedID);
      return new NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_destroyedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
