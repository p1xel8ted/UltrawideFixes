// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.DepthState
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
public struct DepthState
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_WriteEnabled;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_CompareFunction;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public byte m_WriteEnabled;
  [FieldOffset(1)]
  public sbyte m_CompareFunction;

  static DepthState()
  {
    Il2CppClassPointerStore<DepthState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (DepthState));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthState>.NativeClassPtr);
    DepthState.NativeFieldInfoPtr_m_WriteEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthState>.NativeClassPtr, nameof (m_WriteEnabled));
    DepthState.NativeFieldInfoPtr_m_CompareFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthState>.NativeClassPtr, nameof (m_CompareFunction));
    DepthState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100670368);
    DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100670369);
    DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100670370);
    DepthState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthState>.NativeClassPtr, 100670371);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487559, XrefRangeEnd = 487563, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DepthState(bool writeEnabled = true, CompareFunction compareFunction = CompareFunction.Less)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &writeEnabled;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &compareFunction;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr__ctor_Public_Void_Boolean_CompareFunction_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(DepthState other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepthState_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487563, XrefRangeEnd = 487566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487566, XrefRangeEnd = 487568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DepthState.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepthState>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static DepthState defaultValue => new DepthState();

  public bool writeEnabled
  {
    get => Il2CppSystem.Convert.ToBoolean(this.m_WriteEnabled);
    set => this.m_WriteEnabled = Il2CppSystem.Convert.ToByte(value);
  }

  public CompareFunction compareFunction
  {
    get => (CompareFunction) this.m_CompareFunction;
    set => this.m_CompareFunction = (sbyte) value;
  }

  public static bool operator ==(DepthState left, DepthState right) => left.Equals(right);

  public static bool operator !=(DepthState left, DepthState right) => !left.Equals(right);
}
