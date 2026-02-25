// Decompiled with JetBrains decompiler
// Type: SadCatStudios.MovementPhysics.PhysicsUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.MovementPhysics;

public static class PhysicsUtil : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_defaultMask;
  private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Static_Void_MoveUnit_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SnapToGround_Public_Static_Vector3_Vector3_Int32_0;

  static PhysicsUtil()
  {
    Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.MovementPhysics", nameof (PhysicsUtil));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr);
    PhysicsUtil.NativeFieldInfoPtr_defaultMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, nameof (defaultMask));
    PhysicsUtil.NativeMethodInfoPtr_Move_Public_Static_Void_MoveUnit_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, 100670979);
    PhysicsUtil.NativeMethodInfoPtr_SnapToGround_Public_Static_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsUtil>.NativeClassPtr, 100670980);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 90026, RefRangeEnd = 90029, XrefRangeStart = 90018, XrefRangeEnd = 90026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Move(MoveUnit moveUnit, ref Vector3 velocity)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &moveUnit;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref velocity;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhysicsUtil.NativeMethodInfoPtr_Move_Public_Static_Void_MoveUnit_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 90044, RefRangeEnd = 90057, XrefRangeStart = 90029, XrefRangeEnd = 90044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector3 SnapToGround(Vector3 pos, int maxLenght = 100)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxLenght;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PhysicsUtil.NativeMethodInfoPtr_SnapToGround_Public_Static_Vector3_Vector3_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public PhysicsUtil(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe LayerMask defaultMask
  {
    get
    {
      LayerMask defaultMask;
      IL2CPP.il2cpp_field_static_get_value(PhysicsUtil.NativeFieldInfoPtr_defaultMask, (void*) &defaultMask);
      return defaultMask;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PhysicsUtil.NativeFieldInfoPtr_defaultMask, (void*) &value);
    }
  }
}
