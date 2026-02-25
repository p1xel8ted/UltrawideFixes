// Decompiled with JetBrains decompiler
// Type: UnitySerializedReferenceDictionary`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
public class UnitySerializedReferenceDictionary<TKey, TValue>(System.IntPtr pointer) : 
  Dictionary<TKey, TValue>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_keyData;
  private static readonly System.IntPtr NativeFieldInfoPtr_valueData;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FromDictionary_Public_Void_Dictionary_2_TKey_TValue_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static UnitySerializedReferenceDictionary()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnitySerializedReferenceDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[2]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr);
    UnitySerializedReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr_keyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr, nameof (keyData));
    UnitySerializedReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr_valueData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr, nameof (valueData));
    UnitySerializedReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100663757);
    UnitySerializedReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100663758);
    UnitySerializedReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_FromDictionary_Public_Void_Dictionary_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100663759);
    UnitySerializedReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr, 100663760 /*0x060001D0*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22677, XrefRangeEnd = 22682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySerializedReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22682, XrefRangeEnd = 22694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySerializedReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22694, XrefRangeEnd = 22705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FromDictionary(Dictionary<TKey, TValue> dict)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dict)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySerializedReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr_FromDictionary_Public_Void_Dictionary_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22716, RefRangeEnd = 22717, XrefRangeStart = 22705, XrefRangeEnd = 22716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnitySerializedReferenceDictionary()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySerializedReferenceDictionary<TKey, TValue>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySerializedReferenceDictionary<TKey, TValue>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe List<TKey> keyData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySerializedReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr_keyData));
      return num == System.IntPtr.Zero ? (List<TKey>) null : Il2CppObjectPool.Get<List<TKey>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySerializedReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr_keyData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<TValue> valueData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySerializedReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr_valueData));
      return num == System.IntPtr.Zero ? (List<TValue>) null : Il2CppObjectPool.Get<List<TValue>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySerializedReferenceDictionary<TKey, TValue>.NativeFieldInfoPtr_valueData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
