// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.MyPlatformHardwareJoystickMapPlatformMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Rewired.Data.Mapping;
using Rewired.Platforms.Custom;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

public sealed class MyPlatformHardwareJoystickMapPlatformMap(System.IntPtr pointer) : 
  HardwareJoystickMapCustomPlatformMapSO(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_platformMap;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPlatformMap_Public_Virtual_Platform_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MyPlatformHardwareJoystickMapPlatformMap()
  {
    Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (MyPlatformHardwareJoystickMapPlatformMap));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr);
    MyPlatformHardwareJoystickMapPlatformMap.NativeFieldInfoPtr_platformMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr, nameof (platformMap));
    MyPlatformHardwareJoystickMapPlatformMap.NativeMethodInfoPtr_GetPlatformMap_Public_Virtual_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr, 100670523);
    MyPlatformHardwareJoystickMapPlatformMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr, 100670524);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe HardwareJoystickMap.Platform GetPlatformMap()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.NativeMethodInfoPtr_GetPlatformMap_Public_Virtual_Platform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (HardwareJoystickMap.Platform) null : Il2CppObjectPool.Get<HardwareJoystickMap.Platform>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 16659, RefRangeEnd = 16660, XrefRangeStart = 16659, XrefRangeEnd = 16660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MyPlatformHardwareJoystickMapPlatformMap()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe MyPlatformHardwareJoystickMapPlatformMap.PlatformMap platformMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformHardwareJoystickMapPlatformMap.NativeFieldInfoPtr_platformMap));
      return num == System.IntPtr.Zero ? (MyPlatformHardwareJoystickMapPlatformMap.PlatformMap) null : Il2CppObjectPool.Get<MyPlatformHardwareJoystickMapPlatformMap.PlatformMap>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformHardwareJoystickMapPlatformMap.NativeFieldInfoPtr_platformMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class PlatformMapBase(System.IntPtr pointer) : 
    HardwareJoystickMapCustomPlatformMap<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static PlatformMapBase()
    {
      Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr, nameof (PlatformMapBase));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase>.NativeClassPtr);
      MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase>.NativeClassPtr, 100670525);
      MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase>.NativeClassPtr, 100670526);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85676, XrefRangeEnd = 85682, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppSystem.Object CreateInstance()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85682, XrefRangeEnd = 85685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlatformMapBase()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public sealed class PlatformMap(System.IntPtr pointer) : 
    MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_variants;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVariants_Public_Virtual_IList_1_Platform_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static PlatformMap()
    {
      Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMap>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr, nameof (PlatformMap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMap>.NativeClassPtr);
      MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeFieldInfoPtr_variants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMap>.NativeClassPtr, nameof (variants));
      MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeMethodInfoPtr_GetVariants_Public_Virtual_IList_1_Platform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMap>.NativeClassPtr, 100670527);
      MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMap>.NativeClassPtr, 100670528);
      MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMap>.NativeClassPtr, 100670529);
    }

    [CallerCount(15)]
    [CachedScanResults(RefRangeStart = 64606, RefRangeEnd = 64621, XrefRangeStart = 64606, XrefRangeEnd = 64621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe IList<HardwareJoystickMap.Platform> GetVariants()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeMethodInfoPtr_GetVariants_Public_Virtual_IList_1_Platform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IList<HardwareJoystickMap.Platform>) null : Il2CppObjectPool.Get<IList<HardwareJoystickMap.Platform>>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85685, XrefRangeEnd = 85691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppSystem.Object CreateInstance()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PlatformMap()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.PlatformMap>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe Il2CppReferenceArray<MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase> variants
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeFieldInfoPtr_variants));
        return num == System.IntPtr.Zero ? (Il2CppReferenceArray<MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<MyPlatformHardwareJoystickMapPlatformMap.PlatformMapBase>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformHardwareJoystickMapPlatformMap.PlatformMap.NativeFieldInfoPtr_variants), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [Serializable]
  public sealed class MatchingCriteria(System.IntPtr pointer) : 
    HardwareJoystickMapCustomPlatformMap.MatchingCriteria(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_vendorId;
    private static readonly System.IntPtr NativeFieldInfoPtr_productId;
    private static readonly System.IntPtr NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DeepClone_Protected_Virtual_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static MatchingCriteria()
    {
      Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap>.NativeClassPtr, nameof (MatchingCriteria));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr);
      MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeFieldInfoPtr_vendorId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr, nameof (vendorId));
      MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeFieldInfoPtr_productId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr, nameof (productId));
      MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr, 100670530);
      MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr, 100670531);
      MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeMethodInfoPtr_DeepClone_Protected_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr, 100670532);
      MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr, 100670533);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85691, XrefRangeEnd = 85694, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Matches(Il2CppSystem.Object customIdentifier)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) customIdentifier)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85694, XrefRangeEnd = 85698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppSystem.Object CreateInstance()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85698, XrefRangeEnd = 85701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void DeepClone(Il2CppSystem.Object destination)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) destination)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeMethodInfoPtr_DeepClone_Protected_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 85702, RefRangeEnd = 85710, XrefRangeStart = 85701, XrefRangeEnd = 85702, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MatchingCriteria()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe uint vendorId
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeFieldInfoPtr_vendorId));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeFieldInfoPtr_vendorId)) = value;
      }
    }

    public unsafe uint productId
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeFieldInfoPtr_productId));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformHardwareJoystickMapPlatformMap.MatchingCriteria.NativeFieldInfoPtr_productId)) = value;
      }
    }
  }
}
