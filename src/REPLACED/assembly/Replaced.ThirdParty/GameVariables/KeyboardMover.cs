// Decompiled with JetBrains decompiler
// Type: GameVariables.KeyboardMover
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace GameVariables;

public class KeyboardMover(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MoveRate;
  private static readonly System.IntPtr NativeFieldInfoPtr_Horizontal;
  private static readonly System.IntPtr NativeFieldInfoPtr_Vertical;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static KeyboardMover()
  {
    Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "GameVariables", nameof (KeyboardMover));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr);
    KeyboardMover.NativeFieldInfoPtr_MoveRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr, nameof (MoveRate));
    KeyboardMover.NativeFieldInfoPtr_Horizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr, nameof (Horizontal));
    KeyboardMover.NativeFieldInfoPtr_Vertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr, nameof (Vertical));
    KeyboardMover.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr, 100663371 /*0x0600004B*/);
    KeyboardMover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr, 100663372 /*0x0600004C*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360920, XrefRangeEnd = 360939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KeyboardMover.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360939, XrefRangeEnd = 360947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe KeyboardMover()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(KeyboardMover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe FloatVariable MoveRate
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.NativeFieldInfoPtr_MoveRate));
      return num == System.IntPtr.Zero ? (FloatVariable) null : Il2CppObjectPool.Get<FloatVariable>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.NativeFieldInfoPtr_MoveRate), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe KeyboardMover.MoveAxis Horizontal
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.NativeFieldInfoPtr_Horizontal));
      return num == System.IntPtr.Zero ? (KeyboardMover.MoveAxis) null : Il2CppObjectPool.Get<KeyboardMover.MoveAxis>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.NativeFieldInfoPtr_Horizontal), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe KeyboardMover.MoveAxis Vertical
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.NativeFieldInfoPtr_Vertical));
      return num == System.IntPtr.Zero ? (KeyboardMover.MoveAxis) null : Il2CppObjectPool.Get<KeyboardMover.MoveAxis>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.NativeFieldInfoPtr_Vertical), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class MoveAxis(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Positive;
    private static readonly System.IntPtr NativeFieldInfoPtr_Negative;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_KeyCode_KeyCode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_MoveAxis_0;

    static MoveAxis()
    {
      Il2CppClassPointerStore<KeyboardMover.MoveAxis>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeyboardMover>.NativeClassPtr, nameof (MoveAxis));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyboardMover.MoveAxis>.NativeClassPtr);
      KeyboardMover.MoveAxis.NativeFieldInfoPtr_Positive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardMover.MoveAxis>.NativeClassPtr, nameof (Positive));
      KeyboardMover.MoveAxis.NativeFieldInfoPtr_Negative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyboardMover.MoveAxis>.NativeClassPtr, nameof (Negative));
      KeyboardMover.MoveAxis.NativeMethodInfoPtr__ctor_Public_Void_KeyCode_KeyCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMover.MoveAxis>.NativeClassPtr, 100663373 /*0x0600004D*/);
      KeyboardMover.MoveAxis.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_MoveAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyboardMover.MoveAxis>.NativeClassPtr, 100663374 /*0x0600004E*/);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoveAxis(KeyCode positive, KeyCode negative)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyboardMover.MoveAxis>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &positive;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &negative;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(KeyboardMover.MoveAxis.NativeMethodInfoPtr__ctor_Public_Void_KeyCode_KeyCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360917, XrefRangeEnd = 360920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator float(KeyboardMover.MoveAxis axis)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) axis)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(KeyboardMover.MoveAxis.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_MoveAxis_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public unsafe KeyCode Positive
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.MoveAxis.NativeFieldInfoPtr_Positive));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.MoveAxis.NativeFieldInfoPtr_Positive)) = value;
      }
    }

    public unsafe KeyCode Negative
    {
      get
      {
        return *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.MoveAxis.NativeFieldInfoPtr_Negative));
      }
      [param: In] set
      {
        *(KeyCode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KeyboardMover.MoveAxis.NativeFieldInfoPtr_Negative)) = value;
      }
    }
  }
}
