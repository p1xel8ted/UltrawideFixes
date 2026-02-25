// Decompiled with JetBrains decompiler
// Type: Articy.Unity.PreviewImage
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class PreviewImage(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mViewBoxX;
  private static readonly System.IntPtr NativeFieldInfoPtr_mViewBoxY;
  private static readonly System.IntPtr NativeFieldInfoPtr_mViewBoxWidth;
  private static readonly System.IntPtr NativeFieldInfoPtr_mViewBoxHeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_mMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAsset;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ViewBox_Public_get_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ViewBox_Public_set_Void_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Mode_Public_get_PreviewImageViewBoxModes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Mode_Public_set_Void_PreviewImageViewBoxModes_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Asset_Public_get_IAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Asset_Public_set_Void_IAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PreviewImage()
  {
    Il2CppClassPointerStore<PreviewImage>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (PreviewImage));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr);
    PreviewImage.NativeFieldInfoPtr_mViewBoxX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, nameof (mViewBoxX));
    PreviewImage.NativeFieldInfoPtr_mViewBoxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, nameof (mViewBoxY));
    PreviewImage.NativeFieldInfoPtr_mViewBoxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, nameof (mViewBoxWidth));
    PreviewImage.NativeFieldInfoPtr_mViewBoxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, nameof (mViewBoxHeight));
    PreviewImage.NativeFieldInfoPtr_mMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, nameof (mMode));
    PreviewImage.NativeFieldInfoPtr_mAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, nameof (mAsset));
    PreviewImage.NativeMethodInfoPtr_get_ViewBox_Public_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664285);
    PreviewImage.NativeMethodInfoPtr_set_ViewBox_Public_set_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664286);
    PreviewImage.NativeMethodInfoPtr_get_Mode_Public_get_PreviewImageViewBoxModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664287);
    PreviewImage.NativeMethodInfoPtr_set_Mode_Public_set_Void_PreviewImageViewBoxModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664288 /*0x060003E0*/);
    PreviewImage.NativeMethodInfoPtr_get_Asset_Public_get_IAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664289);
    PreviewImage.NativeMethodInfoPtr_set_Asset_Public_set_Void_IAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664290);
    PreviewImage.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664291);
    PreviewImage.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664292);
    PreviewImage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr, 100664293);
  }

  public unsafe Rect ViewBox
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr_get_ViewBox_Public_get_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr_set_ViewBox_Public_set_Void_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe PreviewImageViewBoxModes Mode
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr_get_Mode_Public_get_PreviewImageViewBoxModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(PreviewImageViewBoxModes*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr_set_Mode_Public_set_Void_PreviewImageViewBoxModes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe IAsset Asset
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 998189, RefRangeEnd = 998191, XrefRangeStart = 998184, XrefRangeEnd = 998189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr_get_Asset_Public_get_IAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IAsset) null : Il2CppObjectPool.Get<IAsset>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998191, XrefRangeEnd = 998196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr_set_Asset_Public_set_Void_IAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998196, XrefRangeEnd = 998206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 998206, XrefRangeEnd = 998224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 998229, RefRangeEnd = 998234, XrefRangeStart = 998224, XrefRangeEnd = 998229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PreviewImage()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PreviewImage>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PreviewImage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float mViewBoxX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mViewBoxX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mViewBoxX)) = value;
    }
  }

  public unsafe float mViewBoxY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mViewBoxY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mViewBoxY)) = value;
    }
  }

  public unsafe float mViewBoxWidth
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mViewBoxWidth));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mViewBoxWidth)) = value;
    }
  }

  public unsafe float mViewBoxHeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mViewBoxHeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mViewBoxHeight)) = value;
    }
  }

  public unsafe PreviewImageViewBoxModes mMode
  {
    get
    {
      return *(PreviewImageViewBoxModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mMode));
    }
    [param: In] set
    {
      *(PreviewImageViewBoxModes*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mMode)) = value;
    }
  }

  public unsafe ArticyValueArticyObject mAsset
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mAsset));
      return num == System.IntPtr.Zero ? (ArticyValueArticyObject) null : Il2CppObjectPool.Get<ArticyValueArticyObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PreviewImage.NativeFieldInfoPtr_mAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
