// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.BridgeObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class BridgeObject(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_topPlane;
  private static readonly IntPtr NativeFieldInfoPtr_bottomPlane;
  private static readonly IntPtr NativeFieldInfoPtr_bridgeLinkingType;
  private static readonly IntPtr NativeMethodInfoPtr_get_TopPlane_Public_get_Plane_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_BottomPlane_Public_get_Plane_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static BridgeObject()
  {
    Il2CppClassPointerStore<BridgeObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (BridgeObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BridgeObject>.NativeClassPtr);
    BridgeObject.NativeFieldInfoPtr_topPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgeObject>.NativeClassPtr, nameof (topPlane));
    BridgeObject.NativeFieldInfoPtr_bottomPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgeObject>.NativeClassPtr, nameof (bottomPlane));
    BridgeObject.NativeFieldInfoPtr_bridgeLinkingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BridgeObject>.NativeClassPtr, nameof (bridgeLinkingType));
    BridgeObject.NativeMethodInfoPtr_get_TopPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeObject>.NativeClassPtr, 100675875);
    BridgeObject.NativeMethodInfoPtr_get_BottomPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeObject>.NativeClassPtr, 100675876);
    BridgeObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BridgeObject>.NativeClassPtr, 100675877);
  }

  public unsafe Plane TopPlane
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 120120, RefRangeEnd = 120122, XrefRangeStart = 120120, XrefRangeEnd = 120120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BridgeObject.NativeMethodInfoPtr_get_TopPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Plane*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Plane BottomPlane
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 120122, RefRangeEnd = 120125, XrefRangeStart = 120122, XrefRangeEnd = 120122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BridgeObject.NativeMethodInfoPtr_get_BottomPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Plane*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BridgeObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BridgeObject>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BridgeObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LayerPlane topPlane
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BridgeObject.NativeFieldInfoPtr_topPlane));
      return num == IntPtr.Zero ? (LayerPlane) null : Il2CppObjectPool.Get<LayerPlane>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BridgeObject.NativeFieldInfoPtr_topPlane), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerPlane bottomPlane
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BridgeObject.NativeFieldInfoPtr_bottomPlane));
      return num == IntPtr.Zero ? (LayerPlane) null : Il2CppObjectPool.Get<LayerPlane>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BridgeObject.NativeFieldInfoPtr_bottomPlane), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe BridgeObject.BridgeLinkingType bridgeLinkingType
  {
    get
    {
      return *(BridgeObject.BridgeLinkingType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BridgeObject.NativeFieldInfoPtr_bridgeLinkingType));
    }
    [param: In] set
    {
      *(BridgeObject.BridgeLinkingType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BridgeObject.NativeFieldInfoPtr_bridgeLinkingType)) = value;
    }
  }

  public enum BridgeLinkingType
  {
    ClimbingObject,
    PassageBridge,
  }
}
