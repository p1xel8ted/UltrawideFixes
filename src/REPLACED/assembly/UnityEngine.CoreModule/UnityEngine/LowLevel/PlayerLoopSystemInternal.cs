// Decompiled with JetBrains decompiler
// Type: UnityEngine.LowLevel.PlayerLoopSystemInternal
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.LowLevel;

public sealed class PlayerLoopSystemInternal : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_updateDelegate;
  private static readonly System.IntPtr NativeFieldInfoPtr_updateFunction;
  private static readonly System.IntPtr NativeFieldInfoPtr_loopConditionFunction;
  private static readonly System.IntPtr NativeFieldInfoPtr_numSubSystems;

  static PlayerLoopSystemInternal()
  {
    Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", nameof (PlayerLoopSystemInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr);
    PlayerLoopSystemInternal.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, nameof (type));
    PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, nameof (updateDelegate));
    PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, nameof (updateFunction));
    PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, nameof (loopConditionFunction));
    PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, nameof (numSubSystems));
  }

  public PlayerLoopSystemInternal(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PlayerLoopSystemInternal()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr))
  {
  }

  public unsafe Il2CppSystem.Type type
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate));
      return num == System.IntPtr.Zero ? (PlayerLoopSystem.UpdateFunction) null : Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe System.IntPtr updateFunction
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction)) = value;
    }
  }

  public unsafe System.IntPtr loopConditionFunction
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction)) = value;
    }
  }

  public unsafe int numSubSystems
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems)) = value;
    }
  }
}
