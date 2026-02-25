// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchPackedCullingViewID
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
public struct BatchPackedCullingViewID
{
  private static readonly System.IntPtr NativeFieldInfoPtr_handle;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  [FieldOffset(0)]
  public ulong handle;

  static BatchPackedCullingViewID()
  {
    Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchPackedCullingViewID));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr);
    BatchPackedCullingViewID.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, nameof (handle));
    BatchPackedCullingViewID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100670288);
    BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100670289);
    BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100670290);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487096, XrefRangeEnd = 487097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 328469, RefRangeEnd = 328475, XrefRangeStart = 328469, XrefRangeEnd = 328475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(BatchPackedCullingViewID other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487097, XrefRangeEnd = 487100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool operator ==(BatchPackedCullingViewID lhs, BatchPackedCullingViewID rhs)
  {
    return lhs.Equals(rhs);
  }

  public static bool operator !=(BatchPackedCullingViewID lhs, BatchPackedCullingViewID rhs)
  {
    return !lhs.Equals(rhs);
  }

  public int GetInstanceID() => (int) ((long) this.handle & (long) uint.MaxValue);

  public int GetSliceIndex() => (int) (this.handle >> 32 /*0x20*/);
}
