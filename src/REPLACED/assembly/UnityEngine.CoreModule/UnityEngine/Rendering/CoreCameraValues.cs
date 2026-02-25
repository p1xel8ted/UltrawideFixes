// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.CoreCameraValues
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct CoreCameraValues
{
  private static readonly System.IntPtr NativeFieldInfoPtr_filterMode;
  private static readonly System.IntPtr NativeFieldInfoPtr_cullingMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_instanceID;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public int filterMode;
  [FieldOffset(4)]
  public uint cullingMask;
  [FieldOffset(8)]
  public int instanceID;

  static CoreCameraValues()
  {
    Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (CoreCameraValues));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr);
    CoreCameraValues.NativeFieldInfoPtr_filterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, nameof (filterMode));
    CoreCameraValues.NativeFieldInfoPtr_cullingMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, nameof (cullingMask));
    CoreCameraValues.NativeFieldInfoPtr_instanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, nameof (instanceID));
    CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100670335);
    CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100670336);
    CoreCameraValues.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, 100670337);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(CoreCameraValues other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CoreCameraValues_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487360, XrefRangeEnd = 487363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CoreCameraValues.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CoreCameraValues>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool operator ==(CoreCameraValues left, CoreCameraValues right)
  {
    return left.Equals(right);
  }

  public static bool operator !=(CoreCameraValues left, CoreCameraValues right)
  {
    return !left.Equals(right);
  }
}
