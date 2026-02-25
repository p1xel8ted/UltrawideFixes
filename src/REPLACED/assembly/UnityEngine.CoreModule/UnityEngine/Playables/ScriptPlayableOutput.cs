// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.ScriptPlayableOutput
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct ScriptPlayableOutput
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0;
  [FieldOffset(0)]
  public PlayableOutputHandle m_Handle;

  static ScriptPlayableOutput()
  {
    Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (ScriptPlayableOutput));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr);
    ScriptPlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, nameof (m_Handle));
    ScriptPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100669568);
    ScriptPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100669569);
    ScriptPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100669570);
    ScriptPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100669571);
    ScriptPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, 100669572);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481388, XrefRangeEnd = 481398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScriptPlayableOutput Create(PlayableGraph graph, string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &graph;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_Create_Public_Static_ScriptPlayableOutput_PlayableGraph_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ScriptPlayableOutput*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 481408, RefRangeEnd = 481411, XrefRangeStart = 481398, XrefRangeEnd = 481408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptPlayableOutput(PlayableOutputHandle handle)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &handle
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr__ctor_Internal_Void_PlayableOutputHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe ScriptPlayableOutput Null
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481411, XrefRangeEnd = 481419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_get_Null_Public_Static_get_ScriptPlayableOutput_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ScriptPlayableOutput*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(49)]
  [CachedScanResults(RefRangeStart = 480002, RefRangeEnd = 480051, XrefRangeStart = 480002, XrefRangeEnd = 480051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PlayableOutputHandle GetHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableOutputHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe implicit operator PlayableOutput(ScriptPlayableOutput output)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &output
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableOutput.NativeMethodInfoPtr_op_Implicit_Public_Static_PlayableOutput_ScriptPlayableOutput_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableOutput*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptPlayableOutput>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static explicit operator ScriptPlayableOutput(PlayableOutput output)
  {
    return new ScriptPlayableOutput(output.GetHandle());
  }
}
