// Decompiled with JetBrains decompiler
// Type: SadCatStudios.FSM.CommentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using XNode;

#nullable disable
namespace SadCatStudios.FSM;

public class CommentNode(IntPtr pointer) : Node(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Comment;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CommentNode()
  {
    Il2CppClassPointerStore<CommentNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.FSM", nameof (CommentNode));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommentNode>.NativeClassPtr);
    CommentNode.NativeFieldInfoPtr_Comment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommentNode>.NativeClassPtr, nameof (Comment));
    CommentNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommentNode>.NativeClassPtr, 100673242);
  }

  [CallerCount(86)]
  [CachedScanResults(RefRangeStart = 102928, RefRangeEnd = 103014, XrefRangeStart = 102928, XrefRangeEnd = 103014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CommentNode()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommentNode>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CommentNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string Comment
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CommentNode.NativeFieldInfoPtr_Comment)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CommentNode.NativeFieldInfoPtr_Comment), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
