// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.Utils.Bolt.ScalableRaycastedZone
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
namespace Replaced.Scripts.Utils.Bolt;

public class ScalableRaycastedZone(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_raycastOrigin;
  private static readonly IntPtr NativeFieldInfoPtr_activeMaxHeight;
  private static readonly IntPtr NativeFieldInfoPtr_visibilityRenderer;
  private static readonly IntPtr NativeFieldInfoPtr_radius;
  private static readonly IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly IntPtr NativeFieldInfoPtr_scaleY;
  private static readonly IntPtr NativeFieldInfoPtr_passthrough;
  private static readonly IntPtr NativeFieldInfoPtr_passthroughTag;
  private static readonly IntPtr NativeFieldInfoPtr_raycastHit;
  private static readonly IntPtr NativeMethodInfoPtr_ScaleForward_Private_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ScalableRaycastedZone()
  {
    Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.Utils.Bolt", nameof (ScalableRaycastedZone));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr);
    ScalableRaycastedZone.NativeFieldInfoPtr_raycastOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (raycastOrigin));
    ScalableRaycastedZone.NativeFieldInfoPtr_activeMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (activeMaxHeight));
    ScalableRaycastedZone.NativeFieldInfoPtr_visibilityRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (visibilityRenderer));
    ScalableRaycastedZone.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (radius));
    ScalableRaycastedZone.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (layerMask));
    ScalableRaycastedZone.NativeFieldInfoPtr_scaleY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (scaleY));
    ScalableRaycastedZone.NativeFieldInfoPtr_passthrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (passthrough));
    ScalableRaycastedZone.NativeFieldInfoPtr_passthroughTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (passthroughTag));
    ScalableRaycastedZone.NativeFieldInfoPtr_raycastHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, nameof (raycastHit));
    ScalableRaycastedZone.NativeMethodInfoPtr_ScaleForward_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, 100670642);
    ScalableRaycastedZone.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, 100670643);
    ScalableRaycastedZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr, 100670644);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86890, XrefRangeEnd = 86900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ScaleForward(float scale)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &scale
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScalableRaycastedZone.NativeMethodInfoPtr_ScaleForward_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86900, XrefRangeEnd = 86924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScalableRaycastedZone.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86924, XrefRangeEnd = 86925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScalableRaycastedZone()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScalableRaycastedZone>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScalableRaycastedZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Transform raycastOrigin
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_raycastOrigin));
      return num == IntPtr.Zero ? (Transform) null : Il2CppObjectPool.Get<Transform>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_raycastOrigin), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float activeMaxHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_activeMaxHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_activeMaxHeight)) = value;
    }
  }

  public unsafe Renderer visibilityRenderer
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_visibilityRenderer));
      return num == IntPtr.Zero ? (Renderer) null : Il2CppObjectPool.Get<Renderer>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_visibilityRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float radius
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_radius));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_radius)) = value;
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe bool scaleY
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_scaleY));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_scaleY)) = value;
    }
  }

  public unsafe bool passthrough
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_passthrough));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_passthrough)) = value;
    }
  }

  public unsafe string passthroughTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_passthroughTag)));
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_passthroughTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe RaycastHit raycastHit
  {
    get
    {
      return *(RaycastHit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_raycastHit));
    }
    [param: In] set
    {
      *(RaycastHit*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScalableRaycastedZone.NativeFieldInfoPtr_raycastHit)) = value;
    }
  }
}
