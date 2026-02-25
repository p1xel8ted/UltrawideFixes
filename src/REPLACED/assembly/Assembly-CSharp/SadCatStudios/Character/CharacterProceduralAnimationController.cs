// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterProceduralAnimationController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Sirenix.OdinInspector;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterProceduralAnimationController(System.IntPtr pointer) : SerializedMonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_spriteMatrix;
  private static readonly System.IntPtr NativeFieldInfoPtr_matrixSize;
  private static readonly System.IntPtr NativeFieldInfoPtr_matrixIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_meshFilter;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSizeChanged_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnIndexChanged_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterProceduralAnimationController()
  {
    Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterProceduralAnimationController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr);
    CharacterProceduralAnimationController.NativeFieldInfoPtr_spriteMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr, nameof (spriteMatrix));
    CharacterProceduralAnimationController.NativeFieldInfoPtr_matrixSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr, nameof (matrixSize));
    CharacterProceduralAnimationController.NativeFieldInfoPtr_matrixIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr, nameof (matrixIndex));
    CharacterProceduralAnimationController.NativeFieldInfoPtr_meshFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr, nameof (meshFilter));
    CharacterProceduralAnimationController.NativeMethodInfoPtr_OnSizeChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr, 100675478);
    CharacterProceduralAnimationController.NativeMethodInfoPtr_OnIndexChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr, 100675479);
    CharacterProceduralAnimationController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr, 100675480);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117762, XrefRangeEnd = 117765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnSizeChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterProceduralAnimationController.NativeMethodInfoPtr_OnSizeChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117765, XrefRangeEnd = 117809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnIndexChanged()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterProceduralAnimationController.NativeMethodInfoPtr_OnIndexChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 117809, XrefRangeEnd = 117813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterProceduralAnimationController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterProceduralAnimationController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppObjectBase spriteMatrix
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterProceduralAnimationController.NativeFieldInfoPtr_spriteMatrix));
      return num == System.IntPtr.Zero ? (Il2CppObjectBase) null : Il2CppObjectPool.Get<Il2CppObjectBase>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterProceduralAnimationController.NativeFieldInfoPtr_spriteMatrix), IL2CPP.Il2CppObjectBaseToPtr(value));
    }
  }

  public Il2CppSystem.ValueTuple<int, int> matrixSize
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterProceduralAnimationController.NativeFieldInfoPtr_matrixSize);
      return new Il2CppSystem.ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterProceduralAnimationController.NativeFieldInfoPtr_matrixSize), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public Il2CppSystem.ValueTuple<int, int> matrixIndex
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterProceduralAnimationController.NativeFieldInfoPtr_matrixIndex);
      return new Il2CppSystem.ValueTuple<int, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterProceduralAnimationController.NativeFieldInfoPtr_matrixIndex), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.ValueTuple<int, int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe MeshFilter meshFilter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterProceduralAnimationController.NativeFieldInfoPtr_meshFilter));
      return num == System.IntPtr.Zero ? (MeshFilter) null : Il2CppObjectPool.Get<MeshFilter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterProceduralAnimationController.NativeFieldInfoPtr_meshFilter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [ObfuscatedName("SadCatStudios.Character.CharacterProceduralAnimationController+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__5_1;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnIndexChanged_b__5_0_Internal_Vector3_Vector2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnIndexChanged_b__5_1_Internal_Int32_UInt16_0;

    static __c()
    {
      Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterProceduralAnimationController>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr);
      CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr, "<>9");
      CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr, "<>9__5_0");
      CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr, "<>9__5_1");
      CharacterProceduralAnimationController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr, 100675482);
      CharacterProceduralAnimationController.__c.NativeMethodInfoPtr__OnIndexChanged_b__5_0_Internal_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr, 100675483);
      CharacterProceduralAnimationController.__c.NativeMethodInfoPtr__OnIndexChanged_b__5_1_Internal_Int32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr, 100675484);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterProceduralAnimationController.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CharacterProceduralAnimationController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe Vector3 _OnIndexChanged_b__5_0(Vector2 i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterProceduralAnimationController.__c.NativeMethodInfoPtr__OnIndexChanged_b__5_0_Internal_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public unsafe int _OnIndexChanged_b__5_1(ushort i)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &i
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterProceduralAnimationController.__c.NativeMethodInfoPtr__OnIndexChanged_b__5_1_Internal_Int32_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public static unsafe CharacterProceduralAnimationController.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (CharacterProceduralAnimationController.__c) null : Il2CppObjectPool.Get<CharacterProceduralAnimationController.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Converter<Vector2, Vector3> __9__5_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9__5_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Converter<Vector2, Vector3>) null : Il2CppObjectPool.Get<Il2CppSystem.Converter<Vector2, Vector3>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Converter<ushort, int> __9__5_1
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9__5_1, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Converter<ushort, int>) null : Il2CppObjectPool.Get<Il2CppSystem.Converter<ushort, int>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CharacterProceduralAnimationController.__c.NativeFieldInfoPtr___9__5_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
