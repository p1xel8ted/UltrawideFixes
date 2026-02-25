// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.FlowSequenceParser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

public static class FlowSequenceParser : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_callRegex;
  private static readonly System.IntPtr NativeMethodInfoPtr_Parse_Public_Static_List_1_FlowElement_String_String_0;

  static FlowSequenceParser()
  {
    Il2CppClassPointerStore<FlowSequenceParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (FlowSequenceParser));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlowSequenceParser>.NativeClassPtr);
    FlowSequenceParser.NativeFieldInfoPtr_callRegex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlowSequenceParser>.NativeClassPtr, nameof (callRegex));
    FlowSequenceParser.NativeMethodInfoPtr_Parse_Public_Static_List_1_FlowElement_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlowSequenceParser>.NativeClassPtr, 100672923);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104859, XrefRangeEnd = 104906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe List<FlowElement> Parse(string flowElementsText, string nodeName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(flowElementsText);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(nodeName);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlowSequenceParser.NativeMethodInfoPtr_Parse_Public_Static_List_1_FlowElement_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<FlowElement>) null : Il2CppObjectPool.Get<List<FlowElement>>(num3);
  }

  public FlowSequenceParser(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Regex callRegex
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(FlowSequenceParser.NativeFieldInfoPtr_callRegex, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Regex) null : Il2CppObjectPool.Get<Regex>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlowSequenceParser.NativeFieldInfoPtr_callRegex, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
