// Decompiled with JetBrains decompiler
// Type: UnityEngine.Experimental.U2D.SpriteRendererGroup
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

#nullable disable
namespace UnityEngine.Experimental.U2D;

public class SpriteRendererGroup(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly SpriteRendererGroup.AddRenderersDelegate AddRenderersDelegateField;
  private static readonly SpriteRendererGroup.ClearDelegate ClearDelegateField;

  static SpriteRendererGroup()
  {
    Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.U2D", nameof (SpriteRendererGroup));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteRendererGroup>.NativeClassPtr);
    SpriteRendererGroup.AddRenderersDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.AddRenderersDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::AddRenderers");
    SpriteRendererGroup.ClearDelegateField = IL2CPP.ResolveICall<SpriteRendererGroup.ClearDelegate>("UnityEngine.Experimental.U2D.SpriteRendererGroup::Clear");
  }

  public static unsafe void AddRenderers(
    NativeArray<SpriteIntermediateRendererInfo> renderers)
  {
    SpriteRendererGroup.AddRenderers(renderers.GetUnsafeReadOnlyPtr<SpriteIntermediateRendererInfo>(), ((NativeArray<SpriteIntermediateRendererInfo>) ref renderers).Length);
  }

  public static unsafe void AddRenderers(void* renderers, int count)
  {
    SpriteRendererGroup.AddRenderersDelegateField((System.IntPtr) renderers, count);
  }

  public static void Clear() => SpriteRendererGroup.ClearDelegateField();

  private delegate void AddRenderersDelegate(System.IntPtr renderers, int count);

  private delegate void ClearDelegate();
}
