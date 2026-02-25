// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.BoltUnityEventElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Dialogs.Articy.PC;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

[Serializable]
public class BoltUnityEventElement(IntPtr pointer) : FlowElement(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_SendTo;
  private static readonly IntPtr NativeFieldInfoPtr_EventName;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_PCFlowPlayer_0;

  static BoltUnityEventElement()
  {
    Il2CppClassPointerStore<BoltUnityEventElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (BoltUnityEventElement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoltUnityEventElement>.NativeClassPtr);
    BoltUnityEventElement.NativeFieldInfoPtr_SendTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoltUnityEventElement>.NativeClassPtr, nameof (SendTo));
    BoltUnityEventElement.NativeFieldInfoPtr_EventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoltUnityEventElement>.NativeClassPtr, nameof (EventName));
    BoltUnityEventElement.NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoltUnityEventElement>.NativeClassPtr, 100672877);
    BoltUnityEventElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoltUnityEventElement>.NativeClassPtr, 100672878);
    BoltUnityEventElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_PCFlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoltUnityEventElement>.NativeClassPtr, 100672879);
  }

  [CallerCount(125)]
  [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoltUnityEventElement(ArticyNode node)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoltUnityEventElement>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BoltUnityEventElement.NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104359, XrefRangeEnd = 104363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe FlowHandler GetHandler(FlowPlayer player)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BoltUnityEventElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (FlowHandler) null : Il2CppObjectPool.Get<FlowHandler>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104363, XrefRangeEnd = 104367, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe FlowHandler GetHandler(PCFlowPlayer player)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BoltUnityEventElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_PCFlowPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (FlowHandler) null : Il2CppObjectPool.Get<FlowHandler>(num3);
  }

  public unsafe GuidReference SendTo
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BoltUnityEventElement.NativeFieldInfoPtr_SendTo));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BoltUnityEventElement.NativeFieldInfoPtr_SendTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string EventName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BoltUnityEventElement.NativeFieldInfoPtr_EventName)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BoltUnityEventElement.NativeFieldInfoPtr_EventName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
