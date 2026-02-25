// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.InitNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using XNode;

#nullable disable
namespace SadCatStudios.FSM;

public class InitNode(IntPtr pointer) : Node(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_startNode;
  private static readonly IntPtr NativeMethodInfoPtr_get_StartNode_Public_get_StateNode_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InitNode()
  {
    Il2CppClassPointerStore<InitNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (InitNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitNode>.NativeClassPtr);
    InitNode.NativeFieldInfoPtr_startNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitNode>.NativeClassPtr, nameof (startNode));
    InitNode.NativeMethodInfoPtr_get_StartNode_Public_get_StateNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitNode>.NativeClassPtr, 100673296);
    InitNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitNode>.NativeClassPtr, 100673297);
  }

  public unsafe StateNode StartNode
  {
    [CallerCount(11), CachedScanResults(RefRangeStart = 109396, RefRangeEnd = 109407, XrefRangeStart = 109390, XrefRangeEnd = 109396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InitNode.NativeMethodInfoPtr_get_StartNode_Public_get_StateNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (StateNode) null : Il2CppObjectPool.Get<StateNode>(num3);
    }
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InitNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InitNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StateNode startNode
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitNode.NativeFieldInfoPtr_startNode));
      return num == IntPtr.Zero ? (StateNode) null : Il2CppObjectPool.Get<StateNode>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitNode.NativeFieldInfoPtr_startNode), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
