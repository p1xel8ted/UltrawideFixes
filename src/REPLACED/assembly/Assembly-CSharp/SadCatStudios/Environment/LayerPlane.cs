// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.LayerPlane
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class LayerPlane(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__DirectionPlane_k__BackingField;
  private static readonly IntPtr NativeMethodInfoPtr_get_DirectionPlane_Public_get_Plane_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_DirectionPlane_Private_set_Void_Plane_0;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LayerPlane()
  {
    Il2CppClassPointerStore<LayerPlane>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (LayerPlane));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayerPlane>.NativeClassPtr);
    LayerPlane.NativeFieldInfoPtr__DirectionPlane_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayerPlane>.NativeClassPtr, "<DirectionPlane>k__BackingField");
    LayerPlane.NativeMethodInfoPtr_get_DirectionPlane_Public_get_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerPlane>.NativeClassPtr, 100676046);
    LayerPlane.NativeMethodInfoPtr_set_DirectionPlane_Private_set_Void_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerPlane>.NativeClassPtr, 100676047);
    LayerPlane.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerPlane>.NativeClassPtr, 100676048);
    LayerPlane.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayerPlane>.NativeClassPtr, 100676049);
  }

  public unsafe Plane DirectionPlane
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LayerPlane.NativeMethodInfoPtr_get_DirectionPlane_Public_get_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Plane*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LayerPlane.NativeMethodInfoPtr_set_DirectionPlane_Private_set_Void_Plane_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 120987, XrefRangeEnd = 120992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LayerPlane.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LayerPlane()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayerPlane>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LayerPlane.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Plane _DirectionPlane_k__BackingField
  {
    get
    {
      return *(Plane*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayerPlane.NativeFieldInfoPtr__DirectionPlane_k__BackingField));
    }
    [param: In] set
    {
      *(Plane*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LayerPlane.NativeFieldInfoPtr__DirectionPlane_k__BackingField)) = value;
    }
  }
}
