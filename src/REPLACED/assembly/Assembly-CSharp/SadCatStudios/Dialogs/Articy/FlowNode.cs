// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using XNode;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class FlowNode(System.IntPtr pointer) : ArticyNode(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_DialogueFragment;
  private static readonly System.IntPtr NativeFieldInfoPtr_Previous;
  private static readonly System.IntPtr NativeFieldInfoPtr_Next;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static FlowNode()
  {
    Il2CppClassPointerStore<FlowNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowNode>.NativeClassPtr);
    FlowNode.NativeFieldInfoPtr_DialogueFragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowNode>.NativeClassPtr, nameof (DialogueFragment));
    FlowNode.NativeFieldInfoPtr_Previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowNode>.NativeClassPtr, nameof (Previous));
    FlowNode.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowNode>.NativeClassPtr, nameof (Next));
    FlowNode.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowNode>.NativeClassPtr, 100672840);
    FlowNode.NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowNode>.NativeClassPtr, 100672841);
    FlowNode.NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowNode>.NativeClassPtr, 100672842);
    FlowNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowNode>.NativeClassPtr, 100672843);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104254, XrefRangeEnd = 104259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object GetValue(NodePort port)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) port)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowNode.NativeMethodInfoPtr_GetValue_Public_Virtual_Object_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104259, XrefRangeEnd = 104261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnCreateConnection(NodePort from, NodePort to)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) from);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) to);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowNode.NativeMethodInfoPtr_OnCreateConnection_Public_Virtual_Void_NodePort_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104261, XrefRangeEnd = 104266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnRemoveConnection(NodePort port)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) port)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FlowNode.NativeMethodInfoPtr_OnRemoveConnection_Public_Virtual_Void_NodePort_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlowNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlowNode>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlowNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyRef DialogueFragment
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowNode.NativeFieldInfoPtr_DialogueFragment));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowNode.NativeFieldInfoPtr_DialogueFragment), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef Previous
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowNode.NativeFieldInfoPtr_Previous));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowNode.NativeFieldInfoPtr_Previous), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyRef Next
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FlowNode.NativeFieldInfoPtr_Next));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FlowNode.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
