// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.ArgumentCache
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Events;

[Serializable]
public class ArgumentCache(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectArgument;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_IntArgument;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_FloatArgument;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StringArgument;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_BoolArgument;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_stringArgument_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArgumentCache()
  {
    Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", nameof (ArgumentCache));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr);
    ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, nameof (m_ObjectArgument));
    ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, nameof (m_ObjectArgumentAssemblyTypeName));
    ArgumentCache.NativeFieldInfoPtr_m_IntArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, nameof (m_IntArgument));
    ArgumentCache.NativeFieldInfoPtr_m_FloatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, nameof (m_FloatArgument));
    ArgumentCache.NativeFieldInfoPtr_m_StringArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, nameof (m_StringArgument));
    ArgumentCache.NativeFieldInfoPtr_m_BoolArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, nameof (m_BoolArgument));
    ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669050);
    ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669051);
    ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669052);
    ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669053);
    ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669054);
    ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669055);
    ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669056);
    ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669057);
    ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr, 100669058);
  }

  public unsafe UnityEngine.Object unityObjectArgument
  {
    [CallerCount(211), CachedScanResults(RefRangeStart = 296220, RefRangeEnd = 296431, XrefRangeStart = 296220, XrefRangeEnd = 296431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgument_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num3);
    }
    set
    {
      this.m_ObjectArgument = value;
      this.m_ObjectArgumentAssemblyTypeName = value != (UnityEngine.Object) null ? value.GetType().AssemblyQualifiedName : Il2CppSystem.String.Empty;
    }
  }

  public unsafe string unityObjectArgumentAssemblyTypeName
  {
    [CallerCount(36), CachedScanResults(RefRangeStart = 302758, RefRangeEnd = 302794, XrefRangeStart = 302758, XrefRangeEnd = 302794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_unityObjectArgumentAssemblyTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe int intArgument
  {
    [CallerCount(27), CachedScanResults(RefRangeStart = 327365, RefRangeEnd = 327392, XrefRangeStart = 327365, XrefRangeEnd = 327392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_intArgument_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_IntArgument = value;
  }

  public unsafe float floatArgument
  {
    [CallerCount(10), CachedScanResults(RefRangeStart = 472992, RefRangeEnd = 473002, XrefRangeStart = 472992, XrefRangeEnd = 472992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_floatArgument_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_FloatArgument = value;
  }

  public unsafe string stringArgument
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 303186, RefRangeEnd = 303188, XrefRangeStart = 303186, XrefRangeEnd = 303188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_stringArgument_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    set => this.m_StringArgument = value;
  }

  public unsafe bool boolArgument
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 331138, RefRangeEnd = 331142, XrefRangeStart = 331138, XrefRangeEnd = 331142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_get_boolArgument_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_BoolArgument = value;
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 473002, XrefRangeEnd = 473003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnBeforeSerialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void OnAfterDeserialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArgumentCache()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentCache>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArgumentCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UnityEngine.Object m_ObjectArgument
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument));
      return num == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgument), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string m_ObjectArgumentAssemblyTypeName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_ObjectArgumentAssemblyTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe int m_IntArgument
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_IntArgument)) = value;
    }
  }

  public unsafe float m_FloatArgument
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_FloatArgument)) = value;
    }
  }

  public unsafe string m_StringArgument
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_StringArgument), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool m_BoolArgument
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArgumentCache.NativeFieldInfoPtr_m_BoolArgument)) = value;
    }
  }
}
