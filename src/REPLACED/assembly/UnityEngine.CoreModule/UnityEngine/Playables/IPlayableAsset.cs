// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.IPlayableAsset
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace UnityEngine.Playables;

public class IPlayableAsset(IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0;

  static IPlayableAsset()
  {
    Il2CppClassPointerStore<IPlayableAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (IPlayableAsset));
    IPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableAsset>.NativeClassPtr, 100669394);
    IPlayableAsset.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableAsset>.NativeClassPtr, 100669395);
  }

  [CallerCount(0)]
  public virtual unsafe Playable CreatePlayable(PlayableGraph graph, GameObject owner)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &graph;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) owner);
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableAsset.NativeMethodInfoPtr_CreatePlayable_Public_Abstract_Virtual_New_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Playable*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public virtual unsafe double duration
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableAsset.NativeMethodInfoPtr_get_duration_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(double*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }
}
