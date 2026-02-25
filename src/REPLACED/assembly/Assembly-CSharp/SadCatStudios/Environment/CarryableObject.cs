// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Environment.CarryableObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using SadCatStudios.Character;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Environment;

public class CarryableObject(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_anchorOffset;
  private static readonly IntPtr NativeFieldInfoPtr_anchorRotation;
  private static readonly IntPtr NativeMethodInfoPtr_get_AnchorOffset_Public_get_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_AnchorRotation_Public_get_Quaternion_0;
  private static readonly IntPtr NativeMethodInfoPtr_Snap_Public_Abstract_Virtual_New_Void_CharacterCarryingController_0;
  private static readonly IntPtr NativeMethodInfoPtr_Drop_Public_Abstract_Virtual_New_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

  static CarryableObject()
  {
    Il2CppClassPointerStore<CarryableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Environment", nameof (CarryableObject));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr);
    CarryableObject.NativeFieldInfoPtr_anchorOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr, nameof (anchorOffset));
    CarryableObject.NativeFieldInfoPtr_anchorRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr, nameof (anchorRotation));
    CarryableObject.NativeMethodInfoPtr_get_AnchorOffset_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr, 100675935);
    CarryableObject.NativeMethodInfoPtr_get_AnchorRotation_Public_get_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr, 100675936);
    CarryableObject.NativeMethodInfoPtr_Snap_Public_Abstract_Virtual_New_Void_CharacterCarryingController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr, 100675937);
    CarryableObject.NativeMethodInfoPtr_Drop_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr, 100675938);
    CarryableObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr, 100675939);
  }

  public unsafe Vector3 AnchorOffset
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarryableObject.NativeMethodInfoPtr_get_AnchorOffset_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe Quaternion AnchorRotation
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CarryableObject.NativeMethodInfoPtr_get_AnchorRotation_Public_get_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Quaternion*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe void Snap(CharacterCarryingController carryingController)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) carryingController)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CarryableObject.NativeMethodInfoPtr_Snap_Public_Abstract_Virtual_New_Void_CharacterCarryingController_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Drop()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CarryableObject.NativeMethodInfoPtr_Drop_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CarryableObject()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CarryableObject>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CarryableObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 anchorOffset
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarryableObject.NativeFieldInfoPtr_anchorOffset));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarryableObject.NativeFieldInfoPtr_anchorOffset)) = value;
    }
  }

  public unsafe Quaternion anchorRotation
  {
    get
    {
      return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarryableObject.NativeFieldInfoPtr_anchorRotation));
    }
    [param: In] set
    {
      *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CarryableObject.NativeFieldInfoPtr_anchorRotation)) = value;
    }
  }
}
