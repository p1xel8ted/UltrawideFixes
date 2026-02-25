// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyRef
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyRef(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_referencingMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_lowId;
  private static readonly System.IntPtr NativeFieldInfoPtr_highId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_HasReference_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetObject_Public_TObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ArticyObject_ArticyRef_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ArticyRef_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyRef()
  {
    Il2CppClassPointerStore<ArticyRef>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyRef));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr);
    ArticyRef.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, nameof (id));
    ArticyRef.NativeFieldInfoPtr_instanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, nameof (instanceId));
    ArticyRef.NativeFieldInfoPtr_referencingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, nameof (referencingMode));
    ArticyRef.NativeFieldInfoPtr_lowId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, nameof (lowId));
    ArticyRef.NativeFieldInfoPtr_highId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, nameof (highId));
    ArticyRef.NativeMethodInfoPtr_get_HasReference_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, 100663657);
    ArticyRef.NativeMethodInfoPtr_GetObject_Public_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, 100663658);
    ArticyRef.NativeMethodInfoPtr_GetObject_Public_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, 100663659);
    ArticyRef.NativeMethodInfoPtr_op_Explicit_Public_Static_ArticyObject_ArticyRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, 100663660);
    ArticyRef.NativeMethodInfoPtr_op_Explicit_Public_Static_ArticyRef_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, 100663661);
    ArticyRef.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, 100663662);
    ArticyRef.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, 100663663);
    ArticyRef.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr, 100663664 /*0x06000170*/);
  }

  public unsafe bool HasReference
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 250516, RefRangeEnd = 250528, XrefRangeStart = 250516, XrefRangeEnd = 250528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRef.NativeMethodInfoPtr_get_HasReference_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 989461, RefRangeEnd = 989474, XrefRangeStart = 989446, XrefRangeEnd = 989461, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyObject GetObject()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRef.NativeMethodInfoPtr_GetObject_Public_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(31 /*0x1F*/)]
  [CachedScanResults(RefRangeStart = 989478, RefRangeEnd = 989509, XrefRangeStart = 989474, XrefRangeEnd = 989478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TObject GetObject<TObject>() where TObject : ArticyObject
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRef.MethodInfoStoreGeneric_GetObject_Public_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TObject>(num2, false, true);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 989513, RefRangeEnd = 989514, XrefRangeStart = 989509, XrefRangeEnd = 989513, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe explicit operator ArticyObject(ArticyRef aRef)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aRef)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRef.NativeMethodInfoPtr_op_Explicit_Public_Static_ArticyObject_ArticyRef_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 989519, RefRangeEnd = 989532, XrefRangeStart = 989514, XrefRangeEnd = 989519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe explicit operator ArticyRef(ArticyObject aObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyRef.NativeMethodInfoPtr_op_Explicit_Public_Static_ArticyRef_ArticyObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRef.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRef.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyRef()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyRef>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyRef.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong id
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_id)) = value;
    }
  }

  public unsafe uint instanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_instanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_instanceId)) = value;
    }
  }

  public unsafe ArticyRefModes referencingMode
  {
    get
    {
      return *(ArticyRefModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_referencingMode));
    }
    [param: In] set
    {
      *(ArticyRefModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_referencingMode)) = value;
    }
  }

  public unsafe uint lowId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_lowId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_lowId)) = value;
    }
  }

  public unsafe uint highId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_highId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyRef.NativeFieldInfoPtr_highId)) = value;
    }
  }

  private sealed class MethodInfoStoreGeneric_GetObject_Public_TObject_0<TObject>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(ArticyRef.NativeMethodInfoPtr_GetObject_Public_TObject_0, Il2CppClassPointerStore<ArticyRef>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr))
    }))));
  }
}
