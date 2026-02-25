// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.BatchMaterialID
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
public struct BatchMaterialID
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Null;
  private static readonly System.IntPtr NativeFieldInfoPtr_value;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0;
  [FieldOffset(0)]
  public uint value;

  static BatchMaterialID()
  {
    Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (BatchMaterialID));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr);
    BatchMaterialID.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, nameof (Null));
    BatchMaterialID.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, nameof (value));
    BatchMaterialID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100670280);
    BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100670281);
    BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100670282);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487086, XrefRangeEnd = 487091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(BatchMaterialID other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe BatchMaterialID Null
  {
    get
    {
      BatchMaterialID batchMaterialId;
      IL2CPP.il2cpp_field_static_get_value(BatchMaterialID.NativeFieldInfoPtr_Null, (void*) &batchMaterialId);
      return batchMaterialId;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(BatchMaterialID.NativeFieldInfoPtr_Null, (void*) &value);
    }
  }

  public int CompareTo(BatchMaterialID other) => this.value.CompareTo(other.value);

  public static bool operator ==(BatchMaterialID a, BatchMaterialID b) => a.Equals(b);

  public static bool operator !=(BatchMaterialID a, BatchMaterialID b) => !a.Equals(b);
}
