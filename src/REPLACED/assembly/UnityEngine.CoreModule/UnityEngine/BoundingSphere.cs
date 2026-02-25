// Decompiled with JetBrains decompiler
// Type: UnityEngine.BoundingSphere
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct BoundingSphere
{
  private static readonly System.IntPtr NativeFieldInfoPtr_position;
  private static readonly System.IntPtr NativeFieldInfoPtr_radius;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0;
  [FieldOffset(0)]
  public Vector3 position;
  [FieldOffset(12)]
  public float radius;

  static BoundingSphere()
  {
    Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BoundingSphere));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr);
    BoundingSphere.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, nameof (position));
    BoundingSphere.NativeFieldInfoPtr_radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, nameof (radius));
    BoundingSphere.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, 100664357);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 419634, RefRangeEnd = 419636, XrefRangeStart = 419634, XrefRangeEnd = 419634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BoundingSphere(Vector3 pos, float rad)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &pos;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rad;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BoundingSphere.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundingSphere>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
