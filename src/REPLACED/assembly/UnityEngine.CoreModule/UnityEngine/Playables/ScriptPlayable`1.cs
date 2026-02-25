// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.ScriptPlayable`1
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Playables;

public sealed class ScriptPlayable<T> : Il2CppSystem.ValueType where T : class, new()
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NullPlayable;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetBehaviour_Public_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_ScriptPlayable_1_T_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0;

  static ScriptPlayable()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "ScriptPlayable`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr);
    ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, nameof (m_Handle));
    ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, nameof (m_NullPlayable));
    ScriptPlayable<T>.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669551);
    ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669552);
    ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669553);
    ScriptPlayable<T>.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669554);
    ScriptPlayable<T>.NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669555);
    ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669556);
    ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669557);
    ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669558);
    ScriptPlayable<T>.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669559);
    ScriptPlayable<T>.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669560);
    ScriptPlayable<T>.NativeMethodInfoPtr_GetBehaviour_Public_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669561);
    ScriptPlayable<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669562);
    ScriptPlayable<T>.NativeMethodInfoPtr_op_Explicit_Public_Static_ScriptPlayable_1_T_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669563);
    ScriptPlayable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, 100669564);
  }

  public static unsafe ScriptPlayable<T> Null
  {
    [CallerCount(8), CachedScanResults(RefRangeStart = 481114, RefRangeEnd = 481122, XrefRangeStart = 481109, XrefRangeEnd = 481114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayable_1_T_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
      return new ScriptPlayable<T>(pointer);
    }
  }

  [CallerCount(22)]
  [CachedScanResults(RefRangeStart = 481129, RefRangeEnd = 481151, XrefRangeStart = 481122, XrefRangeEnd = 481129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScriptPlayable<T> Create(PlayableGraph graph, int inputCount = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &graph;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputCount;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new ScriptPlayable<T>(pointer);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 481158, RefRangeEnd = 481171, XrefRangeStart = 481151, XrefRangeEnd = 481158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScriptPlayable<T> Create(PlayableGraph graph, T template, int inputCount = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &graph;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) template;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref template;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inputCount;
    System.IntPtr num2;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayable_1_T_PlayableGraph_T_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return new ScriptPlayable<T>(pointer);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481206, RefRangeEnd = 481208, XrefRangeStart = 481171, XrefRangeEnd = 481206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayableHandle CreateHandle(PlayableGraph graph, T template, int inputCount)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &graph;
    System.IntPtr num1 = (System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
    // ISSUE: variable of a reference type
    T& local1;
    if (!typeof (T).IsValueType)
    {
      // ISSUE: variable of a boxed type
      __Boxed<T> local2 = (object) template;
      // ISSUE: cast to a reference type
      // ISSUE: cast to a reference type
      local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
    }
    else
      local1 = ref template;
    *(System.IntPtr*) num1 = (System.IntPtr) ref local1;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &inputCount;
    System.IntPtr num2;
    System.IntPtr num3 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CreateHandle_Private_Static_PlayableHandle_PlayableGraph_T_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num2);
    Il2CppException.RaiseExceptionIfNecessary(num2);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481225, RefRangeEnd = 481226, XrefRangeStart = 481208, XrefRangeEnd = 481225, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Object CreateScriptInstance()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CreateScriptInstance_Private_Static_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481241, RefRangeEnd = 481242, XrefRangeStart = 481226, XrefRangeEnd = 481241, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Object CloneScriptInstance(IPlayableBehaviour source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstance_Private_Static_Object_IPlayableBehaviour_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481242, XrefRangeEnd = 481249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Object CloneScriptInstanceFromEngineObject(UnityEngine.Object source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromEngineObject_Private_Static_Object_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481249, XrefRangeEnd = 481253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Il2CppSystem.Object CloneScriptInstanceFromIClonable(Il2CppSystem.ICloneable source)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) source)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_CloneScriptInstanceFromIClonable_Private_Static_Object_ICloneable_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 481264, RefRangeEnd = 481267, XrefRangeStart = 481253, XrefRangeEnd = 481264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptPlayable(PlayableHandle handle)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(49)]
  [CachedScanResults(RefRangeStart = 480002, RefRangeEnd = 480051, XrefRangeStart = 480002, XrefRangeEnd = 480051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PlayableHandle GetHandle()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(29)]
  [CachedScanResults(RefRangeStart = 481272, RefRangeEnd = 481301, XrefRangeStart = 481267, XrefRangeEnd = 481272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe T GetBehaviour()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_GetBehaviour_Public_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
  }

  [CallerCount(34)]
  [CachedScanResults(RefRangeStart = 481306, RefRangeEnd = 481340, XrefRangeStart = 481301, XrefRangeEnd = 481306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator Playable(ScriptPlayable<T> playable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) playable))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_op_Implicit_Public_Static_Playable_ScriptPlayable_1_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(10)]
  [CachedScanResults(RefRangeStart = 481346, RefRangeEnd = 481356, XrefRangeStart = 481340, XrefRangeEnd = 481346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe explicit operator ScriptPlayable<T>(Playable playable)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_op_Explicit_Public_Static_ScriptPlayable_1_T_Playable_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new ScriptPlayable<T>(pointer);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 481365, RefRangeEnd = 481366, XrefRangeStart = 481356, XrefRangeEnd = 481365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(ScriptPlayable<T> other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other))
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayable<T>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ScriptPlayable_1_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public ScriptPlayable(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ScriptPlayable()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr))
  {
  }

  public unsafe PlayableHandle m_Handle
  {
    get
    {
      return *(PlayableHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle));
    }
    [param: In] set
    {
      *(PlayableHandle*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptPlayable<T>.NativeFieldInfoPtr_m_Handle)) = value;
    }
  }

  public static unsafe ScriptPlayable<T> m_NullPlayable
  {
    get
    {
      System.IntPtr num = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      IL2CPP.il2cpp_field_static_get_value(ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable, (void*) num);
      return new ScriptPlayable<T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayable<T>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScriptPlayable<T>.NativeFieldInfoPtr_m_NullPlayable, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
    }
  }
}
