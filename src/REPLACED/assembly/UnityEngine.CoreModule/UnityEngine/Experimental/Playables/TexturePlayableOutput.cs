// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Playables.TexturePlayableOutput
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Experimental.Playables;

[StructLayout(LayoutKind.Explicit)]
public struct TexturePlayableOutput
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Handle;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0;
  [FieldOffset(0)]
  public PlayableOutputHandle m_Handle;
  private static readonly TexturePlayableOutput.InternalGetTarget_InjectedDelegate InternalGetTarget_InjectedDelegateField;
  private static readonly TexturePlayableOutput.InternalSetTarget_InjectedDelegate InternalSetTarget_InjectedDelegateField;

  static TexturePlayableOutput()
  {
    Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", nameof (TexturePlayableOutput));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr);
    TexturePlayableOutput.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, nameof (m_Handle));
    TexturePlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, 100670734);
    TexturePlayableOutput.InternalGetTarget_InjectedDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalGetTarget_InjectedDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalGetTarget_Injected");
    TexturePlayableOutput.InternalSetTarget_InjectedDelegateField = IL2CPP.ResolveICall<TexturePlayableOutput.InternalSetTarget_InjectedDelegate>("UnityEngine.Experimental.Playables.TexturePlayableOutput::InternalSetTarget_Injected");
  }

  [CallerCount(49)]
  [CachedScanResults(RefRangeStart = 480002, RefRangeEnd = 480051, XrefRangeStart = 480002, XrefRangeEnd = 480051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe PlayableOutputHandle GetHandle()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TexturePlayableOutput.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableOutputHandle_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableOutputHandle*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TexturePlayableOutput>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static TexturePlayableOutput Create(
    PlayableGraph graph,
    string name,
    RenderTexture target)
  {
    PlayableOutputHandle handle;
    if (!TexturePlayableGraphExtensions.InternalCreateTextureOutput(ref graph, name, out handle))
      return TexturePlayableOutput.Null;
    TexturePlayableOutput texturePlayableOutput = new TexturePlayableOutput(handle);
    texturePlayableOutput.SetTarget(target);
    return texturePlayableOutput;
  }

  public static TexturePlayableOutput Null => new TexturePlayableOutput(PlayableOutputHandle.Null);

  public static implicit operator PlayableOutput(TexturePlayableOutput output)
  {
    return new PlayableOutput(output.GetHandle());
  }

  public static explicit operator TexturePlayableOutput(PlayableOutput output)
  {
    return new TexturePlayableOutput(output.GetHandle());
  }

  public RenderTexture GetTarget() => TexturePlayableOutput.InternalGetTarget(ref this.m_Handle);

  public void SetTarget(RenderTexture value)
  {
    TexturePlayableOutput.InternalSetTarget(ref this.m_Handle, value);
  }

  public static RenderTexture InternalGetTarget(ref PlayableOutputHandle output)
  {
    return Unmarshal.UnmarshalUnityObject<RenderTexture>(TexturePlayableOutput.InternalGetTarget_Injected(ref output));
  }

  public static void InternalSetTarget(ref PlayableOutputHandle output, RenderTexture target)
  {
    TexturePlayableOutput.InternalSetTarget_Injected(ref output, UnityEngine.Object.MarshalledUnityObject.Marshal<RenderTexture>(target));
  }

  public static System.IntPtr InternalGetTarget_Injected(ref PlayableOutputHandle output)
  {
    return TexturePlayableOutput.InternalGetTarget_InjectedDelegateField((System.IntPtr) ref output);
  }

  public static void InternalSetTarget_Injected(ref PlayableOutputHandle output, System.IntPtr target)
  {
    TexturePlayableOutput.InternalSetTarget_InjectedDelegateField((System.IntPtr) ref output, target);
  }

  private delegate System.IntPtr InternalGetTarget_InjectedDelegate(System.IntPtr output);

  private delegate void InternalSetTarget_InjectedDelegate(System.IntPtr output, System.IntPtr target);
}
