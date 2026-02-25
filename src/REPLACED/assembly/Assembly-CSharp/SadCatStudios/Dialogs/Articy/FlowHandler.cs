// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced;
using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using SadCatStudios.Dialogs.Articy.PC;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowHandler(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_dialogueFragment;
  private static readonly System.IntPtr NativeFieldInfoPtr_element;
  private static readonly System.IntPtr NativeFieldInfoPtr_flowPlayer;
  private static readonly System.IntPtr NativeFieldInfoPtr_pcFlowPlayer;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_FlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_PCFlowPlayer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_DialogueFragment_FlowElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_UniTask_CancellationToken_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Skip_Public_Abstract_Virtual_New_Void_0;

  static FlowHandler()
  {
    Il2CppClassPointerStore<FlowHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowHandler));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr);
    FlowHandler.NativeFieldInfoPtr_dialogueFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, nameof (dialogueFragment));
    FlowHandler.NativeFieldInfoPtr_element = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, nameof (element));
    FlowHandler.NativeFieldInfoPtr_flowPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, nameof (flowPlayer));
    FlowHandler.NativeFieldInfoPtr_pcFlowPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, nameof (pcFlowPlayer));
    FlowHandler.NativeMethodInfoPtr__ctor_Protected_Void_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, 100672763);
    FlowHandler.NativeMethodInfoPtr__ctor_Protected_Void_PCFlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, 100672764);
    FlowHandler.NativeMethodInfoPtr_Init_Public_Void_DialogueFragment_FlowElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, 100672765);
    FlowHandler.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_UniTask_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, 100672766);
    FlowHandler.NativeMethodInfoPtr_Skip_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr, 100672767);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowHandler(FlowPlayer player)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowHandler.NativeMethodInfoPtr__ctor_Protected_Void_FlowPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 103076, RefRangeEnd = 103079, XrefRangeStart = 103076, XrefRangeEnd = 103079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowHandler(PCFlowPlayer player)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowHandler>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowHandler.NativeMethodInfoPtr__ctor_Protected_Void_PCFlowPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 103343, RefRangeEnd = 103357, XrefRangeStart = 103343, XrefRangeEnd = 103343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(DialogueFragment dialogueFragment, FlowElement element)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) dialogueFragment);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) element);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowHandler.NativeMethodInfoPtr_Init_Public_Void_DialogueFragment_FlowElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe UniTask Play(CancellationToken cancel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) cancel))
    };
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowHandler.NativeMethodInfoPtr_Play_Public_Abstract_Virtual_New_UniTask_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UniTask(pointer);
  }

  [CallerCount(0)]
  public virtual unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowHandler.NativeMethodInfoPtr_Skip_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DialogueFragment dialogueFragment
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowHandler.NativeFieldInfoPtr_dialogueFragment));
      return num == System.IntPtr.Zero ? (DialogueFragment) null : Il2CppObjectPool.Get<DialogueFragment>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowHandler.NativeFieldInfoPtr_dialogueFragment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowElement element
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowHandler.NativeFieldInfoPtr_element));
      return num == System.IntPtr.Zero ? (FlowElement) null : Il2CppObjectPool.Get<FlowElement>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowHandler.NativeFieldInfoPtr_element), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowPlayer flowPlayer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowHandler.NativeFieldInfoPtr_flowPlayer));
      return num == System.IntPtr.Zero ? (FlowPlayer) null : Il2CppObjectPool.Get<FlowPlayer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowHandler.NativeFieldInfoPtr_flowPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe PCFlowPlayer pcFlowPlayer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowHandler.NativeFieldInfoPtr_pcFlowPlayer));
      return num == System.IntPtr.Zero ? (PCFlowPlayer) null : Il2CppObjectPool.Get<PCFlowPlayer>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowHandler.NativeFieldInfoPtr_pcFlowPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
