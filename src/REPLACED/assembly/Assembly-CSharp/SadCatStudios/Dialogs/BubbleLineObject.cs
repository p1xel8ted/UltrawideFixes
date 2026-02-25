// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.BubbleLineObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Dialogs;

public class BubbleLineObject(IntPtr pointer) : ScriptableObject(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_sourceId;
  private static readonly IntPtr NativeFieldInfoPtr_lines;
  private static readonly IntPtr NativeMethodInfoPtr_get_SourceId_Public_get_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Lines_Public_get_List_1_DialogLine_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BubbleLineObject()
  {
    Il2CppClassPointerStore<BubbleLineObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs", nameof (BubbleLineObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BubbleLineObject>.NativeClassPtr);
    BubbleLineObject.NativeFieldInfoPtr_sourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BubbleLineObject>.NativeClassPtr, nameof (sourceId));
    BubbleLineObject.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BubbleLineObject>.NativeClassPtr, nameof (lines));
    BubbleLineObject.NativeMethodInfoPtr_get_SourceId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleLineObject>.NativeClassPtr, 100672623);
    BubbleLineObject.NativeMethodInfoPtr_get_Lines_Public_get_List_1_DialogLine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleLineObject>.NativeClassPtr, 100672624);
    BubbleLineObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BubbleLineObject>.NativeClassPtr, 100672625);
  }

  public unsafe string SourceId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BubbleLineObject.NativeMethodInfoPtr_get_SourceId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe List<DialogLine> Lines
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 68960, RefRangeEnd = 68964, XrefRangeStart = 68960, XrefRangeEnd = 68964, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BubbleLineObject.NativeMethodInfoPtr_get_Lines_Public_get_List_1_DialogLine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (List<DialogLine>) null : Il2CppObjectPool.Get<List<DialogLine>>(num3);
    }
  }

  [CallerCount(45)]
  [CachedScanResults(RefRangeStart = 69132, RefRangeEnd = 69177, XrefRangeStart = 69132, XrefRangeEnd = 69177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BubbleLineObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BubbleLineObject>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BubbleLineObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StringVariable sourceId
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BubbleLineObject.NativeFieldInfoPtr_sourceId));
      return num == IntPtr.Zero ? (StringVariable) null : Il2CppObjectPool.Get<StringVariable>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BubbleLineObject.NativeFieldInfoPtr_sourceId), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe List<DialogLine> lines
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BubbleLineObject.NativeFieldInfoPtr_lines));
      return num == IntPtr.Zero ? (List<DialogLine>) null : Il2CppObjectPool.Get<List<DialogLine>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BubbleLineObject.NativeFieldInfoPtr_lines), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
