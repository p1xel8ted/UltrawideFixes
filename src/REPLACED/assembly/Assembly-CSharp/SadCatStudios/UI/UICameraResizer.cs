// Decompiled with JetBrains decompiler
// Type: SadCatStudios.UI.UICameraResizer
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
namespace SadCatStudios.UI;

public class UICameraResizer(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_screenMaterial;
  private static readonly IntPtr NativeFieldInfoPtr_theCamera;
  private static readonly IntPtr NativeFieldInfoPtr_renderTexture;
  private static readonly IntPtr NativeFieldInfoPtr_screenSize;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Resize_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UICameraResizer()
  {
    Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.UI", nameof (UICameraResizer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr);
    UICameraResizer.NativeFieldInfoPtr_screenMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr, nameof (screenMaterial));
    UICameraResizer.NativeFieldInfoPtr_theCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr, nameof (theCamera));
    UICameraResizer.NativeFieldInfoPtr_renderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr, nameof (renderTexture));
    UICameraResizer.NativeFieldInfoPtr_screenSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr, nameof (screenSize));
    UICameraResizer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr, 100672151);
    UICameraResizer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr, 100672152);
    UICameraResizer.NativeMethodInfoPtr_Resize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr, 100672153);
    UICameraResizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr, 100672154);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98616, XrefRangeEnd = 98622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UICameraResizer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98622, XrefRangeEnd = 98627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LateUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UICameraResizer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 98643, RefRangeEnd = 98645, XrefRangeStart = 98627, XrefRangeEnd = 98643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Resize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UICameraResizer.NativeMethodInfoPtr_Resize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UICameraResizer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UICameraResizer>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UICameraResizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Material screenMaterial
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICameraResizer.NativeFieldInfoPtr_screenMaterial));
      return num == IntPtr.Zero ? (Material) null : Il2CppObjectPool.Get<Material>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICameraResizer.NativeFieldInfoPtr_screenMaterial), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Camera theCamera
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICameraResizer.NativeFieldInfoPtr_theCamera));
      return num == IntPtr.Zero ? (Camera) null : Il2CppObjectPool.Get<Camera>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICameraResizer.NativeFieldInfoPtr_theCamera), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe RenderTexture renderTexture
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICameraResizer.NativeFieldInfoPtr_renderTexture));
      return num == IntPtr.Zero ? (RenderTexture) null : Il2CppObjectPool.Get<RenderTexture>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UICameraResizer.NativeFieldInfoPtr_renderTexture), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Vector2 screenSize
  {
    get
    {
      return *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICameraResizer.NativeFieldInfoPtr_screenSize));
    }
    [param: In] set
    {
      *(Vector2*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UICameraResizer.NativeFieldInfoPtr_screenSize)) = value;
    }
  }
}
