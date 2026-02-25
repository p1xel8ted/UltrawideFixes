// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchMeshID
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
public struct BatchMeshID
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Null;
  private static readonly System.IntPtr NativeFieldInfoPtr_value;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0;
  [FieldOffset(0)]
  public uint value;

  static BatchMeshID()
  {
    Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchMeshID));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr);
    BatchMeshID.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, nameof (Null));
    BatchMeshID.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, nameof (value));
    BatchMeshID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100670284);
    BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100670285);
    BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100670286);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487091, XrefRangeEnd = 487096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(BatchMeshID other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe BatchMeshID Null
  {
    get
    {
      BatchMeshID batchMeshId;
      IL2CPP.il2cpp_field_static_get_value(BatchMeshID.NativeFieldInfoPtr_Null, (void*) &batchMeshId);
      return batchMeshId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BatchMeshID.NativeFieldInfoPtr_Null, (void*) &value);
    }
  }

  public int CompareTo(BatchMeshID other) => this.value.CompareTo(other.value);

  public static bool operator ==(BatchMeshID a, BatchMeshID b) => a.Equals(b);

  public static bool operator !=(BatchMeshID a, BatchMeshID b) => !a.Equals(b);
}
