// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.PlayableOutput
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct PlayableOutput
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_NullPlayableOutput;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0;
  [FieldOffset(0)]
  public PlayableOutputHandle m_Handle;

  static PlayableOutput()
  {
    Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (PlayableOutput));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr);
    PlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, nameof (m_Handle));
    PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, nameof (m_NullPlayableOutput));
    PlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100669514);
    PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100669515);
    PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100669516);
    PlayableOutput.NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100669517);
    PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, 100669518);
  }

  public static unsafe PlayableOutput Null
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480868, XrefRangeEnd = 480872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutput_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PlayableOutput*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 70612, RefRangeEnd = 70627, XrefRangeStart = 70612, XrefRangeEnd = 70627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayableOutput(PlayableOutputHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(49)]
  [CachedScanResults(RefRangeStart = 480002, RefRangeEnd = 480051, XrefRangeStart = 480002, XrefRangeEnd = 480051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PlayableOutputHandle GetHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableOutputHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 480889, RefRangeEnd = 480890, XrefRangeStart = 480872, XrefRangeEnd = 480889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool IsPlayableOutputOfType<T>() where T : new()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.MethodInfoStoreGeneric_IsPlayableOutputOfType_Public_Boolean_0<T>.Pointer, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 480890, XrefRangeEnd = 480899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(PlayableOutput other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayableOutput.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutput_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe PlayableOutput m_NullPlayableOutput
  {
    get
    {
      PlayableOutput nullPlayableOutput;
      IL2CPP.il2cpp_field_static_get_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*) &nullPlayableOutput);
      return nullPlayableOutput;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PlayableOutput.NativeFieldInfoPtr_m_NullPlayableOutput, (void*) &value);
    }
  }

  public Il2CppSystem.Type GetPlayableOutputType() => this.GetHandle().GetPlayableOutputType();

  private sealed class MethodInfoStoreGeneric_IsPlayableOutputOfType_Public_Boolean_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableOutput.NativeMethodInfoPtr_IsPlayableOutputOfType_Public_Boolean_0, Il2CppClassPointerStore<PlayableOutput>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
