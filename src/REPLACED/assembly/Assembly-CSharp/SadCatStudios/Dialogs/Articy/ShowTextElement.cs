// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.ShowTextElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Dialogs.Articy.PC;
using System;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

[Serializable]
public class ShowTextElement(IntPtr pointer) : FlowElement(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_PCFlowPlayer_0;

  static ShowTextElement()
  {
    Il2CppClassPointerStore<ShowTextElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (ShowTextElement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTextElement>.NativeClassPtr);
    ShowTextElement.NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextElement>.NativeClassPtr, 100672848);
    ShowTextElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextElement>.NativeClassPtr, 100672849);
    ShowTextElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_PCFlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTextElement>.NativeClassPtr, 100672850);
  }

  [CallerCount(125)]
  [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShowTextElement(ArticyNode node)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTextElement>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ShowTextElement.NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104273, XrefRangeEnd = 104280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe FlowHandler GetHandler(FlowPlayer player)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTextElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (FlowHandler) null : Il2CppObjectPool.Get<FlowHandler>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104280, XrefRangeEnd = 104284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe FlowHandler GetHandler(PCFlowPlayer player)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTextElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_PCFlowPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (FlowHandler) null : Il2CppObjectPool.Get<FlowHandler>(num3);
  }
}
