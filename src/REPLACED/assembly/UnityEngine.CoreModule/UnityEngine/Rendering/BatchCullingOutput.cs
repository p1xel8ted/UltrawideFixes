// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchCullingOutput
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace UnityEngine.Rendering;

public sealed class BatchCullingOutput : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_drawCommands;
  private static readonly System.IntPtr NativeFieldInfoPtr_customCullingResult;

  static BatchCullingOutput()
  {
    Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchCullingOutput));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr);
    BatchCullingOutput.NativeFieldInfoPtr_drawCommands = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr, nameof (drawCommands));
    BatchCullingOutput.NativeFieldInfoPtr_customCullingResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr, nameof (customCullingResult));
  }

  public BatchCullingOutput(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public BatchCullingOutput()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BatchCullingOutput>.NativeClassPtr))
  {
  }

  public NativeArray<BatchCullingOutputDrawCommands> drawCommands
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingOutput.NativeFieldInfoPtr_drawCommands);
      return new NativeArray<BatchCullingOutputDrawCommands>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingOutput.NativeFieldInfoPtr_drawCommands), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<BatchCullingOutputDrawCommands>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public NativeArray<System.IntPtr> customCullingResult
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingOutput.NativeFieldInfoPtr_customCullingResult);
      return new NativeArray<System.IntPtr>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BatchCullingOutput.NativeFieldInfoPtr_customCullingResult), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<System.IntPtr>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }
}
