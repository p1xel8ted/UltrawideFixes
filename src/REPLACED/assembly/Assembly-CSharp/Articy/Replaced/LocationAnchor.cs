// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.LocationAnchor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Replaced;

[Serializable]
public class LocationAnchor(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mAnchorPositionX;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAnchorPositionY;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAnchorColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAnchorSize;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AnchorPositionX_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AnchorPositionX_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AnchorPositionY_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AnchorPositionY_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AnchorColor_Public_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AnchorColor_Public_set_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_AnchorSize_Public_get_LocationAnchorSize_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_AnchorSize_Public_set_Void_LocationAnchorSize_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static LocationAnchor()
  {
    Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (LocationAnchor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr);
    LocationAnchor.NativeFieldInfoPtr_mAnchorPositionX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, nameof (mAnchorPositionX));
    LocationAnchor.NativeFieldInfoPtr_mAnchorPositionY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, nameof (mAnchorPositionY));
    LocationAnchor.NativeFieldInfoPtr_mAnchorColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, nameof (mAnchorColor));
    LocationAnchor.NativeFieldInfoPtr_mAnchorSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, nameof (mAnchorSize));
    LocationAnchor.NativeMethodInfoPtr_get_AnchorPositionX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678406);
    LocationAnchor.NativeMethodInfoPtr_set_AnchorPositionX_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678407);
    LocationAnchor.NativeMethodInfoPtr_get_AnchorPositionY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678408);
    LocationAnchor.NativeMethodInfoPtr_set_AnchorPositionY_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678409);
    LocationAnchor.NativeMethodInfoPtr_get_AnchorColor_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678410);
    LocationAnchor.NativeMethodInfoPtr_set_AnchorColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678411);
    LocationAnchor.NativeMethodInfoPtr_get_AnchorSize_Public_get_LocationAnchorSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678412);
    LocationAnchor.NativeMethodInfoPtr_set_AnchorSize_Public_set_Void_LocationAnchorSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678413);
    LocationAnchor.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678414);
    LocationAnchor.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678415);
    LocationAnchor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr, 100678416);
  }

  public unsafe float AnchorPositionX
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_get_AnchorPositionX_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 136972, RefRangeEnd = 136973, XrefRangeStart = 136972, XrefRangeEnd = 136972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_set_AnchorPositionX_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float AnchorPositionY
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_get_AnchorPositionY_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 70589, RefRangeEnd = 70590, XrefRangeStart = 70589, XrefRangeEnd = 70590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_set_AnchorPositionY_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Color AnchorColor
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_get_AnchorColor_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_set_AnchorColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe LocationAnchorSize AnchorSize
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_get_AnchorSize_Public_get_LocationAnchorSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LocationAnchorSize*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 68964, RefRangeEnd = 68968, XrefRangeStart = 68964, XrefRangeEnd = 68968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_set_AnchorSize_Public_set_Void_LocationAnchorSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136973, XrefRangeEnd = 136975, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136975, XrefRangeEnd = 136981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LocationAnchor()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocationAnchor>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LocationAnchor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float mAnchorPositionX
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocationAnchor.NativeFieldInfoPtr_mAnchorPositionX));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocationAnchor.NativeFieldInfoPtr_mAnchorPositionX)) = value;
    }
  }

  public unsafe float mAnchorPositionY
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocationAnchor.NativeFieldInfoPtr_mAnchorPositionY));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocationAnchor.NativeFieldInfoPtr_mAnchorPositionY)) = value;
    }
  }

  public unsafe Color mAnchorColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocationAnchor.NativeFieldInfoPtr_mAnchorColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocationAnchor.NativeFieldInfoPtr_mAnchorColor)) = value;
    }
  }

  public unsafe LocationAnchorSize mAnchorSize
  {
    get
    {
      return *(LocationAnchorSize*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocationAnchor.NativeFieldInfoPtr_mAnchorSize));
    }
    [param: In] set
    {
      *(LocationAnchorSize*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocationAnchor.NativeFieldInfoPtr_mAnchorSize)) = value;
    }
  }
}
