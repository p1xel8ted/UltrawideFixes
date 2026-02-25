// Decompiled with JetBrains decompiler
// Type: GuidManager
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class GuidManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Instance;
  private static readonly System.IntPtr NativeFieldInfoPtr_guidToObjectMap;
  private static readonly System.IntPtr NativeMethodInfoPtr_Add_Public_Static_Boolean_GuidComponent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Remove_Public_Static_Void_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_Action_1_GameObject_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalAdd_Private_Boolean_GuidComponent_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_InternalRemove_Private_Void_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResolveGuidInternal_Private_GameObject_Guid_Action_1_GameObject_Action_0;

  static GuidManager()
  {
    Il2CppClassPointerStore<GuidManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "", nameof (GuidManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidManager>.NativeClassPtr);
    GuidManager.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, nameof (Instance));
    GuidManager.NativeFieldInfoPtr_guidToObjectMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, nameof (guidToObjectMap));
    GuidManager.NativeMethodInfoPtr_Add_Public_Static_Boolean_GuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663306 /*0x0600000A*/);
    GuidManager.NativeMethodInfoPtr_Remove_Public_Static_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663307 /*0x0600000B*/);
    GuidManager.NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_Action_1_GameObject_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663308 /*0x0600000C*/);
    GuidManager.NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663309 /*0x0600000D*/);
    GuidManager.NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663310 /*0x0600000E*/);
    GuidManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663311 /*0x0600000F*/);
    GuidManager.NativeMethodInfoPtr_InternalAdd_Private_Boolean_GuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663312 /*0x06000010*/);
    GuidManager.NativeMethodInfoPtr_InternalRemove_Private_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663313 /*0x06000011*/);
    GuidManager.NativeMethodInfoPtr_ResolveGuidInternal_Private_GameObject_Guid_Action_1_GameObject_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, 100663314 /*0x06000012*/);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 360065, RefRangeEnd = 360066, XrefRangeStart = 360057, XrefRangeEnd = 360065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool Add(GuidComponent guidComponent)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) guidComponent)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr_Add_Public_Static_Boolean_GuidComponent_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 360078, RefRangeEnd = 360079, XrefRangeStart = 360066, XrefRangeEnd = 360078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Remove(Il2CppSystem.Guid guid)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &guid
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr_Remove_Public_Static_Void_Guid_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360079, XrefRangeEnd = 360086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject ResolveGuid(
    Il2CppSystem.Guid guid,
    Il2CppSystem.Action<GameObject> onAddCallback,
    Il2CppSystem.Action onRemoveCallback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &guid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onAddCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onRemoveCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_Action_1_GameObject_Action_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360086, XrefRangeEnd = 360100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject ResolveGuid(Il2CppSystem.Guid guid, Il2CppSystem.Action onDestroyCallback)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &guid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onDestroyCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_Action_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360100, XrefRangeEnd = 360113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe GameObject ResolveGuid(Il2CppSystem.Guid guid)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &guid
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr_ResolveGuid_Public_Static_GameObject_Guid_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 360120, RefRangeEnd = 360127, XrefRangeStart = 360113, XrefRangeEnd = 360120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GuidManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 360172, RefRangeEnd = 360173, XrefRangeStart = 360127, XrefRangeEnd = 360172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool InternalAdd(GuidComponent guidComponent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) guidComponent)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr_InternalAdd_Private_Boolean_GuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360173, XrefRangeEnd = 360179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void InternalRemove(Il2CppSystem.Guid guid)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &guid
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr_InternalRemove_Private_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 360188, RefRangeEnd = 360190, XrefRangeStart = 360179, XrefRangeEnd = 360188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe GameObject ResolveGuidInternal(
    Il2CppSystem.Guid guid,
    Il2CppSystem.Action<GameObject> onAddCallback,
    Il2CppSystem.Action onRemoveCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &guid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onAddCallback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) onRemoveCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GuidManager.NativeMethodInfoPtr_ResolveGuidInternal_Private_GameObject_Guid_Action_1_GameObject_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num3);
  }

  public static unsafe GuidManager Instance
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(GuidManager.NativeFieldInfoPtr_Instance, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (GuidManager) null : Il2CppObjectPool.Get<GuidManager>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(GuidManager.NativeFieldInfoPtr_Instance, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Dictionary<Il2CppSystem.Guid, GuidManager.GuidInfo> guidToObjectMap
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidManager.NativeFieldInfoPtr_guidToObjectMap));
      return num == System.IntPtr.Zero ? (Dictionary<Il2CppSystem.Guid, GuidManager.GuidInfo>) null : Il2CppObjectPool.Get<Dictionary<Il2CppSystem.Guid, GuidManager.GuidInfo>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidManager.NativeFieldInfoPtr_guidToObjectMap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class GuidInfo : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_go;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnAdd;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnRemove;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_OnAdd_Public_add_Void_Action_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnAdd_Public_rem_Void_Action_1_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_add_OnRemove_Public_add_Void_Action_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_remove_OnRemove_Public_rem_Void_Action_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuidComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleAddCallback_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleRemoveCallback_Public_Void_0;

    static GuidInfo()
    {
      Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GuidManager>.NativeClassPtr, nameof (GuidInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr);
      GuidManager.GuidInfo.NativeFieldInfoPtr_go = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, nameof (go));
      GuidManager.GuidInfo.NativeFieldInfoPtr_OnAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, nameof (OnAdd));
      GuidManager.GuidInfo.NativeFieldInfoPtr_OnRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, nameof (OnRemove));
      GuidManager.GuidInfo.NativeMethodInfoPtr_add_OnAdd_Public_add_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, 100663315 /*0x06000013*/);
      GuidManager.GuidInfo.NativeMethodInfoPtr_remove_OnAdd_Public_rem_Void_Action_1_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, 100663316 /*0x06000014*/);
      GuidManager.GuidInfo.NativeMethodInfoPtr_add_OnRemove_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, 100663317 /*0x06000015*/);
      GuidManager.GuidInfo.NativeMethodInfoPtr_remove_OnRemove_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, 100663318 /*0x06000016*/);
      GuidManager.GuidInfo.NativeMethodInfoPtr__ctor_Public_Void_GuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, 100663319 /*0x06000017*/);
      GuidManager.GuidInfo.NativeMethodInfoPtr_HandleAddCallback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, 100663320 /*0x06000018*/);
      GuidManager.GuidInfo.NativeMethodInfoPtr_HandleRemoveCallback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr, 100663321 /*0x06000019*/);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 360040, RefRangeEnd = 360041, XrefRangeStart = 360035, XrefRangeEnd = 360040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_OnAdd(Il2CppSystem.Action<GameObject> value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidManager.GuidInfo.NativeMethodInfoPtr_add_OnAdd_Public_add_Void_Action_1_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360041, XrefRangeEnd = 360046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_OnAdd(Il2CppSystem.Action<GameObject> value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidManager.GuidInfo.NativeMethodInfoPtr_remove_OnAdd_Public_rem_Void_Action_1_GameObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 360050, RefRangeEnd = 360052, XrefRangeStart = 360046, XrefRangeEnd = 360050, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void add_OnRemove(Il2CppSystem.Action value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidManager.GuidInfo.NativeMethodInfoPtr_add_OnRemove_Public_add_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360052, XrefRangeEnd = 360056, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    [SpecialName]
    public unsafe void remove_OnRemove(Il2CppSystem.Action value)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidManager.GuidInfo.NativeMethodInfoPtr_remove_OnRemove_Public_rem_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360056, XrefRangeEnd = 360057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GuidInfo(GuidComponent comp)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) comp)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidManager.GuidInfo.NativeMethodInfoPtr__ctor_Public_Void_GuidComponent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void HandleAddCallback()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidManager.GuidInfo.NativeMethodInfoPtr_HandleAddCallback_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public unsafe void HandleRemoveCallback()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GuidManager.GuidInfo.NativeMethodInfoPtr_HandleRemoveCallback_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public GuidInfo(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public GuidInfo()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuidManager.GuidInfo>.NativeClassPtr))
    {
    }

    public unsafe GameObject go
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidManager.GuidInfo.NativeFieldInfoPtr_go));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidManager.GuidInfo.NativeFieldInfoPtr_go), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<GameObject> OnAdd
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidManager.GuidInfo.NativeFieldInfoPtr_OnAdd));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action<GameObject>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<GameObject>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidManager.GuidInfo.NativeFieldInfoPtr_OnAdd), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action OnRemove
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GuidManager.GuidInfo.NativeFieldInfoPtr_OnRemove));
        return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GuidManager.GuidInfo.NativeFieldInfoPtr_OnRemove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
