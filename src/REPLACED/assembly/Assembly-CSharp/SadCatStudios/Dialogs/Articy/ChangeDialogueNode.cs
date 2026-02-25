// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.ChangeDialogueNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced;
using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class ChangeDialogueNode(IntPtr pointer) : ArticyNode(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Jump;
  private static readonly IntPtr NativeFieldInfoPtr_NewGraph;
  private static readonly IntPtr NativeFieldInfoPtr_Previous;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ChangeDialogueNode()
  {
    Il2CppClassPointerStore<ChangeDialogueNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (ChangeDialogueNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeDialogueNode>.NativeClassPtr);
    ChangeDialogueNode.NativeFieldInfoPtr_Jump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeDialogueNode>.NativeClassPtr, nameof (Jump));
    ChangeDialogueNode.NativeFieldInfoPtr_NewGraph = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeDialogueNode>.NativeClassPtr, nameof (NewGraph));
    ChangeDialogueNode.NativeFieldInfoPtr_Previous = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeDialogueNode>.NativeClassPtr, nameof (Previous));
    ChangeDialogueNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeDialogueNode>.NativeClassPtr, 100672710);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102927, XrefRangeEnd = 102928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ChangeDialogueNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeDialogueNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ChangeDialogueNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Jump Jump
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeDialogueNode.NativeFieldInfoPtr_Jump));
      return num == IntPtr.Zero ? (Jump) null : Il2CppObjectPool.Get<Jump>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChangeDialogueNode.NativeFieldInfoPtr_Jump), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe FlowGraph NewGraph
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeDialogueNode.NativeFieldInfoPtr_NewGraph));
      return num == IntPtr.Zero ? (FlowGraph) null : Il2CppObjectPool.Get<FlowGraph>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChangeDialogueNode.NativeFieldInfoPtr_NewGraph), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyObject Previous
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeDialogueNode.NativeFieldInfoPtr_Previous));
      return num == IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChangeDialogueNode.NativeFieldInfoPtr_Previous), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
