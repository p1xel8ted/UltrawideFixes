// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowGameObjectHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using SadCatStudios.Dialogs.Articy.PC;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowGameObjectHandler(System.IntPtr pointer) : FlowHandler(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_PCFlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddOnEnded_Private_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOnEnded_Private_Void_UnityAction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Virtual_Void_0;

  static FlowGameObjectHandler()
  {
    Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowGameObjectHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr);
    FlowGameObjectHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr, 100672755);
    FlowGameObjectHandler.NativeMethodInfoPtr__ctor_Public_Void_PCFlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr, 100672756);
    FlowGameObjectHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr, 100672757);
    FlowGameObjectHandler.NativeMethodInfoPtr_AddOnEnded_Private_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr, 100672758);
    FlowGameObjectHandler.NativeMethodInfoPtr_RemoveOnEnded_Private_Void_UnityAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr, 100672759);
    FlowGameObjectHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr, 100672760);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowGameObjectHandler(FlowPlayer player)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowGameObjectHandler.NativeMethodInfoPtr__ctor_Public_Void_FlowPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 103076, RefRangeEnd = 103079, XrefRangeStart = 103076, XrefRangeEnd = 103079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowGameObjectHandler(PCFlowPlayer player)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowGameObjectHandler.NativeMethodInfoPtr__ctor_Public_Void_PCFlowPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103304, XrefRangeEnd = 103329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowGameObjectHandler.NativeMethodInfoPtr_Play_Public_Virtual_UniTask_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103329, XrefRangeEnd = 103336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void AddOnEnded(UnityAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowGameObjectHandler.NativeMethodInfoPtr_AddOnEnded_Private_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103336, XrefRangeEnd = 103343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RemoveOnEnded(UnityAction action)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowGameObjectHandler.NativeMethodInfoPtr_RemoveOnEnded_Private_Void_UnityAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowGameObjectHandler.NativeMethodInfoPtr_Skip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [ObfuscatedName("SadCatStudios.Dialogs.Articy.FlowGameObjectHandler+<>c__DisplayClass2_0")]
  public sealed class __c__DisplayClass2_0(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_gameObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_activate;
    private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

    static __c__DisplayClass2_0()
    {
      Il2CppClassPointerStore<FlowGameObjectHandler.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FlowGameObjectHandler>.NativeClassPtr, "<>c__DisplayClass2_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowGameObjectHandler.__c__DisplayClass2_0>.NativeClassPtr);
      FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_gameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGameObjectHandler.__c__DisplayClass2_0>.NativeClassPtr, nameof (gameObject));
      FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_activate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGameObjectHandler.__c__DisplayClass2_0>.NativeClassPtr, nameof (activate));
      FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowGameObjectHandler.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
      FlowGameObjectHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGameObjectHandler.__c__DisplayClass2_0>.NativeClassPtr, 100672761);
      FlowGameObjectHandler.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowGameObjectHandler.__c__DisplayClass2_0>.NativeClassPtr, 100672762);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c__DisplayClass2_0()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowGameObjectHandler.__c__DisplayClass2_0>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowGameObjectHandler.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 103290, XrefRangeEnd = 103304, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Method_Internal_Void_PDM_0()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(FlowGameObjectHandler.__c__DisplayClass2_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe GameObject gameObject
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_gameObject));
        return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_gameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool activate
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_activate));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr_activate)) = value;
      }
    }

    public unsafe FlowGameObjectHandler __4__this
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
        return num == System.IntPtr.Zero ? (FlowGameObjectHandler) null : Il2CppObjectPool.Get<FlowGameObjectHandler>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowGameObjectHandler.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
