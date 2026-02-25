// Decompiled with JetBrains decompiler
// Type: SadCatStudios.PlayerInput.InputCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.PlayerInput;

public class InputCache(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_cacheAction;
  private static readonly System.IntPtr NativeFieldInfoPtr_cacheTime;
  private static readonly System.IntPtr NativeFieldInfoPtr_inputDict;
  private static readonly System.IntPtr NativeFieldInfoPtr_keys;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FloatReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Press_Public_Void_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invalidate_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Public_Boolean_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonShort_Public_Boolean_InputAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_Single_0;

  static InputCache()
  {
    Il2CppClassPointerStore<InputCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.PlayerInput", nameof (InputCache));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputCache>.NativeClassPtr);
    InputCache.NativeFieldInfoPtr_cacheAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCache>.NativeClassPtr, nameof (cacheAction));
    InputCache.NativeFieldInfoPtr_cacheTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCache>.NativeClassPtr, nameof (cacheTime));
    InputCache.NativeFieldInfoPtr_inputDict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCache>.NativeClassPtr, nameof (inputDict));
    InputCache.NativeFieldInfoPtr_keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputCache>.NativeClassPtr, nameof (keys));
    InputCache.NativeMethodInfoPtr__ctor_Public_Void_FloatReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCache>.NativeClassPtr, 100671004);
    InputCache.NativeMethodInfoPtr_Press_Public_Void_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCache>.NativeClassPtr, 100671005);
    InputCache.NativeMethodInfoPtr_Invalidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCache>.NativeClassPtr, 100671006);
    InputCache.NativeMethodInfoPtr_GetButton_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCache>.NativeClassPtr, 100671007);
    InputCache.NativeMethodInfoPtr_GetButtonShort_Public_Boolean_InputAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCache>.NativeClassPtr, 100671008);
    InputCache.NativeMethodInfoPtr_Update_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputCache>.NativeClassPtr, 100671009);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90327, RefRangeEnd = 90328, XrefRangeStart = 90287, XrefRangeEnd = 90327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputCache(FloatReference cacheTime)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputCache>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cacheTime)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputCache.NativeMethodInfoPtr__ctor_Public_Void_FloatReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90333, RefRangeEnd = 90334, XrefRangeStart = 90328, XrefRangeEnd = 90333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Press(InputAction inputAction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputAction
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputCache.NativeMethodInfoPtr_Press_Public_Void_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90334, XrefRangeEnd = 90344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Invalidate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputCache.NativeMethodInfoPtr_Invalidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 90350, RefRangeEnd = 90354, XrefRangeStart = 90344, XrefRangeEnd = 90350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButton(InputAction inputAction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputAction
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputCache.NativeMethodInfoPtr_GetButton_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90354, XrefRangeEnd = 90359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool GetButtonShort(InputAction inputAction)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &inputAction
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputCache.NativeMethodInfoPtr_GetButtonShort_Public_Boolean_InputAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 90381, RefRangeEnd = 90382, XrefRangeStart = 90359, XrefRangeEnd = 90381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update(float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deltaTime
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputCache.NativeMethodInfoPtr_Update_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InputAction cacheAction
  {
    get
    {
      return *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputCache.NativeFieldInfoPtr_cacheAction));
    }
    [param: In] set
    {
      *(InputAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputCache.NativeFieldInfoPtr_cacheAction)) = value;
    }
  }

  public unsafe FloatReference cacheTime
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputCache.NativeFieldInfoPtr_cacheTime));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputCache.NativeFieldInfoPtr_cacheTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<InputAction, float> inputDict
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputCache.NativeFieldInfoPtr_inputDict));
      return num == System.IntPtr.Zero ? (Dictionary<InputAction, float>) null : Il2CppObjectPool.Get<Dictionary<InputAction, float>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputCache.NativeFieldInfoPtr_inputDict), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<InputAction> keys
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputCache.NativeFieldInfoPtr_keys));
      return num == System.IntPtr.Zero ? (List<InputAction>) null : Il2CppObjectPool.Get<List<InputAction>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputCache.NativeFieldInfoPtr_keys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
