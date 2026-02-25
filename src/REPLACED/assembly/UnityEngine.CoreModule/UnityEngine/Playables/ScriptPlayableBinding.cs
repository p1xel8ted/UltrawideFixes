// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.ScriptPlayableBinding
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine.Playables;

public static class ScriptPlayableBinding : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0;

  static ScriptPlayableBinding()
  {
    Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (ScriptPlayableBinding));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr);
    ScriptPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr, 100669566);
    ScriptPlayableBinding.NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptPlayableBinding>.NativeClassPtr, 100669567);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 481376, RefRangeEnd = 481378, XrefRangeStart = 481366, XrefRangeEnd = 481376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayableBinding Create(string name, UnityEngine.Object key, Il2CppSystem.Type type)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) key);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableBinding.NativeMethodInfoPtr_Create_Public_Static_PlayableBinding_String_Object_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new PlayableBinding(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481378, XrefRangeEnd = 481388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe PlayableOutput CreateScriptOutput(PlayableGraph graph, string name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &graph;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(name);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptPlayableBinding.NativeMethodInfoPtr_CreateScriptOutput_Private_Static_PlayableOutput_PlayableGraph_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(PlayableOutput*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public ScriptPlayableBinding(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
