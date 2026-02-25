// Decompiled with JetBrains decompiler
// Type: UnityEngine.LowLevel.PlayerLoopSystem
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.LowLevel;

public sealed class PlayerLoopSystem : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_subSystemList;
  private static readonly System.IntPtr NativeFieldInfoPtr_updateDelegate;
  private static readonly System.IntPtr NativeFieldInfoPtr_updateFunction;
  private static readonly System.IntPtr NativeFieldInfoPtr_loopConditionFunction;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  static PlayerLoopSystem()
  {
    Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", nameof (PlayerLoopSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr);
    PlayerLoopSystem.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, nameof (type));
    PlayerLoopSystem.NativeFieldInfoPtr_subSystemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, nameof (subSystemList));
    PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, nameof (updateDelegate));
    PlayerLoopSystem.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, nameof (updateFunction));
    PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, nameof (loopConditionFunction));
    PlayerLoopSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, 100669273);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 479062, RefRangeEnd = 479063, XrefRangeStart = 479061, XrefRangeEnd = 479062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public PlayerLoopSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public PlayerLoopSystem()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr))
  {
  }

  public unsafe Il2CppSystem.Type type
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_type));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<PlayerLoopSystem> subSystemList
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_subSystemList));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<PlayerLoopSystem>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystem>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_subSystemList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate));
      return num == System.IntPtr.Zero ? (PlayerLoopSystem.UpdateFunction) null : Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe System.IntPtr updateFunction
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateFunction));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateFunction)) = value;
    }
  }

  public unsafe System.IntPtr loopConditionFunction
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction)) = value;
    }
  }

  public sealed class UpdateFunction(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

    static UpdateFunction()
    {
      Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, nameof (UpdateFunction));
      PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr, 100669274);
      PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr, 100669275);
    }

    [CallerCount(483)]
    [CachedScanResults(RefRangeStart = 231718, RefRangeEnd = 232201, XrefRangeStart = 231718, XrefRangeEnd = 232201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateFunction(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PlayerLoopSystem.UpdateFunction([In] System.Action obj0)
    {
      return DelegateSupport.ConvertDelegate<PlayerLoopSystem.UpdateFunction>((System.Delegate) obj0);
    }

    public static PlayerLoopSystem.UpdateFunction operator +(
      [In] PlayerLoopSystem.UpdateFunction obj0,
      [In] PlayerLoopSystem.UpdateFunction obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PlayerLoopSystem.UpdateFunction>();
    }

    public static PlayerLoopSystem.UpdateFunction operator -(
      [In] PlayerLoopSystem.UpdateFunction obj0,
      [In] PlayerLoopSystem.UpdateFunction obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PlayerLoopSystem.UpdateFunction) @delegate : @delegate.Cast<PlayerLoopSystem.UpdateFunction>();
    }
  }
}
