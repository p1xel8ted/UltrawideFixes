// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.Playable
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct Playable
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NullPlayable;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_Playable_PlayableGraph_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayableOfType_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayableType_Public_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0;
  [FieldOffset(0)]
  public PlayableHandle m_Handle;

  static Playable()
  {
    Il2CppClassPointerStore<Playable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (Playable));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Playable>.NativeClassPtr);
    Playable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Playable>.NativeClassPtr, nameof (m_Handle));
    Playable.NativeFieldInfoPtr_m_NullPlayable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Playable>.NativeClassPtr, nameof (m_NullPlayable));
    Playable.NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100669386);
    Playable.NativeMethodInfoPtr_Create_Public_Static_Playable_PlayableGraph_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100669387);
    Playable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100669388);
    Playable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100669389);
    Playable.NativeMethodInfoPtr_IsPlayableOfType_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100669390);
    Playable.NativeMethodInfoPtr_GetPlayableType_Public_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100669391);
    Playable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Playable>.NativeClassPtr, 100669392);
  }

  public static unsafe Playable Null
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 479978, RefRangeEnd = 479987, XrefRangeStart = 479974, XrefRangeEnd = 479978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_get_Null_Public_Static_get_Playable_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 479995, RefRangeEnd = 480002, XrefRangeStart = 479987, XrefRangeEnd = 479995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Playable Create(PlayableGraph graph, int inputCount = 0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &graph;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &inputCount;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_Create_Public_Static_Playable_PlayableGraph_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 70612, RefRangeEnd = 70627, XrefRangeStart = 70612, XrefRangeEnd = 70627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Playable(PlayableHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr__ctor_Internal_Void_PlayableHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(49)]
  [CachedScanResults(RefRangeStart = 480002, RefRangeEnd = 480051, XrefRangeStart = 480002, XrefRangeEnd = 480002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PlayableHandle GetHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 480068, RefRangeEnd = 480072, XrefRangeStart = 480051, XrefRangeEnd = 480068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsPlayableOfType<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Playable.MethodInfoStoreGeneric_IsPlayableOfType_Public_Boolean_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480080, RefRangeEnd = 480081, XrefRangeStart = 480072, XrefRangeEnd = 480080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Il2CppSystem.Type GetPlayableType()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_GetPlayableType_Public_Type_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480081, XrefRangeEnd = 480090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Playable other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Playable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Playable_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Playable>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe Playable m_NullPlayable
  {
    get
    {
      Playable mNullPlayable;
      IL2CPP.il2cpp_field_static_get_value(Playable.NativeFieldInfoPtr_m_NullPlayable, (void*) &mNullPlayable);
      return mNullPlayable;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(Playable.NativeFieldInfoPtr_m_NullPlayable, (void*) &value);
    }
  }

  private sealed class MethodInfoStoreGeneric_IsPlayableOfType_Public_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(Playable.NativeMethodInfoPtr_IsPlayableOfType_Public_Boolean_0, Il2CppClassPointerStore<Playable>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
