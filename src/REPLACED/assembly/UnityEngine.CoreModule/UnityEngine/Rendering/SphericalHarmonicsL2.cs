// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SphericalHarmonicsL2
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct SphericalHarmonicsL2
{
  private static readonly System.IntPtr NativeFieldInfoPtr_shr0;
  private static readonly System.IntPtr NativeFieldInfoPtr_shr1;
  private static readonly System.IntPtr NativeFieldInfoPtr_shr2;
  private static readonly System.IntPtr NativeFieldInfoPtr_shr3;
  private static readonly System.IntPtr NativeFieldInfoPtr_shr4;
  private static readonly System.IntPtr NativeFieldInfoPtr_shr5;
  private static readonly System.IntPtr NativeFieldInfoPtr_shr6;
  private static readonly System.IntPtr NativeFieldInfoPtr_shr7;
  private static readonly System.IntPtr NativeFieldInfoPtr_shr8;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg0;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg1;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg2;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg3;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg4;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg5;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg6;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg7;
  private static readonly System.IntPtr NativeFieldInfoPtr_shg8;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb0;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb1;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb2;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb3;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb4;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb5;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb6;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb7;
  private static readonly System.IntPtr NativeFieldInfoPtr_shb8;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0;
  [FieldOffset(0)]
  public float shr0;
  [FieldOffset(4)]
  public float shr1;
  [FieldOffset(8)]
  public float shr2;
  [FieldOffset(12)]
  public float shr3;
  [FieldOffset(16 /*0x10*/)]
  public float shr4;
  [FieldOffset(20)]
  public float shr5;
  [FieldOffset(24)]
  public float shr6;
  [FieldOffset(28)]
  public float shr7;
  [FieldOffset(32 /*0x20*/)]
  public float shr8;
  [FieldOffset(36)]
  public float shg0;
  [FieldOffset(40)]
  public float shg1;
  [FieldOffset(44)]
  public float shg2;
  [FieldOffset(48 /*0x30*/)]
  public float shg3;
  [FieldOffset(52)]
  public float shg4;
  [FieldOffset(56)]
  public float shg5;
  [FieldOffset(60)]
  public float shg6;
  [FieldOffset(64 /*0x40*/)]
  public float shg7;
  [FieldOffset(68)]
  public float shg8;
  [FieldOffset(72)]
  public float shb0;
  [FieldOffset(76)]
  public float shb1;
  [FieldOffset(80 /*0x50*/)]
  public float shb2;
  [FieldOffset(84)]
  public float shb3;
  [FieldOffset(88)]
  public float shb4;
  [FieldOffset(92)]
  public float shb5;
  [FieldOffset(96 /*0x60*/)]
  public float shb6;
  [FieldOffset(100)]
  public float shb7;
  [FieldOffset(104)]
  public float shb8;
  private static readonly SphericalHarmonicsL2.SetZeroDelegate SetZeroDelegateField;
  private static readonly SphericalHarmonicsL2.AddAmbientLight_InjectedDelegate AddAmbientLight_InjectedDelegateField;
  private static readonly SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegate AddDirectionalLightInternal_InjectedDelegateField;
  private static readonly SphericalHarmonicsL2.EvaluateInternal_InjectedDelegate EvaluateInternal_InjectedDelegateField;

  static SphericalHarmonicsL2()
  {
    Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (SphericalHarmonicsL2));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr);
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr0));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr1));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr2));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr3));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr4));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr5));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr6));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr7));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shr8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shr8));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg0));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg1));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg2));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg3));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg4));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg5));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg6));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg7));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shg8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shg8));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb0));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb1));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb2));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb3));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb4));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb5));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb6));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb7));
    SphericalHarmonicsL2.NativeFieldInfoPtr_shb8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, nameof (shb8));
    SphericalHarmonicsL2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100670270);
    SphericalHarmonicsL2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100670271);
    SphericalHarmonicsL2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100670272);
    SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100670273);
    SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100670274);
    SphericalHarmonicsL2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, 100670275);
    SphericalHarmonicsL2.SetZeroDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.SetZeroDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::SetZero");
    SphericalHarmonicsL2.AddAmbientLight_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.AddAmbientLight_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::AddAmbientLight_Injected");
    SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::AddDirectionalLightInternal_Injected");
    SphericalHarmonicsL2.EvaluateInternal_InjectedDelegateField = IL2CPP.ResolveICall<SphericalHarmonicsL2.EvaluateInternal_InjectedDelegate>("UnityEngine.Rendering.SphericalHarmonicsL2::EvaluateInternal_Injected");
  }

  public unsafe float this[int rgb, int coefficient]
  {
    [CallerCount(69), CachedScanResults(RefRangeStart = 486954, RefRangeEnd = 487023, XrefRangeStart = 486954, XrefRangeEnd = 486954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &rgb;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &coefficient;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_get_Item_Public_get_Single_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(24), CachedScanResults(RefRangeStart = 487023, RefRangeEnd = 487047, XrefRangeStart = 487023, XrefRangeEnd = 487023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &rgb;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &coefficient;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487047, XrefRangeEnd = 487074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487074, XrefRangeEnd = 487078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487078, XrefRangeEnd = 487079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(SphericalHarmonicsL2 other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SphericalHarmonicsL2_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487079, RefRangeEnd = 487081, XrefRangeStart = 487079, XrefRangeEnd = 487079, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SphericalHarmonicsL2.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SphericalHarmonicsL2_SphericalHarmonicsL2_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SphericalHarmonicsL2>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public void Clear() => this.SetZero();

  public void SetZero()
  {
    SphericalHarmonicsL2.SetZeroDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) ref this));
  }

  public void AddAmbientLight(Color color)
  {
    SphericalHarmonicsL2.AddAmbientLight_Injected(ref this, ref color);
  }

  public void AddDirectionalLight(Vector3 direction, Color color, float intensity)
  {
    Color color1 = color * (2f * intensity);
    SphericalHarmonicsL2.AddDirectionalLightInternal(ref this, direction, color1);
  }

  public static void AddDirectionalLightInternal(
    ref SphericalHarmonicsL2 sh,
    Vector3 direction,
    Color color)
  {
    SphericalHarmonicsL2.AddDirectionalLightInternal_Injected(ref sh, ref direction, ref color);
  }

  public void Evaluate(Il2CppStructArray<Vector3> directions, Il2CppStructArray<Color> results)
  {
    if (directions == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (directions));
    if (results == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (results));
    if (((Il2CppArrayBase) directions).Length == 0)
      return;
    if (((Il2CppArrayBase) directions).Length != ((Il2CppArrayBase) results).Length)
      throw new Il2CppSystem.ArgumentException("Length of the directions array and the results array must match.");
    SphericalHarmonicsL2.EvaluateInternal(ref this, directions, results);
  }

  public static void EvaluateInternal(
    ref SphericalHarmonicsL2 sh,
    Il2CppStructArray<Vector3> directions,
    [Out] Il2CppStructArray<Color> results)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static SphericalHarmonicsL2 operator *(SphericalHarmonicsL2 lhs, float rhs)
  {
    return new SphericalHarmonicsL2()
    {
      shr0 = lhs.shr0 * rhs,
      shr1 = lhs.shr1 * rhs,
      shr2 = lhs.shr2 * rhs,
      shr3 = lhs.shr3 * rhs,
      shr4 = lhs.shr4 * rhs,
      shr5 = lhs.shr5 * rhs,
      shr6 = lhs.shr6 * rhs,
      shr7 = lhs.shr7 * rhs,
      shr8 = lhs.shr8 * rhs,
      shg0 = lhs.shg0 * rhs,
      shg1 = lhs.shg1 * rhs,
      shg2 = lhs.shg2 * rhs,
      shg3 = lhs.shg3 * rhs,
      shg4 = lhs.shg4 * rhs,
      shg5 = lhs.shg5 * rhs,
      shg6 = lhs.shg6 * rhs,
      shg7 = lhs.shg7 * rhs,
      shg8 = lhs.shg8 * rhs,
      shb0 = lhs.shb0 * rhs,
      shb1 = lhs.shb1 * rhs,
      shb2 = lhs.shb2 * rhs,
      shb3 = lhs.shb3 * rhs,
      shb4 = lhs.shb4 * rhs,
      shb5 = lhs.shb5 * rhs,
      shb6 = lhs.shb6 * rhs,
      shb7 = lhs.shb7 * rhs,
      shb8 = lhs.shb8 * rhs
    };
  }

  public static SphericalHarmonicsL2 operator *(float lhs, SphericalHarmonicsL2 rhs)
  {
    return new SphericalHarmonicsL2()
    {
      shr0 = rhs.shr0 * lhs,
      shr1 = rhs.shr1 * lhs,
      shr2 = rhs.shr2 * lhs,
      shr3 = rhs.shr3 * lhs,
      shr4 = rhs.shr4 * lhs,
      shr5 = rhs.shr5 * lhs,
      shr6 = rhs.shr6 * lhs,
      shr7 = rhs.shr7 * lhs,
      shr8 = rhs.shr8 * lhs,
      shg0 = rhs.shg0 * lhs,
      shg1 = rhs.shg1 * lhs,
      shg2 = rhs.shg2 * lhs,
      shg3 = rhs.shg3 * lhs,
      shg4 = rhs.shg4 * lhs,
      shg5 = rhs.shg5 * lhs,
      shg6 = rhs.shg6 * lhs,
      shg7 = rhs.shg7 * lhs,
      shg8 = rhs.shg8 * lhs,
      shb0 = rhs.shb0 * lhs,
      shb1 = rhs.shb1 * lhs,
      shb2 = rhs.shb2 * lhs,
      shb3 = rhs.shb3 * lhs,
      shb4 = rhs.shb4 * lhs,
      shb5 = rhs.shb5 * lhs,
      shb6 = rhs.shb6 * lhs,
      shb7 = rhs.shb7 * lhs,
      shb8 = rhs.shb8 * lhs
    };
  }

  public static SphericalHarmonicsL2 operator +(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
  {
    return new SphericalHarmonicsL2()
    {
      shr0 = lhs.shr0 + rhs.shr0,
      shr1 = lhs.shr1 + rhs.shr1,
      shr2 = lhs.shr2 + rhs.shr2,
      shr3 = lhs.shr3 + rhs.shr3,
      shr4 = lhs.shr4 + rhs.shr4,
      shr5 = lhs.shr5 + rhs.shr5,
      shr6 = lhs.shr6 + rhs.shr6,
      shr7 = lhs.shr7 + rhs.shr7,
      shr8 = lhs.shr8 + rhs.shr8,
      shg0 = lhs.shg0 + rhs.shg0,
      shg1 = lhs.shg1 + rhs.shg1,
      shg2 = lhs.shg2 + rhs.shg2,
      shg3 = lhs.shg3 + rhs.shg3,
      shg4 = lhs.shg4 + rhs.shg4,
      shg5 = lhs.shg5 + rhs.shg5,
      shg6 = lhs.shg6 + rhs.shg6,
      shg7 = lhs.shg7 + rhs.shg7,
      shg8 = lhs.shg8 + rhs.shg8,
      shb0 = lhs.shb0 + rhs.shb0,
      shb1 = lhs.shb1 + rhs.shb1,
      shb2 = lhs.shb2 + rhs.shb2,
      shb3 = lhs.shb3 + rhs.shb3,
      shb4 = lhs.shb4 + rhs.shb4,
      shb5 = lhs.shb5 + rhs.shb5,
      shb6 = lhs.shb6 + rhs.shb6,
      shb7 = lhs.shb7 + rhs.shb7,
      shb8 = lhs.shb8 + rhs.shb8
    };
  }

  public static bool operator !=(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs)
  {
    return !(lhs == rhs);
  }

  public static void AddAmbientLight_Injected(ref SphericalHarmonicsL2 _unity_self, [In] ref Color color)
  {
    SphericalHarmonicsL2.AddAmbientLight_InjectedDelegateField((System.IntPtr) ref _unity_self, (System.IntPtr) ref color);
  }

  public static void AddDirectionalLightInternal_Injected(
    ref SphericalHarmonicsL2 sh,
    [In] ref Vector3 direction,
    [In] ref Color color)
  {
    SphericalHarmonicsL2.AddDirectionalLightInternal_InjectedDelegateField((System.IntPtr) ref sh, (System.IntPtr) ref direction, (System.IntPtr) ref color);
  }

  public static void EvaluateInternal_Injected(
    ref SphericalHarmonicsL2 sh,
    ref ManagedSpanWrapper directions,
    out BlittableArrayWrapper results)
  {
    SphericalHarmonicsL2.EvaluateInternal_InjectedDelegateField((System.IntPtr) ref sh, (System.IntPtr) ref directions, (System.IntPtr) ref results);
  }

  private delegate void SetZeroDelegate(System.IntPtr _param1);

  private delegate void AddAmbientLight_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr color);

  private delegate void AddDirectionalLightInternal_InjectedDelegate(
    System.IntPtr sh,
    [In] System.IntPtr direction,
    [In] System.IntPtr color);

  private delegate void EvaluateInternal_InjectedDelegate(
    System.IntPtr sh,
    System.IntPtr directions,
    [Out] System.IntPtr results);
}
