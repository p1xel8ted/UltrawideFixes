// Decompiled with JetBrains decompiler
// Type: SadCatStudios.CameraMovement.CameraDebugFly
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
namespace SadCatStudios.CameraMovement;

public class CameraDebugFly(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_movementSpeed;
  private static readonly IntPtr NativeFieldInfoPtr_rotationSpeed;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_Single_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CameraDebugFly()
  {
    Il2CppClassPointerStore<CameraDebugFly>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.CameraMovement", nameof (CameraDebugFly));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraDebugFly>.NativeClassPtr);
    CameraDebugFly.NativeFieldInfoPtr_movementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugFly>.NativeClassPtr, nameof (movementSpeed));
    CameraDebugFly.NativeFieldInfoPtr_rotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraDebugFly>.NativeClassPtr, nameof (rotationSpeed));
    CameraDebugFly.NativeMethodInfoPtr_Init_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugFly>.NativeClassPtr, 100676310);
    CameraDebugFly.NativeMethodInfoPtr_UpdateTransform_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugFly>.NativeClassPtr, 100676311);
    CameraDebugFly.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraDebugFly>.NativeClassPtr, 100676312);
  }

  [CallerCount(0)]
  public unsafe void Init(float movementSpeed, float rotationSpeed)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &movementSpeed;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &rotationSpeed;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraDebugFly.NativeMethodInfoPtr_Init_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122785, XrefRangeEnd = 122813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void UpdateTransform(float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &deltaTime
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraDebugFly.NativeMethodInfoPtr_UpdateTransform_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122813, XrefRangeEnd = 122814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CameraDebugFly()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraDebugFly>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CameraDebugFly.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float movementSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugFly.NativeFieldInfoPtr_movementSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugFly.NativeFieldInfoPtr_movementSpeed)) = value;
    }
  }

  public unsafe float rotationSpeed
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugFly.NativeFieldInfoPtr_rotationSpeed));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CameraDebugFly.NativeFieldInfoPtr_rotationSpeed)) = value;
    }
  }
}
