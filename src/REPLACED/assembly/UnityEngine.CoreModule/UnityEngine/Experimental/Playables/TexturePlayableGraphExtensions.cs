// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.Playables.TexturePlayableGraphExtensions
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Playables;

#nullable disable
namespace UnityEngine.Experimental.Playables;

public static class TexturePlayableGraphExtensions
{
  private static readonly TexturePlayableGraphExtensions.InternalCreateTextureOutput_InjectedDelegate InternalCreateTextureOutput_InjectedDelegateField = IL2CPP.ResolveICall<TexturePlayableGraphExtensions.InternalCreateTextureOutput_InjectedDelegate>("UnityEngine.Experimental.Playables.TexturePlayableGraphExtensions::InternalCreateTextureOutput_Injected");

  public static unsafe bool InternalCreateTextureOutput(
    ref PlayableGraph graph,
    string name,
    out PlayableOutputHandle handle)
  {
    try
    {
      ref PlayableGraph local1 = ref graph;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local2 = ref managedSpanWrapper;
      ref PlayableOutputHandle local3 = ref handle;
      return TexturePlayableGraphExtensions.InternalCreateTextureOutput_Injected(ref local1, ref local2, out local3);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static bool InternalCreateTextureOutput_Injected(
    ref PlayableGraph graph,
    ref ManagedSpanWrapper name,
    out PlayableOutputHandle handle)
  {
    return TexturePlayableGraphExtensions.InternalCreateTextureOutput_InjectedDelegateField((System.IntPtr) ref graph, (System.IntPtr) ref name, (System.IntPtr) ref handle);
  }

  private delegate bool InternalCreateTextureOutput_InjectedDelegate(
    System.IntPtr graph,
    System.IntPtr name,
    [Out] System.IntPtr handle);
}
