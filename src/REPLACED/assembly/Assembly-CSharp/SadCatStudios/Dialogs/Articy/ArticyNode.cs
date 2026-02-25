// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.ArticyNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public class ArticyNode(IntPtr pointer) : XNode.Node(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_ArticyID;
  private static readonly IntPtr NativeFieldInfoPtr_FlowElementBlocks;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static ArticyNode()
  {
    Il2CppClassPointerStore<ArticyNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (ArticyNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyNode>.NativeClassPtr);
    ArticyNode.NativeFieldInfoPtr_ArticyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNode>.NativeClassPtr, nameof (ArticyID));
    ArticyNode.NativeFieldInfoPtr_FlowElementBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyNode>.NativeClassPtr, nameof (FlowElementBlocks));
    ArticyNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyNode>.NativeClassPtr, 100672839);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong ArticyID
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNode.NativeFieldInfoPtr_ArticyID));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNode.NativeFieldInfoPtr_ArticyID)) = value;
    }
  }

  public unsafe List<FlowElementBlock> FlowElementBlocks
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyNode.NativeFieldInfoPtr_FlowElementBlocks));
      return num == IntPtr.Zero ? (List<FlowElementBlock>) null : Il2CppObjectPool.Get<List<FlowElementBlock>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyNode.NativeFieldInfoPtr_FlowElementBlocks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
