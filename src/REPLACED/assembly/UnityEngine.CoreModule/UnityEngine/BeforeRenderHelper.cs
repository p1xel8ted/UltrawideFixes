// Decompiled with JetBrains decompiler
// Type: UnityEngine.BeforeRenderHelper
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Events;

#nullable disable
namespace UnityEngine;

public static class BeforeRenderHelper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_OrderBlocks;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_0;

  static BeforeRenderHelper()
  {
    Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BeforeRenderHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr);
    BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, nameof (s_OrderBlocks));
    BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100664651);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 422885, RefRangeEnd = 422886, XrefRangeStart = 422867, XrefRangeEnd = 422885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Invoke()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public BeforeRenderHelper(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe List<BeforeRenderHelper.OrderBlock> s_OrderBlocks
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<BeforeRenderHelper.OrderBlock>) null : Il2CppObjectPool.Get<List<BeforeRenderHelper.OrderBlock>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static int GetUpdateOrder(UnityAction callback)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void RegisterCallback(UnityAction callback)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static void UnregisterCallback(UnityAction callback)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public sealed class OrderBlock : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_order;
    private static readonly System.IntPtr NativeFieldInfoPtr_callback;

    static OrderBlock()
    {
      Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, nameof (OrderBlock));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr);
      BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, nameof (order));
      BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, nameof (callback));
    }

    public OrderBlock(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public OrderBlock()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr))
    {
    }

    public unsafe int order
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order)) = value;
      }
    }

    public unsafe UnityAction callback
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback));
        return num == System.IntPtr.Zero ? (UnityAction) null : Il2CppObjectPool.Get<UnityAction>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
