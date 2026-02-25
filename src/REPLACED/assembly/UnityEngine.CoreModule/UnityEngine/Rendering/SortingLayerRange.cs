// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.SortingLayerRange
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
public struct SortingLayerRange
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_LowerBound;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UpperBound;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public short m_LowerBound;
  [FieldOffset(2)]
  public short m_UpperBound;

  static SortingLayerRange()
  {
    Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (SortingLayerRange));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr);
    SortingLayerRange.NativeFieldInfoPtr_m_LowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, nameof (m_LowerBound));
    SortingLayerRange.NativeFieldInfoPtr_m_UpperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, nameof (m_UpperBound));
    SortingLayerRange.NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100670579);
    SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100670580);
    SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100670581);
    SortingLayerRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, 100670582);
  }

  public static unsafe SortingLayerRange all
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_get_all_Public_Static_get_SortingLayerRange_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(SortingLayerRange*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(SortingLayerRange other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SortingLayerRange_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 488685, XrefRangeEnd = 488688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SortingLayerRange.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SortingLayerRange>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public short lowerBound
  {
    get => this.m_LowerBound;
    set => this.m_LowerBound = value;
  }

  public short upperBound
  {
    get => this.m_UpperBound;
    set => this.m_UpperBound = value;
  }

  public static bool operator !=(SortingLayerRange lhs, SortingLayerRange rhs) => !lhs.Equals(rhs);

  public static bool operator ==(SortingLayerRange lhs, SortingLayerRange rhs) => lhs.Equals(rhs);
}
