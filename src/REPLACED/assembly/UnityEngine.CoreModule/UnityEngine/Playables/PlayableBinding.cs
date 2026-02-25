// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableBinding
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

public sealed class PlayableBinding : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StreamName;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceObject;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SourceBindingType;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CreateOutputMethod;
  private static readonly System.IntPtr NativeFieldInfoPtr_None;
  private static readonly System.IntPtr NativeFieldInfoPtr_DefaultDuration;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_streamName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_outputTargetType_Public_get_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0;

  static PlayableBinding()
  {
    Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (PlayableBinding));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr);
    PlayableBinding.NativeFieldInfoPtr_m_StreamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, nameof (m_StreamName));
    PlayableBinding.NativeFieldInfoPtr_m_SourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, nameof (m_SourceObject));
    PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, nameof (m_SourceBindingType));
    PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, nameof (m_CreateOutputMethod));
    PlayableBinding.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, nameof (None));
    PlayableBinding.NativeFieldInfoPtr_DefaultDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, nameof (DefaultDuration));
    PlayableBinding.NativeMethodInfoPtr_get_streamName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100669412);
    PlayableBinding.NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100669413);
    PlayableBinding.NativeMethodInfoPtr_get_outputTargetType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100669414);
    PlayableBinding.NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100669415);
    PlayableBinding.NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, 100669416);
  }

  public unsafe string streamName
  {
    [CallerCount(192 /*0xC0*/), CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_get_streamName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    set => this.m_StreamName = value;
  }

  public unsafe UnityEngine.Object sourceObject
  {
    [CallerCount(29), CachedScanResults(RefRangeStart = 265578, RefRangeEnd = 265607, XrefRangeStart = 265578, XrefRangeEnd = 265607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_get_sourceObject_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num3);
    }
    set => this.m_SourceObject = value;
  }

  public unsafe Il2CppSystem.Type outputTargetType
  {
    [CallerCount(211), CachedScanResults(RefRangeStart = 296220, RefRangeEnd = 296431, XrefRangeStart = 296220, XrefRangeEnd = 296431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_get_outputTargetType_Public_get_Type_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480126, RefRangeEnd = 480127, XrefRangeStart = 480118, XrefRangeEnd = 480126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayableOutput CreateOutput(PlayableGraph graph)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &graph
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_CreateOutput_Internal_PlayableOutput_PlayableGraph_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableOutput*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 480127, RefRangeEnd = 480129, XrefRangeStart = 480127, XrefRangeEnd = 480127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayableBinding CreateInternal(
    string name,
    UnityEngine.Object sourceObject,
    Il2CppSystem.Type sourceType,
    PlayableBinding.CreateOutputMethod createFunction)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceObject);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) createFunction);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.NativeMethodInfoPtr_CreateInternal_Internal_Static_PlayableBinding_String_Object_Type_CreateOutputMethod_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new PlayableBinding(pointer);
  }

  public PlayableBinding(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PlayableBinding()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr))
  {
  }

  public unsafe string m_StreamName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe UnityEngine.Object m_SourceObject
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject));
      return num == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Type m_SourceBindingType
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayableBinding.CreateOutputMethod m_CreateOutputMethod
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod));
      return num == System.IntPtr.Zero ? (PlayableBinding.CreateOutputMethod) null : Il2CppObjectPool.Get<PlayableBinding.CreateOutputMethod>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppReferenceArray<PlayableBinding> None
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_None, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<PlayableBinding>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<PlayableBinding>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_None, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe double DefaultDuration
  {
    get
    {
      double defaultDuration;
      IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*) &defaultDuration);
      return defaultDuration;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*) &value);
    }
  }

  public Il2CppSystem.Type sourceBindingType
  {
    get => this.m_SourceBindingType;
    set
    {
    }
  }

  public DataStreamType streamType
  {
    get => DataStreamType.None;
    set
    {
    }
  }

  public sealed class CreateOutputMethod(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0;

    static CreateOutputMethod()
    {
      Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, nameof (CreateOutputMethod));
      PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100669418);
      PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100669419);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 480116, RefRangeEnd = 480118, XrefRangeStart = 480114, XrefRangeEnd = 480116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateOutputMethod(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe PlayableOutput Invoke(PlayableGraph graph, string name)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &graph;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PlayableOutput*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static implicit operator PlayableBinding.CreateOutputMethod(
      [In] System.Func<PlayableGraph, string, PlayableOutput> obj0)
    {
      return DelegateSupport.ConvertDelegate<PlayableBinding.CreateOutputMethod>((System.Delegate) obj0);
    }

    public static PlayableBinding.CreateOutputMethod operator +(
      [In] PlayableBinding.CreateOutputMethod obj0,
      [In] PlayableBinding.CreateOutputMethod obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PlayableBinding.CreateOutputMethod>();
    }

    public static PlayableBinding.CreateOutputMethod operator -(
      [In] PlayableBinding.CreateOutputMethod obj0,
      [In] PlayableBinding.CreateOutputMethod obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PlayableBinding.CreateOutputMethod) @delegate : @delegate.Cast<PlayableBinding.CreateOutputMethod>();
    }
  }
}
