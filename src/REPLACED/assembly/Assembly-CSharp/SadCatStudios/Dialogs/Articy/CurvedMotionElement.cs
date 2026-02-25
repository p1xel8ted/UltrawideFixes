// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Dialogs.Articy.CurvedMotionElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Animation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Dialogs.Articy;

[Serializable]
public class CurvedMotionElement(IntPtr pointer) : FlowElement(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_MovingCharacter;
  private static readonly IntPtr NativeFieldInfoPtr_Waypoint;
  private static readonly IntPtr NativeFieldInfoPtr_MoveClip;
  private static readonly IntPtr NativeFieldInfoPtr_MotionCurve;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0;
  private static readonly IntPtr NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0;

  static CurvedMotionElement()
  {
    Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Dialogs.Articy", nameof (CurvedMotionElement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr);
    CurvedMotionElement.NativeFieldInfoPtr_MovingCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr, nameof (MovingCharacter));
    CurvedMotionElement.NativeFieldInfoPtr_Waypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr, nameof (Waypoint));
    CurvedMotionElement.NativeFieldInfoPtr_MoveClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr, nameof (MoveClip));
    CurvedMotionElement.NativeFieldInfoPtr_MotionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr, nameof (MotionCurve));
    CurvedMotionElement.NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr, 100672866);
    CurvedMotionElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr, 100672867);
  }

  [CallerCount(125)]
  [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CurvedMotionElement(ArticyNode node)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedMotionElement>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) node)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CurvedMotionElement.NativeMethodInfoPtr__ctor_Public_Void_ArticyNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104331, XrefRangeEnd = 104335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe FlowHandler GetHandler(FlowPlayer player)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) player)
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CurvedMotionElement.NativeMethodInfoPtr_GetHandler_Public_Virtual_FlowHandler_FlowPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (FlowHandler) null : Il2CppObjectPool.Get<FlowHandler>(num3);
  }

  public unsafe GuidReference MovingCharacter
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionElement.NativeFieldInfoPtr_MovingCharacter));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionElement.NativeFieldInfoPtr_MovingCharacter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GuidReference Waypoint
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionElement.NativeFieldInfoPtr_Waypoint));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionElement.NativeFieldInfoPtr_Waypoint), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe MeshClip MoveClip
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionElement.NativeFieldInfoPtr_MoveClip));
      return num == IntPtr.Zero ? (MeshClip) null : Il2CppObjectPool.Get<MeshClip>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionElement.NativeFieldInfoPtr_MoveClip), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe AnimationCurve MotionCurve
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionElement.NativeFieldInfoPtr_MotionCurve));
      return num == IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMotionElement.NativeFieldInfoPtr_MotionCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
