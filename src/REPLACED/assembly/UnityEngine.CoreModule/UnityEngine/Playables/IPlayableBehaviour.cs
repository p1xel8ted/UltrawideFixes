// Decompiled with JetBrains decompiler
// Type: UnityEngine.Playables.IPlayableBehaviour
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine.Playables;

public class IPlayableBehaviour(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0;

  static IPlayableBehaviour()
  {
    Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", nameof (IPlayableBehaviour));
    IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100669377);
    IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100669378);
    IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100669379);
    IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100669380);
    IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100669381);
    IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100669382);
    IPlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100669383);
    IPlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayableBehaviour>.NativeClassPtr, 100669384);
  }

  [CallerCount(0)]
  public virtual unsafe void OnGraphStart(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStart_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnGraphStop(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableBehaviour.NativeMethodInfoPtr_OnGraphStop_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnPlayableCreate(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableCreate_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnPlayableDestroy(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableBehaviour.NativeMethodInfoPtr_OnPlayableDestroy_Public_Abstract_Virtual_New_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnBehaviourPlay(Playable playable, FrameData info)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPlay_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void OnBehaviourPause(Playable playable, FrameData info)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableBehaviour.NativeMethodInfoPtr_OnBehaviourPause_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void PrepareFrame(Playable playable, FrameData info)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableBehaviour.NativeMethodInfoPtr_PrepareFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayableBehaviour.NativeMethodInfoPtr_ProcessFrame_Public_Abstract_Virtual_New_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
